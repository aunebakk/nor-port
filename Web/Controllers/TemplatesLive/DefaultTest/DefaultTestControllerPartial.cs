using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public partial class DefaultTestController : Controller {
        [HttpGet]
        public ActionResult DefaultTestEditByDefaultTestId(
            System.Guid defaultTestId
            ) {

            //CrudeDefaultTestContract testContract =
            //    new CrudeDefaultTestServiceClient().
            //            DefaultTestCompleteGet(
            //                defaultTestId,
            //                new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
            //                );

            //Logging.ActionLog(Request, "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestEdit ( ASP MVC WCF )");

            //return View(
            //    "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestEdit.cshtml",
            //    testContract
            //    );
            return null;
        }

        [HttpGet]
        public ActionResult AddTest() {
            Logging.ActionLog(Request, "~/Views/Templates/DefaultTest/DefaultTest/AddTest ( ASP MVC WCF )");

            string urlReferrer = string.Empty;
            if (Request.UrlReferrer != null) {
                urlReferrer = Request.UrlReferrer.AbsoluteUri;
            }

            // save result of call
            try {
                new DefaultTestServiceClient().
                        AddTestRun(
                            "NorPort", "MVC", "ASPMenu",
                            urlReferrer,
                            DateTime.UtcNow, DateTime.UtcNow,
                            1,
                            DefaultTestRunResultRef.OK,
                            "new",
                            Logging.UserId(User.Identity, ViewBag)
                            );
            } catch (Exception ex) {
                Logging.ErrorLog("DefaultTestController", "AddTest", ex);
            }

            ViewBag.UrlReferrer = urlReferrer;

            return View(
                "~/Views/TemplatesLive/DefaultTest/DefaultTest/AddTest.cshtml"
                );

        }
    }
}
