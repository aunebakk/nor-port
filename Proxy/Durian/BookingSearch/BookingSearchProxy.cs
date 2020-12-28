/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:21:15 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IBookingSearchService")]
    public interface IBookingSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingStatistics", ReplyAction="http://tempuri.org/IBookingSearchService/BookingStatisticsResponse")]
        List<BookingStatisticsContract> BookingStatistics (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingEventHistory", ReplyAction="http://tempuri.org/IBookingSearchService/BookingEventHistoryResponse")]
        List<BookingEventHistoryContract> BookingEventHistory (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingsOpen", ReplyAction="http://tempuri.org/IBookingSearchService/BookingsOpenResponse")]
        List<BookingsOpenContract> BookingsOpen ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingPassengerWithExtra", ReplyAction="http://tempuri.org/IBookingSearchService/BookingPassengerWithExtraResponse")]
        BookingPassengerWithExtraContract BookingPassengerWithExtra (System.Guid bookingPassengerId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingPassengers", ReplyAction="http://tempuri.org/IBookingSearchService/BookingPassengersResponse")]
        List<BookingPassengersContract> BookingPassengers (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingFlights", ReplyAction="http://tempuri.org/IBookingSearchService/BookingFlightsResponse")]
        List<BookingFlightsContract> BookingFlights (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingFinancialTransactions", ReplyAction="http://tempuri.org/IBookingSearchService/BookingFinancialTransactionsResponse")]
        List<BookingFinancialTransactionsContract> BookingFinancialTransactions (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingServiceSummary", ReplyAction="http://tempuri.org/IBookingSearchService/BookingServiceSummaryResponse")]
        List<BookingServiceSummaryContract> BookingServiceSummary (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingFinancialPayments", ReplyAction="http://tempuri.org/IBookingSearchService/BookingFinancialPaymentsResponse")]
        List<BookingFinancialPaymentsContract> BookingFinancialPayments (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingEventCount", ReplyAction="http://tempuri.org/IBookingSearchService/BookingEventCountResponse")]
        BookingEventCountContract BookingEventCount (System.Guid bookingId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingSearchServiceChannel : IBookingSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class BookingSearchService : System.ServiceModel.ClientBase<IBookingSearchService>, IBookingSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingStatisticsContract> BookingStatistics (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.BookingStatistics(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingEventHistoryContract> BookingEventHistory (System.Guid bookingId) {
            return base.Channel.BookingEventHistory(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingsOpenContract> BookingsOpen () {
            return base.Channel.BookingsOpen();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public BookingPassengerWithExtraContract BookingPassengerWithExtra (System.Guid bookingPassengerId) {
            return base.Channel.BookingPassengerWithExtra(bookingPassengerId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingPassengersContract> BookingPassengers (System.Guid bookingId) {
            return base.Channel.BookingPassengers(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingFlightsContract> BookingFlights (System.Guid bookingId) {
            return base.Channel.BookingFlights(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingFinancialTransactionsContract> BookingFinancialTransactions (System.Guid bookingId) {
            return base.Channel.BookingFinancialTransactions(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingServiceSummaryContract> BookingServiceSummary (System.Guid bookingId) {
            return base.Channel.BookingServiceSummary(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<BookingFinancialPaymentsContract> BookingFinancialPayments (System.Guid bookingId) {
            return base.Channel.BookingFinancialPayments(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public BookingEventCountContract BookingEventCount (System.Guid bookingId) {
            return base.Channel.BookingEventCount(bookingId);
        }
        
        public BookingSearchService() {
        }
        
        public BookingSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
