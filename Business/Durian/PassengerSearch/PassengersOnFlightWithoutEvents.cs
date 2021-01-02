/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 2:44:11 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.DataAccessLayer;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/3f5526a4-3503-435d-96a1-5a88aaeb7b9f
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of PassengersOnFlightWithoutEvents's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/babfd233-23de-489f-8f62-51eaec05a19e
    public class PassengersOnFlightWithoutEvents {
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6a251e13-1f76-48af-af34-18c592706874
        // parameters:
        //  dataContract: from durian ansi sql select statement
        public List<PassengersOnFlightWithoutEventsContract> PassengersOnFlightWithoutEventsFromDal(List<PassengersOnFlightWithoutEventsData> dataList) {
           var list = new List<PassengersOnFlightWithoutEventsContract>();

           foreach (PassengersOnFlightWithoutEventsData data in dataList) {
               var contract = new PassengersOnFlightWithoutEventsContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6140089a-d7c9-4e92-b385-f6fd91026820
        // parameters:
        //  dalPassengersOnFlightWithoutEvents: from durian ansi sql select statement
        //  dataContract: business wcf contract
        public void DataToContract(PassengersOnFlightWithoutEventsData dalPassengersOnFlightWithoutEvents, PassengersOnFlightWithoutEventsContract dataContract) {
            dataContract.RecordLocator = dalPassengersOnFlightWithoutEvents.RecordLocator;
            dataContract.ReceivedFrom = dalPassengersOnFlightWithoutEvents.ReceivedFrom;
            dataContract.PassengerName = dalPassengersOnFlightWithoutEvents.PassengerName;
            dataContract.PassengerTypeName = dalPassengersOnFlightWithoutEvents.PassengerTypeName;
            dataContract.PassengerId = dalPassengersOnFlightWithoutEvents.PassengerId;
            dataContract.BookingId = dalPassengersOnFlightWithoutEvents.BookingId;
            dataContract.BookingPassengerId = dalPassengersOnFlightWithoutEvents.BookingPassengerId;
            dataContract.BookingFlightSegmentId = dalPassengersOnFlightWithoutEvents.BookingFlightSegmentId;
        }
    }
}
