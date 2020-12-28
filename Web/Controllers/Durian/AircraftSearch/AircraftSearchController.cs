/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:35:22 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class AircraftSearchController : Controller {

        [HttpGet]
        public ActionResult AircraftSearchIndex() {

            return View(
                "~/Views/Durian/AircraftSearch/AircraftSearch.cshtml"
                );
        }

    }
}
