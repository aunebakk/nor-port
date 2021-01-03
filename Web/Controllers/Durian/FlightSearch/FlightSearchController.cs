/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:30:33 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class FlightSearchController : Controller {

        [HttpGet]
        public ActionResult FlightSearchIndex() {

            return View(
                "~/Views/Durian/FlightSearch/FlightSearch.cshtml"
                );
        }

    }
}
