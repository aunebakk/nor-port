﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 3:22:16 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class ClientSearchController : Controller {

        [HttpGet]
        public ActionResult ClientSearchIndex() {

            return View(
                "~/Views/Durian/ClientSearch/ClientSearch.cshtml"
                );
        }

    }
}
