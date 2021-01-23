/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:36:48 PM
  From Machine: DESKTOP-9A2DH39
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
    // this class start with an identical representation of a ansi sql select statement in BookingsOpenData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class BookingsOpenData {
        
        public System.Guid BookingId { get; set; }
        
        public string RecordLocator { get; set; }
        
        public string LastBookingEventTypeName { get; set; }
        
        public System.DateTime LastBookingEventDateTime { get; set; }
        
        public string LastBookingContactMethod { get; set; }
        
        public string BookingSourceName { get; set; }
        
        public int AdultCount { get; set; }
        
        public int ChildCount { get; set; }
        
        public int InfantCount { get; set; }
        
        public decimal BalanceAmount { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, BookingsOpenDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.BookingId)) BookingId = reader.GetGuid(ordinals.BookingId);
            if (!reader.IsDBNull(ordinals.RecordLocator)) RecordLocator = reader.GetString(ordinals.RecordLocator);
            if (!reader.IsDBNull(ordinals.LastBookingEventTypeName)) LastBookingEventTypeName = reader.GetString(ordinals.LastBookingEventTypeName);
            if (!reader.IsDBNull(ordinals.LastBookingEventDateTime)) LastBookingEventDateTime = reader.GetDateTime(ordinals.LastBookingEventDateTime);
            if (!reader.IsDBNull(ordinals.LastBookingContactMethod)) LastBookingContactMethod = reader.GetString(ordinals.LastBookingContactMethod);
            if (!reader.IsDBNull(ordinals.BookingSourceName)) BookingSourceName = reader.GetString(ordinals.BookingSourceName);
            if (!reader.IsDBNull(ordinals.AdultCount)) AdultCount = reader.GetInt32(ordinals.AdultCount);
            if (!reader.IsDBNull(ordinals.ChildCount)) ChildCount = reader.GetInt32(ordinals.ChildCount);
            if (!reader.IsDBNull(ordinals.InfantCount)) InfantCount = reader.GetInt32(ordinals.InfantCount);
            if (!reader.IsDBNull(ordinals.BalanceAmount)) BalanceAmount = reader.GetDecimal(ordinals.BalanceAmount);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in BookingsOpenData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class BookingsOpenDataOrdinals {
        
        public int BookingId;
        
        public int RecordLocator;
        
        public int LastBookingEventTypeName;
        
        public int LastBookingEventDateTime;
        
        public int LastBookingContactMethod;
        
        public int BookingSourceName;
        
        public int AdultCount;
        
        public int ChildCount;
        
        public int InfantCount;
        
        public int BalanceAmount;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public BookingsOpenDataOrdinals(IDataReader reader) {
            BookingId = reader.GetOrdinal("booking_id");
            RecordLocator = reader.GetOrdinal("record_locator");
            LastBookingEventTypeName = reader.GetOrdinal("last_booking_event_type_name");
            LastBookingEventDateTime = reader.GetOrdinal("last_booking_event_date_time");
            LastBookingContactMethod = reader.GetOrdinal("last_booking_contact_method");
            BookingSourceName = reader.GetOrdinal("booking_source_name");
            AdultCount = reader.GetOrdinal("adult_count");
            ChildCount = reader.GetOrdinal("child_count");
            InfantCount = reader.GetOrdinal("infant_count");
            BalanceAmount = reader.GetOrdinal("balance_amount");
        }
    }
}
