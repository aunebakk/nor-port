﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:22:30 PM
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
    [Route("api/1/crudebookingpassenger")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeBookingPassengerController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeBookingPassengerHelp(
            ) {

            return View(@"Views\Templates\Booking\CrudeBookingPassenger.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeBookingPassengerModel> CrudeBookingPassengerFetchAll() {

            List<CrudeBookingPassengerModel> bookingPassengers = 
                new CrudeBookingPassengerBusiness().FetchAll();

            return bookingPassengers;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeBookingPassengerFetchAllCount() {

            return new CrudeBookingPassengerBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeBookingPassengerModel> CrudeBookingPassengerFetchAllWithLimit(
                string limit
                ) {

            List<CrudeBookingPassengerModel> bookingPassengers = 
                new CrudeBookingPassengerBusiness().FetchAllWithLimit(limit);

            return bookingPassengers;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeBookingPassengerModel> CrudeBookingPassengerFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeBookingPassengerModel> bookingPassengers = 
                new CrudeBookingPassengerBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return bookingPassengers;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbybookingpassengerid/{bookingpassengerid?}")]
        public CrudeBookingPassengerModel CrudeBookingPassengerFetchByBookingPassengerId(System.Guid bookingpassengerid) {

            CrudeBookingPassengerModel bookingPassenger = 
                new CrudeBookingPassengerBusiness().FetchByBookingPassengerId(bookingpassengerid);

            return bookingPassenger;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingid/{bookingid?}")]
        public IEnumerable<CrudeBookingPassengerModel> CrudeBookingPassengerFetchByBookingId(System.Guid bookingid) {

            List<CrudeBookingPassengerModel> bookingPassenger = 
                new CrudeBookingPassengerBusiness().FetchByBookingId(bookingid);

            return bookingPassenger;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbypassengerid/{passengerid?}")]
        public IEnumerable<CrudeBookingPassengerModel> CrudeBookingPassengerFetchByPassengerId(System.Guid passengerid) {

            List<CrudeBookingPassengerModel> bookingPassenger = 
                new CrudeBookingPassengerBusiness().FetchByPassengerId(passengerid);

            return bookingPassenger;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudebookingpassengercreate")]
        public CrudeBookingPassengerModel CrudeBookingPassengerCreate([Bind()] CrudeBookingPassengerModel bookingPassenger) {

            new CrudeBookingPassengerBusiness().Insert(bookingPassenger);

            return bookingPassenger;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeBookingPassengerCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:22:30 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeBookingPassenger/CrudeBookingPassengerCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingPassenger/CrudeBookingPassengerCreate/", content).Result;

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
        [HttpPut("crudebookingpassengerupdate")]
        public CrudeBookingPassengerModel CrudeBookingPassengerUpdate([Bind()] CrudeBookingPassengerModel bookingPassenger) {

            new CrudeBookingPassengerBusiness().Update(bookingPassenger);

            return bookingPassenger;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeBookingPassengerUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:22:30 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeBookingPassenger/CrudeBookingPassengerUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingPassenger/CrudeBookingPassengerUpdate/", content).Result;

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
        [HttpDelete("bookingpassengerdelete/{bookingpassengerid?}")]
        public void CrudeBookingPassengerDelete(System.Guid bookingPassengerId) {

            new CrudeBookingPassengerBusiness().Delete(bookingPassengerId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeBookingPassengerDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeBookingPassenger/CrudeBookingPassengerDelete/00000000-0000-0000-0000-000000000001" ).Result;

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