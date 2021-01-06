/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:45:58 AM
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
    // this class start with an identical representation of a ansi sql select statement in ServicePackagePromotionWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ServicePackagePromotionWithFilterData {
        
        public string ServicePackageName { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public string ClientName { get; set; }
        
        public decimal PromotionPriceAmount { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ServicePackagePromotionId { get; set; }
        
        public System.Guid ServicePackageId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ServicePackagePromotionWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ServicePackageName)) ServicePackageName = reader.GetString(ordinals.ServicePackageName);
            if (!reader.IsDBNull(ordinals.ClientId)) ClientId = reader.GetGuid(ordinals.ClientId);
            if (!reader.IsDBNull(ordinals.ClientName)) ClientName = reader.GetString(ordinals.ClientName);
            if (!reader.IsDBNull(ordinals.PromotionPriceAmount)) PromotionPriceAmount = reader.GetDecimal(ordinals.PromotionPriceAmount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ServicePackagePromotionId)) ServicePackagePromotionId = reader.GetGuid(ordinals.ServicePackagePromotionId);
            if (!reader.IsDBNull(ordinals.ServicePackageId)) ServicePackageId = reader.GetGuid(ordinals.ServicePackageId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in ServicePackagePromotionWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ServicePackagePromotionWithFilterDataOrdinals {
        
        public int ServicePackageName;
        
        public int ClientId;
        
        public int ClientName;
        
        public int PromotionPriceAmount;
        
        public int FinancialCurrencyId;
        
        public int FinancialCurrencyTypeName;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int ServicePackagePromotionId;
        
        public int ServicePackageId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ServicePackagePromotionWithFilterDataOrdinals(IDataReader reader) {
            ServicePackageName = reader.GetOrdinal("service_package_name");
            ClientId = reader.GetOrdinal("client_id");
            ClientName = reader.GetOrdinal("client_name");
            PromotionPriceAmount = reader.GetOrdinal("promotion_price_amount");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            ServicePackagePromotionId = reader.GetOrdinal("service_package_promotion_id");
            ServicePackageId = reader.GetOrdinal("service_package_id");
        }
    }
}
