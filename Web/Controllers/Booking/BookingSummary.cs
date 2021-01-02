using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingSummaryContract BookingSummaryNew(
            Guid bookingId
            ) {

            // fetch booking data
            var bookingSummaryContract = 
                new BookingSummaryContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // get service attached to booking
            bookingSummaryContract.Summary =
                new BookingSearchServiceClient().BookingServiceSummary(
                        bookingId);

            return bookingSummaryContract;
        }

        [HttpGet]
        public ActionResult BookingSummary(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingSummary"),
                BookingSummaryNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingSummary(
            [Bind()] BookingSummaryContract BookingSummaryContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingSummary",
                    new { bookingId = BookingSummaryContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingSummary"),
                BookingSummaryNew(BookingSummaryContract.BookingId)
                );
        }
    }

    public class BookingSummaryContract : BookingGeneralContract
    {
        public BookingSummaryContract() {
        }

        public BookingSummaryContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<BookingServiceSummaryContract> Summary { get; set; }
    }
}
