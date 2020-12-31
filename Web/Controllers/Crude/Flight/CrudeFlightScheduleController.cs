/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 10:37:55 AM
  From Machine: DESKTOP-LSRVP12
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
    //   and transfers that data with an to REST API Contract through the JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeFlightScheduleController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeFlightScheduleIndex() {

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleIndex.cshtml",
                new CrudeFlightScheduleServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFlightScheduleByAirlineIndex(System.Guid airlineId) {
            ViewBag.AirlineId = airlineId;

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleIndex.cshtml",
                new CrudeFlightScheduleServiceClient().FetchByAirlineId(airlineId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFlightScheduleByDepartureAirportIndex(System.Guid departureAirportId) {
            ViewBag.DepartureAirportId = departureAirportId;

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleIndex.cshtml",
                new CrudeFlightScheduleServiceClient().FetchByDepartureAirportId(departureAirportId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFlightScheduleByArrivalAirportIndex(System.Guid arrivalAirportId) {
            ViewBag.ArrivalAirportId = arrivalAirportId;

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleIndex.cshtml",
                new CrudeFlightScheduleServiceClient().FetchByArrivalAirportId(arrivalAirportId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeFlightScheduleDetails(System.Guid flightScheduleId) {

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleDetails.cshtml",
                new CrudeFlightScheduleServiceClient().FetchByFlightScheduleId(flightScheduleId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeFlightScheduleEdit(
            System.Guid flightScheduleId
            ) {

            CrudeFlightScheduleContract contract = new CrudeFlightScheduleServiceClient().FetchByFlightScheduleId(flightScheduleId);
            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.AircraftTypeRcd =
                new SelectList( new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                contract.AircraftTypeRcd
                                );

            ViewBag.DepartureAirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.ArrivalAirportId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFlightScheduleEdit([Bind()] CrudeFlightScheduleContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFlightScheduleServiceClient().Update(contract);

                return RedirectToAction("CrudeFlightScheduleIndex");
            }

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeFlightScheduleCreate(System.Guid? becameFlightScheduleId, System.Guid? bindingFlightScheduleId, System.Guid? airlineId, System.Guid? departureAirportId, System.Guid? arrivalAirportId, System.Guid? userId) {
            var contract = new CrudeFlightScheduleContract();
            if (becameFlightScheduleId != null) contract.BecameFlightScheduleId = (System.Guid) becameFlightScheduleId;
            if (bindingFlightScheduleId != null) contract.BindingFlightScheduleId = (System.Guid) bindingFlightScheduleId;
            if (airlineId != null) contract.AirlineId = (System.Guid) airlineId;
            if (departureAirportId != null) contract.DepartureAirportId = (System.Guid) departureAirportId;
            if (arrivalAirportId != null) contract.ArrivalAirportId = (System.Guid) arrivalAirportId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.AircraftTypeRcd =
                new SelectList( new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                contract.AircraftTypeRcd
                                );

            ViewBag.DepartureAirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList( new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.ArrivalAirportId
                                );

            contract.FromDateTime = DateTime.UtcNow;

            contract.UntilDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFlightScheduleCreate([Bind()] CrudeFlightScheduleContract contract) {
            if (ModelState.IsValid) {

                new CrudeFlightScheduleServiceClient().Insert(contract);

                return RedirectToAction("CrudeFlightScheduleIndex");
            }

            return View(
                "~/Views/Crude/Flight/CrudeFlightSchedule/CrudeFlightScheduleCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeFlightScheduleDelete(
            System.Guid flightScheduleId
            ) {
            new CrudeFlightScheduleServiceClient().Delete(flightScheduleId);

            return RedirectToAction("CrudeFlightScheduleIndex");
        }
    }
}
