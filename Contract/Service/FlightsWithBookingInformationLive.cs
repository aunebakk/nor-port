using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{

    [DataContract()]
    public class FlightsWithBookingInformationLiveContract
    {

        [DataMember()]
        public DateTime FromDateTime { get; set; }

        [DataMember()]
        public DateTime UntilDateTime { get; set; }

        [DataMember()]
        public List<FlightsWithBookingInformationContract> Flights { get; set; }

    }
}
