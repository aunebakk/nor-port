/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 7:01:46 AM
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAirportSearchService")]
    public interface IAirportSearchService {
        // returns a list of AirportIdentifierIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirportSearchService/AirportIdentifierIndexWithFilter", ReplyAction="http://tempuri.org/IAirportSearchService/AirportIdentifierIndexWithFilterResponse")]
        List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter ();
        // returns a list of GetAirportIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirportSearchService/GetAirportIndexWithFilter", ReplyAction="http://tempuri.org/IAirportSearchService/GetAirportIndexWithFilterResponse")]
        List<GetAirportIndexWithFilterContract> GetAirportIndexWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAirportSearchServiceChannel : IAirportSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class AirportSearchService : System.ServiceModel.ClientBase<IAirportSearchService>, IAirportSearchService {
        // returns a list of AirportIdentifierIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter () {
            return base.Channel.AirportIdentifierIndexWithFilter();
        }
        // returns a list of GetAirportIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<GetAirportIndexWithFilterContract> GetAirportIndexWithFilter () {
            return base.Channel.GetAirportIndexWithFilter();
        }
        
        public AirportSearchService() {
        }
        
        public AirportSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AirportSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirportSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirportSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
