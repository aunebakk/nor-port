/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:55:40 AM
  Template: SQL2XExtensionV3.SQL2XExtensionCreatorCoreV3.ProxyClient
*/
using System;
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of DefaultTest's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
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
