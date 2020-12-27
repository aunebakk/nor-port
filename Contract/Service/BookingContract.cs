using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [DataContract()]
    public class BookingContract
    {
        [DataMember()]
        public CrudeBookingContract Booking { get; set; }

        [DataMember()]
        public CrudeAddressContract BookingAddress { get; set; }

        [DataMember()]
        public List<CrudePassengerContract> Passenger { get; set; }

        [DataMember()]
        public List<BookingPassengersContract> BookingPassengers { get; set; }

        [DataMember()]
        public CrudeBookingIdentifierContract BookingIdentifier { get; set; }

        [DataMember()]
        public CrudeBookingContactMethodContract BookingContactMethod { get; set; }

        [DataMember()]
        public BookingEventCountContract BookingEventCount { get; set; }
    }
}
