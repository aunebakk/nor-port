/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 9:01:27 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/c8b78807-5be0-4da9-89f2-2d7f8dac1c12
    [ServiceContract()]
    public partial interface IFlightSearchService {
        // returns a list of FlightsOnBooking contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightsOnBookingContract> FlightsOnBooking (System.Guid bookingId);
        // returns a list of FlightHistory contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightHistoryContract> FlightHistory (System.Guid flightId);
        // returns a list of FlightSegments contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightSegmentsContract> FlightSegments (System.Guid flightId);
        // returns a list of AirportsAvailableWithFilter contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsOpenForCheckinWithDescription contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsWithCheckinInformation contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsWithBookingInformation contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightsWithBookingInformationContract> FlightsWithBookingInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsForBookingWithFare contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightsForBookingWithFareContract> FlightsForBookingWithFare (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        // returns a list of FlightsForPeriod contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightsForPeriodContract> FlightsForPeriod (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime);
        
        // returns a list of FlightEvents contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FlightEventsContract> FlightEvents(System.Guid flightId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class FlightSearchService : IFlightSearchService {
        // returns a list of FlightsOnBooking contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsOnBookingContract> FlightsOnBooking (System.Guid bookingId) {
            // transfer all FlightsOnBooking serialized objects from FlightSearch as FlightsOnBooking contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightsOnBooking();
            return businessLogicLayer.FlightsOnBookingFromDal(dataAccessLayer.FlightsOnBooking(bookingId));
        }
        // returns a list of FlightHistory contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightHistoryContract> FlightHistory (System.Guid flightId) {
            // transfer all FlightHistory serialized objects from FlightSearch as FlightHistory contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightHistory();
            return businessLogicLayer.FlightHistoryFromDal(dataAccessLayer.FlightHistory(flightId));
        }
        // returns a list of FlightSegments contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightSegmentsContract> FlightSegments (System.Guid flightId) {
            // transfer all FlightSegments serialized objects from FlightSearch as FlightSegments contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightSegments();
            return businessLogicLayer.FlightSegmentsFromDal(dataAccessLayer.FlightSegments(flightId));
        }
        // returns a list of AirportsAvailableWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<AirportsAvailableWithFilterContract> AirportsAvailableWithFilter (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all AirportsAvailableWithFilter serialized objects from FlightSearch as AirportsAvailableWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new AirportsAvailableWithFilter();
            return businessLogicLayer.AirportsAvailableWithFilterFromDal(dataAccessLayer.AirportsAvailableWithFilter(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        // returns a list of FlightsOpenForCheckinWithDescription contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsOpenForCheckinWithDescriptionContract> FlightsOpenForCheckinWithDescription (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all FlightsOpenForCheckinWithDescription serialized objects from FlightSearch as FlightsOpenForCheckinWithDescription contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightsOpenForCheckinWithDescription();
            return businessLogicLayer.FlightsOpenForCheckinWithDescriptionFromDal(dataAccessLayer.FlightsOpenForCheckinWithDescription(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        // returns a list of FlightsWithCheckinInformation contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all FlightsWithCheckinInformation serialized objects from FlightSearch as FlightsWithCheckinInformation contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightsWithCheckinInformation();
            return businessLogicLayer.FlightsWithCheckinInformationFromDal(dataAccessLayer.FlightsWithCheckinInformation(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        // returns a list of FlightsWithBookingInformation contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsWithBookingInformationContract> FlightsWithBookingInformation (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all FlightsWithBookingInformation serialized objects from FlightSearch as FlightsWithBookingInformation contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightsWithBookingInformation();
            return businessLogicLayer.FlightsWithBookingInformationFromDal(dataAccessLayer.FlightsWithBookingInformation(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        // returns a list of FlightsForBookingWithFare contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsForBookingWithFareContract> FlightsForBookingWithFare (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all FlightsForBookingWithFare serialized objects from FlightSearch as FlightsForBookingWithFare contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightsForBookingWithFare();
            return businessLogicLayer.FlightsForBookingWithFareFromDal(dataAccessLayer.FlightsForBookingWithFare(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        // returns a list of FlightsForPeriod contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  departureAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  arrivalAirportId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FlightsForPeriodContract> FlightsForPeriod (System.Guid departureAirportId,System.Guid arrivalAirportId,System.DateTime fromDateTime,System.DateTime untilDateTime) {
            // transfer all FlightsForPeriod serialized objects from FlightSearch as FlightsForPeriod contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightsForPeriod();
            return businessLogicLayer.FlightsForPeriodFromDal(dataAccessLayer.FlightsForPeriod(departureAirportId, arrivalAirportId, fromDateTime, untilDateTime));
        }
        
        // returns a list of FlightEvents contracts from FlightSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual List<FlightEventsContract> FlightEvents(System.Guid flightId) {
            // transfer all FlightEvents serialized objects from FlightSearch as FlightEvents contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FlightSearch();
            var businessLogicLayer = new FlightEvents();
            return businessLogicLayer.FlightEventsFromDal(dataAccessLayer.FlightEvents(flightId));
        }
    }
}
