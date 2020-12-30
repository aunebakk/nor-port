/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 5:50:29 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in VoucherTransactions's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    // SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class VoucherTransactionsContract {
        
        [DataMember()]
        public int VoucherNumber { get; set; }
        
        [DataMember()]
        public string VoucherDescription { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public decimal PaidCurrencyAmount { get; set; }
        
        [DataMember()]
        public string PaidCurrencyType { get; set; }
        
        [DataMember()]
        public decimal ExchangeRate { get; set; }
        
        [DataMember()]
        public decimal BookingCurrencyAmount { get; set; }
        
        [DataMember()]
        public string BookingCurrencyType { get; set; }
        
        [DataMember()]
        public string FinancialCostcentreCode { get; set; }
        
        [DataMember()]
        public string FinancialCostcentreName { get; set; }
        
        [DataMember()]
        public string DefaultUserCode { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.Guid FinancialPaymentId { get; set; }
        
        [DataMember()]
        public System.Guid BookingId { get; set; }
    }
}
