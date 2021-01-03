/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 2:23:05 PM
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
    public partial interface IAirportSearchService {
        // returns a list of AirportIdentifierIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter ();
        // returns a list of GetAirportIndexWithFilter contracts from AirportSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
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
        public List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter () {
            // transfer all AirportIdentifierIndexWithFilter serialized objects from AirportSearch as AirportIdentifierIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AirportSearch();
            var businessLogicLayer = new AirportIdentifierIndexWithFilter();
            return businessLogicLayer.AirportIdentifierIndexWithFilterFromDal(dataAccessLayer.AirportIdentifierIndexWithFilter());
        }
        // returns a list of GetAirportIndexWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<GetAirportIndexWithFilterContract> GetAirportIndexWithFilter () {
            // transfer all GetAirportIndexWithFilter serialized objects from AirportSearch as GetAirportIndexWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.AirportSearch();
            var businessLogicLayer = new GetAirportIndexWithFilter();
            return businessLogicLayer.GetAirportIndexWithFilterFromDal(dataAccessLayer.GetAirportIndexWithFilter());
        }
    }
}
