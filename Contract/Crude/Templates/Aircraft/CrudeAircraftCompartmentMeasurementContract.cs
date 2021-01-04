﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 4:28:46 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/89dc5b67-2bf9-4c88-8911-c3b6294c3a64
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class serves as a data access contract between c# and sql server
    // this class start with an identical representation of CrudeAircraftCompartmentMeasurement's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/ceb39174-f927-4fd8-8396-5ec4d04ea471
    [DataContract()]
    public partial class CrudeAircraftCompartmentMeasurementContract {
        
        [DataMember()]
        public System.Guid AircraftCompartmentMeasurementId { get; set; }
        
        [DataMember()]
        public decimal Length { get; set; }
        
        [DataMember()]
        public decimal Height { get; set; }
        
        [DataMember()]
        public decimal Width { get; set; }
        
        [DataMember()]
        public decimal PayloadInKilo { get; set; }
        
        [DataMember()]
        public int UnitLoadDevicePositions { get; set; }
        
        [DataMember()]
        public int CarryOnBinCount { get; set; }
        
        [DataMember()]
        public int CarryOnPiecesAllowedCount { get; set; }
        
        [DataMember()]
        public int CarryOnPieceMaxWeightInKilo { get; set; }
        
        [DataMember()]
        public int InfantLimit { get; set; }
        
        [DataMember()]
        public int BookableLimit { get; set; }
        
        [DataMember()]
        public int PassengerLimit { get; set; }
        
        [DataMember()]
        public int RowCount { get; set; }
        
        [DataMember()]
        public int ColumnCount { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
