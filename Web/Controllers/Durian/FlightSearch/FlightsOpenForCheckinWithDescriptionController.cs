/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:49:15 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class FlightsOpenForCheckinWithDescriptionController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8bae4bc2-d317-474f-9717-7963ab03f019
        [HttpGet]
        public ActionResult FlightsOpenForCheckinWithDescriptionIndex(System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {

            return View(
                "~/Views/Durian/FlightSearch/FlightsOpenForCheckinWithDescriptionIndex.cshtml",
                new FlightSearchService().FlightsOpenForCheckinWithDescription(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime)
                );
        }

    }
}
