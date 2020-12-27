using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingServiceHotelContract BookingServiceHotelNew(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingServicesContract = 
                new BookingServiceHotelContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // get service attached to booking
            bookingServicesContract.Services =
                new FinancialSearchService().FinancialServiceDetailsForBooking(
                    bookingId);

            // get available hotels
            bookingServicesContract.ServiceHotelList =
                new FinancialSearchService().ServiceHotelList();

            return bookingServicesContract;
        }

        [HttpGet]
        public ActionResult BookingServiceHotel(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServiceHotel"),
                BookingServiceHotelNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingServiceHotel(
            [Bind()] BookingServiceHotelContract bookingServicesContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingServiceHotel",
                    new { bookingId = bookingServicesContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServiceHotel"),
                BookingServiceHotelNew(bookingServicesContract.BookingId)
                );
        }

        [HttpGet]
        public ActionResult ServiceHotelRemove(
             Guid bookingId,
             Guid bookingServiceRequestId
             ) {
            new BookingServiceClient().BookingServiceRequestRemove(
                bookingServiceRequestId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServiceHotel",
                    new { bookingId = bookingId });
        }

        [HttpGet]
        public ActionResult ServiceHotelAdd(
             Guid bookingId,
             Guid serviceHotelId
             ) {
            new BookingServiceClient().BookingServiceHotelAdd(
                bookingId,
                serviceHotelId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServiceHotel",
                    new { bookingId = bookingId });
        }
    }

    public class BookingServiceHotelContract : BookingGeneralContract
    {
        public BookingServiceHotelContract() {
        }

        public BookingServiceHotelContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<FinancialServiceDetailsForBookingContract> Services { get; set; }

        public List<ServiceHotelListContract> ServiceHotelList { get; set; }
    }
}
