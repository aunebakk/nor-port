using System;
using System.Diagnostics;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Dashboard () {
            return View ();
        }

        public ActionResult DashboardInfo () {
            return View ();
        }

        public ActionResult Splash () {
            return View ( );
        }

    }
}
