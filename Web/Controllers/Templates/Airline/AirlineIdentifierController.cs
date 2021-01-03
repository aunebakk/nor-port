/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 2:30:05 PM
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
    // AirlineIdentifier Controller
    // the AirlineIdentifier Controller contains pages for adding, editing and listing AirlineIdentifier's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AirlineIdentifierController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AirlineIdentifierIndex() {

            return View(
                "~/Views/Templates/Airline/AirlineIdentifier/AirlineIdentifierIndex.cshtml",
                new AirlineSearchServiceClient().AirlineIdentifierIndexWithFilter()
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AirlineIdentifierEdit(
            System.Guid airlineIdentifierId
            ) {

            ViewBag.AirlineIdentifierId = airlineIdentifierId;

            var airlineIdentifierContract = new AirlineIdentifierContract();

            airlineIdentifierContract.AirlineIdentifier =
                new CrudeAirlineIdentifierServiceClient().FetchByAirlineIdentifierId(airlineIdentifierId);

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                airlineIdentifierContract.AirlineIdentifier.AirlineId
                                );

            ViewBag.AirlineIdentifierTypeRcd =
                new SelectList( new CrudeAirlineIdentifierTypeRefServiceClient().FetchAll(),
                                "AirlineIdentifierTypeRcd",
                                "AirlineIdentifierTypeName",
                                airlineIdentifierContract.AirlineIdentifier.AirlineIdentifierTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airlineIdentifierContract.AirlineIdentifier.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Airline/AirlineIdentifier/AirlineIdentifierEdit.cshtml",
                airlineIdentifierContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirlineIdentifierEdit([Bind()] AirlineIdentifierContract airlineIdentifierContract, System.Guid airlineId,System.String airlineIdentifierTypeRcd) {
            if (ModelState.IsValid) {

                airlineIdentifierContract.AirlineIdentifier.AirlineId = airlineId;
                airlineIdentifierContract.AirlineIdentifier.AirlineIdentifierTypeRcd = airlineIdentifierTypeRcd;
                airlineIdentifierContract.AirlineIdentifier.DateTime = DateTime.UtcNow;

                new CrudeAirlineIdentifierServiceClient().Update(airlineIdentifierContract.AirlineIdentifier);

                return RedirectToAction("AirlineIdentifierIndex", new { airlineId = airlineIdentifierContract.AirlineIdentifier.AirlineId} );
            }

            return View(
                "~/Views/Templates/Airline/AirlineIdentifier/AirlineIdentifierEdit.cshtml",
                airlineIdentifierContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AirlineIdentifierCreate(System.Guid? airlineId, System.Guid? userId) {
            var airlineIdentifierContract = new AirlineIdentifierContract();
            airlineIdentifierContract.AirlineIdentifier = new CrudeAirlineIdentifierContract();
            if (airlineId != null) airlineIdentifierContract.AirlineIdentifier.AirlineId = (System.Guid) airlineId;
            if (userId != null) airlineIdentifierContract.AirlineIdentifier.UserId = (System.Guid) userId;

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                airlineIdentifierContract.AirlineIdentifier.AirlineId
                                );

            ViewBag.AirlineIdentifierTypeRcd =
                new SelectList( new CrudeAirlineIdentifierTypeRefServiceClient().FetchAll(),
                                "AirlineIdentifierTypeRcd",
                                "AirlineIdentifierTypeName",
                                airlineIdentifierContract.AirlineIdentifier.AirlineIdentifierTypeRcd
                                );

            if (userId == null)
                airlineIdentifierContract.AirlineIdentifier.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airlineIdentifierContract.AirlineIdentifier.UserId).DefaultUserName;

            airlineIdentifierContract.AirlineIdentifier.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Airline/AirlineIdentifier/AirlineIdentifierCreate.cshtml",
                airlineIdentifierContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirlineIdentifierCreate([Bind()] AirlineIdentifierContract airlineIdentifierContract, System.Guid airlineId,System.String airlineIdentifierTypeRcd) {
            if (ModelState.IsValid) {

                airlineIdentifierContract.AirlineIdentifier.AirlineId = airlineId;
                airlineIdentifierContract.AirlineIdentifier.AirlineIdentifierTypeRcd = airlineIdentifierTypeRcd;
                new CrudeAirlineIdentifierServiceClient().Insert(airlineIdentifierContract.AirlineIdentifier);

                return RedirectToAction("AirlineIdentifierIndex", new { airlineId = airlineIdentifierContract.AirlineIdentifier.AirlineId} );
            }

            return View(
                "~/Views/Templates/Airline/AirlineIdentifier/AirlineIdentifierCreate.cshtml",
                airlineIdentifierContract
                );
        }

    }
}
