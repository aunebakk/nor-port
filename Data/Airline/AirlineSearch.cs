using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides airline search with different parameter and result sets
    /// </summary>
    /// <domain>Airline</domain>
    public partial class AirlineSearch
    {
        /// <summary>
        /// Get Airline Identifier
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<AirlineIdentifierIndexWithFilterData> AirlineIdentifierIndexWithFilter() {
            var ret = new List<AirlineIdentifierIndexWithFilterData>();
            string sql = @"
select 
     [a].airline_name
    ,[a].legal_name
    ,[aitr].airline_identifier_type_name
    ,[du].default_user_name
    ,[ai].airline_id
    ,[ai].airline_identifier_type_rcd
    ,[ai].airline_identifier_code
    ,[ai].user_id
    ,[ai].date_time
    ,[ai].airline_identifier_id
from airline_identifier as [ai]
inner join airline as [a] on [a].airline_id = [ai].airline_id
inner join airline_identifier_type_ref as [aitr] on [aitr].airline_identifier_type_rcd = [ai].airline_identifier_type_rcd
inner join default_user as [du] on [du].default_user_id = [ai].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("AirlineIdentifierIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new AirlineIdentifierIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new AirlineIdentifierIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>
        /// Get Airline
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<GetAirlineIndexWithFilterData> GetAirlineIndexWithFilter() {
            var ret = new List<GetAirlineIndexWithFilterData>();
            string sql = @"
select 
     [a].airline_name
    ,[atr].airline_type_name
    ,[a].legal_name
    ,[p].product_name
    ,[du].default_user_name
    ,[a].airline_type_rcd
    ,[a1].address_one
    ,[a1].address_two
    ,[a1].address_three
    ,[a1].city
    ,[a1].street
    ,[a1].state
    ,[a1].district
    ,[a1].province
    ,[a1].zip_code
    ,[a1].po_box
    ,[a1].comment
    ,[a].address_id
    ,[a].product_id
    ,[a].stock_market_symbol
    ,[a].aircraft_count
    ,[a].user_id
    ,[a].date_time
    ,[a].airline_id
from airline as [a]
inner join airline_type_ref as [atr] on [atr].airline_type_rcd = [a].airline_type_rcd
left join address as [a1] on [a1].address_id = [a].address_id
left join product as [p] on [p].product_id = [a].product_id
inner join default_user as [du] on [du].default_user_id = [a].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("GetAirlineIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetAirlineIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GetAirlineIndexWithFilterData();
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
