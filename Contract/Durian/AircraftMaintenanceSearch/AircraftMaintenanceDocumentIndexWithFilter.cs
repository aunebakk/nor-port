/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 8:56:49 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in AircraftMaintenanceDocumentIndexWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class AircraftMaintenanceDocumentIndexWithFilterContract {
        
        [DataMember()]
        public System.Guid AircraftId { get; set; }
        
        [DataMember()]
        public string AircraftName { get; set; }
        
        [DataMember()]
        public string AircraftDocumentTypeRcd { get; set; }
        
        [DataMember()]
        public string AircraftDocumentTypeName { get; set; }
        
        [DataMember()]
        public string DocumentName { get; set; }
        
        [DataMember()]
        public System.DateTime DocumentDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ExpiryDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid AircraftDocumentId { get; set; }
    }
}
