/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 1:48:31 PM
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
