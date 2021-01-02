/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 4:49:59 PM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAirlineSearchService")]
    public interface IAirlineSearchServiceClient {
        // returns a list of AirlineIdentifierIndexWithFilter contracts from AirlineSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirlineSearchService/AirlineIdentifierIndexWithFilter", ReplyAction="http://tempuri.org/IAirlineSearchService/AirlineIdentifierIndexWithFilterResponse")]
        List<AirlineIdentifierIndexWithFilterContract> AirlineIdentifierIndexWithFilter ();
        // returns a list of GetAirlineIndexWithFilter contracts from AirlineSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirlineSearchService/GetAirlineIndexWithFilter", ReplyAction="http://tempuri.org/IAirlineSearchService/GetAirlineIndexWithFilterResponse")]
        List<GetAirlineIndexWithFilterContract> GetAirlineIndexWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAirlineSearchServiceChannel : IAirlineSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class AirlineSearchServiceClient : System.ServiceModel.ClientBase<IAirlineSearchServiceClient>, IAirlineSearchServiceClient {
        // returns a list of AirlineIdentifierIndexWithFilter contracts from AirlineSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<AirlineIdentifierIndexWithFilterContract> AirlineIdentifierIndexWithFilter () {
            return base.Channel.AirlineIdentifierIndexWithFilter();
        }
        // returns a list of GetAirlineIndexWithFilter contracts from AirlineSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        public List<GetAirlineIndexWithFilterContract> GetAirlineIndexWithFilter () {
            return base.Channel.GetAirlineIndexWithFilter();
        }
        
        public AirlineSearchServiceClient() {
        }
        
        public AirlineSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AirlineSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirlineSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirlineSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
