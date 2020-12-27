using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides flight search with different parameter and result sets
    /// </summary>
    /// <domain>Flight</domain>
    public class FlightSearch
    {
        /// <summary>Get events for flight</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightEventsData> FlightEvents(
            Guid flightId
            ) {
            var ret = new List<FlightEventsData>();

            string sql = @" 
                    select 
						 fe.flight_event_number
	                    ,fe.date_time
	                    ,fe.date_time_type_rcd
	                    ,dttr.date_time_type_name
	                    ,fe.new_date_time
                    from  flight_event				as fe
                    inner join date_time_type_ref	as dttr on dttr.date_time_type_rcd = fe.date_time_type_rcd
                    --realwhere
                    where fe.flight_id = @flight_id
                    order by fe.flight_event_number desc
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightEvents");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightEventsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightEventsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get flights for a duration</summary>
        /// <cardinality>Many</cardinality>
        /// <generatelayer>DataAccessLayer</generatelayer>
        public static List<FlightsForPeriodSimpleData> FlightsForPeriodSimple(
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<FlightsForPeriodSimpleData>();

            string sql = @" 
                    select 
                         fl.flight_id   
	                    ,fl.from_date_time
	                    ,fl.until_date_time
/*
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							where fs.flight_id = fl.flight_id
							)									as flights_booked_count
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				    as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.PD')
							order by fe.date_time desc
							)								    as planned_departure_date_time
*/
                    from flight                                 as fl
                    
                    --realwhere

                    where (fl.from_date_time between @from_date_time and @until_date_time
                        or fl.until_date_time between @from_date_time and @until_date_time)
                      and fl.became_flight_id is null

                    order by fl.from_date_time
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsForPeriodSimple");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsForPeriodSimpleDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsForPeriodSimpleData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get current schedule based on airport and date</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightsForPeriodData> FlightsForPeriod(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<FlightsForPeriodData>();

            string sql = @" 
                    select 
                         fl.flight_id   
						,ai.airline_identifier_code
						,fi.flight_identifier_code			as flight_number
	                    ,dai.airport_identifier_code		as departure_airport_identifier_code
	                    ,da.airport_name					as departure_airport_name
	                    ,aai.airport_identifier_code		as arrival_airport_identifier_code
	                    ,aa.airport_name					as arrival_airport_name

	                    ,fl.from_date_time
	                    ,fl.until_date_time
	                    ,(	select
								top 1 dttr.date_time_type_name
							from  flight_event				as fe
							inner join date_time_type_ref	as dttr on dttr.date_time_type_rcd = fe.date_time_type_rcd
							where fe.flight_id = fl.flight_id
							order by fe.date_time desc
							)								as last_date_time_type_name
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.PD')
							order by fe.date_time desc
							)								as planned_departure_date_time
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.ED')
							order by fe.date_time desc
							)								as estimated_departure_date_time
                        ,fl.comment
                    from flight                             as fl
	                inner join airline_identifier	        as ai	on ai.airline_id = fl.airline_id
													        		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				        as da	on da.airport_id = fl.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fl.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fl.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fl.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_identifier	        as fi	on fi.flight_id = fl.flight_id
															        and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    --realwhere
                    where fl.from_date_time between @from_date_time and @until_date_time
                      and fl.became_flight_id is null
                ";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += "                    order by fl.from_date_time\r\n";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsForPeriod");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsForPeriodDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsForPeriodData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get current schedule based on airport and date</summary>
        /// <summary>with fare information</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightsForBookingWithFareData> FlightsForBookingWithFare(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<FlightsForBookingWithFareData>();

            string sql = @" 
                    select 
                         fl.flight_id   
						,ai.airline_identifier_code
						,fi.flight_identifier_code			as flight_number
	                    ,dai.airport_identifier_code		as departure_airport_identifier_code
	                    ,da.airport_name					as departure_airport_name
	                    ,aai.airport_identifier_code		as arrival_airport_identifier_code
	                    ,aa.airport_name					as arrival_airport_name

	                    ,fl.from_date_time
	                    ,fl.until_date_time
						,dbo.FlightEventOneIsLast(
								fl.flight_id, 
								dbo.ref('date_time_type_ref.BO'), 
								dbo.ref('date_time_type_ref.BC')
								)							as booking_open_flag
						,ff.amount
						,fc.financial_currency_type_code
						,ff.financial_currency_id
						,ff.financial_fare_id
                    from flight                             as fl
	                inner join airline_identifier	        as ai	on ai.airline_id = fl.airline_id
													        		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				        as da	on da.airport_id = fl.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fl.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fl.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fl.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_identifier	        as fi	on fi.flight_id = fl.flight_id
															        and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
					 left join financial_fare				as ff	on ff.departure_airport_id = fl.departure_airport_id
																   and ff.arrival_airport_id = fl.arrival_airport_id
																   and fl.from_date_time between ff.valid_from_flight_date_time and ff.valid_until_flight_date_time
					 left join financial_currency			as fc	on fc.financial_currency_id = ff.financial_currency_id
                    --realwhere
                    where fl.from_date_time between @from_date_time and @until_date_time
                      and fl.became_flight_id is null
                ";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += "                    order by fl.from_date_time\r\n";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsForBookingWithFare");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsForBookingWithFareDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsForBookingWithFareData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get current schedule based on airport and date with booking information</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightsWithBookingInformationData> FlightsWithBookingInformation(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<FlightsWithBookingInformationData>();

            string sql = @" 
                    select 
                         fl.flight_id   
						,ai.airline_identifier_code
						,fi.flight_identifier_code			    as flight_number
	                    ,dai.airport_identifier_code		    as departure_airport_identifier_code
	                    ,da.airport_name					    as departure_airport_name
	                    ,aai.airport_identifier_code		    as arrival_airport_identifier_code
	                    ,aa.airport_name					    as arrival_airport_name
	                    ,fl.from_date_time
	                    ,fl.until_date_time
						,dbo.FlightEventOneIsLast(
								fl.flight_id, 
								dbo.ref('date_time_type_ref.BO'), 
								dbo.ref('date_time_type_ref.BC')
								)							    as can_book_flag
						,dbo.FlightEventOneIsLast(
								fl.flight_id, 
								dbo.ref('date_time_type_ref.CO'), 
								dbo.ref('date_time_type_ref.CC')
								)							    as can_checkin_flag
						,dbo.FlightEventOneIsLast(
								fl.flight_id, 
								dbo.ref('date_time_type_ref.TO'), 
								dbo.ref('date_time_type_ref.TD')
								)							    as in_flight_flag
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							where fs.flight_id = fl.flight_id
							)									as flights_booked_count
	                    ,(	select
								top 1 dttr.date_time_type_name
							from  flight_event				    as fe
							inner join date_time_type_ref	    as dttr on dttr.date_time_type_rcd = fe.date_time_type_rcd
							where fe.flight_id = fl.flight_id
							order by fe.date_time desc
							)								    as last_date_time_type_name
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				    as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.PD')
							order by fe.date_time desc
							)								    as planned_departure_date_time
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				    as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.ED')
							order by fe.date_time desc
							)								    as estimated_departure_date_time

                    from flight                                 as fl
	                inner join airline_identifier	            as ai	on ai.airline_id = fl.airline_id
													            		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				            as da	on da.airport_id = fl.departure_airport_id
                    inner join airport				            as aa	on aa.airport_id = fl.arrival_airport_id
                    inner join airport_identifier	            as dai	on dai.airport_id = fl.departure_airport_id
										                                and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	            as aai	on aai.airport_id = fl.arrival_airport_id
										                                and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_identifier	            as fi	on fi.flight_id = fl.flight_id
															            and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    
                    --realwhere

                    where fl.from_date_time between @from_date_time and @until_date_time
                      and fl.became_flight_id is null
                ";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += "                    order by fl.from_date_time\r\n";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsWithBookingInformation");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsWithBookingInformationDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsWithBookingInformationData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get current schedule based on airport and date with checkin information</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightsWithCheckinInformationData> FlightsWithCheckinInformation(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<FlightsWithCheckinInformationData>();

            string sql = @" 
                    select 
                         fl.flight_id   
						,ai.airline_identifier_code
						,fi.flight_identifier_code			    as flight_number
	                    ,dai.airport_identifier_code		    as departure_airport_identifier_code
	                    ,da.airport_name					    as departure_airport_name
	                    ,aai.airport_identifier_code		    as arrival_airport_identifier_code
	                    ,aa.airport_name					    as arrival_airport_name
	                    ,fl.from_date_time
	                    ,fl.until_date_time
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							inner join booking_passenger		as bp	on	bp.booking_id = bfs.booking_id
																		and bp.became_booking_passenger_id is null
							where fs.flight_id = fl.flight_id
							)									as passengers_booked_count
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							inner join booking_passenger		as bp	on	bp.booking_id = bfs.booking_id
																		and bp.became_booking_passenger_id is null
							inner join passenger				as p	on	p.passenger_id = bp.passenger_id
																		and p.passenger_type_rcd = dbo.ref('passenger_type_ref.AD')
							where fs.flight_id = fl.flight_id
							)									as adult_booked_count
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							inner join booking_passenger		as bp	on	bp.booking_id = bfs.booking_id
																		and bp.became_booking_passenger_id is null
							inner join passenger				as p	on	p.passenger_id = bp.passenger_id
																		and p.passenger_type_rcd = dbo.ref('passenger_type_ref.CHD')
							where fs.flight_id = fl.flight_id
							)									as child_booked_count
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							inner join booking_passenger		as bp	on	bp.booking_id = bfs.booking_id
																		and bp.became_booking_passenger_id is null
							inner join passenger				as p	on	p.passenger_id = bp.passenger_id
																		and p.passenger_type_rcd = dbo.ref('passenger_type_ref.INF')
							where fs.flight_id = fl.flight_id
							)									as infant_booked_count
	                    ,(	select
								top 1 dttr.date_time_type_name
							from  flight_event				    as fe
							inner join date_time_type_ref	    as dttr on dttr.date_time_type_rcd = fe.date_time_type_rcd
							where fe.flight_id = fl.flight_id
							order by fe.date_time desc
							)								    as last_date_time_type_name
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				    as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.PD')
							order by fe.date_time desc
							)								    as planned_departure_date_time
	                    ,(	select
								top 1 fe.new_date_time
							from  flight_event				    as fe
							where	fe.flight_id = fl.flight_id
								and fe.date_time_type_rcd = dbo.ref('date_time_type_ref.ED')
							order by fe.date_time desc
							)								    as estimated_departure_date_time

                    from flight                                 as fl
	                inner join airline_identifier	            as ai	on ai.airline_id = fl.airline_id
													            		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				            as da	on da.airport_id = fl.departure_airport_id
                    inner join airport				            as aa	on aa.airport_id = fl.arrival_airport_id
                    inner join airport_identifier	            as dai	on dai.airport_id = fl.departure_airport_id
										                                and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	            as aai	on aai.airport_id = fl.arrival_airport_id
										                                and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_identifier	            as fi	on fi.flight_id = fl.flight_id
															            and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    
                    --realwhere

                    where fl.from_date_time between @from_date_time and @until_date_time
                      and fl.became_flight_id is null
					  and dbo.FlightEventOneIsLast(
								fl.flight_id, 
								dbo.ref('date_time_type_ref.CO'), 
								dbo.ref('date_time_type_ref.CC')
								) = 1
                ";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += "                    order by fl.from_date_time\r\n";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsWithCheckinInformation");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsWithCheckinInformationDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsWithCheckinInformationData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get current flights open for checkin information with one column description</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightsOpenForCheckinWithDescriptionData> FlightsOpenForCheckinWithDescription(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<FlightsOpenForCheckinWithDescriptionData>();

            string sql = @" 
                    select 
						 ai.airline_identifier_code
						,fi.flight_identifier_code			    as flight_number
	                    ,dai.airport_identifier_code		    as departure_airport_identifier_code
	                    ,da.airport_name					    as departure_airport_name
	                    ,aai.airport_identifier_code		    as arrival_airport_identifier_code
	                    ,aa.airport_name					    as arrival_airport_name
	                    ,fl.from_date_time
	                    ,fl.until_date_time
						,(	select count(*)
							from flight_segment					as fs
							inner join booking_flight_segment	as bfs	on	bfs.flight_segment_id = fs.flight_segment_id
																		and bfs.became_booking_flight_segment_id is null
							inner join booking_passenger		as bp	on	bp.booking_id = bfs.booking_id
																		and bp.became_booking_passenger_id is null
							where fs.flight_id = fl.flight_id
							)									as passengers_booked_count
						,        ai.airline_identifier_code 
						 + ' ' + fi.flight_identifier_code			    
	                     + ' ' + dai.airport_identifier_code		    
	                     + ' ' + aai.airport_identifier_code	as flight_description
                        ,fl.flight_id   
                    from flight                                 as fl
	                inner join airline_identifier	            as ai	on ai.airline_id = fl.airline_id
													            		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				            as da	on da.airport_id = fl.departure_airport_id
                    inner join airport				            as aa	on aa.airport_id = fl.arrival_airport_id
                    inner join airport_identifier	            as dai	on dai.airport_id = fl.departure_airport_id
										                                and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	            as aai	on aai.airport_id = fl.arrival_airport_id
										                                and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_identifier	            as fi	on fi.flight_id = fl.flight_id
															            and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    
                    --realwhere

                    where fl.from_date_time between @from_date_time and @until_date_time
                      and fl.became_flight_id is null
					  and dbo.FlightEventOneIsLast(
								fl.flight_id, 
								dbo.ref('date_time_type_ref.CO'), 
								dbo.ref('date_time_type_ref.CC')
								) = 1
                ";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += "                    order by fl.from_date_time\r\n";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsOpenForCheckinWithDescription");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsOpenForCheckinWithDescriptionDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsOpenForCheckinWithDescriptionData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get airports</summary>
        /// <cardinality>Many</cardinality>
        public List<AirportsAvailableWithFilterData> AirportsAvailableWithFilter(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<AirportsAvailableWithFilterData>();
            // distinct removed because of sql2x inadequety
            string sql = @" 
                    select 
						 a.airport_id
	                    ,dai.airport_identifier_code
	                    ,a.airport_name
                    from airport					as a								
                    inner join airport_identifier	as dai	on  dai.airport_id = a.airport_id
										                    and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
					union
                    select 
						 null						
	                    ,'All'
	                    ,'All'
                ";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += "                    order by a.airport_name\r\n";


            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.AirportsAvailableWithFilter");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AirportsAvailableWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AirportsAvailableWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get segments for flight</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightSegmentsData> FlightSegments(
            Guid flightId
            ) {
            var ret = new List<FlightSegmentsData>();

            string sql = @" 
					select 
                         fs.flight_id   
                        ,fs.flight_segment_id
						,ai.airline_identifier_code
						,fi.flight_identifier_code		as flight_number
	                    ,dai.airport_identifier_code	as departure_airport_identifier_code
	                    ,da.airport_name				as departure_airport_name
	                    ,aai.airport_identifier_code	as arrival_airport_identifier_code
	                    ,aa.airport_name				as arrival_airport_name

	                    ,fs.from_date_time
	                    ,fs.until_date_time
						,fs.departure_gate
						,fs.arrival_gate
						,fs.logical_segment_number
						,fs.physical_segment_number
	                    ,(	select
								top 1 dttr.date_time_type_name
							from  flight_segment_event		as fse
							inner join date_time_type_ref	as dttr on dttr.date_time_type_rcd = fse.date_time_type_rcd
							where fse.flight_segment_id = fs.flight_segment_id
							order by fse.date_time desc
							)                           as last_date_time_type_name
                    from flight_segment				        as fs
                    inner join flight                       as f    on f.flight_id = fs.flight_id
	                inner join airline_identifier	        as ai	on ai.airline_id = f.airline_id
													        		and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                    inner join airport				        as da	on da.airport_id = fs.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fs.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fs.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fs.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                 left join flight_identifier	        as fi	on fi.flight_id = fs.flight_id
															        and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')

                    --realwhere
					where fs.flight_id = @flight_id
                    order by fs.from_date_time
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightSegments");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightSegmentsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightSegmentsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get flight history</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightHistoryData> FlightHistory(
            Guid flightId
            ) {
            var ret = new List<FlightHistoryData>();

            string sql = @" 
                    select 
						 f.date_time
                        ,f.flight_id
	                    ,ai.airline_identifier_code
	                    ,a.airline_name
						,fi.flight_identifier_code		as flight_number
	                    ,atr.aircraft_type_name
	                    ,dai.airport_identifier_code	as departure_airport_identifier_code
	                    ,da.airport_name				as departure_airport_name
	                    ,aai.airport_identifier_code	as arrival_airport_identifier_code
	                    ,aa.airport_name				as arrival_airport_name
	                    ,f.from_date_time
	                    ,f.until_date_time
						,(	select count(1) 
							from flight_segment as fs
							where fs.flight_id = f.flight_id
						 )								as segment_count
                    from flight								as f
                    inner join airline				        as a	on a.airline_id = f.airline_id
                    inner join aircraft_type_ref	        as atr	on atr.aircraft_type_rcd = f.aircraft_type_rcd
                    inner join airport				        as da	on da.airport_id = f.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = f.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = f.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = f.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airline_identifier	        as ai	on ai.airline_id = f.airline_id
										                            and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC2')
	                 left join flight_identifier			as fi	on fi.flight_id = f.flight_id
															        and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                    --realwhere
                    where f.binding_flight_id = @flight_id
					order by f.date_time desc
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@flight_id", SqlDbType.UniqueIdentifier).Value = flightId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightHistory");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightHistoryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightHistoryData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get all flights on a booking</summary>
        /// <cardinality>Many</cardinality>
        public List<FlightsOnBookingData> FlightsOnBooking(
            Guid bookingId
            ) {
            var ret = new List<FlightsOnBookingData>();

            string sql = @" 
                    select 
	                      (	select 
			                    top 1 flight_identifier_code
		                    from flight_identifier as fi
		                    where fi.flight_id = fl.flight_id
		                      and fi.flight_identifier_type_rcd = 'FN3'
	                      ) as flight_number

	                     ,(	select 
			                    top 1 airport_identifier_code
		                    from airport_identifier as ai
		                    where ai.airport_id = fl.departure_airport_id
		                      and ai.airport_identifier_type_rcd = 'AC3'
	                     ) as origin_airport_code

	                    ,ao.airport_name as origin_airport_name

	                    ,(	select 
			                    top 1 airport_identifier_code
		                    from airport_identifier as ai
		                    where ai.airport_id = fl.arrival_airport_id
		                      and ai.airport_identifier_type_rcd = 'AC3'
	                     ) as destination_airport_code

	                    ,ad.airport_name as destination_airport_name

	                    ,fl.from_date_time
	                    ,fl.until_date_time
	                    ,fl.comment
                        ,fl.flight_id
                    from flight                         as fl
					inner join flight_segment           as fs on fs.flight_id = fl.flight_id
					inner join booking_flight_segment   as bfs on bfs.flight_segment_id = fs.flight_segment_id
                    inner join airport                  as ao on ao.airport_id = fl.departure_airport_id
                    inner join airport                  as ad on ad.airport_id = fl.arrival_airport_id
                    --realwhere
                    where bfs.booking_id = @booking_id
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.FlightsOnBooking");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FlightsOnBookingDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FlightsOnBookingData();
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
