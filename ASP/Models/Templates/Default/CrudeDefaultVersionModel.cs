/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:19:39 AM
  From Machine: DESKTOP-BP3OHLH
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
    public partial class CrudeDefaultVersionModel {
        
        [Display(Name="Default Version Id")]
        [Required()]
        public System.Guid DefaultVersionId { get; set; }
        
        [Display(Name="Fun Version")]
        [Required()]
        public string FunVersion { get; set; }
        
        [Display(Name="Number")]
        [Required()]
        public string Number { get; set; }
        
        [Display(Name="Major Number")]
        [Required()]
        public int MajorNumber { get; set; }
        
        [Display(Name="Minor Number")]
        [Required()]
        public int MinorNumber { get; set; }
        
        [Display(Name="Sequence Number")]
        [Required()]
        public int SequenceNumber { get; set; }
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
