/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:29:09 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in BookingFinancialPayments's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class BookingFinancialPaymentsContract {
        
        [DataMember()]
        public int TransactionNumber { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public string FinancialPaymentTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialPaymentTypeName { get; set; }
        
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
        public string PaymentDescription { get; set; }
        
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
    }
}
