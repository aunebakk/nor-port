using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.UserInterface;
//using SQL2XPrototype.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Net;

namespace Test {
    [TestClass]
    public class Simulate {
        private Guid DefaultUserId => new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

        [TestMethod]
        public void MakeAirplane() {
            try {
                Assert.Fail(message: "not implemented");
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to XXX, message: {ex.Message}");
            } finally {
            }
        }

        [TestMethod]
        public void MakeSchedule() {
            try {
                Assert.Fail(message: "not implemented");
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to XXX, message: {ex.Message}");
            } finally {
            }
        }

        [TestMethod]
        public void MakePerson() {
            try {
                Assert.Fail(message: "not implemented");
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to XXX, message: {ex.Message}");
            } finally {
            }
        }

        [TestMethod]
        public void MakeBooking() {
            try {
                Assert.Fail(message: "not implemented");
                // get all flights in a date time range
                //List<FlightsForPeriodSimpleData> flights =
                //    FlightSearch.FlightsForPeriodSimple(
                //        fromDateTime,
                //        untilDateTime
                //        );

                //log.LogRun("Flights");

                //Random random = new Random();

                //// add bookings with some of the flights
                //foreach (FlightsForPeriodSimpleData flight in flights) {
                //    if (random.Next(4) == 1) {
                //        BookingContract booking = GetBookingEmpty(userId);

                //        booking.Booking.BookingId =
                //            UpdateBooking(
                //                booking.Booking.BookingId,
                //                booking.Booking.BookingSourceRcd,
                //                booking.BookingIdentifier.BookingIdentifierValue,
                //                string.Empty,
                //                "SimulateBookings",
                //                string.Empty,
                //                booking.Booking.FinancialCurrencyId,
                //                booking.Booking.FinancialCostcentreId,
                //                userId
                //                );

                //        log.LogRun("UpdateBookings");

                //        FlightAdd(
                //            booking.Booking.BookingId,
                //            flight.FlightId,
                //            userId
                //            );

                //        log.LogRun("FlightAdd");

                //        // add passengers
                //        int passengerCount = random.Next(5);
                //        for (int i = 0; i < passengerCount; i++) {

                //            // random passenger type
                //            string passengerTypeRcd = string.Empty;
                //            switch (random.Next(6)) {
                //                case 0:
                //                case 1:
                //                case 2:
                //                    passengerTypeRcd = PassengerTypeRef.Adult;
                //                    break;
                //                case 3:
                //                case 4:
                //                    passengerTypeRcd = PassengerTypeRef.Child;
                //                    break;
                //                case 5:
                //                    passengerTypeRcd = PassengerTypeRef.Infant;
                //                    break;
                //            }

                //            PassengerAdd(
                //                booking.Booking.BookingId,
                //                passengerTypeRcd,
                //                RandomFirstName(random) + ' ' + RandomSurname(random),
                //                userId,
                //                connection,
                //                null // transaction
                //                );

                //            log.LogRun("PassengerAdd");
                //        }

                //        BookingConfirm(
                //            booking.Booking.BookingId,
                //            userId
                //            );

                //        log.LogRun("BookingConfirm");
                //    }
                //}

            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to XXX, message: {ex.Message}");
            } finally {
            }
        }

        [TestMethod]
        public void MakeCheckin() {
            try {
                Assert.Fail(message: "not implemented");
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to XXX, message: {ex.Message}");
            } finally {
            }
        }

        [TestMethod]
        public void MakeBoarding() {
            try {
                Assert.Fail(message: "not implemented");
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to XXX, message: {ex.Message}");
            } finally {
            }
        }

