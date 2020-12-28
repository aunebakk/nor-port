using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.ServiceModel;
using SolutionNorSolutionPort.DataAccessLayer;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [ServiceContract()]
    public interface IDefaultTestService
    {
        // add test run
        [OperationContract()]
        System.Guid AddTestRun(
            string systemName,
            string testArea,
            string testSubArea,
            string testAddress,
            DateTime startDateTime,
            DateTime endDateTime,
            int elapsedMilliseconds,
            string defaultTestRunResultRcd,
            string result,
            System.Guid userId
            );

        // run all tests
        [OperationContract()]
        void RunAllTests(
            System.Guid userId
            );
    }

    /// <domain>DefaultTest</domain>
    /// <class></class>
    public class DefaultTestService : IDefaultTestService
    {
        /// <summary>
        /// run all tests
        /// </summary>
        /// <param name="userId"></param>
        public void RunAllTests(
            System.Guid userId
            ) {

            List<CrudeDefaultTestContract> allTests = new CrudeDefaultTestService().FetchAll();
            foreach ( var test in allTests ) {
                string defaultTestRunResultRcd = string.Empty;
                string result = string.Empty;

                // make call
                var time = Logging.PerformanceTimeStart("RunAllTests");
                try {
                    var client = new WebClient();
                    string html = client.DownloadString(test.TestAddress);

                    WebHeaderCollection headers = client.ResponseHeaders;
                    defaultTestRunResultRcd = DefaultTestRunResultRef.OK;
                    result = headers.ToString();
                } catch ( WebException ex ) {
                    defaultTestRunResultRcd = DefaultTestRunResultRef.WebException;
                    result = "Status: " + ex.Status + ", Response: " + ex.Response + " : " + test.TestAddress;
                } catch ( Exception ex ) {
                    defaultTestRunResultRcd = DefaultTestRunResultRef.Exception;
                    result = "Message: " + ex.Message + " : " + test.TestAddress;
                }
                time.PerformanceTimeStop();

                // save result of call
                AddTestRun(
                    test.SystemName, test.TestArea, test.TestSubArea, test.TestAddress,
                    time.StartUTC, time.StopUTC,
                    ( int ) time.StopWatch.ElapsedMilliseconds,
                    defaultTestRunResultRcd,
                    result,
                    userId
                    );
            }
        }

        /// <summary>
        /// add test run
        /// </summary>
        /// <param name="systemName"></param>
        /// <param name="testArea"></param>
        /// <param name="testSubArea"></param>
        /// <param name="testAddress"></param>
        /// <param name="startDateTime"></param>
        /// <param name="endDateTime"></param>
        /// <param name="elapsedMilliseconds"></param>
        /// <param name="defaultTestRunResultRcd"></param>
        /// <param name="result"></param>
        /// <param name="userId"></param>
        /// <returns>new test run id</returns>
        public System.Guid AddTestRun(
            string systemName,
            string testArea,
            string testSubArea,
            string testAddress,
            DateTime startDateTime,
            DateTime endDateTime,
            int elapsedMilliseconds,
            string defaultTestRunResultRcd,
            string result,
            System.Guid userId
            ) {

            Logging log = 
                Logging.PerformanceTimeStart(
                    "DefaultTest", "BusinessLogicLayer", "DefaultTest", "AddTestRun", userId);

            // find existing test(s)
            List<CrudeDefaultTestContract> tests = 
                new CrudeDefaultTestService().FetchWithFilter(
                    Guid.Empty,
                    systemName,
                    testArea,
                    testSubArea,
                    testAddress,
                    Guid.Empty,
                    DateTime.MinValue
                    );

            var test = new CrudeDefaultTestContract();
            using ( var connection = new SqlConnection(Conn.ConnectionString) ) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // insert new test
                    if ( tests.Count > 0 ) {
                        // pick the first one
                        test = tests[0];
                    } else {
                        test = new CrudeDefaultTestContract();
                        test.DefaultTestId = Guid.NewGuid();
                        test.SystemName = systemName;
                        test.TestArea = testArea;
                        test.TestSubArea = testSubArea;
                        test.TestAddress = testAddress;
                        test.DateTime = DateTime.UtcNow;
                        test.UserId = userId;
                        new CrudeDefaultTestService().Insert(test, connection, transaction);
                    }

                    // insert new test run
                    var testRun = new CrudeDefaultTestRunContract();
                    testRun.DefaultTestId = test.DefaultTestId;
                    testRun.DefaultTestRunResultRcd = defaultTestRunResultRcd;
                    testRun.StartDateTime = startDateTime;
                    testRun.EndDateTime = endDateTime;
                    testRun.ElapsedMilliseconds = elapsedMilliseconds;

                    // truncate result to the first 240 chars
                    if ( result.Length > 240 )
                        testRun.Result = result.Substring(0, 240);
                    else
                        testRun.Result = result;

                    // avoid empty result
                    if (string.IsNullOrEmpty(testRun.Result))
                        testRun.Result = "N/A";

                    testRun.DateTime = DateTime.UtcNow;
                    testRun.UserId = userId;
                    new CrudeDefaultTestRunService().Insert(testRun, connection, transaction);

                    // commit and log transaction
                    transaction.Commit();
                    log.PerformanceTimeStop();
                } catch ( Exception ex ) {
                    transaction.Rollback();
                    log.Error(ex);
                    throw new Exception("DefaultTestService.AddTestRun", ex);
                }
            }

            return test.DefaultTestId;
        }
    }
}
