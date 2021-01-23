﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:47:28 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in FinancialFares's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class FinancialFaresContract {
        
        [DataMember()]
        public string FinancialFareTypeRcd { get; set; }
        
        [DataMember()]
        public string DepartureAirportIdentifierCode { get; set; }
        
        [DataMember()]
        public string DepartureAirportName { get; set; }
        
        [DataMember()]
        public string ArrivalAirportIdentifierCode { get; set; }
        
        [DataMember()]
        public string ArrivalAirportName { get; set; }
        
        [DataMember()]
        public System.DateTime ValidFromFlightDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ValidUntilFlightDateTime { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public string DefaultUserCode { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.Guid FinancialFareId { get; set; }
    }
}
