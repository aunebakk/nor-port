/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 3:16:42 AM
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
    // this class start with an identical representation of a ansi sql select statement in GetServicePackageData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class GetServicePackageData {
        
        public string ServicePackageName { get; set; }
        
        public System.Guid ServiceHotelId { get; set; }
        
        public string HotelName { get; set; }
        
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        public string ServiceSpecialServiceRequestName { get; set; }
        
        public System.Guid ServiceCarRentalId { get; set; }
        
        public string CarName { get; set; }
        
        public System.Guid DepartureAirportId { get; set; }
        
        public string DepartureAirportName { get; set; }
        
        public System.Guid ArrivalAirportId { get; set; }
        
        public string ArrivalAirportName { get; set; }
        
        public int StayDurationDays { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ServicePackageId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, GetServicePackageDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ServicePackageName)) ServicePackageName = reader.GetString(ordinals.ServicePackageName);
            if (!reader.IsDBNull(ordinals.ServiceHotelId)) ServiceHotelId = reader.GetGuid(ordinals.ServiceHotelId);
            if (!reader.IsDBNull(ordinals.HotelName)) HotelName = reader.GetString(ordinals.HotelName);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestId)) ServiceSpecialServiceRequestId = reader.GetGuid(ordinals.ServiceSpecialServiceRequestId);
            if (!reader.IsDBNull(ordinals.ServiceSpecialServiceRequestName)) ServiceSpecialServiceRequestName = reader.GetString(ordinals.ServiceSpecialServiceRequestName);
            if (!reader.IsDBNull(ordinals.ServiceCarRentalId)) ServiceCarRentalId = reader.GetGuid(ordinals.ServiceCarRentalId);
            if (!reader.IsDBNull(ordinals.CarName)) CarName = reader.GetString(ordinals.CarName);
            if (!reader.IsDBNull(ordinals.DepartureAirportId)) DepartureAirportId = reader.GetGuid(ordinals.DepartureAirportId);
            if (!reader.IsDBNull(ordinals.DepartureAirportName)) DepartureAirportName = reader.GetString(ordinals.DepartureAirportName);
            if (!reader.IsDBNull(ordinals.ArrivalAirportId)) ArrivalAirportId = reader.GetGuid(ordinals.ArrivalAirportId);
            if (!reader.IsDBNull(ordinals.ArrivalAirportName)) ArrivalAirportName = reader.GetString(ordinals.ArrivalAirportName);
            if (!reader.IsDBNull(ordinals.StayDurationDays)) StayDurationDays = reader.GetInt32(ordinals.StayDurationDays);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ServicePackageId)) ServicePackageId = reader.GetGuid(ordinals.ServicePackageId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in GetServicePackageData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class GetServicePackageDataOrdinals {
        
        public int ServicePackageName;
        
        public int ServiceHotelId;
        
        public int HotelName;
        
        public int ServiceSpecialServiceRequestId;
        
        public int ServiceSpecialServiceRequestName;
        
        public int ServiceCarRentalId;
        
        public int CarName;
        
        public int DepartureAirportId;
        
        public int DepartureAirportName;
        
        public int ArrivalAirportId;
        
        public int ArrivalAirportName;
        
        public int StayDurationDays;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int ServicePackageId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public GetServicePackageDataOrdinals(IDataReader reader) {
            ServicePackageName = reader.GetOrdinal("service_package_name");
            ServiceHotelId = reader.GetOrdinal("service_hotel_id");
            HotelName = reader.GetOrdinal("hotel_name");
            ServiceSpecialServiceRequestId = reader.GetOrdinal("service_special_service_request_id");
            ServiceSpecialServiceRequestName = reader.GetOrdinal("service_special_service_request_name");
            ServiceCarRentalId = reader.GetOrdinal("service_car_rental_id");
            CarName = reader.GetOrdinal("car_name");
            DepartureAirportId = reader.GetOrdinal("departure_airport_id");
            DepartureAirportName = reader.GetOrdinal("departure_airport_name");
            ArrivalAirportId = reader.GetOrdinal("arrival_airport_id");
            ArrivalAirportName = reader.GetOrdinal("arrival_airport_name");
            StayDurationDays = reader.GetOrdinal("stay_duration_days");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            ServicePackageId = reader.GetOrdinal("service_package_id");
        }
    }
}
