/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 5:46:49 AM
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IAirportSearchService {
        // returns a list of AirportIdentifierIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter ();
        // returns a list of GetAirportIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<GetAirportIndexWithFilterContract> GetAirportIndexWithFilter ();
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class AirportSearchService : IAirportSearchService {
        // returns a list of AirportIdentifierIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter () {
            // transfer all AirportIdentifierIndexWithFilter serialized objects from AirportSearch as AirportIdentifierIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AirportSearch();
            var businessLogicLayer = new AirportIdentifierIndexWithFilter();
            return businessLogicLayer.AirportIdentifierIndexWithFilterFromDal(dataAccessLayer.AirportIdentifierIndexWithFilter());
        }
        // returns a list of GetAirportIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<GetAirportIndexWithFilterContract> GetAirportIndexWithFilter () {
            // transfer all GetAirportIndexWithFilter serialized objects from AirportSearch as GetAirportIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AirportSearch();
            var businessLogicLayer = new GetAirportIndexWithFilter();
            return businessLogicLayer.GetAirportIndexWithFilterFromDal(dataAccessLayer.GetAirportIndexWithFilter());
        }
    }
}
