/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:35:46 PM
  From Machine: DESKTOP-9A2DH39
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
    // this class start with an identical representation of a ansi sql select statement in BookingFinancialTransactionsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class BookingFinancialTransactionsData {
        
        public int TransactionNumber { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string TransactionType { get; set; }
        
        public string TypeName { get; set; }
        
        public decimal DebitAmount { get; set; }
        
        public decimal CreditAmount { get; set; }
        
        public string FinancialCurrencyTypeRcd { get; set; }
        
        public string FinancialCostcentreCode { get; set; }
        
        public string FinancialCostcentreName { get; set; }
        
        public string DefaultUserCode { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid BookingId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, BookingFinancialTransactionsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.TransactionNumber)) TransactionNumber = reader.GetInt32(ordinals.TransactionNumber);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.TransactionType)) TransactionType = reader.GetString(ordinals.TransactionType);
            if (!reader.IsDBNull(ordinals.TypeName)) TypeName = reader.GetString(ordinals.TypeName);
            if (!reader.IsDBNull(ordinals.DebitAmount)) DebitAmount = reader.GetDecimal(ordinals.DebitAmount);
            if (!reader.IsDBNull(ordinals.CreditAmount)) CreditAmount = reader.GetDecimal(ordinals.CreditAmount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeRcd)) FinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCostcentreCode)) FinancialCostcentreCode = reader.GetString(ordinals.FinancialCostcentreCode);
            if (!reader.IsDBNull(ordinals.FinancialCostcentreName)) FinancialCostcentreName = reader.GetString(ordinals.FinancialCostcentreName);
            if (!reader.IsDBNull(ordinals.DefaultUserCode)) DefaultUserCode = reader.GetString(ordinals.DefaultUserCode);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.BookingId)) BookingId = reader.GetGuid(ordinals.BookingId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in BookingFinancialTransactionsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class BookingFinancialTransactionsDataOrdinals {
        
        public int TransactionNumber;
        
        public int DateTime;
        
        public int TransactionType;
        
        public int TypeName;
        
        public int DebitAmount;
        
        public int CreditAmount;
        
        public int FinancialCurrencyTypeRcd;
        
        public int FinancialCostcentreCode;
        
        public int FinancialCostcentreName;
        
        public int DefaultUserCode;
        
        public int DefaultUserName;
        
        public int BookingId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public BookingFinancialTransactionsDataOrdinals(IDataReader reader) {
            TransactionNumber = reader.GetOrdinal("transaction_number");
            DateTime = reader.GetOrdinal("date_time");
            TransactionType = reader.GetOrdinal("transaction_type");
            TypeName = reader.GetOrdinal("type_name");
            DebitAmount = reader.GetOrdinal("debit_amount");
            CreditAmount = reader.GetOrdinal("credit_amount");
            FinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_type_rcd");
            FinancialCostcentreCode = reader.GetOrdinal("financial_costcentre_code");
            FinancialCostcentreName = reader.GetOrdinal("financial_costcentre_name");
            DefaultUserCode = reader.GetOrdinal("default_user_code");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            BookingId = reader.GetOrdinal("booking_id");
        }
    }
}