        private void TryCall(
                string systemName,
                string testArea,
                string url
            ) {

            WebClient client = new WebClient();
            string html = string.Empty;
            WebHeaderCollection headers = null;

            CrudeDefaultTestContract test = new CrudeDefaultTestContract {
                DefaultTestId = Guid.NewGuid(),
                SystemName = systemName,
                TestArea = testArea,
                TestSubArea = " ",
                TestAddress = url,
                DateTime = DateTime.UtcNow,
                UserId = DefaultUserId
            };

            CrudeDefaultTestRunContract testRun = new CrudeDefaultTestRunContract {
                DefaultTestId = test.DefaultTestId,
                DateTime = DateTime.UtcNow,
                UserId = DefaultUserId
            };

            try {
                testRun.StartDateTime = DateTime.UtcNow;

                // download page
                LoggingTime time = LoggingTime.PerformanceTimeStart("tryCall");
                html = client.DownloadString(url);
                time.PerformanceTimeStop();

                testRun.ElapsedMilliseconds = (int)time.StopWatch.ElapsedMilliseconds;
                testRun.EndDateTime = DateTime.UtcNow;

                headers = client.ResponseHeaders;
                testRun.Result = headers.ToString();

                testRun.DefaultTestRunResultRcd = DefaultTestRunResultRef.OK;
            } catch (WebException ex) {
                testRun.DefaultTestRunResultRcd = DefaultTestRunResultRef.WebException;
                testRun.Result = "Status: " + ex.Status + ", Response: " + ex.Response + " : " + url;
                //Error(ex);
            } catch (Exception ex) {
                testRun.DefaultTestRunResultRcd = DefaultTestRunResultRef.Exception;
                testRun.Result = "Message: " + ex.Message + " : " + url;
                //Error(ex);
            }

            // truncate result
            if (testRun.Result.Length > 240) {
                testRun.Result = testRun.Result.Substring(0, 240);
            }

            try {
                //new CrudeDefaultTestServiceClient().Insert(test);
                //new CrudeDefaultTestRunServiceClient().Insert(testRun);

                Console.WriteLine($"{testRun.DefaultTestRunResultRcd} {testRun.ElapsedMilliseconds} {test.TestAddress}");

                var defaultTest = new DefaultTestServiceClient();
                defaultTest.AddTestRun(
                    test.SystemName, test.TestArea, test.TestSubArea, test.TestAddress,
                    testRun.StartDateTime, testRun.EndDateTime, testRun.ElapsedMilliseconds, testRun.DefaultTestRunResultRcd,
                    testRun.Result, testRun.UserId
                    );

            } catch (Exception ex) {
                if (ex != null) { }
            }

            //Log(systemName, testArea, testRun.DefaultTestRunResultRcd);
        }

        /// <summary>
        /// try calling all default tests
        /// </summary>
        [TestMethod]
        public void DoTests() {
            try {
                // run all tests
                List<CrudeDefaultTestContract> allTests = new CrudeDefaultTestServiceClient().FetchAll();
                foreach (CrudeDefaultTestContract test in allTests) {
                    TryCall(
                        test.SystemName,
                        test.TestArea,
                        test.TestAddress
                        );
                }
                //new DefaultTestServiceClient().RunAllTests(DefaultUserId);
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to call test area, message: {ex.Message}");
            }
        }

        /// <summary>
        /// try calling all default tests
        /// </summary>
        [TestMethod]
        public void DoCifudeTests() {
            try {
                // run all tests
                //List<SQL2XPrototype.DataAccessLayer.CifudeTestData> allTests = SQL2XPrototype.DataAccessLayer.CifudeTestData.FetchAll();
                //foreach (SQL2XPrototype.DataAccessLayer.CifudeTestData test in allTests) {
                //    TryCall(
                //        "NorPort",
                //        "All",
                //        test.Address
                //        );

                //    Console.WriteLine($"{test.Address}");
                //}
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to call test area, message: {ex.Message}");
            }
        }

        /// <summary>
        /// try calling all default tests
        /// </summary>
        [TestMethod]
        public void DoCrudeTests() {
            try {
                // run all tests
                //List<SQL2XPrototype.DataAccessLayer.CifudeTestData> allTests = SQL2XPrototype.DataAccessLayer.CifudeTestData.FetchAll();
                //foreach (SQL2XPrototype.DataAccessLayer.CifudeTestData test in allTests) {
                //    TryCall(
                //        "NorPort",
                //        "All",
                //        test.Address
                //        );

                //    Console.WriteLine($"{test.Address}");
                //}
            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to call test area, message: {ex.Message}");
            }
        }

        /// <summary>
        /// try calling Check Flight Statuses
        /// </summary>
        [TestMethod]
        public void CheckFlightStatuses() {
            FlightServiceClient flightService = new FlightServiceClient();
            try {
                flightService.CheckFlightStatuses(
                    DateTime.UtcNow.Date,
                    DateTime.UtcNow.Date.AddDays(1),
                    DefaultUserId
                    );

            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to Check Flight Statuses, message: {ex.Message}");
            } finally {
                flightService.Close();
            }
        }

        /// <summary>
        /// try calling Simulate booking
        /// </summary>
        [TestMethod]
        public void SimulateBookings() {
            FlightServiceClient flightService = new FlightServiceClient();
            BookingServiceClient bookingService = new BookingServiceClient();
            try {
                bookingService.SimulateBookings(
                    DateTime.UtcNow.Date,
                    DateTime.UtcNow.Date.AddDays(1),
                    DefaultUserId
                    );

            } catch (Exception ex) {
                Assert.Fail(message: $"Failed to Simulate Bookings, message: {ex.Message}");
            } finally {
                bookingService.Close();
            }
        }
    }
}
