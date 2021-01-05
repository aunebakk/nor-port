/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 3:36:29 AM
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
    [Route("api/1/AircraftMaintenanceSearchService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class AircraftMaintenanceSearchServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\AircraftMaintenanceSearchService\AircraftMaintenanceSearchServiceHelp.cshtml");
        }

        [HttpGet("AircraftPIMDetailsHelp")]
        public IActionResult AircraftPIMDetailsHelp(
            ) {

            return View(@"Views\Templates\AircraftMaintenanceSearchService\AircraftPIMDetailsHelp.cshtml");
        }

        // get a JSON Array Contract with data for AircraftPIMDetails
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("AircraftPIMDetails")]
        public IEnumerable<AircraftPIMDetailsContract> AircraftPIMDetails(
            ) {

            List<AircraftPIMDetailsContract> list =
                new AircraftMaintenanceSearchService().AircraftPIMDetails();

            return list;
        }


        [HttpGet("AircraftMaintenanceIndexWithFilterHelp")]
        public IActionResult AircraftMaintenanceIndexWithFilterHelp(
            ) {

            return View(@"Views\Templates\AircraftMaintenanceSearchService\AircraftMaintenanceIndexWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for AircraftMaintenanceIndexWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("AircraftMaintenanceIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilter(
            ) {

            List<AircraftMaintenanceIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceIndexWithFilter();

            return list;
        }


        [HttpGet("AircraftMaintenanceCompartmentIndexWithFilterHelp")]
        public IActionResult AircraftMaintenanceCompartmentIndexWithFilterHelp(
            ) {

            return View(@"Views\Templates\AircraftMaintenanceSearchService\AircraftMaintenanceCompartmentIndexWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for AircraftMaintenanceCompartmentIndexWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  aircraftId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("AircraftMaintenanceCompartmentIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceCompartmentIndexWithFilterContract> AircraftMaintenanceCompartmentIndexWithFilter(
            System.Guid aircraftId
            ) {

            List<AircraftMaintenanceCompartmentIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceCompartmentIndexWithFilter(aircraftId: aircraftId);

            return list;
        }


        [HttpGet("AircraftMaintenanceIdentifierIndexWithFilterHelp")]
        public IActionResult AircraftMaintenanceIdentifierIndexWithFilterHelp(
            ) {

            return View(@"Views\Templates\AircraftMaintenanceSearchService\AircraftMaintenanceIdentifierIndexWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for AircraftMaintenanceIdentifierIndexWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  aircraftId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("AircraftMaintenanceIdentifierIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceIdentifierIndexWithFilterContract> AircraftMaintenanceIdentifierIndexWithFilter(
            System.Guid aircraftId
            ) {

            List<AircraftMaintenanceIdentifierIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceIdentifierIndexWithFilter(aircraftId: aircraftId);

            return list;
        }


        [HttpGet("AircraftMaintenanceDocumentIndexWithFilterHelp")]
        public IActionResult AircraftMaintenanceDocumentIndexWithFilterHelp(
            ) {

            return View(@"Views\Templates\AircraftMaintenanceSearchService\AircraftMaintenanceDocumentIndexWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for AircraftMaintenanceDocumentIndexWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  aircraftId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("AircraftMaintenanceDocumentIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceDocumentIndexWithFilterContract> AircraftMaintenanceDocumentIndexWithFilter(
            System.Guid aircraftId
            ) {

            List<AircraftMaintenanceDocumentIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceDocumentIndexWithFilter(aircraftId: aircraftId);

            return list;
        }

    }
}
