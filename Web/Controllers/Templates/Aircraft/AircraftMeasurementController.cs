/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 7:53:08 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateChildCrudeOneToOneGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class AircraftMeasurementController : Controller {

        [HttpGet]
        public ActionResult AircraftMeasurementEdit(
            System.Guid aircraftId
            ) {

            ViewBag.AircraftId = aircraftId;

            // get right-side primary key from left-side entity
            System.Guid aircraftMeasurementId = new CrudeAircraftServiceClient().FetchByAircraftId(aircraftId).AircraftMeasurementId;

            // get right-side entity
            CrudeAircraftMeasurementContract contract = new CrudeAircraftMeasurementServiceClient().FetchByAircraftMeasurementId(aircraftMeasurementId);

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Templates/Aircraft/AircraftMeasurement/AircraftMeasurementEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftMeasurementEdit(
            [Bind()] CrudeAircraftMeasurementContract contract,
            System.Guid aircraftId
            ) {
            ViewBag.AircraftId = aircraftId;

            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                if (contract.AircraftMeasurementId == Guid.Empty) {
                    // insert right-side entity
                    contract.AircraftMeasurementId = Guid.NewGuid();
                    contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                    new CrudeAircraftMeasurementServiceClient().Insert(contract);

                    // update left-side with right-side id
                    CrudeAircraftContract aircraftContract = new CrudeAircraftServiceClient().FetchByAircraftId(aircraftId);
                    aircraftContract.AircraftMeasurementId = contract.AircraftMeasurementId;
                    aircraftContract.DateTime = DateTime.UtcNow;
                    aircraftContract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                    new CrudeAircraftServiceClient().Update(aircraftContract);
                } else {
                    // update right-side entity
                    new CrudeAircraftMeasurementServiceClient().Update(contract);
                }

            }

            return View(
                "~/Views/Templates/Aircraft/AircraftMeasurement/AircraftMeasurementEdit.cshtml",
                contract
                );
        }
    }
}
