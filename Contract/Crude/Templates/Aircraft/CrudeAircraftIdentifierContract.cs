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
    public partial class CrudeAircraftIdentifierContract {
        
        [DataMember()]
        public System.Guid AircraftIdentifierId { get; set; }
        
        [DataMember()]
        public System.Guid AircraftId { get; set; }
        
        [DataMember()]
        public string AircraftIdentifierTypeRcd { get; set; }
        
        [DataMember()]
        public string AircraftIdentifierCode { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
