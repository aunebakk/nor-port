/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:10:24 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class PassengerSearchController : Controller {

        [HttpGet]
        public ActionResult PassengerSearchIndex() {

            return View(
                "~/Views/Durian/PassengerSearch/PassengerSearch.cshtml"
                );
        }

    }
}
