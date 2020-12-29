/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:02:02 AM
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
    // this class start with an identical representation of a ansi sql select statement in AircraftMaintenanceCompartmentIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class AircraftMaintenanceCompartmentIndexWithFilterData {
        
        public System.Guid AircraftId { get; set; }
        
        public string AircraftName { get; set; }
        
        public string AircraftCompartmentTypeRcd { get; set; }
        
        public string AircraftCompartmentTypeName { get; set; }
        
        public string AircraftCompartmentName { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AircraftCompartmentId { get; set; }
        
        public System.Guid AircraftCompartmentMeasurementId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, AircraftMaintenanceCompartmentIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AircraftId)) AircraftId = reader.GetGuid(ordinals.AircraftId);
            if (!reader.IsDBNull(ordinals.AircraftName)) AircraftName = reader.GetString(ordinals.AircraftName);
            if (!reader.IsDBNull(ordinals.AircraftCompartmentTypeRcd)) AircraftCompartmentTypeRcd = reader.GetString(ordinals.AircraftCompartmentTypeRcd);
            if (!reader.IsDBNull(ordinals.AircraftCompartmentTypeName)) AircraftCompartmentTypeName = reader.GetString(ordinals.AircraftCompartmentTypeName);
            if (!reader.IsDBNull(ordinals.AircraftCompartmentName)) AircraftCompartmentName = reader.GetString(ordinals.AircraftCompartmentName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AircraftCompartmentId)) AircraftCompartmentId = reader.GetGuid(ordinals.AircraftCompartmentId);
            if (!reader.IsDBNull(ordinals.AircraftCompartmentMeasurementId)) AircraftCompartmentMeasurementId = reader.GetGuid(ordinals.AircraftCompartmentMeasurementId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in AircraftMaintenanceCompartmentIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class AircraftMaintenanceCompartmentIndexWithFilterDataOrdinals {
        
        public int AircraftId;
        
        public int AircraftName;
        
        public int AircraftCompartmentTypeRcd;
        
        public int AircraftCompartmentTypeName;
        
        public int AircraftCompartmentName;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int AircraftCompartmentId;
        
        public int AircraftCompartmentMeasurementId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public AircraftMaintenanceCompartmentIndexWithFilterDataOrdinals(IDataReader reader) {
            AircraftId = reader.GetOrdinal("aircraft_id");
            AircraftName = reader.GetOrdinal("aircraft_name");
            AircraftCompartmentTypeRcd = reader.GetOrdinal("aircraft_compartment_type_rcd");
            AircraftCompartmentTypeName = reader.GetOrdinal("aircraft_compartment_type_name");
            AircraftCompartmentName = reader.GetOrdinal("aircraft_compartment_name");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            AircraftCompartmentId = reader.GetOrdinal("aircraft_compartment_id");
            AircraftCompartmentMeasurementId = reader.GetOrdinal("aircraft_compartment_measurement_id");
        }
    }
}
