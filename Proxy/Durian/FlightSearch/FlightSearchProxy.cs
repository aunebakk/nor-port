/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 1:52:24 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFlightSearchService")]
    public interface IFlightSearchService {
        // returns a list of FlightsOnBooking contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsOnBooking", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsOnBookingResponse")]
        List<FlightsOnBookingContract> FlightsOnBooking (System.Guid bookingId);
        // returns a list of FlightHistory contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightHistory", ReplyAction="http://tempuri.org/IFlightSearchService/FlightHistoryResponse")]
        List<FlightHistoryContract> FlightHistory (System.Guid flightId);
        // returns a list of FlightSegments contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightSegments", ReplyAction="http://tempuri.org/IFlightSearchService/FlightSegmentsResponse")]
        List<FlightSegmentsContract> FlightSegments (System.Guid flightId);
        // returns a list of AirportsAvailableWithFilter contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/AirportsAvailableWithFilter", ReplyAction="http://tempuri.org/IFlightSearchService/AirportsAvailableWithFilterResponse")]
        List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsOpenForCheckinWithDescription contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsOpenForCheckinWithDescription", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsOpenForCheckinWithDescriptionResponse")]
        List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsWithCheckinInformation contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsWithCheckinInformation", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsWithCheckinInformationResponse")]
        List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsWithBookingInformation contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsWithBookingInformation", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsWithBookingInformationResponse")]
        List<FlightsWithBookingInformationContract> FlightsWithBookingInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsForBookingWithFare contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsForBookingWithFare", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsForBookingWithFareResponse")]
        List<FlightsForBookingWithFareContract> FlightsForBookingWithFare (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsForPeriod contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsForPeriod", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsForPeriodResponse")]
        List<FlightsForPeriodContract> FlightsForPeriod (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightEvents contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightEvents", ReplyAction="http://tempuri.org/IFlightSearchService/FlightEventsResponse")]
        List<FlightEventsContract> FlightEvents (System.Guid flightId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightSearchServiceChannel : IFlightSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class FlightSearchService : System.ServiceModel.ClientBase<IFlightSearchService>, IFlightSearchService {
        // returns a list of FlightsOnBooking contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsOnBookingContract> FlightsOnBooking (System.Guid bookingId) {
            return base.Channel.FlightsOnBooking(bookingId);
        }
        // returns a list of FlightHistory contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightHistoryContract> FlightHistory (System.Guid flightId) {
            return base.Channel.FlightHistory(flightId);
        }
        // returns a list of FlightSegments contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightSegmentsContract> FlightSegments (System.Guid flightId) {
            return base.Channel.FlightSegments(flightId);
        }
        // returns a list of AirportsAvailableWithFilter contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.AirportsAvailableWithFilter(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of FlightsOpenForCheckinWithDescription contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsOpenForCheckinWithDescription(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of FlightsWithCheckinInformation contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsWithCheckinInformation(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of FlightsWithBookingInformation contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsWithBookingInformationContract> FlightsWithBookingInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsWithBookingInformation(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of FlightsForBookingWithFare contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsForBookingWithFareContract> FlightsForBookingWithFare (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsForBookingWithFare(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of FlightsForPeriod contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsForPeriodContract> FlightsForPeriod (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsForPeriod(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // returns a list of FlightEvents contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightEventsContract> FlightEvents (System.Guid flightId) {
            return base.Channel.FlightEvents(flightId);
        }
        
        public FlightSearchService() {
        }
        
        public FlightSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
