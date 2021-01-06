using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class ServicePackagePromotionWithFilterLiveController : Controller
    {

        [HttpGet]
        public ActionResult ServicePackagePromotionWithFilterIndex() {
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackagePromotionWithFilterIndex"),
                new ServiceSearchServiceClient().ServicePackagePromotionWithFilter(Guid.Empty)
                );
        }

        [HttpGet]
        public ActionResult ServicePackagePromotionSend(
            Guid servicePackagePromotionId
            ) {
            CrudeServicePackageContract contract = 
                new CrudeServicePackageServiceClient().FetchByServicePackageId(
                    servicePackagePromotionId
                    );

            new ServiceServiceClient().PromotionSend(
                servicePackagePromotionId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackagePromotionSend")
                );
        }

        [HttpGet]
        public ActionResult ServicePackagePromotionMakeBooking(
            Guid servicePackagePromotionId
            ) {
            CrudeServicePackageContract contract = 
                new CrudeServicePackageServiceClient().FetchByServicePackageId(
                    servicePackagePromotionId
                    );

            new ServiceServiceClient().PromotionMakeBooking(
                servicePackagePromotionId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackagePromotionMake")
                );
        }
    }
}
