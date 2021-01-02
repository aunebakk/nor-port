/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 7:45:56 PM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class FerrySearchController : Controller {

        [HttpGet]
        public ActionResult FerrySearchIndex() {

            return View(
                "~/Views/Durian/FerrySearch/FerrySearch.cshtml"
                );
        }

    }
}
