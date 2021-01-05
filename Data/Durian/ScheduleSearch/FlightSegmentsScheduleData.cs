/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 2:32:11 PM
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
    // this class start with an identical representation of a ansi sql select statement in FlightSegmentsScheduleData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class FlightSegmentsScheduleData {
        
        public System.Guid FlightScheduleId { get; set; }
        
        public System.Guid FlightScheduleSegmentId { get; set; }
        
        public string AirlineIdentifierCode { get; set; }
        
        public string FlightNumber { get; set; }
        
        public string DepartureAirportIdentifierCode { get; set; }
        
        public string DepartureAirportName { get; set; }
        
        public string ArrivalAirportIdentifierCode { get; set; }
        
        public string ArrivalAirportName { get; set; }
        
        public int LogicalSegmentNumber { get; set; }
        
        public int PhysicalSegmentNumber { get; set; }
        
        public System.TimeSpan DepartureTime { get; set; }
        
        public System.TimeSpan ArrivalTime { get; set; }
        
        public string DepartureGate { get; set; }
        
        public string ArrivalGate { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, FlightSegmentsScheduleDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FlightScheduleId)) FlightScheduleId = reader.GetGuid(ordinals.FlightScheduleId);
            if (!reader.IsDBNull(ordinals.FlightScheduleSegmentId)) FlightScheduleSegmentId = reader.GetGuid(ordinals.FlightScheduleSegmentId);
            if (!reader.IsDBNull(ordinals.AirlineIdentifierCode)) AirlineIdentifierCode = reader.GetString(ordinals.AirlineIdentifierCode);
            if (!reader.IsDBNull(ordinals.FlightNumber)) FlightNumber = reader.GetString(ordinals.FlightNumber);
            if (!reader.IsDBNull(ordinals.DepartureAirportIdentifierCode)) DepartureAirportIdentifierCode = reader.GetString(ordinals.DepartureAirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.DepartureAirportName)) DepartureAirportName = reader.GetString(ordinals.DepartureAirportName);
            if (!reader.IsDBNull(ordinals.ArrivalAirportIdentifierCode)) ArrivalAirportIdentifierCode = reader.GetString(ordinals.ArrivalAirportIdentifierCode);
            if (!reader.IsDBNull(ordinals.ArrivalAirportName)) ArrivalAirportName = reader.GetString(ordinals.ArrivalAirportName);
            if (!reader.IsDBNull(ordinals.LogicalSegmentNumber)) LogicalSegmentNumber = reader.GetInt32(ordinals.LogicalSegmentNumber);
            if (!reader.IsDBNull(ordinals.PhysicalSegmentNumber)) PhysicalSegmentNumber = reader.GetInt32(ordinals.PhysicalSegmentNumber);
            if (!reader.IsDBNull(ordinals.DepartureTime)) DepartureTime = (TimeSpan) reader[ordinals.DepartureTime];
            if (!reader.IsDBNull(ordinals.ArrivalTime)) ArrivalTime = (TimeSpan) reader[ordinals.ArrivalTime];
            if (!reader.IsDBNull(ordinals.DepartureGate)) DepartureGate = reader.GetString(ordinals.DepartureGate);
            if (!reader.IsDBNull(ordinals.ArrivalGate)) ArrivalGate = reader.GetString(ordinals.ArrivalGate);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in FlightSegmentsScheduleData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class FlightSegmentsScheduleDataOrdinals {
        
        public int FlightScheduleId;
        
        public int FlightScheduleSegmentId;
        
        public int AirlineIdentifierCode;
        
        public int FlightNumber;
        
        public int DepartureAirportIdentifierCode;
        
        public int DepartureAirportName;
        
        public int ArrivalAirportIdentifierCode;
        
        public int ArrivalAirportName;
        
        public int LogicalSegmentNumber;
        
        public int PhysicalSegmentNumber;
        
        public int DepartureTime;
        
        public int ArrivalTime;
        
        public int DepartureGate;
        
        public int ArrivalGate;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public FlightSegmentsScheduleDataOrdinals(IDataReader reader) {
            FlightScheduleId = reader.GetOrdinal("flight_schedule_id");
            FlightScheduleSegmentId = reader.GetOrdinal("flight_schedule_segment_id");
            AirlineIdentifierCode = reader.GetOrdinal("airline_identifier_code");
            FlightNumber = reader.GetOrdinal("flight_number");
            DepartureAirportIdentifierCode = reader.GetOrdinal("departure_airport_identifier_code");
            DepartureAirportName = reader.GetOrdinal("departure_airport_name");
            ArrivalAirportIdentifierCode = reader.GetOrdinal("arrival_airport_identifier_code");
            ArrivalAirportName = reader.GetOrdinal("arrival_airport_name");
            LogicalSegmentNumber = reader.GetOrdinal("logical_segment_number");
            PhysicalSegmentNumber = reader.GetOrdinal("physical_segment_number");
            DepartureTime = reader.GetOrdinal("departure_time");
            ArrivalTime = reader.GetOrdinal("arrival_time");
            DepartureGate = reader.GetOrdinal("departure_gate");
            ArrivalGate = reader.GetOrdinal("arrival_gate");
        }
    }
}
