/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 6:55:22 PM
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
    public class CrudeServiceSpecialServiceRequestGroupRefController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefIndex() {

            return View(
                "~/Views/Crude/Service/CrudeServiceSpecialServiceRequestGroupRef/CrudeServiceSpecialServiceRequestGroupRefIndex.cshtml",
                new CrudeServiceSpecialServiceRequestGroupRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefDetails(System.String serviceSpecialServiceRequestGroupRcd) {

            return View(
                "~/Views/Crude/Service/CrudeServiceSpecialServiceRequestGroupRef/CrudeServiceSpecialServiceRequestGroupRefDetails.cshtml",
                new CrudeServiceSpecialServiceRequestGroupRefServiceClient().FetchByServiceSpecialServiceRequestGroupRcd(serviceSpecialServiceRequestGroupRcd)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefEdit(
            System.String serviceSpecialServiceRequestGroupRcd
            ) {

            CrudeServiceSpecialServiceRequestGroupRefContract contract = new CrudeServiceSpecialServiceRequestGroupRefServiceClient().FetchByServiceSpecialServiceRequestGroupRcd(serviceSpecialServiceRequestGroupRcd);

            return View(
                "~/Views/Crude/Service/CrudeServiceSpecialServiceRequestGroupRef/CrudeServiceSpecialServiceRequestGroupRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefEdit([Bind()] CrudeServiceSpecialServiceRequestGroupRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeServiceSpecialServiceRequestGroupRefServiceClient().Update(contract);

                return RedirectToAction("CrudeServiceSpecialServiceRequestGroupRefIndex");
            }

            return View(
                "~/Views/Crude/Service/CrudeServiceSpecialServiceRequestGroupRef/CrudeServiceSpecialServiceRequestGroupRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefCreate(System.Guid? userId) {
            var contract = new CrudeServiceSpecialServiceRequestGroupRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Service/CrudeServiceSpecialServiceRequestGroupRef/CrudeServiceSpecialServiceRequestGroupRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefCreate([Bind()] CrudeServiceSpecialServiceRequestGroupRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeServiceSpecialServiceRequestGroupRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeServiceSpecialServiceRequestGroupRefIndex");
            }

            return View(
                "~/Views/Crude/Service/CrudeServiceSpecialServiceRequestGroupRef/CrudeServiceSpecialServiceRequestGroupRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeServiceSpecialServiceRequestGroupRefDelete(
            System.String serviceSpecialServiceRequestGroupRcd
            ) {
            new CrudeServiceSpecialServiceRequestGroupRefServiceClient().Delete(serviceSpecialServiceRequestGroupRcd);

            return RedirectToAction("CrudeServiceSpecialServiceRequestGroupRefIndex");
        }
    }
}
