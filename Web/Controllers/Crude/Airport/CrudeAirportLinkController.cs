﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:16:29 PM
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
    public class CrudeAirportLinkController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeAirportLinkIndex() {

            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkIndex.cshtml",
                new CrudeAirportLinkServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirportLinkByAirportIndex(System.Guid airportId) {
            ViewBag.AirportId = airportId;

            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkIndex.cshtml",
                new CrudeAirportLinkServiceClient().FetchByAirportId(airportId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeAirportLinkDetails(System.Guid airportLinkId) {

            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkDetails.cshtml",
                new CrudeAirportLinkServiceClient().FetchByAirportLinkId(airportLinkId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeAirportLinkEdit(
            System.Guid airportLinkId
            ) {

            CrudeAirportLinkContract contract = new CrudeAirportLinkServiceClient().FetchByAirportLinkId(airportLinkId);
            ViewBag.AirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.AirportId
                                );

            ViewBag.LinkTypeRcd =
                new SelectList( new CrudeLinkTypeRefServiceClient().FetchAll(),
                                "LinkTypeRcd",
                                "LinkTypeName",
                                contract.LinkTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirportLinkEdit([Bind()] CrudeAirportLinkContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeAirportLinkServiceClient().Update(contract);

                return RedirectToAction("CrudeAirportLinkIndex");
            }

            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeAirportLinkCreate(System.Guid? airportId, System.Guid? userId) {
            var contract = new CrudeAirportLinkContract();
            if (airportId != null) contract.AirportId = (System.Guid) airportId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.AirportId
                                );

            ViewBag.LinkTypeRcd =
                new SelectList( new CrudeLinkTypeRefServiceClient().FetchAll(),
                                "LinkTypeRcd",
                                "LinkTypeName",
                                contract.LinkTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirportLinkCreate([Bind()] CrudeAirportLinkContract contract) {
            if (ModelState.IsValid) {

                new CrudeAirportLinkServiceClient().Insert(contract);

                return RedirectToAction("CrudeAirportLinkIndex");
            }

            return View(
                "~/Views/Crude/Airport/CrudeAirportLink/CrudeAirportLinkCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeAirportLinkDelete(
            System.Guid airportLinkId
            ) {
            new CrudeAirportLinkServiceClient().Delete(airportLinkId);

            return RedirectToAction("CrudeAirportLinkIndex");
        }
    }
}