/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:37:00 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFlightSearchService")]
    public interface IFlightSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsOnBooking", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsOnBookingResponse")]
        List<FlightsOnBookingContract> FlightsOnBooking (System.Guid bookingId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightHistory", ReplyAction="http://tempuri.org/IFlightSearchService/FlightHistoryResponse")]
        List<FlightHistoryContract> FlightHistory (System.Guid flightId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightSegments", ReplyAction="http://tempuri.org/IFlightSearchService/FlightSegmentsResponse")]
        List<FlightSegmentsContract> FlightSegments (System.Guid flightId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/AirportsAvailableWithFilter", ReplyAction="http://tempuri.org/IFlightSearchService/AirportsAvailableWithFilterResponse")]
        List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsOpenForCheckinWithDescription", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsOpenForCheckinWithDescriptionResponse")]
        List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsWithCheckinInformation", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsWithCheckinInformationResponse")]
        List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsWithBookingInformation", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsWithBookingInformationResponse")]
        List<FlightsWithBookingInformationContract> FlightsWithBookingInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsForBookingWithFare", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsForBookingWithFareResponse")]
        List<FlightsForBookingWithFareContract> FlightsForBookingWithFare (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightsForPeriod", ReplyAction="http://tempuri.org/IFlightSearchService/FlightsForPeriodResponse")]
        List<FlightsForPeriodContract> FlightsForPeriod (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightSearchService/FlightEvents", ReplyAction="http://tempuri.org/IFlightSearchService/FlightEventsResponse")]
        List<FlightEventsContract> FlightEvents (System.Guid flightId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightSearchServiceChannel : IFlightSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class FlightSearchService : System.ServiceModel.ClientBase<IFlightSearchService>, IFlightSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightsOnBookingContract> FlightsOnBooking (System.Guid bookingId) {
            return base.Channel.FlightsOnBooking(bookingId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightHistoryContract> FlightHistory (System.Guid flightId) {
            return base.Channel.FlightHistory(flightId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightSegmentsContract> FlightSegments (System.Guid flightId) {
            return base.Channel.FlightSegments(flightId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.AirportsAvailableWithFilter(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsOpenForCheckinWithDescription(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsWithCheckinInformation(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightsWithBookingInformationContract> FlightsWithBookingInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsWithBookingInformation(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightsForBookingWithFareContract> FlightsForBookingWithFare (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsForBookingWithFare(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<FlightsForPeriodContract> FlightsForPeriod (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            return base.Channel.FlightsForPeriod(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
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
