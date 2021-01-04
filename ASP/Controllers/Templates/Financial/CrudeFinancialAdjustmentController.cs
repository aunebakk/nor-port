/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 2:54:41 AM
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
    [Route("api/1/crudefinancialadjustment")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeFinancialAdjustmentController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeFinancialAdjustmentHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialAdjustment.cshtml");
        }

        // fetch all API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchAll() {

            List<CrudeFinancialAdjustmentModel> financialAdjustments = 
                new CrudeFinancialAdjustmentBusiness().FetchAll();

            return financialAdjustments;
        }

        // fetch all count API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeFinancialAdjustmentFetchAllCount() {

            return new CrudeFinancialAdjustmentBusiness().FetchAllCount();
        }

        // fetch all with limit API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        // parameters:
        //  limit: only return this number of rows
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialAdjustmentModel> financialAdjustments = 
                new CrudeFinancialAdjustmentBusiness().FetchAllWithLimit(limit);

            return financialAdjustments;
        }

        // fetch all with limit and offset API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        // parameters:
        //  limit: only return this number of rows
        //   offset: start from this offset of rows
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialAdjustmentModel> financialAdjustments = 
                new CrudeFinancialAdjustmentBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialAdjustments;
        }

        // fetch by primary key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        // parameters:
        //  financialadjustmentid: filter by primary key
        [HttpGet("fetchbyfinancialadjustmentid/{financialadjustmentid?}")]
        public CrudeFinancialAdjustmentModel CrudeFinancialAdjustmentFetchByFinancialAdjustmentId(System.Guid financialadjustmentid) {

            CrudeFinancialAdjustmentModel financialAdjustment = 
                new CrudeFinancialAdjustmentBusiness().FetchByFinancialAdjustmentId(financialadjustmentid);

            return financialAdjustment;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  financialadjustmenttypercd: filter by this foreign this key, use the following for no filter: ''
        [HttpGet("fetchbyfinancialadjustmenttypercd/{financialadjustmenttypercd?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchByFinancialAdjustmentTypeRcd(System.String financialadjustmenttypercd) {

            List<CrudeFinancialAdjustmentModel> financialAdjustment = 
                new CrudeFinancialAdjustmentBusiness().FetchByFinancialAdjustmentTypeRcd(financialadjustmenttypercd);

            return financialAdjustment;
        }

        // fetch by foreign key API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        // parameters:
        //  financialcurrencyid: filter by this foreign this key, use the following for no filter: '00000000-0000-0000-0000-000000000000'
        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialAdjustmentModel> financialAdjustment = 
                new CrudeFinancialAdjustmentBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialAdjustment;
        }

        // create FinancialAdjustment POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        // parameters:
        //  CrudeFinancialAdjustmentModel: contract to add
        [HttpPost("crudefinancialadjustmentcreate")]
        public CrudeFinancialAdjustmentModel CrudeFinancialAdjustmentCreate([Bind()] CrudeFinancialAdjustmentModel financialAdjustment) {

            new CrudeFinancialAdjustmentBusiness().Insert(financialAdjustment);

            return financialAdjustment;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeFinancialAdjustmentCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/4/2021 2:54:41 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentCreate/", content).Result;

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

        // ppdate FinancialAdjustment POST API for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/5c88b29b-595f-4435-b8cd-6db26d0f958d
        // parameters:
        //  CrudeFinancialAdjustmentModel: contract to add
        [HttpPut("crudefinancialadjustmentupdate")]
        public CrudeFinancialAdjustmentModel CrudeFinancialAdjustmentUpdate([Bind()] CrudeFinancialAdjustmentModel financialAdjustment) {

            new CrudeFinancialAdjustmentBusiness().Update(financialAdjustment);

            return financialAdjustment;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeFinancialAdjustmentUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/4/2021 2:54:41 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentUpdate/", content).Result;

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
        [HttpDelete("financialadjustmentdelete/{financialadjustmentid?}")]
        public void CrudeFinancialAdjustmentDelete(System.Guid financialAdjustmentId) {

            new CrudeFinancialAdjustmentBusiness().Delete(financialAdjustmentId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeFinancialAdjustmentDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://NorSolutionPort.AzureWebSites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
