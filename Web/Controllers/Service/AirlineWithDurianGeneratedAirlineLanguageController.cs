using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class AirlineWithDurianGeneratedAirlineLanguageController : Controller {

        [HttpGet]
        public ActionResult AirlineLanguageIndex() {
            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageIndex"),
                new CrudeAirlineLanguageServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult AirlineLanguageByAirlineIndex(System.Guid airlineId) {
            ViewBag.AirlineId = airlineId;
            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageIndex"),
                new CrudeAirlineLanguageServiceClient().FetchByAirlineId(airlineId)
                );
        }

        [HttpGet]
        public ActionResult AirlineLanguageDetails(System.Guid airlineLanguageId) {
            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageDetails"),
                new CrudeAirlineLanguageServiceClient().FetchByAirlineLanguageId(airlineLanguageId)
                );
        }

        [HttpGet]
        public ActionResult AirlineLanguageEdit(System.Guid airlineLanguageId) {
            CrudeAirlineLanguageContract contract =
                new CrudeAirlineLanguageServiceClient().FetchByAirlineLanguageId(airlineLanguageId);

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.LanguageRcd =
                new SelectList( new CrudeLanguageRefServiceClient().FetchAll(),
                                "LanguageRcd",
                                "LanguageName",
                                contract.LanguageRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirlineLanguageEdit([Bind()] CrudeAirlineLanguageContract contract) {
            if (ModelState.IsValid) {
                new CrudeAirlineLanguageServiceClient().Update(contract);

                return RedirectToAction("AirlineWithDurianGeneratedEdit", "AirlineWithDurianGenerated", new { airlineId = contract.AirlineId } );
            }

            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult AirlineLanguageCreate(System.Guid? airlineId, System.Guid? userId) {
            var contract = new CrudeAirlineLanguageContract();
            if (airlineId != null) contract.AirlineId = (System.Guid) airlineId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.LanguageRcd =
                new SelectList( new CrudeLanguageRefServiceClient().FetchAll(),
                                "LanguageRcd",
                                "LanguageName",
                                contract.LanguageRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirlineLanguageCreate([Bind()] CrudeAirlineLanguageContract contract) {
            if (ModelState.IsValid) {

                new CrudeAirlineLanguageServiceClient().Insert(contract);

                return RedirectToAction("AirlineWithDurianGeneratedEdit", "AirlineWithDurianGenerated", new { airlineId = contract.AirlineId } );
            }

            return View(
                MVCHelper.Resolve(Request, "Airline", "AirlineWithDurianGenerated\\AirlineLanguage", "AirlineLanguageCreate"),
                contract
                );
        }
    }
}
