/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:25:07 PM
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
    [Route("api/1/crudedefaultsystemsettingref")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeDefaultSystemSettingRefController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeDefaultSystemSettingRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultSystemSettingRef.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultSystemSettingRefModel> CrudeDefaultSystemSettingRefFetchAll() {

            List<CrudeDefaultSystemSettingRefModel> defaultSystemSettingRefs = 
                new CrudeDefaultSystemSettingRefBusiness().FetchAll();

            return defaultSystemSettingRefs;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeDefaultSystemSettingRefFetchAllCount() {

            return new CrudeDefaultSystemSettingRefBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultSystemSettingRefModel> CrudeDefaultSystemSettingRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultSystemSettingRefModel> defaultSystemSettingRefs = 
                new CrudeDefaultSystemSettingRefBusiness().FetchAllWithLimit(limit);

            return defaultSystemSettingRefs;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultSystemSettingRefModel> CrudeDefaultSystemSettingRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultSystemSettingRefModel> defaultSystemSettingRefs = 
                new CrudeDefaultSystemSettingRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultSystemSettingRefs;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbydefaultsystemsettingrcd/{defaultsystemsettingrcd?}")]
        public CrudeDefaultSystemSettingRefModel CrudeDefaultSystemSettingRefFetchByDefaultSystemSettingRcd(System.String defaultsystemsettingrcd) {

            CrudeDefaultSystemSettingRefModel defaultSystemSettingRef = 
                new CrudeDefaultSystemSettingRefBusiness().FetchByDefaultSystemSettingRcd(defaultsystemsettingrcd);

            return defaultSystemSettingRef;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudedefaultsystemsettingrefcreate")]
        public CrudeDefaultSystemSettingRefModel CrudeDefaultSystemSettingRefCreate([Bind()] CrudeDefaultSystemSettingRefModel defaultSystemSettingRef) {

            new CrudeDefaultSystemSettingRefBusiness().Insert(defaultSystemSettingRef);

            return defaultSystemSettingRef;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeDefaultSystemSettingRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:25:07 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefCreate/", content).Result;

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
        [HttpPut("crudedefaultsystemsettingrefupdate")]
        public CrudeDefaultSystemSettingRefModel CrudeDefaultSystemSettingRefUpdate([Bind()] CrudeDefaultSystemSettingRefModel defaultSystemSettingRef) {

            new CrudeDefaultSystemSettingRefBusiness().Update(defaultSystemSettingRef);

            return defaultSystemSettingRef;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeDefaultSystemSettingRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:25:07 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefUpdate/", content).Result;

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
        [HttpDelete("defaultsystemsettingrefdelete/{defaultsystemsettingrcd?}")]
        public void CrudeDefaultSystemSettingRefDelete(System.String defaultSystemSettingRcd) {

            new CrudeDefaultSystemSettingRefBusiness().Delete(defaultSystemSettingRcd);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeDefaultSystemSettingRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
