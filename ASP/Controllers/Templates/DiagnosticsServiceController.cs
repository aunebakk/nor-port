/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 2:42:27 PM
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
    [Route("api/1/DiagnosticsService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DiagnosticsServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\DiagnosticsService\DiagnosticsServiceHelp.cshtml");
        }

        [HttpGet("WorkingSetHelp")]
        public IActionResult WorkingSetHelp(
            ) {

            return View(@"Views\Templates\DiagnosticsService\WorkingSetHelp.cshtml");
        }

        // get a JSON Array Contract with data for WorkingSet
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("WorkingSet")]
        public System.Int64 WorkingSet(
            ) {

            return new DiagnosticsService().WorkingSet();
        }


        [HttpGet("PingTestHelp")]
        public IActionResult PingTestHelp(
            ) {

            return View(@"Views\Templates\DiagnosticsService\PingTestHelp.cshtml");
        }

        // get a JSON Array Contract with data for PingTest
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("PingTest")]
        public System.DateTime PingTest(
            ) {

            return new DiagnosticsService().PingTest();
        }


        [HttpGet("DatabaseHelp")]
        public IActionResult DatabaseHelp(
            ) {

            return View(@"Views\Templates\DiagnosticsService\DatabaseHelp.cshtml");
        }

        // get a JSON Array Contract with data for Database
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("Database")]
        public System.String Database(
            ) {

            return new DiagnosticsService().Database();
        }


        [HttpGet("ComputerNameHelp")]
        public IActionResult ComputerNameHelp(
            ) {

            return View(@"Views\Templates\DiagnosticsService\ComputerNameHelp.cshtml");
        }

        // get a JSON Array Contract with data for ComputerName
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("ComputerName")]
        public System.String ComputerName(
            ) {

            return new DiagnosticsService().ComputerName();
        }

    }
}
