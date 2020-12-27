/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 7:23:11 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IScheduleSearchService")]
    public interface IScheduleSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleSearchService/FlightSegmentsSchedule", ReplyAction="http://tempuri.org/IScheduleSearchService/FlightSegmentsScheduleResponse")]
        List<FlightSegmentsScheduleContract> FlightSegmentsSchedule (System.Guid flightScheduleId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleSearchService/FlightScheduleHistory", ReplyAction="http://tempuri.org/IScheduleSearchService/FlightScheduleHistoryResponse")]
        List<FlightScheduleHistoryContract> FlightScheduleHistory (System.Guid flightScheduleId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleSearchService/FlightSchedule", ReplyAction="http://tempuri.org/IScheduleSearchService/FlightScheduleResponse")]
        List<FlightScheduleContract> FlightSchedule ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScheduleSearchServiceChannel : IScheduleSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ScheduleSearchService : System.ServiceModel.ClientBase<IScheduleSearchService>, IScheduleSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightSegmentsScheduleContract> FlightSegmentsSchedule (System.Guid flightScheduleId) {
            return base.Channel.FlightSegmentsSchedule(flightScheduleId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightScheduleHistoryContract> FlightScheduleHistory (System.Guid flightScheduleId) {
            return base.Channel.FlightScheduleHistory(flightScheduleId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightScheduleContract> FlightSchedule () {
            return base.Channel.FlightSchedule();
        }
        
        public ScheduleSearchService() {
        }
        
        public ScheduleSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScheduleSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
