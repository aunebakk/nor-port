/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:52:14 AM
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
    public class DefaultUserActivityServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public System.String ResolveNetnameFromIpV4(
            System.String ipAddress
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultUserActivityService/ResolveNetnameFromIpV4?ipAddress={ipAddress}";
            string jsonString = client.DownloadString(query);

            System.String reply =
                JsonConvert.DeserializeObject<System.String>(jsonString);

            return reply;
        }

        public void AddActivity(
            System.Guid userId,
            System.String userActivityTypeRcd,
            System.String activityNote,
            System.String originatingAddress
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultUserActivityService/AddActivity?userId={userId}&userActivityTypeRcd={userActivityTypeRcd}&activityNote={activityNote}&originatingAddress={originatingAddress}";
            string jsonString = client.DownloadString(query);

        }

        public System.Guid Login(
            System.String userCode
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultUserActivityService/Login?userCode={userCode}";
            string jsonString = client.DownloadString(query);

            System.Guid reply =
                JsonConvert.DeserializeObject<System.Guid>(jsonString);

            return reply;
        }

        public System.Guid LoginOverrideUserName(
            System.String userCode
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultUserActivityService/LoginOverrideUserName?userCode={userCode}";
            string jsonString = client.DownloadString(query);

            System.Guid reply =
                JsonConvert.DeserializeObject<System.Guid>(jsonString);

            return reply;
        }

    }
}
