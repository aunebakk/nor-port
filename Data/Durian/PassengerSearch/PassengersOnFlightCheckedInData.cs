/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:30:57 AM
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
    // this class start with an identical representation of a ansi sql select statement in PassengersOnFlightCheckedInData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class PassengersOnFlightCheckedInData {
        
        public string RecordLocator { get; set; }
        
        public string ReceivedFrom { get; set; }
        
        public string PassengerName { get; set; }
        
        public string PassengerTypeName { get; set; }
        
        public System.Guid PassengerId { get; set; }
        
        public System.Guid BookingId { get; set; }
        
        public System.Guid BookingPassengerId { get; set; }
        
        public System.Guid BookingFlightSegmentId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, PassengersOnFlightCheckedInDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.RecordLocator)) RecordLocator = reader.GetString(ordinals.RecordLocator);
            if (!reader.IsDBNull(ordinals.ReceivedFrom)) ReceivedFrom = reader.GetString(ordinals.ReceivedFrom);
            if (!reader.IsDBNull(ordinals.PassengerName)) PassengerName = reader.GetString(ordinals.PassengerName);
            if (!reader.IsDBNull(ordinals.PassengerTypeName)) PassengerTypeName = reader.GetString(ordinals.PassengerTypeName);
            if (!reader.IsDBNull(ordinals.PassengerId)) PassengerId = reader.GetGuid(ordinals.PassengerId);
            if (!reader.IsDBNull(ordinals.BookingId)) BookingId = reader.GetGuid(ordinals.BookingId);
            if (!reader.IsDBNull(ordinals.BookingPassengerId)) BookingPassengerId = reader.GetGuid(ordinals.BookingPassengerId);
            if (!reader.IsDBNull(ordinals.BookingFlightSegmentId)) BookingFlightSegmentId = reader.GetGuid(ordinals.BookingFlightSegmentId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in PassengersOnFlightCheckedInData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class PassengersOnFlightCheckedInDataOrdinals {
        
        public int RecordLocator;
        
        public int ReceivedFrom;
        
        public int PassengerName;
        
        public int PassengerTypeName;
        
        public int PassengerId;
        
        public int BookingId;
        
        public int BookingPassengerId;
        
        public int BookingFlightSegmentId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public PassengersOnFlightCheckedInDataOrdinals(IDataReader reader) {
            RecordLocator = reader.GetOrdinal("record_locator");
            ReceivedFrom = reader.GetOrdinal("received_from");
            PassengerName = reader.GetOrdinal("passenger_name");
            PassengerTypeName = reader.GetOrdinal("passenger_type_name");
            PassengerId = reader.GetOrdinal("passenger_id");
            BookingId = reader.GetOrdinal("booking_id");
            BookingPassengerId = reader.GetOrdinal("booking_passenger_id");
            BookingFlightSegmentId = reader.GetOrdinal("booking_flight_segment_id");
        }
    }
}
