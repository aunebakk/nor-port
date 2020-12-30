/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 7:04:39 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class DefaultTestSearchController : Controller {

        [HttpGet]
        public ActionResult DefaultTestSearchIndex() {

            return View(
                "~/Views/Durian/DefaultTestSearch/DefaultTestSearch.cshtml"
                );
        }

    }
}
