using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class AfterDatabaseInitOrdered {
        [TestMethod]
        public void Start() {
            AfterDatabaseInit afterDatabaseInit = new AfterDatabaseInit();

            afterDatabaseInit.Step1_Web_InitiateDB();
            afterDatabaseInit.Step2_API_MakeFlights();
            afterDatabaseInit.Step3_API_CheckFlightAndMakeBookings();
            afterDatabaseInit.Step4_Web_Reports();
            afterDatabaseInit.Step5_SOAP_Count_Aircrafts();
            afterDatabaseInit.Step6_SOAP_Count_Flights();
            afterDatabaseInit.Step7_REST_Count_Flights();
            afterDatabaseInit.Step8_REST_Check_Flights();
        }
    }
}
