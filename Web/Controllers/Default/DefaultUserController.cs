using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers { 
    public class DefaultUserController : Controller
    {
        [HttpGet]
        public ActionResult DefaultUserIndex() {
            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserIndex"),
                new CrudeDefaultUserServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult DefaultUserByCreatedByDefaultUserIndex(System.Guid createdByDefaultUserId) {
            ViewBag.CreatedByDefaultUserId = createdByDefaultUserId;
            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserIndex"),
                new CrudeDefaultUserServiceClient().FetchByCreatedByDefaultUserId(createdByDefaultUserId)
                );
        }

        [HttpGet]
        public ActionResult DefaultUserDetails(System.Guid defaultUserId) {
            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserDetails"),
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId)
                );
        }

        [HttpGet]
        public ActionResult DefaultUserEdit(System.Guid defaultUserId) {
            CrudeDefaultUserContract contract = new CrudeDefaultUserServiceClient().FetchByDefaultUserId(defaultUserId);
            ViewBag.DefaultStateRcd =
                new SelectList(new CrudeDefaultStateRefServiceClient().FetchAll(),
                                "DefaultStateRcd",
                                "DefaultStateName",
                                contract.DefaultStateRcd
                                );

            ViewBag.CreatedByDefaultUserId =
                new SelectList(new CrudeDefaultUserServiceClient().FetchAll(),
                                "DefaultUserId",
                                "DefaultUserName",
                                contract.CreatedByDefaultUserId
                                );

            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultUserEdit([Bind()] CrudeDefaultUserContract contract) {
            if ( ModelState.IsValid ) {
                contract.DateTime = DateTime.UtcNow;
                contract.LastActivityDateTime = DateTime.UtcNow;

                new CrudeDefaultUserServiceClient().Update(contract);

                return RedirectToAction("DefaultUserListIndex", "DefaultUserListLive");
            }

            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult DefaultUserCreate(System.Guid? createdByDefaultUserId) {
            var contract = new CrudeDefaultUserContract();
            if ( createdByDefaultUserId != null )
                contract.CreatedByDefaultUserId = ( System.Guid ) createdByDefaultUserId;

            ViewBag.DefaultStateRcd =
                new SelectList(new CrudeDefaultStateRefServiceClient().FetchAll(),
                                "DefaultStateRcd",
                                "DefaultStateName",
                                contract.DefaultStateRcd
                                );

            ViewBag.CreatedByDefaultUserId =
                new SelectList(new CrudeDefaultUserServiceClient().FetchAll(),
                                "DefaultUserId",
                                "DefaultUserName",
                                contract.CreatedByDefaultUserId
                                );

            contract.DateTime = DateTime.UtcNow;

            contract.LastActivityDateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultUserCreate([Bind()] CrudeDefaultUserContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeDefaultUserServiceClient().Insert(contract);

                return RedirectToAction("DefaultUserListIndex", "DefaultUserListLive");
            }

            return View(
                MVCHelper.Resolve(Request, "Default", "DefaultUser", "DefaultUserCreate"),
                contract
                );
        }
    }
}
