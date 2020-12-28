﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:16:52 PM
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
    public class CrudeClientContactMethodController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeClientContactMethodIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodIndex.cshtml",
                new CrudeClientContactMethodServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeClientContactMethodByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodIndex.cshtml",
                new CrudeClientContactMethodServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeClientContactMethodDetails(System.Guid clientContactMethodId) {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodDetails.cshtml",
                new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeClientContactMethodEdit(
            System.Guid clientContactMethodId
            ) {

            CrudeClientContactMethodContract contract = new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ContactMethodRcd =
                new SelectList( new CrudeContactMethodRefServiceClient().FetchAll(),
                                "ContactMethodRcd",
                                "ContactMethodName",
                                contract.ContactMethodRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodEdit([Bind()] CrudeClientContactMethodContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientContactMethodServiceClient().Update(contract);

                return RedirectToAction("CrudeClientContactMethodIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeClientContactMethodCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientContactMethodContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ContactMethodRcd =
                new SelectList( new CrudeContactMethodRefServiceClient().FetchAll(),
                                "ContactMethodRcd",
                                "ContactMethodName",
                                contract.ContactMethodRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodCreate([Bind()] CrudeClientContactMethodContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientContactMethodServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientContactMethodIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeClientContactMethodDelete(
            System.Guid clientContactMethodId
            ) {
            new CrudeClientContactMethodServiceClient().Delete(clientContactMethodId);

            return RedirectToAction("CrudeClientContactMethodIndex");
        }
    }
}