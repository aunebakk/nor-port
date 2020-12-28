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
    public partial class CrudeAirportContract {
        
        [DataMember()]
        public System.Guid AirportId { get; set; }
        
        [DataMember()]
        public string AirportName { get; set; }
        
        [DataMember()]
        public string AirportTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid CityId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public decimal UtcOffset { get; set; }
        
        [DataMember()]
        public decimal ElevationInMeters { get; set; }
        
        [DataMember()]
        public decimal RunwayInMeters { get; set; }
        
        [DataMember()]
        public string Latitude { get; set; }
        
        [DataMember()]
        public string Longitude { get; set; }
        
        [DataMember()]
        public System.Guid TimezoneId { get; set; }
        
        [DataMember()]
        public string Variation { get; set; }
        
        [DataMember()]
        public string Attendance { get; set; }
        
        [DataMember()]
        public bool ControlTowerFlag { get; set; }
        
        [DataMember()]
        public System.DateTime ActivationDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
