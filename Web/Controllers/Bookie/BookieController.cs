using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookieController : Controller
    {

        [HttpGet]
        public ActionResult BookieSearchWithOrigin(
            string originRcd
            ) {

            CrudeAirportContract origin = new CrudeAirportServiceClient().FetchByAirportName(originRcd);

            var contract = new BookieContract();
            contract.DepartureAirportId = origin.AirportId;
            contract.FromDateTime = DateTime.UtcNow.Date;
            contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            contract.Flights =
                new FlightSearchService().FlightsForBookingWithFare(
                    contract.DepartureAirportId,
                    contract.ArrivalAirportId,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Bookie", "BookieSearch"),
                contract
                );
        }

        [HttpGet]
        public ActionResult BookieIndex(
            [Bind()] BookieContract contract,
            System.Guid? airportId
            ) {

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            List<AirportsAvailableWithFilterContract> airports =
                    new FlightSearchService().AirportsAvailableWithFilter(
                             Guid.Empty
                            , Guid.Empty
                            , contract.FromDateTime
                            , contract.UntilDateTime
                            );

            if ( airportId == null && airports.Count > 1 ) {
                contract.DepartureAirportId = airports[1].AirportId;
            }

            ViewBag.DepartureAirportId =
                new SelectList(
                    airports,
                    "AirportId",
                    "AirportName",
                    contract.DepartureAirportId
                    );

            ViewBag.ArrivalAirportId =
                new SelectList(
                    airports,
                    "AirportId",
                    "AirportName",
                    contract.ArrivalAirportId
                    );

            contract.Flights =
                new FlightSearchService().FlightsForBookingWithFare(
                    contract.DepartureAirportId,
                    contract.ArrivalAirportId,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Bookie", "BookieIndex"),
                contract
                );
        }

        [HttpPost]
        public ActionResult BookieIndex(
            [Bind()] BookieContract contract,
            System.Guid? airportId,
            Guid? dillToDiffrentiateFromHttpGet
            ) {

            if ( contract.FromDateTime == DateTime.MinValue )
                contract.FromDateTime = DateTime.UtcNow.Date;

            if ( contract.UntilDateTime == DateTime.MinValue )
                contract.UntilDateTime = contract.FromDateTime.AddDays(1);

            List<AirportsAvailableWithFilterContract> airports =
                    new FlightSearchService().AirportsAvailableWithFilter(
                             Guid.Empty
                            , Guid.Empty
                            , contract.FromDateTime
                            , contract.UntilDateTime
                            );

            //if (airportId == null && airports.Length > 0)
            //    contract.DepartureAirportId = airports[0].AirportId;

            ViewBag.DepartureAirportId =
                new SelectList(
                    airports,
                    "AirportId",
                    "AirportName",
                    contract.DepartureAirportId
                    );

            ViewBag.ArrivalAirportId =
                new SelectList(
                    airports,
                    "AirportId",
                    "AirportName",
                    contract.ArrivalAirportId
                    );

            contract.Flights =
                new FlightSearchService().FlightsForBookingWithFare(
                    contract.DepartureAirportId,
                    contract.ArrivalAirportId,
                    contract.FromDateTime,
                    contract.UntilDateTime
                    );

            return View(
                MVCHelper.Resolve(Request, "Bookie", "BookieIndex"),
                contract
                );
        }
    }

    public class BookieContract
    {
        public DateTime FromDateTime { get; set; }
        public DateTime UntilDateTime { get; set; }
        public Guid DepartureAirportId { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public List<FlightsForBookingWithFareContract> Flights { get; set; }
    }
}
