using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class DefaultUserActivityGroupedByAddressLiveController : Controller
    {

        [HttpGet]
        public ActionResult DefaultUserActivityGroupedByAddressIndex() {
            Logging.ActionLog(Request, "DefaultSearch DefaultUserActivityGroupedByAddressIndex ( ASP MVC WCF )");

            return View(
                "~/Views/DurianLive/DefaultSearch/DefaultUserActivityGroupedByAddressIndex.cshtml",
                new DefaultSearchServiceClient().DefaultUserActivityGroupedByAddress()
                );
        }

    }
}
