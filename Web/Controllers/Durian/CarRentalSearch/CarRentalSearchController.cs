﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:37:49 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class CarRentalSearchController : Controller {

        [HttpGet]
        public ActionResult CarRentalSearchIndex() {

            return View(
                "~/Views/Durian/CarRentalSearch/CarRentalSearch.cshtml"
                );
        }

    }
}
