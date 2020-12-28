/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:03:52 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateDotNetCoreApiGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    // controller namespace for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/38992382-0d4d-420b-ad2d-d57d3a1b6641
    [Produces("application/json")]
    [Route("api/1/crudeclient")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeClientController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeClientHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClient.cshtml");
        }

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
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeClientFetchAllCount() {

            return new CrudeClientBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAllWithLimit(limit);

            return clients;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyclientid/{clientid?}")]
        public CrudeClientModel CrudeClientFetchByClientId(System.Guid clientid) {

            CrudeClientModel client = 
                new CrudeClientBusiness().FetchByClientId(clientid);

            return client;
        }

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
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyaddressid/{addressid?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByAddressId(System.Guid addressid) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByAddressId(addressid);

            return client;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbypassengertypercd/{passengertypercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByPassengerTypeRcd(System.String passengertypercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByPassengerTypeRcd(passengertypercd);

            return client;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbynationalityrcd/{nationalityrcd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByNationalityRcd(System.String nationalityrcd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByNationalityRcd(nationalityrcd);

            return client;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbygenderrcd/{genderrcd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByGenderRcd(System.String genderrcd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByGenderRcd(genderrcd);

            return client;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbytitlercd/{titlercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByTitleRcd(System.String titlercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByTitleRcd(titlercd);

            return client;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyclienttypercd/{clienttypercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientTypeRcd(System.String clienttypercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientTypeRcd(clienttypercd);

            return client;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudeclientcreate")]
        public CrudeClientModel CrudeClientCreate([Bind()] CrudeClientModel client) {

            new CrudeClientBusiness().Insert(client);

            return client;
        }

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
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 5:03:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClient/CrudeClientCreate/", content).Result;
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

        // Update POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        [HttpPut("crudeclientupdate")]
        public CrudeClientModel CrudeClientUpdate([Bind()] CrudeClientModel client) {

            new CrudeClientBusiness().Update(client);

            return client;
        }

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
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 5:03:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClient/CrudeClientUpdate/", content).Result;
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

        // delete page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/c5cd4292-e198-4631-9b3f-a67451a48cac
        [HttpDelete("clientdelete/{clientid?}")]
        public void CrudeClientDelete(System.Guid clientId) {

            new CrudeClientBusiness().Delete(clientId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeClientDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClient/CrudeClientDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
