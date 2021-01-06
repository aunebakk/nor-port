/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 5:42:24 AM
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
    // this class start with an identical representation of a ansi sql select statement in GetFerryIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class GetFerryIndexWithFilterData {
        
        public string FerryName { get; set; }
        
        public string FerryTypeRcd { get; set; }
        
        public string FerryTypeName { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public System.DateTime FirstFloatDateTime { get; set; }
        
        public System.DateTime OperationalDateTime { get; set; }
        
        public string EngineType { get; set; }
        
        public int PassengerCapacity { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid FerryId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, GetFerryIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FerryName)) FerryName = reader.GetString(ordinals.FerryName);
            if (!reader.IsDBNull(ordinals.FerryTypeRcd)) FerryTypeRcd = reader.GetString(ordinals.FerryTypeRcd);
            if (!reader.IsDBNull(ordinals.FerryTypeName)) FerryTypeName = reader.GetString(ordinals.FerryTypeName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.FirstFloatDateTime)) FirstFloatDateTime = reader.GetDateTime(ordinals.FirstFloatDateTime);
            if (!reader.IsDBNull(ordinals.OperationalDateTime)) OperationalDateTime = reader.GetDateTime(ordinals.OperationalDateTime);
            if (!reader.IsDBNull(ordinals.EngineType)) EngineType = reader.GetString(ordinals.EngineType);
            if (!reader.IsDBNull(ordinals.PassengerCapacity)) PassengerCapacity = reader.GetInt32(ordinals.PassengerCapacity);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.FerryId)) FerryId = reader.GetGuid(ordinals.FerryId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in GetFerryIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class GetFerryIndexWithFilterDataOrdinals {
        
        public int FerryName;
        
        public int FerryTypeRcd;
        
        public int FerryTypeName;
        
        public int ProductId;
        
        public int ProductName;
        
        public int FirstFloatDateTime;
        
        public int OperationalDateTime;
        
        public int EngineType;
        
        public int PassengerCapacity;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int FerryId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public GetFerryIndexWithFilterDataOrdinals(IDataReader reader) {
            FerryName = reader.GetOrdinal("ferry_name");
            FerryTypeRcd = reader.GetOrdinal("ferry_type_rcd");
            FerryTypeName = reader.GetOrdinal("ferry_type_name");
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            FirstFloatDateTime = reader.GetOrdinal("first_float_date_time");
            OperationalDateTime = reader.GetOrdinal("operational_date_time");
            EngineType = reader.GetOrdinal("engine_type");
            PassengerCapacity = reader.GetOrdinal("passenger_capacity");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            FerryId = reader.GetOrdinal("ferry_id");
        }
    }
}
