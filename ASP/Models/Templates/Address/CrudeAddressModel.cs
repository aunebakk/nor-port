/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:24:29 AM
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
    public partial class CrudeAddressModel {
        
        [Display(Name="Address Id")]
        [Required()]
        public System.Guid AddressId { get; set; }
        
        [Display(Name="Address Type")]
        [Required()]
        public string AddressTypeRcd { get; set; }
        
        [Display(Name="Address One")]
        [Required()]
        public string AddressOne { get; set; }
        
        [Display(Name="Address Two")]
        [Required()]
        public string AddressTwo { get; set; }
        
        [Display(Name="Address Three")]
        [Required()]
        public string AddressThree { get; set; }
        
        [Display(Name="City")]
        [Required()]
        public string City { get; set; }
        
        [Display(Name="Street")]
        [Required()]
        public string Street { get; set; }
        
        [Display(Name="State")]
        [Required()]
        public string State { get; set; }
        
        [Display(Name="District")]
        [Required()]
        public string District { get; set; }
        
        [Display(Name="Province")]
        [Required()]
        public string Province { get; set; }
        
        [Display(Name="Zip Code")]
        [Required()]
        public string ZipCode { get; set; }
        
        [Display(Name="Po Box")]
        [Required()]
        public string PoBox { get; set; }
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
