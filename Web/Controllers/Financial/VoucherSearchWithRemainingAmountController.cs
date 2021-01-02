using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class VoucherSearchWithRemainingAmountLiveController : Controller
    {

        [HttpGet]
        public ActionResult VoucherSearchWithRemainingAmountIndex() {
            return View(
                MVCHelper.Resolve(Request, "Financial", "VoucherSearchWithRemainingAmountIndex"),
                new FinancialSearchServiceClient().VoucherSearchWithRemainingAmount(DateTime.MinValue)
                );
        }

    }
}
