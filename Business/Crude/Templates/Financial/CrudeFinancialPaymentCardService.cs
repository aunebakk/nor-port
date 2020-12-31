/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:19:20 AM
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
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface ICrudeFinancialPaymentCardService {
        
        [OperationContract()]
        CrudeFinancialPaymentCardContract FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchByFinancialCardTypeRcd(string financialCardTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchWithFilter(System.Guid financialPaymentCardId, string financialCardTypeRcd, string nameOnCard, string cardNumber, int cardVerificationValue, string addressVerificationCode, int issuedYear, int issuedMonth, int expiryYear, int expiryMonth, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCardContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentCardContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentCardContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentCardId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of financial_payment_card's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/bccca991-4801-4ad4-80f0-0357a1249606
    public partial class CrudeFinancialPaymentCardService : ICrudeFinancialPaymentCardService {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  financialPaymentCardId: primary key of table financial_payment_card
        public CrudeFinancialPaymentCardContract FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            var dataAccessLayer = new CrudeFinancialPaymentCardData();
            var contract = new CrudeFinancialPaymentCardContract();

            dataAccessLayer.FetchByFinancialPaymentCardId(financialPaymentCardId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeFinancialPaymentCardContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentCardData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeFinancialPaymentCardContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentCardData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeFinancialPaymentCardContract> FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            return DataListToContractList(CrudeFinancialPaymentCardData.FetchByFinancialCardTypeRcd(financialCardTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/7467f97d-14e5-4ccf-9282-ef8df4f63088
        public static List<CrudeFinancialPaymentCardContract> DataListToContractList(List<CrudeFinancialPaymentCardData> dataList) {
            var contractList = new List<CrudeFinancialPaymentCardContract>();

            foreach (CrudeFinancialPaymentCardData data in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        // links:
        //  docLink: http://sql2x.org/documentationLink/1c6c6b9c-e201-4590-8c69-d38a0ad2a9f7
        public static void ContractListToDataList(List<CrudeFinancialPaymentCardContract> contractList, List<CrudeFinancialPaymentCardData> dataList) {
            foreach (CrudeFinancialPaymentCardContract contract in contractList) {
                var data = new CrudeFinancialPaymentCardData();
                CrudeFinancialPaymentCardService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeFinancialPaymentCardData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9204c68e-93b8-4c77-af3c-3181985ff75f
        public List<CrudeFinancialPaymentCardContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAll();

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCard in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(crudeFinancialPaymentCard, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/f23c4cd8-e941-4b3e-8fda-7b2ac6a399f7
        public List<CrudeFinancialPaymentCardContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCard in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(crudeFinancialPaymentCard, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/3fe9f1b3-97b6-4f58-a0f2-adfcbd973bfc
        public List<CrudeFinancialPaymentCardContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentCardData crudeFinancialPaymentCard in dataList) {
                var contract = new CrudeFinancialPaymentCardContract();
                DataToContract(crudeFinancialPaymentCard, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/7cd5e52c-b3d7-4566-a27a-408d0732dd88
        public int FetchAllCount() {
            return CrudeFinancialPaymentCardData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce01ef4a-5cd0-4e51-b211-9c0a15b791a0
        public List<CrudeFinancialPaymentCardContract> FetchWithFilter(System.Guid financialPaymentCardId, string financialCardTypeRcd, string nameOnCard, string cardNumber, int cardVerificationValue, string addressVerificationCode, int issuedYear, int issuedMonth, int expiryYear, int expiryMonth, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialPaymentCardContract>();
            List<CrudeFinancialPaymentCardData> dataList = CrudeFinancialPaymentCardData.FetchWithFilter(
                financialPaymentCardId: financialPaymentCardId,
                financialCardTypeRcd: financialCardTypeRcd,
                nameOnCard: nameOnCard,
                cardNumber: cardNumber,
                cardVerificationValue: cardVerificationValue,
                addressVerificationCode: addressVerificationCode,
                issuedYear: issuedYear,
                issuedMonth: issuedMonth,
                expiryYear: expiryYear,
                expiryMonth: expiryMonth,
                amount: amount,
                financialCurrencyId: financialCurrencyId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialPaymentCardData data in dataList) {
                var crudeFinancialPaymentCardContract = new CrudeFinancialPaymentCardContract();
                DataToContract(data, crudeFinancialPaymentCardContract);
                list.Add(crudeFinancialPaymentCardContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/75aad010-e6aa-4f19-a6e5-597456aa20d8
        public void Insert(CrudeFinancialPaymentCardContract contract) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/542f9458-c3b9-4edf-8575-0870086f3a7f
        public void Insert(CrudeFinancialPaymentCardContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce75e72e-fb16-4f4e-a2e6-dbd079dfa206
        public void Update(CrudeFinancialPaymentCardContract contract) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/b798ad6b-f4b8-466a-9086-6588a814fcf3
        public void Update(CrudeFinancialPaymentCardContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCardData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb0597e0-8ea0-425c-88af-213a170bbd5e
        public void Delete(System.Guid financialPaymentCardId) {
            CrudeFinancialPaymentCardData.Delete(financialPaymentCardId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/10700d38-2227-4021-be12-2f4f206f5dd9
        public static void ContractToData(CrudeFinancialPaymentCardContract contract, CrudeFinancialPaymentCardData data) {
            data.FinancialPaymentCardId = contract.FinancialPaymentCardId;
            data.FinancialCardTypeRcd = contract.FinancialCardTypeRcd;
            data.NameOnCard = contract.NameOnCard;
            data.CardNumber = contract.CardNumber;
            data.CardVerificationValue = contract.CardVerificationValue;
            data.AddressVerificationCode = contract.AddressVerificationCode;
            data.IssuedYear = contract.IssuedYear;
            data.IssuedMonth = contract.IssuedMonth;
            data.ExpiryYear = contract.ExpiryYear;
            data.ExpiryMonth = contract.ExpiryMonth;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/7553d6dd-da65-4a72-84c8-81f2f99ef4f5
        public static void DataToContract(CrudeFinancialPaymentCardData data, CrudeFinancialPaymentCardContract contract) {
            contract.FinancialPaymentCardId = data.FinancialPaymentCardId;
            contract.FinancialCardTypeRcd = data.FinancialCardTypeRcd;
            contract.NameOnCard = data.NameOnCard;
            contract.CardNumber = data.CardNumber;
            contract.CardVerificationValue = data.CardVerificationValue;
            contract.AddressVerificationCode = data.AddressVerificationCode;
            contract.IssuedYear = data.IssuedYear;
            contract.IssuedMonth = data.IssuedMonth;
            contract.ExpiryYear = data.ExpiryYear;
            contract.ExpiryMonth = data.ExpiryMonth;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
