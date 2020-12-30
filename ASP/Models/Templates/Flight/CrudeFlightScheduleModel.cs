/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:11:57 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
// Namespace for the Business Logic Layer
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this class is used to carry Model POCO classes
    // this class is used to carry Model POCO classes
    // this class is used to carry Model POCO classes
    // links:
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeFlightScheduleModel {
        
        [Display(Name="Flight Schedule Id")]
        [Required()]
        public System.Guid FlightScheduleId { get; set; }
        
        [Display(Name="Became Flight Schedule Id")]
        [Required()]
        public System.Guid BecameFlightScheduleId { get; set; }
        
        [Display(Name="Binding Flight Schedule Id")]
        [Required()]
        public System.Guid BindingFlightScheduleId { get; set; }
        
        [Display(Name="Airline Id")]
        [Required()]
        public System.Guid AirlineId { get; set; }
        
        [Display(Name="Aircraft Type")]
        [Required()]
        public string AircraftTypeRcd { get; set; }
        
        [Display(Name="Departure Airport Id")]
        [Required()]
        public System.Guid DepartureAirportId { get; set; }
        
        [Display(Name="Arrival Airport Id")]
        [Required()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; }
        
        [Display(Name="From Date Time")]
        [Required()]
        public System.DateTime FromDateTime { get; set; }
        
        [Display(Name="Until Date Time")]
        [Required()]
        public System.DateTime UntilDateTime { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
