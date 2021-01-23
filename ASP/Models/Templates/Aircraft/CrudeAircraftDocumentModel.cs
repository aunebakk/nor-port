﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:05:51 PM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeAircraftDocumentModel {
        
        [Display(Name="Aircraft Document Id")]
        [Required()]
        public System.Guid AircraftDocumentId { get; set; }
        
        [Display(Name="Aircraft Id")]
        [Required()]
        public System.Guid AircraftId { get; set; }
        
        [Display(Name="Aircraft Document Type")]
        [Required()]
        public string AircraftDocumentTypeRcd { get; set; }
        
        [Display(Name="Document Name")]
        [Required()]
        public string DocumentName { get; set; }
        
        [Display(Name="Document Date Time")]
        [Required()]
        public System.DateTime DocumentDateTime { get; set; }
        
        [Display(Name="Expiry Date Time")]
        [Required()]
        public System.DateTime ExpiryDateTime { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
