/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 7:34:53 AM
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
    [Route("api/1/crudefinancialpaymenttyperef")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeFinancialPaymentTypeRefController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentTypeRef.cshtml");
        }

        // fetch all API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentTypeRefModel> CrudeFinancialPaymentTypeRefFetchAll() {

            List<CrudeFinancialPaymentTypeRefModel> financialPaymentTypeRefs = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchAll();

            return financialPaymentTypeRefs;
        }

        // fetch all count API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentTypeRefFetchAllCount() {

            return new CrudeFinancialPaymentTypeRefBusiness().FetchAllCount();
        }

        // fetch all with limit API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentTypeRefModel> CrudeFinancialPaymentTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentTypeRefModel> financialPaymentTypeRefs = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchAllWithLimit(limit);

            return financialPaymentTypeRefs;
        }

        // fetch all with limit and offset API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        // parameters:
        //  limit: only return this number of rows
        //   offset: start from this offset of rows
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentTypeRefModel> CrudeFinancialPaymentTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentTypeRefModel> financialPaymentTypeRefs = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentTypeRefs;
        }

        // fetch by primary key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  financialpaymenttypercd: filter by primary key
        [HttpGet("fetchbyfinancialpaymenttypercd/{financialpaymenttypercd?}")]
        public CrudeFinancialPaymentTypeRefModel CrudeFinancialPaymentTypeRefFetchByFinancialPaymentTypeRcd(System.String financialpaymenttypercd) {

            CrudeFinancialPaymentTypeRefModel financialPaymentTypeRef = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchByFinancialPaymentTypeRcd(financialpaymenttypercd);

            return financialPaymentTypeRef;
        }

        // create FinancialPaymentTypeRef POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeFinancialPaymentTypeRefModel: contract to add
        [HttpPost("crudefinancialpaymenttyperefcreate")]
        public CrudeFinancialPaymentTypeRefModel CrudeFinancialPaymentTypeRefCreate([Bind()] CrudeFinancialPaymentTypeRefModel financialPaymentTypeRef) {

            new CrudeFinancialPaymentTypeRefBusiness().Insert(financialPaymentTypeRef);

            return financialPaymentTypeRef;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeFinancialPaymentTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/5/2021 7:34:53 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefCreate/", content).Result;

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

        // ppdate FinancialPaymentTypeRef POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeFinancialPaymentTypeRefModel: contract to add
        [HttpPut("crudefinancialpaymenttyperefupdate")]
        public CrudeFinancialPaymentTypeRefModel CrudeFinancialPaymentTypeRefUpdate([Bind()] CrudeFinancialPaymentTypeRefModel financialPaymentTypeRef) {

            new CrudeFinancialPaymentTypeRefBusiness().Update(financialPaymentTypeRef);

            return financialPaymentTypeRef;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/5/2021 7:34:53 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefUpdate/", content).Result;

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
        [HttpDelete("financialpaymenttyperefdelete/{financialpaymenttypercd?}")]
        public void CrudeFinancialPaymentTypeRefDelete(System.String financialPaymentTypeRcd) {

            new CrudeFinancialPaymentTypeRefBusiness().Delete(financialPaymentTypeRcd);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
