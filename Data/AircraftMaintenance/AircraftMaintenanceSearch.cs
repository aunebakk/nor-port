using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides Aircraft maintenance search with different parameter and result sets
    /// </summary>
    /// <domain>AircraftMaintenance</domain>
    public class AircraftMaintenanceSearch
    {

        /// <summary>Get Aircraft Document</summary>
        /// <cardinality>Many</cardinality>
        public List<AircraftMaintenanceDocumentIndexWithFilterData> AircraftMaintenanceDocumentIndexWithFilter(
             System.Guid aircraftId
            ) {
            var ret = new List<AircraftMaintenanceDocumentIndexWithFilterData>();
            string sql = @"
SELECT ad.aircraft_id
    ,a.aircraft_name AS aircraft_name
    ,ad.aircraft_document_type_rcd
    ,adtr.aircraft_document_type_name
    ,ad.document_name
    ,ad.document_date_time
    ,ad.expiry_date_time
    ,ad.user_id
    ,du.default_user_name
    ,ad.date_time
    ,ad.aircraft_document_id
FROM aircraft_document AS ad
INNER JOIN aircraft AS a
    ON a.aircraft_id = ad.aircraft_id
INNER JOIN aircraft_document_type_ref AS adtr
    ON adtr.aircraft_document_type_rcd = ad.aircraft_document_type_rcd
INNER JOIN default_user AS du
    ON du.default_user_id = ad.user_id
WHERE 1 = 1
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    if ( aircraftId != Guid.Empty ) {
                        command.Parameters.Add("@aircraft_id", SqlDbType.UniqueIdentifier).Value = ( System.Guid ) aircraftId;
                        sql += " and ad.aircraft_id = @aircraft_id";
                    }

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("AircraftMaintenanceDocumentIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftMaintenanceDocumentIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AircraftMaintenanceDocumentIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Aircraft Identifier</summary>
        /// <cardinality>Many</cardinality>
        public List<AircraftMaintenanceIdentifierIndexWithFilterData> AircraftMaintenanceIdentifierIndexWithFilter(
             System.Guid aircraftId
            ) {
            var ret = new List<AircraftMaintenanceIdentifierIndexWithFilterData>();
            string sql = @"
SELECT ai.aircraft_id
    ,a.aircraft_name AS aircraft_name
    ,ai.aircraft_identifier_type_rcd
    ,aitr.aircraft_identifier_type_name
    ,ai.aircraft_identifier_code
    ,ai.user_id
    ,du.default_user_name
    ,ai.date_time
    ,ai.aircraft_identifier_id
FROM aircraft_identifier AS ai
INNER JOIN aircraft AS a
    ON a.aircraft_id = ai.aircraft_id
INNER JOIN aircraft_identifier_type_ref AS aitr
    ON aitr.aircraft_identifier_type_rcd = ai.aircraft_identifier_type_rcd
INNER JOIN default_user AS du
    ON du.default_user_id = ai.user_id
WHERE 1 = 1
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    if ( aircraftId != Guid.Empty ) {
                        command.Parameters.Add("@aircraft_id", SqlDbType.UniqueIdentifier).Value = ( System.Guid ) aircraftId;
                        sql += " and ai.aircraft_id = @aircraft_id";
                    }

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("AircraftMaintenanceIdentifierIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftMaintenanceIdentifierIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AircraftMaintenanceIdentifierIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Aircraft Compartment</summary>
        /// <cardinality>Many</cardinality>
        public List<AircraftMaintenanceCompartmentIndexWithFilterData> AircraftMaintenanceCompartmentIndexWithFilter(
             System.Guid aircraftId
            ) {
            var ret = new List<AircraftMaintenanceCompartmentIndexWithFilterData>();
            string sql = @"
SELECT ac.aircraft_id
    ,a.aircraft_name AS aircraft_name
    ,ac.aircraft_compartment_type_rcd
    ,actr.aircraft_compartment_type_name
    ,ac.aircraft_compartment_name
    ,ac.user_id
    ,du.default_user_name
    ,ac.date_time
    ,ac.aircraft_compartment_id
    ,ac.aircraft_compartment_measurement_id
FROM aircraft_compartment AS ac
INNER JOIN aircraft AS a
    ON a.aircraft_id = ac.aircraft_id
INNER JOIN aircraft_compartment_type_ref AS actr
    ON actr.aircraft_compartment_type_rcd = ac.aircraft_compartment_type_rcd
INNER JOIN default_user AS du
    ON du.default_user_id = ac.user_id
WHERE 1 = 1
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    if ( aircraftId != Guid.Empty ) {
                        command.Parameters.Add("@aircraft_id", SqlDbType.UniqueIdentifier).Value = ( System.Guid ) aircraftId;
                        sql += " and ac.aircraft_id = @aircraft_id";
                    }

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("AircraftMaintenanceCompartmentIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftMaintenanceCompartmentIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AircraftMaintenanceCompartmentIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Aircraft</summary>
        /// <cardinality>Many</cardinality>
        public List<AircraftMaintenanceIndexWithFilterData> AircraftMaintenanceIndexWithFilter() {
            var ret = new List<AircraftMaintenanceIndexWithFilterData>();
            string sql = @"
SELECT 
     a.aircraft_name
    ,a.aircraft_configuration_rcd
    ,acr.aircraft_configuration_name
    ,a.aircraft_body_rcd
    ,abr.aircraft_body_name
    ,a.aircraft_type_rcd
    ,atr.aircraft_type_name
    ,a.engine_type
    ,a.operational_date_time
    ,a.first_flight_date_time
    ,a.passenger_capacity
    ,a.user_id
    ,du.default_user_name
    ,a.date_time
    ,a.aircraft_id
    ,a.product_id
FROM aircraft AS a
LEFT JOIN aircraft_configuration_ref AS acr
    ON acr.aircraft_configuration_rcd = a.aircraft_configuration_rcd
INNER JOIN aircraft_body_ref AS abr
    ON abr.aircraft_body_rcd = a.aircraft_body_rcd
INNER JOIN aircraft_type_ref AS atr
    ON atr.aircraft_type_rcd = a.aircraft_type_rcd
INNER JOIN default_user AS du
    ON du.default_user_id = a.user_id
WHERE 1 = 1
";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("AircraftMaintenanceIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftMaintenanceIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AircraftMaintenanceIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Aircraft details for PIM stuff</summary>
        /// <cardinality>Many</cardinality>
        public List<AircraftPIMDetailsData> AircraftPIMDetails() {
            var ret = new List<AircraftPIMDetailsData>();
            string sql = @"
SELECT 
     a.aircraft_name
	,atr.aircraft_family_image
    ,acr.aircraft_configuration_name
    ,abr.aircraft_body_name
    ,atr.aircraft_type_name
	,0 as product_info_value
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

                    Logging log = Logging.PerformanceTimeStart("AircraftPIMDetails");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftPIMDetailsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new AircraftPIMDetailsData();
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
