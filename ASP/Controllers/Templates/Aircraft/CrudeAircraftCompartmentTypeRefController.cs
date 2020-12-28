/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 5:01:18 PM
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
    [Route("api/1/crudeaircraftcompartmenttyperef")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeAircraftCompartmentTypeRefController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeAircraftCompartmentTypeRefHelp(
            ) {

            return View(@"Views\Templates\Aircraft\CrudeAircraftCompartmentTypeRef.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeAircraftCompartmentTypeRefModel> CrudeAircraftCompartmentTypeRefFetchAll() {

            List<CrudeAircraftCompartmentTypeRefModel> aircraftCompartmentTypeRefs = 
                new CrudeAircraftCompartmentTypeRefBusiness().FetchAll();

            return aircraftCompartmentTypeRefs;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeAircraftCompartmentTypeRefFetchAllCount() {

            return new CrudeAircraftCompartmentTypeRefBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeAircraftCompartmentTypeRefModel> CrudeAircraftCompartmentTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeAircraftCompartmentTypeRefModel> aircraftCompartmentTypeRefs = 
                new CrudeAircraftCompartmentTypeRefBusiness().FetchAllWithLimit(limit);

            return aircraftCompartmentTypeRefs;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeAircraftCompartmentTypeRefModel> CrudeAircraftCompartmentTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeAircraftCompartmentTypeRefModel> aircraftCompartmentTypeRefs = 
                new CrudeAircraftCompartmentTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return aircraftCompartmentTypeRefs;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyaircraftcompartmenttypercd/{aircraftcompartmenttypercd?}")]
        public CrudeAircraftCompartmentTypeRefModel CrudeAircraftCompartmentTypeRefFetchByAircraftCompartmentTypeRcd(System.String aircraftcompartmenttypercd) {

            CrudeAircraftCompartmentTypeRefModel aircraftCompartmentTypeRef = 
                new CrudeAircraftCompartmentTypeRefBusiness().FetchByAircraftCompartmentTypeRcd(aircraftcompartmenttypercd);

            return aircraftCompartmentTypeRef;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudeaircraftcompartmenttyperefcreate")]
        public CrudeAircraftCompartmentTypeRefModel CrudeAircraftCompartmentTypeRefCreate([Bind()] CrudeAircraftCompartmentTypeRefModel aircraftCompartmentTypeRef) {

            new CrudeAircraftCompartmentTypeRefBusiness().Insert(aircraftCompartmentTypeRef);

            return aircraftCompartmentTypeRef;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeAircraftCompartmentTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "AircraftCompartmentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AircraftCompartmentTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 5:01:18 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeAircraftCompartmentTypeRef/CrudeAircraftCompartmentTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeAircraftCompartmentTypeRef/CrudeAircraftCompartmentTypeRefCreate/", content).Result;

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
        [HttpPut("crudeaircraftcompartmenttyperefupdate")]
        public CrudeAircraftCompartmentTypeRefModel CrudeAircraftCompartmentTypeRefUpdate([Bind()] CrudeAircraftCompartmentTypeRefModel aircraftCompartmentTypeRef) {

            new CrudeAircraftCompartmentTypeRefBusiness().Update(aircraftCompartmentTypeRef);

            return aircraftCompartmentTypeRef;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeAircraftCompartmentTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "AircraftCompartmentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AircraftCompartmentTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 5:01:18 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeAircraftCompartmentTypeRef/CrudeAircraftCompartmentTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeAircraftCompartmentTypeRef/CrudeAircraftCompartmentTypeRefUpdate/", content).Result;

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
        [HttpDelete("aircraftcompartmenttyperefdelete/{aircraftcompartmenttypercd?}")]
        public void CrudeAircraftCompartmentTypeRefDelete(System.String aircraftCompartmentTypeRcd) {

            new CrudeAircraftCompartmentTypeRefBusiness().Delete(aircraftCompartmentTypeRcd);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeAircraftCompartmentTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeAircraftCompartmentTypeRef/CrudeAircraftCompartmentTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
