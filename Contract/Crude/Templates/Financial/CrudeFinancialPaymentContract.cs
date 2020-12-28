/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:13:39 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeFinancialPaymentContract {
        
        [DataMember()]
        public System.Guid FinancialPaymentId { get; set; }
        
        [DataMember()]
        public string FinancialPaymentTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentCardId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentCashId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentVoucherId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentCouponId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentBankId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentAccountingId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
