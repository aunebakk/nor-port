using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class ScheduleController : Controller
    {

        private Guid DefaultUserId { get { return Logging.UserId(User.Identity, ViewBag); } }

        // GET: Schedule
        public ActionResult MakeFlightsFromSchedule(Guid flightScheduleId) {
            var schedule = new ScheduleServiceClient();
            schedule.MakeFlightsFromSchedule(
                flightScheduleId,
                DefaultUserId
                );

            return RedirectToAction("FlightsForPeriodIndex", "FlightsForPeriodLive");
        }

        [HttpGet]
        public ActionResult ScheduleIndex() {
            return View(
                "~/Views/" + "Schedule" + "/" + "ScheduleIndex" + ".cshtml",
                new CrudeFlightScheduleServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult ScheduleCreate() {
            var scheduleContract = 
                new ScheduleContract();

            ViewBag.AirlineId =
                new SelectList(new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                scheduleContract.FlightSchedule.AirlineId
                                );

            ViewBag.AircraftTypeRcd =
                new SelectList(new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                "AircraftTypeRcd",
                                "AircraftTypeName",
                                scheduleContract.FlightSchedule.AircraftTypeRcd
                                );

            ViewBag.DepartureAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                scheduleContract.FlightSchedule.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                scheduleContract.FlightSchedule.ArrivalAirportId
                                );

            scheduleContract.FlightSchedule.FromDateTime = DateTime.UtcNow;
            scheduleContract.FlightSchedule.UntilDateTime = DateTime.UtcNow;
            scheduleContract.FlightSchedule.UserId = DefaultUserId;

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().
                    FetchByDefaultUserId(scheduleContract.FlightSchedule.UserId).
                        DefaultUserName;

            scheduleContract.FlightSchedule.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleCreate"),
                scheduleContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScheduleCreate([Bind()] ScheduleContract scheduleContract) {
            if ( ModelState.IsValid ) {
                new ScheduleServiceClient().
                    CreateSchedule(
                        scheduleContract,
                        DefaultUserId
                        );

                return RedirectToAction("FlightScheduleIndex", "FlightScheduleLive");
            }

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleCreate"),
                scheduleContract.FlightSchedule
                );
        }

        [HttpGet]
        public ActionResult ScheduleDetails(System.Guid flightScheduleId) {
            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleDetails"),
                new CrudeFlightScheduleServiceClient().FetchByFlightScheduleId(flightScheduleId)
                );
        }

        [HttpGet]
        public ActionResult ScheduleEdit(System.Guid flightScheduleId) {
            ScheduleContract scheduleContract = 
                new ScheduleServiceClient().GetSchedule(
                    flightScheduleId,
                    DefaultUserId
                    );

            ViewBag.AirlineId =
                new SelectList(new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                scheduleContract.FlightSchedule.AirlineId
                                );

            // items, string dataValueField, string dataTextField, string dataGroupField, object selectedValue
            ViewBag.AircraftTypeRcd =
                new SelectList(items: new CrudeAircraftTypeRefServiceClient().FetchAll(),
                                dataValueField: "AircraftTypeRcd",
                                dataTextField: "AircraftTypeName",
                                selectedValue: scheduleContract.FlightSchedule.AircraftTypeRcd
                                );

            ViewBag.DepartureAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                scheduleContract.FlightSchedule.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                scheduleContract.FlightSchedule.ArrivalAirportId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(
                        scheduleContract.FlightSchedule.UserId
                        ).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleEdit"),
                scheduleContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScheduleEdit([Bind()] ScheduleContract scheduleContract) {
            if ( ModelState.IsValid ) {

                new ScheduleServiceClient().
                    UpdateSchedule(
                        scheduleContract,
                        DefaultUserId
                        );

                return RedirectToAction("FlightScheduleIndex", "FlightScheduleLive");
            }

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleEdit"),
                scheduleContract
                );
        }

        [HttpGet]
        public ActionResult ScheduleSegmentCreate(Guid flightScheduleId) {
            var contract = new CrudeFlightScheduleSegmentContract();

            contract.FlightScheduleId = flightScheduleId;

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

            contract.UserId = DefaultUserId;

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().
                    FetchByDefaultUserId(DefaultUserId).
                        DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleSegmentCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScheduleSegmentCreate([Bind()] CrudeFlightScheduleSegmentContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeFlightScheduleSegmentServiceClient().Insert(contract);

                return RedirectToAction("ScheduleEdit", new { flightScheduleId = contract.FlightScheduleId });
            }

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleSegmentCreate"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ScheduleSegmentEdit(System.Guid flightScheduleSegmentId) {
            CrudeFlightScheduleSegmentContract contract = 
                new CrudeFlightScheduleSegmentServiceClient().FetchByFlightScheduleSegmentId(flightScheduleSegmentId);

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

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().
                    FetchByDefaultUserId(DefaultUserId).
                        DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleSegmentEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScheduleSegmentEdit([Bind()] CrudeFlightScheduleSegmentContract contract) {
            if ( ModelState.IsValid ) {
                new CrudeFlightScheduleSegmentServiceClient().Update(contract);

                return RedirectToAction("ScheduleEdit", new { flightScheduleId = contract.FlightScheduleId });
            }

            return View(
                MVCHelper.Resolve(Request, "Schedule", "ScheduleSegmentEdit"),
                contract
                );
        }
    }
}
