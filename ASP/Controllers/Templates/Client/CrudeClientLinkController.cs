﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:17:38 AM
  From Machine: DESKTOP-BP3OHLH
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
    [Route("api/1/crudeclientlink")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeClientLinkController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeClientLinkHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientLink.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchAll() {

            List<CrudeClientLinkModel> clientLinks = 
                new CrudeClientLinkBusiness().FetchAll();

            return clientLinks;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeClientLinkFetchAllCount() {

            return new CrudeClientLinkBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientLinkModel> clientLinks = 
                new CrudeClientLinkBusiness().FetchAllWithLimit(limit);

            return clientLinks;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientLinkModel> clientLinks = 
                new CrudeClientLinkBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientLinks;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyclientlinkid/{clientlinkid?}")]
        public CrudeClientLinkModel CrudeClientLinkFetchByClientLinkId(System.Guid clientlinkid) {

            CrudeClientLinkModel clientLink = 
                new CrudeClientLinkBusiness().FetchByClientLinkId(clientlinkid);

            return clientLink;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchByClientId(System.Guid clientid) {

            List<CrudeClientLinkModel> clientLink = 
                new CrudeClientLinkBusiness().FetchByClientId(clientid);

            return clientLink;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbylinktypercd/{linktypercd?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchByLinkTypeRcd(System.String linktypercd) {

            List<CrudeClientLinkModel> clientLink = 
                new CrudeClientLinkBusiness().FetchByLinkTypeRcd(linktypercd);

            return clientLink;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudeclientlinkcreate")]
        public CrudeClientLinkModel CrudeClientLinkCreate([Bind()] CrudeClientLinkModel clientLink) {

            new CrudeClientLinkBusiness().Insert(clientLink);

            return clientLink;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeClientLinkCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LinkTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Link" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 12:17:38 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientLink/CrudeClientLinkCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeClientLink/CrudeClientLinkCreate/", content).Result;

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
        [HttpPut("crudeclientlinkupdate")]
        public CrudeClientLinkModel CrudeClientLinkUpdate([Bind()] CrudeClientLinkModel clientLink) {

            new CrudeClientLinkBusiness().Update(clientLink);

            return clientLink;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeClientLinkUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LinkTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Link" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 12:17:38 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientLink/CrudeClientLinkUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeClientLink/CrudeClientLinkUpdate/", content).Result;

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
        [HttpDelete("clientlinkdelete/{clientlinkid?}")]
        public void CrudeClientLinkDelete(System.Guid clientLinkId) {

            new CrudeClientLinkBusiness().Delete(clientLinkId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeClientLinkDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientLink/CrudeClientLinkDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
