using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {
        [HttpGet]
        public ActionResult BookingAddress(
            Guid bookingId
            ) {
            // make rest buffer
            var bookingAddressContract = 
                new BookingAddressContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            bookingAddressContract.AddressTypeRcd = bookingAddressContract.BookingContract.BookingAddress.AddressTypeRcd;
            bookingAddressContract.AddressOne = bookingAddressContract.BookingContract.BookingAddress.AddressOne;
            bookingAddressContract.AddressTwo = bookingAddressContract.BookingContract.BookingAddress.AddressTwo;
            bookingAddressContract.AddressThree = bookingAddressContract.BookingContract.BookingAddress.AddressThree;
            bookingAddressContract.City = bookingAddressContract.BookingContract.BookingAddress.City;
            bookingAddressContract.Street = bookingAddressContract.BookingContract.BookingAddress.Street;
            bookingAddressContract.State = bookingAddressContract.BookingContract.BookingAddress.State;
            bookingAddressContract.District = bookingAddressContract.BookingContract.BookingAddress.District;
            bookingAddressContract.Province = bookingAddressContract.BookingContract.BookingAddress.Province;
            bookingAddressContract.ZipCode = bookingAddressContract.BookingContract.BookingAddress.ZipCode;
            bookingAddressContract.PoBox = bookingAddressContract.BookingContract.BookingAddress.PoBox;
            bookingAddressContract.Comment = bookingAddressContract.BookingContract.BookingAddress.Comment;
            bookingAddressContract.DateTime = bookingAddressContract.BookingContract.BookingAddress.DateTime;

            ViewBag.AddressTypeRcd =
                new SelectList(
                    new SolutionNorSolutionPort.BusinessLogicLayer.CrudeAddressTypeRefServiceClient().FetchAll(),
                    "AddressTypeRcd",
                    "AddressTypeName",
                    bookingAddressContract.AddressTypeRcd
                    );

            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingAddress"),
                            bookingAddressContract
                            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingAddress(
            [Bind()] BookingAddressContract bookingAddressContract
            ) {
            if ( ModelState.IsValid ) {
                new BookingServiceClient().UpdateBookingPage3(
                    bookingAddressContract.BookingId,
                    bookingAddressContract.AddressTypeRcd,
                    bookingAddressContract.AddressOne,
                    bookingAddressContract.AddressTwo,
                    bookingAddressContract.AddressThree,
                    bookingAddressContract.City,
                    bookingAddressContract.Street,
                    bookingAddressContract.State,
                    bookingAddressContract.District,
                    bookingAddressContract.Province,
                    bookingAddressContract.ZipCode,
                    bookingAddressContract.PoBox,
                    bookingAddressContract.Comment,
                    Logging.UserId(User.Identity, ViewBag)
                    );

                return RedirectToAction(
                    "BookingPassengers",
                    new { bookingId = bookingAddressContract.BookingId });
            }
            return View(MVCHelper.Resolve(Request, "", "Booking", "BookingAddress"),
                            bookingAddressContract
                            );
        }
    }

    public class BookingAddressContract : BookingGeneralContract
    {
        public BookingAddressContract() { }
        public BookingAddressContract(Guid bookingId, Guid userId) : base(bookingId, userId) { }
        public Guid AddressId { get; set; }
        public string AddressTypeRcd { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string AddressThree { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public string PoBox { get; set; }
        public new string Comment { get; set; }
        public Guid UserId { get; set; }
        public System.DateTime DateTime { get; set; }
    }
}
