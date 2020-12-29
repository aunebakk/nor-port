/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:15:20 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.DotNetFrameworkBusinessToDotNetFrameworkRestProxy.ProxyMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System.Collections.Generic;
using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

// Namespace for a Business Logic Layer in a Proxy
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer.Proxy {
    // proxy service class for dot net framework
    // links:
    //  docLink: http://sql2x.org/documentationLink/41996556-e83c-47d0-90e1-464b60264260
    public class FinancialSearchServiceClient {
        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/794b5c09-a236-4274-9be6-f25aeaa2ab46
        public List<GetAvailableCurrenciesContract> GetAvailableCurrencies(
            System.Guid financialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/GetAvailableCurrencies?financialCurrencyId={financialCurrencyId}&currencyDateTime={currencyDateTime}";
            string jsonString = client.DownloadString(query);

            List<GetAvailableCurrenciesContract> reply =
                JsonConvert.DeserializeObject<List<GetAvailableCurrenciesContract>>(jsonString);

            return reply;
        }

        public List<FinancialFaresContract> FinancialFares(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/FinancialFares?";
            string jsonString = client.DownloadString(query);

            List<FinancialFaresContract> reply =
                JsonConvert.DeserializeObject<List<FinancialFaresContract>>(jsonString);

            return reply;
        }

        public List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount(
            System.DateTime voucherValidOnDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/VoucherSearchWithRemainingAmount?voucherValidOnDateTime={voucherValidOnDateTime}";
            string jsonString = client.DownloadString(query);

            List<VoucherSearchWithRemainingAmountContract> reply =
                JsonConvert.DeserializeObject<List<VoucherSearchWithRemainingAmountContract>>(jsonString);

            return reply;
        }

        public List<VoucherTransactionsContract> VoucherTransactions(
            System.Guid financialVoucherId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/VoucherTransactions?financialVoucherId={financialVoucherId}";
            string jsonString = client.DownloadString(query);

            List<VoucherTransactionsContract> reply =
                JsonConvert.DeserializeObject<List<VoucherTransactionsContract>>(jsonString);

            return reply;
        }

        public List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking(
            System.Guid bookingId
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/FinancialServiceDetailsForBooking?bookingId={bookingId}";
            string jsonString = client.DownloadString(query);

            List<FinancialServiceDetailsForBookingContract> reply =
                JsonConvert.DeserializeObject<List<FinancialServiceDetailsForBookingContract>>(jsonString);

            return reply;
        }

        public List<ServiceFerryListContract> ServiceFerryList(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/ServiceFerryList?";
            string jsonString = client.DownloadString(query);

            List<ServiceFerryListContract> reply =
                JsonConvert.DeserializeObject<List<ServiceFerryListContract>>(jsonString);

            return reply;
        }

        public List<ServiceCarRentalListContract> ServiceCarRentalList(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/ServiceCarRentalList?";
            string jsonString = client.DownloadString(query);

            List<ServiceCarRentalListContract> reply =
                JsonConvert.DeserializeObject<List<ServiceCarRentalListContract>>(jsonString);

            return reply;
        }

        public List<ServiceHotelListContract> ServiceHotelList(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/ServiceHotelList?";
            string jsonString = client.DownloadString(query);

            List<ServiceHotelListContract> reply =
                JsonConvert.DeserializeObject<List<ServiceHotelListContract>>(jsonString);

            return reply;
        }

        public List<SpecialServiceRequestListContract> SpecialServiceRequestList(
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/SpecialServiceRequestList?";
            string jsonString = client.DownloadString(query);

            List<SpecialServiceRequestListContract> reply =
                JsonConvert.DeserializeObject<List<SpecialServiceRequestListContract>>(jsonString);

            return reply;
        }

        public List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance(
            System.DateTime fromDateTime,
            System.DateTime untilDateTime
            ) {

            WebClient client = new WebClient();

            string query = "http://NorSolutionPortCore.AzureWebSites.net/api/1/FinancialSearchService/TransactionsCreditDebitBalance?fromDateTime={fromDateTime}&untilDateTime={untilDateTime}";
            string jsonString = client.DownloadString(query);

            List<TransactionsCreditDebitBalanceContract> reply =
                JsonConvert.DeserializeObject<List<TransactionsCreditDebitBalanceContract>>(jsonString);

            return reply;
        }

    }
}
