/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 5:23:08 AM
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this class is used to carry Model POCO classes
    // links:
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeClientModel {
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; }
        
        [Display(Name="First Name")]
        [Required()]
        public string FirstName { get; set; }
        
        [Display(Name="Middle Name")]
        [Required()]
        public string MiddleName { get; set; }
        
        [Display(Name="Last Name")]
        [Required()]
        public string LastName { get; set; }
        
        [Display(Name="Address Id")]
        [Required()]
        public System.Guid AddressId { get; set; }
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; }
        
        [Display(Name="Passenger Type")]
        [Required()]
        public string PassengerTypeRcd { get; set; }
        
        [Display(Name="Nationality")]
        [Required()]
        public string NationalityRcd { get; set; }
        
        [Display(Name="Gender")]
        [Required()]
        public string GenderRcd { get; set; }
        
        [Display(Name="Title")]
        [Required()]
        public string TitleRcd { get; set; }
        
        [Display(Name="Client Type")]
        [Required()]
        public string ClientTypeRcd { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
