/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:45:07 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in SpecialServiceRequestList's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class SpecialServiceRequestListContract {
        
        [DataMember()]
        public string ServiceSpecialServiceRequestGroupRcd { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestCode { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestName { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public string ServiceDescription { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestRequirementName { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestOperationRuleName { get; set; }
        
        [DataMember()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
    }
}
