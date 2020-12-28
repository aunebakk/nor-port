using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{

    [DataContract()]
    public class FlightContract
    {
        [DataMember()]
        public CrudeFlightContract Flight { get; set; }

        [DataMember()]
        public CrudeFlightIdentifierContract FlightIdentifier { get; set; }

        [DataMember()]
        public CrudeFlightSegmentContract[] CrudeFlightSegments { get; set; }

        public FlightContract() {
            Flight = new CrudeFlightContract();
            FlightIdentifier = new CrudeFlightIdentifierContract();
        }

        public string FlightNumberFN3 { get { return FlightIdentifier.FlightIdentifierCode; } set { FlightIdentifier.FlightIdentifierCode = value; } }
    }
}
