/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:43:59 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// business namespace for proxy
// links:
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
