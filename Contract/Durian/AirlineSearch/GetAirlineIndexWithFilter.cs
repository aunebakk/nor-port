/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:48:43 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetAirlineIndexWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class GetAirlineIndexWithFilterContract {
        
        [DataMember()]
        public string AirlineName { get; set; }
        
        [DataMember()]
        public string AirlineTypeName { get; set; }
        
        [DataMember()]
        public string LegalName { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string AirlineTypeRcd { get; set; }
        
        [DataMember()]
        public string AddressOne { get; set; }
        
        [DataMember()]
        public string AddressTwo { get; set; }
        
        [DataMember()]
        public string AddressThree { get; set; }
        
        [DataMember()]
        public string City { get; set; }
        
        [DataMember()]
        public string Street { get; set; }
        
        [DataMember()]
        public string State { get; set; }
        
        [DataMember()]
        public string District { get; set; }
        
        [DataMember()]
        public string Province { get; set; }
        
        [DataMember()]
        public string ZipCode { get; set; }
        
        [DataMember()]
        public string PoBox { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid AddressId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string StockMarketSymbol { get; set; }
        
        [DataMember()]
        public int AircraftCount { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid AirlineId { get; set; }
    }
}
