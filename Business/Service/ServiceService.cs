using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.ServiceModel;
using System.Text;
using SolutionNorSolutionPort.DataAccessLayer;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [ServiceContract()]
    public interface IServiceService
    {
        [OperationContract()]
        void PromotionSend(
            Guid servicePackagePromotionId,
            Guid userId
            );

        [OperationContract()]
        void PromotionMakeBooking(
            Guid servicePackagePromotionId,
            Guid userId
            );
    }

    public class ServiceService : IServiceService
    {
        public void PromotionMakeBooking(
            Guid servicePackagePromotionId,
            Guid userId
            ) {
            Logging log = 
                Logging.PerformanceTimeStart(
                            "Service",
                            "BusinessLogicLayer",
                            "ServiceService",
                            "PromotionMakeBooking",
                            userId
                            );

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                var promotionData = CrudeServicePackagePromotionData.GetByServicePackagePromotionId(servicePackagePromotionId);
                var packageData = CrudeServicePackageData.GetByServicePackageId(promotionData.ServicePackageId);
                var clientData = CrudeClientData.GetByClientId(promotionData.ClientId);
                var contactData = CrudeClientContactMethodData.GetCurrentMail(promotionData.ClientId);

                // get flights
                // make booking
                var bookingService = new BookingService();
                BookingContract booking = bookingService.GetBookingEmpty(userId);

                // save booking
                // todo, transaction
                booking.Booking.BookingId =
                    bookingService.UpdateBooking(
                        booking.Booking.BookingId,
                        booking.Booking.BookingSourceRcd,
                        booking.BookingIdentifier.BookingIdentifierValue,
                        contactData.ContactMethodWay,
                        "PromotionMakeBooking",
                        string.Empty,
                        booking.Booking.FinancialCurrencyId,
                        booking.Booking.FinancialCostcentreId,
                        userId
                        );

                // flights
                if ( packageData.DepartureAirportId != Guid.Empty ) {
                    Guid flightId = 
                        Flight.GetFlightMatching(
                            packageData.DepartureAirportId,
                            packageData.ArrivalAirportId
                            );

                    if ( flightId != Guid.Empty )
                        bookingService.FlightAdd(
                            booking.Booking.BookingId,
                            flightId,
                            userId
                            );
                }

                // passengers
                bookingService.PassengerAdd(
                    booking.Booking.BookingId,
                    PassengerTypeRef.Adult,
                    clientData.FirstName + ' ' + clientData.MiddleName + ' ' + clientData.LastName,
                    userId
                    );

                // services (SSR)
                if ( packageData.ServiceSpecialServiceRequestId != Guid.Empty )
                    bookingService.BookingServiceSpecialServiceRequestAdd(
                        booking.Booking.BookingId,
                        packageData.ServiceSpecialServiceRequestId,
                        userId
                        );

                // services (Hotel)
                if ( packageData.ServiceHotelId != Guid.Empty )
                    bookingService.BookingServiceHotelAdd(
                        booking.Booking.BookingId,
                        packageData.ServiceHotelId,
                        userId
                        );

                // services (Car)
                if ( packageData.ServiceCarRentalId != Guid.Empty )
                    bookingService.BookingServiceCarRentalAdd(
                        booking.Booking.BookingId,
                        packageData.ServiceCarRentalId,
                        userId
                        );

                // confirm booking
                bookingService.BookingConfirm(
                    booking.Booking.BookingId,
                    userId
                    );

                try {
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();
                    log.Error(ex);
                    throw ex;
                }
            }
        }

        public void PromotionSend(
            Guid servicePackagePromotionId,
            Guid userId
            ) {
            Logging log = 
                Logging.PerformanceTimeStart(
                            "Service",
                            "BusinessLogicLayer",
                            "ServiceService",
                            "PromotionSend",
                            userId
                            );

            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    var promotionData = CrudeServicePackagePromotionData.GetByServicePackagePromotionId(servicePackagePromotionId);
                    var packageData = CrudeServicePackageData.GetByServicePackageId(promotionData.ServicePackageId);
                    var clientData = CrudeClientData.GetByClientId(promotionData.ClientId);
                    var contactData = CrudeClientContactMethodData.GetCurrentMail(promotionData.ClientId);

                    // todo, assume one hit
                    GetServicePackageData packageDetailsData = 
                        new ServiceSearch().GetServicePackage(promotionData.ServicePackageId)[0];

                    string messageText = string.Empty;
                    messageText += "Hi,<br>\r\n";
                    messageText += "<br>\r\n";
                    if ( !string.IsNullOrEmpty(packageDetailsData.DepartureAirportName) )
                        messageText += " From: " + packageDetailsData.DepartureAirportName + "<br>\r\n";
                    if ( !string.IsNullOrEmpty(packageDetailsData.ArrivalAirportName) )
                        messageText += " To: " + packageDetailsData.ArrivalAirportName + "<br>\r\n";
                    if ( !string.IsNullOrEmpty(packageDetailsData.CarName) )
                        messageText += " Traveling with: " + packageDetailsData.CarName + "<br>\r\n";
                    if ( !string.IsNullOrEmpty(packageDetailsData.HotelName) )
                        messageText += " Staying at: " + packageDetailsData.HotelName + "<br>\r\n";
                    if ( !string.IsNullOrEmpty(packageDetailsData.ServiceSpecialServiceRequestName) )
                        messageText += " Special Request: " + packageDetailsData.ServiceSpecialServiceRequestName + "<br>\r\n";

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

                        messageText += "<br>\r\n";
                        messageText += "The package is not yet a booking, click ";
                        // http://localhost:1301/ServicePackagePromotionWithFilter/ServicePackagePromotionMakeBooking?servicePackagePromotionId=4417cd4e-e033-4644-b9fe-74ceec50d903
                        messageText += "<a href=\"" + systemSettingData.DefaultSystemSettingValue;
                        messageText += "/ServicePackagePromotionWithFilter/ServicePackagePromotionMakeBooking";
                        messageText += "?servicePackagePromotionId=" + promotionData.ServicePackagePromotionId.ToString();
                        messageText += "\">here to make it into one</a>. The flight will be the first available one, so fly to the airport :-|<br>\r\n";

                        // change package message
                        messageText += "If you for some reason do not agree with this wonderful package then <br>\r\n";
                        messageText += " it can be ";
                        messageText += "<a href=\"" + systemSettingData.DefaultSystemSettingValue;
                        messageText += "/GetServicePackageLive/ServicePackageEdit";
                        messageText += "?servicePackageId=" + packageData.ServicePackageId.ToString();
                        messageText += "\">changed here</a><br>\r\n";

                        // confirmed message
                        messageText += "<br>\r\n";
                        messageText += "The booking will be confirmed and a new mail message will arrive at this address confirming that fact.<br>\r\n";
                        messageText += "In the confirmation mail you can view the complete booking through web pages or a windows interface<br>\r\n";
                        messageText += "<br>\r\n";
                        messageText += "Thanks for booking through nor-port<br>\r\n";
                        messageText += "<br>\r\n";
                    }
                    messageText += "//nor-port<br>\r\n";

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
                            "emailLog",
                            "HU6767Ghvhvj"
                            );

                    MailMessage message = 
                        new MailMessage(
                            "emailLog",
                            contactData.ContactMethodWay,
                            "Promotional Package : " + packageData.ServicePackageName,
                            messageText
                            );

                    message.IsBodyHtml = true;

                    message.BodyEncoding = UTF8Encoding.UTF8;
                    message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(message);

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

