/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:39:35 AM
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
    // this class start with an identical representation of a ansi sql select statement in AircraftMaintenanceIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class AircraftMaintenanceIndexWithFilterData {
        
        public string AircraftName { get; set; }
        
        public string AircraftConfigurationRcd { get; set; }
        
        public string AircraftConfigurationName { get; set; }
        
        public string AircraftBodyRcd { get; set; }
        
        public string AircraftBodyName { get; set; }
        
        public string AircraftTypeRcd { get; set; }
        
        public string AircraftTypeName { get; set; }
        
        public string EngineType { get; set; }
        
        public System.DateTime OperationalDateTime { get; set; }
        
        public System.DateTime FirstFlightDateTime { get; set; }
        
        public int PassengerCapacity { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AircraftId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, AircraftMaintenanceIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AircraftName)) AircraftName = reader.GetString(ordinals.AircraftName);
            if (!reader.IsDBNull(ordinals.AircraftConfigurationRcd)) AircraftConfigurationRcd = reader.GetString(ordinals.AircraftConfigurationRcd);
            if (!reader.IsDBNull(ordinals.AircraftConfigurationName)) AircraftConfigurationName = reader.GetString(ordinals.AircraftConfigurationName);
            if (!reader.IsDBNull(ordinals.AircraftBodyRcd)) AircraftBodyRcd = reader.GetString(ordinals.AircraftBodyRcd);
            if (!reader.IsDBNull(ordinals.AircraftBodyName)) AircraftBodyName = reader.GetString(ordinals.AircraftBodyName);
            if (!reader.IsDBNull(ordinals.AircraftTypeRcd)) AircraftTypeRcd = reader.GetString(ordinals.AircraftTypeRcd);
            if (!reader.IsDBNull(ordinals.AircraftTypeName)) AircraftTypeName = reader.GetString(ordinals.AircraftTypeName);
            if (!reader.IsDBNull(ordinals.EngineType)) EngineType = reader.GetString(ordinals.EngineType);
            if (!reader.IsDBNull(ordinals.OperationalDateTime)) OperationalDateTime = reader.GetDateTime(ordinals.OperationalDateTime);
            if (!reader.IsDBNull(ordinals.FirstFlightDateTime)) FirstFlightDateTime = reader.GetDateTime(ordinals.FirstFlightDateTime);
            if (!reader.IsDBNull(ordinals.PassengerCapacity)) PassengerCapacity = reader.GetInt32(ordinals.PassengerCapacity);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AircraftId)) AircraftId = reader.GetGuid(ordinals.AircraftId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in AircraftMaintenanceIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class AircraftMaintenanceIndexWithFilterDataOrdinals {
        
        public int AircraftName;
        
        public int AircraftConfigurationRcd;
        
        public int AircraftConfigurationName;
        
        public int AircraftBodyRcd;
        
        public int AircraftBodyName;
        
        public int AircraftTypeRcd;
        
        public int AircraftTypeName;
        
        public int EngineType;
        
        public int OperationalDateTime;
        
        public int FirstFlightDateTime;
        
        public int PassengerCapacity;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int AircraftId;
        
        public int ProductId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public AircraftMaintenanceIndexWithFilterDataOrdinals(IDataReader reader) {
            AircraftName = reader.GetOrdinal("aircraft_name");
            AircraftConfigurationRcd = reader.GetOrdinal("aircraft_configuration_rcd");
            AircraftConfigurationName = reader.GetOrdinal("aircraft_configuration_name");
            AircraftBodyRcd = reader.GetOrdinal("aircraft_body_rcd");
            AircraftBodyName = reader.GetOrdinal("aircraft_body_name");
            AircraftTypeRcd = reader.GetOrdinal("aircraft_type_rcd");
            AircraftTypeName = reader.GetOrdinal("aircraft_type_name");
            EngineType = reader.GetOrdinal("engine_type");
            OperationalDateTime = reader.GetOrdinal("operational_date_time");
            FirstFlightDateTime = reader.GetOrdinal("first_flight_date_time");
            PassengerCapacity = reader.GetOrdinal("passenger_capacity");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            AircraftId = reader.GetOrdinal("aircraft_id");
            ProductId = reader.GetOrdinal("product_id");
        }
    }
}
