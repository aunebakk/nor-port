/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:17 PM
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
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPort.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in AirportIdentifierIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class AirportIdentifierIndexWithFilterData {
        
        public string AirportName { get; set; }
        
        public string AirportIdentifierTypeName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid AirportId { get; set; }
        
        public string AirportIdentifierTypeRcd { get; set; }
        
        public string AirportIdentifierCode { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AirportIdentifierId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, AirportIdentifierIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AirportName)) AirportName = reader.GetString(ordinals.AirportName);
            if (!reader.IsDBNull(ordinals.AirportIdentifierTypeName)) AirportIdentifierTypeName = reader.GetString(ordinals.AirportIdentifierTypeName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.AirportId)) AirportId = reader.GetGuid(ordinals.AirportId);
            if (!reader.IsDBNull(ordinals.AirportIdentifierTypeRcd)) AirportIdentifierTypeRcd = reader.GetString(ordinals.AirportIdentifierTypeRcd);
            if (!reader.IsDBNull(ordinals.AirportIdentifierCode)) AirportIdentifierCode = reader.GetString(ordinals.AirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AirportIdentifierId)) AirportIdentifierId = reader.GetGuid(ordinals.AirportIdentifierId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in AirportIdentifierIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class AirportIdentifierIndexWithFilterDataOrdinals {
        
        public int AirportName;
        
        public int AirportIdentifierTypeName;
        
        public int DefaultUserName;
        
        public int AirportId;
        
        public int AirportIdentifierTypeRcd;
        
        public int AirportIdentifierCode;
        
        public int UserId;
        
        public int DateTime;
        
        public int AirportIdentifierId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public AirportIdentifierIndexWithFilterDataOrdinals(IDataReader reader) {
            AirportName = reader.GetOrdinal("airport_name");
            AirportIdentifierTypeName = reader.GetOrdinal("airport_identifier_type_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            AirportId = reader.GetOrdinal("airport_id");
            AirportIdentifierTypeRcd = reader.GetOrdinal("airport_identifier_type_rcd");
            AirportIdentifierCode = reader.GetOrdinal("airport_identifier_code");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            AirportIdentifierId = reader.GetOrdinal("airport_identifier_id");
        }
    }
}
