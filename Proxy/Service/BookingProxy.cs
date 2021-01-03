/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:20:52 AM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of Booking's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IBookingService")]
    public partial interface IBookingService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBookingEmpty", ReplyAction="http://tempuri.org/IBookingService/GetBookingEmptyResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.BookingContract GetBookingEmpty(System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBookingEmpty", ReplyAction="http://tempuri.org/IBookingService/GetBookingEmptyResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.BookingContract> GetBookingEmptyAsync(System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/CreateBooking", ReplyAction="http://tempuri.org/IBookingService/CreateBookingResponse")]
        System.Guid CreateBooking(string bookingSourceRcd, System.Guid flightId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/CreateBooking", ReplyAction="http://tempuri.org/IBookingService/CreateBookingResponse")]
        System.Threading.Tasks.Task<System.Guid> CreateBookingAsync(string bookingSourceRcd, System.Guid flightId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBooking", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingResponse")]
        System.Guid UpdateBooking(System.Guid bookingId, string bookingSourceRcd, string locator, string email, string receivedFrom, string comment, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBooking", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingResponse")]
        System.Threading.Tasks.Task<System.Guid> UpdateBookingAsync(System.Guid bookingId, string bookingSourceRcd, string locator, string email, string receivedFrom, string comment, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBooking", ReplyAction="http://tempuri.org/IBookingService/GetBookingResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.BookingContract GetBooking(System.Guid bookingId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBooking", ReplyAction="http://tempuri.org/IBookingService/GetBookingResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.BookingContract> GetBookingAsync(System.Guid bookingId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage1", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage1Response")]
        void UpdateBookingPage1(System.Guid bookingId, string bookingSourceRcd, string locator, string receivedFrom, string comment, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage1", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage1Response")]
        System.Threading.Tasks.Task UpdateBookingPage1Async(System.Guid bookingId, string bookingSourceRcd, string locator, string receivedFrom, string comment, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage2", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage2Response")]
        void UpdateBookingPage2(System.Guid bookingId, string eMail, string comment, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage2", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage2Response")]
        System.Threading.Tasks.Task UpdateBookingPage2Async(System.Guid bookingId, string eMail, string comment, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage3", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage3Response")]
        void UpdateBookingPage3(System.Guid bookingId, string addressTypeRcd, string addressOne, string addressTwo, string addressThree, string city, string street, string state, string district, string province, string zipCode, string poBox, string comment, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage3", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage3Response")]
        System.Threading.Tasks.Task UpdateBookingPage3Async(System.Guid bookingId, string addressTypeRcd, string addressOne, string addressTwo, string addressThree, string city, string street, string state, string district, string province, string zipCode, string poBox, string comment, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage4", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage4Response")]
        void UpdateBookingPage4(System.Guid bookingId, string[] passengers, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/UpdateBookingPage4", ReplyAction="http://tempuri.org/IBookingService/UpdateBookingPage4Response")]
        System.Threading.Tasks.Task UpdateBookingPage4Async(System.Guid bookingId, string[] passengers, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerAdd", ReplyAction="http://tempuri.org/IBookingService/PassengerAddResponse")]
        void PassengerAdd(System.Guid bookingId, string passengerTypeRcd, string passengerName, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerAdd", ReplyAction="http://tempuri.org/IBookingService/PassengerAddResponse")]
        System.Threading.Tasks.Task PassengerAddAsync(System.Guid bookingId, string passengerTypeRcd, string passengerName, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerRemove", ReplyAction="http://tempuri.org/IBookingService/PassengerRemoveResponse")]
        void PassengerRemove(System.Guid bookingPassengerId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerRemove", ReplyAction="http://tempuri.org/IBookingService/PassengerRemoveResponse")]
        System.Threading.Tasks.Task PassengerRemoveAsync(System.Guid bookingPassengerId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerUpdate", ReplyAction="http://tempuri.org/IBookingService/PassengerUpdateResponse")]
        void PassengerUpdate(System.Guid bookingPassengerId, string passengerTypeRcd, string passengerName, string defaultStateRcd, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerUpdate", ReplyAction="http://tempuri.org/IBookingService/PassengerUpdateResponse")]
        System.Threading.Tasks.Task PassengerUpdateAsync(System.Guid bookingPassengerId, string passengerTypeRcd, string passengerName, string defaultStateRcd, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentCardAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentCardAddResponse")]
        void PaymentCardAdd(System.Guid bookingId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentCardContract cardContract, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentCardAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentCardAddResponse")]
        System.Threading.Tasks.Task PaymentCardAddAsync(System.Guid bookingId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentCardContract cardContract, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentCashAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentCashAddResponse")]
        void PaymentCashAdd(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentCashAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentCashAddResponse")]
        System.Threading.Tasks.Task PaymentCashAddAsync(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentVoucherAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentVoucherAddResponse")]
        void PaymentVoucherAdd(System.Guid bookingId, System.Guid financialVoucherId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentVoucherAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentVoucherAddResponse")]
        System.Threading.Tasks.Task PaymentVoucherAddAsync(System.Guid bookingId, System.Guid financialVoucherId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentBankAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentBankAddResponse")]
        void PaymentBankAdd(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, string financialBankAccountNumberTypeRcd, string bankName, string bankAccount, string bankNumber, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentBankAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentBankAddResponse")]
        System.Threading.Tasks.Task PaymentBankAddAsync(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, string financialBankAccountNumberTypeRcd, string bankName, string bankAccount, string bankNumber, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentAccountingAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentAccountingAddResponse")]
        void PaymentAccountingAdd(System.Guid bookingId, decimal amount, decimal roundingAmount, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentAccountingAdd", ReplyAction="http://tempuri.org/IBookingService/PaymentAccountingAddResponse")]
        System.Threading.Tasks.Task PaymentAccountingAddAsync(System.Guid bookingId, decimal amount, decimal roundingAmount, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentGetCurrency", ReplyAction="http://tempuri.org/IBookingService/PaymentGetCurrencyResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialCurrencyContract PaymentGetCurrency(System.Guid financialCurrencyId, System.Guid againstFinancialCurrencyId, System.DateTime currencyDateTime);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PaymentGetCurrency", ReplyAction="http://tempuri.org/IBookingService/PaymentGetCurrencyResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialCurrencyContract> PaymentGetCurrencyAsync(System.Guid financialCurrencyId, System.Guid againstFinancialCurrencyId, System.DateTime currencyDateTime);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/FlightAdd", ReplyAction="http://tempuri.org/IBookingService/FlightAddResponse")]
        void FlightAdd(System.Guid bookingId, System.Guid flightId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/FlightAdd", ReplyAction="http://tempuri.org/IBookingService/FlightAddResponse")]
        System.Threading.Tasks.Task FlightAddAsync(System.Guid bookingId, System.Guid flightId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/FlightRemove", ReplyAction="http://tempuri.org/IBookingService/FlightRemoveResponse")]
        void FlightRemove(System.Guid bookingId, System.Guid bookingFlightSegmentId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/FlightRemove", ReplyAction="http://tempuri.org/IBookingService/FlightRemoveResponse")]
        System.Threading.Tasks.Task FlightRemoveAsync(System.Guid bookingId, System.Guid bookingFlightSegmentId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/SimulateBookings", ReplyAction="http://tempuri.org/IBookingService/SimulateBookingsResponse")]
        void SimulateBookings(System.DateTime fromDateTime, System.DateTime untilDateTime, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/SimulateBookings", ReplyAction="http://tempuri.org/IBookingService/SimulateBookingsResponse")]
        System.Threading.Tasks.Task SimulateBookingsAsync(System.DateTime fromDateTime, System.DateTime untilDateTime, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingConfirm", ReplyAction="http://tempuri.org/IBookingService/BookingConfirmResponse")]
        void BookingConfirm(System.Guid bookingId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingConfirm", ReplyAction="http://tempuri.org/IBookingService/BookingConfirmResponse")]
        System.Threading.Tasks.Task BookingConfirmAsync(System.Guid bookingId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/LocatorCreate", ReplyAction="http://tempuri.org/IBookingService/LocatorCreateResponse")]
        string LocatorCreate();
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/LocatorCreate", ReplyAction="http://tempuri.org/IBookingService/LocatorCreateResponse")]
        System.Threading.Tasks.Task<System.String> LocatorCreateAsync();
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingFinancialBalance", ReplyAction="http://tempuri.org/IBookingService/BookingFinancialBalanceResponse")]
        decimal BookingFinancialBalance(System.Guid bookingId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingFinancialBalance", ReplyAction="http://tempuri.org/IBookingService/BookingFinancialBalanceResponse")]
        System.Threading.Tasks.Task<System.Decimal> BookingFinancialBalanceAsync(System.Guid bookingId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/SendBookingConfirmationByEmail", ReplyAction="http://tempuri.org/IBookingService/SendBookingConfirmationByEmailResponse")]
        void SendBookingConfirmationByEmail(System.Guid bookingId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/SendBookingConfirmationByEmail", ReplyAction="http://tempuri.org/IBookingService/SendBookingConfirmationByEmailResponse")]
        System.Threading.Tasks.Task SendBookingConfirmationByEmailAsync(System.Guid bookingId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerCheckIn", ReplyAction="http://tempuri.org/IBookingService/PassengerCheckInResponse")]
        void PassengerCheckIn(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerCheckIn", ReplyAction="http://tempuri.org/IBookingService/PassengerCheckInResponse")]
        System.Threading.Tasks.Task PassengerCheckInAsync(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerCheckOut", ReplyAction="http://tempuri.org/IBookingService/PassengerCheckOutResponse")]
        void PassengerCheckOut(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/PassengerCheckOut", ReplyAction="http://tempuri.org/IBookingService/PassengerCheckOutResponse")]
        System.Threading.Tasks.Task PassengerCheckOutAsync(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceHotelAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceHotelAddResponse")]
        void BookingServiceHotelAdd(System.Guid bookingId, System.Guid serviceHotelId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceHotelAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceHotelAddResponse")]
        System.Threading.Tasks.Task BookingServiceHotelAddAsync(System.Guid bookingId, System.Guid serviceHotelId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceFerryAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceFerryAddResponse")]
        void BookingServiceFerryAdd(System.Guid bookingId, System.Guid serviceFerryId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceFerryAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceFerryAddResponse")]
        System.Threading.Tasks.Task BookingServiceFerryAddAsync(System.Guid bookingId, System.Guid serviceFerryId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceCarRentalAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceCarRentalAddResponse")]
        void BookingServiceCarRentalAdd(System.Guid bookingId, System.Guid serviceCarRentalId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceCarRentalAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceCarRentalAddResponse")]
        System.Threading.Tasks.Task BookingServiceCarRentalAddAsync(System.Guid bookingId, System.Guid serviceCarRentalId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceSpecialServiceRequestAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceSpecialServiceRequestAddResponse" +
            "")]
        void BookingServiceSpecialServiceRequestAdd(System.Guid bookingId, System.Guid serviceSpecialServiceRequestId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceSpecialServiceRequestAdd", ReplyAction="http://tempuri.org/IBookingService/BookingServiceSpecialServiceRequestAddResponse" +
            "")]
        System.Threading.Tasks.Task BookingServiceSpecialServiceRequestAddAsync(System.Guid bookingId, System.Guid serviceSpecialServiceRequestId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceRequestRemove", ReplyAction="http://tempuri.org/IBookingService/BookingServiceRequestRemoveResponse")]
        void BookingServiceRequestRemove(System.Guid bookingServiceRequestId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/BookingServiceRequestRemove", ReplyAction="http://tempuri.org/IBookingService/BookingServiceRequestRemoveResponse")]
        System.Threading.Tasks.Task BookingServiceRequestRemoveAsync(System.Guid bookingServiceRequestId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/FinancialCurrencyUpdate", ReplyAction="http://tempuri.org/IBookingService/FinancialCurrencyUpdateResponse")]
        void FinancialCurrencyUpdate(string currencyCode, string againstCurrencyCode, decimal rate, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/FinancialCurrencyUpdate", ReplyAction="http://tempuri.org/IBookingService/FinancialCurrencyUpdateResponse")]
        System.Threading.Tasks.Task FinancialCurrencyUpdateAsync(string currencyCode, string againstCurrencyCode, decimal rate, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingServiceChannel : IBookingService, System.ServiceModel.IClientChannel {
    }
    
    public class BookingServiceClient : System.ServiceModel.ClientBase<IBookingService>, IBookingService {
        
        public BookingServiceClient() {
        }
        
        public BookingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPort.BusinessLogicLayer.BookingContract GetBookingEmpty(System.Guid userId) {
            return base.Channel.GetBookingEmpty(userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.BookingContract> GetBookingEmptyAsync(System.Guid userId) {
            return base.Channel.GetBookingEmptyAsync(userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid CreateBooking(string bookingSourceRcd, System.Guid flightId, System.Guid userId) {
            return base.Channel.CreateBooking(bookingSourceRcd, flightId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> CreateBookingAsync(string bookingSourceRcd, System.Guid flightId, System.Guid userId) {
            return base.Channel.CreateBookingAsync(bookingSourceRcd, flightId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid UpdateBooking(System.Guid bookingId, string bookingSourceRcd, string locator, string email, string receivedFrom, string comment, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.UpdateBooking(bookingId, bookingSourceRcd, locator, email, receivedFrom, comment, financialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> UpdateBookingAsync(System.Guid bookingId, string bookingSourceRcd, string locator, string email, string receivedFrom, string comment, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.UpdateBookingAsync(bookingId, bookingSourceRcd, locator, email, receivedFrom, comment, financialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPort.BusinessLogicLayer.BookingContract GetBooking(System.Guid bookingId, System.Guid userId) {
            return base.Channel.GetBooking(bookingId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.BookingContract> GetBookingAsync(System.Guid bookingId, System.Guid userId) {
            return base.Channel.GetBookingAsync(bookingId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void UpdateBookingPage1(System.Guid bookingId, string bookingSourceRcd, string locator, string receivedFrom, string comment, System.Guid userId) {
            base.Channel.UpdateBookingPage1(bookingId, bookingSourceRcd, locator, receivedFrom, comment, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task UpdateBookingPage1Async(System.Guid bookingId, string bookingSourceRcd, string locator, string receivedFrom, string comment, System.Guid userId) {
            return base.Channel.UpdateBookingPage1Async(bookingId, bookingSourceRcd, locator, receivedFrom, comment, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void UpdateBookingPage2(System.Guid bookingId, string eMail, string comment, System.Guid userId) {
            base.Channel.UpdateBookingPage2(bookingId, eMail, comment, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task UpdateBookingPage2Async(System.Guid bookingId, string eMail, string comment, System.Guid userId) {
            return base.Channel.UpdateBookingPage2Async(bookingId, eMail, comment, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void UpdateBookingPage3(System.Guid bookingId, string addressTypeRcd, string addressOne, string addressTwo, string addressThree, string city, string street, string state, string district, string province, string zipCode, string poBox, string comment, System.Guid userId) {
            base.Channel.UpdateBookingPage3(bookingId, addressTypeRcd, addressOne, addressTwo, addressThree, city, street, state, district, province, zipCode, poBox, comment, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task UpdateBookingPage3Async(System.Guid bookingId, string addressTypeRcd, string addressOne, string addressTwo, string addressThree, string city, string street, string state, string district, string province, string zipCode, string poBox, string comment, System.Guid userId) {
            return base.Channel.UpdateBookingPage3Async(bookingId, addressTypeRcd, addressOne, addressTwo, addressThree, city, street, state, district, province, zipCode, poBox, comment, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void UpdateBookingPage4(System.Guid bookingId, string[] passengers, System.Guid userId) {
            base.Channel.UpdateBookingPage4(bookingId, passengers, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task UpdateBookingPage4Async(System.Guid bookingId, string[] passengers, System.Guid userId) {
            return base.Channel.UpdateBookingPage4Async(bookingId, passengers, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PassengerAdd(System.Guid bookingId, string passengerTypeRcd, string passengerName, System.Guid userId) {
            base.Channel.PassengerAdd(bookingId, passengerTypeRcd, passengerName, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PassengerAddAsync(System.Guid bookingId, string passengerTypeRcd, string passengerName, System.Guid userId) {
            return base.Channel.PassengerAddAsync(bookingId, passengerTypeRcd, passengerName, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PassengerRemove(System.Guid bookingPassengerId, System.Guid userId) {
            base.Channel.PassengerRemove(bookingPassengerId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PassengerRemoveAsync(System.Guid bookingPassengerId, System.Guid userId) {
            return base.Channel.PassengerRemoveAsync(bookingPassengerId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PassengerUpdate(System.Guid bookingPassengerId, string passengerTypeRcd, string passengerName, string defaultStateRcd, System.Guid userId) {
            base.Channel.PassengerUpdate(bookingPassengerId, passengerTypeRcd, passengerName, defaultStateRcd, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PassengerUpdateAsync(System.Guid bookingPassengerId, string passengerTypeRcd, string passengerName, string defaultStateRcd, System.Guid userId) {
            return base.Channel.PassengerUpdateAsync(bookingPassengerId, passengerTypeRcd, passengerName, defaultStateRcd, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PaymentCardAdd(System.Guid bookingId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentCardContract cardContract, System.Guid financialCostcentreId, System.Guid userId) {
            base.Channel.PaymentCardAdd(bookingId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, cardContract, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PaymentCardAddAsync(System.Guid bookingId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentCardContract cardContract, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.PaymentCardAddAsync(bookingId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, cardContract, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PaymentCashAdd(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            base.Channel.PaymentCashAdd(bookingId, paidAmount, paidAmountRounding, paidFinancialCurrencyId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PaymentCashAddAsync(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.PaymentCashAddAsync(bookingId, paidAmount, paidAmountRounding, paidFinancialCurrencyId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PaymentVoucherAdd(System.Guid bookingId, System.Guid financialVoucherId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            base.Channel.PaymentVoucherAdd(bookingId, financialVoucherId, paidAmount, paidAmountRounding, paidFinancialCurrencyId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PaymentVoucherAddAsync(System.Guid bookingId, System.Guid financialVoucherId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.PaymentVoucherAddAsync(bookingId, financialVoucherId, paidAmount, paidAmountRounding, paidFinancialCurrencyId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PaymentBankAdd(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, string financialBankAccountNumberTypeRcd, string bankName, string bankAccount, string bankNumber, System.Guid financialCostcentreId, System.Guid userId) {
            base.Channel.PaymentBankAdd(bookingId, paidAmount, paidAmountRounding, paidFinancialCurrencyId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, financialBankAccountNumberTypeRcd, bankName, bankAccount, bankNumber, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PaymentBankAddAsync(System.Guid bookingId, decimal paidAmount, decimal paidAmountRounding, System.Guid paidFinancialCurrencyId, decimal paidAmountBookingCurrency, decimal paidAmountRoundingBookingCurrency, System.Guid paidAmountBookingFinancialCurrencyId, string financialBankAccountNumberTypeRcd, string bankName, string bankAccount, string bankNumber, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.PaymentBankAddAsync(bookingId, paidAmount, paidAmountRounding, paidFinancialCurrencyId, paidAmountBookingCurrency, paidAmountRoundingBookingCurrency, paidAmountBookingFinancialCurrencyId, financialBankAccountNumberTypeRcd, bankName, bankAccount, bankNumber, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PaymentAccountingAdd(System.Guid bookingId, decimal amount, decimal roundingAmount, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            base.Channel.PaymentAccountingAdd(bookingId, amount, roundingAmount, financialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PaymentAccountingAddAsync(System.Guid bookingId, decimal amount, decimal roundingAmount, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            return base.Channel.PaymentAccountingAddAsync(bookingId, amount, roundingAmount, financialCurrencyId, financialCostcentreId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialCurrencyContract PaymentGetCurrency(System.Guid financialCurrencyId, System.Guid againstFinancialCurrencyId, System.DateTime currencyDateTime) {
            return base.Channel.PaymentGetCurrency(financialCurrencyId, againstFinancialCurrencyId, currencyDateTime);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialCurrencyContract> PaymentGetCurrencyAsync(System.Guid financialCurrencyId, System.Guid againstFinancialCurrencyId, System.DateTime currencyDateTime) {
            return base.Channel.PaymentGetCurrencyAsync(financialCurrencyId, againstFinancialCurrencyId, currencyDateTime);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void FlightAdd(System.Guid bookingId, System.Guid flightId, System.Guid userId) {
            base.Channel.FlightAdd(bookingId, flightId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task FlightAddAsync(System.Guid bookingId, System.Guid flightId, System.Guid userId) {
            return base.Channel.FlightAddAsync(bookingId, flightId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void FlightRemove(System.Guid bookingId, System.Guid bookingFlightSegmentId, System.Guid userId) {
            base.Channel.FlightRemove(bookingId, bookingFlightSegmentId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task FlightRemoveAsync(System.Guid bookingId, System.Guid bookingFlightSegmentId, System.Guid userId) {
            return base.Channel.FlightRemoveAsync(bookingId, bookingFlightSegmentId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void SimulateBookings(System.DateTime fromDateTime, System.DateTime untilDateTime, System.Guid userId) {
            base.Channel.SimulateBookings(fromDateTime, untilDateTime, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task SimulateBookingsAsync(System.DateTime fromDateTime, System.DateTime untilDateTime, System.Guid userId) {
            return base.Channel.SimulateBookingsAsync(fromDateTime, untilDateTime, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void BookingConfirm(System.Guid bookingId, System.Guid userId) {
            base.Channel.BookingConfirm(bookingId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task BookingConfirmAsync(System.Guid bookingId, System.Guid userId) {
            return base.Channel.BookingConfirmAsync(bookingId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public string LocatorCreate() {
            return base.Channel.LocatorCreate();
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.String> LocatorCreateAsync() {
            return base.Channel.LocatorCreateAsync();
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public decimal BookingFinancialBalance(System.Guid bookingId) {
            return base.Channel.BookingFinancialBalance(bookingId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Decimal> BookingFinancialBalanceAsync(System.Guid bookingId) {
            return base.Channel.BookingFinancialBalanceAsync(bookingId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void SendBookingConfirmationByEmail(System.Guid bookingId, System.Guid userId) {
            base.Channel.SendBookingConfirmationByEmail(bookingId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task SendBookingConfirmationByEmailAsync(System.Guid bookingId, System.Guid userId) {
            return base.Channel.SendBookingConfirmationByEmailAsync(bookingId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PassengerCheckIn(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId) {
            base.Channel.PassengerCheckIn(bookingPassengerId, bookingFlightSegmentId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PassengerCheckInAsync(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId) {
            return base.Channel.PassengerCheckInAsync(bookingPassengerId, bookingFlightSegmentId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PassengerCheckOut(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId) {
            base.Channel.PassengerCheckOut(bookingPassengerId, bookingFlightSegmentId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PassengerCheckOutAsync(System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid userId) {
            return base.Channel.PassengerCheckOutAsync(bookingPassengerId, bookingFlightSegmentId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void BookingServiceHotelAdd(System.Guid bookingId, System.Guid serviceHotelId, System.Guid userId) {
            base.Channel.BookingServiceHotelAdd(bookingId, serviceHotelId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task BookingServiceHotelAddAsync(System.Guid bookingId, System.Guid serviceHotelId, System.Guid userId) {
            return base.Channel.BookingServiceHotelAddAsync(bookingId, serviceHotelId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void BookingServiceFerryAdd(System.Guid bookingId, System.Guid serviceFerryId, System.Guid userId) {
            base.Channel.BookingServiceFerryAdd(bookingId, serviceFerryId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task BookingServiceFerryAddAsync(System.Guid bookingId, System.Guid serviceFerryId, System.Guid userId) {
            return base.Channel.BookingServiceFerryAddAsync(bookingId, serviceFerryId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void BookingServiceCarRentalAdd(System.Guid bookingId, System.Guid serviceCarRentalId, System.Guid userId) {
            base.Channel.BookingServiceCarRentalAdd(bookingId, serviceCarRentalId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task BookingServiceCarRentalAddAsync(System.Guid bookingId, System.Guid serviceCarRentalId, System.Guid userId) {
            return base.Channel.BookingServiceCarRentalAddAsync(bookingId, serviceCarRentalId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void BookingServiceSpecialServiceRequestAdd(System.Guid bookingId, System.Guid serviceSpecialServiceRequestId, System.Guid userId) {
            base.Channel.BookingServiceSpecialServiceRequestAdd(bookingId, serviceSpecialServiceRequestId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task BookingServiceSpecialServiceRequestAddAsync(System.Guid bookingId, System.Guid serviceSpecialServiceRequestId, System.Guid userId) {
            return base.Channel.BookingServiceSpecialServiceRequestAddAsync(bookingId, serviceSpecialServiceRequestId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void BookingServiceRequestRemove(System.Guid bookingServiceRequestId, System.Guid userId) {
            base.Channel.BookingServiceRequestRemove(bookingServiceRequestId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task BookingServiceRequestRemoveAsync(System.Guid bookingServiceRequestId, System.Guid userId) {
            return base.Channel.BookingServiceRequestRemoveAsync(bookingServiceRequestId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void FinancialCurrencyUpdate(string currencyCode, string againstCurrencyCode, decimal rate, System.Guid userId) {
            base.Channel.FinancialCurrencyUpdate(currencyCode, againstCurrencyCode, rate, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task FinancialCurrencyUpdateAsync(string currencyCode, string againstCurrencyCode, decimal rate, System.Guid userId) {
            return base.Channel.FinancialCurrencyUpdateAsync(currencyCode, againstCurrencyCode, rate, userId);
        }
    }
}
