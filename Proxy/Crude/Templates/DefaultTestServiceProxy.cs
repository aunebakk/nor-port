/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:52:21 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// business namespace for proxy
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class DefaultTestServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public System.Guid AddTestRun(
            System.String systemName,
            System.String testArea,
            System.String testSubArea,
            System.String testAddress,
            System.DateTime startDateTime,
            System.DateTime endDateTime,
            System.Int32 elapsedMilliseconds,
            System.String defaultTestRunResultRcd,
            System.String result,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultTestService/AddTestRun?systemName={systemName}&testArea={testArea}&testSubArea={testSubArea}&testAddress={testAddress}&startDateTime={startDateTime}&endDateTime={endDateTime}&elapsedMilliseconds={elapsedMilliseconds}&defaultTestRunResultRcd={defaultTestRunResultRcd}&result={result}&userId={userId}";
            string jsonString = client.DownloadString(query);

            System.Guid reply =
                JsonConvert.DeserializeObject<System.Guid>(jsonString);

            return reply;
        }

        public void RunAllTests(
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultTestService/RunAllTests?userId={userId}";
            string jsonString = client.DownloadString(query);

        }

    }
}
