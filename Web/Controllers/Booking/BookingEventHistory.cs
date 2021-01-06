using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingEventHistoryContract BookingEventHistoryNew(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingEventHistoryContract = 
                new BookingEventHistoryContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            bookingEventHistoryContract.EventHistory =
                new BookingSearchServiceClient().BookingEventHistory(bookingId);

            return bookingEventHistoryContract;
        }

        [HttpGet]
        public ActionResult BookingEventHistory(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingEventHistory"),
                BookingEventHistoryNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingEventHistory(
            [Bind()] BookingEventHistoryContract bookingEventHistoryContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingEventHistory",
                    new { bookingId = bookingEventHistoryContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingEventHistory"),
                BookingEventHistoryNew(bookingEventHistoryContract.BookingId)
                );
        }
    }

    public class BookingEventHistoryContract : BookingGeneralContract
    {
        public BookingEventHistoryContract() {
        }

        public BookingEventHistoryContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<SolutionNorSolutionPort.BusinessLogicLayer.BookingEventHistoryContract> EventHistory { get; set; }
    }
}
