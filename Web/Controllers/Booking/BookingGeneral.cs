using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {
        [HttpGet]
        public ActionResult BookingGeneral(
            Guid bookingId
            ) {

            var bookingGeneralContract = 
                new BookingGeneralContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // make view bag for ref codes
            List<CrudeBookingSourceRefContract> refs = 
                new BusinessLogicLayer.CrudeBookingSourceRefServiceClient().FetchAll();

            ViewBag.BookingSourceRcd =
                new SelectList(refs,
                                "BookingSourceRcd",
                                "BookingSourceName",
                                bookingGeneralContract.BookingSourceRcd
                                );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingGeneral"),
                            bookingGeneralContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingGeneral(
            [Bind()] BookingGeneralContract bookingGeneralContract
            ) {
            if ( ModelState.IsValid ) {
                new BookingServiceClient().UpdateBookingPage1(
                    bookingGeneralContract.BookingId,
                    bookingGeneralContract.BookingSourceRcd,
                    bookingGeneralContract.Locator,
                    bookingGeneralContract.ReceivedFrom,
                    bookingGeneralContract.Comment,
                    Logging.UserId(User.Identity, ViewBag)
                    );

                return RedirectToAction(
                    "BookingContacts",
                    new { bookingId = bookingGeneralContract.BookingId });
            }
            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingGeneral"),
                            bookingGeneralContract
                            );
        }
    }

    public class BookingGeneralContract
    {
        public BookingGeneralContract() { }

        public BookingGeneralContract(
            Guid bookingId,
            Guid userId
            ) {

            // fetch booking data
            BookingContract =
                new BookingServiceClient().GetBooking(
                        bookingId,
                        userId
                        );

            BookingId = BookingContract.Booking.BookingId;
            Locator = BookingContract.BookingIdentifier.BookingIdentifierValue;
            BookingSourceRcd = BookingContract.Booking.BookingSourceRcd;
            ReceivedFrom = BookingContract.Booking.ReceivedFrom;
            Comment = BookingContract.Booking.Comment;
        }

        public BookingContract BookingContract { get; set; }
        public Guid BookingId { get; set; }
        public string Locator { get; set; }
        public string BookingSourceRcd { get; set; }
        public string ReceivedFrom { get; set; }
        public string Comment { get; set; }
    }
}
