/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:08:25 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPort.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in AircraftMaintenanceDocumentIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class AircraftMaintenanceDocumentIndexWithFilterData {
        
        public System.Guid AircraftId { get; set; }
        
        public string AircraftName { get; set; }
        
        public string AircraftDocumentTypeRcd { get; set; }
        
        public string AircraftDocumentTypeName { get; set; }
        
        public string DocumentName { get; set; }
        
        public System.DateTime DocumentDateTime { get; set; }
        
        public System.DateTime ExpiryDateTime { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AircraftDocumentId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, AircraftMaintenanceDocumentIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AircraftId)) AircraftId = reader.GetGuid(ordinals.AircraftId);
            if (!reader.IsDBNull(ordinals.AircraftName)) AircraftName = reader.GetString(ordinals.AircraftName);
            if (!reader.IsDBNull(ordinals.AircraftDocumentTypeRcd)) AircraftDocumentTypeRcd = reader.GetString(ordinals.AircraftDocumentTypeRcd);
            if (!reader.IsDBNull(ordinals.AircraftDocumentTypeName)) AircraftDocumentTypeName = reader.GetString(ordinals.AircraftDocumentTypeName);
            if (!reader.IsDBNull(ordinals.DocumentName)) DocumentName = reader.GetString(ordinals.DocumentName);
            if (!reader.IsDBNull(ordinals.DocumentDateTime)) DocumentDateTime = reader.GetDateTime(ordinals.DocumentDateTime);
            if (!reader.IsDBNull(ordinals.ExpiryDateTime)) ExpiryDateTime = reader.GetDateTime(ordinals.ExpiryDateTime);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AircraftDocumentId)) AircraftDocumentId = reader.GetGuid(ordinals.AircraftDocumentId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in AircraftMaintenanceDocumentIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class AircraftMaintenanceDocumentIndexWithFilterDataOrdinals {
        
        public int AircraftId;
        
        public int AircraftName;
        
        public int AircraftDocumentTypeRcd;
        
        public int AircraftDocumentTypeName;
        
        public int DocumentName;
        
        public int DocumentDateTime;
        
        public int ExpiryDateTime;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int AircraftDocumentId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public AircraftMaintenanceDocumentIndexWithFilterDataOrdinals(IDataReader reader) {
            AircraftId = reader.GetOrdinal("aircraft_id");
            AircraftName = reader.GetOrdinal("aircraft_name");
            AircraftDocumentTypeRcd = reader.GetOrdinal("aircraft_document_type_rcd");
            AircraftDocumentTypeName = reader.GetOrdinal("aircraft_document_type_name");
            DocumentName = reader.GetOrdinal("document_name");
            DocumentDateTime = reader.GetOrdinal("document_date_time");
            ExpiryDateTime = reader.GetOrdinal("expiry_date_time");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            AircraftDocumentId = reader.GetOrdinal("aircraft_document_id");
        }
    }
}
