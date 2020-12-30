/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 1:56:01 PM
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
    [Route("api/1/FlightSearchService")]
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
    public class FlightSearchServiceController : Controller {
        // get a JSON Array Contract with data for FlightsOnBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FlightsOnBooking")]
        public IEnumerable<FlightsOnBookingContract> FlightsOnBooking(
            System.Guid bookingId
            ) {

            List<FlightsOnBookingContract> list =
                new FlightSearchService().FlightsOnBooking(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for FlightHistory
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FlightHistory")]
        public IEnumerable<FlightHistoryContract> FlightHistory(
            System.Guid flightId
            ) {

            List<FlightHistoryContract> list =
                new FlightSearchService().FlightHistory(flightId: flightId);

            return list;
        }

        // get a JSON Array Contract with data for FlightSegments
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FlightSegments")]
        public IEnumerable<FlightSegmentsContract> FlightSegments(
            System.Guid flightId
            ) {

            List<FlightSegmentsContract> list =
                new FlightSearchService().FlightSegments(flightId: flightId);

            return list;
        }

        // get a JSON Array Contract with data for AirportsAvailableWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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

        // get a JSON Array Contract with data for FlightsOpenForCheckinWithDescription
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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

        // get a JSON Array Contract with data for FlightsWithCheckinInformation
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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

        // get a JSON Array Contract with data for FlightsWithBookingInformation
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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

        // get a JSON Array Contract with data for FlightsForBookingWithFare
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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

        // get a JSON Array Contract with data for FlightsForPeriod
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  departureAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   arrivalAirportId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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

        // get a JSON Array Contract with data for FlightEvents
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
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
