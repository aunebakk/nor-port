using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public class Flight
    {
        /// <summary>Get highest flight event number</summary>
        public static int FlightEventHighestNumber(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid flightId
            ) {

            int flightEventNumber = 0;

            string sql = @" 
                    select 
                         max(fe.flight_event_number) as flight_event_number_highest
                    from flight_event	as fe
                    where fe.flight_id = @flight_id
                ";

            using ( var command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Flight.FlightEventHighestNumber");
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                log.PerformanceTimeStop(sql, command);

                if ( reader.Read() ) {
                    int flightEventNumberOrdinal = reader.GetOrdinal("flight_event_number_highest");
                    if ( !reader.IsDBNull(flightEventNumberOrdinal) )
                        flightEventNumber = reader.GetInt32(flightEventNumberOrdinal);
                }

                reader.Close();
            }

            return flightEventNumber;
        }

        /// <summary>Get highest flight event number</summary>
        public static int FlightSegmentEventHighestNumber(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid flightSegmentId
            ) {

            int flightEventNumber = 0;

            string sql = @" 
                    select 
                         max(fe.flight_segment_event_number) as flight_segment_event_number_highest
                    from flight_segment_event	as fe
                    where fe.flight_segment_id = @flight_segment_id
                ";

            using ( var command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@flight_segment_id", SqlDbType.UniqueIdentifier).Value = flightSegmentId;

                Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Flight.FlightSegmentEventHighestNumber");
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                log.PerformanceTimeStop(sql, command);

                if ( reader.Read() ) {
                    int flightSegmentEventNumberOrdinal = reader.GetOrdinal("flight_segment_event_number_highest");
                    if ( !reader.IsDBNull(flightSegmentEventNumberOrdinal) )
                        flightEventNumber = reader.GetInt32(flightSegmentEventNumberOrdinal);
                }

                reader.Close();
            }

            return flightEventNumber;
        }

        /// <summary>get closest flight matching departure and arrival</summary>
        public static Guid GetFlightMatching(
            Guid departureAirportId,
            Guid arrivalArportId
            ) {
            var ret = new CrudeFlightData();

            string sql = @" 
                select top 1
                    flight_id
                from flight	as fl
                where fl.departure_airport_id = @departure_airport_id
                  and fl.arrival_airport_id = @arrival_airport_id
				  and fl.from_date_time > getutcdate()
				order by fl.from_date_time 
                ";

            Guid flight = Guid.Empty;
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalArportId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Flight.GetFlightMatching");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    if ( reader.Read() )
                        flight = ( Guid ) reader["flight_id"];
                }

                return flight;
            }
        }

        /// <summary>get all segments for flight</summary>
        public static List<CrudeFlightSegmentData> GetFlightSegments(System.Guid flightId) {
            var dataList = new List<CrudeFlightSegmentData>();

            string sql = @" 
                select 
	                flight_segment_id, flight_id, departure_airport_id, arrival_airport_id, logical_segment_number, physical_segment_number, from_date_time, until_date_time, departure_gate, arrival_gate, user_id, date_time
                from flight_segment	as fs	
                where fs.flight_id = @flight_id
                order by fs.physical_segment_number
            ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Flight.GetFlightSegments");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    while ( reader.Read() ) {
                        var data = new CrudeFlightSegmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }

                return dataList;
            }
        }

        /// <summary>Check if event exist for a flight</summary>
        public static bool FlightEventExist(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid flightId,
            string dateTimeTypeRcd
            ) {

            Guid flightEventId = Guid.Empty;

            string sql = @" 
                    select 
                         fe.flight_event_id   
                    from flight_event	as fe
                    --realwhere
                    where fe.flight_id = @flight_id
						and fe.date_time_type_rcd = @date_time_type_rcd
                    order by fe.new_date_time
                ";
            /*
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
            */
            using ( var command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;
                command.Parameters.Add("@date_time_type_rcd", SqlDbType.VarChar).Value = dateTimeTypeRcd;

                Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Flight.FlightEventExist");
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                log.PerformanceTimeStop(sql, command);

                if ( reader.Read() ) {
                    int flightEventOrdinal = reader.GetOrdinal("flight_event_id");
                    if ( !reader.IsDBNull(flightEventOrdinal) )
                        flightEventId = reader.GetGuid(flightEventOrdinal);
                }

                reader.Close();
            }

            return flightEventId != Guid.Empty;
        }
        //        }
    }
}
