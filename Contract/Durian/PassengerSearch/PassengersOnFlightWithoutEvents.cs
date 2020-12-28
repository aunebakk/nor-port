/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:26:14 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in PassengersOnFlightWithoutEvents's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class PassengersOnFlightWithoutEventsContract {
        
        [DataMember()]
        public string RecordLocator { get; set; }
        
        [DataMember()]
        public string ReceivedFrom { get; set; }
        
        [DataMember()]
        public string PassengerName { get; set; }
        
        [DataMember()]
        public string PassengerTypeName { get; set; }
        
        [DataMember()]
        public System.Guid PassengerId { get; set; }
        
        [DataMember()]
        public System.Guid BookingId { get; set; }
        
        [DataMember()]
        public System.Guid BookingPassengerId { get; set; }
        
        [DataMember()]
        public System.Guid BookingFlightSegmentId { get; set; }
    }
}
