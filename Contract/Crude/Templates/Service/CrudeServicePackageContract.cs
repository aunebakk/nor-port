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
    public partial class CrudeServicePackageContract {
        
        [DataMember()]
        public System.Guid ServicePackageId { get; set; }
        
        [DataMember()]
        public string ServicePackageName { get; set; }
        
        [DataMember()]
        public System.Guid ServiceHotelId { get; set; }
        
        [DataMember()]
        public System.Guid ServiceSpecialServiceRequestId { get; set; }
        
        [DataMember()]
        public System.Guid ServiceCarRentalId { get; set; }
        
        [DataMember()]
        public System.Guid DepartureAirportId { get; set; }
        
        [DataMember()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [DataMember()]
        public int StayDurationDays { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
