/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 7:16:59 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in FetchServiceSpecialServiceRequestWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class FetchServiceSpecialServiceRequestWithFilterContract {
        
        [DataMember()]
        public string ServiceSpecialServiceRequestGroupRcd { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestGroupName { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestCode { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestName { get; set; }
        
        [DataMember()]
        public string ServiceDescription { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public bool InventoryControlledFlag { get; set; }
        
        [DataMember()]
        public string RequestServiceSpecialServiceRequestRequirementRcd { get; set; }
        
        [DataMember()]
        public string RequestRequirementName { get; set; }
        
        [DataMember()]
        public string ReplyServiceSpecialServiceRequestRequirementRcd { get; set; }
        
        [DataMember()]
        public string ReplyRequirementName { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestOperationRuleRcd { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestOperationRuleName { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
    }
}
