using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class FlightsForPeriodLiveController : Controller
    {

        [HttpGet]
        public ActionResult FlightsForPeriodIndex(
            [Bind()] FlightsForPeriodLiveContract contract
            ) {

            // get user id in order to trigger registration of user ( and hopefully fill the viewbag with user id )
            Logging.UserId(User.Identity, ViewBag);

            // default date's
            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = DateTime.UtcNow.Date.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsForPeriod(
                    Guid.Empty,
                    Guid.Empty,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightsForPeriodIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult FlightsForPeriodIndex([Bind()] FlightsForPeriodLiveContract contract, Guid? dill) {
            Guid userId = Logging.UserId(User.Identity, ViewBag);

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsForPeriod(
                    Guid.Empty,
                    Guid.Empty,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightsForPeriodIndex"),
                contract
                );
        }

        [HttpGet]
        public ActionResult FlightsForPeriodBookIndex([Bind()] FlightsForPeriodLiveContract contract) {

            // get user id in order to trigger registration of user ( and hopefully fill the viewbag with user id )
            Logging.UserId(User.Identity, ViewBag);

            // default date's
            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = DateTime.UtcNow.Date.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsForPeriod(
                    Guid.Empty,
                    Guid.Empty,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightsForPeriodBookIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult FlightsForPeriodBookIndex(
            [Bind()] FlightsForPeriodLiveContract contract,
            Guid? dillToDiffrentiateFromHttpGet
            ) {

            Guid userId = Logging.UserId(User.Identity, ViewBag);

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsForPeriod(
                    Guid.Empty,
                    Guid.Empty,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightsForPeriodBookIndex"),
                contract
                );
        }
    }
}
