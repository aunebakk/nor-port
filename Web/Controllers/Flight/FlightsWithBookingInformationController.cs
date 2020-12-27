using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class FlightsWithBookingInformationLiveController : Controller
    {

        [HttpGet]
        public ActionResult FlightsWithBookingInformationIndex(
            [Bind()] FlightsWithBookingInformationLiveContract contract
            ) {

            // get user id in order to trigger registration of user ( and hopefully fill the viewbag with user id )
            Logging.UserId(User.Identity, ViewBag);

            // default date's
            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = DateTime.UtcNow.Date.AddDays(1);

            contract.Flights =
                    new FlightSearchService().FlightsWithBookingInformation(
                        Guid.Empty,
                        Guid.Empty,
                        contract.FromDateTime,
                        contract.UntilDateTime
                    );
            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightsWithBookingInformationIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult FlightsWithBookingInformationIndex(
            [Bind()] FlightsWithBookingInformationLiveContract contract,
            Guid? dillToDiffrentiateFromHttpGet
            ) {

            Guid userId = Logging.UserId(User.Identity, ViewBag);

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsWithBookingInformation(
                    Guid.Empty,
                    Guid.Empty,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Flight", "FlightsWithBookingInformationIndex"),
                contract
                );
        }
    }
}
