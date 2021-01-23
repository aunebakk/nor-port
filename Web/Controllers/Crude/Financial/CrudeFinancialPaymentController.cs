﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 4:57:22 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPort.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeFinancialPaymentController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeFinancialPaymentIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentIndex.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFinancialPaymentByFinancialPaymentCardIndex(System.Guid financialPaymentCardId) {
            ViewBag.FinancialPaymentCardId = financialPaymentCardId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentIndex.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentCardId(financialPaymentCardId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFinancialPaymentByFinancialPaymentBankIndex(System.Guid financialPaymentBankId) {
            ViewBag.FinancialPaymentBankId = financialPaymentBankId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentIndex.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentBankId(financialPaymentBankId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeFinancialPaymentDetails(System.Guid financialPaymentId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentDetails.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentId(financialPaymentId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeFinancialPaymentEdit(
            System.Guid financialPaymentId
            ) {

            CrudeFinancialPaymentContract contract = new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentId(financialPaymentId);
            ViewBag.FinancialPaymentTypeRcd =
                new SelectList( new CrudeFinancialPaymentTypeRefServiceClient().FetchAll(),
                                "FinancialPaymentTypeRcd",
                                "FinancialPaymentTypeName",
                                contract.FinancialPaymentTypeRcd
                                );

            ViewBag.FinancialPaymentCardId =
                new SelectList( new CrudeFinancialPaymentCardServiceClient().FetchAll(),
                                "FinancialPaymentCardId",
                                "NameOnCard",
                                contract.FinancialPaymentCardId
                                );

            ViewBag.FinancialPaymentBankId =
                new SelectList( new CrudeFinancialPaymentBankServiceClient().FetchAll(),
                                "FinancialPaymentBankId",
                                "BankName",
                                contract.FinancialPaymentBankId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentEdit([Bind()] CrudeFinancialPaymentContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeFinancialPaymentCreate(System.Guid? financialPaymentCardId, System.Guid? financialPaymentCashId, System.Guid? financialPaymentVoucherId, System.Guid? financialPaymentCouponId, System.Guid? financialPaymentBankId, System.Guid? financialPaymentAccountingId, System.Guid? userId) {
            var contract = new CrudeFinancialPaymentContract();
            if (financialPaymentCardId != null) contract.FinancialPaymentCardId = (System.Guid) financialPaymentCardId;
            if (financialPaymentCashId != null) contract.FinancialPaymentCashId = (System.Guid) financialPaymentCashId;
            if (financialPaymentVoucherId != null) contract.FinancialPaymentVoucherId = (System.Guid) financialPaymentVoucherId;
            if (financialPaymentCouponId != null) contract.FinancialPaymentCouponId = (System.Guid) financialPaymentCouponId;
            if (financialPaymentBankId != null) contract.FinancialPaymentBankId = (System.Guid) financialPaymentBankId;
            if (financialPaymentAccountingId != null) contract.FinancialPaymentAccountingId = (System.Guid) financialPaymentAccountingId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialPaymentTypeRcd =
                new SelectList( new CrudeFinancialPaymentTypeRefServiceClient().FetchAll(),
                                "FinancialPaymentTypeRcd",
                                "FinancialPaymentTypeName",
                                contract.FinancialPaymentTypeRcd
                                );

            ViewBag.FinancialPaymentCardId =
                new SelectList( new CrudeFinancialPaymentCardServiceClient().FetchAll(),
                                "FinancialPaymentCardId",
                                "NameOnCard",
                                contract.FinancialPaymentCardId
                                );

            ViewBag.FinancialPaymentBankId =
                new SelectList( new CrudeFinancialPaymentBankServiceClient().FetchAll(),
                                "FinancialPaymentBankId",
                                "BankName",
                                contract.FinancialPaymentBankId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCreate([Bind()] CrudeFinancialPaymentContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeFinancialPaymentDelete(
            System.Guid financialPaymentId
            ) {
            new CrudeFinancialPaymentServiceClient().Delete(financialPaymentId);

            return RedirectToAction("CrudeFinancialPaymentIndex");
        }
    }
}
