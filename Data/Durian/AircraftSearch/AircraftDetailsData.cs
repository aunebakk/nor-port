/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:01:33 AM
  From Machine: DESKTOP-517I8BU
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
    // this class start with an identical representation of a ansi sql select statement in AircraftDetailsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class AircraftDetailsData {
        
        public string AircraftName { get; set; }
        
        public byte[] AircraftFamilyImage { get; set; }
        
        public string AircraftConfigurationName { get; set; }
        
        public string AircraftBodyName { get; set; }
        
        public string AircraftTypeName { get; set; }
        
        public string ProductInfoValue { get; set; }
        
        public System.Guid AircraftId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, AircraftDetailsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AircraftName)) AircraftName = reader.GetString(ordinals.AircraftName);
            if (!reader.IsDBNull(ordinals.AircraftFamilyImage)) AircraftFamilyImage = (System.Byte[]) reader[ordinals.AircraftFamilyImage];
            if (!reader.IsDBNull(ordinals.AircraftConfigurationName)) AircraftConfigurationName = reader.GetString(ordinals.AircraftConfigurationName);
            if (!reader.IsDBNull(ordinals.AircraftBodyName)) AircraftBodyName = reader.GetString(ordinals.AircraftBodyName);
            if (!reader.IsDBNull(ordinals.AircraftTypeName)) AircraftTypeName = reader.GetString(ordinals.AircraftTypeName);
            if (!reader.IsDBNull(ordinals.ProductInfoValue)) ProductInfoValue = reader.GetString(ordinals.ProductInfoValue);
            if (!reader.IsDBNull(ordinals.AircraftId)) AircraftId = reader.GetGuid(ordinals.AircraftId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in AircraftDetailsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class AircraftDetailsDataOrdinals {
        
        public int AircraftName;
        
        public int AircraftFamilyImage;
        
        public int AircraftConfigurationName;
        
        public int AircraftBodyName;
        
        public int AircraftTypeName;
        
        public int ProductInfoValue;
        
        public int AircraftId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public AircraftDetailsDataOrdinals(IDataReader reader) {
            AircraftName = reader.GetOrdinal("aircraft_name");
            AircraftFamilyImage = reader.GetOrdinal("aircraft_family_image");
            AircraftConfigurationName = reader.GetOrdinal("aircraft_configuration_name");
            AircraftBodyName = reader.GetOrdinal("aircraft_body_name");
            AircraftTypeName = reader.GetOrdinal("aircraft_type_name");
            ProductInfoValue = reader.GetOrdinal("product_info_value");
            AircraftId = reader.GetOrdinal("aircraft_id");
        }
    }
}
