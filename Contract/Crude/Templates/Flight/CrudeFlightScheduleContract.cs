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
    public partial class CrudeFlightScheduleContract {
        
        [DataMember()]
        public System.Guid FlightScheduleId { get; set; }
        
        [DataMember()]
        public System.Guid BecameFlightScheduleId { get; set; }
        
        [DataMember()]
        public System.Guid BindingFlightScheduleId { get; set; }
        
        [DataMember()]
        public System.Guid AirlineId { get; set; }
        
        [DataMember()]
        public string AircraftTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid DepartureAirportId { get; set; }
        
        [DataMember()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.DateTime FromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime UntilDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
