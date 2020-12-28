using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class FinancialVoucherController : Controller
    {

        [HttpGet]
        public ActionResult FinancialVoucherEdit(System.Guid financialVoucherId) {
            CrudeFinancialVoucherContract contract = new CrudeFinancialVoucherServiceClient().FetchByFinancialVoucherId(financialVoucherId);
            ViewBag.FinancialVoucherTypeRcd =
                new SelectList(new CrudeFinancialVoucherTypeRefServiceClient().FetchAll(),
                                "FinancialVoucherTypeRcd",
                                "FinancialVoucherTypeName",
                                contract.FinancialVoucherTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList(new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                "~/Views/Financial/FinancialVoucherEdit.cshtml",
                contract
                );
        }
    }
}
