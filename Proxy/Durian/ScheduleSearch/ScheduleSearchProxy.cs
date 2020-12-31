/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:50:06 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IScheduleSearchService")]
    public interface IScheduleSearchService {
        // returns a list of FlightSegmentsSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleSearchService/FlightSegmentsSchedule", ReplyAction="http://tempuri.org/IScheduleSearchService/FlightSegmentsScheduleResponse")]
        List<FlightSegmentsScheduleContract> FlightSegmentsSchedule (System.Guid flightScheduleId);
        // returns a list of FlightScheduleHistory contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleSearchService/FlightScheduleHistory", ReplyAction="http://tempuri.org/IScheduleSearchService/FlightScheduleHistoryResponse")]
        List<FlightScheduleHistoryContract> FlightScheduleHistory (System.Guid flightScheduleId);
        // returns a list of FlightSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleSearchService/FlightSchedule", ReplyAction="http://tempuri.org/IScheduleSearchService/FlightScheduleResponse")]
        List<FlightScheduleContract> FlightSchedule ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScheduleSearchServiceChannel : IScheduleSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ScheduleSearchService : System.ServiceModel.ClientBase<IScheduleSearchService>, IScheduleSearchService {
        // returns a list of FlightSegmentsSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightSegmentsScheduleContract> FlightSegmentsSchedule (System.Guid flightScheduleId) {
            return base.Channel.FlightSegmentsSchedule(flightScheduleId);
        }
        // returns a list of FlightScheduleHistory contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightScheduleId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightScheduleHistoryContract> FlightScheduleHistory (System.Guid flightScheduleId) {
            return base.Channel.FlightScheduleHistory(flightScheduleId);
        }
        // returns a list of FlightSchedule contracts from ScheduleSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
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
