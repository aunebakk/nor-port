/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:12:16 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client ASP Controller
// the Client ASP Controller Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client controller layer: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
//  docLink: http://sql2x.org/documentationLink/4fbcc19b-c130-4190-b31b-e28bc3aaf29f
namespace SolutionNorSolutionPort.AspMvc.Controllers {
    // AircraftIdentifier Controller
    // the AircraftIdentifier Controller contains pages for adding, editing and listing AircraftIdentifier's
    // links:
    //  client controller layer: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AircraftIdentifierController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  Adding a view: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-view
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AircraftIdentifierIndex(System.Guid aircraftId) {
            ViewBag.AircraftId = aircraftId;

            return View(
                "~/Views/Templates/Aircraft/AircraftIdentifier/AircraftIdentifierIndex.cshtml",
                new AircraftSearchService().AircraftIdentifierIndexWithFilter(aircraftId)
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AircraftIdentifierEdit(
            System.Guid aircraftIdentifierId
            ) {

            ViewBag.AircraftIdentifierId = aircraftIdentifierId;

            var aircraftIdentifierContract = new AircraftIdentifierContract();

            aircraftIdentifierContract.AircraftIdentifier =
                new CrudeAircraftIdentifierServiceClient().FetchByAircraftIdentifierId(aircraftIdentifierId);

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                aircraftIdentifierContract.AircraftIdentifier.AircraftId
                                );

            ViewBag.AircraftIdentifierTypeRcd =
                new SelectList( new CrudeAircraftIdentifierTypeRefServiceClient().FetchAll(),
                                "AircraftIdentifierTypeRcd",
                                "AircraftIdentifierTypeName",
                                aircraftIdentifierContract.AircraftIdentifier.AircraftIdentifierTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftIdentifierContract.AircraftIdentifier.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Aircraft/AircraftIdentifier/AircraftIdentifierEdit.cshtml",
                aircraftIdentifierContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftIdentifierEdit([Bind()] AircraftIdentifierContract aircraftIdentifierContract, System.Guid aircraftId,System.String aircraftIdentifierTypeRcd) {
            if (ModelState.IsValid) {

                aircraftIdentifierContract.AircraftIdentifier.AircraftId = aircraftId;
                aircraftIdentifierContract.AircraftIdentifier.AircraftIdentifierTypeRcd = aircraftIdentifierTypeRcd;
                aircraftIdentifierContract.AircraftIdentifier.DateTime = DateTime.UtcNow;

                new CrudeAircraftIdentifierServiceClient().Update(aircraftIdentifierContract.AircraftIdentifier);

                return RedirectToAction("AircraftIdentifierIndex", new { aircraftId = aircraftIdentifierContract.AircraftIdentifier.AircraftId} );
            }

            return View(
                "~/Views/Templates/Aircraft/AircraftIdentifier/AircraftIdentifierEdit.cshtml",
                aircraftIdentifierContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AircraftIdentifierCreate(System.Guid? aircraftId, System.Guid? userId) {
            var aircraftIdentifierContract = new AircraftIdentifierContract();
            aircraftIdentifierContract.AircraftIdentifier = new CrudeAircraftIdentifierContract();
            if (aircraftId != null) aircraftIdentifierContract.AircraftIdentifier.AircraftId = (System.Guid) aircraftId;
            if (userId != null) aircraftIdentifierContract.AircraftIdentifier.UserId = (System.Guid) userId;

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                aircraftIdentifierContract.AircraftIdentifier.AircraftId
                                );

            ViewBag.AircraftIdentifierTypeRcd =
                new SelectList( new CrudeAircraftIdentifierTypeRefServiceClient().FetchAll(),
                                "AircraftIdentifierTypeRcd",
                                "AircraftIdentifierTypeName",
                                aircraftIdentifierContract.AircraftIdentifier.AircraftIdentifierTypeRcd
                                );

            if (userId == null)
                aircraftIdentifierContract.AircraftIdentifier.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftIdentifierContract.AircraftIdentifier.UserId).DefaultUserName;

            aircraftIdentifierContract.AircraftIdentifier.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Aircraft/AircraftIdentifier/AircraftIdentifierCreate.cshtml",
                aircraftIdentifierContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftIdentifierCreate([Bind()] AircraftIdentifierContract aircraftIdentifierContract, System.Guid aircraftId,System.String aircraftIdentifierTypeRcd) {
            if (ModelState.IsValid) {

                aircraftIdentifierContract.AircraftIdentifier.AircraftId = aircraftId;
                aircraftIdentifierContract.AircraftIdentifier.AircraftIdentifierTypeRcd = aircraftIdentifierTypeRcd;
                new CrudeAircraftIdentifierServiceClient().Insert(aircraftIdentifierContract.AircraftIdentifier);

                return RedirectToAction("AircraftIdentifierIndex", new { aircraftId = aircraftIdentifierContract.AircraftIdentifier.AircraftId} );
            }

            return View(
                "~/Views/Templates/Aircraft/AircraftIdentifier/AircraftIdentifierCreate.cshtml",
                aircraftIdentifierContract
                );
        }

    }
}
