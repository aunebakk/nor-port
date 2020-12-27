using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides schedule search with different parameter and result sets
    /// </summary>
    /// <domain>Passenger</domain>
    public partial class PassengerSearch
    {
        /// <summary>Get all passengers on a booking</summary>
        /// <cardinality>Many</cardinality>
        public List<PassengersOnBookingData> PassengersOnBooking(Guid bookingId) {
            var ret = new List<PassengersOnBookingData>();

            string sql = @" 
                    select
                         pa.passenger_id
	                    ,pa.passenger_name
	                    ,ptr.passenger_type_name
                    from passenger as pa 
                    inner join passenger_type_ref as ptr on ptr.passenger_type_rcd = pa.passenger_type_rcd
                    inner join booking_passenger as bp on bp.passenger_id = pa.passenger_id
                    where bp.booking_id = @booking_id
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.PassengerSearch.PassengersOnBooking");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new PassengersOnBookingDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new PassengersOnBookingData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get all passengers on a flight</summary>
        /// <cardinality>Many</cardinality>
        public List<PassengersOnFlightData> PassengersOnFlight(
            Guid flightId
            ) {
            var ret = new List<PassengersOnFlightData>();

            string sql = @" 
                    select
						(	
							select top 1 booking_identifier_value
							from booking_identifier as bi
							where bi.booking_id = bp.booking_id
							  and bi.booking_identifier_type_rcd = dbo.ref('booking_identifier_type_ref.RL')
							order by bi.date_time desc
						) as record_locator
						,b.received_from
	                    ,pa.passenger_name
	                    ,ptr.passenger_type_name
						,dbo.BookingPassengerEventOneIsLast(
								bp.booking_passenger_id, 
								dbo.ref('booking_passenger_event_type_ref.CIFS'), 
								dbo.ref('booking_passenger_event_type_ref.COFS')
								)							    as checkedin_flag
                        ,pa.passenger_id
                        ,bp.booking_id
                        ,bp.booking_passenger_id
                        ,bfs.booking_flight_segment_id
                    from passenger						as pa 
                    inner join passenger_type_ref		as ptr	on ptr.passenger_type_rcd = pa.passenger_type_rcd
                    inner join booking_passenger		as bp	on	bp.passenger_id = pa.passenger_id
																and bp.became_booking_passenger_id is null
					inner join booking_flight_segment	as bfs	on bfs.booking_id = bp.booking_id
					inner join booking					as b	on b.booking_id = bp.booking_id
					inner join flight_segment			as fs	on fs.flight_segment_id = bfs.flight_segment_id

                    --realwhere

                    where fs.flight_id = @flight_id
					  and pa.became_passenger_id is null
					  and pa.default_state_rcd in (dbo.ref('default_state_ref.C'), dbo.ref('default_state_ref.U'))

					order by record_locator
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.PassengerSearch.PassengersOnFlight");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new PassengersOnFlightDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new PassengersOnFlightData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get all passengers on a flight</summary>
        /// <cardinality>Many</cardinality>
        public List<PassengersOnFlightCheckedInData> PassengersOnFlightCheckedIn(
            Guid flightId
            ) {
            var ret = new List<PassengersOnFlightCheckedInData>();

            string sql = @" 
                    select
						(	
							select top 1 booking_identifier_value
							from booking_identifier as bi
							where bi.booking_id = bp.booking_id
							  and bi.booking_identifier_type_rcd = dbo.ref('booking_identifier_type_ref.RL')
							order by bi.date_time desc
						) as record_locator
						,b.received_from
	                    ,pa.passenger_name
	                    ,ptr.passenger_type_name
                        ,pa.passenger_id
                        ,bp.booking_id
                        ,bp.booking_passenger_id
                        ,bfs.booking_flight_segment_id
                    from passenger						as pa 
                    inner join passenger_type_ref		as ptr	on ptr.passenger_type_rcd = pa.passenger_type_rcd
                    inner join booking_passenger		as bp	on	bp.passenger_id = pa.passenger_id
																and bp.became_booking_passenger_id is null
					inner join booking_flight_segment	as bfs	on bfs.booking_id = bp.booking_id
					inner join booking					as b	on b.booking_id = bp.booking_id
					inner join flight_segment			as fs	on fs.flight_segment_id = bfs.flight_segment_id

                    --realwhere

                    where fs.flight_id = @flight_id
					  and pa.became_passenger_id is null
					  and pa.default_state_rcd in (dbo.ref('default_state_ref.C'), dbo.ref('default_state_ref.U'))
					  and dbo.BookingPassengerEventOneIsLast(
								bp.booking_passenger_id, 
								dbo.ref('booking_passenger_event_type_ref.CIFS'), 
								dbo.ref('booking_passenger_event_type_ref.COFS')
								) <> 0

					order by record_locator
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.PassengerSearch.PassengersOnFlightCheckedIn");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new PassengersOnFlightCheckedInDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new PassengersOnFlightCheckedInData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get all passengers on a flight</summary>
        /// <cardinality>Many</cardinality>
        public List<PassengersOnFlightWithoutEventsData> PassengersOnFlightWithoutEvents(
            Guid flightId
            ) {
            var ret = new List<PassengersOnFlightWithoutEventsData>();

            string sql = @" 
                    select
						(	
							select top 1 booking_identifier_value
							from booking_identifier as bi
							where bi.booking_id = bp.booking_id
							  and bi.booking_identifier_type_rcd = dbo.ref('booking_identifier_type_ref.RL')
							order by bi.date_time desc
						) as record_locator
						,b.received_from
	                    ,pa.passenger_name
	                    ,ptr.passenger_type_name
                        ,pa.passenger_id
                        ,bp.booking_id
                        ,bp.booking_passenger_id
                        ,bfs.booking_flight_segment_id
                    from passenger						as pa 
                    inner join passenger_type_ref		as ptr	on ptr.passenger_type_rcd = pa.passenger_type_rcd
                    inner join booking_passenger		as bp	on	bp.passenger_id = pa.passenger_id
																and bp.became_booking_passenger_id is null
					inner join booking_flight_segment	as bfs	on bfs.booking_id = bp.booking_id
					inner join booking					as b	on b.booking_id = bp.booking_id
					inner join flight_segment			as fs	on fs.flight_segment_id = bfs.flight_segment_id
                     left join booking_passenger_event  as bpe  on bpe.booking_passenger_id = bp.booking_passenger_id

                    --realwhere

                    where fs.flight_id = @flight_id
					  and pa.became_passenger_id is null
					  and pa.default_state_rcd in (dbo.ref('default_state_ref.C'), dbo.ref('default_state_ref.U'))
					  and bpe.booking_passenger_event_id is null

					order by record_locator
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.PassengerSearch.PassengersOnFlightWithoutEvents");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new PassengersOnFlightWithoutEventsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new PassengersOnFlightWithoutEventsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
    }
}
