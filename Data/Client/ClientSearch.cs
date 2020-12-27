using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides client search with different parameter and result sets
    /// </summary>
    /// <domain>Client</domain>
    public class ClientSearch
    {
        /// <summary>Get Client</summary>
        /// <cardinality>Many</cardinality>
        public List<GetClientWithFilterData> GetClientWithFilter(
             System.String lastName
            , System.String clientTypeRcd
            ) {

            var ret = new List<GetClientWithFilterData>();
            string sql = @"select
     c.first_name
    ,c.middle_name
    ,c.last_name
    ,c.passenger_type_rcd
    ,ptr.passenger_type_name
    ,c.nationality_rcd
    ,nr.nationality_name
    ,c.gender_rcd
    ,gr.gender_name
    ,c.title_rcd
    ,tr.title_name
    ,c.client_type_rcd
    ,ctr.client_type_name
    ,c.user_id
    ,du.default_user_name
    ,c.date_time
    ,c.client_id
    ,c.default_user_id
from client as c
inner join default_user as du on du.default_user_id = c.user_id
left join passenger_type_ref as ptr on ptr.passenger_type_rcd = c.passenger_type_rcd
left join nationality_ref as nr on nr.nationality_rcd = c.nationality_rcd
left join gender_ref as gr on gr.gender_rcd = c.gender_rcd
left join title_ref as tr on tr.title_rcd = c.title_rcd
left join client_type_ref as ctr on ctr.client_type_rcd = c.client_type_rcd
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    //command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = lastName;
                    //command.Parameters.Add("@client_type_rcd", SqlDbType.NVarChar).Value = clientTypeRcd;

                    Logging log = Logging.PerformanceTimeStart("GetClientWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetClientWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetClientWithFilterData();
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
