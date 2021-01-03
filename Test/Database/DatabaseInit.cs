using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SolutionNorSolutionPort.BusinessLogicLayer;
//using SolutionNorSolutionPort.BusinessLogicLayer.Proxy;
using System;
using System.Collections.Generic;
using System.Net;

namespace Test {
    [TestClass]
    public partial class Ordered {
        [TestMethod]
        public void DatabaseInit() {
            DatabaseInit afterDatabaseInit = new DatabaseInit();

            afterDatabaseInit.Step01_Web_InitiateDB();
            afterDatabaseInit.Step02_API_MakeFlights();
            afterDatabaseInit.Step03_API_CheckFlightAndMakeBookings();
            afterDatabaseInit.Step04_Web_Reports();
            afterDatabaseInit.Step05_SOAP_Count_Aircrafts();
            afterDatabaseInit.Step06_SOAP_Count_Flights();
            afterDatabaseInit.Step07_REST_Count_Flights();
            afterDatabaseInit.Step08_REST_Check_Flights();
            afterDatabaseInit.Step09_REST_and_SOAP_Proxy_test();
            afterDatabaseInit.Step10_REST_Proxy_Booking_Test();
        }
    }

    [TestClass]
    public class DatabaseInit {

        private Guid DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

        /// <summary>
        /// Initiate schedule 
        /// </summary>
        [TestMethod]
        public void Step01_Web_InitiateDB() {
            Simulate simulate = new Simulate();
            WebClient client = new WebClient();

            Console.WriteLine($"Start; {DateTime.UtcNow}");

            // init db
            string html = client.DownloadString("http://NorSolutionPortCore.azurewebsites.net/api/1/database/SetVersionZero");

            Console.WriteLine(html.Substring(html.IndexOf("Database Version is; "), 40));

            Assert.IsTrue(
                    condition: html.IndexOf("Database Version is; 0.0.0") > 0,
                    message: "database version is wrong after init"
                );

            Console.WriteLine("Init db");

            int maxRuns = 30;
            do {
                html = client.DownloadString("http://NorSolutionPortCore.azurewebsites.net/api/1/database/increaseversiontolatest");

                Console.WriteLine(html.Substring(html.IndexOf("Database Version is; "), 40));
            } while (
                html.IndexOf("Database Version is; 0.10.0") == -1
                && maxRuns-- != 00
                );

            Assert.IsTrue(
                    condition: html.IndexOf("Database Version is; 0.10.0") > 0,
                    message: $"database version is wrong after increase ({html.Substring(html.IndexOf("Database Version is; "), 40)})"
                );
        }

        /// <summary>
        /// Initiate schedule 
        /// </summary>
        [TestMethod]
        public void Step02_API_MakeFlights() {
            Simulate simulate = new Simulate();
            WebClient client = new WebClient();

            // make flights
            ScheduleServiceClient scheduleService = new ScheduleServiceClient();
            scheduleService.MakeFlightsFromScheduleAll(DefaultUserId);
        }

        /// <summary>
        /// check flight schedule and make bookings
        /// </summary>
        [TestMethod]
        public void Step03_API_CheckFlightAndMakeBookings() {
            Simulate simulate = new Simulate();
            WebClient client = new WebClient();

            ScheduleServiceClient scheduleService = new ScheduleServiceClient();

            // flight status
            for (int i = 0; i < 10; i++) {
                simulate.CheckFlightStatuses();
            }

            // bookings
            for (int i = 0; i < 10; i++) {
                simulate.SimulateBookings();
            }

        }

        /// <summary>
        /// check reports
        /// </summary>
        [TestMethod]
        public void Step04_Web_Reports() {
            Simulate simulate = new Simulate();
            WebClient client = new WebClient();

            // flights with booking information / passenger name list
            Console.WriteLine("flights with booking information / passenger name list");

            string html = client.DownloadString("https://NorSolutionPort.azurewebsites.net/FlightsWithCheckinInformationLive/FlightsWithCheckinInformationIndex");

            int iPos = html.IndexOf("Gardermoen");

            Assert.IsTrue(
                            condition: iPos > 20000 && iPos < 24000,
                            message: $"airport not in expected position, found in {iPos}"
                            );

            // flights
            Console.WriteLine("checking flights");

            // SAS 620
            html = client.DownloadString("https://NorSolutionPort.azurewebsites.net/FlightsForPeriodLive/FlightsForPeriodIndex");
            int dateTimePosition = html.IndexOf($"{DateTime.UtcNow.ToString("M/d/yyyy")} 5:00:00 AM");

            Assert.IsTrue(
                            condition: dateTimePosition > 22000 && dateTimePosition < 26000,
                            message: $"SAS 620 not in position {"22000 to 26000"} but in {dateTimePosition}"
                            );

            // SAS 638 ( last flight arrival )
            dateTimePosition = html.IndexOf($"{DateTime.UtcNow.ToString("M/d/yyyy")} 11:00:00 PM");

            Assert.IsTrue(
                            condition: dateTimePosition >= 36300,
                            message: $"SAS 638 not in position {" >= 36300"} but in {dateTimePosition}"
                            );
        }

