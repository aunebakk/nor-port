using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {
        [HttpGet]
        public ActionResult BookingItinerary(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingItineraryContract = 
                new BookingItineraryContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // todo, move the following into get booking service
            bookingItineraryContract.Flights = new BookingSearchService().BookingFlights(bookingId);

            // default search flight dates
            bookingItineraryContract.SearchFlights = new FlightsForPeriodLiveContract();
            bookingItineraryContract.SearchFlights.FromDateTime = DateTime.UtcNow.Date;
            bookingItineraryContract.SearchFlights.UntilDateTime = DateTime.UtcNow.Date.AddDays(1);

            bookingItineraryContract.SearchFlights.Flights =
                new FlightSearchService().FlightsForPeriod(
                    Guid.Empty,
                    Guid.Empty,
                    bookingItineraryContract.SearchFlights.FromDateTime,
                    bookingItineraryContract.SearchFlights.UntilDateTime
                    );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingItinerary"),
                            bookingItineraryContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingItinerary(
            [Bind()] BookingItineraryContract bookingItineraryContract
            ) {
            // move the following into get booking service
            bookingItineraryContract.Flights = new BookingSearchService().BookingFlights(bookingItineraryContract.BookingId);

            // search for flights
            bookingItineraryContract.SearchFlights.Flights =
                new FlightSearchService().FlightsForPeriod(
                    Guid.Empty,
                    Guid.Empty,
                    bookingItineraryContract.SearchFlights.FromDateTime,
                    bookingItineraryContract.SearchFlights.UntilDateTime
                    );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingItinerary"),
                            bookingItineraryContract
                            );
        }

        [HttpGet]
        public ActionResult FlightAdd(
            Guid bookingId,
            Guid flightId
            ) {

            new BookingServiceClient().FlightAdd(
                bookingId,
                flightId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                "BookingItinerary",
                new { bookingId = bookingId });
        }

        [HttpGet]
        public ActionResult FlightRemove(
            Guid bookingId,
            Guid bookingFlightSegmentId
            ) {

            new BookingServiceClient().FlightRemove(
                bookingId,
                bookingFlightSegmentId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                "BookingItinerary",
                new { bookingId = bookingId });
        }
    }

    public class BookingItineraryContract : BookingGeneralContract
    {

        public BookingItineraryContract() {
            SearchFlights = new FlightsForPeriodLiveContract();
        }

        public BookingItineraryContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
            SearchFlights = new FlightsForPeriodLiveContract();
        }

        public List<BookingFlightsContract> Flights { get; set; }

        public FlightsForPeriodLiveContract SearchFlights { get; set; }

        public DateTime FromDateTime { get { return SearchFlights.FromDateTime; } set { SearchFlights.FromDateTime = value; } }

        public DateTime UntilDateTime { get { return SearchFlights.UntilDateTime; } set { SearchFlights.UntilDateTime = value; } }
    }
}
