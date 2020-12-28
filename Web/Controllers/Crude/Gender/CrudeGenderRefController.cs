/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:09:54 AM
  From Machine: DESKTOP-BP3OHLH
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
    public class CrudeGenderRefController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeGenderRefIndex() {

            return View(
                "~/Views/Crude/Gender/CrudeGenderRef/CrudeGenderRefIndex.cshtml",
                new CrudeGenderRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeGenderRefDetails(System.String genderRcd) {

            return View(
                "~/Views/Crude/Gender/CrudeGenderRef/CrudeGenderRefDetails.cshtml",
                new CrudeGenderRefServiceClient().FetchByGenderRcd(genderRcd)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeGenderRefEdit(
            System.String genderRcd
            ) {

            CrudeGenderRefContract contract = new CrudeGenderRefServiceClient().FetchByGenderRcd(genderRcd);

            return View(
                "~/Views/Crude/Gender/CrudeGenderRef/CrudeGenderRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeGenderRefEdit([Bind()] CrudeGenderRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeGenderRefServiceClient().Update(contract);

                return RedirectToAction("CrudeGenderRefIndex");
            }

            return View(
                "~/Views/Crude/Gender/CrudeGenderRef/CrudeGenderRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeGenderRefCreate(System.Guid? userId) {
            var contract = new CrudeGenderRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Gender/CrudeGenderRef/CrudeGenderRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeGenderRefCreate([Bind()] CrudeGenderRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeGenderRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeGenderRefIndex");
            }

            return View(
                "~/Views/Crude/Gender/CrudeGenderRef/CrudeGenderRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeGenderRefDelete(
            System.String genderRcd
            ) {
            new CrudeGenderRefServiceClient().Delete(genderRcd);

            return RedirectToAction("CrudeGenderRefIndex");
        }
    }
}
