/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 1/20/2019 4:21:54 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class FlightEventsLiveController : Controller {

        [HttpGet]
        public ActionResult FlightEventsIndex(System.Guid flightId) {

            ViewBag.FlightId = flightId;

            return View(
                "~/Views/DurianLive/FlightSearch/FlightEventsIndex.cshtml",
                new FlightSearchServiceClient().FlightEvents(flightId)
                );
        }

    }
}
