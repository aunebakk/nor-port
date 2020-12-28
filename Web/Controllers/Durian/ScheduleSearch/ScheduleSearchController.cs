/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:47:40 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class ScheduleSearchController : Controller {

        [HttpGet]
        public ActionResult ScheduleSearchIndex() {

            return View(
                "~/Views/Durian/ScheduleSearch/ScheduleSearch.cshtml"
                );
        }

    }
}
