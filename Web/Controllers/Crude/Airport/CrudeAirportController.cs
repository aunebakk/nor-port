﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 4:52:05 PM
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
    public class CrudeAirportController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeAirportIndex() {

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportIndex.cshtml",
                new CrudeAirportServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirportByCityIndex(System.Guid cityId) {
            ViewBag.CityId = cityId;

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportIndex.cshtml",
                new CrudeAirportServiceClient().FetchByCityId(cityId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirportByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportIndex.cshtml",
                new CrudeAirportServiceClient().FetchByProductId(productId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirportByTimezoneIndex(System.Guid timezoneId) {
            ViewBag.TimezoneId = timezoneId;

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportIndex.cshtml",
                new CrudeAirportServiceClient().FetchByTimezoneId(timezoneId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeAirportDetails(System.Guid airportId) {

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportDetails.cshtml",
                new CrudeAirportServiceClient().FetchByAirportId(airportId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeAirportEdit(
            System.Guid airportId
            ) {

            CrudeAirportContract contract = new CrudeAirportServiceClient().FetchByAirportId(airportId);
            ViewBag.AirportTypeRcd =
                new SelectList( new CrudeAirportTypeRefServiceClient().FetchAll(),
                                "AirportTypeRcd",
                                "AirportTypeName",
                                contract.AirportTypeRcd
                                );

            ViewBag.CityId =
                new SelectList( new CrudeCityServiceClient().FetchAll(),
                                "CityId",
                                "CityName",
                                contract.CityId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.TimezoneId =
                new SelectList( new CrudeTimezoneServiceClient().FetchAll(),
                                "TimezoneId",
                                "TimezoneName",
                                contract.TimezoneId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirportEdit([Bind()] CrudeAirportContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeAirportServiceClient().Update(contract);

                return RedirectToAction("CrudeAirportIndex");
            }

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeAirportCreate(System.Guid? cityId, System.Guid? productId, System.Guid? timezoneId, System.Guid? userId) {
            var contract = new CrudeAirportContract();
            if (cityId != null) contract.CityId = (System.Guid) cityId;
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (timezoneId != null) contract.TimezoneId = (System.Guid) timezoneId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirportTypeRcd =
                new SelectList( new CrudeAirportTypeRefServiceClient().FetchAll(),
                                "AirportTypeRcd",
                                "AirportTypeName",
                                contract.AirportTypeRcd
                                );

            ViewBag.CityId =
                new SelectList( new CrudeCityServiceClient().FetchAll(),
                                "CityId",
                                "CityName",
                                contract.CityId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.TimezoneId =
                new SelectList( new CrudeTimezoneServiceClient().FetchAll(),
                                "TimezoneId",
                                "TimezoneName",
                                contract.TimezoneId
                                );

            contract.ActivationDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirportCreate([Bind()] CrudeAirportContract contract) {
            if (ModelState.IsValid) {

                new CrudeAirportServiceClient().Insert(contract);

                return RedirectToAction("CrudeAirportIndex");
            }

            return View(
                "~/Views/Crude/Airport/CrudeAirport/CrudeAirportCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeAirportDelete(
            System.Guid airportId
            ) {
            new CrudeAirportServiceClient().Delete(airportId);

            return RedirectToAction("CrudeAirportIndex");
        }
    }
}
