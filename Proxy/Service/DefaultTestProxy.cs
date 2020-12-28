/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:48:40 AM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of DefaultTest's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/4067ab7d-fb64-496a-b5d1-0ef69e142b57
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultTestService")]
    public partial interface IDefaultTestService {
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/AddTestRun", ReplyAction="http://tempuri.org/IDefaultTestService/AddTestRunResponse")]
        System.Guid AddTestRun(string systemName, string testArea, string testSubArea, string testAddress, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, string defaultTestRunResultRcd, string result, System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/AddTestRun", ReplyAction="http://tempuri.org/IDefaultTestService/AddTestRunResponse")]
        System.Threading.Tasks.Task<System.Guid> AddTestRunAsync(string systemName, string testArea, string testSubArea, string testAddress, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, string defaultTestRunResultRcd, string result, System.Guid userId);
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/RunAllTests", ReplyAction="http://tempuri.org/IDefaultTestService/RunAllTestsResponse")]
        void RunAllTests(System.Guid userId);
        
        // method derived from SOAP layer, Async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/1cad607d-ab40-465a-bd0b-930736b15402
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/RunAllTests", ReplyAction="http://tempuri.org/IDefaultTestService/RunAllTestsResponse")]
        System.Threading.Tasks.Task RunAllTestsAsync(System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultTestServiceChannel : IDefaultTestService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultTestServiceClient : System.ServiceModel.ClientBase<IDefaultTestService>, IDefaultTestService {
        
        public DefaultTestServiceClient() {
        }
        
        public DefaultTestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultTestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultTestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultTestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public System.Guid AddTestRun(string systemName, string testArea, string testSubArea, string testAddress, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, string defaultTestRunResultRcd, string result, System.Guid userId) {
            return base.Channel.AddTestRun(systemName, testArea, testSubArea, testAddress, startDateTime, endDateTime, elapsedMilliseconds, defaultTestRunResultRcd, result, userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task<System.Guid> AddTestRunAsync(string systemName, string testArea, string testSubArea, string testAddress, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, string defaultTestRunResultRcd, string result, System.Guid userId) {
            return base.Channel.AddTestRunAsync(systemName, testArea, testSubArea, testAddress, startDateTime, endDateTime, elapsedMilliseconds, defaultTestRunResultRcd, result, userId);
        }
        
        // method derived from SOAP layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/2814d348-759d-425b-841e-456ed83f3f20
        public void RunAllTests(System.Guid userId) {
            base.Channel.RunAllTests(userId);
        }
        
        // method derived from SOAP layer, async version
        // links:
        //  docLink: http://sql2x.org/documentationLink/97727d48-326b-4648-9d81-67853713d87f
        public System.Threading.Tasks.Task RunAllTestsAsync(System.Guid userId) {
            return base.Channel.RunAllTestsAsync(userId);
        }
    }
}
