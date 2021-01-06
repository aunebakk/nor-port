using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides financial search with different parameter and result sets
    /// </summary>
    /// <domain>Financial</domain>
    public partial class FinancialSearch
    {
        /// <summary>Get credit debit transaction balances pr day</summary>
        /// <cardinality>Many</cardinality>
        public List<TransactionsCreditDebitBalanceData> TransactionsCreditDebitBalance(
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<TransactionsCreditDebitBalanceData>();

            string sql = @" 
                    select top 50
                            cast(datepart(year, fl.from_date_time)	as char(4))
						  + cast(datepart(month, fl.from_date_time) as varchar(2))
						  + cast(datepart(day, fl.from_date_time)	as varchar(2))	as date
						,(	select sum(fbt.amount)						
							from financial_booking_transaction	as fbt
							where 
									datepart(year, fbt.date_time) = datepart(year, fl.from_date_time)
								and datepart(month, fbt.date_time) = datepart(month, fl.from_date_time)
								and datepart(day, fbt.date_time) = datepart(day, fl.from_date_time)
								and fbt.financial_payment_id is null
								and fbt.financial_adjustment_id is null
						  )											as debit_amount
						,(	select sum(fbt.amount)						
							from financial_booking_transaction	as fbt
							where 
									datepart(year, fbt.date_time) = datepart(year, fl.from_date_time)
								and datepart(month, fbt.date_time) = datepart(month, fl.from_date_time)
								and datepart(day, fbt.date_time) = datepart(day, fl.from_date_time)
						      and (fbt.financial_payment_id is not null
                                or fbt.financial_adjustment_id is not null)
						  )											as credit_amount

                    from flight as fl
                    --realwhere
                    where fl.from_date_time between @from_date_time and @until_date_time
                      and fl.became_flight_id is null
					group by 
                         datepart(year, fl.from_date_time)
						,datepart(month, fl.from_date_time)
						,datepart(day, fl.from_date_time)
						
					order by
						 datepart(year, fl.from_date_time)
						,datepart(month, fl.from_date_time)
						,datepart(day, fl.from_date_time)
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.TransactionsCreditDebitBalance");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new TransactionsCreditDebitBalanceDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new TransactionsCreditDebitBalanceData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Special Service Request List</summary>
        /// <cardinality>Many</cardinality>
        public List<SpecialServiceRequestListData> SpecialServiceRequestList(
            ) {
            var ret = new List<SpecialServiceRequestListData>();

            string sql = @" 
                select 
	                 sssr.service_special_service_request_group_rcd
	                ,sssr.service_special_service_request_code
	                ,sssr.service_special_service_request_name
	                ,sssr.amount								
	                ,fc.financial_currency_type_name			
	                ,sssr.service_description
	                ,req.service_special_service_request_requirement_name
	                ,ope.service_special_service_request_operation_rule_name
                    ,sssr.service_special_service_request_id
                from service_special_service_request							as sssr	
                inner join service_special_service_request_requirement_ref		as req	on	req.service_special_service_request_requirement_rcd = sssr.request_service_special_service_request_requirement_rcd
                inner join service_special_service_request_operation_rule_ref	as ope	on	ope.service_special_service_request_operation_rule_rcd = sssr.service_special_service_request_operation_rule_rcd
                 left join financial_currency									as fc	on	fc.financial_currency_id = sssr.financial_currency_id
                order by sssr.service_special_service_request_code
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.SpecialServiceRequestList");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new SpecialServiceRequestListDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new SpecialServiceRequestListData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Service hotel List</summary>
        /// <cardinality>Many</cardinality>
        public List<ServiceHotelListData> ServiceHotelList(
            ) {
            var ret = new List<ServiceHotelListData>();

            string sql = @" 
                select 
					 sh.hotel_name
	                ,sh.day_price_amount								
	                ,fc.financial_currency_type_name			
                    ,sh.service_hotel_id
                from service_hotel							as sh	
                inner join financial_currency				as fc	on	fc.financial_currency_id = sh.financial_currency_id
                order by sh.hotel_name
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.ServiceHotelList");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new ServiceHotelListDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ServiceHotelListData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Service car rental List</summary>
        /// <cardinality>Many</cardinality>
        public List<ServiceCarRentalListData> ServiceCarRentalList(
            ) {
            var ret = new List<ServiceCarRentalListData>();

            string sql = @" 
                select 
					 scr.car_name
	                ,scr.day_price_amount								
	                ,fc.financial_currency_type_name			
                    ,scr.service_car_rental_id
                from service_car_rental						as scr
                inner join financial_currency				as fc	on	fc.financial_currency_id = scr.financial_currency_id
                order by scr.car_name
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.ServiceCarRentalList");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new ServiceCarRentalListDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ServiceCarRentalListData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Service ferry rental List</summary>
        /// <cardinality>Many</cardinality>
        public List<ServiceFerryListData> ServiceFerryList(
            ) {
            var ret = new List<ServiceFerryListData>();

            string sql = @" 
                select 
 	                 f.ferry_name
	                ,sf.amount								
	                ,fc.financial_currency_type_name			
                    ,f.ferry_id
                    ,f.product_id
                    ,sf.service_ferry_id
                from service_ferry						as sf
                inner join ferry						as f	on	f.ferry_id = sf.ferry_id
                inner join financial_currency			as fc	on	fc.financial_currency_id = sf.financial_currency_id
                order by f.ferry_name
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.ServiceFerryList");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new ServiceFerryListDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ServiceFerryListData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Financial service details for booking</summary>
        /// <cardinality>Many</cardinality>
        public List<FinancialServiceDetailsForBookingData> FinancialServiceDetailsForBooking(
            Guid bookingId
            ) {
            var ret = new List<FinancialServiceDetailsForBookingData>();

            string sql = @" 
                select 
	                 'ssr'												as service_type_name
	                ,'(' + sssr.service_special_service_request_code
	                 + ') ' + sssr.service_special_service_request_name	as service_description
					,srsr.service_request_status_name
	                ,sssr.amount										as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
                    ,booking_service_request_id
					,bsr.service_special_service_request_id
					,bsr.service_hotel_id
					,bsr.service_car_rental_id
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_special_service_request				as sssr		on	sssr.service_special_service_request_id = bsr.service_special_service_request_id
                 left join financial_currency							as fc		on	fc.financial_currency_id = sssr.financial_currency_id
                where bsr.booking_id = @booking_id

				union 

                select 
	                 'hotel'											as service_type_name
	                ,sh.hotel_name										as service_description
					,srsr.service_request_status_name
	                ,sh.day_price_amount								as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
                    ,booking_service_request_id
					,bsr.service_special_service_request_id
					,bsr.service_hotel_id
					,bsr.service_car_rental_id
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_hotel								as sh		on	sh.service_hotel_id = bsr.service_hotel_id
                inner join financial_currency							as fc		on	fc.financial_currency_id = sh.financial_currency_id
                where bsr.booking_id = @booking_id

				union 

                select 
	                 'ferry'											as service_type_name
	                ,fe.ferry_name										as service_description
					,srsr.service_request_status_name
	                ,sh.amount											as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
                    ,booking_service_request_id
					,bsr.service_special_service_request_id
					,bsr.service_ferry_id
					,bsr.service_car_rental_id
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_ferry								as sh		on	sh.service_ferry_id = bsr.service_ferry_id
                inner join ferry										as fe		on	fe.ferry_id = sh.ferry_id
                inner join financial_currency							as fc		on	fc.financial_currency_id = sh.financial_currency_id
                where bsr.booking_id = @booking_id

				union 

                select 
	                 'car'												as service_type_name
	                ,scr.car_name										as service_description
					,srsr.service_request_status_name
	                ,scr.day_price_amount								as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
                    ,booking_service_request_id
					,bsr.service_special_service_request_id
					,bsr.service_hotel_id
					,bsr.service_car_rental_id
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_car_rental							as scr		on	scr.service_car_rental_id = bsr.service_car_rental_id
                inner join financial_currency							as fc		on	fc.financial_currency_id = scr.financial_currency_id
                where bsr.booking_id = @booking_id
                --order by bsr.date_time
            ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.FinancialServiceDetailsForBooking");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FinancialServiceDetailsForBookingDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FinancialServiceDetailsForBookingData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>voucher usage details</summary>
        /// <cardinality>Many</cardinality>
        public List<VoucherTransactionsData> VoucherTransactions(
            Guid financialVoucherId
            ) {
            var ret = new List<VoucherTransactionsData>();

            string sql = @" 
                    select top 50 
						 fv.voucher_number 
						,fv.voucher_description
						,fbt.date_time
						,fpv.amount							as paid_currency_amount
						,fvc.financial_currency_type_rcd	as paid_currency_type
						,fc.equals_amount					as exchange_rate
						,fbt.amount							as booking_currency_amount
						,fc.financial_currency_type_rcd	as booking_currency_type
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.financial_payment_id
						,fbt.booking_id
                    from financial_booking_transaction		as fbt
					inner join financial_currency			as fc	on fc.financial_currency_id = fbt.financial_currency_id
					inner join financial_payment			as fp	on fp.financial_payment_id = fbt.financial_payment_id
					inner join financial_payment_type_ref	as fptr	on fptr.financial_payment_type_rcd = fp.financial_payment_type_rcd
					inner join financial_payment_voucher	as fpv	on fpv.financial_payment_voucher_id = fp.financial_payment_voucher_id
					inner join financial_voucher			as fv	on fv.financial_voucher_id = fpv.financial_voucher_id
					inner join financial_currency			as fvc	on fvc.financial_currency_id = fpv.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
					inner join default_user					as du	on du.default_user_id = fbt.user_id
					where fv.financial_voucher_id = @financial_voucher_id
					order by fbt.date_time
                    ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@financial_voucher_id", SqlDbType.UniqueIdentifier).Value = financialVoucherId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.VoucherTransactions");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new VoucherTransactionsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new VoucherTransactionsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>voucher search with remaining amount</summary>
        /// <cardinality>Many</cardinality>
        public List<VoucherSearchWithRemainingAmountData> VoucherSearchWithRemainingAmount(
            DateTime voucherValidOnDateTime
            ) {
            var ret = new List<VoucherSearchWithRemainingAmountData>();

            string sql = @" 
                    select top 50 
	                     fv.financial_voucher_id
                        ,fv.financial_currency_id
						,fv.voucher_number
						,fv.voucher_description
						,fv.value_amount
							- coalesce(
								(	select sum(fpv.amount)
									from financial_payment_voucher	as fpv
									where fpv.financial_voucher_id = fv.financial_voucher_id)
								, 0)				as remaining_amount
						,fc.financial_currency_type_code
						,fc.financial_currency_type_name
						,fv.valid_from_date_time
						,fv.valid_until_date_time
                    from financial_voucher			as fv
					inner join financial_currency	as fc	on fc.financial_currency_id = fv.financial_currency_id
                    --realwhere
                    ";

            if ( voucherValidOnDateTime != DateTime.MinValue )
                sql += "					where @voucher_valid_on_date_time between fv.valid_from_date_time and fv.valid_until_date_time";

            sql += "                    order by fv.voucher_number";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    if ( voucherValidOnDateTime != DateTime.MinValue )
                        command.Parameters.Add("@voucher_valid_on_date_time", SqlDbType.DateTime).Value = voucherValidOnDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.VoucherSearchWithRemainingAmount");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new VoucherSearchWithRemainingAmountDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new VoucherSearchWithRemainingAmountData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Currency Conversion</summary>
        /// <cardinality>One</cardinality>
        /// <generatelayer>DataAccessLayer</generatelayer>
        public static CrudeFinancialCurrencyData GetBookingCurrencyConversion(
            string currencyCode,
            DateTime currencyDateTime
            ) {

            string sql = @" 
                    select 
	                    top 1 fc.*
                    from financial_currency	as fc
                    where fc.financial_currency_type_rcd = @currency_code
	                    and fc.financial_currency_against_financial_currency_type_rcd = @currency_code
                    	and @currency_date_time >= fc.valid_from_date_time and (@currency_date_time <= fc.valid_until_date_time or fc.valid_until_date_time is null)
                        ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                var data = new CrudeFinancialCurrencyData();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@currency_code", SqlDbType.VarChar).Value = currencyCode;
                    command.Parameters.Add("@currency_date_time", SqlDbType.DateTime).Value = currencyDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.GetBookingCurrencyConversion");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    if ( reader.Read() )
                        data.Populate(reader);

                    reader.Close();
                }

                return data;
            }
        }

        /// <summary>Get Currency Conversion</summary>
        /// <cardinality>One</cardinality>
        /// <generatelayer>DataAccessLayer</generatelayer>
        public static CrudeFinancialCurrencyData GetCurrencyConversion(
            Guid financialCurrencyId,
            Guid againstFinancialCurrencyId,
            DateTime currencyDateTime
            ) {

            string sql = @" 
                    select 
	                    top 1 fc.*
                    from financial_currency	as fc
                    where fc.financial_currency_type_rcd = (
		                    select fc2.financial_currency_type_rcd 
		                    from financial_currency	as fc2 
		                    where fc2.financial_currency_id = @financial_currency_id
	                    )
	                    and fc.financial_currency_against_financial_currency_type_rcd = (
		                    select fc2.financial_currency_type_rcd 
		                    from financial_currency	as fc2 
		                    where fc2.financial_currency_id = @financial_currency_against_financial_currency_id
	                    )
                    	and @currency_date_time >= fc.valid_from_date_time and (@currency_date_time <= fc.valid_until_date_time or fc.valid_until_date_time is null)
                        ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                var data = new CrudeFinancialCurrencyData();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    command.Parameters.Add("@financial_currency_against_financial_currency_id", SqlDbType.UniqueIdentifier).Value = againstFinancialCurrencyId;
                    command.Parameters.Add("@currency_date_time", SqlDbType.DateTime).Value = currencyDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.GetCurrencyConversion");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    if ( reader.Read() )
                        data.Populate(reader);

                    reader.Close();
                }

                return data;
            }
        }

        /// <summary>Get fares</summary>
        /// <cardinality>Many</cardinality>
        public List<FinancialFaresData> FinancialFares() {
            var ret = new List<FinancialFaresData>();

            string sql = @" 
                    select top 50 
						 fare.financial_fare_type_rcd
	                    ,dai.airport_identifier_code		as departure_airport_identifier_code
	                    ,da.airport_name					as departure_airport_name
	                    ,aai.airport_identifier_code		as arrival_airport_identifier_code
	                    ,aa.airport_name					as arrival_airport_name
						,fare.valid_from_flight_date_time
						,fare.valid_until_flight_date_time
						,fare.amount
						,fc.financial_currency_type_rcd
						,fctr.financial_currency_type_name
						,fare.date_time
						,du.default_user_code
						,du.default_user_name
                        ,fare.financial_fare_id
                    from financial_fare						as fare
                    inner join airport				        as da	on da.airport_id = fare.departure_airport_id
                    inner join airport				        as aa	on aa.airport_id = fare.arrival_airport_id
                    inner join airport_identifier	        as dai	on dai.airport_id = fare.departure_airport_id
										                            and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                    inner join airport_identifier	        as aai	on aai.airport_id = fare.arrival_airport_id
										                            and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
					inner join financial_currency			as fc	on fc.financial_currency_id = fare.financial_currency_id
					inner join financial_currency_type_ref	as fctr	on fctr.financial_currency_type_rcd = fc.financial_currency_type_rcd
					inner join default_user					as du	on du.default_user_id = fare.user_id
            ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    //command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.FinancialFares");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FinancialFaresDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FinancialFaresData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get available currencies</summary>
        /// <cardinality>Many</cardinality>
        public List<GetAvailableCurrenciesData> GetAvailableCurrencies(
            Guid financialCurrencyId,
            DateTime currencyDateTime
            ) {
            var ret = new List<GetAvailableCurrenciesData>();

            string sql = @" 
                    select top 50 
						 fc.financial_currency_against_financial_currency_type_rcd
						,fctr.financial_currency_type_name
						,fc.amount
						,fc.equals_amount
						,fc.decimal_count
	                    ,fc.financial_currency_id
                    from financial_currency					as fc
					inner join financial_currency_type_ref	as fctr	on	fctr.financial_currency_type_rcd = financial_currency_against_financial_currency_type_rcd
                    where fc.valid_from_date_time <= @currency_date_time and (fc.valid_until_date_time is null or @currency_date_time <= fc.valid_until_date_time)
            ";

            if ( financialCurrencyId != Guid.Empty ) {
                sql += @" and fc.financial_currency_type_rcd = (
		                        select fc2.financial_currency_type_rcd 
		                        from financial_currency	as fc2 
		                        where fc2.financial_currency_id = @financial_currency_id
							    )";
            } else {
                sql += @" and fc.amount = fc.equals_amount";
            }

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    command.Parameters.Add("@currency_date_time", SqlDbType.DateTime).Value = currencyDateTime;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FinancialSearch.GetAvailableCurrencies");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetAvailableCurrenciesDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetAvailableCurrenciesData();
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
