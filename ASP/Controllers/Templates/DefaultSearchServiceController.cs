/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:41 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// controller namespace for mvc
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/DefaultSearchService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DefaultSearchServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("DefaultResourceDatabaseStatistics")]
        public IEnumerable<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics(
            ) {

            List<DefaultResourceDatabaseStatisticsContract> list =
                new DefaultSearchService().DefaultResourceDatabaseStatistics();

            return list;
        }

        [HttpGet("DefaultResourceStatistics")]
        public IEnumerable<DefaultResourceStatisticsContract> DefaultResourceStatistics(
            ) {

            List<DefaultResourceStatisticsContract> list =
                new DefaultSearchService().DefaultResourceStatistics();

            return list;
        }

        [HttpGet("GetDefaultChangeLog")]
        public IEnumerable<GetDefaultChangeLogContract> GetDefaultChangeLog(
            System.String defaultChangeName,
            System.String defaultChangeLogTypeRcd,
            System.Guid defaultIssueId,
            System.Guid defaultChangeLogId
            ) {

            List<GetDefaultChangeLogContract> list =
                new DefaultSearchService().GetDefaultChangeLog(defaultChangeName: defaultChangeName, defaultChangeLogTypeRcd: defaultChangeLogTypeRcd, defaultIssueId: defaultIssueId, defaultChangeLogId: defaultChangeLogId);

            return list;
        }

        [HttpGet("DefaultUserListForDashboard")]
        public IEnumerable<DefaultUserListForDashboardContract> DefaultUserListForDashboard(
            ) {

            List<DefaultUserListForDashboardContract> list =
                new DefaultSearchService().DefaultUserListForDashboard();

            return list;
        }

        [HttpGet("DefaultUserList")]
        public IEnumerable<DefaultUserListContract> DefaultUserList(
            ) {

            List<DefaultUserListContract> list =
                new DefaultSearchService().DefaultUserList();

            return list;
        }

        [HttpGet("DefaultUserActivityGroupedByAddress")]
        public IEnumerable<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress(
            ) {

            List<DefaultUserActivityGroupedByAddressContract> list =
                new DefaultSearchService().DefaultUserActivityGroupedByAddress();

            return list;
        }

        [HttpGet("DefaultUserActivityGrouped")]
        public IEnumerable<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped(
            ) {

            List<DefaultUserActivityGroupedContract> list =
                new DefaultSearchService().DefaultUserActivityGrouped();

            return list;
        }

        [HttpGet("DefaultUserActivityOnAddress")]
        public IEnumerable<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress(
            System.String originatingAddress
            ) {

            List<DefaultUserActivityOnAddressContract> list =
                new DefaultSearchService().DefaultUserActivityOnAddress(originatingAddress: originatingAddress);

            return list;
        }

        [HttpGet("DefaultUserActivityRecent")]
        public IEnumerable<DefaultUserActivityRecentContract> DefaultUserActivityRecent(
            System.Guid defaultUserId
            ) {

            List<DefaultUserActivityRecentContract> list =
                new DefaultSearchService().DefaultUserActivityRecent(defaultUserId: defaultUserId);

            return list;
        }

        [HttpGet("DefaultPerformanceTimeCommands")]
        public IEnumerable<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands(
            ) {

            List<DefaultPerformanceTimeCommandsContract> list =
                new DefaultSearchService().DefaultPerformanceTimeCommands();

            return list;
        }

        [HttpGet("DefaultPerformanceTimes")]
        public IEnumerable<DefaultPerformanceTimesContract> DefaultPerformanceTimes(
            System.String commandName
            ) {

            List<DefaultPerformanceTimesContract> list =
                new DefaultSearchService().DefaultPerformanceTimes(commandName: commandName);

            return list;
        }

        [HttpGet("DefaultStatisticsTop5")]
        public IEnumerable<DefaultStatisticsTop5Contract> DefaultStatisticsTop5(
            ) {

            List<DefaultStatisticsTop5Contract> list =
                new DefaultSearchService().DefaultStatisticsTop5();

            return list;
        }

        [HttpGet("DefaultStatisticsByMonth")]
        public IEnumerable<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth(
            ) {

            List<DefaultStatisticsByMonthContract> list =
                new DefaultSearchService().DefaultStatisticsByMonth();

            return list;
        }

        [HttpGet("DefaultUserActivityByHour")]
        public IEnumerable<DefaultUserActivityByHourContract> DefaultUserActivityByHour(
            ) {

            List<DefaultUserActivityByHourContract> list =
                new DefaultSearchService().DefaultUserActivityByHour();

            return list;
        }

        [HttpGet("DefaultStatistics")]
        public IEnumerable<DefaultStatisticsContract> DefaultStatistics(
            ) {

            List<DefaultStatisticsContract> list =
                new DefaultSearchService().DefaultStatistics();

            return list;
        }

        [HttpGet("DefaultPerformanceIndicators")]
        public IEnumerable<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators(
            ) {

            List<DefaultPerformanceIndicatorsContract> list =
                new DefaultSearchService().DefaultPerformanceIndicators();

            return list;
        }

        [HttpGet("DefaultErrorOverview")]
        public IEnumerable<DefaultErrorOverviewContract> DefaultErrorOverview(
            ) {

            List<DefaultErrorOverviewContract> list =
                new DefaultSearchService().DefaultErrorOverview();

            return list;
        }

        [HttpGet("DefaultIssueWithFilter")]
        public IEnumerable<DefaultIssueWithFilterContract> DefaultIssueWithFilter(
            System.String defaultIssueTypeRcd,
            System.String defaultIssueStatusRcd
            ) {

            List<DefaultIssueWithFilterContract> list =
                new DefaultSearchService().DefaultIssueWithFilter(defaultIssueTypeRcd: defaultIssueTypeRcd, defaultIssueStatusRcd: defaultIssueStatusRcd);

            return list;
        }

        [HttpGet("DefaultPerformanceIssueFetchWithFilter")]
        public IEnumerable<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter(
            System.String commandName
            ) {

            List<DefaultPerformanceIssueFetchWithFilterContract> list =
                new DefaultSearchService().DefaultPerformanceIssueFetchWithFilter(commandName: commandName);

            return list;
        }

        [HttpGet("DashboardCounts")]
        public IEnumerable<DashboardCountsContract> DashboardCounts(
            System.String dashboardLayoutRcd
            ) {

            List<DashboardCountsContract> list =
                new DefaultSearchService().DashboardCounts(dashboardLayoutRcd: dashboardLayoutRcd);

            return list;
        }

        [HttpGet("DefaultTestOverview")]
        public IEnumerable<DefaultTestOverviewContract> DefaultTestOverview(
            System.String commandName
            ) {

            List<DefaultTestOverviewContract> list =
                new DefaultSearchService().DefaultTestOverview(commandName: commandName);

            return list;
        }
    }
}
