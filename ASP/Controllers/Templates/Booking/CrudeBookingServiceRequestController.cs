/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 6:53:55 PM
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
    [Route("api/1/crudebookingservicerequest")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeBookingServiceRequestController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeBookingServiceRequestHelp(
            ) {

            return View(@"Views\Templates\Booking\CrudeBookingServiceRequest.cshtml");
        }

        // fetch all API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchAll() {

            List<CrudeBookingServiceRequestModel> bookingServiceRequests = 
                new CrudeBookingServiceRequestBusiness().FetchAll();

            return bookingServiceRequests;
        }

        // fetch all count API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeBookingServiceRequestFetchAllCount() {

            return new CrudeBookingServiceRequestBusiness().FetchAllCount();
        }

        // fetch all with limit API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchAllWithLimit(
                string limit
                ) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequests = 
                new CrudeBookingServiceRequestBusiness().FetchAllWithLimit(limit);

            return bookingServiceRequests;
        }

        // fetch all with limit and offset API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        // parameters:
        //  limit: only return this number of rows
        //   offset: start from this offset of rows
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequests = 
                new CrudeBookingServiceRequestBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return bookingServiceRequests;
        }

        // fetch by primary key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  bookingservicerequestid: filter by primary key
        [HttpGet("fetchbybookingservicerequestid/{bookingservicerequestid?}")]
        public CrudeBookingServiceRequestModel CrudeBookingServiceRequestFetchByBookingServiceRequestId(System.Guid bookingservicerequestid) {

            CrudeBookingServiceRequestModel bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByBookingServiceRequestId(bookingservicerequestid);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  bookingid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbybookingid/{bookingid?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByBookingId(System.Guid bookingid) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByBookingId(bookingid);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicetypercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyservicetypercd/{servicetypercd?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByServiceTypeRcd(System.String servicetypercd) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByServiceTypeRcd(servicetypercd);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicespecialservicerequestid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyservicespecialservicerequestid/{servicespecialservicerequestid?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByServiceSpecialServiceRequestId(System.Guid servicespecialservicerequestid) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByServiceSpecialServiceRequestId(servicespecialservicerequestid);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicerequeststatusrcd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyservicerequeststatusrcd/{servicerequeststatusrcd?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByServiceRequestStatusRcd(System.String servicerequeststatusrcd) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByServiceRequestStatusRcd(servicerequeststatusrcd);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicehotelid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyservicehotelid/{servicehotelid?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByServiceHotelId(System.Guid servicehotelid) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByServiceHotelId(servicehotelid);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicecarrentalid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyservicecarrentalid/{servicecarrentalid?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByServiceCarRentalId(System.Guid servicecarrentalid) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByServiceCarRentalId(servicecarrentalid);

            return bookingServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  serviceferryid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyserviceferryid/{serviceferryid?}")]
        public IEnumerable<CrudeBookingServiceRequestModel> CrudeBookingServiceRequestFetchByServiceFerryId(System.Guid serviceferryid) {

            List<CrudeBookingServiceRequestModel> bookingServiceRequest = 
                new CrudeBookingServiceRequestBusiness().FetchByServiceFerryId(serviceferryid);

            return bookingServiceRequest;
        }

        // create BookingServiceRequest POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeBookingServiceRequestModel: contract to add
        [HttpPost("crudebookingservicerequestcreate")]
        public CrudeBookingServiceRequestModel CrudeBookingServiceRequestCreate([Bind()] CrudeBookingServiceRequestModel bookingServiceRequest) {

            new CrudeBookingServiceRequestBusiness().Insert(bookingServiceRequest);

            return bookingServiceRequest;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeBookingServiceRequestCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceRequestStatusRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/4/2021 6:53:56 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeBookingServiceRequest/CrudeBookingServiceRequestCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingServiceRequest/CrudeBookingServiceRequestCreate/", content).Result;

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

        // ppdate BookingServiceRequest POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeBookingServiceRequestModel: contract to add
        [HttpPut("crudebookingservicerequestupdate")]
        public CrudeBookingServiceRequestModel CrudeBookingServiceRequestUpdate([Bind()] CrudeBookingServiceRequestModel bookingServiceRequest) {

            new CrudeBookingServiceRequestBusiness().Update(bookingServiceRequest);

            return bookingServiceRequest;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeBookingServiceRequestUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceRequestStatusRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/4/2021 6:53:56 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeBookingServiceRequest/CrudeBookingServiceRequestUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeBookingServiceRequest/CrudeBookingServiceRequestUpdate/", content).Result;

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
        [HttpDelete("bookingservicerequestdelete/{bookingservicerequestid?}")]
        public void CrudeBookingServiceRequestDelete(System.Guid bookingServiceRequestId) {

            new CrudeBookingServiceRequestBusiness().Delete(bookingServiceRequestId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeBookingServiceRequestDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeBookingServiceRequest/CrudeBookingServiceRequestDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
