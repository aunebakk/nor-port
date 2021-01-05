/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 1:26:58 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/DefaultSearchService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DefaultSearchServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultSearchServiceHelp.cshtml");
        }

        [HttpGet("DefaultResourceDatabaseStatisticsHelp")]
        public IActionResult DefaultResourceDatabaseStatisticsHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultResourceDatabaseStatisticsHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultResourceDatabaseStatistics
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultResourceDatabaseStatistics")]
        public IEnumerable<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics(
            ) {

            List<DefaultResourceDatabaseStatisticsContract> list =
                new DefaultSearchService().DefaultResourceDatabaseStatistics();

            return list;
        }


        [HttpGet("DefaultResourceStatisticsHelp")]
        public IActionResult DefaultResourceStatisticsHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultResourceStatisticsHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultResourceStatistics
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultResourceStatistics")]
        public IEnumerable<DefaultResourceStatisticsContract> DefaultResourceStatistics(
            ) {

            List<DefaultResourceStatisticsContract> list =
                new DefaultSearchService().DefaultResourceStatistics();

            return list;
        }


        [HttpGet("GetDefaultChangeLogHelp")]
        public IActionResult GetDefaultChangeLogHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\GetDefaultChangeLogHelp.cshtml");
        }

        // get a JSON Array Contract with data for GetDefaultChangeLog
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  defaultChangeName: filter by this key, for no filter use: ''
        //   defaultChangeLogTypeRcd: filter by this key, for no filter use: ''
        //   defaultIssueId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   defaultChangeLogId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
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


        [HttpGet("DefaultUserListForDashboardHelp")]
        public IActionResult DefaultUserListForDashboardHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserListForDashboardHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserListForDashboard
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultUserListForDashboard")]
        public IEnumerable<DefaultUserListForDashboardContract> DefaultUserListForDashboard(
            ) {

            List<DefaultUserListForDashboardContract> list =
                new DefaultSearchService().DefaultUserListForDashboard();

            return list;
        }


        [HttpGet("DefaultUserListHelp")]
        public IActionResult DefaultUserListHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserListHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserList
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultUserList")]
        public IEnumerable<DefaultUserListContract> DefaultUserList(
            ) {

            List<DefaultUserListContract> list =
                new DefaultSearchService().DefaultUserList();

            return list;
        }


        [HttpGet("DefaultUserActivityGroupedByAddressHelp")]
        public IActionResult DefaultUserActivityGroupedByAddressHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserActivityGroupedByAddressHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserActivityGroupedByAddress
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultUserActivityGroupedByAddress")]
        public IEnumerable<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress(
            ) {

            List<DefaultUserActivityGroupedByAddressContract> list =
                new DefaultSearchService().DefaultUserActivityGroupedByAddress();

            return list;
        }


        [HttpGet("DefaultUserActivityGroupedHelp")]
        public IActionResult DefaultUserActivityGroupedHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserActivityGroupedHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserActivityGrouped
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultUserActivityGrouped")]
        public IEnumerable<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped(
            ) {

            List<DefaultUserActivityGroupedContract> list =
                new DefaultSearchService().DefaultUserActivityGrouped();

            return list;
        }


        [HttpGet("DefaultUserActivityOnAddressHelp")]
        public IActionResult DefaultUserActivityOnAddressHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserActivityOnAddressHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserActivityOnAddress
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  originatingAddress: filter by this key, for no filter use: ''
        [HttpGet("DefaultUserActivityOnAddress")]
        public IEnumerable<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress(
            System.String originatingAddress
            ) {

            List<DefaultUserActivityOnAddressContract> list =
                new DefaultSearchService().DefaultUserActivityOnAddress(originatingAddress: originatingAddress);

            return list;
        }


        [HttpGet("DefaultUserActivityRecentHelp")]
        public IActionResult DefaultUserActivityRecentHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserActivityRecentHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserActivityRecent
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  defaultUserId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("DefaultUserActivityRecent")]
        public IEnumerable<DefaultUserActivityRecentContract> DefaultUserActivityRecent(
            System.Guid defaultUserId
            ) {

            List<DefaultUserActivityRecentContract> list =
                new DefaultSearchService().DefaultUserActivityRecent(defaultUserId: defaultUserId);

            return list;
        }


        [HttpGet("DefaultPerformanceTimeCommandsHelp")]
        public IActionResult DefaultPerformanceTimeCommandsHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultPerformanceTimeCommandsHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultPerformanceTimeCommands
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultPerformanceTimeCommands")]
        public IEnumerable<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands(
            ) {

            List<DefaultPerformanceTimeCommandsContract> list =
                new DefaultSearchService().DefaultPerformanceTimeCommands();

            return list;
        }


        [HttpGet("DefaultPerformanceTimesHelp")]
        public IActionResult DefaultPerformanceTimesHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultPerformanceTimesHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultPerformanceTimes
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  commandName: filter by this key, for no filter use: ''
        [HttpGet("DefaultPerformanceTimes")]
        public IEnumerable<DefaultPerformanceTimesContract> DefaultPerformanceTimes(
            System.String commandName
            ) {

            List<DefaultPerformanceTimesContract> list =
                new DefaultSearchService().DefaultPerformanceTimes(commandName: commandName);

            return list;
        }


        [HttpGet("DefaultStatisticsTop5Help")]
        public IActionResult DefaultStatisticsTop5Help(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultStatisticsTop5Help.cshtml");
        }

        // get a JSON Array Contract with data for DefaultStatisticsTop5
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultStatisticsTop5")]
        public IEnumerable<DefaultStatisticsTop5Contract> DefaultStatisticsTop5(
            ) {

            List<DefaultStatisticsTop5Contract> list =
                new DefaultSearchService().DefaultStatisticsTop5();

            return list;
        }


        [HttpGet("DefaultStatisticsByMonthHelp")]
        public IActionResult DefaultStatisticsByMonthHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultStatisticsByMonthHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultStatisticsByMonth
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultStatisticsByMonth")]
        public IEnumerable<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth(
            ) {

            List<DefaultStatisticsByMonthContract> list =
                new DefaultSearchService().DefaultStatisticsByMonth();

            return list;
        }


        [HttpGet("DefaultUserActivityByHourHelp")]
        public IActionResult DefaultUserActivityByHourHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultUserActivityByHourHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultUserActivityByHour
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultUserActivityByHour")]
        public IEnumerable<DefaultUserActivityByHourContract> DefaultUserActivityByHour(
            ) {

            List<DefaultUserActivityByHourContract> list =
                new DefaultSearchService().DefaultUserActivityByHour();

            return list;
        }


        [HttpGet("DefaultStatisticsHelp")]
        public IActionResult DefaultStatisticsHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultStatisticsHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultStatistics
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultStatistics")]
        public IEnumerable<DefaultStatisticsContract> DefaultStatistics(
            ) {

            List<DefaultStatisticsContract> list =
                new DefaultSearchService().DefaultStatistics();

            return list;
        }


        [HttpGet("DefaultPerformanceIndicatorsHelp")]
        public IActionResult DefaultPerformanceIndicatorsHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultPerformanceIndicatorsHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultPerformanceIndicators
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultPerformanceIndicators")]
        public IEnumerable<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators(
            ) {

            List<DefaultPerformanceIndicatorsContract> list =
                new DefaultSearchService().DefaultPerformanceIndicators();

            return list;
        }


        [HttpGet("DefaultErrorOverviewHelp")]
        public IActionResult DefaultErrorOverviewHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultErrorOverviewHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultErrorOverview
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("DefaultErrorOverview")]
        public IEnumerable<DefaultErrorOverviewContract> DefaultErrorOverview(
            ) {

            List<DefaultErrorOverviewContract> list =
                new DefaultSearchService().DefaultErrorOverview();

            return list;
        }


        [HttpGet("DefaultIssueWithFilterHelp")]
        public IActionResult DefaultIssueWithFilterHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultIssueWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultIssueWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  defaultIssueTypeRcd: filter by this key, for no filter use: ''
        //   defaultIssueStatusRcd: filter by this key, for no filter use: ''
        [HttpGet("DefaultIssueWithFilter")]
        public IEnumerable<DefaultIssueWithFilterContract> DefaultIssueWithFilter(
            System.String defaultIssueTypeRcd,
            System.String defaultIssueStatusRcd
            ) {

            List<DefaultIssueWithFilterContract> list =
                new DefaultSearchService().DefaultIssueWithFilter(defaultIssueTypeRcd: defaultIssueTypeRcd, defaultIssueStatusRcd: defaultIssueStatusRcd);

            return list;
        }


        [HttpGet("DefaultPerformanceIssueFetchWithFilterHelp")]
        public IActionResult DefaultPerformanceIssueFetchWithFilterHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultPerformanceIssueFetchWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultPerformanceIssueFetchWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  commandName: filter by this key, for no filter use: ''
        [HttpGet("DefaultPerformanceIssueFetchWithFilter")]
        public IEnumerable<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter(
            System.String commandName
            ) {

            List<DefaultPerformanceIssueFetchWithFilterContract> list =
                new DefaultSearchService().DefaultPerformanceIssueFetchWithFilter(commandName: commandName);

            return list;
        }


        [HttpGet("DashboardCountsHelp")]
        public IActionResult DashboardCountsHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DashboardCountsHelp.cshtml");
        }

        // get a JSON Array Contract with data for DashboardCounts
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  dashboardLayoutRcd: filter by this key, for no filter use: ''
        [HttpGet("DashboardCounts")]
        public IEnumerable<DashboardCountsContract> DashboardCounts(
            System.String dashboardLayoutRcd
            ) {

            List<DashboardCountsContract> list =
                new DefaultSearchService().DashboardCounts(dashboardLayoutRcd: dashboardLayoutRcd);

            return list;
        }


        [HttpGet("DefaultTestOverviewHelp")]
        public IActionResult DefaultTestOverviewHelp(
            ) {

            return View(@"Views\Templates\DefaultSearchService\DefaultTestOverviewHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultTestOverview
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  commandName: filter by this key, for no filter use: ''
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
