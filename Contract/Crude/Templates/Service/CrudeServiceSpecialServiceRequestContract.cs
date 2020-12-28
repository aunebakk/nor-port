/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 7:51:26 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeServiceSpecialServiceRequestContract {
        
        [DataMember()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestGroupRcd { get; set; }
        
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
        public bool InventoryControlledFlag { get; set; }
        
        [DataMember()]
        public string RequestServiceSpecialServiceRequestRequirementRcd { get; set; }
        
        [DataMember()]
        public string ReplyServiceSpecialServiceRequestRequirementRcd { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestOperationRuleRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
