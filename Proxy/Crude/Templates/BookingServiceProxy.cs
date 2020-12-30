/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 5:55:32 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// Namespace for a Business Logic Layer in a Proxy
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class BookingServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public BookingContract GetBookingEmpty(
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/GetBookingEmpty?userId={userId}";
            string jsonString = client.DownloadString(query);

            BookingContract reply =
                JsonConvert.DeserializeObject<BookingContract>(jsonString);

            return reply;
        }

        public System.Guid CreateBooking(
            System.String bookingSourceRcd,
            System.Guid flightId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/CreateBooking?bookingSourceRcd={bookingSourceRcd}&flightId={flightId}&userId={userId}";
            string jsonString = client.DownloadString(query);

            System.Guid reply =
                JsonConvert.DeserializeObject<System.Guid>(jsonString);

            return reply;
        }

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

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/UpdateBooking?bookingId={bookingId}&bookingSourceRcd={bookingSourceRcd}&locator={locator}&email={email}&receivedFrom={receivedFrom}&comment={comment}&financialCurrencyId={financialCurrencyId}&financialCostcentreId={financialCostcentreId}&userId={userId}";
            string jsonString = client.DownloadString(query);

            System.Guid reply =
                JsonConvert.DeserializeObject<System.Guid>(jsonString);

            return reply;
        }

        public BookingContract GetBooking(
            System.Guid bookingId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/GetBooking?bookingId={bookingId}&userId={userId}";
            string jsonString = client.DownloadString(query);

            BookingContract reply =
                JsonConvert.DeserializeObject<BookingContract>(jsonString);

            return reply;
        }

        public void UpdateBookingPage1(
            System.Guid bookingId,
            System.String bookingSourceRcd,
            System.String locator,
            System.String receivedFrom,
            System.String comment,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/UpdateBookingPage1?bookingId={bookingId}&bookingSourceRcd={bookingSourceRcd}&locator={locator}&receivedFrom={receivedFrom}&comment={comment}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void UpdateBookingPage2(
            System.Guid bookingId,
            System.String eMail,
            System.String comment,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/UpdateBookingPage2?bookingId={bookingId}&eMail={eMail}&comment={comment}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

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

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/UpdateBookingPage3?bookingId={bookingId}&addressTypeRcd={addressTypeRcd}&addressOne={addressOne}&addressTwo={addressTwo}&addressThree={addressThree}&city={city}&street={street}&state={state}&district={district}&province={province}&zipCode={zipCode}&poBox={poBox}&comment={comment}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void UpdateBookingPage4(
            System.Guid bookingId,
            System.String[] passengers,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/UpdateBookingPage4?bookingId={bookingId}&passengers={passengers}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PassengerAdd(
            System.Guid bookingId,
            System.String passengerTypeRcd,
            System.String passengerName,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PassengerAdd?bookingId={bookingId}&passengerTypeRcd={passengerTypeRcd}&passengerName={passengerName}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PassengerRemove(
            System.Guid bookingPassengerId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PassengerRemove?bookingPassengerId={bookingPassengerId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PassengerUpdate(
            System.Guid bookingPassengerId,
            System.String passengerTypeRcd,
            System.String passengerName,
            System.String defaultStateRcd,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PassengerUpdate?bookingPassengerId={bookingPassengerId}&passengerTypeRcd={passengerTypeRcd}&passengerName={passengerName}&defaultStateRcd={defaultStateRcd}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PaymentCardAdd(
            System.Guid bookingId,
            System.Decimal paidAmountBookingCurrency,
            System.Decimal paidAmountRoundingBookingCurrency,
            System.Guid paidAmountBookingFinancialCurrencyId,
            CrudeFinancialPaymentCardContract cardContract,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PaymentCardAdd?bookingId={bookingId}&paidAmountBookingCurrency={paidAmountBookingCurrency}&paidAmountRoundingBookingCurrency={paidAmountRoundingBookingCurrency}&paidAmountBookingFinancialCurrencyId={paidAmountBookingFinancialCurrencyId}&cardContract={cardContract}&financialCostcentreId={financialCostcentreId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

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

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PaymentCashAdd?bookingId={bookingId}&paidAmount={paidAmount}&paidAmountRounding={paidAmountRounding}&paidFinancialCurrencyId={paidFinancialCurrencyId}&paidAmountBookingCurrency={paidAmountBookingCurrency}&paidAmountRoundingBookingCurrency={paidAmountRoundingBookingCurrency}&paidAmountBookingFinancialCurrencyId={paidAmountBookingFinancialCurrencyId}&financialCostcentreId={financialCostcentreId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

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

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PaymentVoucherAdd?bookingId={bookingId}&financialVoucherId={financialVoucherId}&paidAmount={paidAmount}&paidAmountRounding={paidAmountRounding}&paidFinancialCurrencyId={paidFinancialCurrencyId}&paidAmountBookingCurrency={paidAmountBookingCurrency}&paidAmountRoundingBookingCurrency={paidAmountRoundingBookingCurrency}&paidAmountBookingFinancialCurrencyId={paidAmountBookingFinancialCurrencyId}&financialCostcentreId={financialCostcentreId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

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

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PaymentBankAdd?bookingId={bookingId}&paidAmount={paidAmount}&paidAmountRounding={paidAmountRounding}&paidFinancialCurrencyId={paidFinancialCurrencyId}&paidAmountBookingCurrency={paidAmountBookingCurrency}&paidAmountRoundingBookingCurrency={paidAmountRoundingBookingCurrency}&paidAmountBookingFinancialCurrencyId={paidAmountBookingFinancialCurrencyId}&financialBankAccountNumberTypeRcd={financialBankAccountNumberTypeRcd}&bankName={bankName}&bankAccount={bankAccount}&bankNumber={bankNumber}&financialCostcentreId={financialCostcentreId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PaymentAccountingAdd(
            System.Guid bookingId,
            System.Decimal amount,
            System.Decimal roundingAmount,
            System.Guid financialCurrencyId,
            System.Guid financialCostcentreId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PaymentAccountingAdd?bookingId={bookingId}&amount={amount}&roundingAmount={roundingAmount}&financialCurrencyId={financialCurrencyId}&financialCostcentreId={financialCostcentreId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public CrudeFinancialCurrencyContract PaymentGetCurrency(
            System.Guid financialCurrencyId,
            System.Guid againstFinancialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PaymentGetCurrency?financialCurrencyId={financialCurrencyId}&againstFinancialCurrencyId={againstFinancialCurrencyId}&currencyDateTime={currencyDateTime}";
            string jsonString = client.DownloadString(query);

            CrudeFinancialCurrencyContract reply =
                JsonConvert.DeserializeObject<CrudeFinancialCurrencyContract>(jsonString);

            return reply;
        }

        public void FlightAdd(
            System.Guid bookingId,
            System.Guid flightId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/FlightAdd?bookingId={bookingId}&flightId={flightId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void FlightRemove(
            System.Guid bookingId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/FlightRemove?bookingId={bookingId}&bookingFlightSegmentId={bookingFlightSegmentId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void SimulateBookings(
            System.DateTime fromDateTime,
            System.DateTime untilDateTime,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/SimulateBookings?fromDateTime={fromDateTime}&untilDateTime={untilDateTime}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void BookingConfirm(
            System.Guid bookingId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingConfirm?bookingId={bookingId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public System.String LocatorCreate(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/LocatorCreate?";
            string jsonString = client.DownloadString(query);

            System.String reply =
                JsonConvert.DeserializeObject<System.String>(jsonString);

            return reply;
        }

        public System.Decimal BookingFinancialBalance(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingFinancialBalance?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            System.Decimal reply =
                JsonConvert.DeserializeObject<System.Decimal>(jsonString);

            return reply;
        }

        public void SendBookingConfirmationByEmail(
            System.Guid bookingId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/SendBookingConfirmationByEmail?bookingId={bookingId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PassengerCheckIn(
            System.Guid bookingPassengerId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PassengerCheckIn?bookingPassengerId={bookingPassengerId}&bookingFlightSegmentId={bookingFlightSegmentId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void PassengerCheckOut(
            System.Guid bookingPassengerId,
            System.Guid bookingFlightSegmentId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/PassengerCheckOut?bookingPassengerId={bookingPassengerId}&bookingFlightSegmentId={bookingFlightSegmentId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void BookingServiceHotelAdd(
            System.Guid bookingId,
            System.Guid serviceHotelId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingServiceHotelAdd?bookingId={bookingId}&serviceHotelId={serviceHotelId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void BookingServiceFerryAdd(
            System.Guid bookingId,
            System.Guid serviceFerryId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingServiceFerryAdd?bookingId={bookingId}&serviceFerryId={serviceFerryId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void BookingServiceCarRentalAdd(
            System.Guid bookingId,
            System.Guid serviceCarRentalId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingServiceCarRentalAdd?bookingId={bookingId}&serviceCarRentalId={serviceCarRentalId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void BookingServiceSpecialServiceRequestAdd(
            System.Guid bookingId,
            System.Guid serviceSpecialServiceRequestId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingServiceSpecialServiceRequestAdd?bookingId={bookingId}&serviceSpecialServiceRequestId={serviceSpecialServiceRequestId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void BookingServiceRequestRemove(
            System.Guid bookingServiceRequestId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/BookingServiceRequestRemove?bookingServiceRequestId={bookingServiceRequestId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void FinancialCurrencyUpdate(
            System.String currencyCode,
            System.String againstCurrencyCode,
            System.Decimal rate,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/BookingService/FinancialCurrencyUpdate?currencyCode={currencyCode}&againstCurrencyCode={againstCurrencyCode}&rate={rate}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

    }
}
