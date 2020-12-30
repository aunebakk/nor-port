/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:07:14 PM
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
    [Route("api/1/crudedefaultperformancetimerollup")]
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
    public class CrudeDefaultPerformanceTimeRollupController : Controller {

        // help page for controller
        // help page for controller
        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeDefaultPerformanceTimeRollupHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultPerformanceTimeRollup.cshtml");
        }

        // fetch all page for controller
        // fetch all page for controller
        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultPerformanceTimeRollupModel> CrudeDefaultPerformanceTimeRollupFetchAll() {

            List<CrudeDefaultPerformanceTimeRollupModel> defaultPerformanceTimeRollups = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchAll();

            return defaultPerformanceTimeRollups;
        }

        // fetch all count page for controller
        // fetch all count page for controller
        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeDefaultPerformanceTimeRollupFetchAllCount() {

            return new CrudeDefaultPerformanceTimeRollupBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // fetch all with limit page for controller
        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultPerformanceTimeRollupModel> CrudeDefaultPerformanceTimeRollupFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultPerformanceTimeRollupModel> defaultPerformanceTimeRollups = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchAllWithLimit(limit);

            return defaultPerformanceTimeRollups;
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
        public IEnumerable<CrudeDefaultPerformanceTimeRollupModel> CrudeDefaultPerformanceTimeRollupFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultPerformanceTimeRollupModel> defaultPerformanceTimeRollups = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultPerformanceTimeRollups;
        }

        // fetch by primary key page for controller
        // fetch by primary key page for controller
        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  defaultperformancetimerollupid: filter by primary key
        [HttpGet("fetchbydefaultperformancetimerollupid/{defaultperformancetimerollupid?}")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupFetchByDefaultPerformanceTimeRollupId(System.Guid defaultperformancetimerollupid) {

            CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchByDefaultPerformanceTimeRollupId(defaultperformancetimerollupid);

            return defaultPerformanceTimeRollup;
        }

        // fetch by foreign key (simple) page for controller
        // fetch by foreign key (simple) page for controller
        // fetch by foreign key (simple) page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/82335188-ebea-40e3-a07d-094026340e92
        [HttpGet("fetchbycommandname/{commandname?}")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupFetchByCommandName(System.String commandname) {

            CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchByCommandName(commandname);

            return defaultPerformanceTimeRollup;
        }

        // create DefaultPerformanceTimeRollup POST page for controller
        // create DefaultPerformanceTimeRollup POST page for controller
        // create DefaultPerformanceTimeRollup POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeDefaultPerformanceTimeRollupModel: contract to add
        [HttpPost("crudedefaultperformancetimerollupcreate")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupCreate([Bind()] CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup) {

            new CrudeDefaultPerformanceTimeRollupBusiness().Insert(defaultPerformanceTimeRollup);

            return defaultPerformanceTimeRollup;
        }

        // create POST test page for controller
        // create POST test page for controller
        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeDefaultPerformanceTimeRollupCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Hits" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/30/2020 9:07:14 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate/", content).Result;

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

        // Update DefaultPerformanceTimeRollup POST page for controller
        // Update DefaultPerformanceTimeRollup POST page for controller
        // Update DefaultPerformanceTimeRollup POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeDefaultPerformanceTimeRollupModel: contract to add
        [HttpPut("crudedefaultperformancetimerollupupdate")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupUpdate([Bind()] CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup) {

            new CrudeDefaultPerformanceTimeRollupBusiness().Update(defaultPerformanceTimeRollup);

            return defaultPerformanceTimeRollup;
        }

        // update test page for controller
        // update test page for controller
        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeDefaultPerformanceTimeRollupUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Hits" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/30/2020 9:07:14 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupUpdate/", content).Result;

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
        [HttpDelete("defaultperformancetimerollupdelete/{defaultperformancetimerollupid?}")]
        public void CrudeDefaultPerformanceTimeRollupDelete(System.Guid defaultPerformanceTimeRollupId) {

            new CrudeDefaultPerformanceTimeRollupBusiness().Delete(defaultPerformanceTimeRollupId);
        }

        // delete test page for controller
        // delete test page for controller
        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeDefaultPerformanceTimeRollupDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
