/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:31:56 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// Namespace for a Business Logic Layer in a Proxy
// Namespace for a Business Logic Layer in a Proxy
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// Namespace for a Business Logic Layer in a Proxy
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // proxy service class for dot net framework
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class DefaultSearchServiceClient {
        // REST interface to Business layer
        // REST interface to Business layer
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultResourceDatabaseStatistics?";
            string jsonString = client.DownloadString(query);

            List<DefaultResourceDatabaseStatisticsContract> reply =
                JsonConvert.DeserializeObject<List<DefaultResourceDatabaseStatisticsContract>>(jsonString);

            return reply;
        }

        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultResourceStatistics?";
            string jsonString = client.DownloadString(query);

            List<DefaultResourceStatisticsContract> reply =
                JsonConvert.DeserializeObject<List<DefaultResourceStatisticsContract>>(jsonString);

            return reply;
        }

        public List<GetDefaultChangeLogContract> GetDefaultChangeLog(
            System.String defaultChangeName,
            System.String defaultChangeLogTypeRcd,
            System.Guid defaultIssueId,
            System.Guid defaultChangeLogId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/GetDefaultChangeLog?defaultChangeName={defaultChangeName}&defaultChangeLogTypeRcd={defaultChangeLogTypeRcd}&defaultIssueId={defaultIssueId}&defaultChangeLogId={defaultChangeLogId}";
            string jsonString = client.DownloadString(query);

            List<GetDefaultChangeLogContract> reply =
                JsonConvert.DeserializeObject<List<GetDefaultChangeLogContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserListForDashboard?";
            string jsonString = client.DownloadString(query);

            List<DefaultUserListForDashboardContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserListForDashboardContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserListContract> DefaultUserList(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserList?";
            string jsonString = client.DownloadString(query);

            List<DefaultUserListContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserListContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserActivityGroupedByAddress?";
            string jsonString = client.DownloadString(query);

            List<DefaultUserActivityGroupedByAddressContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserActivityGroupedByAddressContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserActivityGrouped?";
            string jsonString = client.DownloadString(query);

            List<DefaultUserActivityGroupedContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserActivityGroupedContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress(
            System.String originatingAddress
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserActivityOnAddress?originatingAddress={originatingAddress}";
            string jsonString = client.DownloadString(query);

            List<DefaultUserActivityOnAddressContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserActivityOnAddressContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent(
            System.Guid defaultUserId
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserActivityRecent?defaultUserId={defaultUserId}";
            string jsonString = client.DownloadString(query);

            List<DefaultUserActivityRecentContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserActivityRecentContract>>(jsonString);

            return reply;
        }

        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultPerformanceTimeCommands?";
            string jsonString = client.DownloadString(query);

            List<DefaultPerformanceTimeCommandsContract> reply =
                JsonConvert.DeserializeObject<List<DefaultPerformanceTimeCommandsContract>>(jsonString);

            return reply;
        }

        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes(
            System.String commandName
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultPerformanceTimes?commandName={commandName}";
            string jsonString = client.DownloadString(query);

            List<DefaultPerformanceTimesContract> reply =
                JsonConvert.DeserializeObject<List<DefaultPerformanceTimesContract>>(jsonString);

            return reply;
        }

        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultStatisticsTop5?";
            string jsonString = client.DownloadString(query);

            List<DefaultStatisticsTop5Contract> reply =
                JsonConvert.DeserializeObject<List<DefaultStatisticsTop5Contract>>(jsonString);

            return reply;
        }

        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultStatisticsByMonth?";
            string jsonString = client.DownloadString(query);

            List<DefaultStatisticsByMonthContract> reply =
                JsonConvert.DeserializeObject<List<DefaultStatisticsByMonthContract>>(jsonString);

            return reply;
        }

        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultUserActivityByHour?";
            string jsonString = client.DownloadString(query);

            List<DefaultUserActivityByHourContract> reply =
                JsonConvert.DeserializeObject<List<DefaultUserActivityByHourContract>>(jsonString);

            return reply;
        }

        public List<DefaultStatisticsContract> DefaultStatistics(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultStatistics?";
            string jsonString = client.DownloadString(query);

            List<DefaultStatisticsContract> reply =
                JsonConvert.DeserializeObject<List<DefaultStatisticsContract>>(jsonString);

            return reply;
        }

        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultPerformanceIndicators?";
            string jsonString = client.DownloadString(query);

            List<DefaultPerformanceIndicatorsContract> reply =
                JsonConvert.DeserializeObject<List<DefaultPerformanceIndicatorsContract>>(jsonString);

            return reply;
        }

        public List<DefaultErrorOverviewContract> DefaultErrorOverview(
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultErrorOverview?";
            string jsonString = client.DownloadString(query);

            List<DefaultErrorOverviewContract> reply =
                JsonConvert.DeserializeObject<List<DefaultErrorOverviewContract>>(jsonString);

            return reply;
        }

        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter(
            System.String defaultIssueTypeRcd,
            System.String defaultIssueStatusRcd
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultIssueWithFilter?defaultIssueTypeRcd={defaultIssueTypeRcd}&defaultIssueStatusRcd={defaultIssueStatusRcd}";
            string jsonString = client.DownloadString(query);

            List<DefaultIssueWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<DefaultIssueWithFilterContract>>(jsonString);

            return reply;
        }

        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter(
            System.String commandName
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultPerformanceIssueFetchWithFilter?commandName={commandName}";
            string jsonString = client.DownloadString(query);

            List<DefaultPerformanceIssueFetchWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<DefaultPerformanceIssueFetchWithFilterContract>>(jsonString);

            return reply;
        }

        public List<DashboardCountsContract> DashboardCounts(
            System.String dashboardLayoutRcd
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DashboardCounts?dashboardLayoutRcd={dashboardLayoutRcd}";
            string jsonString = client.DownloadString(query);

            List<DashboardCountsContract> reply =
                JsonConvert.DeserializeObject<List<DashboardCountsContract>>(jsonString);

            return reply;
        }

        public List<DefaultTestOverviewContract> DefaultTestOverview(
            System.String commandName
            ) {

            WebClient client = new WebClient();

            string query = $"http://NorSolutionPortCore.AzureWebSites.net/api/1/DefaultSearchService/DefaultTestOverview?commandName={commandName}";
            string jsonString = client.DownloadString(query);

            List<DefaultTestOverviewContract> reply =
                JsonConvert.DeserializeObject<List<DefaultTestOverviewContract>>(jsonString);

            return reply;
        }

    }
}
