using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.AspMvc.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XXPrototypeDotNetFrameworkWebAppMvcAndOAuthCrudeAspMvc.Controllers {
    [RequireHttps]
    public class HomeController : Controller {

        public ActionResult Checkin() {
            Logging.ActionLog(Request, "WinForm Checkin");

            return Redirect("~/install/Checkin/PrototypeDotNetFrameworkWinExeCheckin.application");
        }

        public ActionResult Applications() {
            return View();
        }

        public ActionResult Booking(Guid bookingId) {
            Logging.ActionLog(Request, "WinForm Booking");

            return Redirect("~/install/Booking/PrototypeDotNetFrameworkWinExeBooking.application?bookingId=" + bookingId.ToString());
        }

        /// <summary>
        /// fill viewbag with error info to show from Shared/error.cshtml
        /// </summary>
        /// <param name="defaultErrorId"></param>
        /// <returns></returns>
        public ActionResult error(
            Guid? defaultErrorId
            ) {

            var error = new CrudeDefaultErrorContract();

            try {
                error = new CrudeDefaultErrorServiceClient().FetchByDefaultErrorId((Guid)defaultErrorId);
                if (error.DefaultErrorId != Guid.Empty)
                    ViewBag.ExceptionMessage = error.ErrorMessage + "\r\n" + error.StackTrace;
            } catch { }

            ViewBag.DefaultErrorId = defaultErrorId;

            return View();
        }

        public ActionResult SystemInformation() {
            Logging.ActionLog(Request, "System Information", ViewBag);

            Process myProcess = Process.GetCurrentProcess();
            long workingSet = myProcess.WorkingSet64 / 1024 / 1024;

            ViewBag.SoapWorkingSet = new DiagnosticsServiceClient().WorkingSet();
            ViewBag.WorkingSet = workingSet;

            var measurement = new CrudeDefaultResourceMeasurementContract();
            measurement.BusinessWorkingsetBytes = ((int)ViewBag.SoapWorkingSet) * 1024 * 1024;
            measurement.ClientWorkingsetBytes = (int)myProcess.WorkingSet64;
            measurement.DatabaseSizeBytes = new DefaultSearchServiceClient().DefaultResourceDatabaseStatistics()[0].ReservedPageCount * 1024;
            measurement.DefaultUserId = Logging.UserId(User.Identity, ViewBag);
            measurement.DateTime = DateTime.UtcNow;

            ViewBag.DatabaseSizeBytes = measurement.DatabaseSizeBytes;
            ViewBag.DatabaseSizeMBytes = measurement.DatabaseSizeBytes / 1024 / 1024;

            new CrudeDefaultResourceMeasurementServiceClient().Insert(measurement);

            return View();
        }

        public ActionResult Documentation() {
            Logging.ActionLog(Request, "Documentation");

            return Redirect("~/documentation/_Index.html");
        }

        public ActionResult WinForm() {
            Logging.ActionLog(Request, "About WinForm");

            return Redirect("~/install/publish.htm");
        }

        public ActionResult Index () {
            return View ();
        }

        public ActionResult About () {
            ViewBag.Message = "Your application description page.";

            return View ();
        }

        public ActionResult Maintenance() {
            ViewBag.Message = "Maintenance";

            return View();
        }

        public ActionResult Durians() {
            ViewBag.Message = "Durians";

            return View();
        }

        public ActionResult Splash () {
            Response.Redirect ( "~/Documentation/Splash2.html", true );

            return null;
        }

        public ActionResult API () {
            return View ();
        }

        public ActionResult CreateIssue (
            string from
            ) {
            Logging.ActionLog ( Request , "Create Issue" );

            //// save result of call
            //new DefaultTestServiceClient().
            //    AddTestRun(
            //        "SolutionNorPort", "MVC", from,
            //        Request.UrlReferrer.AbsoluteUri,
            //        DateTime.UtcNow, DateTime.UtcNow,
            //        1,
            //        DefaultTestRunResultRef.OK,
            //        string.Empty,
            //        Logging.UserId(User.Identity, ViewBag)
            //    );

            return RedirectToAction (
                "DefaultIssueCreateWithUrl" ,
                "DefaultIssue" ,
                new {
                    fromUrl = Request.UrlReferrer.AbsoluteUri ,
                    defaultUserId = Logging.UserId(User.Identity, ViewBag)
                }
                );
        }
    }
}
