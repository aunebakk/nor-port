/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 7:57:51 AM
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
    public class CrudeDefaultUserController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeDefaultUserIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserIndex.cshtml",
                new CrudeDefaultUserServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeDefaultUserByCreatedByDefaultUserIndex(System.Guid createdByDefaultUserId) {
            ViewBag.CreatedByDefaultUserId = createdByDefaultUserId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserIndex.cshtml",
                new CrudeDefaultUserServiceClient().FetchByCreatedByDefaultUserId(createdByDefaultUserId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeDefaultUserDetails(System.Guid defaultUserId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserDetails.cshtml",
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeDefaultUserEdit(
            System.Guid defaultUserId
            ) {

            CrudeDefaultUserContract contract = new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId);
            ViewBag.DefaultStateRcd =
                new SelectList( new CrudeDefaultStateRefServiceClient().FetchAll(),
                                "DefaultStateRcd",
                                "DefaultStateName",
                                contract.DefaultStateRcd
                                );

            ViewBag.CreatedByDefaultUserId =
                new SelectList( new CrudeDefaultUserServiceClient().FetchAll(),
                                "DefaultUserId",
                                "DefaultUserName",
                                contract.CreatedByDefaultUserId
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserEdit([Bind()] CrudeDefaultUserContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultUserServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultUserIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeDefaultUserCreate(System.Guid? createdByDefaultUserId) {
            var contract = new CrudeDefaultUserContract();
            if (createdByDefaultUserId != null) contract.CreatedByDefaultUserId = (System.Guid) createdByDefaultUserId;

            ViewBag.DefaultStateRcd =
                new SelectList( new CrudeDefaultStateRefServiceClient().FetchAll(),
                                "DefaultStateRcd",
                                "DefaultStateName",
                                contract.DefaultStateRcd
                                );

            ViewBag.CreatedByDefaultUserId =
                new SelectList( new CrudeDefaultUserServiceClient().FetchAll(),
                                "DefaultUserId",
                                "DefaultUserName",
                                contract.CreatedByDefaultUserId
                                );

            contract.DateTime = DateTime.UtcNow;

            contract.LastActivityDateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserCreate([Bind()] CrudeDefaultUserContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultUserServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultUserIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUser/CrudeDefaultUserCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeDefaultUserDelete(
            System.Guid defaultUserId
            ) {
            new CrudeDefaultUserServiceClient().Delete(defaultUserId);

            return RedirectToAction("CrudeDefaultUserIndex");
        }
    }
}
