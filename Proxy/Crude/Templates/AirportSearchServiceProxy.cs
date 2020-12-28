/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:52:00 AM
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
    public class AirportSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilter(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AirportSearchService/AirportIdentifierIndexWithFilter?";
            string jsonString = client.DownloadString(query);

            List<AirportIdentifierIndexWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<AirportIdentifierIndexWithFilterContract>>(jsonString);

            return reply;
        }

        public List<GetAirportIndexWithFilterContract> GetAirportIndexWithFilter(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/AirportSearchService/GetAirportIndexWithFilter?";
            string jsonString = client.DownloadString(query);

            List<GetAirportIndexWithFilterContract> reply =
                JsonConvert.DeserializeObject<List<GetAirportIndexWithFilterContract>>(jsonString);

            return reply;
        }

    }
}
