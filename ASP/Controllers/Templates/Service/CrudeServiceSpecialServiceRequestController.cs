/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 1:35:38 PM
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
    [Route("api/1/crudeservicespecialservicerequest")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeServiceSpecialServiceRequestController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeServiceSpecialServiceRequestHelp(
            ) {

            return View(@"Views\Templates\Service\CrudeServiceSpecialServiceRequest.cshtml");
        }

        // fetch all API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchAll() {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequests = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchAll();

            return serviceSpecialServiceRequests;
        }

        // fetch all count API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeServiceSpecialServiceRequestFetchAllCount() {

            return new CrudeServiceSpecialServiceRequestBusiness().FetchAllCount();
        }

        // fetch all with limit API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchAllWithLimit(
                string limit
                ) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequests = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchAllWithLimit(limit);

            return serviceSpecialServiceRequests;
        }

        // fetch all with limit and offset API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        // parameters:
        //  limit: only return this number of rows
        //   offset: start from this offset of rows
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequests = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return serviceSpecialServiceRequests;
        }

        // fetch by primary key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  servicespecialservicerequestid: filter by primary key
        [HttpGet("fetchbyservicespecialservicerequestid/{servicespecialservicerequestid?}")]
        public CrudeServiceSpecialServiceRequestModel CrudeServiceSpecialServiceRequestFetchByServiceSpecialServiceRequestId(System.Guid servicespecialservicerequestid) {

            CrudeServiceSpecialServiceRequestModel serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByServiceSpecialServiceRequestId(servicespecialservicerequestid);

            return serviceSpecialServiceRequest;
        }

        // fetch by foreign key (simple) API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/82335188-ebea-40e3-a07d-094026340e92
        [HttpGet("fetchbyservicespecialservicerequestcode/{servicespecialservicerequestcode?}")]
        public CrudeServiceSpecialServiceRequestModel CrudeServiceSpecialServiceRequestFetchByServiceSpecialServiceRequestCode(System.String servicespecialservicerequestcode) {

            CrudeServiceSpecialServiceRequestModel serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByServiceSpecialServiceRequestCode(servicespecialservicerequestcode);

            return serviceSpecialServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicespecialservicerequestgrouprcd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyservicespecialservicerequestgrouprcd/{servicespecialservicerequestgrouprcd?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchByServiceSpecialServiceRequestGroupRcd(System.String servicespecialservicerequestgrouprcd) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByServiceSpecialServiceRequestGroupRcd(servicespecialservicerequestgrouprcd);

            return serviceSpecialServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  financialcurrencyid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return serviceSpecialServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  requestservicespecialservicerequestrequirementrcd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyrequestservicespecialservicerequestrequirementrcd/{requestservicespecialservicerequestrequirementrcd?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchByRequestServiceSpecialServiceRequestRequirementRcd(System.String requestservicespecialservicerequestrequirementrcd) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByRequestServiceSpecialServiceRequestRequirementRcd(requestservicespecialservicerequestrequirementrcd);

            return serviceSpecialServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  replyservicespecialservicerequestrequirementrcd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyreplyservicespecialservicerequestrequirementrcd/{replyservicespecialservicerequestrequirementrcd?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchByReplyServiceSpecialServiceRequestRequirementRcd(System.String replyservicespecialservicerequestrequirementrcd) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByReplyServiceSpecialServiceRequestRequirementRcd(replyservicespecialservicerequestrequirementrcd);

            return serviceSpecialServiceRequest;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  servicespecialservicerequestoperationrulercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyservicespecialservicerequestoperationrulercd/{servicespecialservicerequestoperationrulercd?}")]
        public IEnumerable<CrudeServiceSpecialServiceRequestModel> CrudeServiceSpecialServiceRequestFetchByServiceSpecialServiceRequestOperationRuleRcd(System.String servicespecialservicerequestoperationrulercd) {

            List<CrudeServiceSpecialServiceRequestModel> serviceSpecialServiceRequest = 
                new CrudeServiceSpecialServiceRequestBusiness().FetchByServiceSpecialServiceRequestOperationRuleRcd(servicespecialservicerequestoperationrulercd);

            return serviceSpecialServiceRequest;
        }

        // create ServiceSpecialServiceRequest POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeServiceSpecialServiceRequestModel: contract to add
        [HttpPost("crudeservicespecialservicerequestcreate")]
        public CrudeServiceSpecialServiceRequestModel CrudeServiceSpecialServiceRequestCreate([Bind()] CrudeServiceSpecialServiceRequestModel serviceSpecialServiceRequest) {

            new CrudeServiceSpecialServiceRequestBusiness().Insert(serviceSpecialServiceRequest);

            return serviceSpecialServiceRequest;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeServiceSpecialServiceRequestCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestGroupRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "RequestServiceSpecialServiceRequestRequirementRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ReplyServiceSpecialServiceRequestRequirementRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestOperationRuleRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/4/2021 1:35:38 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeServiceSpecialServiceRequest/CrudeServiceSpecialServiceRequestCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeServiceSpecialServiceRequest/CrudeServiceSpecialServiceRequestCreate/", content).Result;

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

        // ppdate ServiceSpecialServiceRequest POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeServiceSpecialServiceRequestModel: contract to add
        [HttpPut("crudeservicespecialservicerequestupdate")]
        public CrudeServiceSpecialServiceRequestModel CrudeServiceSpecialServiceRequestUpdate([Bind()] CrudeServiceSpecialServiceRequestModel serviceSpecialServiceRequest) {

            new CrudeServiceSpecialServiceRequestBusiness().Update(serviceSpecialServiceRequest);

            return serviceSpecialServiceRequest;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeServiceSpecialServiceRequestUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestGroupRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "RequestServiceSpecialServiceRequestRequirementRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ReplyServiceSpecialServiceRequestRequirementRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ServiceSpecialServiceRequestOperationRuleRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/4/2021 1:35:38 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeServiceSpecialServiceRequest/CrudeServiceSpecialServiceRequestUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeServiceSpecialServiceRequest/CrudeServiceSpecialServiceRequestUpdate/", content).Result;

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
        [HttpDelete("servicespecialservicerequestdelete/{servicespecialservicerequestid?}")]
        public void CrudeServiceSpecialServiceRequestDelete(System.Guid serviceSpecialServiceRequestId) {

            new CrudeServiceSpecialServiceRequestBusiness().Delete(serviceSpecialServiceRequestId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeServiceSpecialServiceRequestDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeServiceSpecialServiceRequest/CrudeServiceSpecialServiceRequestDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
