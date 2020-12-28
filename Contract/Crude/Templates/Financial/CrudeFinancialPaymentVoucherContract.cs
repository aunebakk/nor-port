/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:01:45 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeFinancialPaymentVoucherContract {
        
        [DataMember()]
        public System.Guid FinancialPaymentVoucherId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialVoucherId { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
