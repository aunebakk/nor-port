/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 5:20:49 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPort.DataAccessLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface ICrudeAircraftService {
        
        [OperationContract()]
        CrudeAircraftContract FetchByAircraftId(System.Guid aircraftId);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchByAircraftMeasurementId(System.Guid aircraftMeasurementId);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchByAircraftTypeRcd(string aircraftTypeRcd);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchByAircraftConfigurationRcd(string aircraftConfigurationRcd);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchByAircraftBodyRcd(string aircraftBodyRcd);
        
        [OperationContract()]
        CrudeAircraftContract FetchByAircraftName(string aircraftName);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchWithFilter(System.Guid aircraftId, string aircraftName, string aircraftTypeRcd, string aircraftConfigurationRcd, string aircraftBodyRcd, System.Guid aircraftMeasurementId, System.Guid productId, System.DateTime operationalDateTime, System.DateTime firstFlightDateTime, string engineType, int passengerCapacity, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchAll();
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeAircraftContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeAircraftContract contract);
        
        [OperationContract()]
        void Update(CrudeAircraftContract contract);
        
        [OperationContract()]
        void Delete(System.Guid aircraftId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of aircraft's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/bccca991-4801-4ad4-80f0-0357a1249606
    public partial class CrudeAircraftService : ICrudeAircraftService {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  aircraftId: primary key of table aircraft
        public CrudeAircraftContract FetchByAircraftId(System.Guid aircraftId) {
            var dataAccessLayer = new CrudeAircraftData();
            var contract = new CrudeAircraftContract();

            dataAccessLayer.FetchByAircraftId(aircraftId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeAircraftContract FetchByAircraftName(string aircraftName) {
            var dataAccessLayer = new CrudeAircraftData();
            var contract = new CrudeAircraftContract();

            dataAccessLayer.FetchByAircraftName(aircraftName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAircraftContract> FetchByAircraftMeasurementId(System.Guid aircraftMeasurementId) {
            return DataListToContractList(CrudeAircraftData.FetchByAircraftMeasurementId(aircraftMeasurementId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAircraftContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeAircraftData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAircraftContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeAircraftData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAircraftContract> FetchByAircraftTypeRcd(string aircraftTypeRcd) {
            return DataListToContractList(CrudeAircraftData.FetchByAircraftTypeRcd(aircraftTypeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAircraftContract> FetchByAircraftConfigurationRcd(string aircraftConfigurationRcd) {
            return DataListToContractList(CrudeAircraftData.FetchByAircraftConfigurationRcd(aircraftConfigurationRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAircraftContract> FetchByAircraftBodyRcd(string aircraftBodyRcd) {
            return DataListToContractList(CrudeAircraftData.FetchByAircraftBodyRcd(aircraftBodyRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/7467f97d-14e5-4ccf-9282-ef8df4f63088
        public static List<CrudeAircraftContract> DataListToContractList(List<CrudeAircraftData> dataList) {
            var contractList = new List<CrudeAircraftContract>();

            foreach (CrudeAircraftData data in dataList) {
                var contract = new CrudeAircraftContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        // links:
        //  docLink: http://sql2x.org/documentationLink/1c6c6b9c-e201-4590-8c69-d38a0ad2a9f7
        public static void ContractListToDataList(List<CrudeAircraftContract> contractList, List<CrudeAircraftData> dataList) {
            foreach (CrudeAircraftContract contract in contractList) {
                var data = new CrudeAircraftData();
                CrudeAircraftService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeAircraftData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9204c68e-93b8-4c77-af3c-3181985ff75f
        public List<CrudeAircraftContract> FetchAll() {
            var list = new List<CrudeAircraftContract>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchAll();

            foreach (CrudeAircraftData crudeAircraft in dataList) {
                var contract = new CrudeAircraftContract();
                DataToContract(crudeAircraft, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/f23c4cd8-e941-4b3e-8fda-7b2ac6a399f7
        public List<CrudeAircraftContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeAircraftContract>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchAllWithLimit(limit);

            foreach (CrudeAircraftData crudeAircraft in dataList) {
                var contract = new CrudeAircraftContract();
                DataToContract(crudeAircraft, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/3fe9f1b3-97b6-4f58-a0f2-adfcbd973bfc
        public List<CrudeAircraftContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeAircraftContract>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeAircraftData crudeAircraft in dataList) {
                var contract = new CrudeAircraftContract();
                DataToContract(crudeAircraft, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/7cd5e52c-b3d7-4566-a27a-408d0732dd88
        public int FetchAllCount() {
            return CrudeAircraftData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce01ef4a-5cd0-4e51-b211-9c0a15b791a0
        public List<CrudeAircraftContract> FetchWithFilter(System.Guid aircraftId, string aircraftName, string aircraftTypeRcd, string aircraftConfigurationRcd, string aircraftBodyRcd, System.Guid aircraftMeasurementId, System.Guid productId, System.DateTime operationalDateTime, System.DateTime firstFlightDateTime, string engineType, int passengerCapacity, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeAircraftContract>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchWithFilter(
                aircraftId: aircraftId,
                aircraftName: aircraftName,
                aircraftTypeRcd: aircraftTypeRcd,
                aircraftConfigurationRcd: aircraftConfigurationRcd,
                aircraftBodyRcd: aircraftBodyRcd,
                aircraftMeasurementId: aircraftMeasurementId,
                productId: productId,
                operationalDateTime: operationalDateTime,
                firstFlightDateTime: firstFlightDateTime,
                engineType: engineType,
                passengerCapacity: passengerCapacity,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeAircraftData data in dataList) {
                var crudeAircraftContract = new CrudeAircraftContract();
                DataToContract(data, crudeAircraftContract);
                list.Add(crudeAircraftContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/75aad010-e6aa-4f19-a6e5-597456aa20d8
        public void Insert(CrudeAircraftContract contract) {
            var data = new CrudeAircraftData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/542f9458-c3b9-4edf-8575-0870086f3a7f
        public void Insert(CrudeAircraftContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeAircraftData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce75e72e-fb16-4f4e-a2e6-dbd079dfa206
        public void Update(CrudeAircraftContract contract) {
            var data = new CrudeAircraftData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/b798ad6b-f4b8-466a-9086-6588a814fcf3
        public void Update(CrudeAircraftContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeAircraftData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb0597e0-8ea0-425c-88af-213a170bbd5e
        public void Delete(System.Guid aircraftId) {
            CrudeAircraftData.Delete(aircraftId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/10700d38-2227-4021-be12-2f4f206f5dd9
        public static void ContractToData(CrudeAircraftContract contract, CrudeAircraftData data) {
            data.AircraftId = contract.AircraftId;
            data.AircraftName = contract.AircraftName;
            data.AircraftTypeRcd = contract.AircraftTypeRcd;
            data.AircraftConfigurationRcd = contract.AircraftConfigurationRcd;
            data.AircraftBodyRcd = contract.AircraftBodyRcd;
            data.AircraftMeasurementId = contract.AircraftMeasurementId;
            data.ProductId = contract.ProductId;
            data.OperationalDateTime = contract.OperationalDateTime;
            data.FirstFlightDateTime = contract.FirstFlightDateTime;
            data.EngineType = contract.EngineType;
            data.PassengerCapacity = contract.PassengerCapacity;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/7553d6dd-da65-4a72-84c8-81f2f99ef4f5
        public static void DataToContract(CrudeAircraftData data, CrudeAircraftContract contract) {
            contract.AircraftId = data.AircraftId;
            contract.AircraftName = data.AircraftName;
            contract.AircraftTypeRcd = data.AircraftTypeRcd;
            contract.AircraftConfigurationRcd = data.AircraftConfigurationRcd;
            contract.AircraftBodyRcd = data.AircraftBodyRcd;
            contract.AircraftMeasurementId = data.AircraftMeasurementId;
            contract.ProductId = data.ProductId;
            contract.OperationalDateTime = data.OperationalDateTime;
            contract.FirstFlightDateTime = data.FirstFlightDateTime;
            contract.EngineType = data.EngineType;
            contract.PassengerCapacity = data.PassengerCapacity;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
