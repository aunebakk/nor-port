﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:42:46 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class BookingSearchController : Controller {

        [HttpGet]
        public ActionResult BookingSearchIndex() {

            return View(
                "~/Views/Durian/BookingSearch/BookingSearch.cshtml"
                );
        }

    }
}