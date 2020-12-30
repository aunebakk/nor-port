/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:29:54 PM
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
    // Airline Controller
    // Airline Controller
    // the Airline Controller contains pages for adding, editing and listing Airline's
    // Airline Controller
    // the Airline Controller contains pages for adding, editing and listing Airline's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AirlineController : Controller {

        // Index page
        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AirlineIndex() {

            return View(
                "~/Views/Templates/Airline/Airline/AirlineIndex.cshtml",
                new AirlineSearchService().GetAirlineIndexWithFilter()
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
        public ActionResult AirlineEdit(
            System.Guid airlineId
            ) {

            ViewBag.AirlineId = airlineId;

            var airlineContract = new AirlineContract();

            airlineContract.Airline =
                new CrudeAirlineServiceClient().FetchByAirlineId(airlineId);

            airlineContract.AirlineContactMethod =
                new CrudeAirlineContactMethodServiceClient().FetchByAirlineId(airlineId);

            ViewBag.AirlineTypeRcd =
                new SelectList( new CrudeAirlineTypeRefServiceClient().FetchAll(),
                                "AirlineTypeRcd",
                                "AirlineTypeName",
                                airlineContract.Airline.AirlineTypeRcd
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                airlineContract.Airline.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airlineContract.Airline.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Airline/Airline/AirlineEdit.cshtml",
                airlineContract
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
        public ActionResult AirlineEdit([Bind()] AirlineContract airlineContract, System.String airlineTypeRcd,System.Guid productId) {
            if (ModelState.IsValid) {

                airlineContract.Airline.AirlineTypeRcd = airlineTypeRcd;
                airlineContract.Airline.ProductId = productId;
                airlineContract.Airline.DateTime = DateTime.UtcNow;

                new CrudeAirlineServiceClient().Update(airlineContract.Airline);

                return RedirectToAction("AirlineIndex");
            }

            return View(
                "~/Views/Templates/Airline/Airline/AirlineEdit.cshtml",
                airlineContract
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
        public ActionResult AirlineCreate(System.Guid? addressId, System.Guid? productId, System.Guid? userId) {
            var airlineContract = new AirlineContract();
            airlineContract.Airline = new CrudeAirlineContract();
            if (addressId != null) airlineContract.Airline.AddressId = (System.Guid) addressId;
            if (productId != null) airlineContract.Airline.ProductId = (System.Guid) productId;
            if (userId != null) airlineContract.Airline.UserId = (System.Guid) userId;

            ViewBag.AirlineTypeRcd =
                new SelectList( new CrudeAirlineTypeRefServiceClient().FetchAll(),
                                "AirlineTypeRcd",
                                "AirlineTypeName",
                                airlineContract.Airline.AirlineTypeRcd
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                airlineContract.Airline.ProductId
                                );

            if (userId == null)
                airlineContract.Airline.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airlineContract.Airline.UserId).DefaultUserName;

            airlineContract.Airline.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Airline/Airline/AirlineCreate.cshtml",
                airlineContract
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
        public ActionResult AirlineCreate([Bind()] AirlineContract airlineContract, System.String airlineTypeRcd,System.Guid productId) {
            if (ModelState.IsValid) {

                airlineContract.Airline.AirlineTypeRcd = airlineTypeRcd;
                airlineContract.Airline.ProductId = productId;
                new CrudeAirlineServiceClient().Insert(airlineContract.Airline);

                return RedirectToAction("AirlineIndex");
            }

            return View(
                "~/Views/Templates/Airline/Airline/AirlineCreate.cshtml",
                airlineContract
                );
        }

        // Remove page GET
        // Remove page GET
        // Remove page GET deletes a child component
        // Remove page GET
        // Remove page GET deletes a child component
        // links:
        //  docLink: http://sql2x.org/documentationLink/218668ec-89e2-445f-8f74-da5dc8067c78
        [HttpGet]
        public ActionResult AirlineRemoveAirlineContactMethod(
            System.Guid airlineContactMethodId ,
            System.Guid airlineId
            ) {
            new CrudeAirlineContactMethodServiceClient().Delete(airlineContactMethodId);

            return RedirectToAction(
                "AirlineEdit",
                "Airline",
                new { airlineId = airlineId }
                );
        }
    }
}
