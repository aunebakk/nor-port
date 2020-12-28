/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:21:58 PM
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
    [Route("api/1/crudebooking")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeBookingController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeBookingHelp(
            ) {

            return View(@"Views\Templates\Booking\CrudeBooking.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchAll() {

            List<CrudeBookingModel> bookings = 
                new CrudeBookingBusiness().FetchAll();

            return bookings;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeBookingFetchAllCount() {

            return new CrudeBookingBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchAllWithLimit(
                string limit
                ) {

            List<CrudeBookingModel> bookings = 
                new CrudeBookingBusiness().FetchAllWithLimit(limit);

            return bookings;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeBookingModel> bookings = 
                new CrudeBookingBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return bookings;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbybookingid/{bookingid?}")]
        public CrudeBookingModel CrudeBookingFetchByBookingId(System.Guid bookingid) {

            CrudeBookingModel booking = 
                new CrudeBookingBusiness().FetchByBookingId(bookingid);

            return booking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyaddressid/{addressid?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchByAddressId(System.Guid addressid) {

            List<CrudeBookingModel> booking = 
                new CrudeBookingBusiness().FetchByAddressId(addressid);

            return booking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingsourcercd/{bookingsourcercd?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchByBookingSourceRcd(System.String bookingsourcercd) {

            List<CrudeBookingModel> booking = 
                new CrudeBookingBusiness().FetchByBookingSourceRcd(bookingsourcercd);

            return booking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyexternalsystemid/{externalsystemid?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchByExternalSystemId(System.Guid externalsystemid) {

            List<CrudeBookingModel> booking = 
                new CrudeBookingBusiness().FetchByExternalSystemId(externalsystemid);

            return booking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyagencyid/{agencyid?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchByAgencyId(System.Guid agencyid) {

            List<CrudeBookingModel> booking = 
                new CrudeBookingBusiness().FetchByAgencyId(agencyid);

            return booking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeBookingModel> booking = 
                new CrudeBookingBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return booking;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialcostcentreid/{financialcostcentreid?}")]
        public IEnumerable<CrudeBookingModel> CrudeBookingFetchByFinancialCostcentreId(System.Guid financialcostcentreid) {

            List<CrudeBookingModel> booking = 
                new CrudeBookingBusiness().FetchByFinancialCostcentreId(financialcostcentreid);

            return booking;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudebookingcreate")]
        public CrudeBookingModel CrudeBookingCreate([Bind()] CrudeBookingModel booking) {

            new CrudeBookingBusiness().Insert(booking);

            return booking;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeBookingCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ReceivedFrom" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingSourceRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:21:58 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeBooking/CrudeBookingCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBooking/CrudeBookingCreate/", content).Result;

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
        [HttpPut("crudebookingupdate")]
        public CrudeBookingModel CrudeBookingUpdate([Bind()] CrudeBookingModel booking) {

            new CrudeBookingBusiness().Update(booking);

            return booking;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeBookingUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ReceivedFrom" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingSourceRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:21:58 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeBooking/CrudeBookingUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBooking/CrudeBookingUpdate/", content).Result;

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
        [HttpDelete("bookingdelete/{bookingid?}")]
        public void CrudeBookingDelete(System.Guid bookingId) {

            new CrudeBookingBusiness().Delete(bookingId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeBookingDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeBooking/CrudeBookingDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
