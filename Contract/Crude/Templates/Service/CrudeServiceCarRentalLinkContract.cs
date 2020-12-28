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
    public partial class CrudeServiceCarRentalLinkContract {
        
        [DataMember()]
        public System.Guid ServiceCarRentalLinkId { get; set; }
        
        [DataMember()]
        public System.Guid ServiceCarRentalId { get; set; }
        
        [DataMember()]
        public string LinkTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
