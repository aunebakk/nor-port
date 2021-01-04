/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 4:59:40 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateChildCrudeOneToOneGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class AircraftCompartmentMeasurementController : Controller {

        [HttpGet]
        public ActionResult AircraftCompartmentMeasurementEdit(
            System.Guid aircraftCompartmentId
            ) {

            ViewBag.AircraftCompartmentId = aircraftCompartmentId;

            // get right-side primary key from left-side entity
            System.Guid aircraftCompartmentMeasurementId = new CrudeAircraftCompartmentServiceClient().FetchByAircraftCompartmentId(aircraftCompartmentId).AircraftCompartmentMeasurementId;

            // get right-side entity
            CrudeAircraftCompartmentMeasurementContract contract = new CrudeAircraftCompartmentMeasurementServiceClient().FetchByAircraftCompartmentMeasurementId(aircraftCompartmentMeasurementId);

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Templates/Aircraft/AircraftCompartmentMeasurement/AircraftCompartmentMeasurementEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AircraftCompartmentMeasurementEdit(
            [Bind()] CrudeAircraftCompartmentMeasurementContract contract,
            System.Guid aircraftCompartmentId
            ) {
            ViewBag.AircraftCompartmentId = aircraftCompartmentId;

            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                if (contract.AircraftCompartmentMeasurementId == Guid.Empty) {
                    // insert right-side entity
                    contract.AircraftCompartmentMeasurementId = Guid.NewGuid();
                    contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                    new CrudeAircraftCompartmentMeasurementServiceClient().Insert(contract);

                    // update left-side with right-side id
                    CrudeAircraftCompartmentContract aircraftCompartmentContract = new CrudeAircraftCompartmentServiceClient().FetchByAircraftCompartmentId(aircraftCompartmentId);
                    aircraftCompartmentContract.AircraftCompartmentMeasurementId = contract.AircraftCompartmentMeasurementId;
                    aircraftCompartmentContract.DateTime = DateTime.UtcNow;
                    aircraftCompartmentContract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                    new CrudeAircraftCompartmentServiceClient().Update(aircraftCompartmentContract);
                } else {
                    // update right-side entity
                    new CrudeAircraftCompartmentMeasurementServiceClient().Update(contract);
                }

            }

            return View(
                "~/Views/Templates/Aircraft/AircraftCompartmentMeasurement/AircraftCompartmentMeasurementEdit.cshtml",
                contract
                );
        }
    }
}
