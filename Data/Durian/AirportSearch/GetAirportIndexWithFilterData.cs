/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 7:08:44 AM
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
    // this class start with an identical representation of a ansi sql select statement in GetAirportIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class GetAirportIndexWithFilterData {
        
        public string AirportName { get; set; }
        
        public string AirportTypeName { get; set; }
        
        public string CityName { get; set; }
        
        public string ProductName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string AirportTypeRcd { get; set; }
        
        public System.Guid CityId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public decimal UtcOffset { get; set; }
        
        public decimal ElevationInMeters { get; set; }
        
        public decimal RunwayInMeters { get; set; }
        
        public string Latitude { get; set; }
        
        public string Longitude { get; set; }
        
        public System.Guid TimezoneId { get; set; }
        
        public string Variation { get; set; }
        
        public string Attendance { get; set; }
        
        public bool ControlTowerFlag { get; set; }
        
        public System.DateTime ActivationDateTime { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AirportId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, GetAirportIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AirportName)) AirportName = reader.GetString(ordinals.AirportName);
            if (!reader.IsDBNull(ordinals.AirportTypeName)) AirportTypeName = reader.GetString(ordinals.AirportTypeName);
            if (!reader.IsDBNull(ordinals.CityName)) CityName = reader.GetString(ordinals.CityName);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.AirportTypeRcd)) AirportTypeRcd = reader.GetString(ordinals.AirportTypeRcd);
            if (!reader.IsDBNull(ordinals.CityId)) CityId = reader.GetGuid(ordinals.CityId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.UtcOffset)) UtcOffset = reader.GetDecimal(ordinals.UtcOffset);
            if (!reader.IsDBNull(ordinals.ElevationInMeters)) ElevationInMeters = reader.GetDecimal(ordinals.ElevationInMeters);
            if (!reader.IsDBNull(ordinals.RunwayInMeters)) RunwayInMeters = reader.GetDecimal(ordinals.RunwayInMeters);
            if (!reader.IsDBNull(ordinals.Latitude)) Latitude = reader.GetString(ordinals.Latitude);
            if (!reader.IsDBNull(ordinals.Longitude)) Longitude = reader.GetString(ordinals.Longitude);
            if (!reader.IsDBNull(ordinals.TimezoneId)) TimezoneId = reader.GetGuid(ordinals.TimezoneId);
            if (!reader.IsDBNull(ordinals.Variation)) Variation = reader.GetString(ordinals.Variation);
            if (!reader.IsDBNull(ordinals.Attendance)) Attendance = reader.GetString(ordinals.Attendance);
            if (!reader.IsDBNull(ordinals.ControlTowerFlag)) ControlTowerFlag = reader.GetBoolean(ordinals.ControlTowerFlag);
            if (!reader.IsDBNull(ordinals.ActivationDateTime)) ActivationDateTime = reader.GetDateTime(ordinals.ActivationDateTime);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AirportId)) AirportId = reader.GetGuid(ordinals.AirportId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in GetAirportIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class GetAirportIndexWithFilterDataOrdinals {
        
        public int AirportName;
        
        public int AirportTypeName;
        
        public int CityName;
        
        public int ProductName;
        
        public int DefaultUserName;
        
        public int AirportTypeRcd;
        
        public int CityId;
        
        public int ProductId;
        
        public int UtcOffset;
        
        public int ElevationInMeters;
        
        public int RunwayInMeters;
        
        public int Latitude;
        
        public int Longitude;
        
        public int TimezoneId;
        
        public int Variation;
        
        public int Attendance;
        
        public int ControlTowerFlag;
        
        public int ActivationDateTime;
        
        public int UserId;
        
        public int DateTime;
        
        public int AirportId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public GetAirportIndexWithFilterDataOrdinals(IDataReader reader) {
            AirportName = reader.GetOrdinal("airport_name");
            AirportTypeName = reader.GetOrdinal("airport_type_name");
            CityName = reader.GetOrdinal("city_name");
            ProductName = reader.GetOrdinal("product_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            AirportTypeRcd = reader.GetOrdinal("airport_type_rcd");
            CityId = reader.GetOrdinal("city_id");
            ProductId = reader.GetOrdinal("product_id");
            UtcOffset = reader.GetOrdinal("utc_offset");
            ElevationInMeters = reader.GetOrdinal("elevation_in_meters");
            RunwayInMeters = reader.GetOrdinal("runway_in_meters");
            Latitude = reader.GetOrdinal("latitude");
            Longitude = reader.GetOrdinal("longitude");
            TimezoneId = reader.GetOrdinal("timezone_id");
            Variation = reader.GetOrdinal("variation");
            Attendance = reader.GetOrdinal("attendance");
            ControlTowerFlag = reader.GetOrdinal("control_tower_flag");
            ActivationDateTime = reader.GetOrdinal("activation_date_time");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            AirportId = reader.GetOrdinal("airport_id");
        }
    }
}
