/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 9:52:59 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in FlightsForPeriod's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class FlightsForPeriodContract {
        
        [DataMember()]
        public System.Guid FlightId { get; set; }
        
        [DataMember()]
        public string AirlineIdentifierCode { get; set; }
        
        [DataMember()]
        public string FlightNumber { get; set; }
        
        [DataMember()]
        public string DepartureAirportIdentifierCode { get; set; }
        
        [DataMember()]
        public string DepartureAirportName { get; set; }
        
        [DataMember()]
        public string ArrivalAirportIdentifierCode { get; set; }
        
        [DataMember()]
        public string ArrivalAirportName { get; set; }
        
        [DataMember()]
        public System.DateTime FromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime UntilDateTime { get; set; }
        
        [DataMember()]
        public string LastDateTimeTypeName { get; set; }
        
        [DataMember()]
        public System.DateTime PlannedDepartureDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime EstimatedDepartureDateTime { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
    }
}
