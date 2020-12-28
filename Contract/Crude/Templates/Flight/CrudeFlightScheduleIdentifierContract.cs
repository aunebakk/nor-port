/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 7:51:26 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeFlightScheduleIdentifierContract {
        
        [DataMember()]
        public System.Guid FlightScheduleIdentifierId { get; set; }
        
        [DataMember()]
        public System.Guid FlightScheduleId { get; set; }
        
        [DataMember()]
        public string FlightIdentifierTypeRcd { get; set; }
        
        [DataMember()]
        public string FlightIdentifierCode { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
