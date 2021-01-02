using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class SpecialServiceRequestController : Controller
    {

        [HttpGet]
        public ActionResult SpecialServiceRequestIndex() {
            return View(
                MVCHelper.Resolve(Request, "Service", "SpecialServiceRequestIndex"),
                new ServiceSearchServiceClient().FetchServiceSpecialServiceRequestWithFilter(
                    String.Empty, String.Empty, String.Empty, String.Empty, String.Empty)
                );
        }

        [HttpGet]
        public ActionResult ServiceSpecialServiceRequestEdit(System.Guid serviceSpecialServiceRequestId) {
            CrudeServiceSpecialServiceRequestContract contract = 
                new CrudeServiceSpecialServiceRequestServiceClient().
                FetchByServiceSpecialServiceRequestId(serviceSpecialServiceRequestId);

            ViewBag.ServiceSpecialServiceRequestGroupRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestGroupRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestGroupRcd",
                                "ServiceSpecialServiceRequestGroupName",
                                contract.ServiceSpecialServiceRequestGroupRcd
                                );

            ViewBag.FinancialCurrencyId =
                    new SelectList(new FinancialSearchServiceClient().
                                        GetAvailableCurrencies(
                                            Guid.Empty,
                                            DateTime.UtcNow
                                            ),
                                    "FinancialCurrencyId",
                                    "FinancialCurrencyTypeName",
                                    contract.FinancialCurrencyId
                                    );
            /*
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(), 
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );
            */
            ViewBag.RequestServiceSpecialServiceRequestRequirementRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestRequirementRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestRequirementRcd",
                                "ServiceSpecialServiceRequestRequirementName",
                                contract.RequestServiceSpecialServiceRequestRequirementRcd
                                );

            ViewBag.ReplyServiceSpecialServiceRequestRequirementRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestRequirementRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestRequirementRcd",
                                "ServiceSpecialServiceRequestRequirementName",
                                contract.ReplyServiceSpecialServiceRequestRequirementRcd
                                );

            ViewBag.ServiceSpecialServiceRequestOperationRuleRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestOperationRuleRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestOperationRuleRcd",
                                "ServiceSpecialServiceRequestOperationRuleName",
                                contract.ServiceSpecialServiceRequestOperationRuleRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Service", "ServiceSpecialServiceRequest", "ServiceSpecialServiceRequestEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServiceSpecialServiceRequestEdit([Bind()] CrudeServiceSpecialServiceRequestContract contract) {
            if ( ModelState.IsValid ) {
                new CrudeServiceSpecialServiceRequestServiceClient().Update(contract);

                return RedirectToAction("SpecialServiceRequestIndex");
            }

            return View(
                MVCHelper.Resolve(Request, "Service", "ServiceSpecialServiceRequest", "ServiceSpecialServiceRequestEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ServiceSpecialServiceRequestCreate(System.Guid? financialCurrencyId, System.Guid? userId) {
            var contract = new CrudeServiceSpecialServiceRequestContract();
            if ( financialCurrencyId != null )
                contract.FinancialCurrencyId = ( System.Guid ) financialCurrencyId;
            if ( userId != null )
                contract.UserId = ( System.Guid ) userId;

            ViewBag.ServiceSpecialServiceRequestGroupRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestGroupRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestGroupRcd",
                                "ServiceSpecialServiceRequestGroupName",
                                contract.ServiceSpecialServiceRequestGroupRcd
                                );
            /*
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(), 
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );
            */
            ViewBag.FinancialCurrencyId =
                    new SelectList(new FinancialSearchServiceClient().
                                        GetAvailableCurrencies(
                                            Guid.Empty,
                                            DateTime.UtcNow
                                            ),
                                    "FinancialCurrencyId",
                                    "FinancialCurrencyTypeName",
                                    contract.FinancialCurrencyId
                                    );

            ViewBag.RequestServiceSpecialServiceRequestRequirementRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestRequirementRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestRequirementRcd",
                                "ServiceSpecialServiceRequestRequirementName",
                                contract.RequestServiceSpecialServiceRequestRequirementRcd
                                );

            ViewBag.ReplyServiceSpecialServiceRequestRequirementRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestRequirementRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestRequirementRcd",
                                "ServiceSpecialServiceRequestRequirementName",
                                contract.ReplyServiceSpecialServiceRequestRequirementRcd
                                );

            ViewBag.ServiceSpecialServiceRequestOperationRuleRcd =
                new SelectList(new CrudeServiceSpecialServiceRequestOperationRuleRefServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestOperationRuleRcd",
                                "ServiceSpecialServiceRequestOperationRuleName",
                                contract.ServiceSpecialServiceRequestOperationRuleRcd
                                );

            if ( userId == null )
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Service", "ServiceSpecialServiceRequest", "ServiceSpecialServiceRequestCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServiceSpecialServiceRequestCreate([Bind()] CrudeServiceSpecialServiceRequestContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeServiceSpecialServiceRequestServiceClient().Insert(contract);

                return RedirectToAction("SpecialServiceRequestIndex");
            }

            return View(
                MVCHelper.Resolve(Request, "Service", "ServiceSpecialServiceRequest", "ServiceSpecialServiceRequestCreate"),
                contract
                );
        }
    }
}
