/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:00:41 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPort.AspMvc.Controllers {

    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/bc619e06-279f-4682-825d-3d1aef43067f
    public class CrudeServicePackagePromotionController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionIndex() {

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionIndex.cshtml",
                new CrudeServicePackagePromotionServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionByServicePackageIndex(System.Guid servicePackageId) {
            ViewBag.ServicePackageId = servicePackageId;

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionIndex.cshtml",
                new CrudeServicePackagePromotionServiceClient().FetchByServicePackageId(servicePackageId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionIndex.cshtml",
                new CrudeServicePackagePromotionServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionIndex.cshtml",
                new CrudeServicePackagePromotionServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionDetails(System.Guid servicePackagePromotionId) {

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionDetails.cshtml",
                new CrudeServicePackagePromotionServiceClient().FetchByServicePackagePromotionId(servicePackagePromotionId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionEdit(
            System.Guid servicePackagePromotionId
            ) {

            CrudeServicePackagePromotionContract contract = new CrudeServicePackagePromotionServiceClient().FetchByServicePackagePromotionId(servicePackagePromotionId);
            ViewBag.ServicePackageId =
                new SelectList( new CrudeServicePackageServiceClient().FetchAll(),
                                "ServicePackageId",
                                "ServicePackageName",
                                contract.ServicePackageId
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeServicePackagePromotionEdit([Bind()] CrudeServicePackagePromotionContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeServicePackagePromotionServiceClient().Update(contract);

                return RedirectToAction("CrudeServicePackagePromotionIndex");
            }

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionCreate(System.Guid? servicePackageId, System.Guid? financialCurrencyId, System.Guid? userId, System.Guid? bookingId, System.Guid? clientId) {
            var contract = new CrudeServicePackagePromotionContract();
            if (servicePackageId != null) contract.ServicePackageId = (System.Guid) servicePackageId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (bookingId != null) contract.BookingId = (System.Guid) bookingId;
            if (clientId != null) contract.ClientId = (System.Guid) clientId;

            ViewBag.ServicePackageId =
                new SelectList( new CrudeServicePackageServiceClient().FetchAll(),
                                "ServicePackageId",
                                "ServicePackageName",
                                contract.ServicePackageId
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );


            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeServicePackagePromotionCreate([Bind()] CrudeServicePackagePromotionContract contract) {
            if (ModelState.IsValid) {

                new CrudeServicePackagePromotionServiceClient().Insert(contract);

                return RedirectToAction("CrudeServicePackagePromotionIndex");
            }

            return View(
                "~/Views/Crude/Service/CrudeServicePackagePromotion/CrudeServicePackagePromotionCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeServicePackagePromotionDelete(
            System.Guid servicePackagePromotionId
            ) {
            new CrudeServicePackagePromotionServiceClient().Delete(servicePackagePromotionId);

            return RedirectToAction("CrudeServicePackagePromotionIndex");
        }
    }
}
