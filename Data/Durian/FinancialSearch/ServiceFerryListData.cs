/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 7:14:41 PM
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
    // this class start with an identical representation of a ansi sql select statement in ServiceFerryListData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ServiceFerryListData {
        
        public string FerryName { get; set; }
        
        public decimal Amount { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public System.Guid FerryId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public System.Guid ServiceFerryId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ServiceFerryListDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FerryName)) FerryName = reader.GetString(ordinals.FerryName);
            if (!reader.IsDBNull(ordinals.Amount)) Amount = reader.GetDecimal(ordinals.Amount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.FerryId)) FerryId = reader.GetGuid(ordinals.FerryId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ServiceFerryId)) ServiceFerryId = reader.GetGuid(ordinals.ServiceFerryId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in ServiceFerryListData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ServiceFerryListDataOrdinals {
        
        public int FerryName;
        
        public int Amount;
        
        public int FinancialCurrencyTypeName;
        
        public int FerryId;
        
        public int ProductId;
        
        public int ServiceFerryId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ServiceFerryListDataOrdinals(IDataReader reader) {
            FerryName = reader.GetOrdinal("ferry_name");
            Amount = reader.GetOrdinal("amount");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            FerryId = reader.GetOrdinal("ferry_id");
            ProductId = reader.GetOrdinal("product_id");
            ServiceFerryId = reader.GetOrdinal("service_ferry_id");
        }
    }
}
