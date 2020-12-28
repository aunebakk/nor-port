using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides ferry search with different parameter and result sets
    /// </summary>
    /// <domain>Ferry</domain>
    public class FerrySearch
    {
        /// <summary>Get Ferry</summary>
        /// <cardinality>Many</cardinality>
        public List<GetFerryIndexWithFilterData> GetFerryIndexWithFilter() {
            var ret = new List<GetFerryIndexWithFilterData>();
            string sql = @"
                SELECT f.ferry_name
                    ,f.ferry_type_rcd
                    ,ftr.ferry_type_name
                    ,f.product_id
                    ,p.product_name AS product_name
                    ,f.first_float_date_time
                    ,f.operational_date_time
                    ,f.engine_type
                    ,f.passenger_capacity
                    ,f.user_id
                    ,du.default_user_name
                    ,f.date_time
                    ,f.ferry_id
                FROM ferry AS f
                INNER JOIN ferry_type_ref AS ftr
                    ON ftr.ferry_type_rcd = f.ferry_type_rcd
                LEFT JOIN product AS p
                    ON p.product_id = f.product_id
                INNER JOIN default_user AS du
                    ON du.default_user_id = f.user_id
                WHERE 1 = 1
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("GetFerryIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetFerryIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetFerryIndexWithFilterData();
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
