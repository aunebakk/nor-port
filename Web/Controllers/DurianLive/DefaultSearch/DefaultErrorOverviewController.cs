using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class DefaultErrorOverviewLiveController : Controller
    {

        [HttpGet]
        public ActionResult DefaultErrorOverviewIndex() {
            Logging.ActionLog(Request, "DefaultSearch" + " " + "DefaultErrorOverviewIndex" + " ( ASP MVC WCF )");

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultErrorOverviewIndex.cshtml",
                new DefaultSearchService().DefaultErrorOverview()
                );
        }

    }
}
