/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:25:59 AM
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
    // this class start with an identical representation of a ansi sql select statement in BookingServiceSummaryData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class BookingServiceSummaryData {
        
        public System.DateTime DateTime { get; set; }
        
        public System.DateTime FromDateTime { get; set; }
        
        public System.DateTime UntilDateTime { get; set; }
        
        public string ServiceTypeName { get; set; }
        
        public string ServiceDescription { get; set; }
        
        public string ServiceRequestStatusName { get; set; }
        
        public decimal ServiceAmount { get; set; }
        
        public string ServiceCurrencyTypeName { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, BookingServiceSummaryDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.FromDateTime)) FromDateTime = reader.GetDateTime(ordinals.FromDateTime);
            if (!reader.IsDBNull(ordinals.UntilDateTime)) UntilDateTime = reader.GetDateTime(ordinals.UntilDateTime);
            if (!reader.IsDBNull(ordinals.ServiceTypeName)) ServiceTypeName = reader.GetString(ordinals.ServiceTypeName);
            if (!reader.IsDBNull(ordinals.ServiceDescription)) ServiceDescription = reader.GetString(ordinals.ServiceDescription);
            if (!reader.IsDBNull(ordinals.ServiceRequestStatusName)) ServiceRequestStatusName = reader.GetString(ordinals.ServiceRequestStatusName);
            if (!reader.IsDBNull(ordinals.ServiceAmount)) ServiceAmount = reader.GetDecimal(ordinals.ServiceAmount);
            if (!reader.IsDBNull(ordinals.ServiceCurrencyTypeName)) ServiceCurrencyTypeName = reader.GetString(ordinals.ServiceCurrencyTypeName);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in BookingServiceSummaryData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class BookingServiceSummaryDataOrdinals {
        
        public int DateTime;
        
        public int FromDateTime;
        
        public int UntilDateTime;
        
        public int ServiceTypeName;
        
        public int ServiceDescription;
        
        public int ServiceRequestStatusName;
        
        public int ServiceAmount;
        
        public int ServiceCurrencyTypeName;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public BookingServiceSummaryDataOrdinals(IDataReader reader) {
            DateTime = reader.GetOrdinal("date_time");
            FromDateTime = reader.GetOrdinal("from_date_time");
            UntilDateTime = reader.GetOrdinal("until_date_time");
            ServiceTypeName = reader.GetOrdinal("service_type_name");
            ServiceDescription = reader.GetOrdinal("service_description");
            ServiceRequestStatusName = reader.GetOrdinal("service_request_status_name");
            ServiceAmount = reader.GetOrdinal("service_amount");
            ServiceCurrencyTypeName = reader.GetOrdinal("service_currency_type_name");
        }
    }
}
