using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {
        [HttpGet]
        public ActionResult BookingContacts(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingContactContract = 
                new BookingContactContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            bookingContactContract.ContactMethodWay = bookingContactContract.BookingContract.BookingContactMethod.ContactMethodWay;
            bookingContactContract.Comment = bookingContactContract.BookingContract.BookingContactMethod.Comment;

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingContacts"),
                            bookingContactContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingContacts(
            [Bind()] BookingContactContract bookingContactContract
            ) {

            if ( ModelState.IsValid ) {
                new BookingServiceClient().UpdateBookingPage2(
                    bookingContactContract.BookingId,
                    bookingContactContract.ContactMethodWay,
                    bookingContactContract.Comment,
                    Logging.UserId(User.Identity, ViewBag)
                    );

                return RedirectToAction(
                    "BookingAddress",
                    new { bookingId = bookingContactContract.BookingId });
            }

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingContacts"),
                            bookingContactContract
                            );
        }
    }

    public class BookingContactContract : BookingGeneralContract
    {
        public BookingContactContract() { }
        public BookingContactContract(Guid bookingId, Guid userId) : base(bookingId, userId) { }
        public string ContactMethodWay { get; set; }
        public string ContactComment { get; set; }
    }
}
