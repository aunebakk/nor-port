using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingServiceCarContract BookingServiceCarNew(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingServicesContract = 
                new BookingServiceCarContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // get service attached to booking
            bookingServicesContract.Services =
                new FinancialSearchService().FinancialServiceDetailsForBooking(
                    bookingId);

            // get available hotels
            bookingServicesContract.ServiceCarList =
                new FinancialSearchService().ServiceCarRentalList();

            return bookingServicesContract;
        }

        [HttpGet]
        public ActionResult BookingServiceCar(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServiceCar"),
                BookingServiceCarNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingServiceCar(
            [Bind()] BookingServiceCarContract bookingServicesContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingServiceCar",
                    new { bookingId = bookingServicesContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingServiceCar"),
                BookingServiceCarNew(bookingServicesContract.BookingId)
                );
        }

        [HttpGet]
        public ActionResult ServiceCarRemove(
             Guid bookingId,
             Guid bookingServiceRequestId
             ) {
            new BookingServiceClient().BookingServiceRequestRemove(
                bookingServiceRequestId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServiceCar",
                    new { bookingId = bookingId });
        }

        [HttpGet]
        public ActionResult ServiceCarAdd(
             Guid bookingId,
             Guid serviceCarRentalId
             ) {
            new BookingServiceClient().BookingServiceCarRentalAdd(
                bookingId,
                serviceCarRentalId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                    "BookingServiceCar",
                    new { bookingId = bookingId });
        }
    }

    public class BookingServiceCarContract : BookingGeneralContract
    {
        public BookingServiceCarContract() {
        }

        public BookingServiceCarContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<FinancialServiceDetailsForBookingContract> Services { get; set; }

        public List<ServiceCarRentalListContract> ServiceCarList { get; set; }
    }
}
