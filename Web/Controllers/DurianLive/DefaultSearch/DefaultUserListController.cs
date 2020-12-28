using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class DefaultUserListLiveController : Controller
    {
        [HttpGet]
        public ActionResult LoginImpersonate(
            string userCode
            ) {
            Guid userId = new DefaultUserActivityServiceClient().Login(userCode);

            Logging.ActionLog(Request, "DefaultSearch DefaultUserListIndex ( ASP MVC WCF )");

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultUserListIndex.cshtml",
                new DefaultSearchService().DefaultUserList()
                );
        }

        [HttpGet]
        public ActionResult LoginOverrideUserName(
            string userCode
            ) {
            Guid userId = new DefaultUserActivityServiceClient().LoginOverrideUserName(userCode);

            Logging.ActionLog(Request, "DefaultSearch DefaultUserListIndex ( ASP MVC WCF )");

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultUserListIndex.cshtml",
                new DefaultSearchService().DefaultUserList()
                );
        }

        [HttpGet]
        public ActionResult DefaultUserListIndex() {
            Logging.ActionLog(Request, "DefaultSearch DefaultUserListIndex ( ASP MVC WCF )");

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultUserListIndex.cshtml",
                new DefaultSearchService().DefaultUserList()
                );
        }
    }
}
