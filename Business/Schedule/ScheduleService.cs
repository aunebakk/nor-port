using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using SolutionNorSolutionPort.DataAccessLayer;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [ServiceContract()]
    public interface IScheduleService
    {
        [OperationContract()]
        void MakeFlightsFromScheduleAll(
            Guid userId
            );

        [OperationContract()]
        void MakeFlightsFromSchedule(
            Guid flightScheduleId,
            Guid userId
            );

        [OperationContract()]
        ScheduleContract GetSchedule(
            Guid flightScheduleId,
            Guid userId
            );

        [OperationContract()]
        void CreateSchedule(
            ScheduleContract scheduleContract,
            Guid userId
            );

        [OperationContract()]
        void UpdateSchedule(
            ScheduleContract scheduleContract,
            Guid userId
            );
    }

    public class ScheduleService : IScheduleService
    {

        /// <summary>Get schedule record including identifiers and segments in displayable and updatable arrays</summary>
        /// <summary>Action log event inserted, exceptions logged</summary>
        /// <cardinality>One</cardinality>
        public ScheduleContract GetSchedule(
            Guid flightScheduleId,
            Guid userId
            ) {
            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.ScheduleService.GetSchedule",
                                userId
                                );

            var schedule = 
                    new ScheduleContract();

            try {
                // flight schedule
                schedule.FlightSchedule =
                    new CrudeFlightScheduleService().FetchByFlightScheduleId(flightScheduleId);

                // segments
                schedule.FlightScheduleSegments =
                    new ScheduleSearchService().FlightSegmentsSchedule(flightScheduleId).ToArray();

                schedule.CrudeFlightScheduleSegments =
                    new CrudeFlightScheduleSegmentService().FetchByFlightScheduleId(flightScheduleId).ToArray();

                // flight identifier
                CrudeFlightScheduleIdentifierContract[] flightIdentifiers =
                        new CrudeFlightScheduleIdentifierService().FetchByFlightScheduleId(flightScheduleId).ToArray();

                // todo, can be more than one, use the one if existing, or make an empty one, should have room for more than one
                if ( flightIdentifiers.Length > 0 )
                    schedule.FlightScheduleIdentifier = flightIdentifiers[0];
                else
                    schedule.FlightScheduleIdentifier = new CrudeFlightScheduleIdentifierContract();

            } catch ( Exception ex ) {
                Logging.ErrorLog("Schedule",
                                    "ScheduleService",
                                    "GetSchedule",
                                    ex.Message,
                                    ex.StackTrace,
                                    userId
                                    );
                throw ex;
            }

            return schedule;
        }

        /// <summary>Create schedule record including identifiers</summary>
        /// <summary>Action log event inserted, exceptions logged</summary>
        public void CreateSchedule(
            ScheduleContract scheduleContract,
            Guid userId
            ) {

            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.ScheduleService.CreateSchedule",
                                userId
                                );

            // start transaction
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // insert flight schedule
                    var crudeFlightScheduleData = new CrudeFlightScheduleData();
                    CrudeFlightScheduleService.ContractToData(
                        scheduleContract.FlightSchedule,
                        crudeFlightScheduleData
                        );

                    crudeFlightScheduleData.FlightScheduleId = Guid.NewGuid();

                    // first flight schedule id has equal flight schedule id
                    crudeFlightScheduleData.BindingFlightScheduleId = crudeFlightScheduleData.FlightScheduleId;

                    crudeFlightScheduleData.UserId = userId;
                    crudeFlightScheduleData.DateTime = DateTime.UtcNow;
                    crudeFlightScheduleData.Insert(connection, transaction);

                    // insert flight identifier, if existing
                    // todo, there can be more than one identifier
                    if ( !String.IsNullOrEmpty(scheduleContract.FlightScheduleIdentifier.FlightIdentifierCode) ) {
                        var crudeFlightScheduleIdentifierData = new CrudeFlightScheduleIdentifierData();
                        crudeFlightScheduleIdentifierData.FlightScheduleId = crudeFlightScheduleData.FlightScheduleId;
                        crudeFlightScheduleIdentifierData.FlightIdentifierCode = scheduleContract.FlightScheduleIdentifier.FlightIdentifierCode;
                        crudeFlightScheduleIdentifierData.FlightIdentifierTypeRcd = FlightIdentifierTypeRef.FlightNumberThree;
                        crudeFlightScheduleIdentifierData.DateTime = DateTime.UtcNow;
                        crudeFlightScheduleIdentifierData.UserId = userId;
                        crudeFlightScheduleIdentifierData.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();
                } catch ( Exception ex ) {
                    transaction.Rollback();
                    Logging.ErrorLog("Schedule",
                                        "ScheduleService",
                                        "CreateSchedule",
                                        ex.Message,
                                        ex.StackTrace,
                                        userId
                                        );
                    throw ex;
                }
            }
        }

        /// <summary>Update schedule record including identifiers</summary>
        /// <summary>Identifier will be created if not existing</summary>
        /// <summary>Action log event inserted, exceptions logged</summary>
        public void UpdateSchedule(
            ScheduleContract scheduleContract,
            Guid userId
            ) {

            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.ScheduleService.UpdateSchedule",
                                userId
                                );

            // make sure this is not an historical record
            if ( scheduleContract.FlightSchedule.BecameFlightScheduleId != Guid.Empty ) {
                Logging.ErrorLog("Schedule",
                                    "ScheduleService",
                                    "UpdateSchedule",
                                    "Schedule.UpdateSchedule: Can not update a history schedule flight record",
                                    string.Empty,
                                    userId
                                    );

                throw new Exception("Schedule.UpdateSchedule: Can not update a history schedule flight record");
            }

            // start transaction
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // insert new flight schedule
                    var crudeNewFlightScheduleData = new CrudeFlightScheduleData();
                    CrudeFlightScheduleService.ContractToData(
                        scheduleContract.FlightSchedule,
                        crudeNewFlightScheduleData
                        );

                    crudeNewFlightScheduleData.FlightScheduleId = Guid.NewGuid();

                    // binding flight schedule id carries on forward
                    crudeNewFlightScheduleData.BindingFlightScheduleId = scheduleContract.FlightSchedule.BindingFlightScheduleId;

                    crudeNewFlightScheduleData.UserId = userId;
                    crudeNewFlightScheduleData.DateTime = DateTime.UtcNow;
                    crudeNewFlightScheduleData.Insert(connection, transaction);

                    // insert new identifier
                    // todo, can be more than one
                    if ( scheduleContract.FlightScheduleIdentifier.FlightIdentifierCode != string.Empty ) {
                        var crudeNewFlightScheduleIdentifierData = new CrudeFlightScheduleIdentifierData();

                        CrudeFlightScheduleIdentifierService.ContractToData(
                            scheduleContract.FlightScheduleIdentifier,
                            crudeNewFlightScheduleIdentifierData
                            );

                        crudeNewFlightScheduleIdentifierData.FlightScheduleIdentifierId = Guid.NewGuid();
                        crudeNewFlightScheduleIdentifierData.FlightScheduleId = crudeNewFlightScheduleData.FlightScheduleId;
                        crudeNewFlightScheduleIdentifierData.FlightIdentifierTypeRcd = FlightIdentifierTypeRef.FlightNumberThree;
                        crudeNewFlightScheduleIdentifierData.DateTime = DateTime.UtcNow;
                        crudeNewFlightScheduleIdentifierData.UserId = userId;
                        crudeNewFlightScheduleIdentifierData.Insert(connection, transaction);
                    }

                    // update old flight schedule 'became' identifier
                    var crudeOldFlightScheduleData = new CrudeFlightScheduleData();
                    crudeOldFlightScheduleData.FetchByFlightScheduleId(scheduleContract.FlightSchedule.FlightScheduleId);
                    crudeOldFlightScheduleData.BecameFlightScheduleId = crudeNewFlightScheduleData.FlightScheduleId;
                    crudeOldFlightScheduleData.Update(connection, transaction);

                    // copy schedule segments
                    List<CrudeFlightScheduleSegmentData> crudeFlightScheduleSegmentsData = 
                        CrudeFlightScheduleSegmentData.FetchByFlightScheduleId(
                            scheduleContract.FlightSchedule.FlightScheduleId
                            );

                    foreach ( CrudeFlightScheduleSegmentData crudeFlightScheduleSegmentData in crudeFlightScheduleSegmentsData ) {
                        crudeFlightScheduleSegmentData.FlightScheduleSegmentId = Guid.NewGuid();
                        crudeFlightScheduleSegmentData.FlightScheduleId = crudeNewFlightScheduleData.FlightScheduleId;
                        crudeFlightScheduleSegmentData.DateTime = DateTime.UtcNow;
                        crudeFlightScheduleSegmentData.UserId = userId;
                        crudeFlightScheduleSegmentData.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    Logging.ErrorLog("Schedule",
                                        "ScheduleService",
                                        "UpdateSchedule",
                                        ex.Message,
                                        ex.StackTrace,
                                        userId
                                        );
                    throw ex;
                }
            }
        }

        public void MakeFlightsFromScheduleAll(
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Schedule", "BusinessLogicLayer", "ScheduleService", "MakeFlightsFromScheduleAll", userId);

            try { 
                var scheduleList = new CrudeFlightScheduleService().FetchAll();
                foreach ( var scheduleItem in scheduleList ) {
                    if ( scheduleItem.BecameFlightScheduleId == Guid.Empty )
                        MakeFlightsFromSchedule(
                            scheduleItem.FlightScheduleId,
                            userId
                            );
                }
            } catch ( Exception ex ) {
                log.Error(ex);
                throw ex;
            }

            log.PerformanceTimeStop();
        }

        /// <summary>Create all flights based on schedule record</summary>
        /// <summary>Schedule main dates will be used if segments does not exist</summary>
        /// <summary>Identifiers are taken from schedule</summary>
        /// <summary>Segments are taken from schedule if existing, default segment created if not</summary>
        /// <summary>Flight and segment 'created' events inserted</summary>
        /// <summary>Action log event inserted, exceptions logged</summary>
        public void MakeFlightsFromSchedule(
            Guid flightScheduleId,
            Guid userId
            ) {

            Logging.ActionLog("SolutionNorSolutionPort.BusinessLogicLayer.ScheduleService.MakeFlightsFromSchedule",
                              userId
                              );

            // get schedule
            ScheduleContract scheduleContract = GetSchedule(flightScheduleId, userId);

            // make sure there are segments
            if ( scheduleContract.CrudeFlightScheduleSegments.Length == 0 ) {
                Logging.ErrorLog("Schedule",
                                    "ScheduleService",
                                    "MakeFlightsFromSchedule",
                                    "Schedule.MakeFlightsFromSchedule: There are no segments on schedule",
                                    string.Empty,
                                    userId
                                    );

                throw new Exception("Schedule.MakeFlightsFromSchedule: There are no segments on schedule");
            }

            // make sure there is at least one identifier
            if ( scheduleContract.FlightScheduleIdentifier == null ||
                scheduleContract.FlightScheduleIdentifier.FlightScheduleIdentifierId == Guid.Empty ) {
                Logging.ErrorLog("Schedule",
                                    "ScheduleService",
                                    "MakeFlightsFromSchedule",
                                    "Schedule.MakeFlightsFromSchedule: There are no flight identifiers",
                                    string.Empty,
                                    userId
                                    );

                throw new Exception("Schedule.MakeFlightsFromSchedule: There are no flight identifiers");
            }

            // get first aircraft available, TODO
            List<CrudeAircraftContract> aircrafts = new CrudeAircraftService().FetchAll();
            if ( aircrafts.Count == 0 ) {
                Logging.ErrorLog("Schedule",
                                    "ScheduleService",
                                    "MakeFlightsFromSchedule",
                                    "Schedule.MakeFlightsFromSchedule: There are no aircrafts available",
                                    string.Empty,
                                    userId
                                    );

                throw new Exception("Schedule.MakeFlightsFromSchedule: There are no aircrafts available");
            }

            // start transaction
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // iterate all dates between from / until
                    //DateTime currentDate = scheduleContract.FlightSchedule.FromDateTime.Date;
                    DateTime currentDate = DateTime.UtcNow.Date;

                    while ( currentDate >= scheduleContract.FlightSchedule.FromDateTime.Date
                            && currentDate <= scheduleContract.FlightSchedule.UntilDateTime ) {

                        // make new flight
                        var flight = new CrudeFlightData();
                        flight.FlightId = Guid.NewGuid();
                        flight.BindingFlightId = flight.FlightId;
                        flight.AirlineId = scheduleContract.FlightSchedule.AirlineId;
                        flight.AircraftId = aircrafts[0].AircraftId;
                        flight.AircraftTypeRcd = scheduleContract.FlightSchedule.AircraftTypeRcd;
                        flight.DepartureAirportId = scheduleContract.FlightSchedule.DepartureAirportId;
                        flight.ArrivalAirportId = scheduleContract.FlightSchedule.ArrivalAirportId;

                        // compose flight date time departure / arrival time from first and last segment 
                        // todo, what about day shift +- 
                        flight.FromDateTime = currentDate.Add(
                            scheduleContract.FlightScheduleSegments[0].DepartureTime
                            );

                        flight.UntilDateTime = currentDate.Add(
                            scheduleContract.FlightScheduleSegments[scheduleContract.FlightScheduleSegments.Length - 1].ArrivalTime
                            );

                        flight.Comment = scheduleContract.FlightSchedule.Comment;
                        flight.DateTime = DateTime.UtcNow;
                        flight.UserId = userId;

                        // make sure flight does not exist
                        List<CrudeFlightData> flightDataList =
                            CrudeFlightData.FetchWithFilter(
                                flightId: Guid.Empty,
                                becameFlightId: Guid.Empty,
                                bindingFlightId: Guid.Empty,
                                airlineId: flight.AirlineId,
                                aircraftId: flight.AircraftId,
                                aircraftTypeRcd: string.Empty,
                                departureAirportId: flight.DepartureAirportId,
                                arrivalAirportId: flight.ArrivalAirportId,
                                fromDateTime: flight.FromDateTime,
                                untilDateTime: flight.UntilDateTime,
                                comment: string.Empty,
                                userId: Guid.Empty,
                                dateTime: DateTime.MinValue
                                );

                        if (flightDataList.Count != 0)
                            continue;

                        flight.Insert(connection, transaction);

                        // flight identifier 
                        // todo, can be more than one
                        var identifier = new CrudeFlightIdentifierData();
                        identifier.FlightIdentifierTypeRcd = scheduleContract.FlightScheduleIdentifier.FlightIdentifierTypeRcd;
                        identifier.FlightIdentifierCode = scheduleContract.FlightScheduleIdentifier.FlightIdentifierCode;
                        identifier.FlightId = flight.FlightId;
                        identifier.UserId = userId;
                        identifier.DateTime = DateTime.UtcNow;
                        identifier.Insert(connection, transaction);

                        // events
                        AddFlightEvent(connection, transaction, flight.FlightId, DateTimeTypeRef.Created, DateTime.UtcNow, userId);

                        // planned / estimated times
                        AddFlightEvent(connection, transaction, flight.FlightId, DateTimeTypeRef.PlannedDeparture, flight.FromDateTime, userId);
                        AddFlightEvent(connection, transaction, flight.FlightId, DateTimeTypeRef.PlannedArrival, flight.UntilDateTime, userId);
                        AddFlightEvent(connection, transaction, flight.FlightId, DateTimeTypeRef.EstimatedDeparture, flight.FromDateTime, userId);
                        AddFlightEvent(connection, transaction, flight.FlightId, DateTimeTypeRef.EstimatedArrival, flight.UntilDateTime, userId);

                        // open for booking
                        AddFlightEvent(connection, transaction, flight.FlightId, DateTimeTypeRef.BookingOpen, DateTime.UtcNow, userId);

                        // check rules

                        // create flight segments for that day
                        foreach ( CrudeFlightScheduleSegmentContract scheduleSegment in scheduleContract.CrudeFlightScheduleSegments ) {
                            var flightSegment = new CrudeFlightSegmentData();
                            flightSegment.FlightSegmentId = Guid.NewGuid();
                            flightSegment.FlightId = flight.FlightId;
                            flightSegment.DepartureAirportId = scheduleSegment.DepartureAirportId;
                            flightSegment.ArrivalAirportId = scheduleSegment.ArrivalAirportId;
                            flightSegment.LogicalSegmentNumber = scheduleSegment.LogicalSegmentNumber;
                            flightSegment.PhysicalSegmentNumber = scheduleSegment.PhysicalSegmentNumber;
                            flightSegment.FromDateTime = currentDate.Add(scheduleSegment.DepartureTime);
                            flightSegment.UntilDateTime = currentDate.Add(scheduleSegment.ArrivalTime);
                            flightSegment.DepartureGate = scheduleSegment.DepartureGate;
                            flightSegment.ArrivalGate = scheduleSegment.ArrivalGate;
                            flightSegment.UserId = userId;
                            flightSegment.DateTime = DateTime.UtcNow;
                            flightSegment.Insert(connection, transaction);

                            // events
                            AddFlightSegmentEvent(connection, transaction, flightSegment.FlightSegmentId, DateTimeTypeRef.Created, DateTime.UtcNow, userId);

                            // planned / estimated times
                            AddFlightSegmentEvent(connection, transaction, flightSegment.FlightSegmentId, DateTimeTypeRef.PlannedDeparture, flightSegment.FromDateTime, userId);
                            AddFlightSegmentEvent(connection, transaction, flightSegment.FlightSegmentId, DateTimeTypeRef.PlannedArrival, flightSegment.UntilDateTime, userId);
                            AddFlightSegmentEvent(connection, transaction, flightSegment.FlightSegmentId, DateTimeTypeRef.EstimatedDeparture, flightSegment.FromDateTime, userId);
                            AddFlightSegmentEvent(connection, transaction, flightSegment.FlightSegmentId, DateTimeTypeRef.EstimatedArrival, flightSegment.UntilDateTime, userId);

                            // open for booking
                            AddFlightSegmentEvent(connection, transaction, flightSegment.FlightSegmentId, DateTimeTypeRef.BookingOpen, DateTime.UtcNow, userId);
                        }

                        currentDate = currentDate.AddDays(1);

                        break; // break here since we are testing with a fresh database where from date is todays date
                    }

                    // commit transaction
                    transaction.Commit();
                } catch ( Exception ex ) {
                    transaction.Rollback();
                    Logging.ErrorLog("Schedule",
                                        "ScheduleService",
                                        "MakeFlightsFromSchedule",
                                        ex.Message,
                                        ex.StackTrace,
                                        userId
                                        );
                    throw ex;
                }
            }
        }

        public void AddFlightEvent(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid flightId,
            string dateTimeTypeRcd,
            DateTime dateTimeOfEvent,
            Guid userId
            ) {

            var flightEvent = new CrudeFlightEventData();
            flightEvent.FlightId = flightId;

            flightEvent.FlightEventNumber =
                Flight.FlightEventHighestNumber(
                    connection,
                    transaction,
                    flightId
                    ) + 1;

            flightEvent.DateTimeTypeRcd = dateTimeTypeRcd;
            flightEvent.NewDateTime = dateTimeOfEvent;
            flightEvent.DateTime = DateTime.UtcNow;
            flightEvent.UserId = userId;
            flightEvent.Insert(connection, transaction);
        }

        public void AddFlightSegmentEvent(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid flightSegmentId,
            string dateTimeTypeRcd,
            DateTime dateTimeOfEvent,
            Guid userId
            ) {

            var flightSegmentEvent = new CrudeFlightSegmentEventData();
            flightSegmentEvent.FlightSegmentId = flightSegmentId;

            flightSegmentEvent.FlightSegmentEventNumber =
                Flight.FlightSegmentEventHighestNumber(
                    connection,
                    transaction,
                    flightSegmentId
                    ) + 1;

            flightSegmentEvent.DateTimeTypeRcd = dateTimeTypeRcd;
            flightSegmentEvent.NewDateTime = dateTimeOfEvent;
            flightSegmentEvent.DateTime = DateTime.UtcNow;
            flightSegmentEvent.UserId = userId;
            flightSegmentEvent.Insert(connection, transaction);
        }
    }
}
