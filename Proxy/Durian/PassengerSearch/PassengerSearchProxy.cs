/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 3:15:48 AM
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
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/179373dc-6fcc-4fc3-a7aa-e57c35d4d1d4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPassengerSearchService")]
    public interface IPassengerSearchServiceClient {
        // returns a list of PassengersOnFlightWithoutEvents contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnFlightWithoutEvents", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnFlightWithoutEventsResponse")]
        List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents (System.Guid flightId);
        // returns a list of PassengersOnFlightCheckedIn contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnFlightCheckedIn", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnFlightCheckedInResponse")]
        List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn (System.Guid flightId);
        // returns a list of PassengersOnFlight contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnFlight", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnFlightResponse")]
        List<PassengersOnFlightContract> PassengersOnFlight (System.Guid flightId);
        // returns a list of PassengersOnBooking contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnBooking", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnBookingResponse")]
        List<PassengersOnBookingContract> PassengersOnBooking (System.Guid bookingId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPassengerSearchServiceChannel : IPassengerSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class PassengerSearchServiceClient : System.ServiceModel.ClientBase<IPassengerSearchServiceClient>, IPassengerSearchServiceClient {
        // returns a list of PassengersOnFlightWithoutEvents contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents (System.Guid flightId) {
            return base.Channel.PassengersOnFlightWithoutEvents(flightId);
        }
        // returns a list of PassengersOnFlightCheckedIn contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn (System.Guid flightId) {
            return base.Channel.PassengersOnFlightCheckedIn(flightId);
        }
        // returns a list of PassengersOnFlight contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  flightId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnFlightContract> PassengersOnFlight (System.Guid flightId) {
            return base.Channel.PassengersOnFlight(flightId);
        }
        // returns a list of PassengersOnBooking contracts from PassengerSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<PassengersOnBookingContract> PassengersOnBooking (System.Guid bookingId) {
            return base.Channel.PassengersOnBooking(bookingId);
        }
        
        public PassengerSearchServiceClient() {
        }
        
        public PassengerSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PassengerSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassengerSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassengerSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
