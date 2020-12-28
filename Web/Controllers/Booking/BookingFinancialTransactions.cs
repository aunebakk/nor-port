using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingFinancialTransactionsContract BookingFinancialTransactionsNew(
            Guid bookingId
            ) {
            // fetch booking data
            var bookingFinancialTransactionsContract = 
                new BookingFinancialTransactionsContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            bookingFinancialTransactionsContract.Transactions =
                new SolutionNorSolutionPort.BusinessLogicLayer.BookingSearchService().BookingFinancialTransactions(bookingId);

            return bookingFinancialTransactionsContract;
        }

        [HttpGet]
        public ActionResult BookingFinancialTransactions(
            Guid bookingId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingFinancialTransactions"),
                BookingFinancialTransactionsNew(bookingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingFinancialTransactions(
            [Bind()] BookingFinancialTransactionsContract bookingFinancialTransactionsContract
            ) {

            if ( ModelState.IsValid ) {
                return RedirectToAction(
                    "BookingFinancialTransactions",
                    new { bookingId = bookingFinancialTransactionsContract.BookingId });

            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingFinancialTransactions"),
                BookingFinancialTransactionsNew(bookingFinancialTransactionsContract.BookingId)
                );
        }
    }

    public class BookingFinancialTransactionsContract : BookingGeneralContract
    {
        public BookingFinancialTransactionsContract() {
        }

        public BookingFinancialTransactionsContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        public List<SolutionNorSolutionPort.BusinessLogicLayer.BookingFinancialTransactionsContract> Transactions { get; set; }
    }
}
