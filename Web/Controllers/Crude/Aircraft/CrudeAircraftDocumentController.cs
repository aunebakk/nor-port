/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 2:31:30 AM
  From Machine: DESKTOP-517I8BU
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

    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeAircraftDocumentController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeAircraftDocumentIndex() {

            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentIndex.cshtml",
                new CrudeAircraftDocumentServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAircraftDocumentByAircraftIndex(System.Guid aircraftId) {
            ViewBag.AircraftId = aircraftId;

            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentIndex.cshtml",
                new CrudeAircraftDocumentServiceClient().FetchByAircraftId(aircraftId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeAircraftDocumentDetails(System.Guid aircraftDocumentId) {

            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentDetails.cshtml",
                new CrudeAircraftDocumentServiceClient().FetchByAircraftDocumentId(aircraftDocumentId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeAircraftDocumentEdit(
            System.Guid aircraftDocumentId
            ) {

            CrudeAircraftDocumentContract contract = new CrudeAircraftDocumentServiceClient().FetchByAircraftDocumentId(aircraftDocumentId);
            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                contract.AircraftId
                                );

            ViewBag.AircraftDocumentTypeRcd =
                new SelectList( new CrudeAircraftDocumentTypeRefServiceClient().FetchAll(),
                                "AircraftDocumentTypeRcd",
                                "AircraftDocumentTypeName",
                                contract.AircraftDocumentTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAircraftDocumentEdit([Bind()] CrudeAircraftDocumentContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeAircraftDocumentServiceClient().Update(contract);

                return RedirectToAction("CrudeAircraftDocumentIndex");
            }

            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeAircraftDocumentCreate(System.Guid? aircraftId, System.Guid? userId) {
            var contract = new CrudeAircraftDocumentContract();
            if (aircraftId != null) contract.AircraftId = (System.Guid) aircraftId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                contract.AircraftId
                                );

            ViewBag.AircraftDocumentTypeRcd =
                new SelectList( new CrudeAircraftDocumentTypeRefServiceClient().FetchAll(),
                                "AircraftDocumentTypeRcd",
                                "AircraftDocumentTypeName",
                                contract.AircraftDocumentTypeRcd
                                );

            contract.DocumentDateTime = DateTime.UtcNow;

            contract.ExpiryDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAircraftDocumentCreate([Bind()] CrudeAircraftDocumentContract contract) {
            if (ModelState.IsValid) {

                new CrudeAircraftDocumentServiceClient().Insert(contract);

                return RedirectToAction("CrudeAircraftDocumentIndex");
            }

            return View(
                "~/Views/Crude/Aircraft/CrudeAircraftDocument/CrudeAircraftDocumentCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeAircraftDocumentDelete(
            System.Guid aircraftDocumentId
            ) {
            new CrudeAircraftDocumentServiceClient().Delete(aircraftDocumentId);

            return RedirectToAction("CrudeAircraftDocumentIndex");
        }
    }
}
