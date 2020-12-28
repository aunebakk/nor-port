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
    public partial class CrudeBookingPassengerEventContract {
        
        [DataMember()]
        public System.Guid BookingPassengerEventId { get; set; }
        
        [DataMember()]
        public string BookingPassengerEventTypeRcd { get; set; }
        
        [DataMember()]
        public int BookingPassengerEventNumber { get; set; }
        
        [DataMember()]
        public System.Guid BookingPassengerId { get; set; }
        
        [DataMember()]
        public System.Guid BookingFlightSegmentId { get; set; }
        
        [DataMember()]
        public System.Guid BookingPassengerTicketId { get; set; }
        
        [DataMember()]
        public System.Guid BookingPassengerSeatId { get; set; }
        
        [DataMember()]
        public System.Guid BookingPassengerBaggageId { get; set; }
        
        [DataMember()]
        public string Remarks { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
