﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 7:14:01 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class DefaultSearchController : Controller {

        [HttpGet]
        public ActionResult DefaultSearchIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultSearch.cshtml"
                );
        }

    }
}
