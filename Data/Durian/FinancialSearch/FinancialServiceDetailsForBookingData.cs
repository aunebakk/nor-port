/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 2:42:25 PM
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
    // this class start with an identical representation of a ansi sql select statement in FinancialServiceDetailsForBookingData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class FinancialServiceDetailsForBookingData {
        
        public string ServiceTypeName { get; set; }
        
        public string ServiceDescription { get; set; }
        
        public string ServiceRequestStatusName { get; set; }
        
        public decimal ServiceAmount { get; set; }
        
        public string ServiceCurrencyTypeName { get; set; }
        
        public System.Guid BookingServiceRequestId { get; set; }
        
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        public System.Guid ServiceHotelId { get; set; }
        
        public System.Guid ServiceCarRentalId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, FinancialServiceDetailsForBookingDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ServiceTypeName)) ServiceTypeName = reader.GetString(ordinals.ServiceTypeName);
            if (!reader.IsDBNull(ordinals.ServiceDescription)) ServiceDescription = reader.GetString(ordinals.ServiceDescription);
            if (!reader.IsDBNull(ordinals.ServiceRequestStatusName)) ServiceRequestStatusName = reader.GetString(ordinals.ServiceRequestStatusName);
            if (!reader.IsDBNull(ordinals.ServiceAmount)) ServiceAmount = reader.GetDecimal(ordinals.ServiceAmount);
            if (!reader.IsDBNull(ordinals.ServiceCurrencyTypeName)) ServiceCurrencyTypeName = reader.GetString(ordinals.ServiceCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.BookingServiceRequestId)) BookingServiceRequestId = reader.GetGuid(ordinals.BookingServiceRequestId);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestId)) ServiceSpecialServiceRequestId = reader.GetGuid(ordinals.ServiceSpecialServiceRequestId);
            if (!reader.IsDBNull(ordinals.ServiceHotelId)) ServiceHotelId = reader.GetGuid(ordinals.ServiceHotelId);
            if (!reader.IsDBNull(ordinals.ServiceCarRentalId)) ServiceCarRentalId = reader.GetGuid(ordinals.ServiceCarRentalId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in FinancialServiceDetailsForBookingData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class FinancialServiceDetailsForBookingDataOrdinals {
        
        public int ServiceTypeName;
        
        public int ServiceDescription;
        
        public int ServiceRequestStatusName;
        
        public int ServiceAmount;
        
        public int ServiceCurrencyTypeName;
        
        public int BookingServiceRequestId;
        
        public int ServiceSpecialServiceRequestId;
        
        public int ServiceHotelId;
        
        public int ServiceCarRentalId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public FinancialServiceDetailsForBookingDataOrdinals(IDataReader reader) {
            ServiceTypeName = reader.GetOrdinal("service_type_name");
            ServiceDescription = reader.GetOrdinal("service_description");
            ServiceRequestStatusName = reader.GetOrdinal("service_request_status_name");
            ServiceAmount = reader.GetOrdinal("service_amount");
            ServiceCurrencyTypeName = reader.GetOrdinal("service_currency_type_name");
            BookingServiceRequestId = reader.GetOrdinal("booking_service_request_id");
            ServiceSpecialServiceRequestId = reader.GetOrdinal("service_special_service_request_id");
            ServiceHotelId = reader.GetOrdinal("service_hotel_id");
            ServiceCarRentalId = reader.GetOrdinal("service_car_rental_id");
        }
    }
}
