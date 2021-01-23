/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:53:17 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in FlightSegmentsSchedule's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class FlightSegmentsScheduleContract {
        
        [DataMember()]
        public System.Guid FlightScheduleId { get; set; }
        
        [DataMember()]
        public System.Guid FlightScheduleSegmentId { get; set; }
        
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
        public int LogicalSegmentNumber { get; set; }
        
        [DataMember()]
        public int PhysicalSegmentNumber { get; set; }
        
        [DataMember()]
        public System.TimeSpan DepartureTime { get; set; }
        
        [DataMember()]
        public System.TimeSpan ArrivalTime { get; set; }
        
        [DataMember()]
        public string DepartureGate { get; set; }
        
        [DataMember()]
        public string ArrivalGate { get; set; }
    }
}
