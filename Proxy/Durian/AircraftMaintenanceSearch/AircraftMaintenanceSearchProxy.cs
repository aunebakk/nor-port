/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 2:26:12 PM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAircraftMaintenanceSearchService")]
    public interface IAircraftMaintenanceSearchServiceClient {
        // returns a list of AircraftPIMDetails contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftPIMDetails", ReplyAction="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftPIMDetailsResponse")]
        List<AircraftPIMDetailsContract> AircraftPIMDetails ();
        // returns a list of AircraftMaintenanceIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceIndexWithFilterResponse")]
        List<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilter ();
        // returns a list of AircraftMaintenanceCompartmentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceCompartmentIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceCompartmentIndexWithFilterResponse")]
        List<AircraftMaintenanceCompartmentIndexWithFilterContract> AircraftMaintenanceCompartmentIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftMaintenanceIdentifierIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceIdentifierIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceIdentifierIndexWithFilterResponse")]
        List<AircraftMaintenanceIdentifierIndexWithFilterContract> AircraftMaintenanceIdentifierIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftMaintenanceDocumentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceDocumentIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftMaintenanceSearchService/AircraftMaintenanceDocumentIndexWithFilterResponse")]
        List<AircraftMaintenanceDocumentIndexWithFilterContract> AircraftMaintenanceDocumentIndexWithFilter (System.Guid aircraftId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAircraftMaintenanceSearchServiceChannel : IAircraftMaintenanceSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class AircraftMaintenanceSearchServiceClient : System.ServiceModel.ClientBase<IAircraftMaintenanceSearchServiceClient>, IAircraftMaintenanceSearchServiceClient {
        // returns a list of AircraftPIMDetails contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<AircraftPIMDetailsContract> AircraftPIMDetails () {
            return base.Channel.AircraftPIMDetails();
        }
        // returns a list of AircraftMaintenanceIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilter () {
            return base.Channel.AircraftMaintenanceIndexWithFilter();
        }
        // returns a list of AircraftMaintenanceCompartmentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftMaintenanceCompartmentIndexWithFilterContract> AircraftMaintenanceCompartmentIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftMaintenanceCompartmentIndexWithFilter(aircraftId);
        }
        // returns a list of AircraftMaintenanceIdentifierIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftMaintenanceIdentifierIndexWithFilterContract> AircraftMaintenanceIdentifierIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftMaintenanceIdentifierIndexWithFilter(aircraftId);
        }
        // returns a list of AircraftMaintenanceDocumentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftMaintenanceDocumentIndexWithFilterContract> AircraftMaintenanceDocumentIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftMaintenanceDocumentIndexWithFilter(aircraftId);
        }
        
        public AircraftMaintenanceSearchServiceClient() {
        }
        
        public AircraftMaintenanceSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AircraftMaintenanceSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AircraftMaintenanceSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AircraftMaintenanceSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
