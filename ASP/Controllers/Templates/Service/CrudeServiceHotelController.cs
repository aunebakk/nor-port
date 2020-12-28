﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:31:45 PM
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
    [Route("api/1/crudeservicehotel")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/cebddfc4-5dd6-4651-a217-1c7697d48c61
    public class CrudeServiceHotelController : Controller {

        // help page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        [HttpGet("help/")]
        public IActionResult CrudeServiceHotelHelp(
            ) {

            return View(@"Views\Templates\Service\CrudeServiceHotel.cshtml");
        }

        // fetch all page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/949b0295-718b-4eaf-8118-083f50045ec5
        [HttpGet("fetchall")]
        public IEnumerable<CrudeServiceHotelModel> CrudeServiceHotelFetchAll() {

            List<CrudeServiceHotelModel> serviceHotels = 
                new CrudeServiceHotelBusiness().FetchAll();

            return serviceHotels;
        }

        // fetch all count page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29cc8429-6a4e-4854-91dc-9ad3027eb3d0
        [HttpGet("fetchallcount")]
        public int CrudeServiceHotelFetchAllCount() {

            return new CrudeServiceHotelBusiness().FetchAllCount();
        }

        // fetch all with limit page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/2eda6a92-1bc1-43d8-9285-87d26d50f574
        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeServiceHotelModel> CrudeServiceHotelFetchAllWithLimit(
                string limit
                ) {

            List<CrudeServiceHotelModel> serviceHotels = 
                new CrudeServiceHotelBusiness().FetchAllWithLimit(limit);

            return serviceHotels;
        }

        // fetch all with limit and offset page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/320ad742-0b46-4155-a5c9-2a82277b1f96
        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeServiceHotelModel> CrudeServiceHotelFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeServiceHotelModel> serviceHotels = 
                new CrudeServiceHotelBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return serviceHotels;
        }

        // fetch by primary key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/b08faa47-a306-4a01-99f5-1125963b5d47
        [HttpGet("fetchbyservicehotelid/{servicehotelid?}")]
        public CrudeServiceHotelModel CrudeServiceHotelFetchByServiceHotelId(System.Guid servicehotelid) {

            CrudeServiceHotelModel serviceHotel = 
                new CrudeServiceHotelBusiness().FetchByServiceHotelId(servicehotelid);

            return serviceHotel;
        }

        // fetch by foreign key (simple) page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/82335188-ebea-40e3-a07d-094026340e92
        [HttpGet("fetchbyhotelname/{hotelname?}")]
        public CrudeServiceHotelModel CrudeServiceHotelFetchByHotelName(System.String hotelname) {

            CrudeServiceHotelModel serviceHotel = 
                new CrudeServiceHotelBusiness().FetchByHotelName(hotelname);

            return serviceHotel;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeServiceHotelModel> CrudeServiceHotelFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeServiceHotelModel> serviceHotel = 
                new CrudeServiceHotelBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return serviceHotel;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyaddressid/{addressid?}")]
        public IEnumerable<CrudeServiceHotelModel> CrudeServiceHotelFetchByAddressId(System.Guid addressid) {

            List<CrudeServiceHotelModel> serviceHotel = 
                new CrudeServiceHotelBusiness().FetchByAddressId(addressid);

            return serviceHotel;
        }

        // fetch by foreign key page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/eab9ad20-fad5-4bde-8f34-a84e2b1e2a18
        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeServiceHotelModel> CrudeServiceHotelFetchByProductId(System.Guid productid) {

            List<CrudeServiceHotelModel> serviceHotel = 
                new CrudeServiceHotelBusiness().FetchByProductId(productid);

            return serviceHotel;
        }

        // create POST page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/fa6b4ff5-5a11-4563-b6de-449d1bb6a5e7
        [HttpPost("crudeservicehotelcreate")]
        public CrudeServiceHotelModel CrudeServiceHotelCreate([Bind()] CrudeServiceHotelModel serviceHotel) {

            new CrudeServiceHotelBusiness().Insert(serviceHotel);

            return serviceHotel;
        }

        // create POST test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/96b8b62a-7bd6-4e9b-a1b4-c10a4b027dc5
        [HttpGet("createtest")]
        public string CrudeServiceHotelCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "HotelName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:31:45 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeServiceHotel/CrudeServiceHotelCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeServiceHotel/CrudeServiceHotelCreate/", content).Result;

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
        [HttpPut("crudeservicehotelupdate")]
        public CrudeServiceHotelModel CrudeServiceHotelUpdate([Bind()] CrudeServiceHotelModel serviceHotel) {

            new CrudeServiceHotelBusiness().Update(serviceHotel);

            return serviceHotel;
        }

        // update test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8f62f04e-393c-4162-b1c1-0b0aa12c5fe9
        [HttpGet("updatetest")]
        public string CrudeServiceHotelUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "HotelName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "12/27/2020 11:31:45 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeServiceHotel/CrudeServiceHotelUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPortCore.azurewebsites.net/api/1/CrudeServiceHotel/CrudeServiceHotelUpdate/", content).Result;

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
        [HttpDelete("servicehoteldelete/{servicehotelid?}")]
        public void CrudeServiceHotelDelete(System.Guid serviceHotelId) {

            new CrudeServiceHotelBusiness().Delete(serviceHotelId);
        }

        // delete test page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/1b411c05-2eda-44e5-99ef-733fd609cead
        [HttpGet("deletetest")]
        public string CrudeServiceHotelDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeServiceHotel/CrudeServiceHotelDelete/00000000-0000-0000-0000-000000000001" ).Result;

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