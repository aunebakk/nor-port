/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:39:54 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/179373dc-6fcc-4fc3-a7aa-e57c35d4d1d4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IBookingSearchService")]
    public interface IBookingSearchServiceClient {
        // returns a list of BookingStatistics contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingStatistics", ReplyAction="http://tempuri.org/IBookingSearchService/BookingStatisticsResponse")]
        List<BookingStatisticsContract> BookingStatistics (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of BookingEventHistory contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingEventHistory", ReplyAction="http://tempuri.org/IBookingSearchService/BookingEventHistoryResponse")]
        List<BookingEventHistoryContract> BookingEventHistory (System.Guid bookingId);
        // returns a list of BookingsOpen contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingsOpen", ReplyAction="http://tempuri.org/IBookingSearchService/BookingsOpenResponse")]
        List<BookingsOpenContract> BookingsOpen ();
        // returns a list of BookingPassengerWithExtra contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingPassengerId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingPassengerWithExtra", ReplyAction="http://tempuri.org/IBookingSearchService/BookingPassengerWithExtraResponse")]
        BookingPassengerWithExtraContract BookingPassengerWithExtra (System.Guid bookingPassengerId);
        // returns a list of BookingPassengers contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingPassengers", ReplyAction="http://tempuri.org/IBookingSearchService/BookingPassengersResponse")]
        List<BookingPassengersContract> BookingPassengers (System.Guid bookingId);
        // returns a list of BookingFlights contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingFlights", ReplyAction="http://tempuri.org/IBookingSearchService/BookingFlightsResponse")]
        List<BookingFlightsContract> BookingFlights (System.Guid bookingId);
        // returns a list of BookingFinancialTransactions contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingFinancialTransactions", ReplyAction="http://tempuri.org/IBookingSearchService/BookingFinancialTransactionsResponse")]
        List<BookingFinancialTransactionsContract> BookingFinancialTransactions (System.Guid bookingId);
        // returns a list of BookingServiceSummary contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingServiceSummary", ReplyAction="http://tempuri.org/IBookingSearchService/BookingServiceSummaryResponse")]
        List<BookingServiceSummaryContract> BookingServiceSummary (System.Guid bookingId);
        // returns a list of BookingFinancialPayments contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingFinancialPayments", ReplyAction="http://tempuri.org/IBookingSearchService/BookingFinancialPaymentsResponse")]
        List<BookingFinancialPaymentsContract> BookingFinancialPayments (System.Guid bookingId);
        // returns a list of BookingEventCount contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingSearchService/BookingEventCount", ReplyAction="http://tempuri.org/IBookingSearchService/BookingEventCountResponse")]
        BookingEventCountContract BookingEventCount (System.Guid bookingId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingSearchServiceChannel : IBookingSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class BookingSearchServiceClient : System.ServiceModel.ClientBase<IBookingSearchServiceClient>, IBookingSearchServiceClient {
        // returns a list of BookingStatistics contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingStatisticsContract> BookingStatistics (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.BookingStatistics(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of BookingEventHistory contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingEventHistoryContract> BookingEventHistory (System.Guid bookingId) {
            return base.Channel.BookingEventHistory(bookingId);
        }
        // returns a list of BookingsOpen contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<BookingsOpenContract> BookingsOpen () {
            return base.Channel.BookingsOpen();
        }
        // returns a list of BookingPassengerWithExtra contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingPassengerId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public BookingPassengerWithExtraContract BookingPassengerWithExtra (System.Guid bookingPassengerId) {
            return base.Channel.BookingPassengerWithExtra(bookingPassengerId);
        }
        // returns a list of BookingPassengers contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingPassengersContract> BookingPassengers (System.Guid bookingId) {
            return base.Channel.BookingPassengers(bookingId);
        }
        // returns a list of BookingFlights contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingFlightsContract> BookingFlights (System.Guid bookingId) {
            return base.Channel.BookingFlights(bookingId);
        }
        // returns a list of BookingFinancialTransactions contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingFinancialTransactionsContract> BookingFinancialTransactions (System.Guid bookingId) {
            return base.Channel.BookingFinancialTransactions(bookingId);
        }
        // returns a list of BookingServiceSummary contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingServiceSummaryContract> BookingServiceSummary (System.Guid bookingId) {
            return base.Channel.BookingServiceSummary(bookingId);
        }
        // returns a list of BookingFinancialPayments contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingFinancialPaymentsContract> BookingFinancialPayments (System.Guid bookingId) {
            return base.Channel.BookingFinancialPayments(bookingId);
        }
        // returns a list of BookingEventCount contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public BookingEventCountContract BookingEventCount (System.Guid bookingId) {
            return base.Channel.BookingEventCount(bookingId);
        }
        
        public BookingSearchServiceClient() {
        }
        
        public BookingSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
