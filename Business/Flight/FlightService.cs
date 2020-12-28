using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using SolutionNorSolutionPort.DataAccessLayer;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [ServiceContract()]
    public interface IFlightService
    {
        [OperationContract()]
        FlightContract GetFlight(
            Guid flightId,
            Guid userId
            );

        [OperationContract()]
        void UpdateFlight(
            FlightContract flightContract,
            Guid userId
            );

        [OperationContract()]
        void CheckFlightStatuses(
            DateTime dateFrom,
            DateTime dateUntil,
            Guid userId
            );
    }

    public class FlightService : IFlightService
    {
        /// <summary>Get schedule record including identifiers and segments in displayable and updatable arrays</summary>
        /// <summary>Action log event inserted, exceptions logged</summary>
        /// <cardinality>One</cardinality>
        public FlightContract GetFlight(
            Guid flightId,
            Guid userId
            ) {
            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.FlightService.GetFlight",
                                userId
                                );

            var flight = 
                    new FlightContract();

            try {
                // flight 
                flight.Flight =
                    new CrudeFlightService().FetchByFlightId(flightId);

                // segments
                /*
                flight.FlightSegments =
                    new ScheduleSearchService().FlightSegments(flight).ToArray();
                */

                flight.CrudeFlightSegments =
                    new CrudeFlightSegmentService().FetchByFlightId(flightId).ToArray();

                // flight identifier
                CrudeFlightIdentifierContract[] flightIdentifiers =
                        new CrudeFlightIdentifierService().FetchByFlightId(flightId).ToArray();

                // todo, can be more than one, use the one if existing, or make an empty one, should have room for more than one
                if ( flightIdentifiers.Length > 0 )
                    flight.FlightIdentifier = flightIdentifiers[0];
                else
                    flight.FlightIdentifier = new CrudeFlightIdentifierContract();

            } catch ( Exception ex ) {
                Logging.ErrorLog("Flight",
                                    "FlightService",
                                    "GetFlight",
                                    ex.Message,
                                    ex.StackTrace,
                                    userId
                                    );
                throw ex;
            }

            return flight;
        }

        public void UpdateFlight(
            FlightContract flightContract,
            Guid userId
            ) {

            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.FlightService.UpdateFlight",
                              userId
                              );

            // start transaction
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // insert new flight 
                    var crudeNewFlightData = new CrudeFlightData();
                    CrudeFlightService.ContractToData(
                        flightContract.Flight,
                        crudeNewFlightData
                        );

                    crudeNewFlightData.FlightId = Guid.NewGuid();

                    // binding flight id carries on forward
                    crudeNewFlightData.BindingFlightId = flightContract.Flight.BindingFlightId;

                    crudeNewFlightData.UserId = userId;
                    crudeNewFlightData.DateTime = DateTime.UtcNow;
                    crudeNewFlightData.Insert(connection, transaction);

                    // todo, can be more than one
                    if ( !String.IsNullOrEmpty(flightContract.FlightIdentifier.FlightIdentifierCode) ) {
                        var crudeNewFlightIdentifierData = new CrudeFlightIdentifierData();

                        CrudeFlightIdentifierService.ContractToData(
                            flightContract.FlightIdentifier,
                            crudeNewFlightIdentifierData
                            );

                        crudeNewFlightIdentifierData.FlightIdentifierId = Guid.NewGuid();
                        crudeNewFlightIdentifierData.FlightId = crudeNewFlightData.FlightId;
                        crudeNewFlightIdentifierData.FlightIdentifierTypeRcd = FlightIdentifierTypeRef.FlightNumberThree;
                        crudeNewFlightIdentifierData.DateTime = DateTime.UtcNow;
                        crudeNewFlightIdentifierData.UserId = userId;
                        crudeNewFlightIdentifierData.Insert(connection, transaction);
                    }

                    // update old flight schedule 'became' identifier
                    var crudeOldFlightData = new CrudeFlightData();
                    crudeOldFlightData.FetchByFlightId(flightContract.Flight.FlightId);
                    crudeOldFlightData.BecameFlightId = crudeNewFlightData.FlightId;
                    crudeOldFlightData.Update(connection, transaction);

                    // copy segments
                    List<CrudeFlightSegmentData> crudeFlightSegmentsData = 
                        CrudeFlightSegmentData.FetchByFlightId(
                            flightContract.Flight.FlightId
                            );

                    foreach ( CrudeFlightSegmentData crudeFlightSegmentData in crudeFlightSegmentsData ) {
                        crudeFlightSegmentData.FlightSegmentId = Guid.NewGuid();
                        crudeFlightSegmentData.FlightId = crudeNewFlightData.FlightId;
                        crudeFlightSegmentData.DateTime = DateTime.UtcNow;
                        crudeFlightSegmentData.UserId = userId;
                        crudeFlightSegmentData.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    Logging.ErrorLog("Flight",
                                        "FlightService",
                                        "UpdateFlight",
                                        ex.Message,
                                        ex.StackTrace,
                                        userId
                                        );
                    throw ex;
                }
            }
        }

        public void CheckFlightStatuses(
            DateTime dateFrom,
            DateTime dateUntil,
            Guid userId
            ) {

            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.FlightService.CheckFlightStatuses",
                              userId
                              );

            // get all flights in a date time range
            List<FlightsForPeriodSimpleData> flights = 
                FlightSearch.FlightsForPeriodSimple(
                    dateFrom,
                    dateUntil
                    );

            // get all flight segments in a date time range

            // start transaction
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    foreach ( FlightsForPeriodSimpleData flight in flights ) {
                        // todo, rules for cutoff times
                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.BookingClosed, TimeSpan.FromMinutes(30), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.BoardingOpen, TimeSpan.FromMinutes(30), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.LoadingInn, TimeSpan.FromMinutes(30), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.CheckInOpen, TimeSpan.FromMinutes(60 * 4), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.CheckInClosed, TimeSpan.FromMinutes(30), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.Takeoff, TimeSpan.FromMinutes(0), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.FlightFlown, TimeSpan.FromMinutes(-5), userId);

                        CheckFlightEventUntil(connection, transaction, flight, DateTimeTypeRef.Touchdown, TimeSpan.FromMinutes(0), userId);

                        CheckFlightEventUntil(connection, transaction, flight, DateTimeTypeRef.ActualArrival, TimeSpan.FromMinutes(-5), userId);

                        CheckFlightEventFrom(connection, transaction, flight, DateTimeTypeRef.LoadingOff, TimeSpan.FromMinutes(-5), userId);
                    }

                    // commit transaction
                    transaction.Commit();
                } catch ( Exception ex ) {
                    transaction.Rollback();
                    Logging.ErrorLog("Flight",
                                        "FlightService",
                                        "CheckFlightStatuses",
                                        ex.Message,
                                        ex.StackTrace,
                                        userId
                                        );
                    throw ex;
                }
            }
        }

        void CheckFlightEventFrom(
            SqlConnection connection,
            SqlTransaction transaction,
            FlightsForPeriodSimpleData flight,
            string dateTimeTypeRcd,
            TimeSpan cutoffTime,
            Guid userId
            ) {

            // cutoff date time is now +- cutoff time
            DateTime cutoffDateTime = DateTime.UtcNow.Add(cutoffTime);

            // is flight within cutoff 
            if ( flight.FromDateTime < cutoffDateTime ) {
                if ( !Flight.FlightEventExist(
                                connection,
                                transaction,
                                flight.FlightId,
                                dateTimeTypeRcd
                                )
                    ) {

                    // add flight event 
                    var scheduleService = new ScheduleService();
                    scheduleService.AddFlightEvent(
                        connection,
                        transaction,
                        flight.FlightId,
                        dateTimeTypeRcd,
                        cutoffDateTime,
                        userId
                        );
                }
            }
        }

        void CheckFlightEventUntil(
            SqlConnection connection,
            SqlTransaction transaction,
            FlightsForPeriodSimpleData flight,
            string dateTimeTypeRcd,
            TimeSpan cutoffTime,
            Guid userId
            ) {

            // cutoff date time is now +- cutoff time
            DateTime cutoffDateTime = DateTime.UtcNow.Add(cutoffTime);

            // is flight within cutoff 
            if ( flight.UntilDateTime < cutoffDateTime ) {
                if ( !Flight.FlightEventExist(
                                connection,
                                transaction,
                                flight.FlightId,
                                dateTimeTypeRcd
                                )
                    ) {

                    // add flight event 
                    var scheduleService = new ScheduleService();
                    scheduleService.AddFlightEvent(
                        connection,
                        transaction,
                        flight.FlightId,
                        dateTimeTypeRcd,
                        cutoffDateTime,
                        userId
                        );
                }
            }
        }
    }
}
