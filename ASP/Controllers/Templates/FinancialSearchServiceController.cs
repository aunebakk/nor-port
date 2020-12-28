/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:51:02 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// controller namespace for mvc
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/FinancialSearchService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class FinancialSearchServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("GetAvailableCurrencies")]
        public IEnumerable<GetAvailableCurrenciesContract> GetAvailableCurrencies(
            System.Guid financialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            List<GetAvailableCurrenciesContract> list =
                new FinancialSearchService().GetAvailableCurrencies(financialCurrencyId: financialCurrencyId, currencyDateTime: currencyDateTime);

            return list;
        }

        [HttpGet("FinancialFares")]
        public IEnumerable<FinancialFaresContract> FinancialFares(
            ) {

            List<FinancialFaresContract> list =
                new FinancialSearchService().FinancialFares();

            return list;
        }

        [HttpGet("VoucherSearchWithRemainingAmount")]
        public IEnumerable<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount(
            System.DateTime voucherValidOnDateTime
            ) {

            List<VoucherSearchWithRemainingAmountContract> list =
                new FinancialSearchService().VoucherSearchWithRemainingAmount(voucherValidOnDateTime: voucherValidOnDateTime);

            return list;
        }

        [HttpGet("VoucherTransactions")]
        public IEnumerable<VoucherTransactionsContract> VoucherTransactions(
            System.Guid financialVoucherId
            ) {

            List<VoucherTransactionsContract> list =
                new FinancialSearchService().VoucherTransactions(financialVoucherId: financialVoucherId);

            return list;
        }

        [HttpGet("FinancialServiceDetailsForBooking")]
        public IEnumerable<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking(
            System.Guid bookingId
            ) {

            List<FinancialServiceDetailsForBookingContract> list =
                new FinancialSearchService().FinancialServiceDetailsForBooking(bookingId: bookingId);

            return list;
        }

        [HttpGet("ServiceFerryList")]
        public IEnumerable<ServiceFerryListContract> ServiceFerryList(
            ) {

            List<ServiceFerryListContract> list =
                new FinancialSearchService().ServiceFerryList();

            return list;
        }

        [HttpGet("ServiceCarRentalList")]
        public IEnumerable<ServiceCarRentalListContract> ServiceCarRentalList(
            ) {

            List<ServiceCarRentalListContract> list =
                new FinancialSearchService().ServiceCarRentalList();

            return list;
        }

        [HttpGet("ServiceHotelList")]
        public IEnumerable<ServiceHotelListContract> ServiceHotelList(
            ) {

            List<ServiceHotelListContract> list =
                new FinancialSearchService().ServiceHotelList();

            return list;
        }

        [HttpGet("SpecialServiceRequestList")]
        public IEnumerable<SpecialServiceRequestListContract> SpecialServiceRequestList(
            ) {

            List<SpecialServiceRequestListContract> list =
                new FinancialSearchService().SpecialServiceRequestList();

            return list;
        }

        [HttpGet("TransactionsCreditDebitBalance")]
        public IEnumerable<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance(
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            List<TransactionsCreditDebitBalanceContract> list =
                new FinancialSearchService().TransactionsCreditDebitBalance(fromDateTime: fromDateTime, untilDateTime: untilDateTime);

            return list;
        }
    }
}
