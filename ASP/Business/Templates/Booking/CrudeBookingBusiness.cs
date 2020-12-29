/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 2:38:16 AM
  From Machine: DESKTOP-517I8BU
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/15abf34a-dec0-46df-8ef1-15d4f2eb7dd0
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is used to expose plain POCO classes against the data layer
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/3f4b94b2-708b-4e8d-847b-2dcf1a60839d
    public partial class CrudeBookingBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  bookingId: primary key of table booking
        public CrudeBookingModel FetchByBookingId(System.Guid bookingId) {
            var dataAccessLayer = new CrudeBookingData();
            var model = new CrudeBookingModel();

            dataAccessLayer.FetchByBookingId(bookingId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AddressId: key of table booking
        public List<CrudeBookingModel> FetchByAddressId(System.Guid addressId) {
            return DataListToModelList(CrudeBookingData.FetchByAddressId(addressId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  BookingSourceRcd: key of table booking
        public List<CrudeBookingModel> FetchByBookingSourceRcd(string bookingSourceRcd) {
            return DataListToModelList(CrudeBookingData.FetchByBookingSourceRcd(bookingSourceRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  ExternalSystemId: key of table booking
        public List<CrudeBookingModel> FetchByExternalSystemId(System.Guid externalSystemId) {
            return DataListToModelList(CrudeBookingData.FetchByExternalSystemId(externalSystemId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AgencyId: key of table booking
        public List<CrudeBookingModel> FetchByAgencyId(System.Guid agencyId) {
            return DataListToModelList(CrudeBookingData.FetchByAgencyId(agencyId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCurrencyId: key of table booking
        public List<CrudeBookingModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeBookingData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCostcentreId: key of table booking
        public List<CrudeBookingModel> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return DataListToModelList(CrudeBookingData.FetchByFinancialCostcentreId(financialCostcentreId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table booking
        public List<CrudeBookingModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeBookingData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeBookingData: object instance of Booking
        public static List<CrudeBookingModel> DataListToModelList(List<CrudeBookingData> dataList) {
            var modelList = new List<CrudeBookingModel>();

            foreach (CrudeBookingData data in dataList) {
                var model = new CrudeBookingModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeBookingData: object instance of Booking
        public static void ModelListToDataList(List<CrudeBookingModel> modelList, List<CrudeBookingData> dataList) {
            foreach (CrudeBookingModel model in modelList) {
                var data = new CrudeBookingData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeBookingData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeBookingModel> FetchAll() {
            var list = new List<CrudeBookingModel>();
            List<CrudeBookingData> dataList = CrudeBookingData.FetchAll();

            foreach (CrudeBookingData crudeBookingBusiness in dataList) {
                var model = new CrudeBookingModel();
                DataToModel(crudeBookingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeBookingModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeBookingModel>();
            List<CrudeBookingData> dataList = CrudeBookingData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeBookingData crudeBookingBusiness in dataList) {
                var model = new CrudeBookingModel();
                DataToModel(crudeBookingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeBookingModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeBookingModel>();
            List<CrudeBookingData> dataList = CrudeBookingData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeBookingData crudeBookingBusiness in dataList) {
                var model = new CrudeBookingModel();
                DataToModel(crudeBookingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeBookingData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeBookingModel> FetchWithFilter(System.Guid bookingId, string receivedFrom, System.Guid addressId, string bookingSourceRcd, System.Guid externalSystemId, System.Guid agencyId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, string comment, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeBookingModel>();
            List<CrudeBookingData> dataList = CrudeBookingData.FetchWithFilter(bookingId,receivedFrom,addressId,bookingSourceRcd,externalSystemId,agencyId,financialCurrencyId,financialCostcentreId,comment,userId,dateTime);

            foreach (CrudeBookingData data in dataList) {
                var crudeBookingBusinessModel = new CrudeBookingModel();
                DataToModel(data, crudeBookingBusinessModel);
                list.Add(crudeBookingBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeBookingModel model) {
            var data = new CrudeBookingData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeBookingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeBookingData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeBookingModel model) {
            var data = new CrudeBookingData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeBookingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeBookingData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid bookingId) {
            CrudeBookingData.Delete(bookingId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeBookingModel model, CrudeBookingData data) {
            data.BookingId = model.BookingId;
            data.ReceivedFrom = model.ReceivedFrom;
            data.AddressId = model.AddressId;
            data.BookingSourceRcd = model.BookingSourceRcd;
            data.ExternalSystemId = model.ExternalSystemId;
            data.AgencyId = model.AgencyId;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.FinancialCostcentreId = model.FinancialCostcentreId;
            data.Comment = model.Comment;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeBookingData data, CrudeBookingModel model) {
            model.BookingId = data.BookingId;
            model.ReceivedFrom = data.ReceivedFrom;
            model.AddressId = data.AddressId;
            model.BookingSourceRcd = data.BookingSourceRcd;
            model.ExternalSystemId = data.ExternalSystemId;
            model.AgencyId = data.AgencyId;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.FinancialCostcentreId = data.FinancialCostcentreId;
            model.Comment = data.Comment;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
