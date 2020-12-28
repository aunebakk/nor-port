using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer {
    /// <summary> 
    /// Provides Aircraft maintenance search with different parameter and result sets
    /// </summary>
    /// <domain>Aircraft</domain>
    public partial class AircraftSearch {
        /// <summary>Get Aircraft details for PIM stuff</summary>
        /// <cardinality>Many</cardinality>
        public List<AircraftDetailsData> AircraftDetails() {
            var ret = new List<AircraftDetailsData>();
            string sql = @"
SELECT 
     a.aircraft_name
	,atr.aircraft_family_image
    ,acr.aircraft_configuration_name
    ,abr.aircraft_body_name
    ,atr.aircraft_type_name
	,'' as product_info_value
    ,a.aircraft_id
FROM aircraft AS a
LEFT JOIN aircraft_configuration_ref AS acr
    ON acr.aircraft_configuration_rcd = a.aircraft_configuration_rcd
INNER JOIN aircraft_body_ref AS abr
    ON abr.aircraft_body_rcd = a.aircraft_body_rcd
INNER JOIN aircraft_type_ref AS atr
    ON atr.aircraft_type_rcd = a.aircraft_type_rcd
--realwhere
WHERE 1 = 1
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("AircraftDetails");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftDetailsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AircraftDetailsData();
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
