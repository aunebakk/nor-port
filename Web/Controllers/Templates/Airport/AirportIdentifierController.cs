/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:17 PM
  From Machine: DESKTOP-LSRVP12
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
    // AirportIdentifier Controller
    // the AirportIdentifier Controller contains pages for adding, editing and listing AirportIdentifier's
    // links:
    //  client controller layer: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AirportIdentifierController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  Adding a view: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-view
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AirportIdentifierIndex() {

            return View(
                "~/Views/Templates/Airport/AirportIdentifier/AirportIdentifierIndex.cshtml",
                new AirportSearchService().AirportIdentifierIndexWithFilter()
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AirportIdentifierEdit(
            System.Guid airportIdentifierId
            ) {

            ViewBag.AirportIdentifierId = airportIdentifierId;

            var airportIdentifierContract = new AirportIdentifierContract();

            airportIdentifierContract.AirportIdentifier =
                new CrudeAirportIdentifierServiceClient().FetchByAirportIdentifierId(airportIdentifierId);

            ViewBag.AirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                airportIdentifierContract.AirportIdentifier.AirportId
                                );

            ViewBag.AirportIdentifierTypeRcd =
                new SelectList( new CrudeAirportIdentifierTypeRefServiceClient().FetchAll(),
                                "AirportIdentifierTypeRcd",
                                "AirportIdentifierTypeName",
                                airportIdentifierContract.AirportIdentifier.AirportIdentifierTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airportIdentifierContract.AirportIdentifier.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Airport/AirportIdentifier/AirportIdentifierEdit.cshtml",
                airportIdentifierContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportIdentifierEdit([Bind()] AirportIdentifierContract airportIdentifierContract, System.Guid airportId,System.String airportIdentifierTypeRcd) {
            if (ModelState.IsValid) {

                airportIdentifierContract.AirportIdentifier.AirportId = airportId;
                airportIdentifierContract.AirportIdentifier.AirportIdentifierTypeRcd = airportIdentifierTypeRcd;
                airportIdentifierContract.AirportIdentifier.DateTime = DateTime.UtcNow;

                new CrudeAirportIdentifierServiceClient().Update(airportIdentifierContract.AirportIdentifier);

                return RedirectToAction("AirportIdentifierIndex", new { airportId = airportIdentifierContract.AirportIdentifier.AirportId} );
            }

            return View(
                "~/Views/Templates/Airport/AirportIdentifier/AirportIdentifierEdit.cshtml",
                airportIdentifierContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AirportIdentifierCreate(System.Guid? airportId, System.Guid? userId) {
            var airportIdentifierContract = new AirportIdentifierContract();
            airportIdentifierContract.AirportIdentifier = new CrudeAirportIdentifierContract();
            if (airportId != null) airportIdentifierContract.AirportIdentifier.AirportId = (System.Guid) airportId;
            if (userId != null) airportIdentifierContract.AirportIdentifier.UserId = (System.Guid) userId;

            ViewBag.AirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                airportIdentifierContract.AirportIdentifier.AirportId
                                );

            ViewBag.AirportIdentifierTypeRcd =
                new SelectList( new CrudeAirportIdentifierTypeRefServiceClient().FetchAll(),
                                "AirportIdentifierTypeRcd",
                                "AirportIdentifierTypeName",
                                airportIdentifierContract.AirportIdentifier.AirportIdentifierTypeRcd
                                );

            if (userId == null)
                airportIdentifierContract.AirportIdentifier.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airportIdentifierContract.AirportIdentifier.UserId).DefaultUserName;

            airportIdentifierContract.AirportIdentifier.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Airport/AirportIdentifier/AirportIdentifierCreate.cshtml",
                airportIdentifierContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportIdentifierCreate([Bind()] AirportIdentifierContract airportIdentifierContract, System.Guid airportId,System.String airportIdentifierTypeRcd) {
            if (ModelState.IsValid) {

                airportIdentifierContract.AirportIdentifier.AirportId = airportId;
                airportIdentifierContract.AirportIdentifier.AirportIdentifierTypeRcd = airportIdentifierTypeRcd;
                new CrudeAirportIdentifierServiceClient().Insert(airportIdentifierContract.AirportIdentifier);

                return RedirectToAction("AirportIdentifierIndex", new { airportId = airportIdentifierContract.AirportIdentifier.AirportId} );
            }

            return View(
                "~/Views/Templates/Airport/AirportIdentifier/AirportIdentifierCreate.cshtml",
                airportIdentifierContract
                );
        }

    }
}
