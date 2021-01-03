/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:13:40 PM
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
    // Airport Controller
    // the Airport Controller contains pages for adding, editing and listing Airport's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class AirportController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult AirportIndex() {

            return View(
                "~/Views/Templates/Airport/Airport/AirportIndex.cshtml",
                new AirportSearchServiceClient().GetAirportIndexWithFilter()
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult AirportEdit(
            System.Guid airportId
            ) {

            ViewBag.AirportId = airportId;

            var airportContract = new AirportContract();

            airportContract.Airport =
                new CrudeAirportServiceClient().FetchByAirportId(airportId);

            ViewBag.AirportTypeRcd =
                new SelectList( new CrudeAirportTypeRefServiceClient().FetchAll(),
                                "AirportTypeRcd",
                                "AirportTypeName",
                                airportContract.Airport.AirportTypeRcd
                                );

            ViewBag.CityId =
                new SelectList( new CrudeCityServiceClient().FetchAll(),
                                "CityId",
                                "CityName",
                                airportContract.Airport.CityId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                airportContract.Airport.ProductId
                                );

            ViewBag.TimezoneId =
                new SelectList( new CrudeTimezoneServiceClient().FetchAll(),
                                "TimezoneId",
                                "TimezoneName",
                                airportContract.Airport.TimezoneId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airportContract.Airport.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/Airport/Airport/AirportEdit.cshtml",
                airportContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportEdit([Bind()] AirportContract airportContract, System.String airportTypeRcd,System.Guid cityId,System.Guid productId,System.Guid timezoneId) {
            if (ModelState.IsValid) {

                airportContract.Airport.AirportTypeRcd = airportTypeRcd;
                airportContract.Airport.CityId = cityId;
                airportContract.Airport.ProductId = productId;
                airportContract.Airport.TimezoneId = timezoneId;
                airportContract.Airport.DateTime = DateTime.UtcNow;

                new CrudeAirportServiceClient().Update(airportContract.Airport);

                return RedirectToAction("AirportIndex");
            }

            return View(
                "~/Views/Templates/Airport/Airport/AirportEdit.cshtml",
                airportContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult AirportCreate(System.Guid? cityId, System.Guid? productId, System.Guid? timezoneId, System.Guid? userId) {
            var airportContract = new AirportContract();
            airportContract.Airport = new CrudeAirportContract();
            if (cityId != null) airportContract.Airport.CityId = (System.Guid) cityId;
            if (productId != null) airportContract.Airport.ProductId = (System.Guid) productId;
            if (timezoneId != null) airportContract.Airport.TimezoneId = (System.Guid) timezoneId;
            if (userId != null) airportContract.Airport.UserId = (System.Guid) userId;

            ViewBag.AirportTypeRcd =
                new SelectList( new CrudeAirportTypeRefServiceClient().FetchAll(),
                                "AirportTypeRcd",
                                "AirportTypeName",
                                airportContract.Airport.AirportTypeRcd
                                );

            ViewBag.CityId =
                new SelectList( new CrudeCityServiceClient().FetchAll(),
                                "CityId",
                                "CityName",
                                airportContract.Airport.CityId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                airportContract.Airport.ProductId
                                );

            ViewBag.TimezoneId =
                new SelectList( new CrudeTimezoneServiceClient().FetchAll(),
                                "TimezoneId",
                                "TimezoneName",
                                airportContract.Airport.TimezoneId
                                );

            airportContract.Airport.ActivationDateTime = DateTime.UtcNow;

            if (userId == null)
                airportContract.Airport.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(airportContract.Airport.UserId).DefaultUserName;

            airportContract.Airport.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Airport/Airport/AirportCreate.cshtml",
                airportContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportCreate([Bind()] AirportContract airportContract, System.String airportTypeRcd,System.Guid cityId,System.Guid productId,System.Guid timezoneId) {
            if (ModelState.IsValid) {

                airportContract.Airport.AirportTypeRcd = airportTypeRcd;
                airportContract.Airport.CityId = cityId;
                airportContract.Airport.ProductId = productId;
                airportContract.Airport.TimezoneId = timezoneId;
                new CrudeAirportServiceClient().Insert(airportContract.Airport);

                return RedirectToAction("AirportIndex");
            }

            return View(
                "~/Views/Templates/Airport/Airport/AirportCreate.cshtml",
                airportContract
                );
        }

    }
}
