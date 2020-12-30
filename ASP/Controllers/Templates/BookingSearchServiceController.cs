/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 1:55:48 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/BookingSearchService")]
    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class BookingSearchServiceController : Controller {
        // get a JSON Array Contract with data for BookingStatistics
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        [HttpGet("BookingStatistics")]
        public IEnumerable<BookingStatisticsContract> BookingStatistics(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<BookingStatisticsContract> list =
                new BookingSearchService().BookingStatistics(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        // get a JSON Array Contract with data for BookingEventHistory
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingEventHistory")]
        public IEnumerable<BookingEventHistoryContract> BookingEventHistory(
            System.Guid bookingId
            ) {

            List<BookingEventHistoryContract> list =
                new BookingSearchService().BookingEventHistory(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for BookingsOpen
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        [HttpGet("BookingsOpen")]
        public IEnumerable<BookingsOpenContract> BookingsOpen(
            ) {

            List<BookingsOpenContract> list =
                new BookingSearchService().BookingsOpen();

            return list;
        }

        // get a JSON Array Contract with data for BookingPassengerWithExtra
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingPassengerId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingPassengerWithExtra")]
        public BookingPassengerWithExtraContract BookingPassengerWithExtra(
            System.Guid bookingPassengerId
            ) {

            return new BookingSearchService().BookingPassengerWithExtra(bookingPassengerId: bookingPassengerId);
        }

        // get a JSON Array Contract with data for BookingPassengers
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingPassengers")]
        public IEnumerable<BookingPassengersContract> BookingPassengers(
            System.Guid bookingId
            ) {

            List<BookingPassengersContract> list =
                new BookingSearchService().BookingPassengers(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for BookingFlights
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingFlights")]
        public IEnumerable<BookingFlightsContract> BookingFlights(
            System.Guid bookingId
            ) {

            List<BookingFlightsContract> list =
                new BookingSearchService().BookingFlights(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for BookingFinancialTransactions
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingFinancialTransactions")]
        public IEnumerable<BookingFinancialTransactionsContract> BookingFinancialTransactions(
            System.Guid bookingId
            ) {

            List<BookingFinancialTransactionsContract> list =
                new BookingSearchService().BookingFinancialTransactions(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for BookingServiceSummary
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingServiceSummary")]
        public IEnumerable<BookingServiceSummaryContract> BookingServiceSummary(
            System.Guid bookingId
            ) {

            List<BookingServiceSummaryContract> list =
                new BookingSearchService().BookingServiceSummary(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for BookingFinancialPayments
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingFinancialPayments")]
        public IEnumerable<BookingFinancialPaymentsContract> BookingFinancialPayments(
            System.Guid bookingId
            ) {

            List<BookingFinancialPaymentsContract> list =
                new BookingSearchService().BookingFinancialPayments(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for BookingEventCount
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingEventCount")]
        public BookingEventCountContract BookingEventCount(
            System.Guid bookingId
            ) {

            return new BookingSearchService().BookingEventCount(bookingId: bookingId);
        }

    }
}
