/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:32:02 PM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of Flight's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFlightService")]
    public partial interface IFlightService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/GetFlight", ReplyAction="http://tempuri.org/IFlightService/GetFlightResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.FlightContract GetFlight(System.Guid flightId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/GetFlight", ReplyAction="http://tempuri.org/IFlightService/GetFlightResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.FlightContract> GetFlightAsync(System.Guid flightId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/UpdateFlight", ReplyAction="http://tempuri.org/IFlightService/UpdateFlightResponse")]
        void UpdateFlight(SolutionNorSolutionPort.BusinessLogicLayer.FlightContract flightContract, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/UpdateFlight", ReplyAction="http://tempuri.org/IFlightService/UpdateFlightResponse")]
        System.Threading.Tasks.Task UpdateFlightAsync(SolutionNorSolutionPort.BusinessLogicLayer.FlightContract flightContract, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/CheckFlightStatuses", ReplyAction="http://tempuri.org/IFlightService/CheckFlightStatusesResponse")]
        void CheckFlightStatuses(System.DateTime dateFrom, System.DateTime dateUntil, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/CheckFlightStatuses", ReplyAction="http://tempuri.org/IFlightService/CheckFlightStatusesResponse")]
        System.Threading.Tasks.Task CheckFlightStatusesAsync(System.DateTime dateFrom, System.DateTime dateUntil, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightServiceChannel : IFlightService, System.ServiceModel.IClientChannel {
    }
    
    public class FlightServiceClient : System.ServiceModel.ClientBase<IFlightService>, IFlightService {
        
        public FlightServiceClient() {
        }
        
        public FlightServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPort.BusinessLogicLayer.FlightContract GetFlight(System.Guid flightId, System.Guid userId) {
            return base.Channel.GetFlight(flightId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.FlightContract> GetFlightAsync(System.Guid flightId, System.Guid userId) {
            return base.Channel.GetFlightAsync(flightId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void UpdateFlight(SolutionNorSolutionPort.BusinessLogicLayer.FlightContract flightContract, System.Guid userId) {
            base.Channel.UpdateFlight(flightContract, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task UpdateFlightAsync(SolutionNorSolutionPort.BusinessLogicLayer.FlightContract flightContract, System.Guid userId) {
            return base.Channel.UpdateFlightAsync(flightContract, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void CheckFlightStatuses(System.DateTime dateFrom, System.DateTime dateUntil, System.Guid userId) {
            base.Channel.CheckFlightStatuses(dateFrom, dateUntil, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task CheckFlightStatusesAsync(System.DateTime dateFrom, System.DateTime dateUntil, System.Guid userId) {
            return base.Channel.CheckFlightStatusesAsync(dateFrom, dateUntil, userId);
        }
    }
}
