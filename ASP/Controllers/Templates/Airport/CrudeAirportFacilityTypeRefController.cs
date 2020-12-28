﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:21:23 PM
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
    [Route("api/1/crudeairportfacilitytyperef")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeAirportFacilityTypeRefController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeAirportFacilityTypeRefHelp(
            ) {

            return View(@"Views\Templates\Airport\CrudeAirportFacilityTypeRef.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeAirportFacilityTypeRefModel> CrudeAirportFacilityTypeRefFetchAll() {

            List<CrudeAirportFacilityTypeRefModel> airportFacilityTypeRefs = 
                new CrudeAirportFacilityTypeRefBusiness().FetchAll();

            return airportFacilityTypeRefs;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeAirportFacilityTypeRefFetchAllCount() {

            return new CrudeAirportFacilityTypeRefBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeAirportFacilityTypeRefModel> CrudeAirportFacilityTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeAirportFacilityTypeRefModel> airportFacilityTypeRefs = 
                new CrudeAirportFacilityTypeRefBusiness().FetchAllWithLimit(limit);

            return airportFacilityTypeRefs;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeAirportFacilityTypeRefModel> CrudeAirportFacilityTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeAirportFacilityTypeRefModel> airportFacilityTypeRefs = 
                new CrudeAirportFacilityTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return airportFacilityTypeRefs;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyairportfacilitytypercd/{airportfacilitytypercd?}")]
        public CrudeAirportFacilityTypeRefModel CrudeAirportFacilityTypeRefFetchByAirportFacilityTypeRcd(System.String airportfacilitytypercd) {

            CrudeAirportFacilityTypeRefModel airportFacilityTypeRef = 
                new CrudeAirportFacilityTypeRefBusiness().FetchByAirportFacilityTypeRcd(airportfacilitytypercd);

            return airportFacilityTypeRef;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudeairportfacilitytyperefcreate")]
        public CrudeAirportFacilityTypeRefModel CrudeAirportFacilityTypeRefCreate([Bind()] CrudeAirportFacilityTypeRefModel airportFacilityTypeRef) {

            new CrudeAirportFacilityTypeRefBusiness().Insert(airportFacilityTypeRef);

            return airportFacilityTypeRef;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeAirportFacilityTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "AirportFacilityTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AirportFacilityTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:21:23 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeAirportFacilityTypeRef/CrudeAirportFacilityTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeAirportFacilityTypeRef/CrudeAirportFacilityTypeRefCreate/", content).Result;

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
        [HttpPut("crudeairportfacilitytyperefupdate")]
        public CrudeAirportFacilityTypeRefModel CrudeAirportFacilityTypeRefUpdate([Bind()] CrudeAirportFacilityTypeRefModel airportFacilityTypeRef) {

            new CrudeAirportFacilityTypeRefBusiness().Update(airportFacilityTypeRef);

            return airportFacilityTypeRef;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeAirportFacilityTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "AirportFacilityTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AirportFacilityTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:21:23 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeAirportFacilityTypeRef/CrudeAirportFacilityTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeAirportFacilityTypeRef/CrudeAirportFacilityTypeRefUpdate/", content).Result;

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
        [HttpDelete("airportfacilitytyperefdelete/{airportfacilitytypercd?}")]
        public void CrudeAirportFacilityTypeRefDelete(System.String airportFacilityTypeRcd) {

            new CrudeAirportFacilityTypeRefBusiness().Delete(airportFacilityTypeRcd);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeAirportFacilityTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeAirportFacilityTypeRef/CrudeAirportFacilityTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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