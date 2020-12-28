﻿/*
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
    public partial class CrudeFlightScheduleSegmentContract {
        
        [DataMember()]
        public System.Guid FlightScheduleSegmentId { get; set; }
        
        [DataMember()]
        public System.Guid FlightScheduleId { get; set; }
        
        [DataMember()]
        public System.Guid DepartureAirportId { get; set; }
        
        [DataMember()]
        public System.Guid ArrivalAirportId { get; set; }
        
        [DataMember()]
        public int PhysicalSegmentNumber { get; set; }
        
        [DataMember()]
        public int LogicalSegmentNumber { get; set; }
        
        [DataMember()]
        public System.TimeSpan DepartureTime { get; set; }
        
        [DataMember()]
        public System.TimeSpan ArrivalTime { get; set; }
        
        [DataMember()]
        public string DepartureGate { get; set; }
        
        [DataMember()]
        public string ArrivalGate { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}