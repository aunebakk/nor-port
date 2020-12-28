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
    public partial class CrudeFinancialServiceContract {
        
        [DataMember()]
        public System.Guid FinancialServiceId { get; set; }
        
        [DataMember()]
        public System.Guid BookingServiceRequestId { get; set; }
        
        [DataMember()]
        public string ServiceTypeRcd { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialSpecialServiceId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialHotelBookingId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCarRentalId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialFerryBookingId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
