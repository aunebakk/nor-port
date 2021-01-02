/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 7:54:37 PM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/FinancialSearchService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class FinancialSearchServiceController : Controller {
        // get a JSON Array Contract with data for GetAvailableCurrencies
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  financialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   currencyDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        [HttpGet("GetAvailableCurrencies")]
        public IEnumerable<GetAvailableCurrenciesContract> GetAvailableCurrencies(
            System.Guid financialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            List<GetAvailableCurrenciesContract> list =
                new FinancialSearchService().GetAvailableCurrencies(financialCurrencyId: financialCurrencyId, currencyDateTime: currencyDateTime);

            return list;
        }

        // get a JSON Array Contract with data for FinancialFares
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("FinancialFares")]
        public IEnumerable<FinancialFaresContract> FinancialFares(
            ) {

            List<FinancialFaresContract> list =
                new FinancialSearchService().FinancialFares();

            return list;
        }

        // get a JSON Array Contract with data for VoucherSearchWithRemainingAmount
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  voucherValidOnDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        [HttpGet("VoucherSearchWithRemainingAmount")]
        public IEnumerable<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount(
            System.DateTime voucherValidOnDateTime
            ) {

            List<VoucherSearchWithRemainingAmountContract> list =
                new FinancialSearchService().VoucherSearchWithRemainingAmount(voucherValidOnDateTime: voucherValidOnDateTime);

            return list;
        }

        // get a JSON Array Contract with data for VoucherTransactions
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  financialVoucherId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("VoucherTransactions")]
        public IEnumerable<VoucherTransactionsContract> VoucherTransactions(
            System.Guid financialVoucherId
            ) {

            List<VoucherTransactionsContract> list =
                new FinancialSearchService().VoucherTransactions(financialVoucherId: financialVoucherId);

            return list;
        }

        // get a JSON Array Contract with data for FinancialServiceDetailsForBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FinancialServiceDetailsForBooking")]
        public IEnumerable<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking(
            System.Guid bookingId
            ) {

            List<FinancialServiceDetailsForBookingContract> list =
                new FinancialSearchService().FinancialServiceDetailsForBooking(bookingId: bookingId);

            return list;
        }

        // get a JSON Array Contract with data for ServiceFerryList
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("ServiceFerryList")]
        public IEnumerable<ServiceFerryListContract> ServiceFerryList(
            ) {

            List<ServiceFerryListContract> list =
                new FinancialSearchService().ServiceFerryList();

            return list;
        }

        // get a JSON Array Contract with data for ServiceCarRentalList
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("ServiceCarRentalList")]
        public IEnumerable<ServiceCarRentalListContract> ServiceCarRentalList(
            ) {

            List<ServiceCarRentalListContract> list =
                new FinancialSearchService().ServiceCarRentalList();

            return list;
        }

        // get a JSON Array Contract with data for ServiceHotelList
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("ServiceHotelList")]
        public IEnumerable<ServiceHotelListContract> ServiceHotelList(
            ) {

            List<ServiceHotelListContract> list =
                new FinancialSearchService().ServiceHotelList();

            return list;
        }

        // get a JSON Array Contract with data for SpecialServiceRequestList
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("SpecialServiceRequestList")]
        public IEnumerable<SpecialServiceRequestListContract> SpecialServiceRequestList(
            ) {

            List<SpecialServiceRequestListContract> list =
                new FinancialSearchService().SpecialServiceRequestList();

            return list;
        }

        // get a JSON Array Contract with data for TransactionsCreditDebitBalance
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
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
