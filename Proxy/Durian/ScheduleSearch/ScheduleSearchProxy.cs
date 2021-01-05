/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 2:31:59 PM
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
    //  docLink: http://sql2x.org/documentationLink/179373dc-6fcc-4fc3-a7aa-e57c35d4d1d4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IScheduleSearchService")]
    public interface IScheduleSearchServiceClient {
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
    public interface IScheduleSearchServiceChannel : IScheduleSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class ScheduleSearchServiceClient : System.ServiceModel.ClientBase<IScheduleSearchServiceClient>, IScheduleSearchServiceClient {
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
        
        public ScheduleSearchServiceClient() {
        }
        
        public ScheduleSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScheduleSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
