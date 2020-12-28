/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:37 PM
  From Machine: DESKTOP-LSRVP12
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
    [Route("api/1/BookingService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class BookingServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("GetBookingEmpty")]
        public BookingContract GetBookingEmpty(
            System.Guid userId
            ) {

            return new BookingService().GetBookingEmpty(userId: userId);
        }

        [HttpGet("CreateBooking")]
        public System.Guid CreateBooking(
            System.String bookingSourceRcd,
            System.Guid flightId,
            System.Guid userId
            ) {

            return new BookingService().CreateBooking(bookingSourceRcd: bookingSourceRcd, flightId: flightId, userId: userId);
        }

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

        [HttpGet("GetBooking")]
        public BookingContract GetBooking(
            System.Guid bookingId,
            System.Guid userId
            ) {

            return new BookingService().GetBooking(bookingId: bookingId, userId: userId);
        }

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

        [HttpGet("UpdateBookingPage2")]
        public void UpdateBookingPage2(
            System.Guid bookingId,
            System.String eMail,
            System.String comment,
            System.Guid userId
            ) {

            new BookingService().UpdateBookingPage2(bookingId: bookingId, eMail: eMail, comment: comment, userId: userId);
        }

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

        [HttpGet("UpdateBookingPage4")]
        public void UpdateBookingPage4(
            System.Guid bookingId,
            System.String[] passengers,
            System.Guid userId
            ) {

            new BookingService().UpdateBookingPage4(bookingId: bookingId, passengers: passengers, userId: userId);
        }

        [HttpGet("PassengerAdd")]
        public void PassengerAdd(
            System.Guid bookingId,
            System.String passengerTypeRcd,
            System.String passengerName,
            System.Guid userId
            ) {

            new BookingService().PassengerAdd(bookingId: bookingId, passengerTypeRcd: passengerTypeRcd, passengerName: passengerName, userId: userId);
        }

        [HttpGet("PassengerRemove")]
        public void PassengerRemove(
            System.Guid bookingPassengerId,
            System.Guid userId
            ) {

            new BookingService().PassengerRemove(bookingPassengerId: bookingPassengerId, userId: userId);
        }

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

        [HttpGet("PaymentGetCurrency")]
        public CrudeFinancialCurrencyContract PaymentGetCurrency(
            System.Guid financialCurrencyId,
            System.Guid againstFinancialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            return new BookingService().PaymentGetCurrency(financialCurrencyId: financialCurrencyId, againstFinancialCurrencyId: againstFinancialCurrencyId, currencyDateTime: currencyDateTime);
        }

        [HttpGet("FlightAdd")]
        public void FlightAdd(
            System.Guid bookingId,
            System.Guid flightId,
            System.Guid userId
            ) {

            new BookingService().FlightAdd(bookingId: bookingId, flightId: flightId, userId: userId);
        }

        [HttpGet("FlightRemove")]
        public void FlightRemove(
            System.Guid bookingId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            new BookingService().FlightRemove(bookingId: bookingId, bookingFlightSegmentId: bookingFlightSegmentId, userId: userId);
        }

        [HttpGet("SimulateBookings")]
        public void SimulateBookings(
            System.DateTime fromDateTime,
            System.DateTime untilDateTime,
            System.Guid userId
            ) {

            new BookingService().SimulateBookings(fromDateTime: fromDateTime, untilDateTime: untilDateTime, userId: userId);
        }

        [HttpGet("BookingConfirm")]
        public void BookingConfirm(
            System.Guid bookingId,
            System.Guid userId
            ) {

            new BookingService().BookingConfirm(bookingId: bookingId, userId: userId);
        }

        [HttpGet("LocatorCreate")]
        public System.String LocatorCreate(
            ) {

            return new BookingService().LocatorCreate();
        }

        [HttpGet("BookingFinancialBalance")]
        public System.Decimal BookingFinancialBalance(
            System.Guid bookingId
            ) {

            return new BookingService().BookingFinancialBalance(bookingId: bookingId);
        }

        [HttpGet("SendBookingConfirmationByEmail")]
        public void SendBookingConfirmationByEmail(
            System.Guid bookingId,
            System.Guid userId
            ) {

            new BookingService().SendBookingConfirmationByEmail(bookingId: bookingId, userId: userId);
        }

        [HttpGet("PassengerCheckIn")]
        public void PassengerCheckIn(
            System.Guid bookingPassengerId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            new BookingService().PassengerCheckIn(bookingPassengerId: bookingPassengerId, bookingFlightSegmentId: bookingFlightSegmentId, userId: userId);
        }

        [HttpGet("PassengerCheckOut")]
        public void PassengerCheckOut(
            System.Guid bookingPassengerId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            new BookingService().PassengerCheckOut(bookingPassengerId: bookingPassengerId, bookingFlightSegmentId: bookingFlightSegmentId, userId: userId);
        }

        [HttpGet("BookingServiceHotelAdd")]
        public void BookingServiceHotelAdd(
            System.Guid bookingId,
            System.Guid serviceHotelId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceHotelAdd(bookingId: bookingId, serviceHotelId: serviceHotelId, userId: userId);
        }

        [HttpGet("BookingServiceFerryAdd")]
        public void BookingServiceFerryAdd(
            System.Guid bookingId,
            System.Guid serviceFerryId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceFerryAdd(bookingId: bookingId, serviceFerryId: serviceFerryId, userId: userId);
        }

        [HttpGet("BookingServiceCarRentalAdd")]
        public void BookingServiceCarRentalAdd(
            System.Guid bookingId,
            System.Guid serviceCarRentalId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceCarRentalAdd(bookingId: bookingId, serviceCarRentalId: serviceCarRentalId, userId: userId);
        }

        [HttpGet("BookingServiceSpecialServiceRequestAdd")]
        public void BookingServiceSpecialServiceRequestAdd(
            System.Guid bookingId,
            System.Guid serviceSpecialServiceRequestId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceSpecialServiceRequestAdd(bookingId: bookingId, serviceSpecialServiceRequestId: serviceSpecialServiceRequestId, userId: userId);
        }

        [HttpGet("BookingServiceRequestRemove")]
        public void BookingServiceRequestRemove(
            System.Guid bookingServiceRequestId,
            System.Guid userId
            ) {

            new BookingService().BookingServiceRequestRemove(bookingServiceRequestId: bookingServiceRequestId, userId: userId);
        }

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
