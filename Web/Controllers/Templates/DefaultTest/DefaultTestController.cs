/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 1/15/2019 5:16:58 AM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
  SQL2XCreatorDirective: DoNotLetTemplateOverwriteThisFile
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public partial class DefaultTestController : Controller {

        [HttpGet]
        public ActionResult DefaultTestIndex() {

            return RedirectToAction(
                    "DefaultTestEditByDefaultTestId",
                    new {    defaultTestId = Guid.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult DefaultTestEdit(
            ) {

            //DefaultTestContract testContract =
            //    new DefaultTestServiceClient().
            //            DefaultTestCompleteGet(
            //                Guid.Empty,
            //                new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
            //                );


            //return View(
            //    "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestEdit.cshtml",
            //    testContract
            //    );
            return null;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultTestEdit(
            [Bind()] CrudeDefaultTestContract testContract
            ) {
            //new DefaultTestServiceClient().
            //        DefaultTestCompleteUpdate(
            //            Guid.Empty,
            //            testContract,
            //            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
            //            );

            return RedirectToAction(
                    "DefaultTestEdit",
                    new { defaultTestId = Guid.Empty }
                    );
        }

        [HttpGet]
        public ActionResult DefaultTestCreate(System.Guid? userId) {
            var testContract = new CrudeDefaultTestContract();
            //testContract.DefaultTestNew = new CrudeDefaultTestContract();
            //if (userId != null) testContract.DefaultTestNew.UserId = (System.Guid)userId;

            //if (userId == null)
            //    testContract.DefaultTestNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            //ViewBag.DefaultUserName =
            //    new CrudeDefaultUserServiceClient().FetchByDefaultUserId(testContract.DefaultTestNew.UserId).DefaultUserName;

            //testContract.DefaultTestNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestCreate.cshtml",
                testContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultTestCreate([Bind()] CrudeDefaultTestContract testContract) {
            if (ModelState.IsValid) {

                //new CrudeDefaultTestServiceClient().Insert(testContract.DefaultTestNew);

                return RedirectToAction(
                        "DefaultTestEdit",
                        new { defaultTestId = Guid.Empty }
                        );
            }

            return View(
                "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestCreate.cshtml",
                testContract
                );
        }

    }
}
