/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 7:10:18 AM
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
    public class FlightServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public FlightContract GetFlight(
            System.Guid flightId,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightService/GetFlight?flightId={flightId}&userId={userId}";
            string jsonString = client.DownloadString(query);

            FlightContract reply =
                JsonConvert.DeserializeObject<FlightContract>(jsonString);

            return reply;
        }

        public void UpdateFlight(
            FlightContract flightContract,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightService/UpdateFlight?flightContract={flightContract}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

        public void CheckFlightStatuses(
            System.DateTime dateFrom,
            System.DateTime dateUntil,
            System.Guid userId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FlightService/CheckFlightStatuses?dateFrom={dateFrom}&dateUntil={dateUntil}&userId={userId}";
            string jsonString = client.DownloadString(query);

        }

    }
}
