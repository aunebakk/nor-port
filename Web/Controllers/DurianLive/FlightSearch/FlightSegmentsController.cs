/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 1/20/2019 4:22:39 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class FlightSegmentsLiveController : Controller {

        [HttpGet]
        public ActionResult FlightSegmentsIndex(System.Guid flightId) {

            ViewBag.FlightId = flightId;

            return View(
                "~/Views/DurianLive/FlightSearch/FlightSegmentsIndex.cshtml",
                new FlightSearchServiceClient().FlightSegments(flightId)
                );
        }

    }
}
