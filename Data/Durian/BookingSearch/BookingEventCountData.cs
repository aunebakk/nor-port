/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 7:46:26 AM
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
    // this class start with an identical representation of a ansi sql select statement in BookingEventCountData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class BookingEventCountData {
        
        public int BookingContactCount { get; set; }
        
        public int BookingIdentifierCount { get; set; }
        
        public int BookingServiceRequestCount { get; set; }
        
        public int BookingEventCount { get; set; }
        
        public int BookingFlightSegmentCount { get; set; }
        
        public int BookingPassengerCount { get; set; }
        
        public int FinancialBookingTransactionCount { get; set; }
        
        public int FinancialPaymentCount { get; set; }
        
        public int ConfirmedFlag { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, BookingEventCountDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.BookingContactCount)) BookingContactCount = reader.GetInt32(ordinals.BookingContactCount);
            if (!reader.IsDBNull(ordinals.BookingIdentifierCount)) BookingIdentifierCount = reader.GetInt32(ordinals.BookingIdentifierCount);
            if (!reader.IsDBNull(ordinals.BookingServiceRequestCount)) BookingServiceRequestCount = reader.GetInt32(ordinals.BookingServiceRequestCount);
            if (!reader.IsDBNull(ordinals.BookingEventCount)) BookingEventCount = reader.GetInt32(ordinals.BookingEventCount);
            if (!reader.IsDBNull(ordinals.BookingFlightSegmentCount)) BookingFlightSegmentCount = reader.GetInt32(ordinals.BookingFlightSegmentCount);
            if (!reader.IsDBNull(ordinals.BookingPassengerCount)) BookingPassengerCount = reader.GetInt32(ordinals.BookingPassengerCount);
            if (!reader.IsDBNull(ordinals.FinancialBookingTransactionCount)) FinancialBookingTransactionCount = reader.GetInt32(ordinals.FinancialBookingTransactionCount);
            if (!reader.IsDBNull(ordinals.FinancialPaymentCount)) FinancialPaymentCount = reader.GetInt32(ordinals.FinancialPaymentCount);
            if (!reader.IsDBNull(ordinals.ConfirmedFlag)) ConfirmedFlag = reader.GetInt32(ordinals.ConfirmedFlag);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in BookingEventCountData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class BookingEventCountDataOrdinals {
        
        public int BookingContactCount;
        
        public int BookingIdentifierCount;
        
        public int BookingServiceRequestCount;
        
        public int BookingEventCount;
        
        public int BookingFlightSegmentCount;
        
        public int BookingPassengerCount;
        
        public int FinancialBookingTransactionCount;
        
        public int FinancialPaymentCount;
        
        public int ConfirmedFlag;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public BookingEventCountDataOrdinals(IDataReader reader) {
            BookingContactCount = reader.GetOrdinal("booking_contact_count");
            BookingIdentifierCount = reader.GetOrdinal("booking_identifier_count");
            BookingServiceRequestCount = reader.GetOrdinal("booking_service_request_count");
            BookingEventCount = reader.GetOrdinal("booking_event_count");
            BookingFlightSegmentCount = reader.GetOrdinal("booking_flight_segment_count");
            BookingPassengerCount = reader.GetOrdinal("booking_passenger_count");
            FinancialBookingTransactionCount = reader.GetOrdinal("financial_booking_transaction_count");
            FinancialPaymentCount = reader.GetOrdinal("financial_payment_count");
            ConfirmedFlag = reader.GetOrdinal("confirmed_flag");
        }
    }
}
