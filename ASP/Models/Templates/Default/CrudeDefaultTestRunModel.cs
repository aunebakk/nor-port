﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 7:01:59 PM
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
    public partial class CrudeDefaultTestRunModel {
        
        [Display(Name="Default Test Run Id")]
        [Required()]
        public System.Guid DefaultTestRunId { get; set; }
        
        [Display(Name="Default Test Id")]
        [Required()]
        public System.Guid DefaultTestId { get; set; }
        
        [Display(Name="Default Test Run Result")]
        [Required()]
        public string DefaultTestRunResultRcd { get; set; }
        
        [Display(Name="Result")]
        [Required()]
        public string Result { get; set; }
        
        [Display(Name="Start Date Time")]
        [Required()]
        public System.DateTime StartDateTime { get; set; }
        
        [Display(Name="End Date Time")]
        [Required()]
        public System.DateTime EndDateTime { get; set; }
        
        [Display(Name="Elapsed Milliseconds")]
        [Required()]
        public int ElapsedMilliseconds { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
