/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 1:10:36 PM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAircraftSearchService")]
    public interface IAircraftSearchServiceClient {
        // returns a list of AircraftIdentifierIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftIdentifierIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftIdentifierIndexWithFilterResponse")]
        List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftDocumentIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftDocumentIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftDocumentIndexWithFilterResponse")]
        List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftCompartmentIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftCompartmentIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftCompartmentIndexWithFilterResponse")]
        List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftIndexWithFilterResponse")]
        List<AircraftIndexWithFilterContract> AircraftIndexWithFilter ();
        // returns a list of AircraftDetails contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftDetails", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftDetailsResponse")]
        List<AircraftDetailsContract> AircraftDetails ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAircraftSearchServiceChannel : IAircraftSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class AircraftSearchServiceClient : System.ServiceModel.ClientBase<IAircraftSearchServiceClient>, IAircraftSearchServiceClient {
        // returns a list of AircraftIdentifierIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftIdentifierIndexWithFilter(aircraftId);
        }
        // returns a list of AircraftDocumentIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftDocumentIndexWithFilter(aircraftId);
        }
        // returns a list of AircraftCompartmentIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftCompartmentIndexWithFilter(aircraftId);
        }
        // returns a list of AircraftIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<AircraftIndexWithFilterContract> AircraftIndexWithFilter () {
            return base.Channel.AircraftIndexWithFilter();
        }
        // returns a list of AircraftDetails contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<AircraftDetailsContract> AircraftDetails () {
            return base.Channel.AircraftDetails();
        }
        
        public AircraftSearchServiceClient() {
        }
        
        public AircraftSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AircraftSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AircraftSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AircraftSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
