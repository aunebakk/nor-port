using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingPassengerContract BookingPassengersNew(
            Guid bookingId
            ) {

            var bookingPassengerContract = 
                new BookingPassengerContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            bookingPassengerContract.Passengers = new BookingSearchServiceClient().BookingPassengers(bookingId);
            bookingPassengerContract.NewPassengerTypeRcd = PassengerTypeRef.Adult;

            ViewBag.NewPassengerTypeRcd =
                new SelectList(
                    new CrudePassengerTypeRefServiceClient().FetchAll(),
                    "PassengerTypeRcd",
                    "PassengerTypeName",
                    bookingPassengerContract.NewPassengerTypeRcd
                    );

            return bookingPassengerContract;
        }

        [HttpGet]
        public ActionResult BookingPassengers(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingPassengers"),
                BookingPassengersNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingPassengers(
            [Bind()] BookingPassengerContract bookingPassengerContract
            ) {

            if ( ModelState.IsValid ) {
                new BookingServiceClient()
                    .PassengerAdd(
                        bookingPassengerContract.BookingId,
                        bookingPassengerContract.NewPassengerTypeRcd,
                        bookingPassengerContract.NewPassengerName,
                        Logging.UserId(User.Identity, ViewBag)
                        );

                return RedirectToAction(
                    "BookingPassengers",
                    new { bookingId = bookingPassengerContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingPassengers"),
                BookingPassengersNew(bookingPassengerContract.BookingId)
                );
        }

        [HttpGet]
        public ActionResult PassengerRemove(
            Guid bookingId,
            Guid bookingPassengerId
            ) {

            new BookingServiceClient().PassengerRemove(
                bookingPassengerId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                "BookingPassengers",
                new { bookingId = bookingId });
        }

    }

    public class BookingPassengerContract : BookingGeneralContract
    {
        public BookingPassengerContract() { }
        public BookingPassengerContract(Guid bookingId, Guid userId) : base(bookingId, userId) { }
        public string NewPassengerTypeRcd { get; set; }
        public string NewPassengerName { get; set; }
        public List<BookingPassengersContract> Passengers { get; set; }
    }
}
