/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:16:18 AM
  From Machine: DESKTOP-BP3OHLH
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
    [Route("api/1/crudebookingdocument")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeBookingDocumentController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeBookingDocumentHelp(
            ) {

            return View(@"Views\Templates\Booking\CrudeBookingDocument.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeBookingDocumentModel> CrudeBookingDocumentFetchAll() {

            List<CrudeBookingDocumentModel> bookingDocuments = 
                new CrudeBookingDocumentBusiness().FetchAll();

            return bookingDocuments;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeBookingDocumentFetchAllCount() {

            return new CrudeBookingDocumentBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeBookingDocumentModel> CrudeBookingDocumentFetchAllWithLimit(
                string limit
                ) {

            List<CrudeBookingDocumentModel> bookingDocuments = 
                new CrudeBookingDocumentBusiness().FetchAllWithLimit(limit);

            return bookingDocuments;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeBookingDocumentModel> CrudeBookingDocumentFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeBookingDocumentModel> bookingDocuments = 
                new CrudeBookingDocumentBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return bookingDocuments;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbybookingdocumentid/{bookingdocumentid?}")]
        public CrudeBookingDocumentModel CrudeBookingDocumentFetchByBookingDocumentId(System.Guid bookingdocumentid) {

            CrudeBookingDocumentModel bookingDocument = 
                new CrudeBookingDocumentBusiness().FetchByBookingDocumentId(bookingdocumentid);

            return bookingDocument;
        }

        // fetch by foreign key (simple) page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/82335188-ebea-40e3-a07d-094026340e92
        [HttpGet("fetchbybookingdocumentname/{bookingdocumentname?}")]
        public CrudeBookingDocumentModel CrudeBookingDocumentFetchByBookingDocumentName(System.String bookingdocumentname) {

            CrudeBookingDocumentModel bookingDocument = 
                new CrudeBookingDocumentBusiness().FetchByBookingDocumentName(bookingdocumentname);

            return bookingDocument;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingid/{bookingid?}")]
        public IEnumerable<CrudeBookingDocumentModel> CrudeBookingDocumentFetchByBookingId(System.Guid bookingid) {

            List<CrudeBookingDocumentModel> bookingDocument = 
                new CrudeBookingDocumentBusiness().FetchByBookingId(bookingid);

            return bookingDocument;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingdocumenttypercd/{bookingdocumenttypercd?}")]
        public IEnumerable<CrudeBookingDocumentModel> CrudeBookingDocumentFetchByBookingDocumentTypeRcd(System.String bookingdocumenttypercd) {

            List<CrudeBookingDocumentModel> bookingDocument = 
                new CrudeBookingDocumentBusiness().FetchByBookingDocumentTypeRcd(bookingdocumenttypercd);

            return bookingDocument;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudebookingdocumentcreate")]
        public CrudeBookingDocumentModel CrudeBookingDocumentCreate([Bind()] CrudeBookingDocumentModel bookingDocument) {

            new CrudeBookingDocumentBusiness().Insert(bookingDocument);

            return bookingDocument;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeBookingDocumentCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocumentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocumentName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocumentFilename" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocument" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 12:16:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeBookingDocument/CrudeBookingDocumentCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingDocument/CrudeBookingDocumentCreate/", content).Result;

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
        [HttpPut("crudebookingdocumentupdate")]
        public CrudeBookingDocumentModel CrudeBookingDocumentUpdate([Bind()] CrudeBookingDocumentModel bookingDocument) {

            new CrudeBookingDocumentBusiness().Update(bookingDocument);

            return bookingDocument;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeBookingDocumentUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocumentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocumentName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocumentFilename" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BookingDocument" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 12:16:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeBookingDocument/CrudeBookingDocumentUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingDocument/CrudeBookingDocumentUpdate/", content).Result;

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
        [HttpDelete("bookingdocumentdelete/{bookingdocumentid?}")]
        public void CrudeBookingDocumentDelete(System.Guid bookingDocumentId) {

            new CrudeBookingDocumentBusiness().Delete(bookingDocumentId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeBookingDocumentDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeBookingDocument/CrudeBookingDocumentDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