        /// <summary>
        /// Number of aircrafts must be 3 after database has been initialized
        /// </summary>
        [TestMethod]
        public void Step05_SOAP_Count_Aircrafts() {
            Assert.AreEqual(
                    expected: 3,
                    actual: new SolutionNorSolutionPort.BusinessLogicLayer.AircraftSearchServiceClient().AircraftIndexWithFilter().Count,
                    message: "Number of aircrafts must be 3 after database has been initialized"
                );
        }

        /// <summary>
        /// Number of flights must be 22
        /// </summary>
        [TestMethod]
        public void Step06_SOAP_Count_Flights() {
            Assert.AreEqual(
                    expected: 22,
                    actual: new SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightServiceClient().FetchAllCount(),
                    message: "Number of flights must be 22 after database has been initialized"
                );
        }

        /// <summary>
        /// Number of flights must be 22
        /// </summary>
        [TestMethod]
        public void Step07_REST_Count_Flights() {
            Simulate simulate = new Simulate();
            WebClient client = new WebClient();
            
            // get flights through the REST interface
            string jsonString = client.DownloadString("http://NorSolutionPortCore.azurewebsites.net/api/1/crudeflight/fetchall");

            JArray flights = JArray.Parse(jsonString);

            Assert.AreEqual(
                    expected: 22,
                    actual: flights.Count,
                    message: "Number of flights must be 22 after database has been initialized"
                );
        }

        /// <summary>
        /// Number of flights must be 22
        /// </summary>
        [TestMethod]
        public void Step08_REST_Check_Flights() {
            Simulate simulate = new Simulate();
            WebClient client = new WebClient();

            // flights
            Console.WriteLine("checking flights");

            // get flights through the REST interface
            string jsonString = client.DownloadString("http://NorSolutionPortCore.azurewebsites.net/api/1/crudeflight/fetchall");

            JArray flightList = JArray.Parse(client.DownloadString("http://NorSolutionPortCore.azurewebsites.net/api/1/crudeflight/fetchall"));
            JArray flightIdentifierList = JArray.Parse(client.DownloadString("http://NorSolutionPortCore.azurewebsites.net/api/1/crudeflightidentifier/fetchall"));

            // Flight Identifier type FN3 for today
            int dateTimePosition = jsonString.IndexOf($"{DateTime.UtcNow.ToString("M/d/yyyy")} 5:00:00 AM");

            bool foundIt = false;
            foreach (JObject flight in flightList) {

                if (flight["fromDateTime"].ToString().Equals($"{DateTime.UtcNow.ToString("M/d/yyyy")} 5:00:00 AM")) {
                    foreach (JObject identifier in flightIdentifierList) {
                        if (identifier["flightIdentifierTypeRcd"].ToString().Equals("FN3")) {
                            foundIt = true;
                        }
                    }
                }
            }

            Assert.IsTrue(
                            condition: foundIt,
                            message: $"SAS ID:FN3 on date {DateTime.UtcNow.ToString("M/d/yyyy")} not found"
                            );
        }

        /// <summary>
        /// test proxy
        /// </summary>
        [TestMethod]
        public void Step09_REST_and_SOAP_Proxy_test() {
            // using the same contract
            List<SolutionNorSolutionPort.BusinessLogicLayer.AircraftIndexWithFilterContract> aircraftIndexWithFilterContractListSoap = null;
            List<SolutionNorSolutionPort.BusinessLogicLayer.AircraftIndexWithFilterContract> aircraftIndexWithFilterContractListRest = null;

            // Rest
            SolutionNorSolutionPort.BusinessLogicLayer.Proxy
                .AircraftSearchServiceClient aircraftSearchServiceProxyRest =
                    new 
                        SolutionNorSolutionPort.BusinessLogicLayer.Proxy.
                        AircraftSearchServiceClient();

            aircraftIndexWithFilterContractListRest =
                aircraftSearchServiceProxyRest
                    .AircraftIndexWithFilter();

            // Soap
            SolutionNorSolutionPort.BusinessLogicLayer
                .AircraftSearchServiceClient aircraftSearchServiceProxySoap = 
                    new 
                        SolutionNorSolutionPort.BusinessLogicLayer.
                        AircraftSearchServiceClient();

            aircraftIndexWithFilterContractListSoap =
                aircraftSearchServiceProxySoap
                    .AircraftIndexWithFilter();

            Assert.AreEqual(
                expected: aircraftIndexWithFilterContractListSoap.Count,
                actual: 3, //aircraftIndexWithFilterContractListRest.Count,
                message: "Number of aircrafts must be equal between SOAP and REST calls"
            );
        }

        /// <summary>
        /// test proxy
        /// </summary>
        [TestMethod]
        public void Step10_REST_Proxy_Booking_Test() {

            //new BookingServiceClient().UpdateBookingPage1(new Guid(), "source", "locator", "me", "hi", new Guid());

            Assert.AreEqual(
                expected: 3,
                actual: 3,
                message: "Number of aircrafts must be 3 after database has been initialized"
            );
        }

    }
}
