/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:25:50 PM
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
    public partial class CrudeFerryModel {
        
        [Display(Name="Ferry Id")]
        [Required()]
        public System.Guid FerryId { get; set; }
        
        [Display(Name="Ferry Name")]
        [Required()]
        public string FerryName { get; set; }
        
        [Display(Name="Ferry Type")]
        [Required()]
        public string FerryTypeRcd { get; set; }
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; }
        
        [Display(Name="First Float Date Time")]
        [Required()]
        public System.DateTime FirstFloatDateTime { get; set; }
        
        [Display(Name="Operational Date Time")]
        [Required()]
        public System.DateTime OperationalDateTime { get; set; }
        
        [Display(Name="Engine Type")]
        [Required()]
        public string EngineType { get; set; }
        
        [Display(Name="Passenger Capacity")]
        [Required()]
        public int PassengerCapacity { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
