/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 7:10:01 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// Namespace for a Business Logic Layer in a Proxy
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class AircraftSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter(
            System.Guid aircraftId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AircraftSearchService/AircraftIdentifierIndexWithFilter?aircraftId={aircraftId}";
            string jsonString = client.DownloadString(query);

            List<AircraftIdentifierIndexWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<AircraftIdentifierIndexWithFilterContract>>(jsonString);

            return reply;
        }

        public List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter(
            System.Guid aircraftId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AircraftSearchService/AircraftDocumentIndexWithFilter?aircraftId={aircraftId}";
            string jsonString = client.DownloadString(query);

            List<AircraftDocumentIndexWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<AircraftDocumentIndexWithFilterContract>>(jsonString);

            return reply;
        }

        public List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter(
            System.Guid aircraftId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AircraftSearchService/AircraftCompartmentIndexWithFilter?aircraftId={aircraftId}";
            string jsonString = client.DownloadString(query);

            List<AircraftCompartmentIndexWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<AircraftCompartmentIndexWithFilterContract>>(jsonString);

            return reply;
        }

        public List<AircraftIndexWithFilterContract> AircraftIndexWithFilter(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AircraftSearchService/AircraftIndexWithFilter?";
            string jsonString = client.DownloadString(query);

            List<AircraftIndexWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<AircraftIndexWithFilterContract>>(jsonString);

            return reply;
        }

        public List<AircraftDetailsContract> AircraftDetails(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AircraftSearchService/AircraftDetails?";
            string jsonString = client.DownloadString(query);

            List<AircraftDetailsContract> reply =
                JsonConvert.DeserializeObject<List<AircraftDetailsContract>>(jsonString);

            return reply;
        }

    }
}
