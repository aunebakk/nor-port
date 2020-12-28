/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 4:55:25 PM
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
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface ICrudeAirlineService {
        
        [OperationContract()]
        CrudeAirlineContract FetchByAirlineId(System.Guid airlineId);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchByAddressId(System.Guid addressId);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchByAirlineTypeRcd(string airlineTypeRcd);
        
        [OperationContract()]
        CrudeAirlineContract FetchByAirlineName(string airlineName);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchWithFilter(System.Guid airlineId, string airlineName, string airlineTypeRcd, string legalName, System.Guid addressId, System.Guid productId, string stockMarketSymbol, int aircraftCount, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchAll();
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeAirlineContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeAirlineContract contract);
        
        [OperationContract()]
        void Update(CrudeAirlineContract contract);
        
        [OperationContract()]
        void Delete(System.Guid airlineId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of airline's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    //  WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/bccca991-4801-4ad4-80f0-0357a1249606
    public partial class CrudeAirlineService : ICrudeAirlineService {
        
        // fetch by Primary key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  airlineId: primary key of table airline
        public CrudeAirlineContract FetchByAirlineId(System.Guid airlineId) {
            var dataAccessLayer = new CrudeAirlineData();
            var contract = new CrudeAirlineContract();

            dataAccessLayer.FetchByAirlineId(airlineId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeAirlineContract FetchByAirlineName(string airlineName) {
            var dataAccessLayer = new CrudeAirlineData();
            var contract = new CrudeAirlineContract();

            dataAccessLayer.FetchByAirlineName(airlineName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAirlineContract> FetchByAddressId(System.Guid addressId) {
            return DataListToContractList(CrudeAirlineData.FetchByAddressId(addressId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAirlineContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeAirlineData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAirlineContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeAirlineData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeAirlineContract> FetchByAirlineTypeRcd(string airlineTypeRcd) {
            return DataListToContractList(CrudeAirlineData.FetchByAirlineTypeRcd(airlineTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/7467f97d-14e5-4ccf-9282-ef8df4f63088
        public static List<CrudeAirlineContract> DataListToContractList(List<CrudeAirlineData> dataList) {
            var contractList = new List<CrudeAirlineContract>();

            foreach (CrudeAirlineData data in dataList) {
                var contract = new CrudeAirlineContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        // links:
        //  docLink: http://sql2x.org/documentationLink/1c6c6b9c-e201-4590-8c69-d38a0ad2a9f7
        public static void ContractListToDataList(List<CrudeAirlineContract> contractList, List<CrudeAirlineData> dataList) {
            foreach (CrudeAirlineContract contract in contractList) {
                var data = new CrudeAirlineData();
                CrudeAirlineService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeAirlineData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9204c68e-93b8-4c77-af3c-3181985ff75f
        public List<CrudeAirlineContract> FetchAll() {
            var list = new List<CrudeAirlineContract>();
            List<CrudeAirlineData> dataList = CrudeAirlineData.FetchAll();

            foreach (CrudeAirlineData crudeAirline in dataList) {
                var contract = new CrudeAirlineContract();
                DataToContract(crudeAirline, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/f23c4cd8-e941-4b3e-8fda-7b2ac6a399f7
        public List<CrudeAirlineContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeAirlineContract>();
            List<CrudeAirlineData> dataList = CrudeAirlineData.FetchAllWithLimit(limit);

            foreach (CrudeAirlineData crudeAirline in dataList) {
                var contract = new CrudeAirlineContract();
                DataToContract(crudeAirline, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/3fe9f1b3-97b6-4f58-a0f2-adfcbd973bfc
        public List<CrudeAirlineContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeAirlineContract>();
            List<CrudeAirlineData> dataList = CrudeAirlineData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeAirlineData crudeAirline in dataList) {
                var contract = new CrudeAirlineContract();
                DataToContract(crudeAirline, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/7cd5e52c-b3d7-4566-a27a-408d0732dd88
        public int FetchAllCount() {
            return CrudeAirlineData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce01ef4a-5cd0-4e51-b211-9c0a15b791a0
        public List<CrudeAirlineContract> FetchWithFilter(System.Guid airlineId, string airlineName, string airlineTypeRcd, string legalName, System.Guid addressId, System.Guid productId, string stockMarketSymbol, int aircraftCount, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeAirlineContract>();
            List<CrudeAirlineData> dataList = CrudeAirlineData.FetchWithFilter(
                airlineId: airlineId,
                airlineName: airlineName,
                airlineTypeRcd: airlineTypeRcd,
                legalName: legalName,
                addressId: addressId,
                productId: productId,
                stockMarketSymbol: stockMarketSymbol,
                aircraftCount: aircraftCount,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeAirlineData data in dataList) {
                var crudeAirlineContract = new CrudeAirlineContract();
                DataToContract(data, crudeAirlineContract);
                list.Add(crudeAirlineContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/75aad010-e6aa-4f19-a6e5-597456aa20d8
        public void Insert(CrudeAirlineContract contract) {
            var data = new CrudeAirlineData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/542f9458-c3b9-4edf-8575-0870086f3a7f
        public void Insert(CrudeAirlineContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeAirlineData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce75e72e-fb16-4f4e-a2e6-dbd079dfa206
        public void Update(CrudeAirlineContract contract) {
            var data = new CrudeAirlineData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/b798ad6b-f4b8-466a-9086-6588a814fcf3
        public void Update(CrudeAirlineContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeAirlineData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb0597e0-8ea0-425c-88af-213a170bbd5e
        public void Delete(System.Guid airlineId) {
            CrudeAirlineData.Delete(airlineId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/10700d38-2227-4021-be12-2f4f206f5dd9
        public static void ContractToData(CrudeAirlineContract contract, CrudeAirlineData data) {
            data.AirlineId = contract.AirlineId;
            data.AirlineName = contract.AirlineName;
            data.AirlineTypeRcd = contract.AirlineTypeRcd;
            data.LegalName = contract.LegalName;
            data.AddressId = contract.AddressId;
            data.ProductId = contract.ProductId;
            data.StockMarketSymbol = contract.StockMarketSymbol;
            data.AircraftCount = contract.AircraftCount;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/7553d6dd-da65-4a72-84c8-81f2f99ef4f5
        public static void DataToContract(CrudeAirlineData data, CrudeAirlineContract contract) {
            contract.AirlineId = data.AirlineId;
            contract.AirlineName = data.AirlineName;
            contract.AirlineTypeRcd = data.AirlineTypeRcd;
            contract.LegalName = data.LegalName;
            contract.AddressId = data.AddressId;
            contract.ProductId = data.ProductId;
            contract.StockMarketSymbol = data.StockMarketSymbol;
            contract.AircraftCount = data.AircraftCount;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
