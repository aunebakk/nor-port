﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 4:45:18 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/89dc5b67-2bf9-4c88-8911-c3b6294c3a64
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class serves as a data access contract between c# and sql server
    // this class start with an identical representation of CrudeAirport's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/ceb39174-f927-4fd8-8396-5ec4d04ea471
    [DataContract()]
    public partial class CrudeAirportContract {
        
        [DataMember()]
        public System.Guid AirportId { get; set; }
        
        [DataMember()]
        public string AirportName { get; set; }
        
        [DataMember()]
        public string AirportTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid CityId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public decimal UtcOffset { get; set; }
        
        [DataMember()]
        public decimal ElevationInMeters { get; set; }
        
        [DataMember()]
        public decimal RunwayInMeters { get; set; }
        
        [DataMember()]
        public string Latitude { get; set; }
        
        [DataMember()]
        public string Longitude { get; set; }
        
        [DataMember()]
        public System.Guid TimezoneId { get; set; }
        
        [DataMember()]
        public string Variation { get; set; }
        
        [DataMember()]
        public string Attendance { get; set; }
        
        [DataMember()]
        public bool ControlTowerFlag { get; set; }
        
        [DataMember()]
        public System.DateTime ActivationDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
