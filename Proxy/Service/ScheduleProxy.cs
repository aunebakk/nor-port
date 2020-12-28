/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:53:53 PM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of Schedule's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IScheduleService")]
    public partial interface IScheduleService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/MakeFlightsFromScheduleAll", ReplyAction="http://tempuri.org/IScheduleService/MakeFlightsFromScheduleAllResponse")]
        void MakeFlightsFromScheduleAll(System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/MakeFlightsFromScheduleAll", ReplyAction="http://tempuri.org/IScheduleService/MakeFlightsFromScheduleAllResponse")]
        System.Threading.Tasks.Task MakeFlightsFromScheduleAllAsync(System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/MakeFlightsFromSchedule", ReplyAction="http://tempuri.org/IScheduleService/MakeFlightsFromScheduleResponse")]
        void MakeFlightsFromSchedule(System.Guid flightScheduleId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/MakeFlightsFromSchedule", ReplyAction="http://tempuri.org/IScheduleService/MakeFlightsFromScheduleResponse")]
        System.Threading.Tasks.Task MakeFlightsFromScheduleAsync(System.Guid flightScheduleId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedule", ReplyAction="http://tempuri.org/IScheduleService/GetScheduleResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract GetSchedule(System.Guid flightScheduleId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedule", ReplyAction="http://tempuri.org/IScheduleService/GetScheduleResponse")]
        System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract> GetScheduleAsync(System.Guid flightScheduleId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/CreateSchedule", ReplyAction="http://tempuri.org/IScheduleService/CreateScheduleResponse")]
        void CreateSchedule(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/CreateSchedule", ReplyAction="http://tempuri.org/IScheduleService/CreateScheduleResponse")]
        System.Threading.Tasks.Task CreateScheduleAsync(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/UpdateSchedule", ReplyAction="http://tempuri.org/IScheduleService/UpdateScheduleResponse")]
        void UpdateSchedule(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/UpdateSchedule", ReplyAction="http://tempuri.org/IScheduleService/UpdateScheduleResponse")]
        System.Threading.Tasks.Task UpdateScheduleAsync(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScheduleServiceChannel : IScheduleService, System.ServiceModel.IClientChannel {
    }
    
    public class ScheduleServiceClient : System.ServiceModel.ClientBase<IScheduleService>, IScheduleService {
        
        public ScheduleServiceClient() {
        }
        
        public ScheduleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScheduleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void MakeFlightsFromScheduleAll(System.Guid userId) {
            base.Channel.MakeFlightsFromScheduleAll(userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task MakeFlightsFromScheduleAllAsync(System.Guid userId) {
            return base.Channel.MakeFlightsFromScheduleAllAsync(userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void MakeFlightsFromSchedule(System.Guid flightScheduleId, System.Guid userId) {
            base.Channel.MakeFlightsFromSchedule(flightScheduleId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task MakeFlightsFromScheduleAsync(System.Guid flightScheduleId, System.Guid userId) {
            return base.Channel.MakeFlightsFromScheduleAsync(flightScheduleId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract GetSchedule(System.Guid flightScheduleId, System.Guid userId) {
            return base.Channel.GetSchedule(flightScheduleId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract> GetScheduleAsync(System.Guid flightScheduleId, System.Guid userId) {
            return base.Channel.GetScheduleAsync(flightScheduleId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void CreateSchedule(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId) {
            base.Channel.CreateSchedule(scheduleContract, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task CreateScheduleAsync(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId) {
            return base.Channel.CreateScheduleAsync(scheduleContract, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void UpdateSchedule(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId) {
            base.Channel.UpdateSchedule(scheduleContract, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task UpdateScheduleAsync(SolutionNorSolutionPort.BusinessLogicLayer.ScheduleContract scheduleContract, System.Guid userId) {
            return base.Channel.UpdateScheduleAsync(scheduleContract, userId);
        }
    }
}
