/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 7:50:45 AM
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
    // this class start with an identical representation of a ansi sql select statement in FlightsWithBookingInformationData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class FlightsWithBookingInformationData {
        
        public System.Guid FlightId { get; set; }
        
        public string AirlineIdentifierCode { get; set; }
        
        public string FlightNumber { get; set; }
        
        public string DepartureAirportIdentifierCode { get; set; }
        
        public string DepartureAirportName { get; set; }
        
        public string ArrivalAirportIdentifierCode { get; set; }
        
        public string ArrivalAirportName { get; set; }
        
        public System.DateTime FromDateTime { get; set; }
        
        public System.DateTime UntilDateTime { get; set; }
        
        public bool CanBookFlag { get; set; }
        
        public bool CanCheckinFlag { get; set; }
        
        public bool InFlightFlag { get; set; }
        
        public int FlightsBookedCount { get; set; }
        
        public string LastDateTimeTypeName { get; set; }
        
        public System.DateTime PlannedDepartureDateTime { get; set; }
        
        public System.DateTime EstimatedDepartureDateTime { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, FlightsWithBookingInformationDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FlightId)) FlightId = reader.GetGuid(ordinals.FlightId);
            if (!reader.IsDBNull(ordinals.AirlineIdentifierCode)) AirlineIdentifierCode = reader.GetString(ordinals.AirlineIdentifierCode);
            if (!reader.IsDBNull(ordinals.FlightNumber)) FlightNumber = reader.GetString(ordinals.FlightNumber);
            if (!reader.IsDBNull(ordinals.DepartureAirportIdentifierCode)) DepartureAirportIdentifierCode = reader.GetString(ordinals.DepartureAirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.DepartureAirportName)) DepartureAirportName = reader.GetString(ordinals.DepartureAirportName);
            if (!reader.IsDBNull(ordinals.ArrivalAirportIdentifierCode)) ArrivalAirportIdentifierCode = reader.GetString(ordinals.ArrivalAirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.ArrivalAirportName)) ArrivalAirportName = reader.GetString(ordinals.ArrivalAirportName);
            if (!reader.IsDBNull(ordinals.FromDateTime)) FromDateTime = reader.GetDateTime(ordinals.FromDateTime);
            if (!reader.IsDBNull(ordinals.UntilDateTime)) UntilDateTime = reader.GetDateTime(ordinals.UntilDateTime);
            if (!reader.IsDBNull(ordinals.CanBookFlag)) CanBookFlag = reader.GetBoolean(ordinals.CanBookFlag);
            if (!reader.IsDBNull(ordinals.CanCheckinFlag)) CanCheckinFlag = reader.GetBoolean(ordinals.CanCheckinFlag);
            if (!reader.IsDBNull(ordinals.InFlightFlag)) InFlightFlag = reader.GetBoolean(ordinals.InFlightFlag);
            if (!reader.IsDBNull(ordinals.FlightsBookedCount)) FlightsBookedCount = reader.GetInt32(ordinals.FlightsBookedCount);
            if (!reader.IsDBNull(ordinals.LastDateTimeTypeName)) LastDateTimeTypeName = reader.GetString(ordinals.LastDateTimeTypeName);
            if (!reader.IsDBNull(ordinals.PlannedDepartureDateTime)) PlannedDepartureDateTime = reader.GetDateTime(ordinals.PlannedDepartureDateTime);
            if (!reader.IsDBNull(ordinals.EstimatedDepartureDateTime)) EstimatedDepartureDateTime = reader.GetDateTime(ordinals.EstimatedDepartureDateTime);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in FlightsWithBookingInformationData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class FlightsWithBookingInformationDataOrdinals {
        
        public int FlightId;
        
        public int AirlineIdentifierCode;
        
        public int FlightNumber;
        
        public int DepartureAirportIdentifierCode;
        
        public int DepartureAirportName;
        
        public int ArrivalAirportIdentifierCode;
        
        public int ArrivalAirportName;
        
        public int FromDateTime;
        
        public int UntilDateTime;
        
        public int CanBookFlag;
        
        public int CanCheckinFlag;
        
        public int InFlightFlag;
        
        public int FlightsBookedCount;
        
        public int LastDateTimeTypeName;
        
        public int PlannedDepartureDateTime;
        
        public int EstimatedDepartureDateTime;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public FlightsWithBookingInformationDataOrdinals(IDataReader reader) {
            FlightId = reader.GetOrdinal("flight_id");
            AirlineIdentifierCode = reader.GetOrdinal("airline_identifier_code");
            FlightNumber = reader.GetOrdinal("flight_number");
            DepartureAirportIdentifierCode = reader.GetOrdinal("departure_airport_identifier_code");
            DepartureAirportName = reader.GetOrdinal("departure_airport_name");
            ArrivalAirportIdentifierCode = reader.GetOrdinal("arrival_airport_identifier_code");
            ArrivalAirportName = reader.GetOrdinal("arrival_airport_name");
            FromDateTime = reader.GetOrdinal("from_date_time");
            UntilDateTime = reader.GetOrdinal("until_date_time");
            CanBookFlag = reader.GetOrdinal("can_book_flag");
            CanCheckinFlag = reader.GetOrdinal("can_checkin_flag");
            InFlightFlag = reader.GetOrdinal("in_flight_flag");
            FlightsBookedCount = reader.GetOrdinal("flights_booked_count");
            LastDateTimeTypeName = reader.GetOrdinal("last_date_time_type_name");
            PlannedDepartureDateTime = reader.GetOrdinal("planned_departure_date_time");
            EstimatedDepartureDateTime = reader.GetOrdinal("estimated_departure_date_time");
        }
    }
}
