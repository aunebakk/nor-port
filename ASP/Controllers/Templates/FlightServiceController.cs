/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 7:19:36 PM
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
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/FlightService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class FlightServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\FlightService\FlightServiceHelp.cshtml");
        }

        [HttpGet("GetFlightHelp")]
        public IActionResult GetFlightHelp(
            ) {

            return View(@"Views\Templates\FlightService\GetFlightHelp.cshtml");
        }

        // get a JSON Array Contract with data for GetFlight
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("GetFlight")]
        public FlightContract GetFlight(
            System.Guid flightId,
            System.Guid userId
            ) {

            return new FlightService().GetFlight(flightId: flightId, userId: userId);
        }


        [HttpGet("UpdateFlightHelp")]
        public IActionResult UpdateFlightHelp(
            ) {

            return View(@"Views\Templates\FlightService\UpdateFlightHelp.cshtml");
        }

        // get a JSON Array Contract with data for UpdateFlight
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightContract: filter by this key, for no filter use: type unknown
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateFlight")]
        public void UpdateFlight(
            FlightContract flightContract,
            System.Guid userId
            ) {

            new FlightService().UpdateFlight(flightContract: flightContract, userId: userId);
        }


        [HttpGet("CheckFlightStatusesHelp")]
        public IActionResult CheckFlightStatusesHelp(
            ) {

            return View(@"Views\Templates\FlightService\CheckFlightStatusesHelp.cshtml");
        }

        // get a JSON Array Contract with data for CheckFlightStatuses
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  dateFrom: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   dateUntil: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("CheckFlightStatuses")]
        public void CheckFlightStatuses(
            System.DateTime dateFrom,
            System.DateTime dateUntil,
            System.Guid userId
            ) {

            new FlightService().CheckFlightStatuses(dateFrom: dateFrom, dateUntil: dateUntil, userId: userId);
        }

    }
}
