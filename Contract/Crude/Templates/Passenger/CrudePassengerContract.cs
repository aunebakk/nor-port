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
    public partial class CrudePassengerContract {
        
        [DataMember()]
        public System.Guid PassengerId { get; set; }
        
        [DataMember()]
        public System.Guid BecamePassengerId { get; set; }
        
        [DataMember()]
        public System.Guid BindingPassengerId { get; set; }
        
        [DataMember()]
        public string PassengerTypeRcd { get; set; }
        
        [DataMember()]
        public string PassengerName { get; set; }
        
        [DataMember()]
        public string DefaultStateRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
