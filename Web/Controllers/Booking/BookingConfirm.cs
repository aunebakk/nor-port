using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {
        [HttpGet]
        public ActionResult BookingConfirm(
            Guid bookingId
            ) {

            // fetch booking data
            var bookingConfirmContract = 
                new BookingConfirmContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingConfirm"),
                            bookingConfirmContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingConfirm(
            [Bind()] BookingConfirmContract bookingConfirmContract
            ) {

            if ( ModelState.IsValid ) {
                new BookingServiceClient().BookingConfirm(
                    bookingConfirmContract.BookingId,
                    Logging.UserId(User.Identity, ViewBag.UserId)
                    );

                return RedirectToAction(
                    "BookingEventHistory",
                    new { bookingId = bookingConfirmContract.BookingId });
            }

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingConfirm"),
                            bookingConfirmContract
                            );
        }
    }

    public class BookingConfirmContract : BookingGeneralContract
    {
        public BookingConfirmContract() {
        }

        public BookingConfirmContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }
    }
}
