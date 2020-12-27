/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 6:50:36 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeAircraftMeasurementContract {
        
        [DataMember()]
        public System.Guid AircraftMeasurementId { get; set; }
        
        [DataMember()]
        public decimal Length { get; set; }
        
        [DataMember()]
        public decimal Height { get; set; }
        
        [DataMember()]
        public decimal Weight { get; set; }
        
        [DataMember()]
        public decimal Wingspan { get; set; }
        
        [DataMember()]
        public decimal Width { get; set; }
        
        [DataMember()]
        public decimal Payload { get; set; }
        
        [DataMember()]
        public decimal TakeoffWeightInKilo { get; set; }
        
        [DataMember()]
        public decimal Speed { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
