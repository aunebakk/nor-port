/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 7:15:32 PM
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer.Models {

    // this class is used to carry Model POCO classes
    // links:
    //  docLink: http://sql2x.org/documentationLink/c5c604a1-5d6d-4fb3-8e70-5d7f590292a6
    public partial class CrudeAircraftCompartmentMeasurementModel {
        
        [Display(Name="Aircraft Compartment Measurement Id")]
        [Required()]
        public System.Guid AircraftCompartmentMeasurementId { get; set; }
        
        [Display(Name="Length")]
        [Required()]
        public decimal Length { get; set; }
        
        [Display(Name="Height")]
        [Required()]
        public decimal Height { get; set; }
        
        [Display(Name="Width")]
        [Required()]
        public decimal Width { get; set; }
        
        [Display(Name="Payload In Kilo")]
        [Required()]
        public decimal PayloadInKilo { get; set; }
        
        [Display(Name="Unit Load Device Positions")]
        [Required()]
        public int UnitLoadDevicePositions { get; set; }
        
        [Display(Name="Carry On Bin Count")]
        [Required()]
        public int CarryOnBinCount { get; set; }
        
        [Display(Name="Carry On Pieces Allowed Count")]
        [Required()]
        public int CarryOnPiecesAllowedCount { get; set; }
        
        [Display(Name="Carry On Piece Max Weight In Kilo")]
        [Required()]
        public int CarryOnPieceMaxWeightInKilo { get; set; }
        
        [Display(Name="Infant Limit")]
        [Required()]
        public int InfantLimit { get; set; }
        
        [Display(Name="Bookable Limit")]
        [Required()]
        public int BookableLimit { get; set; }
        
        [Display(Name="Passenger Limit")]
        [Required()]
        public int PassengerLimit { get; set; }
        
        [Display(Name="Row Count")]
        [Required()]
        public int RowCount { get; set; }
        
        [Display(Name="Column Count")]
        [Required()]
        public int ColumnCount { get; set; }
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; }
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; }
    }
}
