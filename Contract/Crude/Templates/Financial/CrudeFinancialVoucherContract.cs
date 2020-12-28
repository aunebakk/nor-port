/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 4:54:56 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeFinancialVoucherContract {
        
        [DataMember()]
        public System.Guid FinancialVoucherId { get; set; }
        
        [DataMember()]
        public string FinancialVoucherTypeRcd { get; set; }
        
        [DataMember()]
        public int VoucherNumber { get; set; }
        
        [DataMember()]
        public string VoucherDescription { get; set; }
        
        [DataMember()]
        public decimal ValueAmount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.DateTime ValidFromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ValidUntilDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
