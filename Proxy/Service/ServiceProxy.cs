﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:53:58 PM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of Service's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IServiceService")]
    public partial interface IServiceService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceService/PromotionSend", ReplyAction="http://tempuri.org/IServiceService/PromotionSendResponse")]
        void PromotionSend(System.Guid servicePackagePromotionId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceService/PromotionSend", ReplyAction="http://tempuri.org/IServiceService/PromotionSendResponse")]
        System.Threading.Tasks.Task PromotionSendAsync(System.Guid servicePackagePromotionId, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceService/PromotionMakeBooking", ReplyAction="http://tempuri.org/IServiceService/PromotionMakeBookingResponse")]
        void PromotionMakeBooking(System.Guid servicePackagePromotionId, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceService/PromotionMakeBooking", ReplyAction="http://tempuri.org/IServiceService/PromotionMakeBookingResponse")]
        System.Threading.Tasks.Task PromotionMakeBookingAsync(System.Guid servicePackagePromotionId, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceServiceChannel : IServiceService, System.ServiceModel.IClientChannel {
    }
    
    public class ServiceServiceClient : System.ServiceModel.ClientBase<IServiceService>, IServiceService {
        
        public ServiceServiceClient() {
        }
        
        public ServiceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PromotionSend(System.Guid servicePackagePromotionId, System.Guid userId) {
            base.Channel.PromotionSend(servicePackagePromotionId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PromotionSendAsync(System.Guid servicePackagePromotionId, System.Guid userId) {
            return base.Channel.PromotionSendAsync(servicePackagePromotionId, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void PromotionMakeBooking(System.Guid servicePackagePromotionId, System.Guid userId) {
            base.Channel.PromotionMakeBooking(servicePackagePromotionId, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task PromotionMakeBookingAsync(System.Guid servicePackagePromotionId, System.Guid userId) {
            return base.Channel.PromotionMakeBookingAsync(servicePackagePromotionId, userId);
        }
    }
}