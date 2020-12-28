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
    public partial class CrudeFinancialFareContract {
        
        [DataMember()]
        public System.Guid FinancialFareId { get; set; }
        
        [DataMember()]
        public string FinancialFareTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid DepartureAirportId { get; set; }
        
        [DataMember()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [DataMember()]
        public System.DateTime ValidFromFlightDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ValidUntilFlightDateTime { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
