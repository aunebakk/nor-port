/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:48:43 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class FinancialSearchController : Controller {

        [HttpGet]
        public ActionResult FinancialSearchIndex() {

            return View(
                "~/Views/Durian/FinancialSearch/FinancialSearch.cshtml"
                );
        }

    }
}
