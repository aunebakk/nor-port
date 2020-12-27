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
    public partial class CrudeBookingServiceRequestContract {
        
        [DataMember()]
        public System.Guid BookingServiceRequestId { get; set; }
        
        [DataMember()]
        public System.Guid BookingId { get; set; }
        
        [DataMember()]
        public string ServiceTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        [DataMember()]
        public string ServiceRequestStatusRcd { get; set; }
        
        [DataMember()]
        public System.Guid ServiceHotelId { get; set; }
        
        [DataMember()]
        public System.Guid ServiceCarRentalId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid ServiceFerryId { get; set; }
    }
}
