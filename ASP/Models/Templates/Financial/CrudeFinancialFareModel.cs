﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:12:44 PM
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
    public partial class CrudeFinancialFareModel {
        
        [Display(Name="Financial Fare Id")]
        [Required()]
        public System.Guid FinancialFareId { get; set; }
        
        [Display(Name="Financial Fare Type")]
        [Required()]
        public string FinancialFareTypeRcd { get; set; }
        
        [Display(Name="Departure Airport Id")]
        [Required()]
        public System.Guid DepartureAirportId { get; set; }
        
        [Display(Name="Arrival Airport Id")]
        [Required()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [Display(Name="Valid From Flight Date Time")]
        [Required()]
        public System.DateTime ValidFromFlightDateTime { get; set; }
        
        [Display(Name="Valid Until Flight Date Time")]
        [Required()]
        public System.DateTime ValidUntilFlightDateTime { get; set; }
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; }
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
