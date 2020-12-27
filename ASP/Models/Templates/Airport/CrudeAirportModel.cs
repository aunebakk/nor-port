/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 6:58:01 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this interface is used to expose Model POCO classes
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeAirportModel {
        
        [Display(Name="Airport Id")]
        [Required()]
        public System.Guid AirportId { get; set; }
        
        [Display(Name="Airport Name")]
        [Required()]
        public string AirportName { get; set; }
        
        [Display(Name="Airport Type")]
        [Required()]
        public string AirportTypeRcd { get; set; }
        
        [Display(Name="City Id")]
        [Required()]
        public System.Guid CityId { get; set; }
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; }
        
        [Display(Name="Utc Offset")]
        [Required()]
        public decimal UtcOffset { get; set; }
        
        [Display(Name="Elevation In Meters")]
        [Required()]
        public decimal ElevationInMeters { get; set; }
        
        [Display(Name="Runway In Meters")]
        [Required()]
        public decimal RunwayInMeters { get; set; }
        
        [Display(Name="Latitude")]
        [Required()]
        public string Latitude { get; set; }
        
        [Display(Name="Longitude")]
        [Required()]
        public string Longitude { get; set; }
        
        [Display(Name="Timezone Id")]
        [Required()]
        public System.Guid TimezoneId { get; set; }
        
        [Display(Name="Variation")]
        [Required()]
        public string Variation { get; set; }
        
        [Display(Name="Attendance")]
        [Required()]
        public string Attendance { get; set; }
        
        [Display(Name="Control Tower Flag")]
        [Required()]
        public bool ControlTowerFlag { get; set; }
        
        [Display(Name="Activation Date Time")]
        [Required()]
        public System.DateTime ActivationDateTime { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
