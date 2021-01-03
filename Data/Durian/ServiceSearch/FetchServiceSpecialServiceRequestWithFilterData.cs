/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:12:25 PM
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
    // this class start with an identical representation of a ansi sql select statement in FetchServiceSpecialServiceRequestWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class FetchServiceSpecialServiceRequestWithFilterData {
        
        public string ServiceSpecialServiceRequestGroupRcd { get; set; }
        
        public string ServiceSpecialServiceRequestGroupName { get; set; }
        
        public string ServiceSpecialServiceRequestCode { get; set; }
        
        public string ServiceSpecialServiceRequestName { get; set; }
        
        public string ServiceDescription { get; set; }
        
        public decimal Amount { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public bool InventoryControlledFlag { get; set; }
        
        public string RequestServiceSpecialServiceRequestRequirementRcd { get; set; }
        
        public string RequestRequirementName { get; set; }
        
        public string ReplyServiceSpecialServiceRequestRequirementRcd { get; set; }
        
        public string ReplyRequirementName { get; set; }
        
        public string ServiceSpecialServiceRequestOperationRuleRcd { get; set; }
        
        public string ServiceSpecialServiceRequestOperationRuleName { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, FetchServiceSpecialServiceRequestWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestGroupRcd)) ServiceSpecialServiceRequestGroupRcd = reader.GetString(ordinals.ServiceSpecialServiceRequestGroupRcd);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestGroupName)) ServiceSpecialServiceRequestGroupName = reader.GetString(ordinals.ServiceSpecialServiceRequestGroupName);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestCode)) ServiceSpecialServiceRequestCode = reader.GetString(ordinals.ServiceSpecialServiceRequestCode);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestName)) ServiceSpecialServiceRequestName = reader.GetString(ordinals.ServiceSpecialServiceRequestName);
            if (!reader.IsDBNull(ordinals.ServiceDescription)) ServiceDescription = reader.GetString(ordinals.ServiceDescription);
            if (!reader.IsDBNull(ordinals.Amount)) Amount = reader.GetDecimal(ordinals.Amount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.InventoryControlledFlag)) InventoryControlledFlag = reader.GetBoolean(ordinals.InventoryControlledFlag);
            if (!reader.IsDBNull(ordinals.RequestServiceSpecialServiceRequestRequirementRcd)) RequestServiceSpecialServiceRequestRequirementRcd = reader.GetString(ordinals.RequestServiceSpecialServiceRequestRequirementRcd);
            if (!reader.IsDBNull(ordinals.RequestRequirementName)) RequestRequirementName = reader.GetString(ordinals.RequestRequirementName);
            if (!reader.IsDBNull(ordinals.ReplyServiceSpecialServiceRequestRequirementRcd)) ReplyServiceSpecialServiceRequestRequirementRcd = reader.GetString(ordinals.ReplyServiceSpecialServiceRequestRequirementRcd);
            if (!reader.IsDBNull(ordinals.ReplyRequirementName)) ReplyRequirementName = reader.GetString(ordinals.ReplyRequirementName);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestOperationRuleRcd)) ServiceSpecialServiceRequestOperationRuleRcd = reader.GetString(ordinals.ServiceSpecialServiceRequestOperationRuleRcd);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestOperationRuleName)) ServiceSpecialServiceRequestOperationRuleName = reader.GetString(ordinals.ServiceSpecialServiceRequestOperationRuleName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestId)) ServiceSpecialServiceRequestId = reader.GetGuid(ordinals.ServiceSpecialServiceRequestId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in FetchServiceSpecialServiceRequestWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class FetchServiceSpecialServiceRequestWithFilterDataOrdinals {
        
        public int ServiceSpecialServiceRequestGroupRcd;
        
        public int ServiceSpecialServiceRequestGroupName;
        
        public int ServiceSpecialServiceRequestCode;
        
        public int ServiceSpecialServiceRequestName;
        
        public int ServiceDescription;
        
        public int Amount;
        
        public int FinancialCurrencyId;
        
        public int FinancialCurrencyTypeName;
        
        public int InventoryControlledFlag;
        
        public int RequestServiceSpecialServiceRequestRequirementRcd;
        
        public int RequestRequirementName;
        
        public int ReplyServiceSpecialServiceRequestRequirementRcd;
        
        public int ReplyRequirementName;
        
        public int ServiceSpecialServiceRequestOperationRuleRcd;
        
        public int ServiceSpecialServiceRequestOperationRuleName;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int ServiceSpecialServiceRequestId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public FetchServiceSpecialServiceRequestWithFilterDataOrdinals(IDataReader reader) {
            ServiceSpecialServiceRequestGroupRcd = reader.GetOrdinal("service_special_service_request_group_rcd");
            ServiceSpecialServiceRequestGroupName = reader.GetOrdinal("service_special_service_request_group_name");
            ServiceSpecialServiceRequestCode = reader.GetOrdinal("service_special_service_request_code");
            ServiceSpecialServiceRequestName = reader.GetOrdinal("service_special_service_request_name");
            ServiceDescription = reader.GetOrdinal("service_description");
            Amount = reader.GetOrdinal("amount");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            InventoryControlledFlag = reader.GetOrdinal("inventory_controlled_flag");
            RequestServiceSpecialServiceRequestRequirementRcd = reader.GetOrdinal("request_service_special_service_request_requirement_rcd");
            RequestRequirementName = reader.GetOrdinal("request_requirement_name");
            ReplyServiceSpecialServiceRequestRequirementRcd = reader.GetOrdinal("reply_service_special_service_request_requirement_rcd");
            ReplyRequirementName = reader.GetOrdinal("reply_requirement_name");
            ServiceSpecialServiceRequestOperationRuleRcd = reader.GetOrdinal("service_special_service_request_operation_rule_rcd");
            ServiceSpecialServiceRequestOperationRuleName = reader.GetOrdinal("service_special_service_request_operation_rule_name");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            ServiceSpecialServiceRequestId = reader.GetOrdinal("service_special_service_request_id");
        }
    }
}
