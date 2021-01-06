using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class DefaultUserActivityGroupedLiveController : Controller
    {

        [HttpGet]
        public ActionResult DefaultUserActivityGroupedIndex() {
            Logging.ActionLog(Request, "DefaultSearch" + " " + " " + "DefaultUserActivityGroupedIndex" + " ( ASP MVC WCF )");

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultUserActivityGroupedIndex.cshtml",
                new DefaultSearchServiceClient().DefaultUserActivityGrouped()
                );
        }

    }
}
