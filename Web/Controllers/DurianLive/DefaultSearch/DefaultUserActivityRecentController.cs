/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 12/29/2018 11:35:17 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class DefaultUserActivityRecentLiveController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityRecentIndex(System.Guid defaultUserId) {

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultUserActivityRecentIndex.cshtml",
                new DefaultSearchServiceClient().DefaultUserActivityRecent(defaultUserId)
                );
        }

    }
}
