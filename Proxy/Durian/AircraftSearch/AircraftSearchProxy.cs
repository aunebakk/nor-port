/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:41:05 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAircraftSearchService")]
    public interface IAircraftSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftIdentifierIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftIdentifierIndexWithFilterResponse")]
        List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter (System.Guid aircraftId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftDocumentIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftDocumentIndexWithFilterResponse")]
        List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter (System.Guid aircraftId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftCompartmentIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftCompartmentIndexWithFilterResponse")]
        List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter (System.Guid aircraftId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftIndexWithFilter", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftIndexWithFilterResponse")]
        List<AircraftIndexWithFilterContract> AircraftIndexWithFilter ();
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAircraftSearchService/AircraftDetails", ReplyAction="http://tempuri.org/IAircraftSearchService/AircraftDetailsResponse")]
        List<AircraftDetailsContract> AircraftDetails ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAircraftSearchServiceChannel : IAircraftSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class AircraftSearchService : System.ServiceModel.ClientBase<IAircraftSearchService>, IAircraftSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftIdentifierIndexWithFilter(aircraftId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftDocumentIndexWithFilter(aircraftId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter (System.Guid aircraftId) {
            return base.Channel.AircraftCompartmentIndexWithFilter(aircraftId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<AircraftIndexWithFilterContract> AircraftIndexWithFilter () {
            return base.Channel.AircraftIndexWithFilter();
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<AircraftDetailsContract> AircraftDetails () {
            return base.Channel.AircraftDetails();
        }
        
        public AircraftSearchService() {
        }
        
        public AircraftSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AircraftSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AircraftSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AircraftSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
