/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 1:32:34 PM
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
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this class is used to carry Model POCO classes
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeDefaultResourceMeasurementModel {
        
        [Display(Name="Default Resource Measurement Id")]
        [Required()]
        public System.Guid DefaultResourceMeasurementId { get; set; }
        
        [Display(Name="Client Workingset Bytes")]
        [Required()]
        public int ClientWorkingsetBytes { get; set; }
        
        [Display(Name="Business Workingset Bytes")]
        [Required()]
        public int BusinessWorkingsetBytes { get; set; }
        
        [Display(Name="Database Size Bytes")]
        [Required()]
        public int DatabaseSizeBytes { get; set; }
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
