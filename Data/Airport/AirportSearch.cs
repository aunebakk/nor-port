using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer {
    /// <summary> 
    /// Provides Airport search with different parameter and result sets
    /// </summary>
    /// <domain>Airport</domain>
    public partial class AirportSearch {
        /// <summary>
        /// Get Airport Identifier
        /// Get Airport Identifier
        /// Get Airport Identifier
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<AirportIdentifierIndexWithFilterData> AirportIdentifierIndexWithFilter() {
            var ret = new List<AirportIdentifierIndexWithFilterData>();
            string sql = @"
select 
     [a].airport_name
    ,[aitr].airport_identifier_type_name
    ,[du].default_user_name
    ,[ai].airport_id
    ,[ai].airport_identifier_type_rcd
    ,[ai].airport_identifier_code
    ,[ai].user_id
    ,[ai].date_time
    ,[ai].airport_identifier_id
from airport_identifier as [ai]
inner join airport as [a] on [a].airport_id = [ai].airport_id
inner join airport_identifier_type_ref as [aitr] on [aitr].airport_identifier_type_rcd = [ai].airport_identifier_type_rcd
inner join default_user as [du] on [du].default_user_id = [ai].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("AirportIdentifierIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new AirportIdentifierIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new AirportIdentifierIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>
        /// Get Airport
        /// Get Airport
        /// Get Airport
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<GetAirportIndexWithFilterData> GetAirportIndexWithFilter() {
            var ret = new List<GetAirportIndexWithFilterData>();
            string sql = @"
select 
     [a].airport_name
    ,[atr].airport_type_name
    ,[c].city_name
    ,[p].product_name
    ,[du].default_user_name
    ,[a].airport_type_rcd
    ,[a].city_id
    ,[a].product_id
    ,[a].utc_offset
    ,[a].elevation_in_meters
    ,[a].runway_in_meters
    ,[a].latitude
    ,[a].longitude
    ,[a].timezone_id
    ,[a].variation
    ,[a].attendance
    ,[a].control_tower_flag
    ,[a].activation_date_time
    ,[a].user_id
    ,[a].date_time
    ,[a].airport_id
from airport as [a]
left join airport_type_ref as [atr] on [atr].airport_type_rcd = [a].airport_type_rcd
inner join city as [c] on [c].city_id = [a].city_id
left join product as [p] on [p].product_id = [a].product_id
left join timezone as [t] on [t].timezone_id = [a].timezone_id
inner join default_user as [du] on [du].default_user_id = [a].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("GetAirportIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetAirportIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GetAirportIndexWithFilterData();
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
