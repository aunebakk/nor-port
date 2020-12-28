/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:46:56 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPassengerSearchService")]
    public interface IPassengerSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnFlightWithoutEvents", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnFlightWithoutEventsResponse")]
        List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents (System.Guid flightId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnFlightCheckedIn", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnFlightCheckedInResponse")]
        List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn (System.Guid flightId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnFlight", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnFlightResponse")]
        List<PassengersOnFlightContract> PassengersOnFlight (System.Guid flightId);
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassengerSearchService/PassengersOnBooking", ReplyAction="http://tempuri.org/IPassengerSearchService/PassengersOnBookingResponse")]
        List<PassengersOnBookingContract> PassengersOnBooking (System.Guid bookingId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPassengerSearchServiceChannel : IPassengerSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class PassengerSearchService : System.ServiceModel.ClientBase<IPassengerSearchService>, IPassengerSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEvents (System.Guid flightId) {
            return base.Channel.PassengersOnFlightWithoutEvents(flightId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<PassengersOnFlightCheckedInContract> PassengersOnFlightCheckedIn (System.Guid flightId) {
            return base.Channel.PassengersOnFlightCheckedIn(flightId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<PassengersOnFlightContract> PassengersOnFlight (System.Guid flightId) {
            return base.Channel.PassengersOnFlight(flightId);
        }
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<PassengersOnBookingContract> PassengersOnBooking (System.Guid bookingId) {
            return base.Channel.PassengersOnBooking(bookingId);
        }
        
        public PassengerSearchService() {
        }
        
        public PassengerSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PassengerSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassengerSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassengerSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}