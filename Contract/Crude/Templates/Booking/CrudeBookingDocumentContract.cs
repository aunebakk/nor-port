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
    public partial class CrudeBookingDocumentContract {
        
        [DataMember()]
        public System.Guid BookingDocumentId { get; set; }
        
        [DataMember()]
        public System.Guid BookingId { get; set; }
        
        [DataMember()]
        public string BookingDocumentTypeRcd { get; set; }
        
        [DataMember()]
        public string BookingDocumentName { get; set; }
        
        [DataMember()]
        public string BookingDocumentFilename { get; set; }
        
        [DataMember()]
        public string BookingDocument { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
