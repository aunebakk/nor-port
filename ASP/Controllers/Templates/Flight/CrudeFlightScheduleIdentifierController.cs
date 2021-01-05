/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 7:36:02 AM
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
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/crudeflightscheduleidentifier")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeFlightScheduleIdentifierController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeFlightScheduleIdentifierHelp(
            ) {

            return View(@"Views\Templates\Flight\CrudeFlightScheduleIdentifier.cshtml");
        }

        // fetch all API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeFlightScheduleIdentifierModel> CrudeFlightScheduleIdentifierFetchAll() {

            List<CrudeFlightScheduleIdentifierModel> flightScheduleIdentifiers = 
                new CrudeFlightScheduleIdentifierBusiness().FetchAll();

            return flightScheduleIdentifiers;
        }

        // fetch all count API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeFlightScheduleIdentifierFetchAllCount() {

            return new CrudeFlightScheduleIdentifierBusiness().FetchAllCount();
        }

        // fetch all with limit API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFlightScheduleIdentifierModel> CrudeFlightScheduleIdentifierFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFlightScheduleIdentifierModel> flightScheduleIdentifiers = 
                new CrudeFlightScheduleIdentifierBusiness().FetchAllWithLimit(limit);

            return flightScheduleIdentifiers;
        }

        // fetch all with limit and offset API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        // parameters:
        //  limit: only return this number of rows
        //   offset: start from this offset of rows
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFlightScheduleIdentifierModel> CrudeFlightScheduleIdentifierFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFlightScheduleIdentifierModel> flightScheduleIdentifiers = 
                new CrudeFlightScheduleIdentifierBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return flightScheduleIdentifiers;
        }

        // fetch by primary key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  flightscheduleidentifierid: filter by primary key
        [HttpGet("fetchbyflightscheduleidentifierid/{flightscheduleidentifierid?}")]
        public CrudeFlightScheduleIdentifierModel CrudeFlightScheduleIdentifierFetchByFlightScheduleIdentifierId(System.Guid flightscheduleidentifierid) {

            CrudeFlightScheduleIdentifierModel flightScheduleIdentifier = 
                new CrudeFlightScheduleIdentifierBusiness().FetchByFlightScheduleIdentifierId(flightscheduleidentifierid);

            return flightScheduleIdentifier;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  flightscheduleid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyflightscheduleid/{flightscheduleid?}")]
        public IEnumerable<CrudeFlightScheduleIdentifierModel> CrudeFlightScheduleIdentifierFetchByFlightScheduleId(System.Guid flightscheduleid) {

            List<CrudeFlightScheduleIdentifierModel> flightScheduleIdentifier = 
                new CrudeFlightScheduleIdentifierBusiness().FetchByFlightScheduleId(flightscheduleid);

            return flightScheduleIdentifier;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  flightidentifiertypercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyflightidentifiertypercd/{flightidentifiertypercd?}")]
        public IEnumerable<CrudeFlightScheduleIdentifierModel> CrudeFlightScheduleIdentifierFetchByFlightIdentifierTypeRcd(System.String flightidentifiertypercd) {

            List<CrudeFlightScheduleIdentifierModel> flightScheduleIdentifier = 
                new CrudeFlightScheduleIdentifierBusiness().FetchByFlightIdentifierTypeRcd(flightidentifiertypercd);

            return flightScheduleIdentifier;
        }

        // create FlightScheduleIdentifier POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeFlightScheduleIdentifierModel: contract to add
        [HttpPost("crudeflightscheduleidentifiercreate")]
        public CrudeFlightScheduleIdentifierModel CrudeFlightScheduleIdentifierCreate([Bind()] CrudeFlightScheduleIdentifierModel flightScheduleIdentifier) {

            new CrudeFlightScheduleIdentifierBusiness().Insert(flightScheduleIdentifier);

            return flightScheduleIdentifier;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeFlightScheduleIdentifierCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FlightIdentifierTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FlightIdentifierCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/5/2021 7:36:02 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFlightScheduleIdentifier/CrudeFlightScheduleIdentifierCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFlightScheduleIdentifier/CrudeFlightScheduleIdentifierCreate/", content).Result;

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

        // ppdate FlightScheduleIdentifier POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeFlightScheduleIdentifierModel: contract to add
        [HttpPut("crudeflightscheduleidentifierupdate")]
        public CrudeFlightScheduleIdentifierModel CrudeFlightScheduleIdentifierUpdate([Bind()] CrudeFlightScheduleIdentifierModel flightScheduleIdentifier) {

            new CrudeFlightScheduleIdentifierBusiness().Update(flightScheduleIdentifier);

            return flightScheduleIdentifier;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeFlightScheduleIdentifierUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FlightIdentifierTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FlightIdentifierCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/5/2021 7:36:02 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFlightScheduleIdentifier/CrudeFlightScheduleIdentifierUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFlightScheduleIdentifier/CrudeFlightScheduleIdentifierUpdate/", content).Result;

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

        // DELETE API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/c5cd4292-e198-4631-9b3f-a67451a48cac
        [HttpDelete("flightscheduleidentifierdelete/{flightscheduleidentifierid?}")]
        public void CrudeFlightScheduleIdentifierDelete(System.Guid flightScheduleIdentifierId) {

            new CrudeFlightScheduleIdentifierBusiness().Delete(flightScheduleIdentifierId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeFlightScheduleIdentifierDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFlightScheduleIdentifier/CrudeFlightScheduleIdentifierDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
