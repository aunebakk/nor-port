using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class FlightScheduleLiveController : Controller
    {

        [HttpGet]
        public ActionResult FlightScheduleIndex() {
            return View(
                MVCHelper.Resolve(Request, "Schedule", "FlightScheduleIndex"),
                new ScheduleSearchServiceClient().FlightSchedule()
                );
        }

        [HttpGet]
        public ActionResult MakeFlightsFromScheduleAll() {
            new ScheduleServiceClient().MakeFlightsFromScheduleAllAsync(
                Logging.UserId(User.Identity, ViewBag)
                );

            return View(
                MVCHelper.Resolve(Request, "Schedule", "MakeFlightsFromScheduleAll")
                );
        }

        [HttpGet]
        public ActionResult CheckFlightStatuses() {
            new FlightServiceClient().CheckFlightStatusesAsync(
                    DateTime.UtcNow.Date,
                    DateTime.UtcNow.Date.AddDays(1),
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return View(
                MVCHelper.Resolve(Request, "Schedule", "CheckFlightStatuses")
                );
        }
    }
}
