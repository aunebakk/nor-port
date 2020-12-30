/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 6:38:42 AM
  From Machine: DESKTOP-LSRVP12
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

    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeFinancialCouponController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeFinancialCouponIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponIndex.cshtml",
                new CrudeFinancialCouponServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeFinancialCouponByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponIndex.cshtml",
                new CrudeFinancialCouponServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeFinancialCouponDetails(System.Guid financialCouponId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponDetails.cshtml",
                new CrudeFinancialCouponServiceClient().FetchByFinancialCouponId(financialCouponId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeFinancialCouponEdit(
            System.Guid financialCouponId
            ) {

            CrudeFinancialCouponContract contract = new CrudeFinancialCouponServiceClient().FetchByFinancialCouponId(financialCouponId);
            ViewBag.FinancialCouponTypeRcd =
                new SelectList( new CrudeFinancialCouponTypeRefServiceClient().FetchAll(),
                                "FinancialCouponTypeRcd",
                                "FinancialCouponTypeName",
                                contract.FinancialCouponTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCouponEdit([Bind()] CrudeFinancialCouponContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCouponServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCouponIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeFinancialCouponCreate(System.Guid? financialCurrencyId, System.Guid? userId) {
            var contract = new CrudeFinancialCouponContract();
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialCouponTypeRcd =
                new SelectList( new CrudeFinancialCouponTypeRefServiceClient().FetchAll(),
                                "FinancialCouponTypeRcd",
                                "FinancialCouponTypeName",
                                contract.FinancialCouponTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            contract.ValidFromDateTime = DateTime.UtcNow;

            contract.ValidUntilDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCouponCreate([Bind()] CrudeFinancialCouponContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCouponServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCouponIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeFinancialCouponDelete(
            System.Guid financialCouponId
            ) {
            new CrudeFinancialCouponServiceClient().Delete(financialCouponId);

            return RedirectToAction("CrudeFinancialCouponIndex");
        }
    }
}
