/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:32:25 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.ControllerForChild
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class AirlineAirlineContactMethodController : Controller {

        [HttpGet]
        public ActionResult AirlineContactMethodIndex() {

            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodIndex",
                new CrudeAirlineContactMethodServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult AirlineContactMethodByAirlineIndex(System.Guid airlineId) {
            ViewBag.AirlineId = airlineId;

            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodIndex",
                new CrudeAirlineContactMethodServiceClient().FetchByAirlineId(airlineId)
                );
        }

        [HttpGet]
        public ActionResult AirlineContactMethodDetails(System.Guid airlineContactMethodId) {


            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodDetails",
                new CrudeAirlineContactMethodServiceClient().FetchByAirlineContactMethodId(airlineContactMethodId)
                );
        }

        [HttpGet]
        public ActionResult AirlineContactMethodEdit(System.Guid airlineContactMethodId) {
            CrudeAirlineContactMethodContract contract =
                new CrudeAirlineContactMethodServiceClient().FetchByAirlineContactMethodId(airlineContactMethodId);

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.ContactMethodRcd =
                new SelectList( new CrudeContactMethodRefServiceClient().FetchAll(),
                                "ContactMethodRcd",
                                "ContactMethodName",
                                contract.ContactMethodRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodEdit",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirlineContactMethodEdit([Bind()] CrudeAirlineContactMethodContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeAirlineContactMethodServiceClient().Update(contract);

                return RedirectToAction("AirlineEdit", "Airline", new { airlineId = contract.AirlineId } );
            }

            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodEdit",
                contract
                );
        }

        [HttpGet]
        public ActionResult AirlineContactMethodCreate(System.Guid? airlineId, System.Guid? userId) {
            var contract = new CrudeAirlineContactMethodContract();
            if (airlineId != null) contract.AirlineId = (System.Guid) airlineId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.ContactMethodRcd =
                new SelectList( new CrudeContactMethodRefServiceClient().FetchAll(),
                                "ContactMethodRcd",
                                "ContactMethodName",
                                contract.ContactMethodRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodCreate",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirlineContactMethodCreate([Bind()] CrudeAirlineContactMethodContract contract) {
            if (ModelState.IsValid) {

                new CrudeAirlineContactMethodServiceClient().Insert(contract);

                return RedirectToAction("AirlineEdit", "Airline", new { airlineId = contract.AirlineId } );
            }

            return View(
                "~/Views/Templates/Airline/Airline/AirlineContactMethod/AirlineContactMethodCreate",
                contract
                );
        }
    }
}
