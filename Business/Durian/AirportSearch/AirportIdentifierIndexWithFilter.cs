/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:32:54 AM
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
    // this contract is an identical representation of AirportIdentifierIndexWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/babfd233-23de-489f-8f62-51eaec05a19e
    public class AirportIdentifierIndexWithFilter {
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6a251e13-1f76-48af-af34-18c592706874
        // parameters:
        //  dataContract: from durian ansi sql select statement
        public List<AirportIdentifierIndexWithFilterContract> AirportIdentifierIndexWithFilterFromDal(List<AirportIdentifierIndexWithFilterData> dataList) {
           var list = new List<AirportIdentifierIndexWithFilterContract>();

           foreach (AirportIdentifierIndexWithFilterData data in dataList) {
               var contract = new AirportIdentifierIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6140089a-d7c9-4e92-b385-f6fd91026820
        // parameters:
        //  dalAirportIdentifierIndexWithFilter: from durian ansi sql select statement
        //  dataContract: business wcf contract
        public void DataToContract(AirportIdentifierIndexWithFilterData dalAirportIdentifierIndexWithFilter, AirportIdentifierIndexWithFilterContract dataContract) {
            dataContract.AirportName = dalAirportIdentifierIndexWithFilter.AirportName;
            dataContract.AirportIdentifierTypeName = dalAirportIdentifierIndexWithFilter.AirportIdentifierTypeName;
            dataContract.DefaultUserName = dalAirportIdentifierIndexWithFilter.DefaultUserName;
            dataContract.AirportId = dalAirportIdentifierIndexWithFilter.AirportId;
            dataContract.AirportIdentifierTypeRcd = dalAirportIdentifierIndexWithFilter.AirportIdentifierTypeRcd;
            dataContract.AirportIdentifierCode = dalAirportIdentifierIndexWithFilter.AirportIdentifierCode;
            dataContract.UserId = dalAirportIdentifierIndexWithFilter.UserId;
            dataContract.DateTime = dalAirportIdentifierIndexWithFilter.DateTime;
            dataContract.AirportIdentifierId = dalAirportIdentifierIndexWithFilter.AirportIdentifierId;
        }
    }
}
