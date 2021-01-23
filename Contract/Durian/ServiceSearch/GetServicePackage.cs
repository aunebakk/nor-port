﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:54:14 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetServicePackage's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class GetServicePackageContract {
        
        [DataMember()]
        public string ServicePackageName { get; set; }
        
        [DataMember()]
        public System.Guid ServiceHotelId { get; set; }
        
        [DataMember()]
        public string HotelName { get; set; }
        
        [DataMember()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        [DataMember()]
        public string ServiceSpecialServiceRequestName { get; set; }
        
        [DataMember()]
        public System.Guid ServiceCarRentalId { get; set; }
        
        [DataMember()]
        public string CarName { get; set; }
        
        [DataMember()]
        public System.Guid DepartureAirportId { get; set; }
        
        [DataMember()]
        public string DepartureAirportName { get; set; }
        
        [DataMember()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [DataMember()]
        public string ArrivalAirportName { get; set; }
        
        [DataMember()]
        public int StayDurationDays { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid ServicePackageId { get; set; }
    }
}
