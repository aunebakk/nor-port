/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:51:00 AM
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
    // AircraftDocument Controller
    // the AircraftDocument Controller contains pages for adding, editing and listing AircraftDocument's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AircraftDocumentController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AircraftDocumentIndex(System.Guid aircraftId) {
            ViewBag.AircraftId = aircraftId;

            return View(
                "~/Views/Templates/Aircraft/AircraftDocument/AircraftDocumentIndex.cshtml",
                new AircraftSearchService().AircraftDocumentIndexWithFilter(aircraftId)
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AircraftDocumentEdit(
            System.Guid aircraftDocumentId
            ) {

            ViewBag.AircraftDocumentId = aircraftDocumentId;

            var aircraftDocumentContract = new AircraftDocumentContract();

            aircraftDocumentContract.AircraftDocument =
                new CrudeAircraftDocumentServiceClient().FetchByAircraftDocumentId(aircraftDocumentId);

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                aircraftDocumentContract.AircraftDocument.AircraftId
                                );

            ViewBag.AircraftDocumentTypeRcd =
                new SelectList( new CrudeAircraftDocumentTypeRefServiceClient().FetchAll(),
                                "AircraftDocumentTypeRcd",
                                "AircraftDocumentTypeName",
                                aircraftDocumentContract.AircraftDocument.AircraftDocumentTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftDocumentContract.AircraftDocument.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Aircraft/AircraftDocument/AircraftDocumentEdit.cshtml",
                aircraftDocumentContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftDocumentEdit([Bind()] AircraftDocumentContract aircraftDocumentContract, System.Guid aircraftId,System.String aircraftDocumentTypeRcd) {
            if (ModelState.IsValid) {

                aircraftDocumentContract.AircraftDocument.AircraftId = aircraftId;
                aircraftDocumentContract.AircraftDocument.AircraftDocumentTypeRcd = aircraftDocumentTypeRcd;
                aircraftDocumentContract.AircraftDocument.DateTime = DateTime.UtcNow;

                new CrudeAircraftDocumentServiceClient().Update(aircraftDocumentContract.AircraftDocument);

                return RedirectToAction("AircraftDocumentIndex", new { aircraftId = aircraftDocumentContract.AircraftDocument.AircraftId} );
            }

            return View(
                "~/Views/Templates/Aircraft/AircraftDocument/AircraftDocumentEdit.cshtml",
                aircraftDocumentContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AircraftDocumentCreate(System.Guid? aircraftId, System.Guid? userId) {
            var aircraftDocumentContract = new AircraftDocumentContract();
            aircraftDocumentContract.AircraftDocument = new CrudeAircraftDocumentContract();
            if (aircraftId != null) aircraftDocumentContract.AircraftDocument.AircraftId = (System.Guid) aircraftId;
            if (userId != null) aircraftDocumentContract.AircraftDocument.UserId = (System.Guid) userId;

            ViewBag.AircraftId =
                new SelectList( new CrudeAircraftServiceClient().FetchAll(),
                                "AircraftId",
                                "AircraftName",
                                aircraftDocumentContract.AircraftDocument.AircraftId
                                );

            ViewBag.AircraftDocumentTypeRcd =
                new SelectList( new CrudeAircraftDocumentTypeRefServiceClient().FetchAll(),
                                "AircraftDocumentTypeRcd",
                                "AircraftDocumentTypeName",
                                aircraftDocumentContract.AircraftDocument.AircraftDocumentTypeRcd
                                );

            aircraftDocumentContract.AircraftDocument.DocumentDateTime = DateTime.UtcNow;

            aircraftDocumentContract.AircraftDocument.ExpiryDateTime = DateTime.UtcNow;

            if (userId == null)
                aircraftDocumentContract.AircraftDocument.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftDocumentContract.AircraftDocument.UserId).DefaultUserName;

            aircraftDocumentContract.AircraftDocument.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Aircraft/AircraftDocument/AircraftDocumentCreate.cshtml",
                aircraftDocumentContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftDocumentCreate([Bind()] AircraftDocumentContract aircraftDocumentContract, System.Guid aircraftId,System.String aircraftDocumentTypeRcd) {
            if (ModelState.IsValid) {

                aircraftDocumentContract.AircraftDocument.AircraftId = aircraftId;
                aircraftDocumentContract.AircraftDocument.AircraftDocumentTypeRcd = aircraftDocumentTypeRcd;
                new CrudeAircraftDocumentServiceClient().Insert(aircraftDocumentContract.AircraftDocument);

                return RedirectToAction("AircraftDocumentIndex", new { aircraftId = aircraftDocumentContract.AircraftDocument.AircraftId} );
            }

            return View(
                "~/Views/Templates/Aircraft/AircraftDocument/AircraftDocumentCreate.cshtml",
                aircraftDocumentContract
                );
        }

    }
}
