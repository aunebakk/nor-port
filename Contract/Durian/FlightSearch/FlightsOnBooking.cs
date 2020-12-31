/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 11:04:02 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in FlightsOnBooking's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class FlightsOnBookingContract {
        
        [DataMember()]
        public string FlightNumber { get; set; }
        
        [DataMember()]
        public string OriginAirportCode { get; set; }
        
        [DataMember()]
        public string OriginAirportName { get; set; }
        
        [DataMember()]
        public string DestinationAirportCode { get; set; }
        
        [DataMember()]
        public string DestinationAirportName { get; set; }
        
        [DataMember()]
        public System.DateTime FromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime UntilDateTime { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid FlightId { get; set; }
    }
}
