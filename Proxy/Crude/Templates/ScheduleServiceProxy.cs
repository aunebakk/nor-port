/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:29:37 PM
  From Machine: DESKTOP-LSRVP12
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
    public class ScheduleServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public void MakeFlightsFromScheduleAll(
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/ScheduleService/MakeFlightsFromScheduleAll?userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void MakeFlightsFromSchedule(
            System.Guid flightScheduleId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/ScheduleService/MakeFlightsFromSchedule?flightScheduleId={flightScheduleId}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public ScheduleContract GetSchedule(
            System.Guid flightScheduleId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/ScheduleService/GetSchedule?flightScheduleId={flightScheduleId}&userId={userId}";
            string jsonString = client.DownloadString(query);

            ScheduleContract reply =
                JsonConvert.DeserializeObject<ScheduleContract>(jsonString);

            return reply;
        }

        public void CreateSchedule(
            ScheduleContract scheduleContract,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/ScheduleService/CreateSchedule?scheduleContract={scheduleContract}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void UpdateSchedule(
            ScheduleContract scheduleContract,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/ScheduleService/UpdateSchedule?scheduleContract={scheduleContract}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

    }
}
