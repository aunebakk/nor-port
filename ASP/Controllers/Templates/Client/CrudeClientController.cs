/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:05:53 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateDotNetCoreApiGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
// Namespace for a Business Logic Layer in a Controller using ModelViewController
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// Namespace for a Business Logic Layer in a Controller using ModelViewController
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/crudeclient")]
    // this class serves as Controller to the data access layer between c# and sql server
    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeClientController : Controller {

        // help page for controller
        // help page for controller
        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeClientHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClient.cshtml");
        }

        // fetch all page for controller
        // fetch all page for controller
        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAll() {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAll();

            return clients;
        }

        // fetch all count page for controller
        // fetch all count page for controller
        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeClientFetchAllCount() {

            return new CrudeClientBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // fetch all with limit page for controller
        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAllWithLimit(limit);

            return clients;
        }

        // fetch all with limit and offset page for controller
        // fetch all with limit and offset page for controller
        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        // parameters:
        //  limit: only return this number of rows
        //   offset: start from this offset of rows
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clients;
        }

        // fetch by primary key page for controller
        // fetch by primary key page for controller
        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  clientid: filter by primary key
        [HttpGet("fetchbyclientid/{clientid?}")]
        public CrudeClientModel CrudeClientFetchByClientId(System.Guid clientid) {

            CrudeClientModel client = 
                new CrudeClientBusiness().FetchByClientId(clientid);

            return client;
        }

        // fetch by foreign key (simple) page for controller
        // fetch by foreign key (simple) page for controller
        // fetch by foreign key (simple) page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/82335188-ebea-40e3-a07d-094026340e92
        [HttpGet("fetchbyfirstname/{firstname?}")]
        public CrudeClientModel CrudeClientFetchByFirstName(System.String firstname) {

            CrudeClientModel client = 
                new CrudeClientBusiness().FetchByFirstName(firstname);

            return client;
        }

        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  addressid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyaddressid/{addressid?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByAddressId(System.Guid addressid) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByAddressId(addressid);

            return client;
        }

        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  passengertypercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbypassengertypercd/{passengertypercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByPassengerTypeRcd(System.String passengertypercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByPassengerTypeRcd(passengertypercd);

            return client;
        }

        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  nationalityrcd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbynationalityrcd/{nationalityrcd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByNationalityRcd(System.String nationalityrcd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByNationalityRcd(nationalityrcd);

            return client;
        }

        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  genderrcd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbygenderrcd/{genderrcd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByGenderRcd(System.String genderrcd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByGenderRcd(genderrcd);

            return client;
        }

        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  titlercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbytitlercd/{titlercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByTitleRcd(System.String titlercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByTitleRcd(titlercd);

            return client;
        }

        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  clienttypercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyclienttypercd/{clienttypercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientTypeRcd(System.String clienttypercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientTypeRcd(clienttypercd);

            return client;
        }

        // create Client POST page for controller
        // create Client POST page for controller
        // create Client POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeClientModel: contract to add
        [HttpPost("crudeclientcreate")]
        public CrudeClientModel CrudeClientCreate([Bind()] CrudeClientModel client) {

            new CrudeClientBusiness().Insert(client);

            return client;
        }

        // create POST test page for controller
        // create POST test page for controller
        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeClientCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FirstName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MiddleName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LastName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "PassengerTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "NationalityRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "GenderRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TitleRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/30/2020 9:05:53 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeClient/CrudeClientCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeClient/CrudeClientCreate/", content).Result;

                // read/return reply
                if ( response.IsSuccessStatusCode )
                    result = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
                else
                    result = response.ReasonPhrase;
            } catch ( System.Exception ex ) {
                result = "Exception: " + ex.Message;
            }

            return result;
        }

        // Update Client POST page for controller
        // Update Client POST page for controller
        // Update Client POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeClientModel: contract to add
        [HttpPut("crudeclientupdate")]
        public CrudeClientModel CrudeClientUpdate([Bind()] CrudeClientModel client) {

            new CrudeClientBusiness().Update(client);

            return client;
        }

        // update test page for controller
        // update test page for controller
        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeClientUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FirstName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MiddleName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LastName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "PassengerTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "NationalityRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "GenderRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TitleRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/30/2020 9:05:53 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeClient/CrudeClientUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeClient/CrudeClientUpdate/", content).Result;

                // read/return reply
                if ( response.IsSuccessStatusCode )
                    result = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
                else
                    result = response.ReasonPhrase;
            } catch ( System.Exception ex ) {
                result = "Exception: " + ex.Message;
            }

            return result;
        }

        // DELETE page for controller
        // DELETE page for controller
        // DELETE page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/c5cd4292-e198-4631-9b3f-a67451a48cac
        [HttpDelete("clientdelete/{clientid?}")]
        public void CrudeClientDelete(System.Guid clientId) {

            new CrudeClientBusiness().Delete(clientId);
        }

        // delete test page for controller
        // delete test page for controller
        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeClientDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeClient/CrudeClientDelete/00000000-0000-0000-0000-000000000001" ).Result;

                // read/return reply
                if ( response.IsSuccessStatusCode )
                    result = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
                else
                    result = response.ReasonPhrase;
            } catch ( System.Exception ex ) {
                result = "Exception: " + ex.Message;
            }

            return result;
        }

    }
}
