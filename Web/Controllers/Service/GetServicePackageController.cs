using System;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public class GetServicePackageLiveController : Controller
    {

        [HttpGet]
        public ActionResult GetServicePackageIndex(System.Guid servicePackageId) {
            return View(
                MVCHelper.Resolve(Request, "Service", "GetServicePackageIndex"),
                new ServiceSearchServiceClient().GetServicePackage(servicePackageId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageIndex() {
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageIndex"),
                new CrudeServicePackageServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult ServicePackageByServiceHotelIndex(System.Guid serviceHotelId) {
            ViewBag.ServiceHotelId = serviceHotelId;
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageIndex"),
                new CrudeServicePackageServiceClient().FetchByServiceHotelId(serviceHotelId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageByServiceSpecialServiceRequestIndex(System.Guid serviceSpecialServiceRequestId) {
            ViewBag.ServiceSpecialServiceRequestId = serviceSpecialServiceRequestId;
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageIndex"),
                new CrudeServicePackageServiceClient().FetchByServiceSpecialServiceRequestId(serviceSpecialServiceRequestId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageByServiceCarRentalIndex(System.Guid serviceCarRentalId) {
            ViewBag.ServiceCarRentalId = serviceCarRentalId;
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageIndex"),
                new CrudeServicePackageServiceClient().FetchByServiceCarRentalId(serviceCarRentalId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageByDepartureAirportIndex(System.Guid departureAirportId) {
            ViewBag.DepartureAirportId = departureAirportId;
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageIndex"),
                new CrudeServicePackageServiceClient().FetchByDepartureAirportId(departureAirportId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageByArrivalAirportIndex(System.Guid arrivalAirportId) {
            ViewBag.ArrivalAirportId = arrivalAirportId;
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageIndex"),
                new CrudeServicePackageServiceClient().FetchByArrivalAirportId(arrivalAirportId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageDetails(System.Guid servicePackageId) {
            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageDetails"),
                new CrudeServicePackageServiceClient().FetchByServicePackageId(servicePackageId)
                );
        }

        [HttpGet]
        public ActionResult ServicePackageEdit(System.Guid servicePackageId) {
            CrudeServicePackageContract contract = new CrudeServicePackageServiceClient().FetchByServicePackageId(servicePackageId);
            ViewBag.ServiceHotelId =
                new SelectList(new CrudeServiceHotelServiceClient().FetchAll(),
                                "ServiceHotelId",
                                "HotelName",
                                contract.ServiceHotelId
                                );

            ViewBag.ServiceSpecialServiceRequestId =
                new SelectList(new CrudeServiceSpecialServiceRequestServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestId",
                                "ServiceSpecialServiceRequestName",
                                contract.ServiceSpecialServiceRequestId
                                );

            ViewBag.ServiceCarRentalId =
                new SelectList(new CrudeServiceCarRentalServiceClient().FetchAll(),
                                "ServiceCarRentalId",
                                "CarName",
                                contract.ServiceCarRentalId
                                );

            ViewBag.DepartureAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.ArrivalAirportId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageEdit"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServicePackageEdit([Bind()] CrudeServicePackageContract contract) {
            if ( ModelState.IsValid ) {
                new CrudeServicePackageServiceClient().Update(contract);

                return RedirectToAction("GetServicePackageIndex", new { servicePackageId = contract.ServicePackageId });
            }

            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageEdit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult ServicePackageCreate(System.Guid? serviceHotelId, System.Guid? serviceSpecialServiceRequestId, System.Guid? serviceCarRentalId, System.Guid? departureAirportId, System.Guid? arrivalAirportId, System.Guid? userId) {
            var contract = new CrudeServicePackageContract();
            if ( serviceHotelId != null )
                contract.ServiceHotelId = ( System.Guid ) serviceHotelId;
            if ( serviceSpecialServiceRequestId != null )
                contract.ServiceSpecialServiceRequestId = ( System.Guid ) serviceSpecialServiceRequestId;
            if ( serviceCarRentalId != null )
                contract.ServiceCarRentalId = ( System.Guid ) serviceCarRentalId;
            if ( departureAirportId != null )
                contract.DepartureAirportId = ( System.Guid ) departureAirportId;
            if ( arrivalAirportId != null )
                contract.ArrivalAirportId = ( System.Guid ) arrivalAirportId;
            if ( userId != null )
                contract.UserId = ( System.Guid ) userId;

            ViewBag.ServiceHotelId =
                new SelectList(new CrudeServiceHotelServiceClient().FetchAll(),
                                "ServiceHotelId",
                                "HotelName",
                                contract.ServiceHotelId
                                );

            ViewBag.ServiceSpecialServiceRequestId =
                new SelectList(new CrudeServiceSpecialServiceRequestServiceClient().FetchAll(),
                                "ServiceSpecialServiceRequestId",
                                "ServiceSpecialServiceRequestName",
                                contract.ServiceSpecialServiceRequestId
                                );

            ViewBag.ServiceCarRentalId =
                new SelectList(new CrudeServiceCarRentalServiceClient().FetchAll(),
                                "ServiceCarRentalId",
                                "CarName",
                                contract.ServiceCarRentalId
                                );

            ViewBag.DepartureAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.DepartureAirportId
                                );

            ViewBag.ArrivalAirportId =
                new SelectList(new CrudeAirportServiceClient().FetchAll(),
                                "AirportId",
                                "AirportName",
                                contract.ArrivalAirportId
                                );

            if ( userId == null )
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServicePackageCreate([Bind()] CrudeServicePackageContract contract) {
            if ( ModelState.IsValid ) {

                new CrudeServicePackageServiceClient().Insert(contract);

                return RedirectToAction("GetServicePackageIndex", new { servicePackageId = contract.ServicePackageId });
            }

            return View(
                MVCHelper.Resolve(Request, "Service", "ServicePackage", "ServicePackageCreate"),
                contract
                );
        }
    }
}
