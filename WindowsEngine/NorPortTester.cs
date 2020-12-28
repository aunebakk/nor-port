using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class NorPortTesterMain : Form
    {
        private Guid DefaultUserId { get { return new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}"); } }
        private bool _next = false;

        public NorPortTesterMain() {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void Log(string message) {
            textBoxLog.Text = DateTime.UtcNow + " - " + message + "\r\n" + textBoxLog.Text;
            Application.DoEvents();
        }

        private void Log(
            string main,
            string sub,
            string message
            ) {
            textBoxLog.Text = DateTime.UtcNow + " - " + main + " : " + sub + " : " + message + "\r\n" + textBoxLog.Text;
            Application.DoEvents();
        }

        private void Error(Exception ex) {
            textBoxLog.Text = DateTime.UtcNow + " - Exception : " + ex.Message + "\r\n" + textBoxLog.Text;
            Application.DoEvents();

            // error message
            KeyValuePair<string, object> error = new KeyValuePair<string, object>("ErrorMessage", ex.ToString());
            if ( error.Value != null ) {
                string errorString = string.Empty;
                errorString = error.Value.ToString();

                if ( errorString != string.Empty )
                    textBoxLog.Text = DateTime.UtcNow + " - ErrorMessage : " + errorString + "\r\n" + textBoxLog.Text;
            }

            if ( ex.InnerException != null )
                textBoxLog.Text = DateTime.UtcNow + " - Exception Inner : " + ex.InnerException.Message + "\r\n" + textBoxLog.Text;

            if ( ex.InnerException != null && ex.InnerException.InnerException != null )
                textBoxLog.Text = DateTime.UtcNow + " - Exception Inner Inner: " + ex.InnerException.InnerException.Message + "\r\n" + textBoxLog.Text;

            Application.DoEvents();
        }

        private void buttonHide_Click(object sender, EventArgs e) {
            Hide();
        }

        private void NorPortTester_Shown(object sender, EventArgs e) {
            Log("started");
            Log("timer started");
            //timerScheduled.Interval = 30 * 60 * 1000;    // every thirty minutes
            timerScheduled.Interval = 60 * 1000;    // every minute
            timerScheduled.Enabled = true;
        }

        private void buttonCheckStatus_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            CheckFlightStatus();
            Cursor.Current = Cursors.Default;
        }

        private void CheckFlightStatus() {
            var flightService = new FlightServiceClient();
            var bookingService = new BookingServiceClient();
            try {
                Log("start cycles");

                flightService.CheckFlightStatuses(
                    DateTime.UtcNow.Date,
                    DateTime.UtcNow.Date.AddDays(1),
                    DefaultUserId
                    );

                Log("check flight status finished");

                bookingService.SimulateBookings(
                    DateTime.UtcNow.Date,
                    DateTime.UtcNow.Date.AddDays(1),
                    DefaultUserId
                    );

                Log("simulate bookings finished");

            } catch ( Exception ex ) {
                Error(ex);
            } finally {
                flightService.Close();
            }
        }

        private void timerScheduled_Tick(object sender, EventArgs e) {
            CheckFlightStatus();

            // open web front
            try {
                if ( _next ) {
                    Log("open web front norport, start");
                    webBrowser.ScriptErrorsSuppressed = true;
                    // webBrowser.Navigate("http://SolutionNorSolutionPort.azurewebsites.net/DefaultStatisticsTop5/DefaultStatisticsTop5Index");
                    webBrowser.Navigate("http://NorSolutionPort.azurewebsites.net/Home/SystemInformation");
                    Log("open web front norport, finish");
                    // test
                    Log("Do test, Start");
                    //                    DoTests();
                    new DefaultTestServiceClient().RunAllTests(DefaultUserId);
                    Log("Do test, Finished");
                } else {
                    Log("open web front, developerName start");
                    webBrowser.ScriptErrorsSuppressed = true;
                    webBrowser.Navigate("https://NorSolutionPort.azurewebsites.net/DefaultStatisticsTop5/DefaultStatisticsTop5Index");
                    Log("open web front, developerName finish");
                }
            } catch ( Exception ex ) {
                Error(ex);
            }
            _next = !_next;
        }

        private void buttonExchange_Click(object sender, EventArgs e) {
            var xml = XDocument.Load("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            string st = xml.Document.ToString();

            // hopeless, use linq instead
            st = st.Substring(st.IndexOf("<Cube>"), st.IndexOf("</gesmes:Envelope>") - st.IndexOf("<Cube>"));
            var xml2 = XDocument.Parse(st);

            foreach ( var x in xml2.Elements("Cube").Elements("Cube").Elements("Cube") ) {
                string currencyCode = ( string ) x.Attribute("currency");
                decimal rate = ( decimal ) x.Attribute("rate");

                new BookingServiceClient().FinancialCurrencyUpdate(
                    "USD",
                    currencyCode,
                    rate,
                    DefaultUserId
                    );
            }
        }

        private void buttonFlightAware_Click(object sender, EventArgs e) {
            //FlightXML2 df = new FlightXML2();
            //df.Credentials = new NetworkCredential("developerName@hotmail.com", "passwordPersonalStyle");
            //df.PreAuthenticate = true;

            //// get the flights currently enroute.
            //EnrouteStruct r = df.Enroute("KAUS", 10, "", 0);
            //foreach ( EnrouteFlightStruct e2 in r.enroute ) {
            //    System.Console.WriteLine(e2.ident);
            //}

            //// get the weather.
            //System.Console.WriteLine(df.Metar("KAUS"));
        }

        private void NorPortTesterMain_Resize(object sender, EventArgs e) {
            //if (WindowState == FormWindowState.Minimized)
            //    {
            //        this.Hide();
            //    }        
        }

        private void TryCall(
            string systemName,
            string testArea,
            string url
            ) {

            var client = new WebClient();
            string html = string.Empty;
            WebHeaderCollection headers = null;

            var test = new CrudeDefaultTestContract();
            test.DefaultTestId = Guid.NewGuid();
            test.SystemName = systemName;
            test.TestArea = testArea;
            test.TestSubArea = " ";
            test.TestAddress = url;
            test.DateTime = DateTime.UtcNow;
            test.UserId = DefaultUserId;

            var testRun = new CrudeDefaultTestRunContract();
            testRun.DefaultTestId = test.DefaultTestId;
            testRun.DateTime = DateTime.UtcNow;
            testRun.UserId = DefaultUserId;

            try {
                testRun.StartDateTime = DateTime.UtcNow;

                // download page
                var time = LoggingTime.PerformanceTimeStart("tryCall");
                html = client.DownloadString(url);
                time.PerformanceTimeStop();

                testRun.ElapsedMilliseconds = ( int ) time.StopWatch.ElapsedMilliseconds;
                testRun.EndDateTime = DateTime.UtcNow;

                headers = client.ResponseHeaders;
                testRun.Result = headers.ToString();

                testRun.DefaultTestRunResultRcd = DefaultTestRunResultRef.OK;
            } catch ( WebException ex ) {
                testRun.DefaultTestRunResultRcd = DefaultTestRunResultRef.WebException;
                testRun.Result = "Status: " + ex.Status + ", Response: " + ex.Response + " : " + url;
                Error(ex);
            } catch ( Exception ex ) {
                testRun.DefaultTestRunResultRcd = DefaultTestRunResultRef.Exception;
                testRun.Result = "Message: " + ex.Message + " : " + url;
                Error(ex);
            }

            // truncate result
            if ( testRun.Result.Length > 240 )
                testRun.Result = testRun.Result.Substring(0, 240);

            try {
                //new CrudeDefaultTestServiceClient().Insert(test);
                //new CrudeDefaultTestRunServiceClient().Insert(testRun);

                var defaultTest = new DefaultTestServiceClient();
                defaultTest.AddTestRun(
                    test.SystemName, test.TestArea, test.TestSubArea, test.TestAddress,
                    testRun.StartDateTime, testRun.EndDateTime, testRun.ElapsedMilliseconds, testRun.DefaultTestRunResultRcd,
                    testRun.Result, testRun.UserId
                    );

            } catch ( Exception ex ) {
                Error(ex);
            }

            Log(systemName, testArea, testRun.DefaultTestRunResultRcd);
        }

        private void DoTests() {
            // run all tests
            var allTests = new CrudeDefaultTestServiceClient().FetchAll();
            foreach ( var test in allTests ) {
                TryCall(
                    test.SystemName,
                    test.TestArea,
                    test.TestAddress
                    );
            }

            // pim
            /*
            TryCall("PIM", "Structure", "http://SolutionNorSolutionPort.azurewebsites.net/TreeView/Index");
            TryCall("PIM", "Maintenance", "http://SolutionNorSolutionPort.azurewebsites.net/ProductMaintenance/ProductMaintenanceIndex");
            TryCall("PIM", "Category", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductCategory/CrudeProductCategoryIndex");
            TryCall("PIM", "Category Image", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductCategoryImage/CrudeProductCategoryImageIndex");
            TryCall("PIM", "Category Documentation", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationIndex");
            TryCall("PIM", "Products On Category", "http://SolutionNorSolutionPort.azurewebsites.net/ProductSearchByCategory/ProductSearchByCategoryIndex?productCategoryId=c4750eb4-c2df-46a2-968a-07ed65d3b94e&onParent=False");
            TryCall("PIM", "Product", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProduct/CrudeProductIndex");
            TryCall("PIM", "Attribute", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductAttribute/CrudeProductAttributeIndex");
            TryCall("PIM", "Documentation", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductDocumentation/CrudeProductDocumentationIndex");
            TryCall("PIM", "Image", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductImage/CrudeProductImageIndex");
            TryCall("PIM", "Info", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductInfo/CrudeProductInfoIndex");
            TryCall("PIM", "Identifier", "http://SolutionNorSolutionPort.azurewebsites.net/CrudeProductIdentifier/CrudeProductIdentifierIndex");
            TryCall("PIM", "PIM Documentation", "http://SolutionNorSolutionPort.azurewebsites.net/norpim/Index");
            TryCall("PIM", "Reference Attribute", "http://SolutionNorSolutionPort.azurewebsites.net/ProductReferenceAttribute/ProductReferenceAttributeEdit");
            TryCall("PIM", "", "");
            //TryCall("PIM", "", "");           
            */
        }

        private void buttonCall_Click(object sender, EventArgs e) {
            DoTests();
        }

        private void buttonCallService_Click(object sender, EventArgs e) {
            new DefaultTestServiceClient().RunAllTests(DefaultUserId);
        }
    }
}

