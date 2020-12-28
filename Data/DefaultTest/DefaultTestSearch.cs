using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer {
    /// <summary> 
    /// Default Test Durians
    /// </summary>
    /// <domain>DefaultTest</domain>
    public partial class DefaultTestSearch {
    
        /// <summary>Get Default Test</summary>
        /// <cardinality>Many</cardinality>
        /// <template>ByServiceTableCrud</template>
        public List<DefaultTestSearchQueryData> DefaultTestSearchQuery() {
            var ret = new List<DefaultTestSearchQueryData>();
            string sql = @"
select 
	  dt.test_area
	 ,dt.test_sub_area
	 ,( select 
			top 1 dtr.default_test_run_result_rcd
		from default_test_run as dtr
		where dtr.default_test_id = dt.default_test_id
		) as default_test_run_result_rcd
	 ,( select 
			top 1 dtr.elapsed_milliseconds
		from default_test_run as dtr
		where dtr.default_test_id = dt.default_test_id
		) as elapsed_milliseconds
	 ,( select 
			top 1 dtr.date_time
		from default_test_run as dtr
		where dtr.default_test_id = dt.default_test_id
		) as date_time
	 ,dt.test_address
from default_test as dt
--realwhere
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("DefaultTestSearchWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new DefaultTestSearchQueryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new DefaultTestSearchQueryData();
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
