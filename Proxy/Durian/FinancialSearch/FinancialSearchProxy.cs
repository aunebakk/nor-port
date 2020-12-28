/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:45:01 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFinancialSearchService")]
    public interface IFinancialSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/GetAvailableCurrencies", ReplyAction="http://tempuri.org/IFinancialSearchService/GetAvailableCurrenciesResponse")]
        List<GetAvailableCurrenciesContract> GetAvailableCurrencies (System.Guid financialCurrencyId,System.DateTime currencyDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/FinancialFares", ReplyAction="http://tempuri.org/IFinancialSearchService/FinancialFaresResponse")]
        List<FinancialFaresContract> FinancialFares ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/VoucherSearchWithRemainingAmount", ReplyAction="http://tempuri.org/IFinancialSearchService/VoucherSearchWithRemainingAmountResponse")]
        List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount (System.DateTime voucherValidOnDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/VoucherTransactions", ReplyAction="http://tempuri.org/IFinancialSearchService/VoucherTransactionsResponse")]
        List<VoucherTransactionsContract> VoucherTransactions (System.Guid financialVoucherId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/FinancialServiceDetailsForBooking", ReplyAction="http://tempuri.org/IFinancialSearchService/FinancialServiceDetailsForBookingResponse")]
        List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/ServiceFerryList", ReplyAction="http://tempuri.org/IFinancialSearchService/ServiceFerryListResponse")]
        List<ServiceFerryListContract> ServiceFerryList ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/ServiceCarRentalList", ReplyAction="http://tempuri.org/IFinancialSearchService/ServiceCarRentalListResponse")]
        List<ServiceCarRentalListContract> ServiceCarRentalList ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/ServiceHotelList", ReplyAction="http://tempuri.org/IFinancialSearchService/ServiceHotelListResponse")]
        List<ServiceHotelListContract> ServiceHotelList ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/SpecialServiceRequestList", ReplyAction="http://tempuri.org/IFinancialSearchService/SpecialServiceRequestListResponse")]
        List<SpecialServiceRequestListContract> SpecialServiceRequestList ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFinancialSearchService/TransactionsCreditDebitBalance", ReplyAction="http://tempuri.org/IFinancialSearchService/TransactionsCreditDebitBalanceResponse")]
        List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance (System.DateTime fromDateTime,System.DateTime untilDateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFinancialSearchServiceChannel : IFinancialSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class FinancialSearchService : System.ServiceModel.ClientBase<IFinancialSearchService>, IFinancialSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<GetAvailableCurrenciesContract> GetAvailableCurrencies (System.Guid financialCurrencyId,System.DateTime currencyDateTime) {
            return base.Channel.GetAvailableCurrencies(financialCurrencyId, currencyDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FinancialFaresContract> FinancialFares () {
            return base.Channel.FinancialFares();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount (System.DateTime voucherValidOnDateTime) {
            return base.Channel.VoucherSearchWithRemainingAmount(voucherValidOnDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<VoucherTransactionsContract> VoucherTransactions (System.Guid financialVoucherId) {
            return base.Channel.VoucherTransactions(financialVoucherId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking (System.Guid bookingId) {
            return base.Channel.FinancialServiceDetailsForBooking(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<ServiceFerryListContract> ServiceFerryList () {
            return base.Channel.ServiceFerryList();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<ServiceCarRentalListContract> ServiceCarRentalList () {
            return base.Channel.ServiceCarRentalList();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<ServiceHotelListContract> ServiceHotelList () {
            return base.Channel.ServiceHotelList();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<SpecialServiceRequestListContract> SpecialServiceRequestList () {
            return base.Channel.SpecialServiceRequestList();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance (System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.TransactionsCreditDebitBalance(fromDateTime, untilDateTime);
        }
        
        public FinancialSearchService() {
        }
        
        public FinancialSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FinancialSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
