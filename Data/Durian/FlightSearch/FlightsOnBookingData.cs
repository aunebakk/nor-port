/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:13:37 AM
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
    // this class start with an identical representation of a ansi sql select statement in FlightsOnBookingData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class FlightsOnBookingData {
        
        public string FlightNumber { get; set; }
        
        public string OriginAirportCode { get; set; }
        
        public string OriginAirportName { get; set; }
        
        public string DestinationAirportCode { get; set; }
        
        public string DestinationAirportName { get; set; }
        
        public System.DateTime FromDateTime { get; set; }
        
        public System.DateTime UntilDateTime { get; set; }
        
        public string Comment { get; set; }
        
        public System.Guid FlightId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, FlightsOnBookingDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FlightNumber)) FlightNumber = reader.GetString(ordinals.FlightNumber);
            if (!reader.IsDBNull(ordinals.OriginAirportCode)) OriginAirportCode = reader.GetString(ordinals.OriginAirportCode);
            if (!reader.IsDBNull(ordinals.OriginAirportName)) OriginAirportName = reader.GetString(ordinals.OriginAirportName);
            if (!reader.IsDBNull(ordinals.DestinationAirportCode)) DestinationAirportCode = reader.GetString(ordinals.DestinationAirportCode);
            if (!reader.IsDBNull(ordinals.DestinationAirportName)) DestinationAirportName = reader.GetString(ordinals.DestinationAirportName);
            if (!reader.IsDBNull(ordinals.FromDateTime)) FromDateTime = reader.GetDateTime(ordinals.FromDateTime);
            if (!reader.IsDBNull(ordinals.UntilDateTime)) UntilDateTime = reader.GetDateTime(ordinals.UntilDateTime);
            if (!reader.IsDBNull(ordinals.Comment)) Comment = reader.GetString(ordinals.Comment);
            if (!reader.IsDBNull(ordinals.FlightId)) FlightId = reader.GetGuid(ordinals.FlightId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in FlightsOnBookingData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class FlightsOnBookingDataOrdinals {
        
        public int FlightNumber;
        
        public int OriginAirportCode;
        
        public int OriginAirportName;
        
        public int DestinationAirportCode;
        
        public int DestinationAirportName;
        
        public int FromDateTime;
        
        public int UntilDateTime;
        
        public int Comment;
        
        public int FlightId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public FlightsOnBookingDataOrdinals(IDataReader reader) {
            FlightNumber = reader.GetOrdinal("flight_number");
            OriginAirportCode = reader.GetOrdinal("origin_airport_code");
            OriginAirportName = reader.GetOrdinal("origin_airport_name");
            DestinationAirportCode = reader.GetOrdinal("destination_airport_code");
            DestinationAirportName = reader.GetOrdinal("destination_airport_name");
            FromDateTime = reader.GetOrdinal("from_date_time");
            UntilDateTime = reader.GetOrdinal("until_date_time");
            Comment = reader.GetOrdinal("comment");
            FlightId = reader.GetOrdinal("flight_id");
        }
    }
}
