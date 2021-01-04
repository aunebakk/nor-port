/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 6:57:03 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreBusiness
*/
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/15abf34a-dec0-46df-8ef1-15d4f2eb7dd0
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is used to expose plain POCO classes against the data layer
    // links:
    //  docLink: http://sql2x.org/documentationLink/3f4b94b2-708b-4e8d-847b-2dcf1a60839d
    public partial class CrudeFinancialBookingTransactionBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  financialBookingTransactionId: primary key of table financial_booking_transaction
        public CrudeFinancialBookingTransactionModel FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            var dataAccessLayer = new CrudeFinancialBookingTransactionData();
            var model = new CrudeFinancialBookingTransactionModel();

            dataAccessLayer.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  BookingId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByBookingId(System.Guid bookingId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByBookingId(bookingId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialBookingTransactionTypeRcd: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialBookingTransactionTypeRcd(string financialBookingTransactionTypeRcd) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialBookingTransactionTypeRcd(financialBookingTransactionTypeRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialFeeId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialFeeId(System.Guid financialFeeId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialFeeId(financialFeeId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialTaxId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialTaxId(System.Guid financialTaxId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialTaxId(financialTaxId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialFareId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialFareId(System.Guid financialFareId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialFareId(financialFareId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialPaymentId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialPaymentId(financialPaymentId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCurrencyId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCostcentreId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialCostcentreId(financialCostcentreId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialAdjustmentId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialAdjustmentId(financialAdjustmentId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialServiceId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByFinancialServiceId(System.Guid financialServiceId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByFinancialServiceId(financialServiceId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table financial_booking_transaction
        public List<CrudeFinancialBookingTransactionModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialBookingTransactionData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeFinancialBookingTransactionData: object instance of FinancialBookingTransaction
        public static List<CrudeFinancialBookingTransactionModel> DataListToModelList(List<CrudeFinancialBookingTransactionData> dataList) {
            var modelList = new List<CrudeFinancialBookingTransactionModel>();

            foreach (CrudeFinancialBookingTransactionData data in dataList) {
                var model = new CrudeFinancialBookingTransactionModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeFinancialBookingTransactionData: object instance of FinancialBookingTransaction
        public static void ModelListToDataList(List<CrudeFinancialBookingTransactionModel> modelList, List<CrudeFinancialBookingTransactionData> dataList) {
            foreach (CrudeFinancialBookingTransactionModel model in modelList) {
                var data = new CrudeFinancialBookingTransactionData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeFinancialBookingTransactionData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeFinancialBookingTransactionModel> FetchAll() {
            var list = new List<CrudeFinancialBookingTransactionModel>();
            List<CrudeFinancialBookingTransactionData> dataList = CrudeFinancialBookingTransactionData.FetchAll();

            foreach (CrudeFinancialBookingTransactionData crudeFinancialBookingTransactionBusiness in dataList) {
                var model = new CrudeFinancialBookingTransactionModel();
                DataToModel(crudeFinancialBookingTransactionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeFinancialBookingTransactionModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialBookingTransactionModel>();
            List<CrudeFinancialBookingTransactionData> dataList = CrudeFinancialBookingTransactionData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialBookingTransactionData crudeFinancialBookingTransactionBusiness in dataList) {
                var model = new CrudeFinancialBookingTransactionModel();
                DataToModel(crudeFinancialBookingTransactionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeFinancialBookingTransactionModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialBookingTransactionModel>();
            List<CrudeFinancialBookingTransactionData> dataList = CrudeFinancialBookingTransactionData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialBookingTransactionData crudeFinancialBookingTransactionBusiness in dataList) {
                var model = new CrudeFinancialBookingTransactionModel();
                DataToModel(crudeFinancialBookingTransactionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeFinancialBookingTransactionData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeFinancialBookingTransactionModel> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid bookingId, int transactionNumber, string financialBookingTransactionTypeRcd, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialFareId, System.Guid financialPaymentId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, System.Guid financialServiceId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialBookingTransactionModel>();
            List<CrudeFinancialBookingTransactionData> dataList = CrudeFinancialBookingTransactionData.FetchWithFilter(financialBookingTransactionId,bookingId,transactionNumber,financialBookingTransactionTypeRcd,amount,financialFeeId,financialTaxId,financialFareId,financialPaymentId,financialCurrencyId,financialCostcentreId,financialAdjustmentId,financialServiceId,userId,dateTime);

            foreach (CrudeFinancialBookingTransactionData data in dataList) {
                var crudeFinancialBookingTransactionBusinessModel = new CrudeFinancialBookingTransactionModel();
                DataToModel(data, crudeFinancialBookingTransactionBusinessModel);
                list.Add(crudeFinancialBookingTransactionBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeFinancialBookingTransactionModel model) {
            var data = new CrudeFinancialBookingTransactionData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeFinancialBookingTransactionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialBookingTransactionData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeFinancialBookingTransactionModel model) {
            var data = new CrudeFinancialBookingTransactionData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeFinancialBookingTransactionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialBookingTransactionData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid financialBookingTransactionId) {
            CrudeFinancialBookingTransactionData.Delete(financialBookingTransactionId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeFinancialBookingTransactionModel model, CrudeFinancialBookingTransactionData data) {
            data.FinancialBookingTransactionId = model.FinancialBookingTransactionId;
            data.BookingId = model.BookingId;
            data.TransactionNumber = model.TransactionNumber;
            data.FinancialBookingTransactionTypeRcd = model.FinancialBookingTransactionTypeRcd;
            data.Amount = model.Amount;
            data.FinancialFeeId = model.FinancialFeeId;
            data.FinancialTaxId = model.FinancialTaxId;
            data.FinancialFareId = model.FinancialFareId;
            data.FinancialPaymentId = model.FinancialPaymentId;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.FinancialCostcentreId = model.FinancialCostcentreId;
            data.FinancialAdjustmentId = model.FinancialAdjustmentId;
            data.FinancialServiceId = model.FinancialServiceId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeFinancialBookingTransactionData data, CrudeFinancialBookingTransactionModel model) {
            model.FinancialBookingTransactionId = data.FinancialBookingTransactionId;
            model.BookingId = data.BookingId;
            model.TransactionNumber = data.TransactionNumber;
            model.FinancialBookingTransactionTypeRcd = data.FinancialBookingTransactionTypeRcd;
            model.Amount = data.Amount;
            model.FinancialFeeId = data.FinancialFeeId;
            model.FinancialTaxId = data.FinancialTaxId;
            model.FinancialFareId = data.FinancialFareId;
            model.FinancialPaymentId = data.FinancialPaymentId;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.FinancialCostcentreId = data.FinancialCostcentreId;
            model.FinancialAdjustmentId = data.FinancialAdjustmentId;
            model.FinancialServiceId = data.FinancialServiceId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
