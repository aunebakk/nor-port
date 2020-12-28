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
    public partial class CrudeFlightContract {
        
        [DataMember()]
        public System.Guid FlightId { get; set; }
        
        [DataMember()]
        public System.Guid BecameFlightId { get; set; }
        
        [DataMember()]
        public System.Guid BindingFlightId { get; set; }
        
        [DataMember()]
        public System.Guid AirlineId { get; set; }
        
        [DataMember()]
        public System.Guid AircraftId { get; set; }
        
        [DataMember()]
        public string AircraftTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid DepartureAirportId { get; set; }
        
        [DataMember()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [DataMember()]
        public System.DateTime FromDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime UntilDateTime { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
