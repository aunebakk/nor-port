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
    public partial class CrudeClientContract {
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string FirstName { get; set; }
        
        [DataMember()]
        public string MiddleName { get; set; }
        
        [DataMember()]
        public string LastName { get; set; }
        
        [DataMember()]
        public System.Guid AddressId { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public string PassengerTypeRcd { get; set; }
        
        [DataMember()]
        public string NationalityRcd { get; set; }
        
        [DataMember()]
        public string GenderRcd { get; set; }
        
        [DataMember()]
        public string TitleRcd { get; set; }
        
        [DataMember()]
        public string ClientTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
