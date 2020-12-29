/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:10:56 AM
  From Machine: DESKTOP-517I8BU
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IServiceSearchService")]
    public interface IServiceSearchService {
        // returns a list of GetServicePackage contracts from ServiceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  servicePackageId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSearchService/GetServicePackage", ReplyAction="http://tempuri.org/IServiceSearchService/GetServicePackageResponse")]
        List<GetServicePackageContract> GetServicePackage (System.Guid servicePackageId);
        // returns a list of FetchServiceSpecialServiceRequestWithFilter contracts from ServiceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  serviceSpecialServiceRequestGroupRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  serviceSpecialServiceRequestCode: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  requestServiceSpecialServiceRequestRequirementRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  replyServiceSpecialServiceRequestRequirementRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  serviceSpecialServiceRequestOperationRuleRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSearchService/FetchServiceSpecialServiceRequestWithFilter", ReplyAction="http://tempuri.org/IServiceSearchService/FetchServiceSpecialServiceRequestWithFilterResponse")]
        List<FetchServiceSpecialServiceRequestWithFilterContract> FetchServiceSpecialServiceRequestWithFilter (System.String serviceSpecialServiceRequestGroupRcd,System.String serviceSpecialServiceRequestCode,System.String requestServiceSpecialServiceRequestRequirementRcd,System.String replyServiceSpecialServiceRequestRequirementRcd,System.String serviceSpecialServiceRequestOperationRuleRcd);
        // returns a list of ServicePackagePromotionWithFilter contracts from ServiceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  clientId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSearchService/ServicePackagePromotionWithFilter", ReplyAction="http://tempuri.org/IServiceSearchService/ServicePackagePromotionWithFilterResponse")]
        List<ServicePackagePromotionWithFilterContract> ServicePackagePromotionWithFilter (System.Guid clientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSearchServiceChannel : IServiceSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ServiceSearchService : System.ServiceModel.ClientBase<IServiceSearchService>, IServiceSearchService {
        // returns a list of GetServicePackage contracts from ServiceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  servicePackageId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<GetServicePackageContract> GetServicePackage (System.Guid servicePackageId) {
            return base.Channel.GetServicePackage(servicePackageId);
        }
        // returns a list of FetchServiceSpecialServiceRequestWithFilter contracts from ServiceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  serviceSpecialServiceRequestGroupRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  serviceSpecialServiceRequestCode: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  requestServiceSpecialServiceRequestRequirementRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  replyServiceSpecialServiceRequestRequirementRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  serviceSpecialServiceRequestOperationRuleRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FetchServiceSpecialServiceRequestWithFilterContract> FetchServiceSpecialServiceRequestWithFilter (System.String serviceSpecialServiceRequestGroupRcd,System.String serviceSpecialServiceRequestCode,System.String requestServiceSpecialServiceRequestRequirementRcd,System.String replyServiceSpecialServiceRequestRequirementRcd,System.String serviceSpecialServiceRequestOperationRuleRcd) {
            return base.Channel.FetchServiceSpecialServiceRequestWithFilter(serviceSpecialServiceRequestGroupRcd, serviceSpecialServiceRequestCode, requestServiceSpecialServiceRequestRequirementRcd, replyServiceSpecialServiceRequestRequirementRcd, serviceSpecialServiceRequestOperationRuleRcd);
        }
        // returns a list of ServicePackagePromotionWithFilter contracts from ServiceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  clientId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
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
