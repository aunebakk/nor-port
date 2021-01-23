﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:13:46 PM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeFinancialPaymentCouponBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  financialPaymentCouponId: primary key of table financial_payment_coupon
        public CrudeFinancialPaymentCouponModel FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            var dataAccessLayer = new CrudeFinancialPaymentCouponData();
            var model = new CrudeFinancialPaymentCouponModel();

            dataAccessLayer.FetchByFinancialPaymentCouponId(financialPaymentCouponId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCurrencyId: key of table financial_payment_coupon
        public List<CrudeFinancialPaymentCouponModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentCouponData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCouponId: key of table financial_payment_coupon
        public List<CrudeFinancialPaymentCouponModel> FetchByFinancialCouponId(System.Guid financialCouponId) {
            return DataListToModelList(CrudeFinancialPaymentCouponData.FetchByFinancialCouponId(financialCouponId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table financial_payment_coupon
        public List<CrudeFinancialPaymentCouponModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentCouponData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeFinancialPaymentCouponData: object instance of FinancialPaymentCoupon
        public static List<CrudeFinancialPaymentCouponModel> DataListToModelList(List<CrudeFinancialPaymentCouponData> dataList) {
            var modelList = new List<CrudeFinancialPaymentCouponModel>();

            foreach (CrudeFinancialPaymentCouponData data in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeFinancialPaymentCouponData: object instance of FinancialPaymentCoupon
        public static void ModelListToDataList(List<CrudeFinancialPaymentCouponModel> modelList, List<CrudeFinancialPaymentCouponData> dataList) {
            foreach (CrudeFinancialPaymentCouponModel model in modelList) {
                var data = new CrudeFinancialPaymentCouponData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeFinancialPaymentCouponData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeFinancialPaymentCouponModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAll();

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCouponBusiness in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(crudeFinancialPaymentCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeFinancialPaymentCouponModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCouponBusiness in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(crudeFinancialPaymentCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeFinancialPaymentCouponModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCouponBusiness in dataList) {
                var model = new CrudeFinancialPaymentCouponModel();
                DataToModel(crudeFinancialPaymentCouponBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeFinancialPaymentCouponData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeFinancialPaymentCouponModel> FetchWithFilter(System.Guid financialPaymentCouponId, decimal amount, System.Guid financialCurrencyId, System.Guid financialCouponId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialPaymentCouponModel>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchWithFilter(financialPaymentCouponId,amount,financialCurrencyId,financialCouponId,userId,dateTime);

            foreach (CrudeFinancialPaymentCouponData data in dataList) {
                var crudeFinancialPaymentCouponBusinessModel = new CrudeFinancialPaymentCouponModel();
                DataToModel(data, crudeFinancialPaymentCouponBusinessModel);
                list.Add(crudeFinancialPaymentCouponBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeFinancialPaymentCouponModel model) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeFinancialPaymentCouponModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeFinancialPaymentCouponModel model) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeFinancialPaymentCouponModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCouponData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid financialPaymentCouponId) {
            CrudeFinancialPaymentCouponData.Delete(financialPaymentCouponId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeFinancialPaymentCouponModel model, CrudeFinancialPaymentCouponData data) {
            data.FinancialPaymentCouponId = model.FinancialPaymentCouponId;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.FinancialCouponId = model.FinancialCouponId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeFinancialPaymentCouponData data, CrudeFinancialPaymentCouponModel model) {
            model.FinancialPaymentCouponId = data.FinancialPaymentCouponId;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.FinancialCouponId = data.FinancialCouponId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
