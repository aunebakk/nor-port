using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{

    [DataContract()]
    public class FlightsForPeriodLiveContract
    {

        [DataMember()]
        public DateTime FromDateTime { get; set; }

        [DataMember()]
        public DateTime UntilDateTime { get; set; }

        [DataMember()]
        public List<FlightsForPeriodContract> Flights { get; set; }

    }
}
