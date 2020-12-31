/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:47:37 AM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultTestSearchService")]
    public interface IDefaultTestSearchService {
        // returns a list of DefaultTestSearchQuery contracts from DefaultTestSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultTestSearchService/DefaultTestSearchQuery", ReplyAction="http://tempuri.org/IDefaultTestSearchService/DefaultTestSearchQueryResponse")]
        List<DefaultTestSearchQueryContract> DefaultTestSearchQuery ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultTestSearchServiceChannel : IDefaultTestSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultTestSearchService : System.ServiceModel.ClientBase<IDefaultTestSearchService>, IDefaultTestSearchService {
        // returns a list of DefaultTestSearchQuery contracts from DefaultTestSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<DefaultTestSearchQueryContract> DefaultTestSearchQuery () {
            return base.Channel.DefaultTestSearchQuery();
        }
        
        public DefaultTestSearchService() {
        }
        
        public DefaultTestSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultTestSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultTestSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultTestSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
