using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides service search with different parameter and result sets
    /// </summary>
    /// <domain>Service</domain>
    public class ServiceSearch
    {

        /// <summary>Get Service Package Promotion</summary>
        /// <cardinality>Many</cardinality>
        public List<ServicePackagePromotionWithFilterData> ServicePackagePromotionWithFilter(
             System.Guid clientId
            ) {

            var ret = new List<ServicePackagePromotionWithFilterData>();
            string sql = @"select
     sp.service_package_name as service_package_name
    ,spp.client_id
    ,c.first_name + ' ' + c.last_name as client_name
    ,spp.promotion_price_amount
    ,spp.financial_currency_id
    ,fc.financial_currency_type_name as financial_currency_type_name
    ,spp.user_id
    ,du.default_user_name
    ,spp.date_time
    ,spp.service_package_promotion_id
    ,spp.service_package_id
from service_package_promotion as spp
inner join service_package as sp on sp.service_package_id = spp.service_package_id
inner join client as c on c.client_id = spp.client_id
inner join financial_currency as fc on fc.financial_currency_id = spp.financial_currency_id
inner join default_user as du on du.default_user_id = spp.user_id
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    //command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    Logging log = Logging.PerformanceTimeStart("ServicePackagePromotionWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new ServicePackagePromotionWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ServicePackagePromotionWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Service Special Service Request</summary>
        /// <cardinality>Many</cardinality>
        public List<FetchServiceSpecialServiceRequestWithFilterData> FetchServiceSpecialServiceRequestWithFilter(
             System.String serviceSpecialServiceRequestGroupRcd
            , System.String serviceSpecialServiceRequestCode
            , System.String requestServiceSpecialServiceRequestRequirementRcd
            , System.String replyServiceSpecialServiceRequestRequirementRcd
            , System.String serviceSpecialServiceRequestOperationRuleRcd
            ) {

            var ret = new List<FetchServiceSpecialServiceRequestWithFilterData>();
            string sql = @"
                select
                     sssr.service_special_service_request_group_rcd
                    ,sssrgr.service_special_service_request_group_name
                    ,sssr.service_special_service_request_code
                    ,sssr.service_special_service_request_name
                    ,sssr.service_description
                    ,sssr.amount
                    ,sssr.financial_currency_id
                    ,fc.financial_currency_type_name as financial_currency_type_name
                    ,sssr.inventory_controlled_flag
                    ,sssr.request_service_special_service_request_requirement_rcd
                    ,rsssrrr.service_special_service_request_requirement_name as request_requirement_name
                    ,sssr.reply_service_special_service_request_requirement_rcd
                    ,resssrrr.service_special_service_request_requirement_name as reply_requirement_name
                    ,sssr.service_special_service_request_operation_rule_rcd
                    ,sssrorr.service_special_service_request_operation_rule_name
                    ,sssr.user_id
                    ,du.default_user_name
                    ,sssr.date_time
                    ,sssr.service_special_service_request_id
                from service_special_service_request as sssr
                inner join service_special_service_request_group_ref as sssrgr on sssrgr.service_special_service_request_group_rcd = sssr.service_special_service_request_group_rcd
                left join financial_currency as fc on fc.financial_currency_id = sssr.financial_currency_id
                inner join service_special_service_request_requirement_ref as rsssrrr on rsssrrr.service_special_service_request_requirement_rcd = sssr.request_service_special_service_request_requirement_rcd
                inner join service_special_service_request_requirement_ref as resssrrr on resssrrr.service_special_service_request_requirement_rcd = sssr.reply_service_special_service_request_requirement_rcd
                inner join service_special_service_request_operation_rule_ref as sssrorr on sssrorr.service_special_service_request_operation_rule_rcd = sssr.service_special_service_request_operation_rule_rcd
                inner join default_user as du on du.default_user_id = sssr.user_id
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@service_special_service_request_group_rcd", SqlDbType.NVarChar).Value = serviceSpecialServiceRequestGroupRcd;
                    command.Parameters.Add("@service_special_service_request_code", SqlDbType.NVarChar).Value = serviceSpecialServiceRequestCode;
                    command.Parameters.Add("@request_service_special_service_request_requirement_rcd", SqlDbType.NVarChar).Value = requestServiceSpecialServiceRequestRequirementRcd;
                    command.Parameters.Add("@reply_service_special_service_request_requirement_rcd", SqlDbType.NVarChar).Value = replyServiceSpecialServiceRequestRequirementRcd;
                    command.Parameters.Add("@service_special_service_request_operation_rule_rcd", SqlDbType.NVarChar).Value = serviceSpecialServiceRequestOperationRuleRcd;

                    Logging log = Logging.PerformanceTimeStart("FetchServiceSpecialServiceRequestWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new FetchServiceSpecialServiceRequestWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new FetchServiceSpecialServiceRequestWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Service Package</summary>
        /// <cardinality>Many</cardinality>
        public List<GetServicePackageData> GetServicePackage(
            System.Guid servicePackageId
            ) {

            var ret = new List<GetServicePackageData>();
            string sql = @"select
     sp.service_package_name
    ,sp.service_hotel_id
    ,sh.hotel_name as hotel_name
    ,sp.service_special_service_request_id
    ,sssr.service_special_service_request_name as service_special_service_request_name
    ,sp.service_car_rental_id
    ,scr.car_name as car_name
    ,sp.departure_airport_id
    ,da.airport_name as departure_airport_name
    ,sp.arrival_airport_id
    ,aa.airport_name as arrival_airport_name
    ,sp.stay_duration_days
    ,sp.user_id
    ,du.default_user_name
    ,sp.date_time
    ,sp.service_package_id
from service_package as sp
left join service_hotel as sh on sh.service_hotel_id = sp.service_hotel_id
left join service_special_service_request as sssr on sssr.service_special_service_request_id = sp.service_special_service_request_id
left join service_car_rental as scr on scr.service_car_rental_id = sp.service_car_rental_id
inner join airport as da on da.airport_id = sp.departure_airport_id
inner join airport as aa on aa.airport_id = sp.arrival_airport_id
inner join default_user as du on du.default_user_id = sp.user_id
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    if ( servicePackageId != Guid.Empty ) {
                        command.Parameters.Add("@service_package_id", SqlDbType.UniqueIdentifier).Value = servicePackageId;
                        sql += " where sp.service_package_id = @service_package_id";
                    }

                    Logging log = Logging.PerformanceTimeStart("GetServicePackage");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetServicePackageDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetServicePackageData();
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
