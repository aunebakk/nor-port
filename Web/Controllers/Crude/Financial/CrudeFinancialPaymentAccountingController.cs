﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:17:43 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPort.AspMvc.Controllers {

    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/bc619e06-279f-4682-825d-3d1aef43067f
    public class CrudeFinancialPaymentAccountingController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingIndex.cshtml",
                new CrudeFinancialPaymentAccountingServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingIndex.cshtml",
                new CrudeFinancialPaymentAccountingServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingDetails(System.Guid financialPaymentAccountingId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingDetails.cshtml",
                new CrudeFinancialPaymentAccountingServiceClient().FetchByFinancialPaymentAccountingId(financialPaymentAccountingId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingEdit(
            System.Guid financialPaymentAccountingId
            ) {

            CrudeFinancialPaymentAccountingContract contract = new CrudeFinancialPaymentAccountingServiceClient().FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentAccountingEdit([Bind()] CrudeFinancialPaymentAccountingContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentAccountingServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentAccountingIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingCreate(System.Guid? financialCurrencyId, System.Guid? userId) {
            var contract = new CrudeFinancialPaymentAccountingContract();
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentAccountingCreate([Bind()] CrudeFinancialPaymentAccountingContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentAccountingServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentAccountingIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingDelete(
            System.Guid financialPaymentAccountingId
            ) {
            new CrudeFinancialPaymentAccountingServiceClient().Delete(financialPaymentAccountingId);

            return RedirectToAction("CrudeFinancialPaymentAccountingIndex");
        }
    }
}