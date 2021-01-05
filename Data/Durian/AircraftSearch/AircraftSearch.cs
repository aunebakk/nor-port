/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 7:52:33 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DataCodeClassMakeAsString
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer {
    /// <summary>
    /// Provides search with different parameter and result sets
    /// links:
    ///  docLink: http://sql2x.org/documentationLink/e0a5f4fb-b246-4074-bfd7-d19e48bcd057
    /// </summary>
    /// <domain>Aircraft</domain>
    public partial class AircraftSearch {
        /// <summary>
        /// Get Aircraft Identifier
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<AircraftIdentifierIndexWithFilterData> AircraftIdentifierIndexWithFilter (
            System.Guid aircraftId
            ) {
            var ret = new List<AircraftIdentifierIndexWithFilterData>();
            string sql = @"
select 
     [a].aircraft_name
    ,[aitr].aircraft_identifier_type_name
    ,[du].default_user_name
    ,[a].engine_type
    ,[ai].aircraft_id
    ,[ai].aircraft_identifier_type_rcd
    ,[ai].aircraft_identifier_code
    ,[ai].user_id
    ,[ai].date_time
    ,[ai].aircraft_identifier_id
from aircraft_identifier as [ai]
inner join aircraft as [a] on [a].aircraft_id = [ai].aircraft_id
inner join aircraft_identifier_type_ref as [aitr] on [aitr].aircraft_identifier_type_rcd = [ai].aircraft_identifier_type_rcd
inner join default_user as [du] on [du].default_user_id = [ai].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (aircraftId != Guid.Empty) {
                        command.Parameters.Add("@aircraft_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) aircraftId;
                        sql += " and [ai].aircraft_id = @aircraft_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("AircraftIdentifierIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftIdentifierIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new AircraftIdentifierIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>
        /// Get Aircraft Document
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<AircraftDocumentIndexWithFilterData> AircraftDocumentIndexWithFilter (
            System.Guid aircraftId
            ) {
            var ret = new List<AircraftDocumentIndexWithFilterData>();
            string sql = @"
select 
     [a].aircraft_name
    ,[adtr].aircraft_document_type_name
    ,[ad].document_name
    ,[du].default_user_name
    ,[a].engine_type
    ,[ad].aircraft_id
    ,[ad].aircraft_document_type_rcd
    ,[ad].document_date_time
    ,[ad].expiry_date_time
    ,[ad].user_id
    ,[ad].date_time
    ,[ad].aircraft_document_id
from aircraft_document as [ad]
inner join aircraft as [a] on [a].aircraft_id = [ad].aircraft_id
inner join aircraft_document_type_ref as [adtr] on [adtr].aircraft_document_type_rcd = [ad].aircraft_document_type_rcd
inner join default_user as [du] on [du].default_user_id = [ad].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (aircraftId != Guid.Empty) {
                        command.Parameters.Add("@aircraft_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) aircraftId;
                        sql += " and [ad].aircraft_id = @aircraft_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("AircraftDocumentIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftDocumentIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new AircraftDocumentIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>
        /// Get Aircraft Compartment
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<AircraftCompartmentIndexWithFilterData> AircraftCompartmentIndexWithFilter (
            System.Guid aircraftId
            ) {
            var ret = new List<AircraftCompartmentIndexWithFilterData>();
            string sql = @"
select 
     [a].aircraft_name
    ,[actr].aircraft_compartment_type_name
    ,[ac].aircraft_compartment_name
    ,[du].default_user_name
    ,[a].engine_type
    ,[ac].aircraft_id
    ,[ac].aircraft_compartment_measurement_id
    ,[ac].aircraft_compartment_type_rcd
    ,[ac].user_id
    ,[ac].date_time
    ,[ac].aircraft_compartment_id
from aircraft_compartment as [ac]
inner join aircraft as [a] on [a].aircraft_id = [ac].aircraft_id
left join aircraft_compartment_measurement as [acm] on [acm].aircraft_compartment_measurement_id = [ac].aircraft_compartment_measurement_id
inner join aircraft_compartment_type_ref as [actr] on [actr].aircraft_compartment_type_rcd = [ac].aircraft_compartment_type_rcd
inner join default_user as [du] on [du].default_user_id = [ac].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (aircraftId != Guid.Empty) {
                        command.Parameters.Add("@aircraft_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) aircraftId;
                        sql += " and [ac].aircraft_id = @aircraft_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("AircraftCompartmentIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftCompartmentIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new AircraftCompartmentIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>
        /// Get Aircraft
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkWithDurian</template>
        /// <cardinality>Many</cardinality>
        public List<AircraftIndexWithFilterData> AircraftIndexWithFilter() {
            var ret = new List<AircraftIndexWithFilterData>();
            string sql = @"
select 
     [a].aircraft_name
    ,[atr].aircraft_type_name
    ,[acr].aircraft_configuration_name
    ,[abr].aircraft_body_name
    ,[p].product_name
    ,[du].default_user_name
    ,[a].aircraft_type_rcd
    ,[a].aircraft_configuration_rcd
    ,[a].aircraft_body_rcd
    ,[a].aircraft_measurement_id
    ,[a].product_id
    ,[a].operational_date_time
    ,[a].first_flight_date_time
    ,[a].engine_type
    ,[a].passenger_capacity
    ,[a].user_id
    ,[a].date_time
    ,[a].aircraft_id
from aircraft as [a]
inner join aircraft_type_ref as [atr] on [atr].aircraft_type_rcd = [a].aircraft_type_rcd
inner join aircraft_configuration_ref as [acr] on [acr].aircraft_configuration_rcd = [a].aircraft_configuration_rcd
inner join aircraft_body_ref as [abr] on [abr].aircraft_body_rcd = [a].aircraft_body_rcd
left join aircraft_measurement as [am] on [am].aircraft_measurement_id = [a].aircraft_measurement_id
left join product as [p] on [p].product_id = [a].product_id
inner join default_user as [du] on [du].default_user_id = [a].user_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("AircraftIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new AircraftIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new AircraftIndexWithFilterData();
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
