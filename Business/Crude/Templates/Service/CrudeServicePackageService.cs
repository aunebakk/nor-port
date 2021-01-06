/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 5:15:14 AM
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
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/a968e8fb-5158-4625-8911-47504426078b
    [ServiceContract()]
    public partial interface ICrudeServicePackageService {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  servicePackageId: primary key of table service_package
        [OperationContract()]
        CrudeServicePackageContract FetchByServicePackageId(System.Guid servicePackageId);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchByServiceHotelId(System.Guid serviceHotelId);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchByServiceSpecialServiceRequestId(System.Guid serviceSpecialServiceRequestId);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchByServiceCarRentalId(System.Guid serviceCarRentalId);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchByDepartureAirportId(System.Guid departureAirportId);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchByArrivalAirportId(System.Guid arrivalAirportId);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeServicePackageContract FetchByServicePackageName(string servicePackageName);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchWithFilter(System.Guid servicePackageId, string servicePackageName, System.Guid serviceHotelId, System.Guid serviceSpecialServiceRequestId, System.Guid serviceCarRentalId, System.Guid departureAirportId, System.Guid arrivalAirportId, int stayDurationDays, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchAll();
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeServicePackageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeServicePackageContract contract);
        
        [OperationContract()]
        void Update(CrudeServicePackageContract contract);
        
        [OperationContract()]
        void Delete(System.Guid servicePackageId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of service_package's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/bccca991-4801-4ad4-80f0-0357a1249606
    public partial class CrudeServicePackageService : ICrudeServicePackageService {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  servicePackageId: primary key of table service_package
        public CrudeServicePackageContract FetchByServicePackageId(System.Guid servicePackageId) {
            var dataAccessLayer = new CrudeServicePackageData();
            var contract = new CrudeServicePackageContract();

            dataAccessLayer.FetchByServicePackageId(servicePackageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeServicePackageContract FetchByServicePackageName(string servicePackageName) {
            var dataAccessLayer = new CrudeServicePackageData();
            var contract = new CrudeServicePackageContract();

            dataAccessLayer.FetchByServicePackageName(servicePackageName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeServicePackageContract> FetchByServiceHotelId(System.Guid serviceHotelId) {
            return DataListToContractList(CrudeServicePackageData.FetchByServiceHotelId(serviceHotelId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeServicePackageContract> FetchByServiceSpecialServiceRequestId(System.Guid serviceSpecialServiceRequestId) {
            return DataListToContractList(CrudeServicePackageData.FetchByServiceSpecialServiceRequestId(serviceSpecialServiceRequestId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeServicePackageContract> FetchByServiceCarRentalId(System.Guid serviceCarRentalId) {
            return DataListToContractList(CrudeServicePackageData.FetchByServiceCarRentalId(serviceCarRentalId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeServicePackageContract> FetchByDepartureAirportId(System.Guid departureAirportId) {
            return DataListToContractList(CrudeServicePackageData.FetchByDepartureAirportId(departureAirportId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeServicePackageContract> FetchByArrivalAirportId(System.Guid arrivalAirportId) {
            return DataListToContractList(CrudeServicePackageData.FetchByArrivalAirportId(arrivalAirportId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeServicePackageContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeServicePackageData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/7467f97d-14e5-4ccf-9282-ef8df4f63088
        public static List<CrudeServicePackageContract> DataListToContractList(List<CrudeServicePackageData> dataList) {
            var contractList = new List<CrudeServicePackageContract>();

            foreach (CrudeServicePackageData data in dataList) {
                var contract = new CrudeServicePackageContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        // links:
        //  docLink: http://sql2x.org/documentationLink/1c6c6b9c-e201-4590-8c69-d38a0ad2a9f7
        public static void ContractListToDataList(List<CrudeServicePackageContract> contractList, List<CrudeServicePackageData> dataList) {
            foreach (CrudeServicePackageContract contract in contractList) {
                var data = new CrudeServicePackageData();
                CrudeServicePackageService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeServicePackageData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9204c68e-93b8-4c77-af3c-3181985ff75f
        public List<CrudeServicePackageContract> FetchAll() {
            var list = new List<CrudeServicePackageContract>();
            List<CrudeServicePackageData> dataList = CrudeServicePackageData.FetchAll();

            foreach (CrudeServicePackageData crudeServicePackage in dataList) {
                var contract = new CrudeServicePackageContract();
                DataToContract(crudeServicePackage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/f23c4cd8-e941-4b3e-8fda-7b2ac6a399f7
        public List<CrudeServicePackageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeServicePackageContract>();
            List<CrudeServicePackageData> dataList = CrudeServicePackageData.FetchAllWithLimit(limit);

            foreach (CrudeServicePackageData crudeServicePackage in dataList) {
                var contract = new CrudeServicePackageContract();
                DataToContract(crudeServicePackage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/3fe9f1b3-97b6-4f58-a0f2-adfcbd973bfc
        public List<CrudeServicePackageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeServicePackageContract>();
            List<CrudeServicePackageData> dataList = CrudeServicePackageData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeServicePackageData crudeServicePackage in dataList) {
                var contract = new CrudeServicePackageContract();
                DataToContract(crudeServicePackage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/7cd5e52c-b3d7-4566-a27a-408d0732dd88
        public int FetchAllCount() {
            return CrudeServicePackageData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce01ef4a-5cd0-4e51-b211-9c0a15b791a0
        public List<CrudeServicePackageContract> FetchWithFilter(System.Guid servicePackageId, string servicePackageName, System.Guid serviceHotelId, System.Guid serviceSpecialServiceRequestId, System.Guid serviceCarRentalId, System.Guid departureAirportId, System.Guid arrivalAirportId, int stayDurationDays, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeServicePackageContract>();
            List<CrudeServicePackageData> dataList = CrudeServicePackageData.FetchWithFilter(
                servicePackageId: servicePackageId,
                servicePackageName: servicePackageName,
                serviceHotelId: serviceHotelId,
                serviceSpecialServiceRequestId: serviceSpecialServiceRequestId,
                serviceCarRentalId: serviceCarRentalId,
                departureAirportId: departureAirportId,
                arrivalAirportId: arrivalAirportId,
                stayDurationDays: stayDurationDays,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeServicePackageData data in dataList) {
                var crudeServicePackageContract = new CrudeServicePackageContract();
                DataToContract(data, crudeServicePackageContract);
                list.Add(crudeServicePackageContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/75aad010-e6aa-4f19-a6e5-597456aa20d8
        public void Insert(CrudeServicePackageContract contract) {
            var data = new CrudeServicePackageData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/542f9458-c3b9-4edf-8575-0870086f3a7f
        public void Insert(CrudeServicePackageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeServicePackageData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce75e72e-fb16-4f4e-a2e6-dbd079dfa206
        public void Update(CrudeServicePackageContract contract) {
            var data = new CrudeServicePackageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/b798ad6b-f4b8-466a-9086-6588a814fcf3
        public void Update(CrudeServicePackageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeServicePackageData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb0597e0-8ea0-425c-88af-213a170bbd5e
        public void Delete(System.Guid servicePackageId) {
            CrudeServicePackageData.Delete(servicePackageId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/10700d38-2227-4021-be12-2f4f206f5dd9
        public static void ContractToData(CrudeServicePackageContract contract, CrudeServicePackageData data) {
            data.ServicePackageId = contract.ServicePackageId;
            data.ServicePackageName = contract.ServicePackageName;
            data.ServiceHotelId = contract.ServiceHotelId;
            data.ServiceSpecialServiceRequestId = contract.ServiceSpecialServiceRequestId;
            data.ServiceCarRentalId = contract.ServiceCarRentalId;
            data.DepartureAirportId = contract.DepartureAirportId;
            data.ArrivalAirportId = contract.ArrivalAirportId;
            data.StayDurationDays = contract.StayDurationDays;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/7553d6dd-da65-4a72-84c8-81f2f99ef4f5
        public static void DataToContract(CrudeServicePackageData data, CrudeServicePackageContract contract) {
            contract.ServicePackageId = data.ServicePackageId;
            contract.ServicePackageName = data.ServicePackageName;
            contract.ServiceHotelId = data.ServiceHotelId;
            contract.ServiceSpecialServiceRequestId = data.ServiceSpecialServiceRequestId;
            contract.ServiceCarRentalId = data.ServiceCarRentalId;
            contract.DepartureAirportId = data.DepartureAirportId;
            contract.ArrivalAirportId = data.ArrivalAirportId;
            contract.StayDurationDays = data.StayDurationDays;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
