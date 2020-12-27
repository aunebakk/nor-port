/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 1/16/2019 5:33:45 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class AircraftDetailsLiveController : Controller {

        [HttpGet]
        public ActionResult AircraftDetailsIndex() {

            return View(
                "~/Views/DurianLive/AircraftSearch/AircraftDetailsIndex.cshtml",
                new AircraftSearchService().AircraftDetails()
                );
        }

    }
}
