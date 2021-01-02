/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 7:47:17 PM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in VoucherSearchWithRemainingAmount's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class VoucherSearchWithRemainingAmountContract {
        
        [DataMember()]
        public System.Guid FinancialVoucherId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public int VoucherNumber { get; set; }
        
        [DataMember()]
        public string VoucherDescription { get; set; }
        
        [DataMember()]
        public decimal RemainingAmount { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeCode { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public System.DateTime ValidFromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ValidUntilDateTime { get; set; }
    }
}
