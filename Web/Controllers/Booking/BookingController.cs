using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.SessionState;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        [HttpGet]
        public ActionResult BookingTest() {
            LoggingTime log = LoggingTime.PerformanceTimeStart("BookingListIndex");
            BookingListIndex();
            new BookingController().BookingListIndex();
            new BookieController().BookieIndex(new BookieContract(), null);

            log.PerformanceTimeStop();
            ViewBag.Result = "Elapsed: " + log.StopWatch.ElapsedMilliseconds;

            return View();
        }

        [HttpGet]
        public ActionResult SimulateBookings() {
            new BookingServiceClient().SimulateBookingsAsync(
                    DateTime.UtcNow.Date,
                    DateTime.UtcNow.Date.AddDays(1),
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingSimulate")
                );
        }

        [HttpGet]
        public ActionResult BookingListIndex() {
            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingListIndex"),
                            new BookingSearchServiceClient().BookingsOpen()
                            );
        }

        [HttpGet]
        public ActionResult BookingSendConfirmationMail(
            System.Guid bookingId
            ) {

            new BookingServiceClient().SendBookingConfirmationByEmail(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return RedirectToAction("BookingEventHistory",
                                    new { bookingId = bookingId }
                                    );

        }

        [HttpGet]
        public ActionResult BookingCreate() {
            // default values
            var bookingService = new BookingServiceClient();
            BookingContract bookingContract = bookingService.GetBookingEmpty(Logging.UserId(User.Identity, ViewBag));

            // todo, session id can't be trusted
            bookingContract.Booking.BookingId = new Guid(Session["SessionID"].ToString());
            bookingContract.Booking.BookingSourceRcd = BookingSourceRef.InternalSystem;

            bookingContract.BookingIdentifier = new CrudeBookingIdentifierContract();
            bookingContract.BookingIdentifier.BookingIdentifierTypeRcd = BookingIdentifierTypeRef.RecordLocator;
            bookingContract.BookingIdentifier.BookingIdentifierValue = new BookingServiceClient().LocatorCreate();

            // get user id
            ViewBag.UserId = Logging.UserId(User.Identity, ViewBag);

            // refs
            List<CrudeBookingSourceRefContract> refs = 
                new BusinessLogicLayer.CrudeBookingSourceRefServiceClient().FetchAll();

            ViewBag.BookingSourceRcd =
                new SelectList(
                    refs,
                    "BookingSourceRcd",
                    "BookingSourceName",
                    bookingContract.Booking.BookingSourceRcd
                    );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingCreate"),
                            bookingContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingCreate([Bind()] BookingContract bookingContract) {
            if ( ModelState.IsValid ) {
                var bookingService = new BookingServiceClient();

                bookingContract.Booking.BookingId =
                    bookingService.UpdateBooking(
                        bookingContract.Booking.BookingId,
                        bookingContract.Booking.BookingSourceRcd,
                        bookingContract.BookingIdentifier.BookingIdentifierValue,
                        bookingContract.BookingContactMethod.ContactMethodWay,
                        bookingContract.Booking.ReceivedFrom,
                        bookingContract.Booking.Comment,
                        bookingContract.Booking.FinancialCurrencyId,
                        bookingContract.Booking.FinancialCostcentreId,
                        Logging.UserId(User.Identity, ViewBag)
                        );

                return RedirectToAction("BookingContacts",
                                        new { bookingId = bookingContract.Booking.BookingId }
                                        );
            }

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingCreate"),
                            bookingContract
                            );
        }

        [HttpGet]
        public ActionResult BookingCreateWithFlightDirect(
            Guid flightId
            ) {

            Guid bookingId = 
                new BookingServiceClient().CreateBooking(
                    BookingSourceRef.InternalSystem,
                    flightId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            return RedirectToAction("BookingPassengers",
                                    new { bookingId = bookingId }
                                    );
        }

        [HttpGet]
        public ActionResult BookingCreateWithFlight(
            Guid flightId
            ) {

            // default values
            var bookingService = new BookingServiceClient();
            BookingContract bookingContract = bookingService.GetBookingEmpty(Logging.UserId(User.Identity, ViewBag));

            // todo, session id can't be trusted
            bookingContract.Booking.BookingId = new Guid(Session["SessionID"].ToString());
            //bookingContract.Booking.BookingId = new Guid(this.Session.SessionID);
            
            bookingContract.Booking.BookingSourceRcd = BookingSourceRef.InternalSystem;

            bookingContract.BookingIdentifier = new CrudeBookingIdentifierContract();
            bookingContract.BookingIdentifier.BookingIdentifierTypeRcd = BookingIdentifierTypeRef.RecordLocator;
            bookingContract.BookingIdentifier.BookingIdentifierValue = new BookingServiceClient().LocatorCreate();

            // get user id
            ViewBag.UserId = Logging.UserId(User.Identity, ViewBag);

            // refs
            List<CrudeBookingSourceRefContract> refs = 
                new BusinessLogicLayer.CrudeBookingSourceRefServiceClient().FetchAll();

            ViewBag.BookingSourceRcd =
                new SelectList(
                    refs,
                    "BookingSourceRcd",
                    "BookingSourceName",
                    bookingContract.Booking.BookingSourceRcd
                    );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingCreate"),
                            bookingContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingCreateWithFlight(
            [Bind()] BookingContract bookingContract,
            Guid flightId
            ) {

            if ( ModelState.IsValid ) {
                var bookingService = new BookingServiceClient();

                bookingContract.Booking.BookingId =
                    bookingService.UpdateBooking(
                        bookingContract.Booking.BookingId,
                        bookingContract.Booking.BookingSourceRcd,
                        bookingContract.BookingIdentifier.BookingIdentifierValue,
                        bookingContract.BookingContactMethod.ContactMethodWay,
                        bookingContract.Booking.ReceivedFrom,
                        bookingContract.Booking.Comment,
                        bookingContract.Booking.FinancialCurrencyId,
                        bookingContract.Booking.FinancialCostcentreId,
                        Logging.UserId(User.Identity, ViewBag)
                        );

                FlightAdd(bookingContract.Booking.BookingId,
                            flightId
                            );

                return RedirectToAction("BookingItinerary",
                                        new { bookingId = bookingContract.Booking.BookingId }
                                        );
            }

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingCreate"),
                            bookingContract
                            );
        }
    }
}
