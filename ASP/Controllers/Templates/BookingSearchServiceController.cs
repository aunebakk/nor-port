/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:50:39 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// controller namespace for mvc
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/BookingSearchService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class BookingSearchServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

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

        [HttpGet("BookingEventHistory")]
        public IEnumerable<BookingEventHistoryContract> BookingEventHistory(
            System.Guid bookingId
            ) {

            List<BookingEventHistoryContract> list =
                new BookingSearchService().BookingEventHistory(bookingId: bookingId);

            return list;
        }

        [HttpGet("BookingsOpen")]
        public IEnumerable<BookingsOpenContract> BookingsOpen(
            ) {

            List<BookingsOpenContract> list =
                new BookingSearchService().BookingsOpen();

            return list;
        }

        [HttpGet("BookingPassengerWithExtra")]
        public BookingPassengerWithExtraContract BookingPassengerWithExtra(
            System.Guid bookingPassengerId
            ) {

            return new BookingSearchService().BookingPassengerWithExtra(bookingPassengerId: bookingPassengerId);
        }

        [HttpGet("BookingPassengers")]
        public IEnumerable<BookingPassengersContract> BookingPassengers(
            System.Guid bookingId
            ) {

            List<BookingPassengersContract> list =
                new BookingSearchService().BookingPassengers(bookingId: bookingId);

            return list;
        }

        [HttpGet("BookingFlights")]
        public IEnumerable<BookingFlightsContract> BookingFlights(
            System.Guid bookingId
            ) {

            List<BookingFlightsContract> list =
                new BookingSearchService().BookingFlights(bookingId: bookingId);

            return list;
        }

        [HttpGet("BookingFinancialTransactions")]
        public IEnumerable<BookingFinancialTransactionsContract> BookingFinancialTransactions(
            System.Guid bookingId
            ) {

            List<BookingFinancialTransactionsContract> list =
                new BookingSearchService().BookingFinancialTransactions(bookingId: bookingId);

            return list;
        }

        [HttpGet("BookingServiceSummary")]
        public IEnumerable<BookingServiceSummaryContract> BookingServiceSummary(
            System.Guid bookingId
            ) {

            List<BookingServiceSummaryContract> list =
                new BookingSearchService().BookingServiceSummary(bookingId: bookingId);

            return list;
        }

        [HttpGet("BookingFinancialPayments")]
        public IEnumerable<BookingFinancialPaymentsContract> BookingFinancialPayments(
            System.Guid bookingId
            ) {

            List<BookingFinancialPaymentsContract> list =
                new BookingSearchService().BookingFinancialPayments(bookingId: bookingId);

            return list;
        }

        [HttpGet("BookingEventCount")]
        public BookingEventCountContract BookingEventCount(
            System.Guid bookingId
            ) {

            return new BookingSearchService().BookingEventCount(bookingId: bookingId);
        }
    }
}
