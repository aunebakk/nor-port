/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:44:29 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// business namespace for proxy
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class FlightSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<FlightsOnBookingContract> FlightsOnBooking(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightsOnBooking?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<FlightsOnBookingContract> reply =
                JsonConvert.DeserializeObject<List<FlightsOnBookingContract>>(jsonString);

            return reply;
        }

        public List<FlightHistoryContract> FlightHistory(
            System.Guid flightId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightHistory?flightId={flightId}";
            string jsonString = client.DownloadString(query);

            List<FlightHistoryContract> reply =
                JsonConvert.DeserializeObject<List<FlightHistoryContract>>(jsonString);

            return reply;
        }

        public List<FlightSegmentsContract> FlightSegments(
            System.Guid flightId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightSegments?flightId={flightId}";
            string jsonString = client.DownloadString(query);

            List<FlightSegmentsContract> reply =
                JsonConvert.DeserializeObject<List<FlightSegmentsContract>>(jsonString);

            return reply;
        }

        public List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/AirportsAvailableWithFilter?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<AirportsAvailableWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<AirportsAvailableWithFilterContract>>(jsonString);

            return reply;
        }

        public List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightsOpenForCheckinWithDescription?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<FlightsOpenForCheckinWithDescriptionContract> reply =
                JsonConvert.DeserializeObject<List<FlightsOpenForCheckinWithDescriptionContract>>(jsonString);

            return reply;
        }

        public List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightsWithCheckinInformation?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<FlightsWithCheckinInformationContract> reply =
                JsonConvert.DeserializeObject<List<FlightsWithCheckinInformationContract>>(jsonString);

            return reply;
        }

        public List<FlightsWithBookingInformationContract> FlightsWithBookingInformation(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightsWithBookingInformation?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<FlightsWithBookingInformationContract> reply =
                JsonConvert.DeserializeObject<List<FlightsWithBookingInformationContract>>(jsonString);

            return reply;
        }

        public List<FlightsForBookingWithFareContract> FlightsForBookingWithFare(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightsForBookingWithFare?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<FlightsForBookingWithFareContract> reply =
                JsonConvert.DeserializeObject<List<FlightsForBookingWithFareContract>>(jsonString);

            return reply;
        }

        public List<FlightsForPeriodContract> FlightsForPeriod(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightsForPeriod?departureAirportId={departureAirportId}&arrivalAirportId={arrivalAirportId}&fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<FlightsForPeriodContract> reply =
                JsonConvert.DeserializeObject<List<FlightsForPeriodContract>>(jsonString);

            return reply;
        }

        public List<FlightEventsContract> FlightEvents(
            System.Guid flightId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightSearchService/FlightEvents?flightId={flightId}";
            string jsonString = client.DownloadString(query);

            List<FlightEventsContract> reply =
                JsonConvert.DeserializeObject<List<FlightEventsContract>>(jsonString);

            return reply;
        }

    }
}
