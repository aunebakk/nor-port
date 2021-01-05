/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 1:10:34 PM
  From Machine: DESKTOP-LSRVP12
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/c8b78807-5be0-4da9-89f2-2d7f8dac1c12
    [ServiceContract()]
    public partial interface IAircraftSearchService {
        // returns a list of AircraftIdentifierIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftDocumentIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftCompartmentIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter (System.Guid aircraftId);
        // returns a list of AircraftIndexWithFilter contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<AircraftIndexWithFilterContract> AircraftIndexWithFilter ();
        
        // returns a list of AircraftDetails contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        [OperationContract()]
        List<AircraftDetailsContract> AircraftDetails();
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class AircraftSearchService : IAircraftSearchService {
        // returns a list of AircraftIdentifierIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter (System.Guid aircraftId) {
            // transfer all AircraftIdentifierIndexWithFilter serialized objects from AircraftSearch as AircraftIdentifierIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftSearch();
            var businessLogicLayer = new AircraftIdentifierIndexWithFilter();
            return businessLogicLayer.AircraftIdentifierIndexWithFilterFromDal(dataAccessLayer.AircraftIdentifierIndexWithFilter(aircraftId));
        }
        // returns a list of AircraftDocumentIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter (System.Guid aircraftId) {
            // transfer all AircraftDocumentIndexWithFilter serialized objects from AircraftSearch as AircraftDocumentIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftSearch();
            var businessLogicLayer = new AircraftDocumentIndexWithFilter();
            return businessLogicLayer.AircraftDocumentIndexWithFilterFromDal(dataAccessLayer.AircraftDocumentIndexWithFilter(aircraftId));
        }
        // returns a list of AircraftCompartmentIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  aircraftId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter (System.Guid aircraftId) {
            // transfer all AircraftCompartmentIndexWithFilter serialized objects from AircraftSearch as AircraftCompartmentIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftSearch();
            var businessLogicLayer = new AircraftCompartmentIndexWithFilter();
            return businessLogicLayer.AircraftCompartmentIndexWithFilterFromDal(dataAccessLayer.AircraftCompartmentIndexWithFilter(aircraftId));
        }
        // returns a list of AircraftIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<AircraftIndexWithFilterContract> AircraftIndexWithFilter () {
            // transfer all AircraftIndexWithFilter serialized objects from AircraftSearch as AircraftIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftSearch();
            var businessLogicLayer = new AircraftIndexWithFilter();
            return businessLogicLayer.AircraftIndexWithFilterFromDal(dataAccessLayer.AircraftIndexWithFilter());
        }
        
        // returns a list of AircraftDetails contracts from AircraftSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        public virtual List<AircraftDetailsContract> AircraftDetails() {
            // transfer all AircraftDetails serialized objects from AircraftSearch as AircraftDetails contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AircraftSearch();
            var businessLogicLayer = new AircraftDetails();
            return businessLogicLayer.AircraftDetailsFromDal(dataAccessLayer.AircraftDetails());
        }
    }
}
