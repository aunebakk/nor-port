/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:01:45 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeAircraftContract {
        
        [DataMember()]
        public System.Guid AircraftId { get; set; }
        
        [DataMember()]
        public string AircraftName { get; set; }
        
        [DataMember()]
        public string AircraftTypeRcd { get; set; }
        
        [DataMember()]
        public string AircraftConfigurationRcd { get; set; }
        
        [DataMember()]
        public string AircraftBodyRcd { get; set; }
        
        [DataMember()]
        public System.Guid AircraftMeasurementId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public System.DateTime OperationalDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime FirstFlightDateTime { get; set; }
        
        [DataMember()]
        public string EngineType { get; set; }
        
        [DataMember()]
        public int PassengerCapacity { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
