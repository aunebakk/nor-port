/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:43:03 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultSearchService")]
    public interface IDefaultSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultResourceDatabaseStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultResourceDatabaseStatisticsResponse")]
        List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultResourceStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultResourceStatisticsResponse")]
        List<DefaultResourceStatisticsContract> DefaultResourceStatistics ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/GetDefaultChangeLog", ReplyAction="http://tempuri.org/IDefaultSearchService/GetDefaultChangeLogResponse")]
        List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserListForDashboard", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserListForDashboardResponse")]
        List<DefaultUserListForDashboardContract> DefaultUserListForDashboard ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserList", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserListResponse")]
        List<DefaultUserListContract> DefaultUserList ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedByAddress", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedByAddressResponse")]
        List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGrouped", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedResponse")]
        List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityOnAddress", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityOnAddressResponse")]
        List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityRecent", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityRecentResponse")]
        List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimeCommands", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimeCommandsResponse")]
        List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimes", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimesResponse")]
        List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatisticsTop5", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsTop5Response")]
        List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatisticsByMonth", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsByMonthResponse")]
        List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityByHour", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityByHourResponse")]
        List<DefaultUserActivityByHourContract> DefaultUserActivityByHour ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsResponse")]
        List<DefaultStatisticsContract> DefaultStatistics ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIndicators", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIndicatorsResponse")]
        List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultErrorOverview", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultErrorOverviewResponse")]
        List<DefaultErrorOverviewContract> DefaultErrorOverview ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultIssueWithFilter", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultIssueWithFilterResponse")]
        List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIssueFetchWithFilter", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIssueFetchWithFilterResponse")]
        List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DashboardCounts", ReplyAction="http://tempuri.org/IDefaultSearchService/DashboardCountsResponse")]
        List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultTestOverview", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultTestOverviewResponse")]
        List<DefaultTestOverviewContract> DefaultTestOverview (System.String commandName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultSearchServiceChannel : IDefaultSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultSearchService : System.ServiceModel.ClientBase<IDefaultSearchService>, IDefaultSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics () {
            return base.Channel.DefaultResourceDatabaseStatistics();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics () {
            return base.Channel.DefaultResourceStatistics();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {
            return base.Channel.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard () {
            return base.Channel.DefaultUserListForDashboard();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserListContract> DefaultUserList () {
            return base.Channel.DefaultUserList();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress () {
            return base.Channel.DefaultUserActivityGroupedByAddress();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped () {
            return base.Channel.DefaultUserActivityGrouped();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress) {
            return base.Channel.DefaultUserActivityOnAddress(originatingAddress);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId) {
            return base.Channel.DefaultUserActivityRecent(defaultUserId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands () {
            return base.Channel.DefaultPerformanceTimeCommands();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName) {
            return base.Channel.DefaultPerformanceTimes(commandName);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 () {
            return base.Channel.DefaultStatisticsTop5();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth () {
            return base.Channel.DefaultStatisticsByMonth();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour () {
            return base.Channel.DefaultUserActivityByHour();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultStatisticsContract> DefaultStatistics () {
            return base.Channel.DefaultStatistics();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators () {
            return base.Channel.DefaultPerformanceIndicators();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultErrorOverviewContract> DefaultErrorOverview () {
            return base.Channel.DefaultErrorOverview();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd) {
            return base.Channel.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName) {
            return base.Channel.DefaultPerformanceIssueFetchWithFilter(commandName);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd) {
            return base.Channel.DashboardCounts(dashboardLayoutRcd);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<DefaultTestOverviewContract> DefaultTestOverview (System.String commandName) {
            return base.Channel.DefaultTestOverview(commandName);
        }
        
        public DefaultSearchService() {
        }
        
        public DefaultSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
