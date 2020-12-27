/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 7:04:21 PM
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
    [Route("api/1/crudefinancialferrybooking")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeFinancialFerryBookingController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeFinancialFerryBookingHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialFerryBooking.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialFerryBookingModel> CrudeFinancialFerryBookingFetchAll() {

            List<CrudeFinancialFerryBookingModel> financialFerryBookings = 
                new CrudeFinancialFerryBookingBusiness().FetchAll();

            return financialFerryBookings;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeFinancialFerryBookingFetchAllCount() {

            return new CrudeFinancialFerryBookingBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialFerryBookingModel> CrudeFinancialFerryBookingFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialFerryBookingModel> financialFerryBookings = 
                new CrudeFinancialFerryBookingBusiness().FetchAllWithLimit(limit);

            return financialFerryBookings;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialFerryBookingModel> CrudeFinancialFerryBookingFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialFerryBookingModel> financialFerryBookings = 
                new CrudeFinancialFerryBookingBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialFerryBookings;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyfinancialferrybookingid/{financialferrybookingid?}")]
        public CrudeFinancialFerryBookingModel CrudeFinancialFerryBookingFetchByFinancialFerryBookingId(System.Guid financialferrybookingid) {

            CrudeFinancialFerryBookingModel financialFerryBooking = 
                new CrudeFinancialFerryBookingBusiness().FetchByFinancialFerryBookingId(financialferrybookingid);

            return financialFerryBooking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyserviceferryid/{serviceferryid?}")]
        public IEnumerable<CrudeFinancialFerryBookingModel> CrudeFinancialFerryBookingFetchByServiceFerryId(System.Guid serviceferryid) {

            List<CrudeFinancialFerryBookingModel> financialFerryBooking = 
                new CrudeFinancialFerryBookingBusiness().FetchByServiceFerryId(serviceferryid);

            return financialFerryBooking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialFerryBookingModel> CrudeFinancialFerryBookingFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialFerryBookingModel> financialFerryBooking = 
                new CrudeFinancialFerryBookingBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialFerryBooking;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudefinancialferrybookingcreate")]
        public CrudeFinancialFerryBookingModel CrudeFinancialFerryBookingCreate([Bind()] CrudeFinancialFerryBookingModel financialFerryBooking) {

            new CrudeFinancialFerryBookingBusiness().Insert(financialFerryBooking);

            return financialFerryBooking;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeFinancialFerryBookingCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FromDateTime" , "12/27/2020 7:04:21 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "UntilDateTime" , "12/27/2020 7:04:21 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 7:04:21 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialFerryBooking/CrudeFinancialFerryBookingCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialFerryBooking/CrudeFinancialFerryBookingCreate/", content).Result;

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
        [HttpPut("crudefinancialferrybookingupdate")]
        public CrudeFinancialFerryBookingModel CrudeFinancialFerryBookingUpdate([Bind()] CrudeFinancialFerryBookingModel financialFerryBooking) {

            new CrudeFinancialFerryBookingBusiness().Update(financialFerryBooking);

            return financialFerryBooking;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeFinancialFerryBookingUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FromDateTime" , "12/27/2020 7:04:21 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "UntilDateTime" , "12/27/2020 7:04:21 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 7:04:21 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialFerryBooking/CrudeFinancialFerryBookingUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialFerryBooking/CrudeFinancialFerryBookingUpdate/", content).Result;

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
        [HttpDelete("financialferrybookingdelete/{financialferrybookingid?}")]
        public void CrudeFinancialFerryBookingDelete(System.Guid financialFerryBookingId) {

            new CrudeFinancialFerryBookingBusiness().Delete(financialFerryBookingId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeFinancialFerryBookingDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialFerryBooking/CrudeFinancialFerryBookingDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
