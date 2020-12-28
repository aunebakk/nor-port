using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.AspMvc.Controllers
{
    public partial class BookingController : Controller
    {

        BookingFinancialPaymentContract BookingFinancialPaymentsNew(
            Guid bookingId,
            string financialPaymentTypeRcd,
            Guid? financialPaymentId,
            Guid? financialCurrencyId,
            Guid? financialVoucherId
            ) {

            // fix null's
            if ( financialPaymentId == null )
                financialPaymentId = Guid.Empty;
            if ( financialCurrencyId == null )
                financialCurrencyId = Guid.Empty;
            if ( financialVoucherId == null )
                financialVoucherId = Guid.Empty;

            // fetch booking data
            var bookingFinancialPayment = 
                new BookingFinancialPaymentContract(
                    bookingId,
                    Logging.UserId(User.Identity, ViewBag)
                    );

            // booking
            bookingFinancialPayment.BookingId = bookingId;

            bookingFinancialPayment.BookingBalanceFinancialCurrencyId =
                bookingFinancialPayment.BookingContract.Booking.FinancialCurrencyId;

            ViewBag.BookingBalanceFinancialCurrencyName =
                new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(
                    bookingFinancialPayment.BookingBalanceFinancialCurrencyId
                    ).FinancialCurrencyTypeName;

            // new payment
            if ( financialPaymentId == Guid.Empty ) {

                // get booking balance
                bookingFinancialPayment.BookingBalanceAmount =
                    new BookingServiceClient().BookingFinancialBalance(
                        bookingId);

                if ( financialCurrencyId != Guid.Empty ) {
                    // payment in new(selected) currency
                    bookingFinancialPayment.PaymentFinancialCurrencyId =
                        ( Guid ) financialCurrencyId;

                    CrudeFinancialCurrencyContract currency = 
                        new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(
                                bookingFinancialPayment.PaymentFinancialCurrencyId);

                    CrudeFinancialCurrencyTypeRefContract paymentCurrency = 
                        new CrudeFinancialCurrencyTypeRefServiceClient().FetchByFinancialCurrencyTypeRcd(
                            currency.FinancialCurrencyAgainstFinancialCurrencyTypeRcd);

                    ViewBag.PaymentFinancialCurrencyName = paymentCurrency.FinancialCurrencyTypeName;

                    bookingFinancialPayment.PaymentAmount =
                        bookingFinancialPayment.BookingBalanceAmount * currency.EqualsAmount;

                    bookingFinancialPayment.PaymentBookingCurrencyAmount =
                        bookingFinancialPayment.BookingBalanceAmount;

                } else {
                    // payment in booking currency
                    bookingFinancialPayment.PaymentFinancialCurrencyId =
                        bookingFinancialPayment.BookingContract.Booking.FinancialCurrencyId;

                    bookingFinancialPayment.PaymentAmount =
                        bookingFinancialPayment.BookingBalanceAmount;

                    bookingFinancialPayment.PaymentBookingCurrencyAmount =
                        bookingFinancialPayment.BookingBalanceAmount;

                    ViewBag.PaymentFinancialCurrencyName =
                        new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(
                            bookingFinancialPayment.PaymentFinancialCurrencyId
                            ).FinancialCurrencyTypeName;
                }

                bookingFinancialPayment.PaymentFinancialCostcentreId =
                    bookingFinancialPayment.BookingContract.Booking.FinancialCostcentreId;
            }

            // payments
            bookingFinancialPayment.Payments =
                new BookingSearchService().BookingFinancialPayments(bookingId);

            bookingFinancialPayment.PaymentFinancialPaymentTypeRcd = financialPaymentTypeRcd;

            // get previous payment ( for viewing )
            if ( financialPaymentId != Guid.Empty ) {
                bookingFinancialPayment.PaymentContract =
                    new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentId(
                        ( Guid ) financialPaymentId);
            } else {
                // get available currencies
                bookingFinancialPayment.PaymentSelectedFinancialCurrencyId =
                    bookingFinancialPayment.PaymentFinancialCurrencyId;

                ViewBag.PaymentSelectedFinancialCurrencyId =
                    new SelectList(new FinancialSearchService().
                                        GetAvailableCurrencies(
                                            bookingFinancialPayment.BookingBalanceFinancialCurrencyId,
                                            DateTime.UtcNow
                                            ),
                                    "FinancialCurrencyId",
                                    "FinancialCurrencyTypeName",
                                    bookingFinancialPayment.PaymentSelectedFinancialCurrencyId
                                    );
            }

            // payment type specific
            if ( financialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Card) ) {
                // card
                if ( financialPaymentId != Guid.Empty )
                    bookingFinancialPayment.CardContract =
                        new CrudeFinancialPaymentCardServiceClient().FetchByFinancialPaymentCardId(
                            bookingFinancialPayment.PaymentContract.FinancialPaymentCardId);

                ViewBag.FinancialCardTypeRcd =
                    new SelectList(new CrudeFinancialCardTypeRefServiceClient().FetchAll(),
                                    "FinancialCardTypeRcd",
                                    "FinancialCardTypeName",
                                    bookingFinancialPayment.FinancialCardTypeRcd);

            } else if ( financialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Cash) ) {
                // cash
                if ( financialPaymentId != Guid.Empty )
                    bookingFinancialPayment.CashContract =
                        new CrudeFinancialPaymentCashServiceClient().FetchByFinancialPaymentCashId(
                            bookingFinancialPayment.PaymentContract.FinancialPaymentCashId);

            } else if ( financialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Bank) ) {
                // bank
                if ( financialPaymentId != Guid.Empty )
                    bookingFinancialPayment.BankContract =
                        new CrudeFinancialPaymentBankServiceClient().FetchByFinancialPaymentBankId(
                            bookingFinancialPayment.PaymentContract.FinancialPaymentBankId);

                ViewBag.FinancialBankAccountNumberTypeRcd =
                    new SelectList(new CrudeFinancialBankAccountNumberTypeRefServiceClient().FetchAll(),
                                    "FinancialBankAccountNumberTypeRcd",
                                    "FinancialBankAccountNumberTypeName",
                                    bookingFinancialPayment.FinancialBankAccountNumberTypeRcd);

            } else if ( financialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Voucher) ) {
                // voucher
                if ( financialPaymentId == Guid.Empty )
                    bookingFinancialPayment.Vouchers =
                        new FinancialSearchService().VoucherSearchWithRemainingAmount(DateTime.UtcNow);
            }

            return bookingFinancialPayment;
        }

        [HttpGet]
        public ActionResult BookingFinancialPayments(
            Guid bookingId,
            string financialPaymentTypeRcd,
            Guid? financialPaymentId,
            Guid? financialCurrencyId,
            Guid? financialVoucherId
            ) {

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingFinancialPayments"),
                BookingFinancialPaymentsNew(
                    bookingId,
                    financialPaymentTypeRcd,
                    financialPaymentId,
                    financialCurrencyId,
                    financialVoucherId
                    )
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookingFinancialPayments(
            [Bind()] BookingFinancialPaymentContract bookingFinancialPayment,
            Guid? financialPaymentId,
            Guid? financialCurrencyId,
            Guid? financialVoucherId
            ) {

            if ( ModelState.IsValid ) {
                // reload if no currency is selected
                if ( financialCurrencyId != null && financialCurrencyId != bookingFinancialPayment.PaymentSelectedFinancialCurrencyId ) {
                    return RedirectToAction(
                        "BookingFinancialPayments",
                        new {
                            bookingId = bookingFinancialPayment.BookingId,
                            financialPaymentTypeRcd = bookingFinancialPayment.PaymentFinancialPaymentTypeRcd,
                            financialPaymentId = Guid.Empty,
                            financialCurrencyId = bookingFinancialPayment.PaymentSelectedFinancialCurrencyId
                        }
                        );
                }

                // currency selected, make payment
                bookingFinancialPayment.PaymentFinancialCurrencyId = bookingFinancialPayment.PaymentSelectedFinancialCurrencyId;

                if ( bookingFinancialPayment.PaymentFinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Card) ) {
                    // card
                    bookingFinancialPayment.CardContract.Amount = bookingFinancialPayment.PaymentAmount;
                    bookingFinancialPayment.CardContract.FinancialCurrencyId = bookingFinancialPayment.PaymentFinancialCurrencyId;

                    new BookingServiceClient()
                        .PaymentCardAdd(
                            bookingFinancialPayment.BookingId,
                            bookingFinancialPayment.PaymentBookingCurrencyAmount,
                            0,
                            bookingFinancialPayment.BookingBalanceFinancialCurrencyId,
                            bookingFinancialPayment.CardContract,
                            bookingFinancialPayment.PaymentFinancialCostcentreId,
                            Logging.UserId(User.Identity, ViewBag)
                            );

                } else if ( bookingFinancialPayment.PaymentFinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Cash) ) {
                    // cash
                    new BookingServiceClient()
                        .PaymentCashAdd(
                            bookingFinancialPayment.BookingId,
                            bookingFinancialPayment.PaymentAmount,
                            0,
                            bookingFinancialPayment.PaymentFinancialCurrencyId,
                            bookingFinancialPayment.PaymentBookingCurrencyAmount,
                            0,
                            bookingFinancialPayment.BookingBalanceFinancialCurrencyId,
                            bookingFinancialPayment.PaymentFinancialCostcentreId,
                            Logging.UserId(User.Identity, ViewBag)
                            );

                } else if ( bookingFinancialPayment.PaymentFinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Bank) ) {
                    // bank
                    new BookingServiceClient()
                        .PaymentBankAdd(
                            bookingFinancialPayment.BookingId,
                            bookingFinancialPayment.PaymentAmount,
                            0,
                            bookingFinancialPayment.PaymentFinancialCurrencyId,
                            bookingFinancialPayment.PaymentBookingCurrencyAmount,
                            0,
                            bookingFinancialPayment.BookingBalanceFinancialCurrencyId,
                            bookingFinancialPayment.BankContract.FinancialBankAccountNumberTypeRcd,
                            bookingFinancialPayment.BankContract.BankName,
                            bookingFinancialPayment.BankContract.BankAccount,
                            bookingFinancialPayment.BankContract.BankNumber,
                            bookingFinancialPayment.PaymentFinancialCostcentreId,
                            Logging.UserId(User.Identity, ViewBag)
                            );

                } else if ( bookingFinancialPayment.PaymentFinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Voucher) ) {
                    // voucher
                    new BookingServiceClient()
                        .PaymentVoucherAdd(
                            bookingFinancialPayment.BookingId,
                            ( Guid ) financialVoucherId,
                            bookingFinancialPayment.PaymentAmount,
                            0,
                            bookingFinancialPayment.PaymentFinancialCurrencyId,
                            bookingFinancialPayment.PaymentBookingCurrencyAmount,
                            0,
                            bookingFinancialPayment.BookingBalanceFinancialCurrencyId,
                            bookingFinancialPayment.PaymentFinancialCostcentreId,
                            Logging.UserId(User.Identity, ViewBag)
                            );
                }

                return RedirectToAction(
                    "BookingFinancialPayments",
                    new {
                        bookingId = bookingFinancialPayment.BookingId,
                        financialPaymentTypeRcd = bookingFinancialPayment.PaymentFinancialPaymentTypeRcd,
                        financialPaymentId = Guid.Empty,
                        financialCurrencyId = Guid.Empty
                    }
                    );
            }

            return View(
                MVCHelper.Resolve(Request, "", "Booking", "BookingFinancialPayments"),
                BookingFinancialPaymentsNew(
                    bookingFinancialPayment.BookingId,
                    bookingFinancialPayment.PaymentFinancialPaymentTypeRcd,
                    Guid.Empty,
                    Guid.Empty,
                    Guid.Empty
                    )
                );
        }

        [HttpGet]
        public ActionResult PaymentRemove(
            Guid bookingId,
            Guid bookingPassengerId
            ) {

            new BookingServiceClient().PassengerRemove(
                bookingPassengerId,
                Logging.UserId(User.Identity, ViewBag)
                );

            return RedirectToAction(
                "BookingFinancialPayments",
                new { bookingId = bookingId });
        }

    }

    public class BookingFinancialPaymentContract : BookingGeneralContract
    {
        public BookingFinancialPaymentContract() {
        }

        public BookingFinancialPaymentContract(Guid bookingId, Guid userId)
            : base(bookingId, userId) {
        }

        // booking balance
        public decimal BookingBalanceAmount { get; set; }
        public Guid BookingBalanceFinancialCurrencyId { get; set; }

        // payment currency
        public Guid PaymentFinancialCurrencyId { get; set; }
        public Guid PaymentSelectedFinancialCurrencyId { get; set; }
        public decimal PaymentAmount { get; set; }
        public Guid PaymentFinancialCostcentreId { get; set; }
        public string PaymentFinancialPaymentTypeRcd { get; set; }

        // payment booking currency
        public decimal PaymentBookingCurrencyAmount { get; set; }
        public Guid PaymentBookingCurrencyFinancialCurrencyId { get; set; }

        // card
        public CrudeFinancialPaymentCardContract CardContract { get; set; }
        public string FinancialCardTypeRcd {
            get {
                if ( CardContract == null )
                    CardContract = new CrudeFinancialPaymentCardContract();
                return CardContract.FinancialCardTypeRcd;
            }

            set {
                if ( CardContract == null )
                    CardContract = new CrudeFinancialPaymentCardContract();

                CardContract.FinancialCardTypeRcd = value;
            }
        }

        // cash
        public CrudeFinancialPaymentCashContract CashContract { get; set; }
        public Guid FinancialCurrencyId {
            get {
                if ( CashContract == null )
                    CashContract = new CrudeFinancialPaymentCashContract();
                return CashContract.FinancialCurrencyId;
            }

            set {
                if ( CashContract == null )
                    CashContract = new CrudeFinancialPaymentCashContract();

                CashContract.FinancialCurrencyId = value;
            }
        }

        // bank
        public CrudeFinancialPaymentBankContract BankContract { get; set; }
        public string FinancialBankAccountNumberTypeRcd {
            get {
                if ( BankContract == null )
                    BankContract = new CrudeFinancialPaymentBankContract();
                return BankContract.FinancialBankAccountNumberTypeRcd;
            }

            set {
                if ( BankContract == null )
                    BankContract = new CrudeFinancialPaymentBankContract();

                BankContract.FinancialBankAccountNumberTypeRcd = value;
            }
        }

        public List<VoucherSearchWithRemainingAmountContract> Vouchers { get; set; }

        // payment
        public CrudeFinancialPaymentContract PaymentContract { get; set; }

        public Guid FinancialPaymentId {
            get {
                if ( PaymentContract == null )
                    PaymentContract = new CrudeFinancialPaymentContract();
                return PaymentContract.FinancialPaymentId;
            }

            set {
                if ( PaymentContract == null )
                    PaymentContract = new CrudeFinancialPaymentContract();

                PaymentContract.FinancialPaymentId = value;
            }
        }

        public List<BookingFinancialPaymentsContract> Payments { get; set; }

        public Guid UserId { get; set; }

        public System.DateTime DateTime { get; set; }
    }
}
