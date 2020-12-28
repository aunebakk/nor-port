using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingServicesContract BookingServicesNew(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingServicesContract = 
                new BookingServicesContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // get service attached to booking
            bookingServicesContract.Services =
                new FinancialSearchService().FinancialServiceDetailsForBooking(
                    bookingId);

            // get available services
            bookingServicesContract.SpecialServiceRequestList = new FinancialSearchService().SpecialServiceRequestList();

            return bookingServicesContract;
        }

        [HttpGet]
        public ActionResult BookingServices(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServices"),
                BookingServicesNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingServices(
            [Bind()] BookingServicesContract bookingServicesContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingServices",
                    new { bookingId = bookingServicesContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServices"),
                BookingServicesNew(bookingServicesContract.BookingId)
                );
        }

        [HttpGet]
        public ActionResult SpecialServiceRemove(
             Guid bookingId,
             Guid bookingServiceRequestId
             ) {
            new BookingServiceClient().BookingServiceRequestRemove(
                bookingServiceRequestId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServices",
                    new { bookingId = bookingId });
        }

        [HttpGet]
        public ActionResult SpecialServiceAdd(
             Guid bookingId,
             Guid serviceSpecialServiceRequestId
             ) {
            new BookingServiceClient().BookingServiceSpecialServiceRequestAdd(
                bookingId,
                serviceSpecialServiceRequestId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServices",
                    new { bookingId = bookingId });
        }
    }

    public class BookingServicesContract : BookingGeneralContract
    {
        public BookingServicesContract() {
        }

        public BookingServicesContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<FinancialServiceDetailsForBookingContract> Services { get; set; }

        public List<SpecialServiceRequestListContract> SpecialServiceRequestList { get; set; }
    }
}
