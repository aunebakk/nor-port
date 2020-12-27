/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 7:18:52 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IClientSearchService")]
    public interface IClientSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientSearchService/GetClientWithFilter", ReplyAction="http://tempuri.org/IClientSearchService/GetClientWithFilterResponse")]
        List<GetClientWithFilterContract> GetClientWithFilter (System.String lastName,System.String clientTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientSearchServiceChannel : IClientSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ClientSearchService : System.ServiceModel.ClientBase<IClientSearchService>, IClientSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<GetClientWithFilterContract> GetClientWithFilter (System.String lastName,System.String clientTypeRcd) {
            return base.Channel.GetClientWithFilter(lastName, clientTypeRcd);
        }
        
        public ClientSearchService() {
        }
        
        public ClientSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
