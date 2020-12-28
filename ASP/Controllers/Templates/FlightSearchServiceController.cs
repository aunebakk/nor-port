/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:51:04 AM
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
    [Route("api/1/FlightSearchService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class FlightSearchServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("FlightsOnBooking")]
        public IEnumerable<FlightsOnBookingContract> FlightsOnBooking(
            System.Guid bookingId
            ) {

            List<FlightsOnBookingContract> list =
                new FlightSearchService().FlightsOnBooking(bookingId: bookingId);

            return list;
        }

        [HttpGet("FlightHistory")]
        public IEnumerable<FlightHistoryContract> FlightHistory(
            System.Guid flightId
            ) {

            List<FlightHistoryContract> list =
                new FlightSearchService().FlightHistory(flightId: flightId);

            return list;
        }

        [HttpGet("FlightSegments")]
        public IEnumerable<FlightSegmentsContract> FlightSegments(
            System.Guid flightId
            ) {

            List<FlightSegmentsContract> list =
                new FlightSearchService().FlightSegments(flightId: flightId);

            return list;
        }

        [HttpGet("AirportsAvailableWithFilter")]
        public IEnumerable<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<AirportsAvailableWithFilterContract> list =
                new FlightSearchService().AirportsAvailableWithFilter(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        [HttpGet("FlightsOpenForCheckinWithDescription")]
        public IEnumerable<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<FlightsOpenForCheckinWithDescriptionContract> list =
                new FlightSearchService().FlightsOpenForCheckinWithDescription(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        [HttpGet("FlightsWithCheckinInformation")]
        public IEnumerable<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<FlightsWithCheckinInformationContract> list =
                new FlightSearchService().FlightsWithCheckinInformation(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        [HttpGet("FlightsWithBookingInformation")]
        public IEnumerable<FlightsWithBookingInformationContract> FlightsWithBookingInformation(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<FlightsWithBookingInformationContract> list =
                new FlightSearchService().FlightsWithBookingInformation(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        [HttpGet("FlightsForBookingWithFare")]
        public IEnumerable<FlightsForBookingWithFareContract> FlightsForBookingWithFare(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<FlightsForBookingWithFareContract> list =
                new FlightSearchService().FlightsForBookingWithFare(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        [HttpGet("FlightsForPeriod")]
        public IEnumerable<FlightsForPeriodContract> FlightsForPeriod(
            System.Guid departureAirportId,
            System.Guid arrivalAirportId,
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<FlightsForPeriodContract> list =
                new FlightSearchService().FlightsForPeriod(departureAirportId: departureAirportId, arrivalAirportId: arrivalAirportId, fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }

        [HttpGet("FlightEvents")]
        public IEnumerable<FlightEventsContract> FlightEvents(
            System.Guid flightId
            ) {

            List<FlightEventsContract> list =
                new FlightSearchService().FlightEvents(flightId: flightId);

            return list;
        }
    }
}
