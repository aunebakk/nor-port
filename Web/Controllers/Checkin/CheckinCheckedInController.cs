using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class CheckinController : Controller
    {

        [HttpGet]
        public ActionResult CheckinCheckedInIndex(System.Guid flightId) {
            var contract = new CheckinContract();

            contract.FlightId = flightId;

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            List<FlightsOpenForCheckinWithDescriptionContract> flights =
                    new FlightSearchService().FlightsOpenForCheckinWithDescription(
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

            contract.PassengersCheckedIn =
                new PassengerSearchService().PassengersOnFlightCheckedIn(
                    flightId);

            return View(
                MVCHelper.Resolve(Request, "Checkin", "CheckinCheckedInIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult CheckinCheckedInIndex(
            [Bind()] CheckinContract contract,
            Guid? dillToDiffrentiateFromHttpGet
            ) {

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            List<FlightsOpenForCheckinWithDescriptionContract> flights =
                    new FlightSearchService().FlightsOpenForCheckinWithDescription(
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

            contract.PassengersCheckedIn =
                new PassengerSearchService().PassengersOnFlightCheckedIn(
                    contract.FlightId
                    );

            return View(
                MVCHelper.Resolve(Request, "Checkin", "CheckinCheckedInIndex"),
                contract
                );
        }
    }
}
