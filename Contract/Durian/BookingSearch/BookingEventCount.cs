﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:34:53 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in BookingEventCount's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class BookingEventCountContract {
        
        [DataMember()]
        public int BookingContactCount { get; set; }
        
        [DataMember()]
        public int BookingIdentifierCount { get; set; }
        
        [DataMember()]
        public int BookingServiceRequestCount { get; set; }
        
        [DataMember()]
        public int BookingEventCount { get; set; }
        
        [DataMember()]
        public int BookingFlightSegmentCount { get; set; }
        
        [DataMember()]
        public int BookingPassengerCount { get; set; }
        
        [DataMember()]
        public int FinancialBookingTransactionCount { get; set; }
        
        [DataMember()]
        public int FinancialPaymentCount { get; set; }
        
        [DataMember()]
        public int ConfirmedFlag { get; set; }
    }
}
