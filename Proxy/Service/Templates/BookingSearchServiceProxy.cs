/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:53:01 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class BookingSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<BookingStatisticsContract> BookingStatistics(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingStatistics?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<BookingStatisticsContract> reply =
                JsonConvert.DeserializeObject<List<BookingStatisticsContract>>(jsonString);

            return reply;
        }

        public List<BookingEventHistoryContract> BookingEventHistory(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingEventHistory?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<BookingEventHistoryContract> reply =
                JsonConvert.DeserializeObject<List<BookingEventHistoryContract>>(jsonString);

            return reply;
        }

        public List<BookingsOpenContract> BookingsOpen(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingsOpen?";
            string jsonString = client.DownloadString(query);

            List<BookingsOpenContract> reply =
                JsonConvert.DeserializeObject<List<BookingsOpenContract>>(jsonString);

            return reply;
        }

        public BookingPassengerWithExtraContract BookingPassengerWithExtra(
            System.Guid bookingPassengerId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingPassengerWithExtra?bookingPassengerId={bookingPassengerId}";
            string jsonString = client.DownloadString(query);

            BookingPassengerWithExtraContract reply =
                JsonConvert.DeserializeObject<BookingPassengerWithExtraContract>(jsonString);

            return reply;
        }

        public List<BookingPassengersContract> BookingPassengers(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingPassengers?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<BookingPassengersContract> reply =
                JsonConvert.DeserializeObject<List<BookingPassengersContract>>(jsonString);

            return reply;
        }

        public List<BookingFlightsContract> BookingFlights(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingFlights?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<BookingFlightsContract> reply =
                JsonConvert.DeserializeObject<List<BookingFlightsContract>>(jsonString);

            return reply;
        }

        public List<BookingFinancialTransactionsContract> BookingFinancialTransactions(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingFinancialTransactions?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<BookingFinancialTransactionsContract> reply =
                JsonConvert.DeserializeObject<List<BookingFinancialTransactionsContract>>(jsonString);

            return reply;
        }

        public List<BookingServiceSummaryContract> BookingServiceSummary(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingServiceSummary?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<BookingServiceSummaryContract> reply =
                JsonConvert.DeserializeObject<List<BookingServiceSummaryContract>>(jsonString);

            return reply;
        }

        public List<BookingFinancialPaymentsContract> BookingFinancialPayments(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingFinancialPayments?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<BookingFinancialPaymentsContract> reply =
                JsonConvert.DeserializeObject<List<BookingFinancialPaymentsContract>>(jsonString);

            return reply;
        }

        public BookingEventCountContract BookingEventCount(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingSearchService/BookingEventCount?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            BookingEventCountContract reply =
                JsonConvert.DeserializeObject<BookingEventCountContract>(jsonString);

            return reply;
        }

    }
}
