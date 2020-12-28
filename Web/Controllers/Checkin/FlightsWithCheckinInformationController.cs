using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class FlightsWithCheckinInformationLiveController : Controller
    {

        [HttpGet]
        public ActionResult FlightsWithCheckinInformationIndex(
            [Bind()] FlightsWithCheckinInformationLiveContract contract
            ) {

            // get user id in order to trigger registration of user ( and hopefully fill the viewbag with user id )
            Logging.UserId(User.Identity, ViewBag);

            // default date's
            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = DateTime.UtcNow.Date.AddDays(1);

            contract.Flights =
                    new FlightSearchService().FlightsWithCheckinInformation(
                        Guid.Empty,
                        Guid.Empty,
                        contract.FromDateTime,
                        contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Checkin", "FlightsWithCheckinInformationIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult FlightsWithCheckinInformationIndex(
            [Bind()] FlightsWithCheckinInformationLiveContract contract,
            Guid? dillToDiffrentiateFromHttpGet
            ) {

            Guid userId = Logging.UserId(User.Identity, ViewBag);

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsWithCheckinInformation(
                    Guid.Empty,
                    Guid.Empty,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Checkin", "FlightsWithCheckinInformationIndex"),
                contract
                );
        }
    }

    public class FlightsWithCheckinInformationLiveContract
    {
        public DateTime FromDateTime { get; set; }
        public DateTime UntilDateTime { get; set; }
        public List<FlightsWithCheckinInformationContract> Flights { get; set; }

    }
}
