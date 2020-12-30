using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.ServiceModel;
using System.Text;
using SolutionNorSolutionPort.DataAccessLayer;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract()]
        BookingContract GetBookingEmpty(
            Guid userId
            );

        [OperationContract()]
        Guid CreateBooking(
            string bookingSourceRcd,
            Guid flightId,
            Guid userId
            );

        [OperationContract()]
        Guid UpdateBooking(
            Guid bookingId,
            string bookingSourceRcd,
            string locator,
            string email,
            string receivedFrom,
            string comment,
            Guid financialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            );

        [OperationContract()]
        BookingContract GetBooking(
            Guid bookingId,
            Guid userId
            );

        [OperationContract()]
        void UpdateBookingPage1(
            Guid bookingId,
            string bookingSourceRcd,
            string locator,
            string receivedFrom,
            string comment,
            Guid userId
            );

        [OperationContract()]
        void UpdateBookingPage2(
            Guid bookingId,
            string eMail,
            string comment,
            Guid userId
            );

        [OperationContract()]
        void UpdateBookingPage3(
            Guid bookingId,
            string addressTypeRcd,
            string addressOne,
            string addressTwo,
            string addressThree,
            string city,
            string street,
            string state,
            string district,
            string province,
            string zipCode,
            string poBox,
            string comment,
            Guid userId
            );

        [OperationContract()]
        void UpdateBookingPage4(
            Guid bookingId,
            string[] passengers,
            Guid userId
            );

        [OperationContract()]
        void PassengerAdd(
            Guid bookingId,
            string passengerTypeRcd,
            string passengerName,
            Guid userId
            );

        [OperationContract()]
        void PassengerRemove(
            Guid bookingPassengerId,
            Guid userId
            );

        [OperationContract()]
        void PassengerUpdate(
            Guid bookingPassengerId,
            string passengerTypeRcd,
            string passengerName,
            string defaultStateRcd,
            Guid userId
            );

        [OperationContract()]
        void PaymentCardAdd(
            Guid bookingId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            CrudeFinancialPaymentCardContract cardContract,
            Guid financialCostcentreId,
            Guid userId
            );

        [OperationContract()]
        void PaymentCashAdd(
            Guid bookingId,
            decimal paidAmount,
            decimal paidAmountRounding,
            Guid paidFinancialCurrencyId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            );

        [OperationContract()]
        void PaymentVoucherAdd(
            Guid bookingId,
            Guid financialVoucherId,
            decimal paidAmount,
            decimal paidAmountRounding,
            Guid paidFinancialCurrencyId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            );

        [OperationContract()]
        void PaymentBankAdd(
            Guid bookingId,
            decimal paidAmount,
            decimal paidAmountRounding,
            Guid paidFinancialCurrencyId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            string financialBankAccountNumberTypeRcd,
            string bankName,
            string bankAccount,
            string bankNumber,
            Guid financialCostcentreId,
            Guid userId
            );

        [OperationContract()]
        void PaymentAccountingAdd(
            Guid bookingId,
            decimal amount,
            decimal roundingAmount,
            Guid financialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            );

        [OperationContract()]
        CrudeFinancialCurrencyContract PaymentGetCurrency(
            Guid financialCurrencyId,
            Guid againstFinancialCurrencyId,
            DateTime currencyDateTime
            );

        [OperationContract()]
        void FlightAdd(
            Guid bookingId,
            Guid flightId,
            Guid userId
            );

        [OperationContract()]
        void FlightRemove(
            Guid bookingId,
            Guid bookingFlightSegmentId,
            Guid userId
            );

        /// <summary>
        /// Add fake bookings
        /// </summary>
        [OperationContract()]
        void SimulateBookings(
            DateTime fromDateTime,
            DateTime untilDateTime,
            Guid userId
            );

        [OperationContract()]
        void BookingConfirm(
            Guid bookingId,
            Guid userId
            );

        [OperationContract()]
        string LocatorCreate();

        [OperationContract()]
        decimal BookingFinancialBalance(
            Guid bookingId
            );

        [OperationContract()]
        void SendBookingConfirmationByEmail(
            Guid bookingId,
            Guid userId
            );

        [OperationContract()]
        void PassengerCheckIn(
            Guid bookingPassengerId,
            Guid bookingFlightSegmentId,
            Guid userId
            );

        [OperationContract()]
        void PassengerCheckOut(
            Guid bookingPassengerId,
            Guid bookingFlightSegmentId,
            Guid userId
            );

        [OperationContract()]
        void BookingServiceHotelAdd(
            Guid bookingId,
            Guid serviceHotelId,
            Guid userId
            );

        [OperationContract()]
        void BookingServiceFerryAdd(
            Guid bookingId,
            Guid serviceFerryId,
            Guid userId
            );

        [OperationContract()]
        void BookingServiceCarRentalAdd(
            Guid bookingId,
            Guid serviceCarRentalId,
            Guid userId
            );

        [OperationContract()]
        void BookingServiceSpecialServiceRequestAdd(
            Guid bookingId,
            Guid serviceSpecialServiceRequestId,
            Guid userId
            );

        [OperationContract()]
        void BookingServiceRequestRemove(
            Guid bookingServiceRequestId,
            Guid userId
            );

        [OperationContract()]
        void FinancialCurrencyUpdate(
            string currencyCode,
            string againstCurrencyCode,
            decimal rate,
            Guid userId
            );
    }

    /// <domain>Booking</domain>
    public class BookingService : IBookingService
    {
        public void FinancialCurrencyUpdate(
            string currencyCode,
            string againstCurrencyCode,
            decimal rate,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "FinancialCurrencyUpdate", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // find internal currency type
                    var financialCurrencyTypeRefData = new CrudeFinancialCurrencyTypeRefData();
                    financialCurrencyTypeRefData.FetchByFinancialCurrencyTypeRcd(currencyCode);

                    var againstFinancialCurrencyTypeRefData = new CrudeFinancialCurrencyTypeRefData();
                    againstFinancialCurrencyTypeRefData.FetchByFinancialCurrencyTypeRcd(againstCurrencyCode);

                    if ( !string.IsNullOrEmpty(financialCurrencyTypeRefData.FinancialCurrencyTypeRcd)
                        && !string.IsNullOrEmpty(againstFinancialCurrencyTypeRefData.FinancialCurrencyTypeRcd)
                        && currencyCode != againstCurrencyCode
                        ) {

                        // find old currency rate
                        CrudeFinancialCurrencyData financialCurrencyData = 
                            CrudeFinancialCurrencyData.FetchByFinancialCurrencyTypeCodeActive(
                                currencyCode,
                                againstCurrencyCode
                                );

                        if ( financialCurrencyData.FinancialCurrencyId != Guid.Empty ) {
                            if ( financialCurrencyData.EqualsAmount != rate ) {
                                // invalidate rate
                                financialCurrencyData.ValidUntilDateTime = DateTime.UtcNow;
                                financialCurrencyData.Update(connection, transaction);

                                // add new rate
                                financialCurrencyData.FinancialCurrencyId = Guid.NewGuid();
                                financialCurrencyData.EqualsAmount = rate;
                                financialCurrencyData.ValidFromDateTime = financialCurrencyData.ValidUntilDateTime;
                                financialCurrencyData.ValidUntilDateTime = DateTime.MinValue; // null
                                financialCurrencyData.UserId = userId;
                                financialCurrencyData.DateTime = DateTime.UtcNow;
                                financialCurrencyData.Insert(connection, transaction);
                            }
                        } else {
                            // add new rate
                            financialCurrencyData.FinancialCurrencyId = Guid.NewGuid();
                            financialCurrencyData.FinancialCurrencyTypeCode = currencyCode;
                            financialCurrencyData.FinancialCurrencyTypeName = financialCurrencyTypeRefData.FinancialCurrencyTypeName;
                            financialCurrencyData.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = againstCurrencyCode;
                            financialCurrencyData.Amount = 1;
                            financialCurrencyData.EqualsAmount = rate;
                            financialCurrencyData.ValidFromDateTime = DateTime.UtcNow;
                            financialCurrencyData.ValidUntilDateTime = DateTime.MinValue; // null
                            financialCurrencyData.UserId = userId;
                            financialCurrencyData.DateTime = DateTime.UtcNow;
                            financialCurrencyData.Insert(connection, transaction);
                        }
                    }

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// remove service request transaction
        /// </summary>
        public void BookingServiceRequestRemove(
            Guid bookingServiceRequestId,
            Guid userId
            ) {
            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "BookingServiceRequestRemove", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // get booking transaction
                    /*
                    var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                    financialBookingTransaction.FetchByFinancialBookingTransactionId(financialBookingTransactionId);

                    // get financial service record
                    var financialServiceData = new CrudeFinancialServiceData();
                    financialServiceData.FetchByFinancialServiceId(financialBookingTransaction.FinancialServiceId);
                    */
                    // mark service request as removed
                    // todo, use became here?
                    var bookingServiceRequestData = new CrudeBookingServiceRequestData();
                    //bookingServiceRequestData.FetchByBookingServiceRequestId(financialServiceData.BookingServiceRequestId);
                    bookingServiceRequestData.FetchByBookingServiceRequestId(bookingServiceRequestId);
                    bookingServiceRequestData.ServiceRequestStatusRcd = ServiceRequestStatusRef.Removed;
                    bookingServiceRequestData.Update(connection, transaction);

                    // change into a 'remove' transaction
                    /*
                    financialBookingTransaction.FinancialBookingTransactionId = Guid.NewGuid();
                    financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Removed;

                    financialBookingTransaction.TransactionNumber = 
                        BookingData.TransactionNumberHighest(
                            connection, 
                            transaction, 
                            financialBookingTransaction.BookingId
                            ) + 1;

                    financialBookingTransaction.UserId = userId;
                    financialBookingTransaction.DateTime = DateTime.UtcNow;
                    financialBookingTransaction.Insert(connection, transaction);
                    */
                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add service car rental transaction
        /// </summary>
        public void BookingServiceCarRentalAdd(
            Guid bookingId,
            Guid serviceCarRentalId,
            Guid userId
            ) {
            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "BookingServiceCarRentalAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // attach service request to booking
                    var bookingServiceRequestData = new CrudeBookingServiceRequestData();
                    bookingServiceRequestData.BookingServiceRequestId = Guid.NewGuid();
                    bookingServiceRequestData.ServiceTypeRcd = ServiceTypeRef.CarRental;
                    bookingServiceRequestData.BookingId = bookingId;
                    bookingServiceRequestData.ServiceCarRentalId = serviceCarRentalId;
                    bookingServiceRequestData.ServiceRequestStatusRcd = ServiceRequestStatusRef.SSRHasBeenRequested;
                    bookingServiceRequestData.DateTime = DateTime.UtcNow;
                    bookingServiceRequestData.UserId = userId;
                    bookingServiceRequestData.Insert(connection, transaction);

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add service hotel transaction
        /// </summary>
        public void BookingServiceHotelAdd(
            Guid bookingId,
            Guid serviceHotelId,
            Guid userId
            ) {
            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "BookingServiceHotelAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // attach service request to booking
                    var bookingServiceRequestData = new CrudeBookingServiceRequestData();
                    bookingServiceRequestData.BookingServiceRequestId = Guid.NewGuid();
                    bookingServiceRequestData.ServiceTypeRcd = ServiceTypeRef.HotelBooking;
                    bookingServiceRequestData.BookingId = bookingId;
                    bookingServiceRequestData.ServiceHotelId = serviceHotelId;
                    bookingServiceRequestData.ServiceRequestStatusRcd = ServiceRequestStatusRef.SSRHasBeenRequested;
                    bookingServiceRequestData.DateTime = DateTime.UtcNow;
                    bookingServiceRequestData.UserId = userId;
                    bookingServiceRequestData.Insert(connection, transaction);

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add service ferry transaction
        /// </summary>
        public void BookingServiceFerryAdd(
            Guid bookingId,
            Guid serviceFerryId,
            Guid userId
            ) {
            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "BookingServiceFerryAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // attach service request to booking
                    var bookingServiceRequestData = new CrudeBookingServiceRequestData();
                    bookingServiceRequestData.BookingServiceRequestId = Guid.NewGuid();
                    bookingServiceRequestData.ServiceTypeRcd = ServiceTypeRef.FerryBooking;
                    bookingServiceRequestData.BookingId = bookingId;
                    bookingServiceRequestData.ServiceFerryId = serviceFerryId;
                    bookingServiceRequestData.ServiceRequestStatusRcd = ServiceRequestStatusRef.SSRHasBeenRequested;
                    bookingServiceRequestData.DateTime = DateTime.UtcNow;
                    bookingServiceRequestData.UserId = userId;
                    bookingServiceRequestData.Insert(connection, transaction);

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add service request transaction
        /// </summary>
        public void BookingServiceSpecialServiceRequestAdd(
            Guid bookingId,
            Guid serviceSpecialServiceRequestId,
            Guid userId
            ) {
            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "BookingServiceSpecialServiceRequestAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // attach service request to booking
                    var bookingServiceRequestData = new CrudeBookingServiceRequestData();
                    bookingServiceRequestData.BookingServiceRequestId = Guid.NewGuid();
                    bookingServiceRequestData.ServiceTypeRcd = ServiceTypeRef.SpecialService;
                    bookingServiceRequestData.BookingId = bookingId;
                    bookingServiceRequestData.ServiceSpecialServiceRequestId = serviceSpecialServiceRequestId;
                    bookingServiceRequestData.ServiceRequestStatusRcd = ServiceRequestStatusRef.SSRHasBeenConfirmed;
                    bookingServiceRequestData.DateTime = DateTime.UtcNow;
                    bookingServiceRequestData.UserId = userId;
                    bookingServiceRequestData.Insert(connection, transaction);
                    /*
                    // get service details
                    // todo, make static fetcher
                    var serviceSpecialServiceRequestData = new CrudeServiceSpecialServiceRequestData();
                    serviceSpecialServiceRequestData.FetchByServiceSpecialServiceRequestId(
                        serviceSpecialServiceRequestId);

                    // attach special service to financial special service
                    var financialSpecialServiceData = new CrudeFinancialSpecialServiceData();
                    financialSpecialServiceData.FinancialSpecialServiceId = Guid.NewGuid();
                    financialSpecialServiceData.ServiceSpecialServiceRequestId = serviceSpecialServiceRequestId;
                    financialSpecialServiceData.Quantity = 1;
                    financialSpecialServiceData.Amount = serviceSpecialServiceRequestData.Amount;
                    financialSpecialServiceData.FinancialCurrencyId = serviceSpecialServiceRequestData.FinancialCurrencyId;
                    financialSpecialServiceData.DateTime = DateTime.UtcNow;
                    financialSpecialServiceData.UserId = userId;
                    financialSpecialServiceData.Insert(connection, transaction);

                    // make financial service record
                    // todo, currency conversion
                    var financialServiceData = new CrudeFinancialServiceData();
                    financialServiceData.FinancialServiceId = Guid.NewGuid();
                    financialServiceData.BookingServiceRequestId = bookingServiceRequestData.BookingServiceRequestId;
                    financialServiceData.FinancialServiceTypeRcd = FinancialServiceTypeRef.SpecialService;
                    financialServiceData.FinancialSpecialServiceId = financialSpecialServiceData.FinancialSpecialServiceId;
                    financialServiceData.Amount = serviceSpecialServiceRequestData.Amount;
                    financialServiceData.FinancialCurrencyId = serviceSpecialServiceRequestData.FinancialCurrencyId;
                    financialServiceData.DateTime = DateTime.UtcNow;
                    financialServiceData.UserId = userId;
                    financialServiceData.Insert(connection, transaction);

                    // get booking
                    var booking = new CrudeBookingData();
                    booking.FetchByBookingId(bookingId);

                    // attach financial service to financial booking transaction
                    var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                    financialBookingTransaction.FinancialBookingTransactionId = Guid.NewGuid();
                    financialBookingTransaction.BookingId = bookingId;

                    financialBookingTransaction.TransactionNumber = 
                        BookingData.TransactionNumberHighest(
                            connection, 
                            transaction, 
                            bookingId
                            ) + 1;

                    financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                    financialBookingTransaction.FinancialServiceId = financialServiceData.FinancialServiceId;
                    financialBookingTransaction.Amount = serviceSpecialServiceRequestData.Amount;
                    financialBookingTransaction.FinancialCurrencyId = serviceSpecialServiceRequestData.FinancialCurrencyId;
                    financialBookingTransaction.FinancialCostcentreId = booking.FinancialCostcentreId;                      
                    financialBookingTransaction.UserId = userId;
                    financialBookingTransaction.DateTime = DateTime.UtcNow;
                    financialBookingTransaction.Insert(connection, transaction);
                    */
                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        public BookingContract GetBookingEmpty(
            Guid userId
            ) {

            BookingContract bookingContract = new BookingContract();

            Logging log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "GetBookingEmpty", userId);

            try {
                bookingContract.Booking = new CrudeBookingContract();

                // todo, fetch all in one go, use linq to search
                // default costcentre
                List<CrudeDefaultSystemSettingData> systemSettingData = 
                    CrudeDefaultSystemSettingData.FetchWithFilter(
                        Guid.Empty,
                        DefaultSystemSettingRef.BookingCostcentre,
                        string.Empty,
                        Guid.Empty,
                        DateTime.MinValue
                        );

                if ( systemSettingData.Count > 0 ) {
                    var costcentreData = new CrudeFinancialCostcentreData();
                    costcentreData.FetchByFinancialCostcentreCode(
                            systemSettingData[0].DefaultSystemSettingValue
                            );

                    bookingContract.Booking.FinancialCostcentreId = costcentreData.FinancialCostcentreId;
                }

                // default currency
                systemSettingData =
                    CrudeDefaultSystemSettingData.FetchWithFilter(
                        Guid.Empty,
                        DefaultSystemSettingRef.BookingCurrency,
                        string.Empty,
                        Guid.Empty,
                        DateTime.MinValue
                        );

                if ( systemSettingData.Count > 0 ) {
                    CrudeFinancialCurrencyData currencyData = FinancialSearch.GetBookingCurrencyConversion(
                        systemSettingData[0].DefaultSystemSettingValue,
                        DateTime.UtcNow
                        );

                    if ( currencyData.FinancialCurrencyId == Guid.Empty )
                        throw new Exception("Can't find default currency");

                    bookingContract.Booking.FinancialCurrencyId = currencyData.FinancialCurrencyId;
                }

                // locator
                bookingContract.BookingIdentifier = new CrudeBookingIdentifierContract();
                bookingContract.BookingIdentifier.BookingIdentifierTypeRcd = BookingIdentifierTypeRef.RecordLocator;
                bookingContract.BookingIdentifier.BookingIdentifierValue = LocatorCreate();

                bookingContract.Booking.UserId = userId;
                bookingContract.Booking.DateTime = DateTime.UtcNow;

                log.PerformanceTimeStop();
            } catch ( Exception ex ) {
                log.Error(ex);
                throw ex;
            }

            return bookingContract;
        }

        public BookingContract GetBooking(
            Guid bookingId,
            Guid userId
            ) {

            BookingContract bookingContract = new BookingContract();
            Logging log = Logging.PerformanceTimeStart(
                    "Booking", "BusinessLogicLayer", "BookingService", "GetBooking", userId);

            try {
                // get booking
                bookingContract.Booking = new CrudeBookingService().FetchByBookingId(bookingId);
                bookingContract.BookingAddress = new CrudeAddressService().FetchByAddressId(bookingContract.Booking.AddressId);

                // get passengers ( crude )
                var passenger = new CrudePassengerData();
                List<CrudePassengerData> passengers = passenger.FetchByBookingId(bookingId);
                bookingContract.Passenger = CrudePassengerService.DataListToContractList(passengers);

                // get booking passengers ( method )
                bookingContract.BookingPassengers = new BookingSearchService().BookingPassengers(bookingId);

                // get identifier
                var identifierData = new CrudeBookingIdentifierData();
                identifierData.FetchByBookingIdLast(bookingId);

                bookingContract.BookingIdentifier = new CrudeBookingIdentifierContract();
                CrudeBookingIdentifierService.DataToContract(identifierData, bookingContract.BookingIdentifier);

                // get contact method
                var contactData = new CrudeBookingContactMethodData();
                contactData.FetchByBookingIdLast(bookingId);

                bookingContract.BookingContactMethod = new CrudeBookingContactMethodContract();
                CrudeBookingContactMethodService.DataToContract(contactData, bookingContract.BookingContactMethod);

                // get counts
                var bookingEventCountData = new BookingEventCountData();
                bookingEventCountData = new BookingSearch().BookingEventCount(bookingId);
                bookingContract.BookingEventCount = new BookingEventCountContract();
                new BookingEventCount().DataToContract(bookingEventCountData, bookingContract.BookingEventCount);

                log.PerformanceTimeStop();
            } catch ( Exception ex ) {
                log.Error(ex);
                throw ex;
            }

            return bookingContract;
        }

        public Guid CreateBooking(
            string bookingSourceRcd,
            Guid flightId,
            Guid userId
            ) {

            BookingContract bookingContract = 
                GetBookingEmpty(userId);

            bookingContract.Booking.BookingSourceRcd = BookingSourceRef.InternalSystem;

            bookingContract.BookingIdentifier = new CrudeBookingIdentifierContract();
            bookingContract.BookingIdentifier.BookingIdentifierTypeRcd = BookingIdentifierTypeRef.RecordLocator;
            bookingContract.BookingIdentifier.BookingIdentifierValue = LocatorCreate();

            bookingContract.BookingContactMethod = new CrudeBookingContactMethodContract();

            bookingContract.Booking.BookingId =
                UpdateBooking(
                    bookingContract.Booking.BookingId,
                    bookingContract.Booking.BookingSourceRcd,
                    bookingContract.BookingIdentifier.BookingIdentifierValue,
                    bookingContract.BookingContactMethod.ContactMethodWay,
                    bookingContract.Booking.ReceivedFrom,
                    bookingContract.Booking.Comment,
                    bookingContract.Booking.FinancialCurrencyId,
                    bookingContract.Booking.FinancialCostcentreId,
                    userId
                    );

            FlightAdd(
                bookingContract.Booking.BookingId,
                flightId,
                userId
                );

            return bookingContract.Booking.BookingId;
        }

        public Guid UpdateBooking(
            Guid bookingId,
            string bookingSourceRcd,
            string locator,
            string email,
            string receivedFrom,
            string comment,
            Guid financialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            ) {

            Logging log = 
                Logging.PerformanceTimeStart(
                        "Booking",
                        "BusinessLogicLayer",
                        "BookingService",
                        "UpdateBooking",
                        userId
                        );

            var booking = new CrudeBookingData();
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);

                try {
                    // booking
                    booking.FetchByBookingId(bookingId, connection, transaction);

                    if ( booking.BookingId == Guid.Empty ) {
                        // does not exist, create it
                        booking.BookingSourceRcd = string.IsNullOrEmpty(bookingSourceRcd) ? BookingSourceRef.InternalSystem : bookingSourceRcd;
                        booking.ReceivedFrom = receivedFrom;
                        booking.Comment = comment;
                        booking.FinancialCurrencyId = financialCurrencyId;
                        booking.FinancialCostcentreId = financialCostcentreId;
                        booking.UserId = userId;
                        booking.DateTime = DateTime.UtcNow;
                        booking.Insert(connection, transaction);

                        // booking event
                        var bookingEvent = new CrudeBookingEventData();
                        bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingCreated;
                        bookingEvent.BookingId = booking.BookingId;
                        bookingEvent.UserId = userId;
                        bookingEvent.DateTime = DateTime.UtcNow;
                        bookingEvent.Insert(connection, transaction);

                        // roundup
                        CrudeReportingRoundupData.UpdateOrInsert(
                                booking.DateTime,
                                ReportingRoundupTypeRef.BookingsPerDay,
                                "BC",
                                1,
                                userId,
                                connection,
                                transaction
                                );

                    } else {
                        booking.BookingSourceRcd = string.IsNullOrEmpty(bookingSourceRcd) ? BookingSourceRef.InternalSystem : bookingSourceRcd;
                        booking.ReceivedFrom = receivedFrom;
                        booking.Comment = comment;

                        if ( financialCurrencyId != Guid.Empty )
                            booking.FinancialCurrencyId = financialCurrencyId;

                        if ( financialCostcentreId != Guid.Empty )
                            booking.FinancialCostcentreId = financialCostcentreId;

                        booking.UserId = userId;
                        booking.DateTime = DateTime.UtcNow;
                        booking.Update(connection, transaction);

                        // booking event
                        var bookingEvent = new CrudeBookingEventData();
                        bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingUpdated;
                        bookingEvent.BookingId = booking.BookingId;
                        bookingEvent.UserId = userId;
                        bookingEvent.DateTime = DateTime.UtcNow;
                        bookingEvent.Insert(connection, transaction);

                        // roundup
                        CrudeReportingRoundupData.UpdateOrInsert(
                                booking.DateTime,
                                ReportingRoundupTypeRef.BookingsPerDay,
                                "BC",
                                1,
                                userId
                                );
                    }

                    // booking identifier, todo, what about inactivation
                    if ( !string.IsNullOrEmpty(locator) ) {
                        var bookingIdentifier = new CrudeBookingIdentifierData();
                        bookingIdentifier.BookingIdentifierTypeRcd = BookingIdentifierTypeRef.RecordLocator;
                        bookingIdentifier.BookingId = booking.BookingId;
                        bookingIdentifier.BookingIdentifierValue = locator;
                        bookingIdentifier.UserId = userId;
                        bookingIdentifier.DateTime = DateTime.UtcNow;
                        bookingIdentifier.Insert(connection, transaction);
                    }

                    // booking contact method, todo, what about inactivation
                    if ( !string.IsNullOrEmpty(email) ) {
                        var bookingContactMethod = new CrudeBookingContactMethodData();
                        bookingContactMethod.ContactMethodRcd = ContactMethodRef.EMail;
                        bookingContactMethod.BookingId = booking.BookingId;
                        bookingContactMethod.ContactMethodWay = email;
                        bookingContactMethod.UserId = userId;
                        bookingContactMethod.DateTime = DateTime.UtcNow;
                        bookingContactMethod.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop(50);
                } catch ( Exception ex ) {
                    transaction.Rollback();
                    log.Error(ex);

                    throw ex;
                }
            }

            return booking.BookingId;
        }

        /// <summary>Updates page 1 fields of a booking</summary>
        /// <returns></returns>
        public void UpdateBookingPage1(
                Guid bookingId,
                string bookingSourceRcd,
                string locator,
                string receivedFrom,
                string comment,
                Guid userId
                ) {

            Logging log = 
                Logging.PerformanceTimeStart(
                    "Booking", "BusinessLogicLayer", "BookingService", "UpdateBookingPage1",
                    userId
                    );

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    var booking = new CrudeBookingData();
                    booking.FetchByBookingId(bookingId);
                    booking.BookingSourceRcd = string.IsNullOrEmpty(bookingSourceRcd) ? BookingSourceRef.InternalSystem : bookingSourceRcd;
                    booking.ReceivedFrom = receivedFrom;
                    booking.Comment = comment;
                    booking.UserId = userId;
                    booking.DateTime = DateTime.UtcNow;
                    booking.Update(connection, transaction);

                    // booking event
                    var bookingEvent = new CrudeBookingEventData();
                    bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingUpdated;
                    bookingEvent.BookingId = booking.BookingId;
                    bookingEvent.UserId = userId;
                    bookingEvent.DateTime = DateTime.UtcNow;
                    bookingEvent.Insert(connection, transaction);

                    // booking identifier, todo, what about inactivation
                    if ( !string.IsNullOrEmpty(locator) ) {
                        var bookingIdentifier = new CrudeBookingIdentifierData();
                        bookingIdentifier.BookingIdentifierTypeRcd = BookingIdentifierTypeRef.RecordLocator;
                        bookingIdentifier.BookingId = booking.BookingId;
                        bookingIdentifier.BookingIdentifierValue = locator;
                        bookingIdentifier.UserId = userId;
                        bookingIdentifier.DateTime = DateTime.UtcNow;
                        bookingIdentifier.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>Updates page 2 fields of a booking</summary>
        /// <returns></returns>
        public void UpdateBookingPage2(
                Guid bookingId,
                string eMail,
                string comment,
                Guid userId
            ) {

            Logging log = 
                Logging.PerformanceTimeStart(
                    "Booking", "BusinessLogicLayer", "BookingService", "UpdateBookingPage2",
                    userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // booking event
                    var bookingEvent = new CrudeBookingEventData();
                    bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingUpdated;
                    bookingEvent.BookingId = bookingId;
                    bookingEvent.UserId = userId;
                    bookingEvent.DateTime = DateTime.UtcNow;
                    bookingEvent.Insert(connection, transaction);

                    // booking contact method, todo, what about inactivation
                    if ( !string.IsNullOrEmpty(eMail) ) {
                        var bookingContactMethod = new CrudeBookingContactMethodData();
                        bookingContactMethod.ContactMethodRcd = ContactMethodRef.EMail;
                        bookingContactMethod.BookingId = bookingId;
                        bookingContactMethod.ContactMethodWay = eMail;
                        bookingContactMethod.Comment = comment;
                        bookingContactMethod.UserId = userId;
                        bookingContactMethod.DateTime = DateTime.UtcNow;
                        bookingContactMethod.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        public void UpdateBookingPage3(
            Guid bookingId,
            string addressTypeRcd,
            string addressOne,
            string addressTwo,
            string addressThree,
            string city,
            string street,
            string state,
            string district,
            string province,
            string zipCode,
            string poBox,
            string comment,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                    "Booking", "BusinessLogicLayer", "BookingService", "UpdateBookingPage3", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    var booking = new CrudeBookingData();
                    booking.FetchByBookingId(bookingId);

                    // booking event
                    var bookingEvent = new CrudeBookingEventData();
                    bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingUpdated;
                    bookingEvent.BookingId = booking.BookingId;
                    bookingEvent.UserId = userId;
                    bookingEvent.DateTime = DateTime.UtcNow;
                    bookingEvent.Insert(connection, transaction);

                    // get address
                    var addressData = new CrudeAddressData();
                    if ( booking.AddressId != Guid.Empty )
                        addressData.FetchByAddressId(booking.AddressId);

                    if ( string.IsNullOrEmpty(addressTypeRcd) )
                        addressData.AddressTypeRcd = AddressTypeRef.Primary;
                    else
                        addressData.AddressTypeRcd = addressTypeRcd;

                    addressData.AddressOne = addressOne;
                    addressData.AddressTwo = addressTwo;
                    addressData.AddressThree = addressThree;
                    addressData.City = city;
                    addressData.Street = street;
                    addressData.State = state;
                    addressData.District = district;
                    addressData.Province = province;
                    addressData.ZipCode = zipCode;
                    addressData.PoBox = poBox;
                    addressData.Comment = comment;

                    if ( booking.AddressId != Guid.Empty ) {
                        addressData.DateTime = DateTime.UtcNow;
                        addressData.UserId = userId;
                        addressData.Update(connection, transaction);
                    } else {
                        // new address
                        addressData.AddressId = Guid.NewGuid();
                        addressData.DateTime = DateTime.UtcNow;
                        addressData.UserId = userId;
                        addressData.Insert(connection, transaction);

                        booking.AddressId = addressData.AddressId;
                        booking.Update(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        public void UpdateBookingPage4(
            Guid bookingId,
            string[] passengers,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                    "Booking", "BusinessLogicLayer", "BookingService", "UpdateBookingPage4", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    List<CrudePassengerData> passengerListData = 
                        new CrudePassengerData().FetchByBookingId(bookingId);

                    // todo, this assumes the same order of passenger... include pk instead
                    for ( int i = 0; i < passengerListData.Count; i++ ) {
                        passengerListData[i].PassengerName = passengers[i];
                        passengerListData[i].Update(connection, transaction);
                        if ( i >= passengers.Length - 1 )
                            break;
                    }

                    // add new passengers
                    for ( int i = passengerListData.Count; i < passengers.Length; i++ ) {
                        var passenger = new CrudePassengerData();
                        passenger.PassengerTypeRcd = PassengerTypeRef.Adult;
                        passenger.PassengerName = passengers[i];
                        passenger.UserId = userId;
                        passenger.DateTime = DateTime.UtcNow;
                        passenger.Insert(connection, transaction);

                        // tie passenger to booking
                        var bookingPassenger = new CrudeBookingPassengerData();
                        bookingPassenger.BookingId = bookingId;
                        bookingPassenger.PassengerId = passenger.PassengerId;
                        //bookingPassenger.StateRcd = DefaultStateRef.Created;
                        bookingPassenger.UserId = userId;
                        bookingPassenger.DateTime = DateTime.UtcNow;
                        bookingPassenger.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add a new passenger and link it to a booking
        /// </summary>
        public void PassengerAdd(
            Guid bookingId,
            string passengerTypeRcd,
            string passengerName,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "PassengerAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // add new passengers
                    var newPassenger = new CrudePassengerData();
                    newPassenger.PassengerId = Guid.NewGuid();
                    newPassenger.BindingPassengerId = newPassenger.PassengerId;
                    newPassenger.PassengerTypeRcd = string.IsNullOrEmpty(passengerTypeRcd) ? PassengerTypeRef.Adult : passengerTypeRcd;
                    newPassenger.PassengerName = passengerName;
                    newPassenger.DefaultStateRcd = DefaultStateRef.Created;
                    newPassenger.UserId = userId;
                    newPassenger.DateTime = DateTime.UtcNow;
                    newPassenger.Insert(connection, transaction);

                    // link passenger to booking
                    var bookingPassenger = new CrudeBookingPassengerData();
                    bookingPassenger.BookingPassengerId = Guid.NewGuid();
                    bookingPassenger.BindingBookingPassengerId = bookingPassenger.BookingPassengerId;
                    bookingPassenger.BookingId = bookingId;
                    bookingPassenger.PassengerId = newPassenger.PassengerId;
                    bookingPassenger.DefaultStateRcd = DefaultStateRef.Created;
                    bookingPassenger.UserId = userId;
                    bookingPassenger.DateTime = DateTime.UtcNow;
                    bookingPassenger.Insert(connection, transaction);

                    // roundup
                    CrudeReportingRoundupData.UpdateOrInsert(
                            bookingPassenger.DateTime,
                            ReportingRoundupTypeRef.BookingsPassenger,
                            newPassenger.PassengerTypeRcd,
                            1,
                            userId,
                            connection,
                            transaction
                            );

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add a new passenger and link it to a booking
        /// </summary>
        public void PassengerAdd(
            Guid bookingId,
            string passengerTypeRcd,
            string passengerName,
            Guid userId,
            SqlConnection connection,
            SqlTransaction transaction
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "PassengerAdd", userId);
            /*                    
                        using (var connection = new SqlConnection(Conn.ConnectionString)) {
                            connection.Open();
                            SqlTransaction transaction = connection.BeginTransaction();
            */
            try {
                // add new passengers
                var newPassenger = new CrudePassengerData();
                newPassenger.PassengerId = Guid.NewGuid();
                newPassenger.BindingPassengerId = newPassenger.PassengerId;
                newPassenger.PassengerTypeRcd = string.IsNullOrEmpty(passengerTypeRcd) ? PassengerTypeRef.Adult : passengerTypeRcd;
                newPassenger.PassengerName = passengerName;
                newPassenger.DefaultStateRcd = DefaultStateRef.Created;
                newPassenger.UserId = userId;
                newPassenger.DateTime = DateTime.UtcNow;
                newPassenger.Insert(connection, transaction);

                // link passenger to booking
                var bookingPassenger = new CrudeBookingPassengerData();
                bookingPassenger.BookingPassengerId = Guid.NewGuid();
                bookingPassenger.BindingBookingPassengerId = bookingPassenger.BookingPassengerId;
                bookingPassenger.BookingId = bookingId;
                bookingPassenger.PassengerId = newPassenger.PassengerId;
                bookingPassenger.DefaultStateRcd = DefaultStateRef.Created;
                bookingPassenger.UserId = userId;
                bookingPassenger.DateTime = DateTime.UtcNow;
                bookingPassenger.Insert(connection, transaction);

                // roundup
                CrudeReportingRoundupData.UpdateOrInsert(
                        bookingPassenger.DateTime,
                        ReportingRoundupTypeRef.BookingsPassenger,
                        newPassenger.PassengerTypeRcd,
                        1,
                        userId,
                        connection,
                        transaction
                        );

                // commit transaction
                //transaction.Commit();

                log.PerformanceTimeStop();
            } catch ( Exception ex ) {
                //transaction.Rollback();

                log.Error(ex);

                throw ex;
            }
            //            }
        }

        /// <summary>
        /// add a new link indicating that a passenger was removed from a booking
        /// </summary>
        public void PassengerRemove(
            Guid bookingPassengerId,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "PassengerRemove", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // fetch old link
                    var oldBookingPassenger = new CrudeBookingPassengerData();
                    oldBookingPassenger.FetchByBookingPassengerId(bookingPassengerId);

                    // create new link
                    var bookingPassenger = new CrudeBookingPassengerData();
                    bookingPassenger.BookingPassengerId = Guid.NewGuid();
                    bookingPassenger.BindingBookingPassengerId = oldBookingPassenger.BindingBookingPassengerId;
                    bookingPassenger.BookingId = oldBookingPassenger.BookingId;
                    bookingPassenger.PassengerId = oldBookingPassenger.PassengerId;
                    bookingPassenger.DefaultStateRcd = DefaultStateRef.Invalidated;
                    bookingPassenger.UserId = userId;
                    bookingPassenger.DateTime = DateTime.UtcNow;
                    bookingPassenger.Insert(connection, transaction);

                    // invalidate old link 
                    oldBookingPassenger.BecameBookingPassengerId = bookingPassenger.BookingPassengerId;
                    oldBookingPassenger.Update(connection, transaction);

                    // roundup
                    // fetch passenger
                    var passenger = new CrudePassengerData();
                    passenger.FetchByPassengerId(bookingPassenger.PassengerId);

                    CrudeReportingRoundupData.UpdateOrInsert(
                            bookingPassenger.DateTime,
                            ReportingRoundupTypeRef.BookingsPassenger,
                            passenger.PassengerTypeRcd,
                            -1,
                            userId
                            );

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// insert new passenger record while keeping history of old record
        /// </summary>
        public void PassengerUpdate(
            Guid bookingPassengerId,
            string passengerTypeRcd,
            string passengerName,
            string defaultStateRcd,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "PassengerUpdate", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // fetch old link
                    var oldBookingPassenger = new CrudeBookingPassengerData();
                    oldBookingPassenger.FetchByBookingPassengerId(bookingPassengerId);

                    // fetch old passenger
                    var oldPassenger = new CrudePassengerData();
                    oldPassenger.FetchByPassengerId(oldBookingPassenger.PassengerId);

                    // new passenger record
                    var newPassenger = new CrudePassengerData();
                    newPassenger.PassengerId = Guid.NewGuid();
                    newPassenger.BindingPassengerId = oldPassenger.BindingPassengerId;
                    newPassenger.PassengerTypeRcd = passengerTypeRcd == string.Empty ? PassengerTypeRef.Adult : passengerTypeRcd;
                    newPassenger.PassengerName = passengerName;
                    newPassenger.DefaultStateRcd = defaultStateRcd;
                    newPassenger.UserId = userId;
                    newPassenger.DateTime = DateTime.UtcNow;
                    newPassenger.Insert(connection, transaction);

                    // invalidate old passenger
                    oldPassenger.BecamePassengerId = newPassenger.PassengerId;
                    oldPassenger.Update(connection, transaction);

                    // link new passenger to booking
                    var newBookingPassenger = new CrudeBookingPassengerData();
                    newBookingPassenger.BookingPassengerId = Guid.NewGuid();
                    newBookingPassenger.BindingBookingPassengerId = oldBookingPassenger.BindingBookingPassengerId;
                    newBookingPassenger.BookingId = oldBookingPassenger.BookingId;
                    newBookingPassenger.PassengerId = newPassenger.PassengerId;
                    newBookingPassenger.DefaultStateRcd = DefaultStateRef.Updated;
                    newBookingPassenger.UserId = userId;
                    newBookingPassenger.DateTime = DateTime.UtcNow;
                    newBookingPassenger.Insert(connection, transaction);

                    // invalidate old link 
                    oldBookingPassenger.BecameBookingPassengerId = newBookingPassenger.BookingPassengerId;
                    oldBookingPassenger.Update(connection, transaction);

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        // get financial currency for date/time
        public CrudeFinancialCurrencyContract PaymentGetCurrency(
            Guid financialCurrencyId,
            Guid againstFinancialCurrencyId,
            DateTime currencyDateTime
            ) {

            CrudeFinancialCurrencyData currencyData = FinancialSearch.GetCurrencyConversion(
                financialCurrencyId,
                againstFinancialCurrencyId,
                currencyDateTime
                );

            var contract = new CrudeFinancialCurrencyContract();
            CrudeFinancialCurrencyService.DataToContract(currencyData, contract);

            return contract;
        }

        /// <summary>
        /// add booking payment with card
        /// </summary>
        public void PaymentCardAdd(
            Guid bookingId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            CrudeFinancialPaymentCardContract cardContract,
            Guid financialCostcentreId,
            Guid userId
            ) {

            var log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "PaymentCardAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // card
                    var financialPaymentCard = new CrudeFinancialPaymentCardData();
                    CrudeFinancialPaymentCardService.ContractToData(cardContract, financialPaymentCard);
                    financialPaymentCard.FinancialPaymentCardId = Guid.NewGuid();
                    financialPaymentCard.DateTime = DateTime.UtcNow;
                    financialPaymentCard.UserId = userId;
                    financialPaymentCard.Insert(connection, transaction);

                    // payment
                    var financialPaymentData = new CrudeFinancialPaymentData();
                    financialPaymentData.FinancialPaymentId = Guid.NewGuid();
                    financialPaymentData.FinancialPaymentTypeRcd = FinancialPaymentTypeRef.Card;
                    financialPaymentData.FinancialPaymentCardId = financialPaymentCard.FinancialPaymentCardId;
                    financialPaymentData.DateTime = DateTime.UtcNow;
                    financialPaymentData.UserId = userId;
                    financialPaymentData.Insert(connection, transaction);

                    // transaction
                    var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                    financialBookingTransaction.BookingId = bookingId;

                    financialBookingTransaction.TransactionNumber =
                        BookingData.TransactionNumberHighest(
                            connection,
                            transaction,
                            bookingId
                            ) + 1;

                    financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                    financialBookingTransaction.FinancialPaymentId = financialPaymentData.FinancialPaymentId;
                    financialBookingTransaction.Amount = paidAmountBookingCurrency;
                    financialBookingTransaction.FinancialCostcentreId = financialCostcentreId;
                    financialBookingTransaction.FinancialCurrencyId = paidAmountBookingFinancialCurrencyId;
                    financialBookingTransaction.UserId = userId;
                    financialBookingTransaction.DateTime = DateTime.UtcNow;
                    financialBookingTransaction.Insert(connection, transaction);

                    // rounding
                    if ( paidAmountRoundingBookingCurrency != 0 )
                        PaymentAdjustmentAdd(
                            connection,
                            transaction,
                            bookingId,
                            paidAmountRoundingBookingCurrency,
                            paidAmountBookingFinancialCurrencyId,
                            financialCostcentreId,
                            userId
                            );

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// Add booking payment in cash
        /// </summary>
        /// <param name="bookingId"></param>
        /// <param name="paidAmount"></param>
        /// <param name="paidAmountRounding"></param>
        /// <param name="paidFinancialCurrencyId"></param>
        /// <param name="paidAmountBookingCurrency"></param>
        /// <param name="paidAmountRoundingBookingCurrency"></param>
        /// <param name="paidAmountBookingFinancialCurrencyId"></param>
        /// <param name="financialCostcentreId"></param>
        /// <param name="userId"></param>
        public void PaymentCashAdd(
            Guid bookingId,
            decimal paidAmount,
            decimal paidAmountRounding,
            Guid paidFinancialCurrencyId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            ) {

            var log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "PaymentCashAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // cash
                    var financialPaymentCash = new CrudeFinancialPaymentCashData();
                    financialPaymentCash.FinancialPaymentCashId = Guid.NewGuid();
                    financialPaymentCash.Amount = paidAmount;
                    financialPaymentCash.FinancialCurrencyId = paidFinancialCurrencyId;
                    financialPaymentCash.DateTime = DateTime.UtcNow;
                    financialPaymentCash.UserId = userId;
                    financialPaymentCash.Insert(connection, transaction);

                    // payment
                    var financialPaymentData = new CrudeFinancialPaymentData();
                    financialPaymentData.FinancialPaymentId = Guid.NewGuid();
                    financialPaymentData.FinancialPaymentTypeRcd = FinancialPaymentTypeRef.Cash;
                    financialPaymentData.FinancialPaymentCashId = financialPaymentCash.FinancialPaymentCashId;
                    financialPaymentData.DateTime = DateTime.UtcNow;
                    financialPaymentData.UserId = userId;
                    financialPaymentData.Insert(connection, transaction);

                    // transaction
                    var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                    financialBookingTransaction.BookingId = bookingId;

                    financialBookingTransaction.TransactionNumber =
                        BookingData.TransactionNumberHighest(
                            connection,
                            transaction,
                            bookingId
                            ) + 1;

                    financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                    financialBookingTransaction.FinancialPaymentId = financialPaymentData.FinancialPaymentId;
                    financialBookingTransaction.Amount = paidAmountBookingCurrency;
                    financialBookingTransaction.FinancialCostcentreId = financialCostcentreId;
                    financialBookingTransaction.FinancialCurrencyId = paidAmountBookingFinancialCurrencyId;
                    financialBookingTransaction.UserId = userId;
                    financialBookingTransaction.DateTime = DateTime.UtcNow;
                    financialBookingTransaction.Insert(connection, transaction);

                    // rounding
                    if ( paidAmountRoundingBookingCurrency != 0 )
                        PaymentAdjustmentAdd(
                            connection,
                            transaction,
                            bookingId,
                            paidAmountRoundingBookingCurrency,
                            paidAmountBookingFinancialCurrencyId,
                            financialCostcentreId,
                            userId
                            );

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        void PaymentAdjustmentAdd(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid bookingId,
            decimal amount,
            Guid financialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            ) {

            var adjustmentData = new CrudeFinancialAdjustmentData();
            adjustmentData.FinancialAdjustmentId = Guid.NewGuid();
            adjustmentData.FinancialAdjustmentTypeRcd = FinancialAdjustmentTypeRef.RoundingRule;
            adjustmentData.Amount = amount;
            adjustmentData.FinancialCurrencyId = financialCurrencyId;
            adjustmentData.DateTime = DateTime.UtcNow;
            adjustmentData.UserId = userId;
            adjustmentData.Insert(connection, transaction);

            // transaction
            var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
            financialBookingTransaction.BookingId = bookingId;

            financialBookingTransaction.TransactionNumber =
                BookingData.TransactionNumberHighest(
                    connection,
                    transaction,
                    bookingId
                    ) + 1;

            financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
            financialBookingTransaction.FinancialAdjustmentId = adjustmentData.FinancialAdjustmentId;
            financialBookingTransaction.Amount = amount;
            financialBookingTransaction.FinancialCostcentreId = financialCostcentreId;
            financialBookingTransaction.FinancialCurrencyId = financialCurrencyId;
            financialBookingTransaction.UserId = userId;
            financialBookingTransaction.DateTime = DateTime.UtcNow;
            financialBookingTransaction.Insert(connection, transaction);
        }

        /// <summary>
        /// add booking payment with voucher
        /// </summary>
        public void PaymentVoucherAdd(
            Guid bookingId,
            Guid financialVoucherId,
            decimal paidAmount,
            decimal paidAmountRounding,
            Guid paidFinancialCurrencyId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            ) {

            var log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "PaymentVoucherAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // cash
                    var financialPaymentVoucher = new CrudeFinancialPaymentVoucherData();
                    financialPaymentVoucher.FinancialPaymentVoucherId = Guid.NewGuid();
                    financialPaymentVoucher.FinancialVoucherId = financialVoucherId;
                    financialPaymentVoucher.Amount = paidAmount;
                    financialPaymentVoucher.FinancialCurrencyId = paidFinancialCurrencyId;
                    financialPaymentVoucher.DateTime = DateTime.UtcNow;
                    financialPaymentVoucher.UserId = userId;
                    financialPaymentVoucher.Insert(connection, transaction);

                    // payment
                    var financialPaymentData = new CrudeFinancialPaymentData();
                    financialPaymentData.FinancialPaymentId = Guid.NewGuid();
                    financialPaymentData.FinancialPaymentTypeRcd = FinancialPaymentTypeRef.Voucher;
                    financialPaymentData.FinancialPaymentVoucherId = financialPaymentVoucher.FinancialPaymentVoucherId;
                    financialPaymentData.DateTime = DateTime.UtcNow;
                    financialPaymentData.UserId = userId;
                    financialPaymentData.Insert(connection, transaction);

                    // transaction
                    var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                    financialBookingTransaction.BookingId = bookingId;

                    financialBookingTransaction.TransactionNumber =
                        BookingData.TransactionNumberHighest(
                            connection,
                            transaction,
                            bookingId
                            ) + 1;

                    financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                    financialBookingTransaction.FinancialPaymentId = financialPaymentData.FinancialPaymentId;
                    financialBookingTransaction.Amount = paidAmountBookingCurrency;
                    financialBookingTransaction.FinancialCostcentreId = financialCostcentreId;
                    financialBookingTransaction.FinancialCurrencyId = paidAmountBookingFinancialCurrencyId;
                    financialBookingTransaction.UserId = userId;
                    financialBookingTransaction.DateTime = DateTime.UtcNow;
                    financialBookingTransaction.Insert(connection, transaction);

                    // rounding
                    if ( paidAmountRoundingBookingCurrency != 0 )
                        PaymentAdjustmentAdd(
                            connection,
                            transaction,
                            bookingId,
                            paidAmountRoundingBookingCurrency,
                            paidAmountBookingFinancialCurrencyId,
                            financialCostcentreId,
                            userId
                            );

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add booking payment with bank
        /// </summary>
        public void PaymentBankAdd(
            Guid bookingId,
            decimal paidAmount,
            decimal paidAmountRounding,
            Guid paidFinancialCurrencyId,
            decimal paidAmountBookingCurrency,
            decimal paidAmountRoundingBookingCurrency,
            Guid paidAmountBookingFinancialCurrencyId,
            string financialBankAccountNumberTypeRcd,
            string bankName,
            string bankAccount,
            string bankNumber,
            Guid financialCostcentreId,
            Guid userId
            ) {

            var log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "PaymentBankAdd", userId);
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {

                    // card
                    var financialPaymentBank = new CrudeFinancialPaymentBankData();
                    financialPaymentBank.FinancialPaymentBankId = Guid.NewGuid();
                    financialPaymentBank.Amount = paidAmount;
                    financialPaymentBank.FinancialCurrencyId = paidFinancialCurrencyId;
                    financialPaymentBank.FinancialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRcd;
                    financialPaymentBank.BankName = bankName;
                    financialPaymentBank.BankAccount = bankAccount;
                    financialPaymentBank.BankNumber = bankNumber;
                    financialPaymentBank.DateTime = DateTime.UtcNow;
                    financialPaymentBank.UserId = userId;
                    financialPaymentBank.Insert(connection, transaction);

                    // payment
                    var financialPaymentData = new CrudeFinancialPaymentData();
                    financialPaymentData.FinancialPaymentId = Guid.NewGuid();
                    financialPaymentData.FinancialPaymentTypeRcd = FinancialPaymentTypeRef.Bank;
                    financialPaymentData.FinancialPaymentBankId = financialPaymentBank.FinancialPaymentBankId;
                    financialPaymentData.DateTime = DateTime.UtcNow;
                    financialPaymentData.UserId = userId;
                    financialPaymentData.Insert(connection, transaction);

                    // transaction
                    var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                    financialBookingTransaction.BookingId = bookingId;

                    financialBookingTransaction.TransactionNumber =
                        BookingData.TransactionNumberHighest(
                            connection,
                            transaction,
                            bookingId
                            ) + 1;

                    financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                    financialBookingTransaction.FinancialPaymentId = financialPaymentData.FinancialPaymentId;
                    financialBookingTransaction.Amount = paidAmountBookingCurrency;
                    financialBookingTransaction.FinancialCostcentreId = financialCostcentreId;
                    financialBookingTransaction.FinancialCurrencyId = paidAmountBookingFinancialCurrencyId;
                    financialBookingTransaction.UserId = userId;
                    financialBookingTransaction.DateTime = DateTime.UtcNow;
                    financialBookingTransaction.Insert(connection, transaction);

                    // rounding
                    if ( paidAmountRoundingBookingCurrency != 0 )
                        PaymentAdjustmentAdd(
                            connection,
                            transaction,
                            bookingId,
                            paidAmountRoundingBookingCurrency,
                            paidAmountBookingFinancialCurrencyId,
                            financialCostcentreId,
                            userId
                            );

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// add booking payment with Account
        /// </summary>
        /// <param name="bookingId"></param>
        /// <param name="amount"></param>
        /// <param name="roundingAmount"></param>
        /// <param name="financialCurrencyId"></param>
        /// <param name="financialCostcentreId"></param>
        /// <param name="userId"></param>
        public void PaymentAccountingAdd(
            Guid bookingId,
            decimal amount,
            decimal roundingAmount,
            Guid financialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            ) {

        }

        /// <summary>
        /// add flight to booking
        /// </summary>
        public void FlightAdd(
            Guid bookingId,
            Guid flightId,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "FlightAdd", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // get all segments for flight
                    List<CrudeFlightSegmentData> segmentsData = Flight.GetFlightSegments(flightId);

                    // add them to booking
                    foreach ( CrudeFlightSegmentData segment in segmentsData ) {
                        var newLink = new CrudeBookingFlightSegmentData();
                        newLink.BookingFlightSegmentId = Guid.NewGuid();
                        newLink.BindingBookingFlightSegmentId = newLink.BookingFlightSegmentId;
                        newLink.BookingId = bookingId;
                        newLink.FlightSegmentId = segment.FlightSegmentId;
                        newLink.DefaultStateRcd = DefaultStateRef.Created;
                        newLink.UserId = userId;
                        newLink.DateTime = DateTime.UtcNow;
                        newLink.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// remove flight from booking
        /// </summary>
        public void FlightRemove(
            Guid bookingId,
            Guid bookingFlightSegmentId,
            Guid userId
            ) {

            var log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "FlightRemove", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // fetch old segment link
                    var oldSegmentData = new CrudeBookingFlightSegmentData();
                    oldSegmentData.FetchByBookingFlightSegmentId(
                                    bookingFlightSegmentId
                                    );

                    // create new link
                    var newSegmentData = new CrudeBookingFlightSegmentData();
                    newSegmentData.BookingFlightSegmentId = Guid.NewGuid();
                    newSegmentData.BindingBookingFlightSegmentId = oldSegmentData.BindingBookingFlightSegmentId;
                    newSegmentData.BookingId = oldSegmentData.BookingId;
                    newSegmentData.FlightSegmentId = oldSegmentData.FlightSegmentId;
                    newSegmentData.DefaultStateRcd = DefaultStateRef.Invalidated;
                    newSegmentData.UserId = userId;
                    newSegmentData.DateTime = DateTime.UtcNow;
                    newSegmentData.Insert(connection, transaction);

                    // invalidate old link 
                    oldSegmentData.BecameBookingFlightSegmentId = newSegmentData.BookingFlightSegmentId;
                    oldSegmentData.Update(connection, transaction);

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        /// <summary>
        /// Add fake bookings
        /// </summary>
        public void SimulateBookings(
            DateTime fromDateTime,
            DateTime untilDateTime,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "SimulateBookings", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                transaction.Commit();
                //SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // get all flights in a date time range
                    List<FlightsForPeriodSimpleData> flights = 
                        FlightSearch.FlightsForPeriodSimple(
                            fromDateTime,
                            untilDateTime
                            );

                    log.LogRun("Flights");

                    var random = new Random();

                    // add bookings with some of the flights
                    foreach ( FlightsForPeriodSimpleData flight in flights ) {
                        if ( random.Next(4) == 1 ) {
                            BookingContract booking = GetBookingEmpty(userId);

                            booking.Booking.BookingId =
                                UpdateBooking(
                                    booking.Booking.BookingId,
                                    booking.Booking.BookingSourceRcd,
                                    booking.BookingIdentifier.BookingIdentifierValue,
                                    String.Empty,
                                    "SimulateBookings",
                                    string.Empty,
                                    booking.Booking.FinancialCurrencyId,
                                    booking.Booking.FinancialCostcentreId,
                                    userId
                                    );

                            log.LogRun("UpdateBookings");

                            FlightAdd(
                                booking.Booking.BookingId,
                                flight.FlightId,
                                userId
                                );

                            log.LogRun("FlightAdd");

                            // add passengers
                            int passengerCount = random.Next(5);
                            for ( int i = 0; i < passengerCount; i++ ) {

                                // random passenger type
                                string passengerTypeRcd = string.Empty;
                                switch ( random.Next(6) ) {
                                    case 0:
                                    case 1:
                                    case 2:
                                        passengerTypeRcd = PassengerTypeRef.Adult;
                                        break;
                                    case 3:
                                    case 4:
                                        passengerTypeRcd = PassengerTypeRef.Child;
                                        break;
                                    case 5:
                                        passengerTypeRcd = PassengerTypeRef.Infant;
                                        break;
                                }

                                PassengerAdd(
                                    booking.Booking.BookingId,
                                    passengerTypeRcd,
                                    RandomFirstName(random) + ' ' + RandomSurname(random),
                                    userId,
                                    connection,
                                    null // transaction
                                    );

                                log.LogRun("PassengerAdd");
                            }

                            BookingConfirm(
                                booking.Booking.BookingId,
                                userId
                                );

                            log.LogRun("BookingConfirm");
                        }
                    }

                    // commit transaction
                    //transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    //transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        string RandomFirstName(
            Random random
            ) {

            switch ( random.Next(20) ) {
                case 0:
                    return "Anna";
                case 1:
                    return "Lisa";
                case 2:
                    return "Lena";
                case 3:
                    return "?????";
                case 4:
                    return "Alyona";
                case 5:
                    return "Smith";
                case 6:
                    return "Nicole";
                case 7:
                    return "??????????";
                case 8:
                    return "?????????";
                case 9:
                    return "Anzhelika";
                case 10:
                    return "Tom";
                case 11:
                    return "Peter";
                case 12:
                    return "Olav";
                case 13:
                    return "Jacob";
                case 14:
                    return "Alex";
                case 15:
                    return "Daniel";
                case 16:
                    return "Fiaz";
                case 17:
                    return "Igor";
                case 18:
                    return "Jack";
                case 19:
                    return "Max";
                default:
                    return "default";
            }
        }

        string RandomSurname(
            Random random
            ) {
            switch ( random.Next(20) ) {
                case 0:
                    return "Rudnitsky";
                case 1:
                    return "Ibsen";
                case 2:
                    return "Zaretsky";
                case 3:
                    return "Reagan";
                case 4:
                    return "Abbey";
                case 5:
                    return "Smith";
                case 6:
                    return "Acker";
                case 7:
                    return "Andrews";
                case 8:
                    return "Aston";
                case 9:
                    return "Hansen";
                case 10:
                    return "Barnet";
                case 11:
                    return "Bone";
                case 12:
                    return "Cannon";
                case 13:
                    return "Carlyle";
                case 14:
                    return "Cox";
                case 15:
                    return "Fox";
                case 16:
                    return "Cropper";
                case 17:
                    return "Olavson";
                case 18:
                    return "Croft";
                case 19:
                    return "Corey";
                default:
                    return "default";
            }
        }

        /// <summary>
        /// Confirm booking, add charges, etc
        /// </summary>
        public void BookingConfirm(
            Guid bookingId,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "BookingConfirm", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // get booking
                    var booking = new CrudeBookingData();
                    booking.FetchByBookingId(bookingId);

                    // booking event
                    var bookingEvent = new CrudeBookingEventData();
                    bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingConfirmed;
                    bookingEvent.BookingId = bookingId;
                    bookingEvent.UserId = userId;
                    bookingEvent.DateTime = DateTime.UtcNow;
                    bookingEvent.Insert(connection, transaction);

                    // get flights
                    List<BookingFlightsSimpleData> bookingFlights = 
                        new BookingSearch().BookingFlightsSimple(bookingId);

                    // add fares to booking transactions
                    foreach ( BookingFlightsSimpleData bookingSegment in bookingFlights ) {
                        var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                        financialBookingTransaction.BookingId = bookingId;

                        financialBookingTransaction.TransactionNumber =
                            BookingData.TransactionNumberHighest(
                                connection,
                                transaction,
                                bookingId
                                ) + 1;

                        financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                        financialBookingTransaction.FinancialFareId = bookingSegment.FinancialFareId;
                        financialBookingTransaction.Amount = bookingSegment.Amount;
                        financialBookingTransaction.FinancialCostcentreId = booking.FinancialCostcentreId;
                        financialBookingTransaction.FinancialCurrencyId = bookingSegment.FinancialCurrencyId;
                        financialBookingTransaction.UserId = userId;
                        financialBookingTransaction.DateTime = DateTime.UtcNow;
                        financialBookingTransaction.Insert(connection, transaction);
                    }

                    // booking fees
                    List<CrudeFinancialFeeContract> bookingFees = 
                        new CrudeFinancialFeeService().
                            FetchWithFilter(
                                Guid.Empty,
                                FinancialFeeTypeRef.BookingFee,
                                0,
                                Guid.Empty,
                                Guid.Empty,
                                DateTime.MinValue
                                );

                    // add fee to booking transactions
                    foreach ( CrudeFinancialFeeContract bookingFee in bookingFees ) {
                        var financialBookingTransaction = new CrudeFinancialBookingTransactionData();
                        financialBookingTransaction.BookingId = bookingId;

                        financialBookingTransaction.TransactionNumber =
                            BookingData.TransactionNumberHighest(
                                connection,
                                transaction,
                                bookingId
                                ) + 1;

                        financialBookingTransaction.FinancialBookingTransactionTypeRcd = FinancialBookingTransactionTypeRef.Added;
                        financialBookingTransaction.FinancialFeeId = bookingFee.FinancialFeeId;
                        financialBookingTransaction.Amount = bookingFee.Amount;
                        financialBookingTransaction.FinancialCostcentreId = booking.FinancialCostcentreId;
                        financialBookingTransaction.FinancialCurrencyId = bookingFee.FinancialCurrencyId;
                        financialBookingTransaction.UserId = userId;
                        financialBookingTransaction.DateTime = DateTime.UtcNow;
                        financialBookingTransaction.Insert(connection, transaction);
                    }

                    SendBookingConfirmationByEmail(
                        connection,
                        transaction,
                        bookingId,
                        userId
                        );

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        public string LocatorCreate() {
            var chars = "BCDFGHJKLMNPQS0123456789";

            var stringChars = new char[6];
            var random = new Random();

            for ( int i = 0; i < stringChars.Length; i++ ) {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public decimal BookingFinancialBalance(
            Guid bookingId
            ) {

            return BookingData.BookingFinancialBalance(bookingId);
        }

        public void SendBookingConfirmationByEmail(
            Guid bookingId,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "SendBookingConfirmationByEmail", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    SendBookingConfirmationByEmail(
                        connection,
                        transaction,
                        bookingId,
                        userId
                        );

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        public void SendBookingConfirmationByEmail(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid bookingId,
            Guid userId
            ) {

            // get all email contact methods
            List<CrudeBookingContactMethodData> contactMethod = 
                CrudeBookingContactMethodData.FetchWithFilter(
                    Guid.Empty,
                    bookingId,
                    ContactMethodRef.EMail,
                    string.Empty,
                    string.Empty,
                    Guid.Empty,
                    DateTime.MinValue
                    );

            if ( contactMethod.Count > 0 ) {
                try {
                    BookingContract booking = GetBooking(bookingId, userId);

                    string messageText = string.Empty;
                    messageText += "Hi,<br>\r\n";
                    messageText += "<br>\r\n";

                    messageText += "Your booking for the following flight has been confirmed:<br>\r\n";
                    messageText += "<br>\r\n";

                    List<FlightsOnBookingData> flights = 
                        new FlightSearch().FlightsOnBooking(bookingId);

                    foreach ( FlightsOnBookingData flight in flights ) {
                        messageText += "Flight Number: " + flight.FlightNumber + "<br>\r\n";
                        messageText += "&nbsp;&nbsp;From: " + flight.OriginAirportCode + " (" + flight.OriginAirportName + ")<br>\r\n";
                        messageText += "&nbsp;&nbsp;To:   " + flight.DestinationAirportCode + " (" + flight.DestinationAirportName + ")<br>\r\n";

                        messageText += "&nbsp;&nbsp;Departure Time: " + flight.FromDateTime + "<br>\r\n";
                        messageText += "&nbsp;&nbsp;Arrival Time: " + flight.UntilDateTime + "<br>\r\n";
                        messageText += "<br>\r\n";
                    }

                    messageText += "    Passengers on this booking:<br>\r\n";

                    List<PassengersOnBookingData> passengers = 
                        new PassengerSearch().PassengersOnBooking(bookingId);

                    foreach ( PassengersOnBookingData passenger in passengers ) {
                        messageText += "&nbsp;&nbsp;" + passenger.PassengerName + " (" + passenger.PassengerTypeName + ")<br>\r\n";
                    }
                    messageText += "<br>\r\n";

                    // payments
                    // get booking balance
                    decimal bookingBalance = 
                        new BookingService().BookingFinancialBalance(
                                bookingId);

                    List<CrudeDefaultSystemSettingData> systemSettingDatas = 
                        CrudeDefaultSystemSettingData.FetchWithFilter(
                            Guid.Empty,
                            DefaultSystemSettingRef.EMailURL,
                            string.Empty,
                            Guid.Empty,
                            DateTime.MinValue
                            );

                    CrudeDefaultSystemSettingData systemSettingData;
                    if ( systemSettingDatas.Count > 0 ) {
                        systemSettingData = systemSettingDatas[0];
                        if ( bookingBalance.Equals(0) ) {
                            messageText += "The booking is paid for, a detailed review is found\r\n";
                            messageText += "<a href=\"" + systemSettingData.DefaultSystemSettingValue + "Booking/BookingFinancialPayments";
                            messageText += "?bookingId=" + bookingId.ToString();
                            messageText += "&financialPaymentTypeRcd=" + FinancialPaymentTypeRef.Cash;
                            messageText += "&financialPaymentId=" + Guid.Empty.ToString();
                            messageText += "&financialCurrencyId=" + Guid.Empty.ToString();
                            messageText += "\">Here</a><br>\r\n";
                        } else {
                            messageText += "The booking does not balance financially, remaining amount is " + bookingBalance.ToString("f2");
                            messageText += " " + new CrudeFinancialCurrencyService().FetchByFinancialCurrencyId(
                                                            booking.Booking.FinancialCurrencyId
                                                            ).FinancialCurrencyTypeName
                                        + ",\r\n";

                            messageText += "<a href=\"" + systemSettingData.DefaultSystemSettingValue + "Booking/BookingFinancialPayments";
                            messageText += "?bookingId=" + bookingId.ToString();
                            messageText += "&financialPaymentTypeRcd=" + FinancialPaymentTypeRef.Card;
                            messageText += "&financialPaymentId=" + Guid.Empty.ToString();
                            messageText += "&financialCurrencyId=" + Guid.Empty.ToString();
                            messageText += "\">Pay it here</a><br>\r\n";
                        }
                    }

                    messageText += "<br>\r\n";
                    messageText += "The flight will likely not be departing at scheduled time, if at all, so do not show up on time.<br>\r\n";
                    messageText += " Please stay with us until this tiny problem is fixed.<br>\r\n";
                    messageText += "<br>\r\n";

                    messageText += "Until then fell free to visit our website for details about this booking:<br>\r\n";
                    messageText += "<br>\r\n";

                    if ( systemSettingDatas.Count > 0 ) {
                        systemSettingData = systemSettingDatas[0];

                        messageText += "                    <a href=\"" + systemSettingData.DefaultSystemSettingValue + "Flight/FlightEdit?flightId=" + flights[0].FlightId + "\">Flight Information</a>, \r\n";
                        messageText += "                    <a href=\"" + systemSettingData.DefaultSystemSettingValue + "Booking/BookingSummary?bookingId=" + booking.Booking.BookingId.ToString() + "\">Complete Booking Information</a>, \r\n";
                        messageText += "                    <a href=\"" + systemSettingData.DefaultSystemSettingValue + "PassengersOnFlight/PassengersOnFlightIndex?flightId=" + flights[0].FlightId + "\">All Passengers on this flight</a>, \r\n";
                        messageText += "<br>\r\n";
                        messageText += "<br>\r\n";
                        messageText += "These pages and much more can also been seen in a windows environment by following this link:\r\n";
                        messageText += "<a href=\"" + systemSettingData.DefaultSystemSettingValue + "install/publish.htm\">Install</a>, use 'launch' if you have trouble with the 'Run' button.\r\n";
                        messageText += "<br>\r\n";
                        messageText += "<br>\r\n";
                    }
                    messageText += "                    //nor-port<br>\r\n";

                    // mailit
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.live.com";  // todo, system setting
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    // todo, system setting
                    client.Credentials =
                        new System.Net.NetworkCredential(
                            userName: "emailLog",
                            password: "azureActiveDirectoryPassword"
                            );

                    //sql2x.MailEx.MailMessage(
                    //        messageSubject: "Booking Confirmation for " + booking.BookingIdentifier.BookingIdentifierValue,
                    //        messageText: messageText,
                    //        recipients: contactMethod[0].ContactMethodWay
                    //    );
                    MailMessage message = 
                        new MailMessage(
                            "emailLog",
                            contactMethod[0].ContactMethodWay,
                            "Booking Confirmation for " + booking.BookingIdentifier.BookingIdentifierValue,
                            messageText
                            );

                    message.IsBodyHtml = true;

                    message.BodyEncoding = UTF8Encoding.UTF8;
                    message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(message);

                    // booking event
                    var bookingEvent = new CrudeBookingEventData();
                    bookingEvent.BookingEventTypeRcd = BookingEventTypeRef.BookingEmailSent;
                    bookingEvent.Comment = "To: " + contactMethod[0].ContactMethodWay;
                    bookingEvent.BookingId = bookingId;
                    bookingEvent.UserId = userId;
                    bookingEvent.DateTime = DateTime.UtcNow;
                    bookingEvent.Insert(connection, transaction);
                } catch ( Exception ex ) {
                    Logging.ErrorLog("Booking",
                                        "BookingService",
                                        "SendBookingConfirmationByEmail",
                                        ex.Message,
                                        ex.StackTrace,
                                        userId
                                        );

                    throw ex;
                }
            }
        }

        public void PassengerCheckIn(
            Guid bookingPassengerId,
            Guid bookingFlightSegmentId,
            Guid userId
            ) {

            Logging log = Logging.PerformanceTimeStart(
                "Booking", "BusinessLogicLayer", "BookingService", "PassengerCheckIn", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    var bookingPassengerEvent = new CrudeBookingPassengerEventData();
                    bookingPassengerEvent.BookingPassengerEventTypeRcd = BookingPassengerEventTypeRef.Checkin;
                    bookingPassengerEvent.BookingPassengerId = bookingPassengerId;

                    bookingPassengerEvent.BookingPassengerEventNumber =
                                            PassengerData.BookingPassengerEventHighestNumber(
                                                connection,
                                                transaction,
                                                bookingPassengerId
                                                ) + 1;

                    bookingPassengerEvent.BookingFlightSegmentId = bookingFlightSegmentId;
                    bookingPassengerEvent.UserId = userId;
                    bookingPassengerEvent.DateTime = DateTime.UtcNow;
                    bookingPassengerEvent.Insert(connection, transaction);

                    // commit transaction
                    transaction.Commit();

                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }

        public void PassengerCheckOut(
            Guid bookingPassengerId,
            Guid bookingFlightSegmentId,
            Guid userId
            ) {

            var log = Logging.PerformanceTimeStart("Booking", "BusinessLogicLayer", "BookingService", "PassengerCheckOut", userId);

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    var bookingPassengerEvent = new CrudeBookingPassengerEventData();
                    bookingPassengerEvent.BookingPassengerEventTypeRcd = BookingPassengerEventTypeRef.Checkout;
                    bookingPassengerEvent.BookingPassengerId = bookingPassengerId;

                    bookingPassengerEvent.BookingPassengerEventNumber =
                                            PassengerData.BookingPassengerEventHighestNumber(
                                                connection,
                                                transaction,
                                                bookingPassengerId
                                                ) + 1;

                    bookingPassengerEvent.BookingFlightSegmentId = bookingFlightSegmentId;
                    bookingPassengerEvent.UserId = userId;
                    bookingPassengerEvent.DateTime = DateTime.UtcNow;
                    bookingPassengerEvent.Insert();

                    // commit transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();

                    log.Error(ex);

                    throw ex;
                }
            }
        }
    }
}


