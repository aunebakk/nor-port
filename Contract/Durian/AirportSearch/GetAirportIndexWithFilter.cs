/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:51:39 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetAirportIndexWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class GetAirportIndexWithFilterContract {
        
        [DataMember()]
        public string AirportName { get; set; }
        
        [DataMember()]
        public string AirportTypeName { get; set; }
        
        [DataMember()]
        public string CityName { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string AirportTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid CityId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public decimal UtcOffset { get; set; }
        
        [DataMember()]
        public decimal ElevationInMeters { get; set; }
        
        [DataMember()]
        public decimal RunwayInMeters { get; set; }
        
        [DataMember()]
        public string Latitude { get; set; }
        
        [DataMember()]
        public string Longitude { get; set; }
        
        [DataMember()]
        public System.Guid TimezoneId { get; set; }
        
        [DataMember()]
        public string Variation { get; set; }
        
        [DataMember()]
        public string Attendance { get; set; }
        
        [DataMember()]
        public bool ControlTowerFlag { get; set; }
        
        [DataMember()]
        public System.DateTime ActivationDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid AirportId { get; set; }
    }
}
