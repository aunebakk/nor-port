/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 2:22:52 PM
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
    // this contract is an identical representation of AircraftMaintenanceIndexWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/babfd233-23de-489f-8f62-51eaec05a19e
    public class AircraftMaintenanceIndexWithFilter {
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6a251e13-1f76-48af-af34-18c592706874
        // parameters:
        //  dataContract: from durian ansi sql select statement
        public List<AircraftMaintenanceIndexWithFilterContract> AircraftMaintenanceIndexWithFilterFromDal(List<AircraftMaintenanceIndexWithFilterData> dataList) {
           var list = new List<AircraftMaintenanceIndexWithFilterContract>();

           foreach (AircraftMaintenanceIndexWithFilterData data in dataList) {
               var contract = new AircraftMaintenanceIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6140089a-d7c9-4e92-b385-f6fd91026820
        // parameters:
        //  dalAircraftMaintenanceIndexWithFilter: from durian ansi sql select statement
        //  dataContract: business wcf contract
        public void DataToContract(AircraftMaintenanceIndexWithFilterData dalAircraftMaintenanceIndexWithFilter, AircraftMaintenanceIndexWithFilterContract dataContract) {
            dataContract.AircraftName = dalAircraftMaintenanceIndexWithFilter.AircraftName;
            dataContract.AircraftConfigurationRcd = dalAircraftMaintenanceIndexWithFilter.AircraftConfigurationRcd;
            dataContract.AircraftConfigurationName = dalAircraftMaintenanceIndexWithFilter.AircraftConfigurationName;
            dataContract.AircraftBodyRcd = dalAircraftMaintenanceIndexWithFilter.AircraftBodyRcd;
            dataContract.AircraftBodyName = dalAircraftMaintenanceIndexWithFilter.AircraftBodyName;
            dataContract.AircraftTypeRcd = dalAircraftMaintenanceIndexWithFilter.AircraftTypeRcd;
            dataContract.AircraftTypeName = dalAircraftMaintenanceIndexWithFilter.AircraftTypeName;
            dataContract.EngineType = dalAircraftMaintenanceIndexWithFilter.EngineType;
            dataContract.OperationalDateTime = dalAircraftMaintenanceIndexWithFilter.OperationalDateTime;
            dataContract.FirstFlightDateTime = dalAircraftMaintenanceIndexWithFilter.FirstFlightDateTime;
            dataContract.PassengerCapacity = dalAircraftMaintenanceIndexWithFilter.PassengerCapacity;
            dataContract.UserId = dalAircraftMaintenanceIndexWithFilter.UserId;
            dataContract.DefaultUserName = dalAircraftMaintenanceIndexWithFilter.DefaultUserName;
            dataContract.DateTime = dalAircraftMaintenanceIndexWithFilter.DateTime;
            dataContract.AircraftId = dalAircraftMaintenanceIndexWithFilter.AircraftId;
            dataContract.ProductId = dalAircraftMaintenanceIndexWithFilter.ProductId;
        }
    }
}
