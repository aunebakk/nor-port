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
    public partial class CrudeDefaultUserActivityContract {
        
        [DataMember()]
        public System.Guid DefaultUserActivityId { get; set; }
        
        [DataMember()]
        public string DefaultUserActivityTypeRcd { get; set; }
        
        [DataMember()]
        public string UserActivityNote { get; set; }
        
        [DataMember()]
        public string OriginatingAddress { get; set; }
        
        [DataMember()]
        public string Referrer { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
