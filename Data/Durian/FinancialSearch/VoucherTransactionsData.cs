/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:48:25 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPort.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in VoucherTransactionsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class VoucherTransactionsData {
        
        public int VoucherNumber { get; set; }
        
        public string VoucherDescription { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public decimal PaidCurrencyAmount { get; set; }
        
        public string PaidCurrencyType { get; set; }
        
        public decimal ExchangeRate { get; set; }
        
        public decimal BookingCurrencyAmount { get; set; }
        
        public string BookingCurrencyType { get; set; }
        
        public string FinancialCostcentreCode { get; set; }
        
        public string FinancialCostcentreName { get; set; }
        
        public string DefaultUserCode { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid FinancialPaymentId { get; set; }
        
        public System.Guid BookingId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, VoucherTransactionsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.VoucherNumber)) VoucherNumber = reader.GetInt32(ordinals.VoucherNumber);
            if (!reader.IsDBNull(ordinals.VoucherDescription)) VoucherDescription = reader.GetString(ordinals.VoucherDescription);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.PaidCurrencyAmount)) PaidCurrencyAmount = reader.GetDecimal(ordinals.PaidCurrencyAmount);
            if (!reader.IsDBNull(ordinals.PaidCurrencyType)) PaidCurrencyType = reader.GetString(ordinals.PaidCurrencyType);
            if (!reader.IsDBNull(ordinals.ExchangeRate)) ExchangeRate = reader.GetDecimal(ordinals.ExchangeRate);
            if (!reader.IsDBNull(ordinals.BookingCurrencyAmount)) BookingCurrencyAmount = reader.GetDecimal(ordinals.BookingCurrencyAmount);
            if (!reader.IsDBNull(ordinals.BookingCurrencyType)) BookingCurrencyType = reader.GetString(ordinals.BookingCurrencyType);
            if (!reader.IsDBNull(ordinals.FinancialCostcentreCode)) FinancialCostcentreCode = reader.GetString(ordinals.FinancialCostcentreCode);
            if (!reader.IsDBNull(ordinals.FinancialCostcentreName)) FinancialCostcentreName = reader.GetString(ordinals.FinancialCostcentreName);
            if (!reader.IsDBNull(ordinals.DefaultUserCode)) DefaultUserCode = reader.GetString(ordinals.DefaultUserCode);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.FinancialPaymentId)) FinancialPaymentId = reader.GetGuid(ordinals.FinancialPaymentId);
            if (!reader.IsDBNull(ordinals.BookingId)) BookingId = reader.GetGuid(ordinals.BookingId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in VoucherTransactionsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class VoucherTransactionsDataOrdinals {
        
        public int VoucherNumber;
        
        public int VoucherDescription;
        
        public int DateTime;
        
        public int PaidCurrencyAmount;
        
        public int PaidCurrencyType;
        
        public int ExchangeRate;
        
        public int BookingCurrencyAmount;
        
        public int BookingCurrencyType;
        
        public int FinancialCostcentreCode;
        
        public int FinancialCostcentreName;
        
        public int DefaultUserCode;
        
        public int DefaultUserName;
        
        public int FinancialPaymentId;
        
        public int BookingId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public VoucherTransactionsDataOrdinals(IDataReader reader) {
            VoucherNumber = reader.GetOrdinal("voucher_number");
            VoucherDescription = reader.GetOrdinal("voucher_description");
            DateTime = reader.GetOrdinal("date_time");
            PaidCurrencyAmount = reader.GetOrdinal("paid_currency_amount");
            PaidCurrencyType = reader.GetOrdinal("paid_currency_type");
            ExchangeRate = reader.GetOrdinal("exchange_rate");
            BookingCurrencyAmount = reader.GetOrdinal("booking_currency_amount");
            BookingCurrencyType = reader.GetOrdinal("booking_currency_type");
            FinancialCostcentreCode = reader.GetOrdinal("financial_costcentre_code");
            FinancialCostcentreName = reader.GetOrdinal("financial_costcentre_name");
            DefaultUserCode = reader.GetOrdinal("default_user_code");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            FinancialPaymentId = reader.GetOrdinal("financial_payment_id");
            BookingId = reader.GetOrdinal("booking_id");
        }
    }
}
