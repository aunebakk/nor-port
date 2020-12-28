/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:42:54 AM
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
    [Route("api/1/AircraftMaintenanceSearchService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class AircraftMaintenanceSearchServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("AircraftPIMDetails")]
        public IEnumerable<AircraftPIMDetailsContract> AircraftPIMDetails(
            ) {

            List<AircraftPIMDetailsContract> list =
                new AircraftMaintenanceSearchService().AircraftPIMDetails();

            return list;
        }

        [HttpGet("AircraftMaintenanceIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilter(
            ) {

            List<AircraftMaintenanceIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceIndexWithFilter();

            return list;
        }

        [HttpGet("AircraftMaintenanceCompartmentIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceCompartmentIndexWithFilterContract> AircraftMaintenanceCompartmentIndexWithFilter(
            System.Guid aircraftId
            ) {

            List<AircraftMaintenanceCompartmentIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceCompartmentIndexWithFilter(aircraftId: aircraftId);

            return list;
        }

        [HttpGet("AircraftMaintenanceIdentifierIndexWithFilter")]
        public IEnumerable<AircraftMaintenanceIdentifierIndexWithFilterContract> AircraftMaintenanceIdentifierIndexWithFilter(
            System.Guid aircraftId
            ) {

            List<AircraftMaintenanceIdentifierIndexWithFilterContract> list =
                new AircraftMaintenanceSearchService().AircraftMaintenanceIdentifierIndexWithFilter(aircraftId: aircraftId);

            return list;
        }

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
