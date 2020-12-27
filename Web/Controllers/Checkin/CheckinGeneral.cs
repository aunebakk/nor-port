using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class CheckinController : Controller
    {

        [HttpGet]
        public ActionResult CheckinCheckIn(
            Guid flightId,
            Guid bookingPassengerId,
            Guid bookingFlightSegmentId,
            string returnToPage
            ) {

            new BookingServiceClient()
                .PassengerCheckIn(
                    bookingPassengerId,
                    bookingFlightSegmentId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return RedirectToAction(returnToPage,
                                    new { flightId = flightId }
                                    );
        }

        [HttpGet]
        public ActionResult CheckinCheckOut(
            Guid flightId,
            Guid bookingPassengerId,
            Guid bookingFlightSegmentId,
            string returnToPage
            ) {

            new BookingServiceClient()
                .PassengerCheckOut(
                    bookingPassengerId,
                    bookingFlightSegmentId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return RedirectToAction(returnToPage,
                                    new { flightId = flightId }
                                    );
        }
    }
}
