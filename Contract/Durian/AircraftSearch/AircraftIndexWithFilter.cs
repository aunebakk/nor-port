/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 6:02:58 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in AircraftIndexWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class AircraftIndexWithFilterContract {
        
        [DataMember()]
        public string AircraftName { get; set; }
        
        [DataMember()]
        public string AircraftTypeName { get; set; }
        
        [DataMember()]
        public string AircraftConfigurationName { get; set; }
        
        [DataMember()]
        public string AircraftBodyName { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string AircraftTypeRcd { get; set; }
        
        [DataMember()]
        public string AircraftConfigurationRcd { get; set; }
        
        [DataMember()]
        public string AircraftBodyRcd { get; set; }
        
        [DataMember()]
        public System.Guid AircraftMeasurementId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public System.DateTime OperationalDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime FirstFlightDateTime { get; set; }
        
        [DataMember()]
        public string EngineType { get; set; }
        
        [DataMember()]
        public int PassengerCapacity { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid AircraftId { get; set; }
    }
}
