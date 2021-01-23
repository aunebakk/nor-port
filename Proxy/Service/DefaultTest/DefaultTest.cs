/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:57:19 PM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultTestService")]
    public partial interface IDefaultTestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/DefaultTestCompleteGet", ReplyAction="http://tempuri.org/IDefaultTestService/DefaultTestCompleteGetResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.DefaultTestContract DefaultTestCompleteGet(System.Guid defaultTestId, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/DefaultTestCompleteUpdate", ReplyAction="http://tempuri.org/IDefaultTestService/DefaultTestCompleteUpdateResponse")]
        System.Guid DefaultTestCompleteUpdate(System.Guid defaultTestId, SolutionNorSolutionPort.BusinessLogicLayer.DefaultTestContract testContract, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/RunAllTests", ReplyAction="http://tempuri.org/IDefaultTestService/RunAllTestsResponse")]
        void RunAllTests(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestService/AddTestRun", ReplyAction="http://tempuri.org/IDefaultTestService/AddTestRunResponse")]
        System.Guid AddTestRun(string systemName, string testArea, string testSubArea, string testAddress, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, string defaultTestRunResultRcd, string result, System.Guid userId);
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
        
        public SolutionNorSolutionPort.BusinessLogicLayer.DefaultTestContract DefaultTestCompleteGet(System.Guid defaultTestId, System.Guid userId) {
            return base.Channel.DefaultTestCompleteGet(defaultTestId, userId);
        }
        
        public System.Guid DefaultTestCompleteUpdate(System.Guid defaultTestId, SolutionNorSolutionPort.BusinessLogicLayer.DefaultTestContract testContract, System.Guid userId) {
            return base.Channel.DefaultTestCompleteUpdate(defaultTestId, testContract, userId);
        }
        
        public void RunAllTests(System.Guid userId) {
            base.Channel.RunAllTests(userId);
        }
        
        public System.Guid AddTestRun(string systemName, string testArea, string testSubArea, string testAddress, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, string defaultTestRunResultRcd, string result, System.Guid userId) {
            return base.Channel.AddTestRun(systemName, testArea, testSubArea, testAddress, startDateTime, endDateTime, elapsedMilliseconds, defaultTestRunResultRcd, result, userId);
        }
    }
}
