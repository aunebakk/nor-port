using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides booking search with different parameter and result sets
    /// </summary>
    /// <domain>Booking</domain>
    public partial class BookingSearch
    {

        /// <summary>Get booking event counts</summary>
        /// <cardinality>One</cardinality>
        public BookingEventCountData BookingEventCount(
            Guid bookingId
            ) {

            var ret = new BookingEventCountData();

            string sql = @" 
                select 
                     (	select count(1)
	                    from booking_contact_method as bcm
	                    where bcm.booking_id = @booking_id
	                    )									as booking_contact_count
                    ,(	select count(1)
	                    from booking_identifier as bi
	                    where bi.booking_id = @booking_id
	                    )									as booking_identifier_count
                    ,(	select count(1)
	                    from booking_service_request as bsr
	                    where bsr.booking_id = @booking_id
	                    )									as booking_service_request_count
                    ,(	select count(1)
	                    from booking_event as be
	                    where be.booking_id = @booking_id
	                    )									as booking_event_count
                    ,(	select count(1)
	                    from booking_flight_segment as bfs
	                    where bfs.booking_id = @booking_id
	                    )									as booking_flight_segment_count
                    ,(	select count(1)
	                    from booking_passenger as bp
	                    where bp.booking_id = @booking_id
	                      and bp.became_booking_passenger_id is null
	                      and bp.default_state_rcd = dbo.ref('default_state_ref.C')
	                    )									as booking_passenger_count
                    ,(	select count(1)
	                    from financial_booking_transaction as fbt
	                    where fbt.booking_id = @booking_id
	                    )									as financial_booking_transaction_count
                    ,(	select count(1)
	                    from financial_booking_transaction as fbt
	                    where fbt.booking_id = @booking_id
	                      and fbt.financial_payment_id is not null
	                    )									as financial_payment_count
                    ,(	select count(*)
	                    from booking_event as be
	                    where be.booking_id = @booking_id
	                      and be.booking_event_type_rcd = dbo.ref('booking_event_type_ref.BC')
	                    )									as confirmed_flag
                    --realwhere
                    ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingEventCount");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    log.PerformanceTimeStop(sql, command);

                    if ( reader.Read() )
                        ret.Populate(
                            reader,
                            new BookingEventCountDataOrdinals(reader)
                            );

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get payments</summary>
        /// <cardinality>Many</cardinality>
        public List<BookingFinancialPaymentsData> BookingFinancialPayments(
            Guid bookingId
            ) {

            var ret = new List<BookingFinancialPaymentsData>();

            string sql = @" 
                    -- cash
                    select top 50 
						 fbt.transaction_number
						,fbt.date_time
                        ,fp.financial_payment_type_rcd
						,fptr.financial_payment_type_name
						,fpc.amount							as paid_currency_amount
						,fpcc.financial_currency_type_rcd	as paid_currency_type
						,fpcc.equals_amount					as exchange_rate
						,fbt.amount							as booking_currency_amount
						,fc.financial_currency_type_rcd		as booking_currency_type
						,''									as payment_description
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.financial_payment_id
                    from financial_booking_transaction		as fbt
					inner join financial_currency			as fc	on fc.financial_currency_id = fbt.financial_currency_id
					inner join financial_payment			as fp	on fp.financial_payment_id = fbt.financial_payment_id
					inner join financial_payment_type_ref	as fptr	on fptr.financial_payment_type_rcd = fp.financial_payment_type_rcd
					inner join financial_payment_cash		as fpc	on fpc.financial_payment_cash_id = fp.financial_payment_cash_id
					inner join financial_currency			as fpcc	on fpcc.financial_currency_id = fpc.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
					inner join default_user					as du	on du.default_user_id = fbt.user_id
                    where fbt.booking_id = @booking_id

                    union

                    -- voucher
                    select top 50 
						 fbt.transaction_number
						,fbt.date_time
                        ,fp.financial_payment_type_rcd
						,fptr.financial_payment_type_name
						,fpv.amount							as paid_currency_amount
						,fvc.financial_currency_type_rcd	as paid_currency_type
						,fc.equals_amount					as exchange_rate
						,fbt.amount							as booking_currency_amount
						,fc.financial_currency_type_rcd	as booking_currency_type
						,'Voucher:' 
							+ cast(fv.voucher_number 
								as varchar(20))
							+ coalesce(
							', ' + 
							fv.voucher_description, '')		as payment_description
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.financial_payment_id
                    from financial_booking_transaction		as fbt
					inner join financial_currency			as fc	on fc.financial_currency_id = fbt.financial_currency_id
					inner join financial_payment			as fp	on fp.financial_payment_id = fbt.financial_payment_id
					inner join financial_payment_type_ref	as fptr	on fptr.financial_payment_type_rcd = fp.financial_payment_type_rcd
					inner join financial_payment_voucher	as fpv	on fpv.financial_payment_voucher_id = fp.financial_payment_voucher_id
					inner join financial_voucher			as fv	on fv.financial_voucher_id = fpv.financial_voucher_id
					inner join financial_currency			as fvc	on fvc.financial_currency_id = fpv.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
					inner join default_user					as du	on du.default_user_id = fbt.user_id
                    where fbt.booking_id = @booking_id

					union

                    -- card
                    select top 50 
						 fbt.transaction_number
						,fbt.date_time
                        ,fp.financial_payment_type_rcd
						,fptr.financial_payment_type_name
						,fpc.amount						    as paid_currency_amount
						,fpcc.financial_currency_type_rcd	as paid_currency_type
						,fpcc.equals_amount					as exchange_rate
						,fbt.amount							as booking_currency_amount
						,fc.financial_currency_type_rcd	    as booking_currency_type
						,'Card: ' 
							+ fpc.financial_card_type_rcd	as payment_description
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.financial_payment_id
                    from financial_booking_transaction		as fbt
					inner join financial_currency			as fc	on fc.financial_currency_id = fbt.financial_currency_id
					inner join financial_payment			as fp	on fp.financial_payment_id = fbt.financial_payment_id
					inner join financial_payment_type_ref	as fptr	on fptr.financial_payment_type_rcd = fp.financial_payment_type_rcd
					inner join financial_payment_card		as fpc	on fpc.financial_payment_card_id = fp.financial_payment_card_id
					inner join financial_currency			as fpcc	on fpcc.financial_currency_id = fpc.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
					inner join default_user					as du	on du.default_user_id = fbt.user_id
                    where fbt.booking_id = @booking_id

                    union

                    -- bank
                    select top 50 
						 fbt.transaction_number
						,fbt.date_time
                        ,fp.financial_payment_type_rcd
						,fptr.financial_payment_type_name
						,fpb.amount						    as paid_currency_amount
						,fpbc.financial_currency_type_rcd	as paid_currency_type
						,fpbc.equals_amount					as exchange_rate
						,fbt.amount							as booking_currency_amount
						,fc.financial_currency_type_rcd		as booking_currency_type
						,'Bank: ' 
							+ fpb.financial_bank_account_number_type_rcd	
															as payment_description
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.financial_payment_id
                    from financial_booking_transaction		as fbt
					inner join financial_currency			as fc	on fc.financial_currency_id = fbt.financial_currency_id
					inner join financial_payment			as fp	on fp.financial_payment_id = fbt.financial_payment_id
					inner join financial_payment_type_ref	as fptr	on fptr.financial_payment_type_rcd = fp.financial_payment_type_rcd
					inner join financial_payment_bank		as fpb	on fpb.financial_payment_bank_id = fp.financial_payment_bank_id
					inner join financial_currency			as fpbc	on fpbc.financial_currency_id = fpb.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
					inner join default_user					as du	on du.default_user_id = fbt.user_id
                    where fbt.booking_id = @booking_id

                    order by fbt.transaction_number
                    ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingFinancialPayments");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingFinancialPaymentsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingFinancialPaymentsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking summary</summary>
        /// <cardinality>Many</cardinality>
        /// <todo>make service type name into reference</todo>
        public List<BookingServiceSummaryData> BookingServiceSummary(
            Guid bookingId
            ) {

            var ret = new List<BookingServiceSummaryData>();

            string sql = @" 
                select 
					 bsr.date_time
	                ,cast(null as datetime)								as from_date_time
					,cast(null as datetime)								as until_date_time
	                ,'ssr'												as service_type_name
	                ,'(' + sssr.service_special_service_request_code
	                 + ') ' + sssr.service_special_service_request_name	as service_description
					,srsr.service_request_status_name
	                ,sssr.amount										as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_special_service_request				as sssr		on	sssr.service_special_service_request_id = bsr.service_special_service_request_id
                 left join financial_currency							as fc		on	fc.financial_currency_id = sssr.financial_currency_id
                where bsr.booking_id = @booking_id

				union 

                select 
	                 bsr.date_time
	                ,cast(null as datetime)								as from_date_time
					,cast(null as datetime)								as until_date_time
	                ,'hotel'											as service_type_name
	                ,sh.hotel_name										as service_description
					,srsr.service_request_status_name
	                ,sh.day_price_amount								as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_hotel								as sh		on	sh.service_hotel_id = bsr.service_hotel_id
                inner join financial_currency							as fc		on	fc.financial_currency_id = sh.financial_currency_id
                where bsr.booking_id = @booking_id

				union 

                select 
	                 bsr.date_time
	                ,cast(null as datetime)								as from_date_time
					,cast(null as datetime)								as until_date_time
	                ,'car'												as service_type_name
	                ,scr.car_name										as service_description
					,srsr.service_request_status_name
	                ,scr.day_price_amount								as service_amount
	                ,fc.financial_currency_type_name					as service_currency_type_name
				from booking_service_request							as bsr
                inner join service_request_status_ref					as srsr		on	srsr.service_request_status_rcd = bsr.service_request_status_rcd
                inner join service_car_rental							as scr		on	scr.service_car_rental_id = bsr.service_car_rental_id
                inner join financial_currency							as fc		on	fc.financial_currency_id = scr.financial_currency_id
                where bsr.booking_id = @booking_id

				union

                select 
	                  bfs.date_time
	                 ,fl.from_date_time
	                 ,fl.until_date_time
	                 ,'flight'									as service_type_name
					 ,ai.airline_identifier_code
					 + ' ' + fi.flight_identifier_code		
	                 + ' ' + dai.airport_identifier_code	
	                 + ' ' + da.airport_name				
	                 + ' ' + aai.airport_identifier_code	
	                 + ' ' + aa.airport_name				
																as service_description
					,null										as service_request_status_name
	                ,null										as service_amount
	                ,null										as service_currency_type_name
                from booking_flight_segment				as bfs
                inner join flight_segment				as fs	on fs.flight_segment_id = bfs.flight_segment_id
                inner join flight						as fl	on fl.flight_id = fs.flight_id
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
                where bfs.booking_id = @booking_id
                  and bfs.became_booking_flight_segment_id is null
                  and bfs.default_state_rcd <> dbo.ref('default_state_ref.I')

                order by date_time
            ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingServiceSummary");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingServiceSummaryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingServiceSummaryData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking financial transactions</summary>
        /// <cardinality>Many</cardinality>
        public List<BookingFinancialTransactionsData> BookingFinancialTransactions(Guid bookingId) {
            var ret = new List<BookingFinancialTransactionsData>();

            string sql = @" 
                    select top 50 
						 fbt.transaction_number				as transaction_number
						,fbt.date_time						as date_time
                        ,'Fee'                              as transaction_type
						,fftr.financial_fee_type_name		as type_name
						,fbt.amount                         as debit_amount
						,0.00                               as credit_amount
						,fc.financial_currency_type_rcd
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.booking_id
                    from financial_booking_transaction		as fbt
					inner join default_user					as du	on du.default_user_id = fbt.user_id
					inner join financial_fee				as fee	on fee.financial_fee_id = fbt.financial_fee_id
					inner join financial_fee_type_ref		as fftr	on fftr.financial_fee_type_rcd = fee.financial_fee_type_rcd
					inner join financial_currency			as fc	on fc.financial_currency_id = fee.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
                    where fbt.booking_id = @booking_id

					union

                    select top 50 
						 fbt.transaction_number				as transaction_number
						,fbt.date_time						as date_time
                        ,'Tax'                              as transaction_type
						,fftr.financial_tax_type_name		as type_name
						,fbt.amount                         as debit_amount
						,null                               as credit_amount
						,fc.financial_currency_type_rcd
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.booking_id
                    from financial_booking_transaction		as fbt
					inner join default_user					as du	on du.default_user_id = fbt.user_id
					inner join financial_tax				as tax	on tax.financial_tax_id = fbt.financial_tax_id
					inner join financial_tax_type_ref		as fftr	on fftr.financial_tax_type_rcd = tax.financial_tax_type_rcd
					inner join financial_currency			as fc	on fc.financial_currency_id = tax.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
                    where fbt.booking_id = @booking_id

					union

                    select top 50 
						 fbt.transaction_number				as transaction_number
						,fbt.date_time						as date_time
                        ,'Service'                          as transaction_type
						,str.service_type_name	            as type_name
						,fbt.amount                         as debit_amount
						,null                               as credit_amount
						,fc.financial_currency_type_rcd
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.booking_id
                    from financial_booking_transaction		as fbt
					inner join default_user					as du	on du.default_user_id = fbt.user_id
					inner join financial_service			as ser	on ser.financial_service_id = fbt.financial_service_id
					inner join service_type_ref	            as str	on str.service_type_rcd = ser.service_type_rcd
					inner join financial_currency			as fc	on fc.financial_currency_id = ser.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
                    where fbt.booking_id = @booking_id

					union

                    select top 50 
						 fbt.transaction_number				as transaction_number
						,fbt.date_time						as date_time
                        ,'Fare'                             as transaction_type
						,fftr.financial_fare_type_name		as type_name
						,fbt.amount                         as debit_amount
						,null                               as credit_amount
						,fc.financial_currency_type_rcd
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.booking_id
                    from financial_booking_transaction		as fbt
					inner join default_user					as du	on du.default_user_id = fbt.user_id
					inner join financial_fare				as fare	on fare.financial_fare_id = fbt.financial_fare_id
					inner join financial_fare_type_ref		as fftr	on fftr.financial_fare_type_rcd = fare.financial_fare_type_rcd
					inner join financial_currency			as fc	on fc.financial_currency_id = fare.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
                    where fbt.booking_id = @booking_id

					union

                    select top 50 
						 fbt.transaction_number				as transaction_number
						,fbt.date_time						as date_time
                        ,'Payment'                          as transaction_type
						,fptr.financial_payment_type_name	as type_name
						,null                               as debit_amount
						,fbt.amount                         as credit_amount
						,fc.financial_currency_type_rcd
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.booking_id
                    from financial_booking_transaction		as fbt
					inner join default_user					as du	on du.default_user_id = fbt.user_id
					inner join financial_payment			as pay	on pay.financial_payment_id = fbt.financial_payment_id
					inner join financial_payment_type_ref	as fptr	on fptr.financial_payment_type_rcd = pay.financial_payment_type_rcd
					inner join financial_currency			as fc	on fc.financial_currency_id = fbt.financial_currency_id
					inner join financial_costcentre			as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
                    where fbt.booking_id = @booking_id

					union

                    select top 50 
						 fbt.transaction_number					as transaction_number
						,fbt.date_time							as date_time
                        ,'Adjustment'							as transaction_type
						,fatr.financial_adjustment_type_name	as type_name
						,null									as debit_amount
						,fbt.amount								as credit_amount
						,fc.financial_currency_type_rcd
						,fcc.financial_costcentre_code
						,fcc.financial_costcentre_name
						,du.default_user_code
						,du.default_user_name
                        ,fbt.booking_id
                    from financial_booking_transaction			as fbt
					inner join default_user						as du	on du.default_user_id = fbt.user_id
					inner join financial_adjustment				as adj	on adj.financial_adjustment_id = fbt.financial_adjustment_id
					inner join financial_adjustment_type_ref	as fatr	on fatr.financial_adjustment_type_rcd = adj.financial_adjustment_type_rcd
					inner join financial_currency				as fc	on fc.financial_currency_id = adj.financial_currency_id
					inner join financial_costcentre				as fcc	on fcc.financial_costcentre_id = fbt.financial_costcentre_id
                    where fbt.booking_id = @booking_id

                    union

                    select top 50 
						 (select max(fbt.transaction_number) 						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = b.booking_id
															) + 1	as transaction_number
						,getutcdate()								as date_time
                        ,'Total'									as transaction_type
						,''											as type_name
						,(select sum(fbt.amount)						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = b.booking_id
						    and fbt.financial_payment_id is null
                            and fbt.financial_adjustment_id is null
						  )											as debit_amount
						,(select sum(fbt.amount)						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = b.booking_id
						    and (fbt.financial_payment_id is not null
                                or fbt.financial_adjustment_id is not null)
						  )											as credit_amount
						,''											as financial_currency_type_rcd
						,''											as financial_costcentre_code
						,''											as financial_costcentre_name
						,''											as default_user_code
						,''											as default_user_name
                        ,'{00000000-0000-0000-0000-000000000000}'	as booking_id
                    from booking									as b
                    where b.booking_id = @booking_id

                    union

                    select top 50 
						 (select max(fbt.transaction_number) 						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = b.booking_id
															) + 2	as transaction_number
						,getutcdate()								as date_time
                        ,'Balance'									as transaction_type
						,''											as type_name
						,null										as debit_amount
						,coalesce((select sum(fbt.amount)						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = b.booking_id
						    and fbt.financial_payment_id is null
                            and fbt.financial_adjustment_id is null
						  ), 0)											
						- coalesce((select sum(fbt.amount)						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = b.booking_id
						    and (fbt.financial_payment_id is not null
                                or fbt.financial_adjustment_id is not null)
						    ), 0)							        as credit_amount
						,''											as financial_currency_type_rcd
						,''											as financial_costcentre_code
						,''											as financial_costcentre_name
						,''											as default_user_code
						,''											as default_user_name
                        ,'{00000000-0000-0000-0000-000000000000}'	as booking_id
                    from booking									as b
                    where b.booking_id = @booking_id

                    order by transaction_number
            ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingFinancialTransactions");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingFinancialTransactionsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingFinancialTransactionsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking flights</summary>
        /// <cardinality>Many</cardinality>
        public List<BookingFlightsData> BookingFlights(Guid bookingId) {
            var ret = new List<BookingFlightsData>();

            string sql = @" 
                select top 50 
	                 ai.airline_identifier_code
	                ,fi.flight_identifier_code			as flight_number
	                ,dai.airport_identifier_code		as departure_airport_identifier_code
	                ,da.airport_name					as departure_airport_name
	                ,aai.airport_identifier_code		as arrival_airport_identifier_code
	                ,aa.airport_name					as arrival_airport_name

	                ,fl.from_date_time
	                ,fl.until_date_time
	                ,fl.comment
                    ,bfs.booking_flight_segment_id
                from booking_flight_segment				as bfs
                inner join flight_segment				as fs	on fs.flight_segment_id = bfs.flight_segment_id
                inner join flight						as fl	on fl.flight_id = fs.flight_id
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
                where bfs.booking_id = @booking_id
                  and bfs.became_booking_flight_segment_id is null
                  and bfs.default_state_rcd <> dbo.ref('default_state_ref.I')
            ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingFlights");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingFlightsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingFlightsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking flights</summary>
        /// <cardinality>Many</cardinality>
        /// <generatelayer>dataaccesslayer</generatelayer>
        public List<BookingFlightsSimpleData> BookingFlightsSimple(Guid bookingId) {
            var ret = new List<BookingFlightsSimpleData>();

            string sql = @" 
                select top 50 
                     bfs.booking_flight_segment_id
                    ,fs.flight_id
                    ,fs.departure_airport_id
                    ,fs.arrival_airport_id
                    ,ff.amount
					,ff.financial_currency_id
                    ,ff.financial_fare_id
                from booking_flight_segment				as bfs
                inner join flight_segment				as fs	on fs.flight_segment_id = bfs.flight_segment_id
                inner join financial_fare				as ff	on ff.departure_airport_id = fs.departure_airport_id
															   and ff.arrival_airport_id = fs.arrival_airport_id
                where bfs.booking_id = @booking_id
                  and bfs.became_booking_flight_segment_id is null
                  and bfs.default_state_rcd <> dbo.ref('default_state_ref.I')
            ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingFlightsSimple");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingFlightsSimpleDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingFlightsSimpleData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking passengers</summary>
        /// <cardinality>Many</cardinality>
        /// <layers>data, business, proxy</layers>
        public List<BookingPassengersData> BookingPassengers(Guid bookingId) {
            var ret = new List<BookingPassengersData>();

            string sql = @" 
                    select top 50
                         bp.booking_passenger_id
                        ,pa.passenger_id
                        ,pa.passenger_type_rcd
                        ,ptr.passenger_type_name
                        ,pa.passenger_name
                        ,pa.user_id
                        ,pa.date_time
                    from passenger as pa
                    inner join booking_passenger    as bp   on bp.passenger_id = pa.passenger_id
                    inner join passenger_type_ref   as ptr  on ptr.passenger_type_rcd = pa.passenger_type_rcd
                    where bp.booking_id = @booking_id
                        and bp.became_booking_passenger_id is null
                        and bp.default_state_rcd <> dbo.ref('default_state_ref.I')
                ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingPassengers");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingPassengersDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingPassengersData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking passenger and passenger</summary>
        /// <cardinality>One</cardinality>
        public BookingPassengerWithExtraData BookingPassengerWithExtra(
            Guid bookingPassengerId
            ) {
            var ret = new BookingPassengerWithExtraData();

            string sql = @" 
                            select top 50 
                                 bp.booking_passenger_id
                                ,bp.booking_id
                                ,bp.passenger_id
                                ,p.passenger_type_rcd
                                ,p.passenger_name
                                ,bp.default_state_rcd
                                ,bp.user_id
                                ,bp.date_time
                            from booking_passenger  as bp
                            inner join passenger    as p    on p.passenger_id = bp.passenger_id
                            where bp.booking_passenger_id = @booking_passenger_id
                              and bp.became_booking_passenger_id is null
                              and bp.default_state_rcd <> dbo.ref('default_state_ref.I')
                        ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingPassengerWithExtra");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_passenger_id", SqlDbType.UniqueIdentifier).Value = bookingPassengerId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingPassengerWithExtraDataOrdinals(reader);

                    if ( reader.Read() ) {
                        ret.Populate(reader, ordinals);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get open bookings</summary>
        /// <cardinality>Many</cardinality>
        public List<BookingsOpenData> BookingsOpen() {
            var ret = new List<BookingsOpenData>();

            string sql = @" 
                select top 50
                     bo.booking_id
	                ,(	
		                select top 1 booking_identifier_value
		                from booking_identifier as bi
		                where bi.booking_id = bo.booking_id
		                  and bi.booking_identifier_type_rcd = 'RL'
                        order by bi.date_time desc
	                ) as record_locator
	                ,(	
		                select top 1 betr.booking_event_type_name
		                from booking_event as be
		                inner join booking_event_type_ref as betr on betr.booking_event_type_rcd = be.booking_event_type_rcd
		                where be.booking_id = bo.booking_id
		                order by be.date_time desc
	                ) as last_booking_event_type_name
	                ,(	
		                select top 1 be.date_time
		                from booking_event as be
		                where be.booking_id = bo.booking_id
		                order by be.date_time desc
	                ) as last_booking_event_date_time
	                ,(	
		                select top 1 bcm.contact_method_way
		                from booking_contact_method as bcm
		                inner join contact_method_ref as cmr on cmr.contact_method_rcd = bcm.contact_method_rcd
		                where bcm.booking_id = bo.booking_id
		                order by bcm.date_time desc
	                ) as last_booking_contact_method

	                ,bsr.booking_source_name
	                ,(select count(*)
					  from booking_passenger as bp
					  inner join passenger as pa on pa.passenger_id = bp.passenger_id
											and pa.passenger_type_rcd = 'AD'
					  where bp.booking_id = bo.booking_id
					  ) as adult_count
	                ,(select count(*)
					  from booking_passenger as bp
					  inner join passenger as pa on pa.passenger_id = bp.passenger_id
											and pa.passenger_type_rcd = 'CHD'
					  where bp.booking_id = bo.booking_id
					  ) as child_count
	                ,(select count(*)
					  from booking_passenger as bp
					  inner join passenger as pa on pa.passenger_id = bp.passenger_id
											and pa.passenger_type_rcd = 'INF'
					  where bp.booking_id = bo.booking_id
					  ) as infant_count
                    ,(	select 
						coalesce((select sum(fbt.amount)						
						from financial_booking_transaction	as fbt
						where fbt.booking_id = bo.booking_id
						and (fbt.financial_payment_id is null
							and fbt.financial_adjustment_id is null)
						), 0)
					- coalesce((select sum(fbt.amount)						
						from financial_booking_transaction	as fbt
						where fbt.booking_id = bo.booking_id
						and (fbt.financial_payment_id is not null
							or fbt.financial_adjustment_id is not null)
						), 0))											as balance_amount


                from booking as bo
                inner join booking_source_ref as bsr on bsr.booking_source_rcd = bo.booking_source_rcd
                --realwhere
                order by bo.date_time desc
                -- (todo, crazy expensive) order by last_booking_event_date_time desc
            ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingsOpen");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingsOpenDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingsOpenData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking history</summary>
        /// <cardinality>Many</cardinality>
        public List<BookingEventHistoryData> BookingEventHistory(Guid bookingId) {
            var ret = new List<BookingEventHistoryData>();

            string sql = @" 
                select top 50 
	                 be.date_time					as date_time
					,'Booking'						as history_event_group_name
	                ,betr.booking_event_type_name	as history_event_type_name
	                ,be.comment						as history_event_description
                from booking_event as be
                inner join booking_event_type_ref as betr on betr.booking_event_type_rcd = be.booking_event_type_rcd
                where be.booking_id = @booking_id

                union

                select top 50 
	                 bp.date_time					as date_time
					,'Passenger'					as history_event_group_name
	                ,dsr.default_state_name			as history_event_type_name
	                ,pa.passenger_name				as history_event_description
                from booking_passenger				as bp
                inner join passenger				as pa	on pa.passenger_id = bp.passenger_id
				inner join default_state_ref		as dsr	on dsr.default_state_rcd = bp.default_state_rcd
                where bp.booking_id = @booking_id
				
				union
                
				select top 50 
	                 bfs.date_time							as date_time
					,'Flight'								as history_event_group_name
	                ,dsr.default_state_name					as history_event_type_name
					,ai.airline_identifier_code
					 + ' ' + fi.flight_identifier_code		
	                 + ' ' + dai.airport_identifier_code	
	                 + ' ' + da.airport_name				
	                 + ' ' + aai.airport_identifier_code	
	                 + ' ' + aa.airport_name				
															as history_event_description
                from booking_flight_segment					as bfs
                inner join flight_segment					as fs	on fs.flight_segment_id = bfs.flight_segment_id
				inner join flight							as fl	on fl.flight_id = fs.flight_id
				inner join default_state_ref				as dsr	on dsr.default_state_rcd = bfs.default_state_rcd
	            inner join airline_identifier				as ai	on ai.airline_id = fl.airline_id
															    	and ai.airline_identifier_type_rcd = dbo.ref('airline_identifier_type_ref.AC3')
                inner join airport							as da	on da.airport_id = fl.departure_airport_id
                inner join airport							as aa	on aa.airport_id = fl.arrival_airport_id
                inner join airport_identifier				as dai	on dai.airport_id = fl.departure_airport_id
															        and dai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
                inner join airport_identifier				as aai	on aai.airport_id = fl.arrival_airport_id
															        and aai.airport_identifier_type_rcd = dbo.ref('airport_identifier_type_ref.AC3')
	                left join flight_identifier				as fi	on fi.flight_id = fl.flight_id
																    and fi.flight_identifier_type_rcd = dbo.ref('flight_identifier_type_ref.FN3')
                where bfs.booking_id = @booking_id

                --realwhere

                order by date_time 
            ";

            Logging log = Logging.PerformanceTimeStart("Booking", "DataAccessLayer", "BookingSearch", "BookingEventHistory");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingEventHistoryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingEventHistoryData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get booking statistics pr day</summary>
        /// <cardinality>Many</cardinality>
        public List<BookingStatisticsData> BookingStatistics(
            Guid departureAirportId,
            Guid arrivalAirportId,
            DateTime fromDateTime,
            DateTime untilDateTime
            ) {

            var ret = new List<BookingStatisticsData>();

            string sql = @"
                select 
	                rr.date
	                ,(	select rri.count_number
		                from reporting_roundup	as rri
		                where rri.date = rr.date
			                and rri.reporting_roundup_type_rcd = dbo.ref('reporting_roundup_type_ref.Bookings') 
		                ) as passengers_booked_count
	                ,(	select rri.count_number
		                from reporting_roundup	as rri
		                where rri.date = rr.date
			                and rri.reporting_roundup_type_rcd = dbo.ref('reporting_roundup_type_ref.BP') 
			                and rri.reporting_reference_code = dbo.ref('passenger_type_ref.AD') 
		                ) as adult_booked_count
	                ,(	select rri.count_number
		                from reporting_roundup	as rri
		                where rri.date = rr.date
			                and rri.reporting_roundup_type_rcd = dbo.ref('reporting_roundup_type_ref.BP') 
			                and rri.reporting_reference_code = dbo.ref('passenger_type_ref.CHD') 
		                ) as child_booked_count
	                ,(	select rri.count_number
		                from reporting_roundup	as rri
		                where rri.date = rr.date
			                and rri.reporting_roundup_type_rcd = dbo.ref('reporting_roundup_type_ref.BP') 
			                and rri.reporting_reference_code = dbo.ref('passenger_type_ref.INF') 
		                ) as infant_booked_count
                from reporting_roundup	as rr
                --realwhere
                where rr.date between @from_date_time and @until_date_time";

            if ( departureAirportId != Guid.Empty )
                sql += "                      and fl.departure_airport_id = @departure_airport_id\r\n";

            if ( arrivalAirportId != Guid.Empty )
                sql += "                      and fl.arrival_airport_id = @arrival_airport_id\r\n";

            sql += @"
                group by 
                    rr.date

                order by
	                rr.date
                ";

            Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.FlightSearch.BookingStatistics");
            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@departure_airport_id", SqlDbType.UniqueIdentifier).Value = departureAirportId;
                    command.Parameters.Add("@arrival_airport_id", SqlDbType.UniqueIdentifier).Value = arrivalAirportId;
                    command.Parameters.Add("@from_date_time", SqlDbType.DateTime).Value = fromDateTime;
                    command.Parameters.Add("@until_date_time", SqlDbType.DateTime).Value = untilDateTime;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new BookingStatisticsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new BookingStatisticsData();
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
