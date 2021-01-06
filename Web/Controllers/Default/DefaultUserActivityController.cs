using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    public class DefaultUserActivityController : Controller
    {
        // GET: DefaultUserActivity
        public ActionResult Index()
        {
            return View();
        }

        // GET: ResolveNetnameFromIpV4
        public ActionResult ResolveNetnameFromIpV4(string ipAddress) {
            ViewBag.IpAddress = ipAddress;

            ViewBag.NetName = new SolutionNorSolutionPort.BusinessLogicLayer.DefaultUserActivityServiceClient().ResolveNetnameFromIpV4(ipAddress);

            if (String.IsNullOrEmpty(ViewBag.NetName)) {
                ViewBag.NetName = "*Not found*";
            }

            Logging.ActionLog(Request, "DefaultSearch" + " " + " " + "ResolveNetnameFromIpV4" + " ( ASP MVC WCF )");

            return View();
        }
    }
}
