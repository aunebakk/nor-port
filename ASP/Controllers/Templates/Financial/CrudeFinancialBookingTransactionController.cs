/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:11:01 AM
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
    [Route("api/1/crudefinancialbookingtransaction")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeFinancialBookingTransactionController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeFinancialBookingTransactionHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialBookingTransaction.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchAll() {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransactions = 
                new CrudeFinancialBookingTransactionBusiness().FetchAll();

            return financialBookingTransactions;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeFinancialBookingTransactionFetchAllCount() {

            return new CrudeFinancialBookingTransactionBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransactions = 
                new CrudeFinancialBookingTransactionBusiness().FetchAllWithLimit(limit);

            return financialBookingTransactions;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransactions = 
                new CrudeFinancialBookingTransactionBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialBookingTransactions;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyfinancialbookingtransactionid/{financialbookingtransactionid?}")]
        public CrudeFinancialBookingTransactionModel CrudeFinancialBookingTransactionFetchByFinancialBookingTransactionId(System.Guid financialbookingtransactionid) {

            CrudeFinancialBookingTransactionModel financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialBookingTransactionId(financialbookingtransactionid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbybookingid/{bookingid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByBookingId(System.Guid bookingid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByBookingId(bookingid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialbookingtransactiontypercd/{financialbookingtransactiontypercd?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialBookingTransactionTypeRcd(System.String financialbookingtransactiontypercd) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialBookingTransactionTypeRcd(financialbookingtransactiontypercd);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialfeeid/{financialfeeid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialFeeId(System.Guid financialfeeid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialFeeId(financialfeeid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialtaxid/{financialtaxid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialTaxId(System.Guid financialtaxid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialTaxId(financialtaxid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialfareid/{financialfareid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialFareId(System.Guid financialfareid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialFareId(financialfareid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialpaymentid/{financialpaymentid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialPaymentId(System.Guid financialpaymentid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialPaymentId(financialpaymentid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialcostcentreid/{financialcostcentreid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialCostcentreId(System.Guid financialcostcentreid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialCostcentreId(financialcostcentreid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialadjustmentid/{financialadjustmentid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialAdjustmentId(System.Guid financialadjustmentid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialAdjustmentId(financialadjustmentid);

            return financialBookingTransaction;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialserviceid/{financialserviceid?}")]
        public IEnumerable<CrudeFinancialBookingTransactionModel> CrudeFinancialBookingTransactionFetchByFinancialServiceId(System.Guid financialserviceid) {

            List<CrudeFinancialBookingTransactionModel> financialBookingTransaction = 
                new CrudeFinancialBookingTransactionBusiness().FetchByFinancialServiceId(financialserviceid);

            return financialBookingTransaction;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudefinancialbookingtransactioncreate")]
        public CrudeFinancialBookingTransactionModel CrudeFinancialBookingTransactionCreate([Bind()] CrudeFinancialBookingTransactionModel financialBookingTransaction) {

            new CrudeFinancialBookingTransactionBusiness().Insert(financialBookingTransaction);

            return financialBookingTransaction;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeFinancialBookingTransactionCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "TransactionNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBookingTransactionTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 8:11:01 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialBookingTransaction/CrudeFinancialBookingTransactionCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialBookingTransaction/CrudeFinancialBookingTransactionCreate/", content).Result;

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
        [HttpPut("crudefinancialbookingtransactionupdate")]
        public CrudeFinancialBookingTransactionModel CrudeFinancialBookingTransactionUpdate([Bind()] CrudeFinancialBookingTransactionModel financialBookingTransaction) {

            new CrudeFinancialBookingTransactionBusiness().Update(financialBookingTransaction);

            return financialBookingTransaction;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeFinancialBookingTransactionUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "TransactionNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBookingTransactionTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/28/2020 8:11:01 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialBookingTransaction/CrudeFinancialBookingTransactionUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeFinancialBookingTransaction/CrudeFinancialBookingTransactionUpdate/", content).Result;

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
        [HttpDelete("financialbookingtransactiondelete/{financialbookingtransactionid?}")]
        public void CrudeFinancialBookingTransactionDelete(System.Guid financialBookingTransactionId) {

            new CrudeFinancialBookingTransactionBusiness().Delete(financialBookingTransactionId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeFinancialBookingTransactionDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialBookingTransaction/CrudeFinancialBookingTransactionDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
