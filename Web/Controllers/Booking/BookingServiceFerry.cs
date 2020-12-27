using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingServiceFerryContract BookingServiceFerryNew(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingServicesContract = 
                new BookingServiceFerryContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // get service attached to booking
            bookingServicesContract.Services =
                new FinancialSearchService().FinancialServiceDetailsForBooking(
                    bookingId);

            // get available hotels
            bookingServicesContract.ServiceFerryList =
                new FinancialSearchService().ServiceFerryList();

            return bookingServicesContract;
        }

        [HttpGet]
        public ActionResult BookingServiceFerry(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServiceFerry"),
                BookingServiceFerryNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingServiceFerry(
            [Bind()] BookingServiceFerryContract bookingServicesContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingServiceFerry",
                    new { bookingId = bookingServicesContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServiceFerry"),
                BookingServiceFerryNew(bookingServicesContract.BookingId)
                );
        }

        [HttpGet]
        public ActionResult ServiceFerryRemove(
             Guid bookingId,
             Guid bookingServiceRequestId
             ) {
            new BookingServiceClient().BookingServiceRequestRemove(
                bookingServiceRequestId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServiceFerry",
                    new { bookingId = bookingId });
        }

        [HttpGet]
        public ActionResult ServiceFerryAdd(
             Guid bookingId,
             Guid serviceFerryId
             ) {
            new BookingServiceClient().BookingServiceFerryAdd(
                bookingId,
                serviceFerryId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServiceFerry",
                    new { bookingId = bookingId });
        }
    }

    public class BookingServiceFerryContract : BookingGeneralContract
    {
        public BookingServiceFerryContract() {
        }

        public BookingServiceFerryContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<FinancialServiceDetailsForBookingContract> Services { get; set; }

        public List<ServiceFerryListContract> ServiceFerryList { get; set; }
    }
}
