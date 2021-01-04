/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 4:59:04 PM
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
    //  docLink: http://sql2x.org/documentationLink/179373dc-6fcc-4fc3-a7aa-e57c35d4d1d4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IServiceSearchService")]
    public interface IServiceSearchServiceClient {
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
    public interface IServiceSearchServiceChannel : IServiceSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class ServiceSearchServiceClient : System.ServiceModel.ClientBase<IServiceSearchServiceClient>, IServiceSearchServiceClient {
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
        
        public ServiceSearchServiceClient() {
        }
        
        public ServiceSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
