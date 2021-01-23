﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:49:16 PM
  From Machine: DESKTOP-9A2DH39
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
    // this contract is an identical representation of FlightsWithCheckinInformation's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/babfd233-23de-489f-8f62-51eaec05a19e
    public class FlightsWithCheckinInformation {
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6a251e13-1f76-48af-af34-18c592706874
        // parameters:
        //  dataContract: from durian ansi sql select statement
        public List<FlightsWithCheckinInformationContract> FlightsWithCheckinInformationFromDal(List<FlightsWithCheckinInformationData> dataList) {
           var list = new List<FlightsWithCheckinInformationContract>();

           foreach (FlightsWithCheckinInformationData data in dataList) {
               var contract = new FlightsWithCheckinInformationContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6140089a-d7c9-4e92-b385-f6fd91026820
        // parameters:
        //  dalFlightsWithCheckinInformation: from durian ansi sql select statement
        //  dataContract: business wcf contract
        public void DataToContract(FlightsWithCheckinInformationData dalFlightsWithCheckinInformation, FlightsWithCheckinInformationContract dataContract) {
            dataContract.FlightId = dalFlightsWithCheckinInformation.FlightId;
            dataContract.AirlineIdentifierCode = dalFlightsWithCheckinInformation.AirlineIdentifierCode;
            dataContract.FlightNumber = dalFlightsWithCheckinInformation.FlightNumber;
            dataContract.DepartureAirportIdentifierCode = dalFlightsWithCheckinInformation.DepartureAirportIdentifierCode;
            dataContract.DepartureAirportName = dalFlightsWithCheckinInformation.DepartureAirportName;
            dataContract.ArrivalAirportIdentifierCode = dalFlightsWithCheckinInformation.ArrivalAirportIdentifierCode;
            dataContract.ArrivalAirportName = dalFlightsWithCheckinInformation.ArrivalAirportName;
            dataContract.FromDateTime = dalFlightsWithCheckinInformation.FromDateTime;
            dataContract.UntilDateTime = dalFlightsWithCheckinInformation.UntilDateTime;
            dataContract.PassengersBookedCount = dalFlightsWithCheckinInformation.PassengersBookedCount;
            dataContract.AdultBookedCount = dalFlightsWithCheckinInformation.AdultBookedCount;
            dataContract.ChildBookedCount = dalFlightsWithCheckinInformation.ChildBookedCount;
            dataContract.InfantBookedCount = dalFlightsWithCheckinInformation.InfantBookedCount;
            dataContract.LastDateTimeTypeName = dalFlightsWithCheckinInformation.LastDateTimeTypeName;
            dataContract.PlannedDepartureDateTime = dalFlightsWithCheckinInformation.PlannedDepartureDateTime;
            dataContract.EstimatedDepartureDateTime = dalFlightsWithCheckinInformation.EstimatedDepartureDateTime;
        }
    }
}
