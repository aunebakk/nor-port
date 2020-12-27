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
    /// <domain>Schedule</domain>
    public partial class ScheduleSearch
    {
        /// <summary>Get flight schedule</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightScheduleData> FlightSchedule() {
            var ret = new List<FlightScheduleData>();

            string sql = @" 
                    select 
                         fs.flight_schedule_id
	                    ,ai.airline_identifier_code
	                    ,a.airline_name
						,fsi.flight_identifier_code		as flight_number
	                    ,atr.aircraft_type_name
	                    ,dai.airport_identifier_code	as departure_airport_identifier_code
	                    ,da.airport_name				as departure_airport_name
	                    ,aai.airport_identifier_code	as arrival_airport_identifier_code
	                    ,aa.airport_name				as arrival_airport_name
	                    ,fs.from_date_time
	                    ,fs.until_date_time
						,(	select count(1) 
							from flight_schedule_segment as fss
							where fss.flight_schedule_id = fs.flight_schedule_id
						 )								as segment_count
                    from flight_schedule			        as fs
                    inner join airline				        as a	on a.airline_id = fs.airline_id
                    inner join aircraft_type_ref	        as atr	on atr.aircraft_type_rcd = fs.aircraft_type_rcd
                    inner join airport				        as da	on da.airport_id = fs.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fs.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fs.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fs.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airline_identifier	        as ai	on ai.airline_id = fs.airline_id
										                            and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC2')
	                 left join flight_schedule_identifier	as fsi	on fsi.flight_schedule_id = fs.flight_schedule_id
															        and fsi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    --realwhere
                    where fs.became_flight_schedule_id is null
                    order by fs.from_date_time
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.ScheduleSearch.FlightSchedule");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightScheduleDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightScheduleData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get flight schedule history</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightScheduleHistoryData> FlightScheduleHistory(
            Guid flightScheduleId
            ) {
            var ret = new List<FlightScheduleHistoryData>();

            string sql = @" 
                    select 
						 fs.date_time
                        ,fs.flight_schedule_id
	                    ,ai.airline_identifier_code
	                    ,a.airline_name
						,fsi.flight_identifier_code		as flight_number
	                    ,atr.aircraft_type_name
	                    ,dai.airport_identifier_code	as departure_airport_identifier_code
	                    ,da.airport_name				as departure_airport_name
	                    ,aai.airport_identifier_code	as arrival_airport_identifier_code
	                    ,aa.airport_name				as arrival_airport_name
	                    ,fs.from_date_time
	                    ,fs.until_date_time
						,(	select count(1) 
							from flight_schedule_segment as fss
							where fss.flight_schedule_id = fs.flight_schedule_id
						 )								as segment_count
                    from flight_schedule			        as fs
                    inner join airline				        as a	on a.airline_id = fs.airline_id
                    inner join aircraft_type_ref	        as atr	on atr.aircraft_type_rcd = fs.aircraft_type_rcd
                    inner join airport				        as da	on da.airport_id = fs.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fs.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fs.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fs.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airline_identifier	        as ai	on ai.airline_id = fs.airline_id
										                            and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC2')
	                 left join flight_schedule_identifier	as fsi	on fsi.flight_schedule_id = fs.flight_schedule_id
															        and fsi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    --realwhere
                    where fs.binding_flight_schedule_id = @flight_schedule_id
					order by fs.date_time desc
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_schedule_id", SqlDbType.UniqueIdentifier).Value = flightScheduleId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.PassengerSearch.FlightScheduleHistory");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightScheduleHistoryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightScheduleHistoryData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get segments for flight schedule</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightSegmentsScheduleData> FlightSegmentsSchedule(
            Guid flightScheduleId
            ) {
            var ret = new List<FlightSegmentsScheduleData>();

            string sql = @" 
                    select 
                         fss.flight_schedule_id   
                        ,fss.flight_schedule_segment_id
						,ai.airline_identifier_code
						,fsi.flight_identifier_code		as flight_number
	                    ,dai.airport_identifier_code	as departure_airport_identifier_code
	                    ,da.airport_name				as departure_airport_name
	                    ,aai.airport_identifier_code	as arrival_airport_identifier_code
	                    ,aa.airport_name				as arrival_airport_name
						,fss.logical_segment_number
						,fss.physical_segment_number
						,fss.departure_time
	                    ,fss.arrival_time
						,fss.departure_gate
	                    ,fss.arrival_gate
                    from flight_schedule_segment	        as fss
                    inner join flight_schedule		        as fs	on fs.flight_schedule_id = fss.flight_schedule_id
	                inner join airline_identifier	        as ai	on ai.airline_id = fs.airline_id
													        		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				        as da	on da.airport_id = fss.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fss.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fss.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fss.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_schedule_identifier	as fsi	on fsi.flight_schedule_id = fss.flight_schedule_id
															        and fsi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')

                    --realwhere
					where fss.flight_schedule_id = @flight_schedule_id
                    order by fss.physical_segment_number
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_schedule_id", SqlDbType.UniqueIdentifier).Value = flightScheduleId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.PassengerSearch.FlightSegmentsSchedule");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightSegmentsScheduleDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightSegmentsScheduleData();
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
