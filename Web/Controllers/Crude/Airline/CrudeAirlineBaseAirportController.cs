/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 7:06:59 PM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPort.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeAirlineBaseAirportController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportIndex() {

            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportIndex.cshtml",
                new CrudeAirlineBaseAirportServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportByAirlineIndex(System.Guid airlineId) {
            ViewBag.AirlineId = airlineId;

            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportIndex.cshtml",
                new CrudeAirlineBaseAirportServiceClient().FetchByAirlineId(airlineId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportByAirportIndex(System.Guid airportId) {
            ViewBag.AirportId = airportId;

            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportIndex.cshtml",
                new CrudeAirlineBaseAirportServiceClient().FetchByAirportId(airportId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportDetails(System.Guid airlineBaseAirportId) {

            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportDetails.cshtml",
                new CrudeAirlineBaseAirportServiceClient().FetchByAirlineBaseAirportId(airlineBaseAirportId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportEdit(
            System.Guid airlineBaseAirportId
            ) {

            CrudeAirlineBaseAirportContract contract = new CrudeAirlineBaseAirportServiceClient().FetchByAirlineBaseAirportId(airlineBaseAirportId);
            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.AirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.AirportId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirlineBaseAirportEdit([Bind()] CrudeAirlineBaseAirportContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeAirlineBaseAirportServiceClient().Update(contract);

                return RedirectToAction("CrudeAirlineBaseAirportIndex");
            }

            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportCreate(System.Guid? airlineId, System.Guid? airportId, System.Guid? userId) {
            var contract = new CrudeAirlineBaseAirportContract();
            if (airlineId != null) contract.AirlineId = (System.Guid) airlineId;
            if (airportId != null) contract.AirportId = (System.Guid) airportId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.AirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.AirportId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirlineBaseAirportCreate([Bind()] CrudeAirlineBaseAirportContract contract) {
            if (ModelState.IsValid) {

                new CrudeAirlineBaseAirportServiceClient().Insert(contract);

                return RedirectToAction("CrudeAirlineBaseAirportIndex");
            }

            return View(
                "~/Views/Crude/Airline/CrudeAirlineBaseAirport/CrudeAirlineBaseAirportCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeAirlineBaseAirportDelete(
            System.Guid airlineBaseAirportId
            ) {
            new CrudeAirlineBaseAirportServiceClient().Delete(airlineBaseAirportId);

            return RedirectToAction("CrudeAirlineBaseAirportIndex");
        }
    }
}
