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
    public partial class CrudeAirlineContract {
        
        [DataMember()]
        public System.Guid AirlineId { get; set; }
        
        [DataMember()]
        public string AirlineName { get; set; }
        
        [DataMember()]
        public string AirlineTypeRcd { get; set; }
        
        [DataMember()]
        public string LegalName { get; set; }
        
        [DataMember()]
        public System.Guid AddressId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string StockMarketSymbol { get; set; }
        
        [DataMember()]
        public int AircraftCount { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
