/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:29:18 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client ASP Controller
// Client ASP Controller
// the Client ASP Controller Layer uses the Proxy Layer to tie into SOAP services
// Client ASP Controller
// the Client ASP Controller Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/4fbcc19b-c130-4190-b31b-e28bc3aaf29f
namespace SolutionNorSolutionPort.AspMvc.Controllers {
    // Aircraft Controller
    // Aircraft Controller
    // the Aircraft Controller contains pages for adding, editing and listing Aircraft's
    // Aircraft Controller
    // the Aircraft Controller contains pages for adding, editing and listing Aircraft's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AircraftController : Controller {

        // Index page
        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AircraftIndex() {

            return View(
                "~/Views/Templates/Aircraft/Aircraft/AircraftIndex.cshtml",
                new AircraftSearchService().AircraftIndexWithFilter()
                );
        }

        // Edit page GET
        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AircraftEdit(
            System.Guid aircraftId
            ) {

            ViewBag.AircraftId = aircraftId;

            var aircraftContract = new AircraftContract();

            aircraftContract.Aircraft =
                new CrudeAircraftServiceClient().FetchByAircraftId(aircraftId);

            ViewBag.AircraftTypeRcd =
                new SelectList( new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                aircraftContract.Aircraft.AircraftTypeRcd
                                );

            ViewBag.AircraftConfigurationRcd =
                new SelectList( new CrudeAircraftConfigurationRefServiceClient().FetchAll(),
                                "AircraftConfigurationRcd",
                                "AircraftConfigurationName",
                                aircraftContract.Aircraft.AircraftConfigurationRcd
                                );

            ViewBag.AircraftBodyRcd =
                new SelectList( new CrudeAircraftBodyRefServiceClient().FetchAll(),
                                "AircraftBodyRcd",
                                "AircraftBodyName",
                                aircraftContract.Aircraft.AircraftBodyRcd
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                aircraftContract.Aircraft.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftContract.Aircraft.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Aircraft/Aircraft/AircraftEdit.cshtml",
                aircraftContract
                );
        }

        // Edit page POST
        // Edit page POST
        // Edit page POST saves all displayable columns
        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftEdit([Bind()] AircraftContract aircraftContract, System.String aircraftTypeRcd,System.String aircraftConfigurationRcd,System.String aircraftBodyRcd,System.Guid productId) {
            if (ModelState.IsValid) {

                aircraftContract.Aircraft.AircraftTypeRcd = aircraftTypeRcd;
                aircraftContract.Aircraft.AircraftConfigurationRcd = aircraftConfigurationRcd;
                aircraftContract.Aircraft.AircraftBodyRcd = aircraftBodyRcd;
                aircraftContract.Aircraft.ProductId = productId;
                aircraftContract.Aircraft.DateTime = DateTime.UtcNow;

                new CrudeAircraftServiceClient().Update(aircraftContract.Aircraft);

                return RedirectToAction("AircraftIndex");
            }

            return View(
                "~/Views/Templates/Aircraft/Aircraft/AircraftEdit.cshtml",
                aircraftContract
                );
        }

        // Create page GET
        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AircraftCreate(System.Guid? aircraftMeasurementId, System.Guid? productId, System.Guid? userId) {
            var aircraftContract = new AircraftContract();
            aircraftContract.Aircraft = new CrudeAircraftContract();
            if (aircraftMeasurementId != null) aircraftContract.Aircraft.AircraftMeasurementId = (System.Guid) aircraftMeasurementId;
            if (productId != null) aircraftContract.Aircraft.ProductId = (System.Guid) productId;
            if (userId != null) aircraftContract.Aircraft.UserId = (System.Guid) userId;

            ViewBag.AircraftTypeRcd =
                new SelectList( new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                aircraftContract.Aircraft.AircraftTypeRcd
                                );

            ViewBag.AircraftConfigurationRcd =
                new SelectList( new CrudeAircraftConfigurationRefServiceClient().FetchAll(),
                                "AircraftConfigurationRcd",
                                "AircraftConfigurationName",
                                aircraftContract.Aircraft.AircraftConfigurationRcd
                                );

            ViewBag.AircraftBodyRcd =
                new SelectList( new CrudeAircraftBodyRefServiceClient().FetchAll(),
                                "AircraftBodyRcd",
                                "AircraftBodyName",
                                aircraftContract.Aircraft.AircraftBodyRcd
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                aircraftContract.Aircraft.ProductId
                                );

            aircraftContract.Aircraft.OperationalDateTime = DateTime.UtcNow;

            aircraftContract.Aircraft.FirstFlightDateTime = DateTime.UtcNow;

            if (userId == null)
                aircraftContract.Aircraft.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(aircraftContract.Aircraft.UserId).DefaultUserName;

            aircraftContract.Aircraft.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Aircraft/Aircraft/AircraftCreate.cshtml",
                aircraftContract
                );
        }

        // Create page POST
        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftCreate([Bind()] AircraftContract aircraftContract, System.String aircraftTypeRcd,System.String aircraftConfigurationRcd,System.String aircraftBodyRcd,System.Guid productId) {
            if (ModelState.IsValid) {

                aircraftContract.Aircraft.AircraftTypeRcd = aircraftTypeRcd;
                aircraftContract.Aircraft.AircraftConfigurationRcd = aircraftConfigurationRcd;
                aircraftContract.Aircraft.AircraftBodyRcd = aircraftBodyRcd;
                aircraftContract.Aircraft.ProductId = productId;
                new CrudeAircraftServiceClient().Insert(aircraftContract.Aircraft);

                return RedirectToAction("AircraftIndex");
            }

            return View(
                "~/Views/Templates/Aircraft/Aircraft/AircraftCreate.cshtml",
                aircraftContract
                );
        }

    }
}
