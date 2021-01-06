///*
//  SQL2X Generated code based on a SQL Server Schema
//  SQL2X Version: 0.d
//  http://sql2x.azurewebsites.net/
//  Generated Date: 8/14/2018 6:47:22 PM
//  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
//*/
//using SolutionNorSolutionPort.BusinessLogicLayer;
//using System;
//using System.Web.Mvc;

//namespace SolutionNorSolutionPort.AspMvc.Controllers {
//    public class CrudeClinicPatientController : Controller {

//        [HttpGet]
//        public ActionResult CrudeClinicPatientIndex() {

//            return View(
//                "~/Views/Crude/Clinic/CrudeClinicPatient/CrudeClinicPatientIndex.cshtml",
//                new CrudeClinicPatientServiceClient().FetchAll()
//                );
//        }

//        [HttpGet]
//        public ActionResult CrudeClinicPatientDetails(System.Guid clinicPatientId) {

//            return View(
//                "~/Views/Crude/Clinic/CrudeClinicPatient/CrudeClinicPatientDetails.cshtml",
//                new CrudeClinicPatientServiceClient().FetchByClinicPatientId(clinicPatientId)
//                );
//        }

//        [HttpGet]
//        public ActionResult CrudeClinicPatientEdit(
//            System.Guid clinicPatientId
//            ) {

//            CrudeClinicPatientContract contract = new CrudeClinicPatientServiceClient().FetchByClinicPatientId(clinicPatientId);

//            return View(
//                "~/Views/Crude/Clinic/CrudeClinicPatient/CrudeClinicPatientEdit.cshtml",
//                contract
//                );
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult CrudeClinicPatientEdit([Bind()] CrudeClinicPatientContract contract) {
//            if (ModelState.IsValid) {
//                contract.DateTime = DateTime.UtcNow;

//                new CrudeClinicPatientServiceClient().Update(contract);

//                return RedirectToAction("CrudeClinicPatientIndex");
//            }

//            return View(
//                "~/Views/Crude/Clinic/CrudeClinicPatient/CrudeClinicPatientEdit.cshtml",
//                contract
//                );
//        }

//        [HttpGet]
//        public ActionResult CrudeClinicPatientCreate(System.Guid? defaultUserId) {
//            var contract = new CrudeClinicPatientContract();
//            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

//            contract.DateTime = DateTime.UtcNow;


//            return View(
//                "~/Views/Crude/Clinic/CrudeClinicPatient/CrudeClinicPatientCreate.cshtml",
//                contract
//                );
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult CrudeClinicPatientCreate([Bind()] CrudeClinicPatientContract contract) {
//            if (ModelState.IsValid) {

//                contract.DefaultUserId = Guid.NewGuid();

//                new CrudeClinicPatientServiceClient().Insert(contract);

//                return RedirectToAction("CrudeClinicPatientIndex");
//            }

//            return View(
//                "~/Views/Crude/Clinic/CrudeClinicPatient/CrudeClinicPatientCreate.cshtml",
//                contract
//                );
//        }

//        [HttpGet]
//        public ActionResult CrudeClinicPatientDelete(
//            System.Guid clinicPatientId
//            ) {
//            new CrudeClinicPatientServiceClient().Delete(clinicPatientId);

//            return RedirectToAction("CrudeClinicPatientIndex");
//        }
//    }
//}
