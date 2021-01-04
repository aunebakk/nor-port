/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 9:13:22 PM
  From Machine: DESKTOP-LSRVP12
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
    [Route("api/1/BookingService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class BookingServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\BookingService\BookingServiceHelp.cshtml");
        }

        [HttpGet("GetBookingEmptyHelp")]
        public IActionResult GetBookingEmptyHelp(
            ) {

            return View(@"Views\Templates\BookingService\GetBookingEmptyHelp.cshtml");
        }

        // get a JSON Array Contract with data for GetBookingEmpty
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("GetBookingEmpty")]
        public BookingContract GetBookingEmpty(
            System.Guid userId
            ) {

            return new BookingService().GetBookingEmpty(userId: userId);
        }


        [HttpGet("CreateBookingHelp")]
        public IActionResult CreateBookingHelp(
            ) {

            return View(@"Views\Templates\BookingService\CreateBookingHelp.cshtml");
        }

        // get a JSON Array Contract with data for CreateBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingSourceRcd: filter by this key, for no filter use: ''
        //   flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("CreateBooking")]
        public System.Guid CreateBooking(
            System.String bookingSourceRcd,
            System.Guid flightId,
            System.Guid userId
            ) {

            return new BookingService().CreateBooking(bookingSourceRcd: bookingSourceRcd, flightId: flightId, userId: userId);
        }


        [HttpGet("UpdateBookingHelp")]
        public IActionResult UpdateBookingHelp(
            ) {

            return View(@"Views\Templates\BookingService\UpdateBookingHelp.cshtml");
        }

        // get a JSON Array Contract with data for UpdateBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   bookingSourceRcd: filter by this key, for no filter use: ''
        //   locator: filter by this key, for no filter use: ''
        //   email: filter by this key, for no filter use: ''
        //   receivedFrom: filter by this key, for no filter use: ''
        //   comment: filter by this key, for no filter use: ''
        //   financialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   financialCostcentreId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateBooking")]
        public System.Guid UpdateBooking(
            System.Guid bookingId,
            System.String bookingSourceRcd,
            System.String locator,
            System.String email,
            System.String receivedFrom,
            System.String comment,
            System.Guid financialCurrencyId,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            return new BookingService().UpdateBooking(bookingId: bookingId, bookingSourceRcd: bookingSourceRcd, locator: locator, email: email, receivedFrom: receivedFrom, comment: comment, financialCurrencyId: financialCurrencyId, financialCostcentreId: financialCostcentreId, userId: userId);
        }


        [HttpGet("GetBookingHelp")]
        public IActionResult GetBookingHelp(
            ) {

            return View(@"Views\Templates\BookingService\GetBookingHelp.cshtml");
        }

        // get a JSON Array Contract with data for GetBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("GetBooking")]
        public BookingContract GetBooking(
            System.Guid bookingId,
            System.Guid userId
            ) {

            return new BookingService().GetBooking(bookingId: bookingId, userId: userId);
        }


        [HttpGet("UpdateBookingPage1Help")]
        public IActionResult UpdateBookingPage1Help(
            ) {

            return View(@"Views\Templates\BookingService\UpdateBookingPage1Help.cshtml");
        }

        // get a JSON Array Contract with data for UpdateBookingPage1
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   bookingSourceRcd: filter by this key, for no filter use: ''
        //   locator: filter by this key, for no filter use: ''
        //   receivedFrom: filter by this key, for no filter use: ''
        //   comment: filter by this key, for no filter use: ''
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateBookingPage1")]
        public void UpdateBookingPage1(
            System.Guid bookingId,
            System.String bookingSourceRcd,
            System.String locator,
            System.String receivedFrom,
            System.String comment,
            System.Guid userId
            ) {

            new BookingService().UpdateBookingPage1(bookingId: bookingId, bookingSourceRcd: bookingSourceRcd, locator: locator, receivedFrom: receivedFrom, comment: comment, userId: userId);
        }


        [HttpGet("UpdateBookingPage2Help")]
        public IActionResult UpdateBookingPage2Help(
            ) {

            return View(@"Views\Templates\BookingService\UpdateBookingPage2Help.cshtml");
        }

        // get a JSON Array Contract with data for UpdateBookingPage2
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   eMail: filter by this key, for no filter use: ''
        //   comment: filter by this key, for no filter use: ''
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateBookingPage2")]
        public void UpdateBookingPage2(
            System.Guid bookingId,
            System.String eMail,
            System.String comment,
            System.Guid userId
            ) {

            new BookingService().UpdateBookingPage2(bookingId: bookingId, eMail: eMail, comment: comment, userId: userId);
        }


        [HttpGet("UpdateBookingPage3Help")]
        public IActionResult UpdateBookingPage3Help(
            ) {

            return View(@"Views\Templates\BookingService\UpdateBookingPage3Help.cshtml");
        }

        // get a JSON Array Contract with data for UpdateBookingPage3
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   addressTypeRcd: filter by this key, for no filter use: ''
        //   addressOne: filter by this key, for no filter use: ''
        //   addressTwo: filter by this key, for no filter use: ''
        //   addressThree: filter by this key, for no filter use: ''
        //   city: filter by this key, for no filter use: ''
        //   street: filter by this key, for no filter use: ''
        //   state: filter by this key, for no filter use: ''
        //   district: filter by this key, for no filter use: ''
        //   province: filter by this key, for no filter use: ''
        //   zipCode: filter by this key, for no filter use: ''
        //   poBox: filter by this key, for no filter use: ''
        //   comment: filter by this key, for no filter use: ''
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateBookingPage3")]
        public void UpdateBookingPage3(
            System.Guid bookingId,
            System.String addressTypeRcd,
            System.String addressOne,
            System.String addressTwo,
            System.String addressThree,
            System.String city,
            System.String street,
            System.String state,
            System.String district,
            System.String province,
            System.String zipCode,
            System.String poBox,
            System.String comment,
            System.Guid userId
            ) {

            new BookingService().UpdateBookingPage3(bookingId: bookingId, addressTypeRcd: addressTypeRcd, addressOne: addressOne, addressTwo: addressTwo, addressThree: addressThree, city: city, street: street, state: state, district: district, province: province, zipCode: zipCode, poBox: poBox, comment: comment, userId: userId);
        }


        [HttpGet("UpdateBookingPage4Help")]
        public IActionResult UpdateBookingPage4Help(
            ) {

            return View(@"Views\Templates\BookingService\UpdateBookingPage4Help.cshtml");
        }

        // get a JSON Array Contract with data for UpdateBookingPage4
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   passengers: filter by this key, for no filter use: type unknown
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateBookingPage4")]
        public void UpdateBookingPage4(
            System.Guid bookingId,
            System.String[] passengers,
            System.Guid userId
            ) {

            new BookingService().UpdateBookingPage4(bookingId: bookingId, passengers: passengers, userId: userId);
        }


        [HttpGet("PassengerAddHelp")]
        public IActionResult PassengerAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\PassengerAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengerAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   passengerTypeRcd: filter by this key, for no filter use: ''
        //   passengerName: filter by this key, for no filter use: ''
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengerAdd")]
        public void PassengerAdd(
            System.Guid bookingId,
            System.String passengerTypeRcd,
            System.String passengerName,
            System.Guid userId
            ) {

            new BookingService().PassengerAdd(bookingId: bookingId, passengerTypeRcd: passengerTypeRcd, passengerName: passengerName, userId: userId);
        }


        [HttpGet("PassengerRemoveHelp")]
        public IActionResult PassengerRemoveHelp(
            ) {

            return View(@"Views\Templates\BookingService\PassengerRemoveHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengerRemove
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingPassengerId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengerRemove")]
        public void PassengerRemove(
            System.Guid bookingPassengerId,
            System.Guid userId
            ) {

            new BookingService().PassengerRemove(bookingPassengerId: bookingPassengerId, userId: userId);
        }


        [HttpGet("PassengerUpdateHelp")]
        public IActionResult PassengerUpdateHelp(
            ) {

            return View(@"Views\Templates\BookingService\PassengerUpdateHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengerUpdate
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingPassengerId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   passengerTypeRcd: filter by this key, for no filter use: ''
        //   passengerName: filter by this key, for no filter use: ''
        //   defaultStateRcd: filter by this key, for no filter use: ''
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengerUpdate")]
        public void PassengerUpdate(
            System.Guid bookingPassengerId,
            System.String passengerTypeRcd,
            System.String passengerName,
            System.String defaultStateRcd,
            System.Guid userId
            ) {

            new BookingService().PassengerUpdate(bookingPassengerId: bookingPassengerId, passengerTypeRcd: passengerTypeRcd, passengerName: passengerName, defaultStateRcd: defaultStateRcd, userId: userId);
        }


        [HttpGet("PaymentCardAddHelp")]
        public IActionResult PaymentCardAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\PaymentCardAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for PaymentCardAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmountBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountRoundingBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountBookingFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   cardContract: filter by this key, for no filter use: type unknown
        //   financialCostcentreId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PaymentCardAdd")]
        public void PaymentCardAdd(
            System.Guid bookingId,
            System.Decimal paidAmountBookingCurrency,
            System.Decimal paidAmountRoundingBookingCurrency,
            System.Guid paidAmountBookingFinancialCurrencyId,
            CrudeFinancialPaymentCardContract cardContract,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            new BookingService().PaymentCardAdd(bookingId: bookingId, paidAmountBookingCurrency: paidAmountBookingCurrency, paidAmountRoundingBookingCurrency: paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId: paidAmountBookingFinancialCurrencyId, cardContract: cardContract, financialCostcentreId: financialCostcentreId, userId: userId);
        }


        [HttpGet("PaymentCashAddHelp")]
        public IActionResult PaymentCashAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\PaymentCashAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for PaymentCashAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmount: filter by this key, for no filter use: 0.00000
        //   paidAmountRounding: filter by this key, for no filter use: 0.00000
        //   paidFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmountBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountRoundingBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountBookingFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   financialCostcentreId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PaymentCashAdd")]
        public void PaymentCashAdd(
            System.Guid bookingId,
            System.Decimal paidAmount,
            System.Decimal paidAmountRounding,
            System.Guid paidFinancialCurrencyId,
            System.Decimal paidAmountBookingCurrency,
            System.Decimal paidAmountRoundingBookingCurrency,
            System.Guid paidAmountBookingFinancialCurrencyId,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            new BookingService().PaymentCashAdd(bookingId: bookingId, paidAmount: paidAmount, paidAmountRounding: paidAmountRounding, paidFinancialCurrencyId: paidFinancialCurrencyId, paidAmountBookingCurrency: paidAmountBookingCurrency, paidAmountRoundingBookingCurrency: paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId: paidAmountBookingFinancialCurrencyId, financialCostcentreId: financialCostcentreId, userId: userId);
        }


        [HttpGet("PaymentVoucherAddHelp")]
        public IActionResult PaymentVoucherAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\PaymentVoucherAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for PaymentVoucherAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   financialVoucherId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmount: filter by this key, for no filter use: 0.00000
        //   paidAmountRounding: filter by this key, for no filter use: 0.00000
        //   paidFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmountBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountRoundingBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountBookingFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   financialCostcentreId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PaymentVoucherAdd")]
        public void PaymentVoucherAdd(
            System.Guid bookingId,
            System.Guid financialVoucherId,
            System.Decimal paidAmount,
            System.Decimal paidAmountRounding,
            System.Guid paidFinancialCurrencyId,
            System.Decimal paidAmountBookingCurrency,
            System.Decimal paidAmountRoundingBookingCurrency,
            System.Guid paidAmountBookingFinancialCurrencyId,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            new BookingService().PaymentVoucherAdd(bookingId: bookingId, financialVoucherId: financialVoucherId, paidAmount: paidAmount, paidAmountRounding: paidAmountRounding, paidFinancialCurrencyId: paidFinancialCurrencyId, paidAmountBookingCurrency: paidAmountBookingCurrency, paidAmountRoundingBookingCurrency: paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId: paidAmountBookingFinancialCurrencyId, financialCostcentreId: financialCostcentreId, userId: userId);
        }


        [HttpGet("PaymentBankAddHelp")]
        public IActionResult PaymentBankAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\PaymentBankAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for PaymentBankAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmount: filter by this key, for no filter use: 0.00000
        //   paidAmountRounding: filter by this key, for no filter use: 0.00000
        //   paidFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   paidAmountBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountRoundingBookingCurrency: filter by this key, for no filter use: 0.00000
        //   paidAmountBookingFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   financialBankAccountNumberTypeRcd: filter by this key, for no filter use: ''
        //   bankName: filter by this key, for no filter use: ''
        //   bankAccount: filter by this key, for no filter use: ''
        //   bankNumber: filter by this key, for no filter use: ''
        //   financialCostcentreId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PaymentBankAdd")]
        public void PaymentBankAdd(
            System.Guid bookingId,
            System.Decimal paidAmount,
            System.Decimal paidAmountRounding,
            System.Guid paidFinancialCurrencyId,
            System.Decimal paidAmountBookingCurrency,
            System.Decimal paidAmountRoundingBookingCurrency,
            System.Guid paidAmountBookingFinancialCurrencyId,
            System.String financialBankAccountNumberTypeRcd,
            System.String bankName,
            System.String bankAccount,
            System.String bankNumber,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            new BookingService().PaymentBankAdd(bookingId: bookingId, paidAmount: paidAmount, paidAmountRounding: paidAmountRounding, paidFinancialCurrencyId: paidFinancialCurrencyId, paidAmountBookingCurrency: paidAmountBookingCurrency, paidAmountRoundingBookingCurrency: paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId: paidAmountBookingFinancialCurrencyId, financialBankAccountNumberTypeRcd: financialBankAccountNumberTypeRcd, bankName: bankName, bankAccount: bankAccount, bankNumber: bankNumber, financialCostcentreId: financialCostcentreId, userId: userId);
        }


        [HttpGet("PaymentAccountingAddHelp")]
        public IActionResult PaymentAccountingAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\PaymentAccountingAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for PaymentAccountingAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   amount: filter by this key, for no filter use: 0.00000
        //   roundingAmount: filter by this key, for no filter use: 0.00000
        //   financialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   financialCostcentreId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PaymentAccountingAdd")]
        public void PaymentAccountingAdd(
            System.Guid bookingId,
            System.Decimal amount,
            System.Decimal roundingAmount,
            System.Guid financialCurrencyId,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            new BookingService().PaymentAccountingAdd(bookingId: bookingId, amount: amount, roundingAmount: roundingAmount, financialCurrencyId: financialCurrencyId, financialCostcentreId: financialCostcentreId, userId: userId);
        }


        [HttpGet("PaymentGetCurrencyHelp")]
        public IActionResult PaymentGetCurrencyHelp(
            ) {

            return View(@"Views\Templates\BookingService\PaymentGetCurrencyHelp.cshtml");
        }

        // get a JSON Array Contract with data for PaymentGetCurrency
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  financialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   againstFinancialCurrencyId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   currencyDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        [HttpGet("PaymentGetCurrency")]
        public CrudeFinancialCurrencyContract PaymentGetCurrency(
            System.Guid financialCurrencyId,
            System.Guid againstFinancialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            return new BookingService().PaymentGetCurrency(financialCurrencyId: financialCurrencyId, againstFinancialCurrencyId: againstFinancialCurrencyId, currencyDateTime: currencyDateTime);
        }


        [HttpGet("FlightAddHelp")]
        public IActionResult FlightAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\FlightAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for FlightAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   flightId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FlightAdd")]
        public void FlightAdd(
            System.Guid bookingId,
            System.Guid flightId,
            System.Guid userId
            ) {

            new BookingService().FlightAdd(bookingId: bookingId, flightId: flightId, userId: userId);
        }


        [HttpGet("FlightRemoveHelp")]
        public IActionResult FlightRemoveHelp(
            ) {

            return View(@"Views\Templates\BookingService\FlightRemoveHelp.cshtml");
        }

        // get a JSON Array Contract with data for FlightRemove
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   bookingFlightSegmentId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FlightRemove")]
        public void FlightRemove(
            System.Guid bookingId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            new BookingService().FlightRemove(bookingId: bookingId, bookingFlightSegmentId: bookingFlightSegmentId, userId: userId);
        }


        [HttpGet("SimulateBookingsHelp")]
        public IActionResult SimulateBookingsHelp(
            ) {

            return View(@"Views\Templates\BookingService\SimulateBookingsHelp.cshtml");
        }

        // get a JSON Array Contract with data for SimulateBookings
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  fromDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   untilDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("SimulateBookings")]
        public void SimulateBookings(
            System.DateTime fromDateTime,
            System.DateTime untilDateTime,
            System.Guid userId
            ) {

            new BookingService().SimulateBookings(fromDateTime: fromDateTime, untilDateTime: untilDateTime, userId: userId);
        }


        [HttpGet("BookingConfirmHelp")]
        public IActionResult BookingConfirmHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingConfirmHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingConfirm
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingConfirm")]
        public void BookingConfirm(
            System.Guid bookingId,
            System.Guid userId
            ) {

            new BookingService().BookingConfirm(bookingId: bookingId, userId: userId);
        }


        [HttpGet("LocatorCreateHelp")]
        public IActionResult LocatorCreateHelp(
            ) {

            return View(@"Views\Templates\BookingService\LocatorCreateHelp.cshtml");
        }

        // get a JSON Array Contract with data for LocatorCreate
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("LocatorCreate")]
        public System.String LocatorCreate(
            ) {

            return new BookingService().LocatorCreate();
        }


        [HttpGet("BookingFinancialBalanceHelp")]
        public IActionResult BookingFinancialBalanceHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingFinancialBalanceHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingFinancialBalance
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingFinancialBalance")]
        public System.Decimal BookingFinancialBalance(
            System.Guid bookingId
            ) {

            return new BookingService().BookingFinancialBalance(bookingId: bookingId);
        }


        [HttpGet("SendBookingConfirmationByEmailHelp")]
        public IActionResult SendBookingConfirmationByEmailHelp(
            ) {

            return View(@"Views\Templates\BookingService\SendBookingConfirmationByEmailHelp.cshtml");
        }

        // get a JSON Array Contract with data for SendBookingConfirmationByEmail
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("SendBookingConfirmationByEmail")]
        public void SendBookingConfirmationByEmail(
            System.Guid bookingId,
            System.Guid userId
            ) {

            new BookingService().SendBookingConfirmationByEmail(bookingId: bookingId, userId: userId);
        }


        [HttpGet("PassengerCheckInHelp")]
        public IActionResult PassengerCheckInHelp(
            ) {

            return View(@"Views\Templates\BookingService\PassengerCheckInHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengerCheckIn
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingPassengerId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   bookingFlightSegmentId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengerCheckIn")]
        public void PassengerCheckIn(
            System.Guid bookingPassengerId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            new BookingService().PassengerCheckIn(bookingPassengerId: bookingPassengerId, bookingFlightSegmentId: bookingFlightSegmentId, userId: userId);
        }


        [HttpGet("PassengerCheckOutHelp")]
        public IActionResult PassengerCheckOutHelp(
            ) {

            return View(@"Views\Templates\BookingService\PassengerCheckOutHelp.cshtml");
        }

        // get a JSON Array Contract with data for PassengerCheckOut
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingPassengerId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   bookingFlightSegmentId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PassengerCheckOut")]
        public void PassengerCheckOut(
            System.Guid bookingPassengerId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            new BookingService().PassengerCheckOut(bookingPassengerId: bookingPassengerId, bookingFlightSegmentId: bookingFlightSegmentId, userId: userId);
        }


        [HttpGet("BookingServiceHotelAddHelp")]
        public IActionResult BookingServiceHotelAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingServiceHotelAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingServiceHotelAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   serviceHotelId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingServiceHotelAdd")]
        public void BookingServiceHotelAdd(
            System.Guid bookingId,
            System.Guid serviceHotelId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceHotelAdd(bookingId: bookingId, serviceHotelId: serviceHotelId, userId: userId);
        }


        [HttpGet("BookingServiceFerryAddHelp")]
        public IActionResult BookingServiceFerryAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingServiceFerryAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingServiceFerryAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   serviceFerryId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingServiceFerryAdd")]
        public void BookingServiceFerryAdd(
            System.Guid bookingId,
            System.Guid serviceFerryId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceFerryAdd(bookingId: bookingId, serviceFerryId: serviceFerryId, userId: userId);
        }


        [HttpGet("BookingServiceCarRentalAddHelp")]
        public IActionResult BookingServiceCarRentalAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingServiceCarRentalAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingServiceCarRentalAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   serviceCarRentalId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingServiceCarRentalAdd")]
        public void BookingServiceCarRentalAdd(
            System.Guid bookingId,
            System.Guid serviceCarRentalId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceCarRentalAdd(bookingId: bookingId, serviceCarRentalId: serviceCarRentalId, userId: userId);
        }


        [HttpGet("BookingServiceSpecialServiceRequestAddHelp")]
        public IActionResult BookingServiceSpecialServiceRequestAddHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingServiceSpecialServiceRequestAddHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingServiceSpecialServiceRequestAdd
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   serviceSpecialServiceRequestId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingServiceSpecialServiceRequestAdd")]
        public void BookingServiceSpecialServiceRequestAdd(
            System.Guid bookingId,
            System.Guid serviceSpecialServiceRequestId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceSpecialServiceRequestAdd(bookingId: bookingId, serviceSpecialServiceRequestId: serviceSpecialServiceRequestId, userId: userId);
        }


        [HttpGet("BookingServiceRequestRemoveHelp")]
        public IActionResult BookingServiceRequestRemoveHelp(
            ) {

            return View(@"Views\Templates\BookingService\BookingServiceRequestRemoveHelp.cshtml");
        }

        // get a JSON Array Contract with data for BookingServiceRequestRemove
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  bookingServiceRequestId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("BookingServiceRequestRemove")]
        public void BookingServiceRequestRemove(
            System.Guid bookingServiceRequestId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceRequestRemove(bookingServiceRequestId: bookingServiceRequestId, userId: userId);
        }


        [HttpGet("FinancialCurrencyUpdateHelp")]
        public IActionResult FinancialCurrencyUpdateHelp(
            ) {

            return View(@"Views\Templates\BookingService\FinancialCurrencyUpdateHelp.cshtml");
        }

        // get a JSON Array Contract with data for FinancialCurrencyUpdate
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  currencyCode: filter by this key, for no filter use: ''
        //   againstCurrencyCode: filter by this key, for no filter use: ''
        //   rate: filter by this key, for no filter use: 0.00000
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("FinancialCurrencyUpdate")]
        public void FinancialCurrencyUpdate(
            System.String currencyCode,
            System.String againstCurrencyCode,
            System.Decimal rate,
            System.Guid userId
            ) {

            new BookingService().FinancialCurrencyUpdate(currencyCode: currencyCode, againstCurrencyCode: againstCurrencyCode, rate: rate, userId: userId);
        }

    }
}
