/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 1:48:35 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IBookingSearchService {
        // returns a list of BookingStatistics contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingStatisticsContract> BookingStatistics (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of BookingEventHistory contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingEventHistoryContract> BookingEventHistory (System.Guid bookingId);
        // returns a list of BookingsOpen contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<BookingsOpenContract> BookingsOpen ();
        // returns a list of BookingPassengerWithExtra contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingPassengerId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        BookingPassengerWithExtraContract BookingPassengerWithExtra (System.Guid bookingPassengerId);
        // returns a list of BookingPassengers contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingPassengersContract> BookingPassengers (System.Guid bookingId);
        // returns a list of BookingFlights contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingFlightsContract> BookingFlights (System.Guid bookingId);
        // returns a list of BookingFinancialTransactions contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingFinancialTransactionsContract> BookingFinancialTransactions (System.Guid bookingId);
        // returns a list of BookingServiceSummary contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingServiceSummaryContract> BookingServiceSummary (System.Guid bookingId);
        // returns a list of BookingFinancialPayments contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<BookingFinancialPaymentsContract> BookingFinancialPayments (System.Guid bookingId);
        
        // returns a list of BookingEventCount contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        BookingEventCountContract BookingEventCount(System.Guid bookingId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class BookingSearchService : IBookingSearchService {
        // returns a list of BookingStatistics contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingStatisticsContract> BookingStatistics (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all BookingStatistics serialized objects from BookingSearch as BookingStatistics contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingStatistics();
            return businessLogicLayer.BookingStatisticsFromDal(dataAccessLayer.BookingStatistics(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        // returns a list of BookingEventHistory contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingEventHistoryContract> BookingEventHistory (System.Guid bookingId) {
            // transfer all BookingEventHistory serialized objects from BookingSearch as BookingEventHistory contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingEventHistory();
            return businessLogicLayer.BookingEventHistoryFromDal(dataAccessLayer.BookingEventHistory(bookingId));
        }
        // returns a list of BookingsOpen contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<BookingsOpenContract> BookingsOpen () {
            // transfer all BookingsOpen serialized objects from BookingSearch as BookingsOpen contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingsOpen();
            return businessLogicLayer.BookingsOpenFromDal(dataAccessLayer.BookingsOpen());
        }
        // returns a list of BookingPassengerWithExtra contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingPassengerId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public BookingPassengerWithExtraContract BookingPassengerWithExtra (System.Guid bookingPassengerId) {
            // transfer all BookingPassengerWithExtra serialized objects from BookingSearch as BookingPassengerWithExtra contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingPassengerWithExtra();
            return businessLogicLayer.BookingPassengerWithExtraFromDal(dataAccessLayer.BookingPassengerWithExtra(bookingPassengerId));
        }
        // returns a list of BookingPassengers contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingPassengersContract> BookingPassengers (System.Guid bookingId) {
            // transfer all BookingPassengers serialized objects from BookingSearch as BookingPassengers contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingPassengers();
            return businessLogicLayer.BookingPassengersFromDal(dataAccessLayer.BookingPassengers(bookingId));
        }
        // returns a list of BookingFlights contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingFlightsContract> BookingFlights (System.Guid bookingId) {
            // transfer all BookingFlights serialized objects from BookingSearch as BookingFlights contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingFlights();
            return businessLogicLayer.BookingFlightsFromDal(dataAccessLayer.BookingFlights(bookingId));
        }
        // returns a list of BookingFinancialTransactions contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingFinancialTransactionsContract> BookingFinancialTransactions (System.Guid bookingId) {
            // transfer all BookingFinancialTransactions serialized objects from BookingSearch as BookingFinancialTransactions contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingFinancialTransactions();
            return businessLogicLayer.BookingFinancialTransactionsFromDal(dataAccessLayer.BookingFinancialTransactions(bookingId));
        }
        // returns a list of BookingServiceSummary contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingServiceSummaryContract> BookingServiceSummary (System.Guid bookingId) {
            // transfer all BookingServiceSummary serialized objects from BookingSearch as BookingServiceSummary contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingServiceSummary();
            return businessLogicLayer.BookingServiceSummaryFromDal(dataAccessLayer.BookingServiceSummary(bookingId));
        }
        // returns a list of BookingFinancialPayments contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<BookingFinancialPaymentsContract> BookingFinancialPayments (System.Guid bookingId) {
            // transfer all BookingFinancialPayments serialized objects from BookingSearch as BookingFinancialPayments contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingFinancialPayments();
            return businessLogicLayer.BookingFinancialPaymentsFromDal(dataAccessLayer.BookingFinancialPayments(bookingId));
        }
        
        // returns a list of BookingEventCount contracts from BookingSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual BookingEventCountContract BookingEventCount(System.Guid bookingId) {
            // transfer all BookingEventCount serialized objects from BookingSearch as BookingEventCount contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.BookingSearch();
            var businessLogicLayer = new BookingEventCount();
            return businessLogicLayer.BookingEventCountFromDal(dataAccessLayer.BookingEventCount(bookingId));
        }
    }
}
