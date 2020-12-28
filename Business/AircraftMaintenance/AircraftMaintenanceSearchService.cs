/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:27:41 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IAircraftMaintenanceSearchService {
        // returns a list of AircraftPIMDetails contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<AircraftPIMDetailsContract> AircraftPIMDetails ();
        // returns a list of AircraftMaintenanceIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilter ();
        // returns a list of AircraftMaintenanceCompartmentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  aircraftId: filter by this key
        [OperationContract()]
        List<AircraftMaintenanceCompartmentIndexWithFilterContract> AircraftMaintenanceCompartmentIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftMaintenanceIdentifierIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  aircraftId: filter by this key
        [OperationContract()]
        List<AircraftMaintenanceIdentifierIndexWithFilterContract> AircraftMaintenanceIdentifierIndexWithFilter (System.Guid aircraftId);
        
        // returns a list of AircraftMaintenanceDocumentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  aircraftId: filter by this key
        [OperationContract()]
        List<AircraftMaintenanceDocumentIndexWithFilterContract> AircraftMaintenanceDocumentIndexWithFilter(System.Guid aircraftId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class AircraftMaintenanceSearchService : IAircraftMaintenanceSearchService {
        // returns a list of AircraftPIMDetails contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<AircraftPIMDetailsContract> AircraftPIMDetails () {
            // transfer all AircraftPIMDetails serialized objects from AircraftMaintenanceSearch as AircraftPIMDetails contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftMaintenanceSearch();
            var businessLogicLayer = new AircraftPIMDetails();
            return businessLogicLayer.AircraftPIMDetailsFromDal(dataAccessLayer.AircraftPIMDetails());
        }
        // returns a list of AircraftMaintenanceIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilter () {
            // transfer all AircraftMaintenanceIndexWithFilter serialized objects from AircraftMaintenanceSearch as AircraftMaintenanceIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftMaintenanceSearch();
            var businessLogicLayer = new AircraftMaintenanceIndexWithFilter();
            return businessLogicLayer.AircraftMaintenanceIndexWithFilterFromDal(dataAccessLayer.AircraftMaintenanceIndexWithFilter());
        }
        // returns a list of AircraftMaintenanceCompartmentIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  aircraftId: filter by this key
        public List<AircraftMaintenanceCompartmentIndexWithFilterContract> AircraftMaintenanceCompartmentIndexWithFilter (System.Guid aircraftId) {
            // transfer all AircraftMaintenanceCompartmentIndexWithFilter serialized objects from AircraftMaintenanceSearch as AircraftMaintenanceCompartmentIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftMaintenanceSearch();
            var businessLogicLayer = new AircraftMaintenanceCompartmentIndexWithFilter();
            return businessLogicLayer.AircraftMaintenanceCompartmentIndexWithFilterFromDal(dataAccessLayer.AircraftMaintenanceCompartmentIndexWithFilter(aircraftId));
        }
        // returns a list of AircraftMaintenanceIdentifierIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  aircraftId: filter by this key
        public List<AircraftMaintenanceIdentifierIndexWithFilterContract> AircraftMaintenanceIdentifierIndexWithFilter (System.Guid aircraftId) {
            // transfer all AircraftMaintenanceIdentifierIndexWithFilter serialized objects from AircraftMaintenanceSearch as AircraftMaintenanceIdentifierIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftMaintenanceSearch();
            var businessLogicLayer = new AircraftMaintenanceIdentifierIndexWithFilter();
            return businessLogicLayer.AircraftMaintenanceIdentifierIndexWithFilterFromDal(dataAccessLayer.AircraftMaintenanceIdentifierIndexWithFilter(aircraftId));
        }
        
        // returns a list of AircraftMaintenanceDocumentIndexWithFilter contracts from AircraftMaintenanceSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  aircraftId: filter by this key
        public virtual List<AircraftMaintenanceDocumentIndexWithFilterContract> AircraftMaintenanceDocumentIndexWithFilter(System.Guid aircraftId) {
            // transfer all AircraftMaintenanceDocumentIndexWithFilter serialized objects from AircraftMaintenanceSearch as AircraftMaintenanceDocumentIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftMaintenanceSearch();
            var businessLogicLayer = new AircraftMaintenanceDocumentIndexWithFilter();
            return businessLogicLayer.AircraftMaintenanceDocumentIndexWithFilterFromDal(dataAccessLayer.AircraftMaintenanceDocumentIndexWithFilter(aircraftId));
        }
    }
}
