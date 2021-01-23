﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 6:11:45 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/PassengerSearchService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class PassengerSearchServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\PassengerSearchService\PassengerSearchServiceHelp.cshtml");
        }

        [HttpGet("PassengersOnFlightWithoutEventsHelp")]
        public IActionResult PassengersOnFlightWithoutEventsHelp(
            ) {

            return View(@"Views\Templates\PassengerSearchService\PassengersOnFlightWithoutEventsHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengersOnFlightWithoutEvents
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengersOnFlightWithoutEvents")]
        public IEnumerable<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents(
            System.Guid flightId
            ) {

            List<PassengersOnFlightWithoutEventsContract> list =
                new PassengerSearchService().PassengersOnFlightWithoutEvents(flightId: flightId);

            return list;
        }


        [HttpGet("PassengersOnFlightCheckedInHelp")]
        public IActionResult PassengersOnFlightCheckedInHelp(
            ) {

            return View(@"Views\Templates\PassengerSearchService\PassengersOnFlightCheckedInHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengersOnFlightCheckedIn
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengersOnFlightCheckedIn")]
        public IEnumerable<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn(
            System.Guid flightId
            ) {

            List<PassengersOnFlightCheckedInContract> list =
                new PassengerSearchService().PassengersOnFlightCheckedIn(flightId: flightId);

            return list;
        }


        [HttpGet("PassengersOnFlightHelp")]
        public IActionResult PassengersOnFlightHelp(
            ) {

            return View(@"Views\Templates\PassengerSearchService\PassengersOnFlightHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengersOnFlight
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengersOnFlight")]
        public IEnumerable<PassengersOnFlightContract> PassengersOnFlight(
            System.Guid flightId
            ) {

            List<PassengersOnFlightContract> list =
                new PassengerSearchService().PassengersOnFlight(flightId: flightId);

            return list;
        }


        [HttpGet("PassengersOnBookingHelp")]
        public IActionResult PassengersOnBookingHelp(
            ) {

            return View(@"Views\Templates\PassengerSearchService\PassengersOnBookingHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengersOnBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengersOnBooking")]
        public IEnumerable<PassengersOnBookingContract> PassengersOnBooking(
            System.Guid bookingId
            ) {

            List<PassengersOnBookingContract> list =
                new PassengerSearchService().PassengersOnBooking(bookingId: bookingId);

            return list;
        }

    }
}
