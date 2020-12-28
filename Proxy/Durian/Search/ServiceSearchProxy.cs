/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:47:44 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IServiceSearchService")]
    public interface IServiceSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSearchService/GetServicePackage", ReplyAction="http://tempuri.org/IServiceSearchService/GetServicePackageResponse")]
        List<GetServicePackageContract> GetServicePackage (System.Guid servicePackageId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSearchService/FetchServiceSpecialServiceRequestWithFilter", ReplyAction="http://tempuri.org/IServiceSearchService/FetchServiceSpecialServiceRequestWithFilterResponse")]
        List<FetchServiceSpecialServiceRequestWithFilterContract> FetchServiceSpecialServiceRequestWithFilter (System.String serviceSpecialServiceRequestGroupRcd,System.String serviceSpecialServiceRequestCode,System.String requestServiceSpecialServiceRequestRequirementRcd,System.String replyServiceSpecialServiceRequestRequirementRcd,System.String serviceSpecialServiceRequestOperationRuleRcd);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSearchService/ServicePackagePromotionWithFilter", ReplyAction="http://tempuri.org/IServiceSearchService/ServicePackagePromotionWithFilterResponse")]
        List<ServicePackagePromotionWithFilterContract> ServicePackagePromotionWithFilter (System.Guid clientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSearchServiceChannel : IServiceSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ServiceSearchService : System.ServiceModel.ClientBase<IServiceSearchService>, IServiceSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<GetServicePackageContract> GetServicePackage (System.Guid servicePackageId) {
            return base.Channel.GetServicePackage(servicePackageId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FetchServiceSpecialServiceRequestWithFilterContract> FetchServiceSpecialServiceRequestWithFilter (System.String serviceSpecialServiceRequestGroupRcd,System.String serviceSpecialServiceRequestCode,System.String requestServiceSpecialServiceRequestRequirementRcd,System.String replyServiceSpecialServiceRequestRequirementRcd,System.String serviceSpecialServiceRequestOperationRuleRcd) {
            return base.Channel.FetchServiceSpecialServiceRequestWithFilter(serviceSpecialServiceRequestGroupRcd, serviceSpecialServiceRequestCode, requestServiceSpecialServiceRequestRequirementRcd, replyServiceSpecialServiceRequestRequirementRcd, serviceSpecialServiceRequestOperationRuleRcd);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<ServicePackagePromotionWithFilterContract> ServicePackagePromotionWithFilter (System.Guid clientId) {
            return base.Channel.ServicePackagePromotionWithFilter(clientId);
        }
        
        public ServiceSearchService() {
        }
        
        public ServiceSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
