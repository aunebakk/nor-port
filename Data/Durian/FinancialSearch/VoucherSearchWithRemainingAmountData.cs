/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 5:50:34 AM
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
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPort.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in VoucherSearchWithRemainingAmountData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class VoucherSearchWithRemainingAmountData {
        
        public System.Guid FinancialVoucherId { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public int VoucherNumber { get; set; }
        
        public string VoucherDescription { get; set; }
        
        public decimal RemainingAmount { get; set; }
        
        public string FinancialCurrencyTypeCode { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public System.DateTime ValidFromDateTime { get; set; }
        
        public System.DateTime ValidUntilDateTime { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, VoucherSearchWithRemainingAmountDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FinancialVoucherId)) FinancialVoucherId = reader.GetGuid(ordinals.FinancialVoucherId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.VoucherNumber)) VoucherNumber = reader.GetInt32(ordinals.VoucherNumber);
            if (!reader.IsDBNull(ordinals.VoucherDescription)) VoucherDescription = reader.GetString(ordinals.VoucherDescription);
            if (!reader.IsDBNull(ordinals.RemainingAmount)) RemainingAmount = reader.GetDecimal(ordinals.RemainingAmount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeCode)) FinancialCurrencyTypeCode = reader.GetString(ordinals.FinancialCurrencyTypeCode);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.ValidFromDateTime)) ValidFromDateTime = reader.GetDateTime(ordinals.ValidFromDateTime);
            if (!reader.IsDBNull(ordinals.ValidUntilDateTime)) ValidUntilDateTime = reader.GetDateTime(ordinals.ValidUntilDateTime);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in VoucherSearchWithRemainingAmountData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class VoucherSearchWithRemainingAmountDataOrdinals {
        
        public int FinancialVoucherId;
        
        public int FinancialCurrencyId;
        
        public int VoucherNumber;
        
        public int VoucherDescription;
        
        public int RemainingAmount;
        
        public int FinancialCurrencyTypeCode;
        
        public int FinancialCurrencyTypeName;
        
        public int ValidFromDateTime;
        
        public int ValidUntilDateTime;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public VoucherSearchWithRemainingAmountDataOrdinals(IDataReader reader) {
            FinancialVoucherId = reader.GetOrdinal("financial_voucher_id");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            VoucherNumber = reader.GetOrdinal("voucher_number");
            VoucherDescription = reader.GetOrdinal("voucher_description");
            RemainingAmount = reader.GetOrdinal("remaining_amount");
            FinancialCurrencyTypeCode = reader.GetOrdinal("financial_currency_type_code");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            ValidFromDateTime = reader.GetOrdinal("valid_from_date_time");
            ValidUntilDateTime = reader.GetOrdinal("valid_until_date_time");
        }
    }
}
