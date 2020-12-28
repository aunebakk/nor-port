﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:52 PM
  From Machine: DESKTOP-LSRVP12
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
    [Route("api/1/PassengerSearchService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class PassengerSearchServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("PassengersOnFlightWithoutEvents")]
        public IEnumerable<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents(
            System.Guid flightId
            ) {

            List<PassengersOnFlightWithoutEventsContract> list =
                new PassengerSearchService().PassengersOnFlightWithoutEvents(flightId: flightId);

            return list;
        }

        [HttpGet("PassengersOnFlightCheckedIn")]
        public IEnumerable<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn(
            System.Guid flightId
            ) {

            List<PassengersOnFlightCheckedInContract> list =
                new PassengerSearchService().PassengersOnFlightCheckedIn(flightId: flightId);

            return list;
        }

        [HttpGet("PassengersOnFlight")]
        public IEnumerable<PassengersOnFlightContract> PassengersOnFlight(
            System.Guid flightId
            ) {

            List<PassengersOnFlightContract> list =
                new PassengerSearchService().PassengersOnFlight(flightId: flightId);

            return list;
        }

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