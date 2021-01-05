﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 12:50:11 PM
  From Machine: DESKTOP-LSRVP12
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
    public class CrudeFinancialHotelBookingController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingIndex.cshtml",
                new CrudeFinancialHotelBookingServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingByServiceHotelIndex(System.Guid serviceHotelId) {
            ViewBag.ServiceHotelId = serviceHotelId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingIndex.cshtml",
                new CrudeFinancialHotelBookingServiceClient().FetchByServiceHotelId(serviceHotelId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingIndex.cshtml",
                new CrudeFinancialHotelBookingServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingDetails(System.Guid financialHotelBookingId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingDetails.cshtml",
                new CrudeFinancialHotelBookingServiceClient().FetchByFinancialHotelBookingId(financialHotelBookingId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingEdit(
            System.Guid financialHotelBookingId
            ) {

            CrudeFinancialHotelBookingContract contract = new CrudeFinancialHotelBookingServiceClient().FetchByFinancialHotelBookingId(financialHotelBookingId);
            ViewBag.ServiceHotelId =
                new SelectList( new CrudeServiceHotelServiceClient().FetchAll(),
                                "ServiceHotelId",
                                "HotelName",
                                contract.ServiceHotelId
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialHotelBookingEdit([Bind()] CrudeFinancialHotelBookingContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialHotelBookingServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialHotelBookingIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingCreate(System.Guid? serviceHotelId, System.Guid? financialCurrencyId, System.Guid? userId) {
            var contract = new CrudeFinancialHotelBookingContract();
            if (serviceHotelId != null) contract.ServiceHotelId = (System.Guid) serviceHotelId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ServiceHotelId =
                new SelectList( new CrudeServiceHotelServiceClient().FetchAll(),
                                "ServiceHotelId",
                                "HotelName",
                                contract.ServiceHotelId
                                );

            contract.FromDateTime = DateTime.UtcNow;

            contract.UntilDateTime = DateTime.UtcNow;

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
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialHotelBookingCreate([Bind()] CrudeFinancialHotelBookingContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialHotelBookingServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialHotelBookingIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialHotelBooking/CrudeFinancialHotelBookingCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeFinancialHotelBookingDelete(
            System.Guid financialHotelBookingId
            ) {
            new CrudeFinancialHotelBookingServiceClient().Delete(financialHotelBookingId);

            return RedirectToAction("CrudeFinancialHotelBookingIndex");
        }
    }
}
