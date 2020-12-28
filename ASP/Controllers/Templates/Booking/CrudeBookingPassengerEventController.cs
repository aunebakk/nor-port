﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:22:38 PM
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
    [Route("api/1/crudebookingpassengerevent")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeBookingPassengerEventController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeBookingPassengerEventHelp(
            ) {

            return View(@"Views\Templates\Booking\CrudeBookingPassengerEvent.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchAll() {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvents = 
                new CrudeBookingPassengerEventBusiness().FetchAll();

            return bookingPassengerEvents;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeBookingPassengerEventFetchAllCount() {

            return new CrudeBookingPassengerEventBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchAllWithLimit(
                string limit
                ) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvents = 
                new CrudeBookingPassengerEventBusiness().FetchAllWithLimit(limit);

            return bookingPassengerEvents;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvents = 
                new CrudeBookingPassengerEventBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return bookingPassengerEvents;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbybookingpassengereventid/{bookingpassengereventid?}")]
        public CrudeBookingPassengerEventModel CrudeBookingPassengerEventFetchByBookingPassengerEventId(System.Guid bookingpassengereventid) {

            CrudeBookingPassengerEventModel bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingPassengerEventId(bookingpassengereventid);

            return bookingPassengerEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingpassengereventtypercd/{bookingpassengereventtypercd?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchByBookingPassengerEventTypeRcd(System.String bookingpassengereventtypercd) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingPassengerEventTypeRcd(bookingpassengereventtypercd);

            return bookingPassengerEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingpassengerid/{bookingpassengerid?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchByBookingPassengerId(System.Guid bookingpassengerid) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingPassengerId(bookingpassengerid);

            return bookingPassengerEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingflightsegmentid/{bookingflightsegmentid?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchByBookingFlightSegmentId(System.Guid bookingflightsegmentid) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingFlightSegmentId(bookingflightsegmentid);

            return bookingPassengerEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingpassengerticketid/{bookingpassengerticketid?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchByBookingPassengerTicketId(System.Guid bookingpassengerticketid) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingPassengerTicketId(bookingpassengerticketid);

            return bookingPassengerEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingpassengerseatid/{bookingpassengerseatid?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchByBookingPassengerSeatId(System.Guid bookingpassengerseatid) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingPassengerSeatId(bookingpassengerseatid);

            return bookingPassengerEvent;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingpassengerbaggageid/{bookingpassengerbaggageid?}")]
        public IEnumerable<CrudeBookingPassengerEventModel> CrudeBookingPassengerEventFetchByBookingPassengerBaggageId(System.Guid bookingpassengerbaggageid) {

            List<CrudeBookingPassengerEventModel> bookingPassengerEvent = 
                new CrudeBookingPassengerEventBusiness().FetchByBookingPassengerBaggageId(bookingpassengerbaggageid);

            return bookingPassengerEvent;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudebookingpassengereventcreate")]
        public CrudeBookingPassengerEventModel CrudeBookingPassengerEventCreate([Bind()] CrudeBookingPassengerEventModel bookingPassengerEvent) {

            new CrudeBookingPassengerEventBusiness().Insert(bookingPassengerEvent);

            return bookingPassengerEvent;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeBookingPassengerEventCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "BookingPassengerEventTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingPassengerEventNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Remarks" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:22:38 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeBookingPassengerEvent/CrudeBookingPassengerEventCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingPassengerEvent/CrudeBookingPassengerEventCreate/", content).Result;

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
        [HttpPut("crudebookingpassengereventupdate")]
        public CrudeBookingPassengerEventModel CrudeBookingPassengerEventUpdate([Bind()] CrudeBookingPassengerEventModel bookingPassengerEvent) {

            new CrudeBookingPassengerEventBusiness().Update(bookingPassengerEvent);

            return bookingPassengerEvent;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeBookingPassengerEventUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "BookingPassengerEventTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingPassengerEventNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Remarks" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:22:38 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeBookingPassengerEvent/CrudeBookingPassengerEventUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingPassengerEvent/CrudeBookingPassengerEventUpdate/", content).Result;

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
        [HttpDelete("bookingpassengereventdelete/{bookingpassengereventid?}")]
        public void CrudeBookingPassengerEventDelete(System.Guid bookingPassengerEventId) {

            new CrudeBookingPassengerEventBusiness().Delete(bookingPassengerEventId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeBookingPassengerEventDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeBookingPassengerEvent/CrudeBookingPassengerEventDelete/00000000-0000-0000-0000-000000000001" ).Result;

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