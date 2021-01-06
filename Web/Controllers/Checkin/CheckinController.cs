using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class CheckinController : Controller
    {

        [HttpGet]
        public ActionResult CheckinIndex(
            [Bind()] CheckinContract contract,
            System.Guid? flightId
            ) {

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            List<FlightsOpenForCheckinWithDescriptionContract> flights =
                    new FlightSearchServiceClient().FlightsOpenForCheckinWithDescription(
                             Guid.Empty
                            , Guid.Empty
                            , contract.FromDateTime
                            , contract.UntilDateTime
                            );

            if ( flightId == null && flights.Count > 0 )
                contract.FlightId = flights[0].FlightId;

            ViewBag.FlightId =
                new SelectList(
                    flights,
                    "FlightId",
                    "FlightDescription",
                    contract.FlightId
                    );

            contract.Passengers = new PassengerSearchServiceClient().PassengersOnFlight(contract.FlightId);

            return View(
                MVCHelper.Resolve(Request, "Checkin", "CheckinIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult CheckinIndex(
            [Bind()] CheckinContract contract,
            System.Guid? flightId,
            Guid? dillToDiffrentiateFromHttpGet
            ) {

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            List<FlightsOpenForCheckinWithDescriptionContract> flights =
                    new FlightSearchServiceClient().FlightsOpenForCheckinWithDescription(
                             Guid.Empty
                            , Guid.Empty
                            , contract.FromDateTime
                            , contract.UntilDateTime
                            );

            ViewBag.FlightId =
                new SelectList(
                    flights,
                    "FlightId",
                    "FlightDescription",
                    contract.FlightId
                    );

            contract.Passengers = new PassengerSearchServiceClient().PassengersOnFlight(contract.FlightId);

            return View(
                MVCHelper.Resolve(Request, "Checkin", "CheckinIndex"),
                contract
                );
        }
    }

    public class CheckinContract
    {
        public DateTime FromDateTime { get; set; }
        public DateTime UntilDateTime { get; set; }
        public Guid FlightId { get; set; }
        public List<PassengersOnFlightContract> Passengers { get; set; }
        public List<PassengersOnFlightWithoutEventsContract> PassengersWithoutEvents { get; set; }
        public List<PassengersOnFlightCheckedInContract> PassengersCheckedIn { get; set; }
    }
}
