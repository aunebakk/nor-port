using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace Test {
    public partial class Ordered {
        [TestMethod]
        public void Booking() {
            Booking afterDatabaseInit = new Booking();

            afterDatabaseInit.Step01_FlightGardermoenToArlanda();
            afterDatabaseInit.Step02_MakeBooking();
            afterDatabaseInit.Step03_ServiceRequestWheelchair();
            afterDatabaseInit.Step04_PayBooking();
            afterDatabaseInit.Step05_CheckEmail();
            afterDatabaseInit.Step06_CheckReportsAfterBooking();
            afterDatabaseInit.Step07_Checkin();
            afterDatabaseInit.Step08_CheckReportsAfterFlight();
        }
    }

    [TestClass]
    public class Booking {
        private Guid DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

        static Guid bookingId = Guid.Empty;
        
        [TestMethod]
        public void Step01_FlightGardermoenToArlanda() {
            CrudeAirportContract airportGardermoen = new CrudeAirportServiceClient().FetchByAirportName("Gardermoen");

            Assert.IsTrue(
                condition: !airportGardermoen.AirportId.Equals(Guid.Empty),
                message: "gardermoen airport id is not correct");

            CrudeAirportContract airportArlanda = new CrudeAirportServiceClient().FetchByAirportName("Arlanda");

            Assert.IsTrue(
                condition: !airportArlanda.AirportId.Equals(Guid.Empty),
                message: "arlanda airport id is not correct");
        }

        [TestMethod]
        public void Step02_MakeBooking() {
            CrudeAirportContract airportGardermoen = new CrudeAirportServiceClient().FetchByAirportName("Gardermoen");

            Assert.IsTrue(
                condition: !airportGardermoen.AirportId.Equals(Guid.Empty),
                message: "gardermoen airport id is not correct");

            CrudeAirportContract airportArlanda = new CrudeAirportServiceClient().FetchByAirportName("Arlanda");

            Assert.IsTrue(
                condition: !airportArlanda.AirportId.Equals(Guid.Empty),
                message: "arlanda airport id is not correct");

            // check availability
            FlightSearchService flightsWithBookingInformation = new FlightSearchService();
            List<FlightsWithBookingInformationContract> flights = 
                flightsWithBookingInformation.FlightsWithBookingInformation(
                    departureAirportId: airportGardermoen.AirportId, 
                    arrivalAirportId: airportArlanda.AirportId, 
                    fromDateTime: DateTime.UtcNow, 
                    untilDateTime: DateTime.UtcNow.AddDays(+1)
                    );

            Assert.AreNotEqual(
                    notExpected: 0, 
                    actual: flights.Count,
                    message: "no flights found"
                );

            // make booking
            bookingId = 
                new BookingServiceClient().CreateBooking(
                        bookingSourceRcd: BookingSourceRef.InternalSystem, 
                        flightId: flights[0].FlightId, 
                        userId: DefaultUserId
                    );

            Assert.IsTrue(
                condition: !bookingId.Equals(Guid.Empty),
                message: "booking id is not correct"
                );
        }

        [TestMethod]
        public void Step03_ServiceRequestWheelchair() {
            // add passenger "Mr Test Data"
            new BookingServiceClient()
                .PassengerAdd(
                        bookingId: bookingId,
                        passengerTypeRcd: PassengerTypeRef.Adult,
                        passengerName: "Test Data",
                        userId: DefaultUserId
                    );

            // service request
            CrudeServiceSpecialServiceRequestContract specialServiceRequestContract =
                new CrudeServiceSpecialServiceRequestServiceClient().FetchByServiceSpecialServiceRequestCode("WCHR");

            Assert.IsTrue(
                condition: !specialServiceRequestContract.Equals(Guid.Empty),
                message: "service request id is not correct"
                );

            // add request to booking
            new BookingServiceClient().BookingServiceSpecialServiceRequestAdd(
                bookingId: bookingId,
                serviceSpecialServiceRequestId: specialServiceRequestContract.ServiceSpecialServiceRequestId,
                userId: DefaultUserId
                );
        }

        [TestMethod]
        public void Step04_PayBooking() {
            new BookingServiceClient().BookingConfirm(
                bookingId: bookingId,
                userId: DefaultUserId
                );

            BookingContract bookingContract =
                new BookingServiceClient().GetBooking(
                        bookingId: bookingId,
                        userId: DefaultUserId
                        );

            Assert.AreEqual(
                expected: BookingSourceRef.InternalSystem,
                actual: bookingContract.Booking.BookingSourceRcd,
                message: "booking source is not correct"
                );

            // currency
            List<CrudeFinancialCurrencyContract> financialCurrency =
                new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyTypeRcd(
                    financialCurrencyTypeRcd: "USD"
                    );
            Assert.AreNotEqual(
                    notExpected: 0,
                    actual: financialCurrency.Count,
                    message: "no financial currency found"
                );

            List<CrudeFinancialCostcentreContract> financialCostcentre =
                new CrudeFinancialCostcentreServiceClient().FetchAll();
            Assert.AreNotEqual(
                    notExpected: 0,
                    actual: financialCostcentre.Count,
                    message: "no financial costcentre found"
                );

            new BookingServiceClient()
                .PaymentCashAdd(
                    bookingId: bookingId,
                    paidAmount: 10,
                    paidAmountRounding: 0,
                    paidFinancialCurrencyId: financialCurrency[0].FinancialCurrencyId,
                    paidAmountBookingCurrency: 10,
                    paidAmountRoundingBookingCurrency: 0,
                    paidAmountBookingFinancialCurrencyId: financialCurrency[0].FinancialCurrencyId,
                    financialCostcentreId: financialCostcentre[0].FinancialCostcentreId,
                    userId: DefaultUserId
                    );
        }

        [TestMethod]
        public void Step05_CheckEmail() {
            new BookingServiceClient().UpdateBookingPage2(
                bookingId: bookingId,
                eMail: "developerName@hotmail.com",
                comment: "developerName@hotmail.com",
                userId: DefaultUserId
                );

        }

        [TestMethod]
        public void Step06_CheckReportsAfterBooking() {

            BookingContract bookingContract =
                new BookingServiceClient().GetBooking(
                        bookingId: bookingId,
                        userId: DefaultUserId
                        );

            List<BookingsOpenContract> bookingList =
                new BookingSearchService().BookingsOpen();

            BookingsOpenContract bookingsOpenContract = null;
            foreach (BookingsOpenContract boc in bookingList) {
                if (boc.RecordLocator == bookingContract.BookingIdentifier.BookingIdentifierValue)
                    bookingsOpenContract = boc;
            }

            Assert.IsNotNull(
                value: bookingsOpenContract,
                message: $"failed to find booking on locator {bookingContract.BookingIdentifier.BookingIdentifierValue}"
                );

        }

        [TestMethod]
        public void Step07_Checkin() {
            List<FlightsOpenForCheckinWithDescriptionContract> flights =
                new FlightSearchService().FlightsOpenForCheckinWithDescription(
                        departureAirportId: Guid.Empty,
                        arrivalAirportId: Guid.Empty,
                        fromDateTime: DateTime.UtcNow.Date,
                        untilDateTime: DateTime.UtcNow.Date.AddDays(1)
                        );

            foreach (FlightsOpenForCheckinWithDescriptionContract flight in flights) { 
                List<PassengersOnFlightContract> passengers = 
                    new PassengerSearchService().PassengersOnFlight(
                        flightId: flight.FlightId
                        );

                // check in every 3rd passenger
                for (int p = 0; p < passengers.Count; p++) {
                    if (p % 3 == 0) {
                        if (!passengers[p].CheckedinFlag) {
                            new BookingServiceClient()
                                .PassengerCheckIn(
                                    passengers[p].BookingPassengerId,
                                    passengers[p].BookingFlightSegmentId,
                                    userId: DefaultUserId
                                    );
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void Step08_CheckReportsAfterFlight() {
            // get flights for the next 24 hours
            List<FlightsOpenForCheckinWithDescriptionContract> flights =
                new FlightSearchService().FlightsOpenForCheckinWithDescription(
                        departureAirportId: Guid.Empty,
                        arrivalAirportId: Guid.Empty,
                        fromDateTime: DateTime.UtcNow.Date,
                        untilDateTime: DateTime.UtcNow.Date.AddDays(1)
                        );

            // iterate all flights
            foreach (FlightsOpenForCheckinWithDescriptionContract flight in flights) {

                // all passengers on flight
                List<PassengersOnFlightContract> passengers =
                    new PassengerSearchService().PassengersOnFlight(
                        flightId: flight.FlightId
                        );

                // checked in passengers
                List<PassengersOnFlightCheckedInContract> passengersCheckedIn =
                    new PassengerSearchService().PassengersOnFlightCheckedIn(
                        flightId: flight.FlightId
                        );

                // checked in passengers should be a third of actual passengers ( TODO: +- 15 for some reason )
                Assert.AreEqual(
                    expected: passengers.Count / 3,
                    actual: passengersCheckedIn.Count,
                    delta: 15,
                    message: $"flight {flight.AirlineIdentifierCode}{flight.FlightNumber} has too few checked in passengers"
                    );
            }
        }
    }
}

