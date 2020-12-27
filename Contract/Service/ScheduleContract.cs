using System;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{

    [DataContract()]
    public class ScheduleContract
    {
        [DataMember()]
        public CrudeFlightScheduleContract FlightSchedule { get; set; }

        [DataMember()]
        public CrudeFlightScheduleIdentifierContract FlightScheduleIdentifier { get; set; }

        [DataMember()]
        public FlightSegmentsScheduleContract[] FlightScheduleSegments { get; set; }

        [DataMember()]
        public CrudeFlightScheduleSegmentContract[] CrudeFlightScheduleSegments { get; set; }

        public ScheduleContract() {
            FlightSchedule = new CrudeFlightScheduleContract();
            FlightScheduleIdentifier = new CrudeFlightScheduleIdentifierContract();
        }

        // These are used because of some MVC dynamic property mapping that does not work on included classes

        public Guid AirlineId { get { return FlightSchedule.AirlineId; } set { FlightSchedule.AirlineId = value; } }

        public Guid BindingFlightScheduleId { get { return FlightSchedule.BindingFlightScheduleId; } set { FlightSchedule.BindingFlightScheduleId = value; } }

        public string AircraftTypeRcd { get { return FlightSchedule.AircraftTypeRcd; } set { FlightSchedule.AircraftTypeRcd = value; } }

        public Guid DepartureAirportId { get { return FlightSchedule.DepartureAirportId; } set { FlightSchedule.DepartureAirportId = value; } }

        public Guid ArrivalAirportId { get { return FlightSchedule.ArrivalAirportId; } set { FlightSchedule.ArrivalAirportId = value; } }

        public string FlightNumberFN3 { get { return FlightScheduleIdentifier.FlightIdentifierCode; } set { FlightScheduleIdentifier.FlightIdentifierCode = value; } }
    }
}
