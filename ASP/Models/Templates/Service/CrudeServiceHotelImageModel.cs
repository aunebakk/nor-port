﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:17:22 PM
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
    public partial class CrudeServiceHotelImageModel {
        
        [Display(Name="Service Hotel Image Id")]
        [Required()]
        public System.Guid ServiceHotelImageId { get; set; }
        
        [Display(Name="Service Hotel Id")]
        [Required()]
        public System.Guid ServiceHotelId { get; set; }
        
        [Display(Name="Service Image Type")]
        [Required()]
        public string ServiceImageTypeRcd { get; set; }
        
        [Display(Name="Image File Name")]
        [Required()]
        public string ImageFileName { get; set; }
        
        [Display(Name="Image")]
        [Required()]
        public byte[] Image { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
