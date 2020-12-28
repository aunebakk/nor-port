using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.AspMvc.Controllers;

namespace SolutionNorSolutionPort.Controllers.Default
{
    public class DefaultIssueWithFilterLiveController : Controller
    {
        [HttpGet]
        public ActionResult DefaultIssueWithFilterIndex(
            string defaultIssueTypeRcd,
            string defaultIssueStatusRcd
            )
        {
            if (defaultIssueStatusRcd == null)
                defaultIssueStatusRcd = DefaultIssueStatusRef.ToBeResolved;

            ViewBag.DefaultIssueStatusRcd =
                new SelectList(
                    new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName",
                    defaultIssueStatusRcd
                    );

            Logging.ActionLog(
                Request,
                "Default DefaultIssueWithFilter DefaultIssueWithFilterIndex ( ASP MVC WCF )"
                );

            return View(
                "~/Views/Default/DefaultIssueWithFilter/DefaultIssueWithFilterIndex.cshtml",
                new DefaultSearchService().DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultIssueWithFilterIndex(
            [Bind] DefaultIssueWithFilterContract contract,
            string defaultIssueTypeRcd,
            string defaultIssueStatusRcd
            )
        {
            ViewBag.DefaultIssueStatusRcd =
                new SelectList(
                    new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName"
                    );

            return View(
                "~/Views/Default/DefaultIssueWithFilterLive/DefaultIssueWithFilterIndex.cshtml",
                new DefaultSearchService().DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd)
                );
        }
    }
}
