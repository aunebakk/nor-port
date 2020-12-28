﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:30:18 PM
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
    [Route("api/1/crudeflightsegmentevent")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeFlightSegmentEventController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeFlightSegmentEventHelp(
            ) {

            return View(@"Views\Templates\Flight\CrudeFlightSegmentEvent.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeFlightSegmentEventModel> CrudeFlightSegmentEventFetchAll() {

            List<CrudeFlightSegmentEventModel> flightSegmentEvents = 
                new CrudeFlightSegmentEventBusiness().FetchAll();

            return flightSegmentEvents;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeFlightSegmentEventFetchAllCount() {

            return new CrudeFlightSegmentEventBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFlightSegmentEventModel> CrudeFlightSegmentEventFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFlightSegmentEventModel> flightSegmentEvents = 
                new CrudeFlightSegmentEventBusiness().FetchAllWithLimit(limit);

            return flightSegmentEvents;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFlightSegmentEventModel> CrudeFlightSegmentEventFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFlightSegmentEventModel> flightSegmentEvents = 
                new CrudeFlightSegmentEventBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return flightSegmentEvents;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyflightsegmenteventid/{flightsegmenteventid?}")]
        public CrudeFlightSegmentEventModel CrudeFlightSegmentEventFetchByFlightSegmentEventId(System.Guid flightsegmenteventid) {

            CrudeFlightSegmentEventModel flightSegmentEvent = 
                new CrudeFlightSegmentEventBusiness().FetchByFlightSegmentEventId(flightsegmenteventid);

            return flightSegmentEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyflightsegmentid/{flightsegmentid?}")]
        public IEnumerable<CrudeFlightSegmentEventModel> CrudeFlightSegmentEventFetchByFlightSegmentId(System.Guid flightsegmentid) {

            List<CrudeFlightSegmentEventModel> flightSegmentEvent = 
                new CrudeFlightSegmentEventBusiness().FetchByFlightSegmentId(flightsegmentid);

            return flightSegmentEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbydatetimetypercd/{datetimetypercd?}")]
        public IEnumerable<CrudeFlightSegmentEventModel> CrudeFlightSegmentEventFetchByDateTimeTypeRcd(System.String datetimetypercd) {

            List<CrudeFlightSegmentEventModel> flightSegmentEvent = 
                new CrudeFlightSegmentEventBusiness().FetchByDateTimeTypeRcd(datetimetypercd);

            return flightSegmentEvent;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudeflightsegmenteventcreate")]
        public CrudeFlightSegmentEventModel CrudeFlightSegmentEventCreate([Bind()] CrudeFlightSegmentEventModel flightSegmentEvent) {

            new CrudeFlightSegmentEventBusiness().Insert(flightSegmentEvent);

            return flightSegmentEvent;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeFlightSegmentEventCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FlightSegmentEventNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTimeTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "NewDateTime" , "12/27/2020 11:30:18 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Remarks" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:30:18 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFlightSegmentEvent/CrudeFlightSegmentEventCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFlightSegmentEvent/CrudeFlightSegmentEventCreate/", content).Result;

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
        [HttpPut("crudeflightsegmenteventupdate")]
        public CrudeFlightSegmentEventModel CrudeFlightSegmentEventUpdate([Bind()] CrudeFlightSegmentEventModel flightSegmentEvent) {

            new CrudeFlightSegmentEventBusiness().Update(flightSegmentEvent);

            return flightSegmentEvent;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeFlightSegmentEventUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FlightSegmentEventNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTimeTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "NewDateTime" , "12/27/2020 11:30:18 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Remarks" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:30:18 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFlightSegmentEvent/CrudeFlightSegmentEventUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFlightSegmentEvent/CrudeFlightSegmentEventUpdate/", content).Result;

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
        [HttpDelete("flightsegmenteventdelete/{flightsegmenteventid?}")]
        public void CrudeFlightSegmentEventDelete(System.Guid flightSegmentEventId) {

            new CrudeFlightSegmentEventBusiness().Delete(flightSegmentEventId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeFlightSegmentEventDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFlightSegmentEvent/CrudeFlightSegmentEventDelete/00000000-0000-0000-0000-000000000001" ).Result;

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