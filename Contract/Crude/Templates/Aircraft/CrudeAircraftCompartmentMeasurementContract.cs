/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:13:39 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

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
