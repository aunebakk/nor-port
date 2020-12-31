/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:51:17 AM
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
    // this class start with an identical representation of a ansi sql select statement in GetAirlineIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class GetAirlineIndexWithFilterData {
        
        public string AirlineName { get; set; }
        
        public string AirlineTypeName { get; set; }
        
        public string LegalName { get; set; }
        
        public string ProductName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string AirlineTypeRcd { get; set; }
        
        public string AddressOne { get; set; }
        
        public string AddressTwo { get; set; }
        
        public string AddressThree { get; set; }
        
        public string City { get; set; }
        
        public string Street { get; set; }
        
        public string State { get; set; }
        
        public string District { get; set; }
        
        public string Province { get; set; }
        
        public string ZipCode { get; set; }
        
        public string PoBox { get; set; }
        
        public string Comment { get; set; }
        
        public System.Guid AddressId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string StockMarketSymbol { get; set; }
        
        public int AircraftCount { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid AirlineId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, GetAirlineIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.AirlineName)) AirlineName = reader.GetString(ordinals.AirlineName);
            if (!reader.IsDBNull(ordinals.AirlineTypeName)) AirlineTypeName = reader.GetString(ordinals.AirlineTypeName);
            if (!reader.IsDBNull(ordinals.LegalName)) LegalName = reader.GetString(ordinals.LegalName);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.AirlineTypeRcd)) AirlineTypeRcd = reader.GetString(ordinals.AirlineTypeRcd);
            if (!reader.IsDBNull(ordinals.AddressOne)) AddressOne = reader.GetString(ordinals.AddressOne);
            if (!reader.IsDBNull(ordinals.AddressTwo)) AddressTwo = reader.GetString(ordinals.AddressTwo);
            if (!reader.IsDBNull(ordinals.AddressThree)) AddressThree = reader.GetString(ordinals.AddressThree);
            if (!reader.IsDBNull(ordinals.City)) City = reader.GetString(ordinals.City);
            if (!reader.IsDBNull(ordinals.Street)) Street = reader.GetString(ordinals.Street);
            if (!reader.IsDBNull(ordinals.State)) State = reader.GetString(ordinals.State);
            if (!reader.IsDBNull(ordinals.District)) District = reader.GetString(ordinals.District);
            if (!reader.IsDBNull(ordinals.Province)) Province = reader.GetString(ordinals.Province);
            if (!reader.IsDBNull(ordinals.ZipCode)) ZipCode = reader.GetString(ordinals.ZipCode);
            if (!reader.IsDBNull(ordinals.PoBox)) PoBox = reader.GetString(ordinals.PoBox);
            if (!reader.IsDBNull(ordinals.Comment)) Comment = reader.GetString(ordinals.Comment);
            if (!reader.IsDBNull(ordinals.AddressId)) AddressId = reader.GetGuid(ordinals.AddressId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.StockMarketSymbol)) StockMarketSymbol = reader.GetString(ordinals.StockMarketSymbol);
            if (!reader.IsDBNull(ordinals.AircraftCount)) AircraftCount = reader.GetInt32(ordinals.AircraftCount);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.AirlineId)) AirlineId = reader.GetGuid(ordinals.AirlineId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in GetAirlineIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class GetAirlineIndexWithFilterDataOrdinals {
        
        public int AirlineName;
        
        public int AirlineTypeName;
        
        public int LegalName;
        
        public int ProductName;
        
        public int DefaultUserName;
        
        public int AirlineTypeRcd;
        
        public int AddressOne;
        
        public int AddressTwo;
        
        public int AddressThree;
        
        public int City;
        
        public int Street;
        
        public int State;
        
        public int District;
        
        public int Province;
        
        public int ZipCode;
        
        public int PoBox;
        
        public int Comment;
        
        public int AddressId;
        
        public int ProductId;
        
        public int StockMarketSymbol;
        
        public int AircraftCount;
        
        public int UserId;
        
        public int DateTime;
        
        public int AirlineId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public GetAirlineIndexWithFilterDataOrdinals(IDataReader reader) {
            AirlineName = reader.GetOrdinal("airline_name");
            AirlineTypeName = reader.GetOrdinal("airline_type_name");
            LegalName = reader.GetOrdinal("legal_name");
            ProductName = reader.GetOrdinal("product_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            AirlineTypeRcd = reader.GetOrdinal("airline_type_rcd");
            AddressOne = reader.GetOrdinal("address_one");
            AddressTwo = reader.GetOrdinal("address_two");
            AddressThree = reader.GetOrdinal("address_three");
            City = reader.GetOrdinal("city");
            Street = reader.GetOrdinal("street");
            State = reader.GetOrdinal("state");
            District = reader.GetOrdinal("district");
            Province = reader.GetOrdinal("province");
            ZipCode = reader.GetOrdinal("zip_code");
            PoBox = reader.GetOrdinal("po_box");
            Comment = reader.GetOrdinal("comment");
            AddressId = reader.GetOrdinal("address_id");
            ProductId = reader.GetOrdinal("product_id");
            StockMarketSymbol = reader.GetOrdinal("stock_market_symbol");
            AircraftCount = reader.GetOrdinal("aircraft_count");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            AirlineId = reader.GetOrdinal("airline_id");
        }
    }
}
