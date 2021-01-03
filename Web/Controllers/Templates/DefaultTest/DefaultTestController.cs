/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:33:02 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public partial class DefaultTestController : Controller {

        [HttpGet]
        public ActionResult DefaultTestIndex() {

            return RedirectToAction(
                    "DefaultTestEdit",
                    new {    defaultTestId = Guid.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult DefaultTestCreate(System.Guid? userId) {
            var testContract = new DefaultTestContract();
            testContract.DefaultTestNew = new CrudeDefaultTestContract();
            if (userId != null) testContract.DefaultTestNew.UserId = (System.Guid) userId;

            testContract.DefaultTestNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestCreate.cshtml",
                testContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultTestCreate([Bind()] DefaultTestContract testContract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestServiceClient().Insert(testContract.DefaultTestNew);

                return RedirectToAction(
                        "DefaultTestEdit",
                        new {    defaultTestId = Guid.Empty}
                        );
            }

            return View(
                "~/Views/Templates/DefaultTest/DefaultTest/DefaultTestCreate.cshtml",
                testContract
                );
        }

    }
}
