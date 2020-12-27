/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 7:21:37 PM
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
    // this class start with an identical representation of a ansi sql select statement in FinancialFaresData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class FinancialFaresData {
        
        public string FinancialFareTypeRcd { get; set; }
        
        public string DepartureAirportIdentifierCode { get; set; }
        
        public string DepartureAirportName { get; set; }
        
        public string ArrivalAirportIdentifierCode { get; set; }
        
        public string ArrivalAirportName { get; set; }
        
        public System.DateTime ValidFromFlightDateTime { get; set; }
        
        public System.DateTime ValidUntilFlightDateTime { get; set; }
        
        public decimal Amount { get; set; }
        
        public string FinancialCurrencyTypeRcd { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string DefaultUserCode { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid FinancialFareId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, FinancialFaresDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FinancialFareTypeRcd)) FinancialFareTypeRcd = reader.GetString(ordinals.FinancialFareTypeRcd);
            if (!reader.IsDBNull(ordinals.DepartureAirportIdentifierCode)) DepartureAirportIdentifierCode = reader.GetString(ordinals.DepartureAirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.DepartureAirportName)) DepartureAirportName = reader.GetString(ordinals.DepartureAirportName);
            if (!reader.IsDBNull(ordinals.ArrivalAirportIdentifierCode)) ArrivalAirportIdentifierCode = reader.GetString(ordinals.ArrivalAirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.ArrivalAirportName)) ArrivalAirportName = reader.GetString(ordinals.ArrivalAirportName);
            if (!reader.IsDBNull(ordinals.ValidFromFlightDateTime)) ValidFromFlightDateTime = reader.GetDateTime(ordinals.ValidFromFlightDateTime);
            if (!reader.IsDBNull(ordinals.ValidUntilFlightDateTime)) ValidUntilFlightDateTime = reader.GetDateTime(ordinals.ValidUntilFlightDateTime);
            if (!reader.IsDBNull(ordinals.Amount)) Amount = reader.GetDecimal(ordinals.Amount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeRcd)) FinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.DefaultUserCode)) DefaultUserCode = reader.GetString(ordinals.DefaultUserCode);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.FinancialFareId)) FinancialFareId = reader.GetGuid(ordinals.FinancialFareId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in FinancialFaresData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class FinancialFaresDataOrdinals {
        
        public int FinancialFareTypeRcd;
        
        public int DepartureAirportIdentifierCode;
        
        public int DepartureAirportName;
        
        public int ArrivalAirportIdentifierCode;
        
        public int ArrivalAirportName;
        
        public int ValidFromFlightDateTime;
        
        public int ValidUntilFlightDateTime;
        
        public int Amount;
        
        public int FinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyTypeName;
        
        public int DateTime;
        
        public int DefaultUserCode;
        
        public int DefaultUserName;
        
        public int FinancialFareId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public FinancialFaresDataOrdinals(IDataReader reader) {
            FinancialFareTypeRcd = reader.GetOrdinal("financial_fare_type_rcd");
            DepartureAirportIdentifierCode = reader.GetOrdinal("departure_airport_identifier_code");
            DepartureAirportName = reader.GetOrdinal("departure_airport_name");
            ArrivalAirportIdentifierCode = reader.GetOrdinal("arrival_airport_identifier_code");
            ArrivalAirportName = reader.GetOrdinal("arrival_airport_name");
            ValidFromFlightDateTime = reader.GetOrdinal("valid_from_flight_date_time");
            ValidUntilFlightDateTime = reader.GetOrdinal("valid_until_flight_date_time");
            Amount = reader.GetOrdinal("amount");
            FinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_type_rcd");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            DateTime = reader.GetOrdinal("date_time");
            DefaultUserCode = reader.GetOrdinal("default_user_code");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            FinancialFareId = reader.GetOrdinal("financial_fare_id");
        }
    }
}
