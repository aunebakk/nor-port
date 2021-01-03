/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:12:47 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client ASP Controller
// the Client ASP Controller Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/4fbcc19b-c130-4190-b31b-e28bc3aaf29f
namespace SolutionNorSolutionPort.AspMvc.Controllers {
    // AircraftCompartment Controller
    // the AircraftCompartment Controller contains pages for adding, editing and listing AircraftCompartment's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AircraftCompartmentController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AircraftCompartmentIndex(System.Guid aircraftId) {
            ViewBag.AircraftId = aircraftId;

            return View(
                "~/Views/Templates/Aircraft/AircraftCompartment/AircraftCompartmentIndex.cshtml",
                new AircraftSearchServiceClient().AircraftCompartmentIndexWithFilter(aircraftId)
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AircraftCompartmentEdit(
            System.Guid aircraftCompartmentId
            ) {

            ViewBag.AircraftCompartmentId = aircraftCompartmentId;

            var aircraftCompartmentContract = new AircraftCompartmentContract();

            aircraftCompartmentContract.AircraftCompartment =
                new CrudeAircraftCompartmentServiceClient().FetchByAircraftCompartmentId(aircraftCompartmentId);

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                aircraftCompartmentContract.AircraftCompartment.AircraftId
                                );

            ViewBag.AircraftCompartmentTypeRcd =
                new SelectList( new CrudeAircraftCompartmentTypeRefServiceClient().FetchAll(),
                                "AircraftCompartmentTypeRcd",
                                "AircraftCompartmentTypeName",
                                aircraftCompartmentContract.AircraftCompartment.AircraftCompartmentTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftCompartmentContract.AircraftCompartment.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Aircraft/AircraftCompartment/AircraftCompartmentEdit.cshtml",
                aircraftCompartmentContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftCompartmentEdit([Bind()] AircraftCompartmentContract aircraftCompartmentContract, System.Guid aircraftId,System.String aircraftCompartmentTypeRcd) {
            if (ModelState.IsValid) {

                aircraftCompartmentContract.AircraftCompartment.AircraftId = aircraftId;
                aircraftCompartmentContract.AircraftCompartment.AircraftCompartmentTypeRcd = aircraftCompartmentTypeRcd;
                aircraftCompartmentContract.AircraftCompartment.DateTime = DateTime.UtcNow;

                new CrudeAircraftCompartmentServiceClient().Update(aircraftCompartmentContract.AircraftCompartment);

                return RedirectToAction("AircraftCompartmentIndex", new { aircraftId = aircraftCompartmentContract.AircraftCompartment.AircraftId} );
            }

            return View(
                "~/Views/Templates/Aircraft/AircraftCompartment/AircraftCompartmentEdit.cshtml",
                aircraftCompartmentContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AircraftCompartmentCreate(System.Guid? aircraftId, System.Guid? aircraftCompartmentMeasurementId, System.Guid? userId) {
            var aircraftCompartmentContract = new AircraftCompartmentContract();
            aircraftCompartmentContract.AircraftCompartment = new CrudeAircraftCompartmentContract();
            if (aircraftId != null) aircraftCompartmentContract.AircraftCompartment.AircraftId = (System.Guid) aircraftId;
            if (aircraftCompartmentMeasurementId != null) aircraftCompartmentContract.AircraftCompartment.AircraftCompartmentMeasurementId = (System.Guid) aircraftCompartmentMeasurementId;
            if (userId != null) aircraftCompartmentContract.AircraftCompartment.UserId = (System.Guid) userId;

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                aircraftCompartmentContract.AircraftCompartment.AircraftId
                                );

            ViewBag.AircraftCompartmentTypeRcd =
                new SelectList( new CrudeAircraftCompartmentTypeRefServiceClient().FetchAll(),
                                "AircraftCompartmentTypeRcd",
                                "AircraftCompartmentTypeName",
                                aircraftCompartmentContract.AircraftCompartment.AircraftCompartmentTypeRcd
                                );

            if (userId == null)
                aircraftCompartmentContract.AircraftCompartment.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftCompartmentContract.AircraftCompartment.UserId).DefaultUserName;

            aircraftCompartmentContract.AircraftCompartment.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Aircraft/AircraftCompartment/AircraftCompartmentCreate.cshtml",
                aircraftCompartmentContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftCompartmentCreate([Bind()] AircraftCompartmentContract aircraftCompartmentContract, System.Guid aircraftId,System.String aircraftCompartmentTypeRcd) {
            if (ModelState.IsValid) {

                aircraftCompartmentContract.AircraftCompartment.AircraftId = aircraftId;
                aircraftCompartmentContract.AircraftCompartment.AircraftCompartmentTypeRcd = aircraftCompartmentTypeRcd;
                new CrudeAircraftCompartmentServiceClient().Insert(aircraftCompartmentContract.AircraftCompartment);

                return RedirectToAction("AircraftCompartmentIndex", new { aircraftId = aircraftCompartmentContract.AircraftCompartment.AircraftId} );
            }

            return View(
                "~/Views/Templates/Aircraft/AircraftCompartment/AircraftCompartmentCreate.cshtml",
                aircraftCompartmentContract
                );
        }

    }
}
