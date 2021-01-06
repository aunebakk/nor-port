using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class FlightController : Controller
    {

        [HttpGet]
        public ActionResult FlightIndex() {
            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightIndex"),
                new CrudeFlightServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult FlightDetails(System.Guid flightId) {
            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightDetails"),
                new CrudeFlightServiceClient().FetchByFlightId(flightId)
                );
        }

        [HttpGet]
        public ActionResult FlightEdit(System.Guid flightId) {

            ViewBag.FlightId = flightId;

            FlightContract flightContract = 
                new FlightServiceClient().GetFlight(
                    flightId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            ViewBag.AirlineId =
                new SelectList(new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                flightContract.Flight.AirlineId
                                );

            ViewBag.AircraftTypeRcd =
                new SelectList(new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                flightContract.Flight.AircraftTypeRcd
                                );

            ViewBag.DepartureAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                flightContract.Flight.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                flightContract.Flight.ArrivalAirportId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(flightContract.Flight.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightEdit"),
                flightContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FlightEdit([Bind()] FlightContract flightContract) {
            if ( ModelState.IsValid ) {
                new FlightServiceClient().
                    UpdateFlight(
                        flightContract,
                        Logging.UserId(User.Identity, ViewBag)
                        );

                return RedirectToAction("FlightIndex");
            }

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightEdit"),
                flightContract
                );
        }

        [HttpGet]
        public ActionResult FlightCreate() {
            var contract = new CrudeFlightContract();

            ViewBag.AirlineId =
                new SelectList(new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.AircraftTypeRcd =
                new SelectList(new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                contract.AircraftTypeRcd
                                );

            ViewBag.DepartureAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.ArrivalAirportId
                                );

            contract.FromDateTime = DateTime.UtcNow;

            contract.UntilDateTime = DateTime.UtcNow;

            contract.UserId = Logging.UserId(User.Identity, ViewBag);

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FlightCreate([Bind()] CrudeFlightContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeFlightServiceClient().Insert(contract);

                return RedirectToAction("FlightIndex");
            }

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightCreate"),
                contract
                );
        }
    }
}
