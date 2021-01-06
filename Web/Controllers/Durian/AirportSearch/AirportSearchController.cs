/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:44:26 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class AirportSearchController : Controller {

        [HttpGet]
        public ActionResult AirportSearchIndex() {

            return View(
                "~/Views/Durian/AirportSearch/AirportSearch.cshtml"
                );
        }

    }
}
