/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:09:50 PM
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
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
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
    // this class is used to expose plain POCO classes against the data layer
    // this class is used to expose plain POCO classes against the data layer
    // links:
    //  docLink: http://sql2x.org/documentationLink/3f4b94b2-708b-4e8d-847b-2dcf1a60839d
    public partial class CrudeFinancialFareBusiness {
        
        // fetch by Primary key into current object
        // fetch by Primary key into current object
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  financialFareId: primary key of table financial_fare
        public CrudeFinancialFareModel FetchByFinancialFareId(System.Guid financialFareId) {
            var dataAccessLayer = new CrudeFinancialFareData();
            var model = new CrudeFinancialFareModel();

            dataAccessLayer.FetchByFinancialFareId(financialFareId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // fetch by Search key into current object
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialFareTypeRcd: key of table financial_fare
        public List<CrudeFinancialFareModel> FetchByFinancialFareTypeRcd(string financialFareTypeRcd) {
            return DataListToModelList(CrudeFinancialFareData.FetchByFinancialFareTypeRcd(financialFareTypeRcd));
        }
        
        // fetch by Search key into current object
        // fetch by Search key into current object
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DepartureAirportId: key of table financial_fare
        public List<CrudeFinancialFareModel> FetchByDepartureAirportId(System.Guid departureAirportId) {
            return DataListToModelList(CrudeFinancialFareData.FetchByDepartureAirportId(departureAirportId));
        }
        
        // fetch by Search key into current object
        // fetch by Search key into current object
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  ArrivalAirportId: key of table financial_fare
        public List<CrudeFinancialFareModel> FetchByArrivalAirportId(System.Guid arrivalAirportId) {
            return DataListToModelList(CrudeFinancialFareData.FetchByArrivalAirportId(arrivalAirportId));
        }
        
        // fetch by Search key into current object
        // fetch by Search key into current object
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FinancialCurrencyId: key of table financial_fare
        public List<CrudeFinancialFareModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialFareData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Search key into current object
        // fetch by Search key into current object
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table financial_fare
        public List<CrudeFinancialFareModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialFareData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // transfer data list to model list
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeFinancialFareData: object instance of FinancialFare
        public static List<CrudeFinancialFareModel> DataListToModelList(List<CrudeFinancialFareData> dataList) {
            var modelList = new List<CrudeFinancialFareModel>();

            foreach (CrudeFinancialFareData data in dataList) {
                var model = new CrudeFinancialFareModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // transfer model list to data list
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeFinancialFareData: object instance of FinancialFare
        public static void ModelListToDataList(List<CrudeFinancialFareModel> modelList, List<CrudeFinancialFareData> dataList) {
            foreach (CrudeFinancialFareModel model in modelList) {
                var data = new CrudeFinancialFareData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeFinancialFareData to a List of REST Contracts
        // copy all rows from a List of data objects in CrudeFinancialFareData to a List of REST Contracts
        // copy all rows from a List of data objects in CrudeFinancialFareData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeFinancialFareModel> FetchAll() {
            var list = new List<CrudeFinancialFareModel>();
            List<CrudeFinancialFareData> dataList = CrudeFinancialFareData.FetchAll();

            foreach (CrudeFinancialFareData crudeFinancialFareBusiness in dataList) {
                var model = new CrudeFinancialFareModel();
                DataToModel(crudeFinancialFareBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // fetch all rows from table with a limit of rows
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeFinancialFareModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialFareModel>();
            List<CrudeFinancialFareData> dataList = CrudeFinancialFareData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialFareData crudeFinancialFareBusiness in dataList) {
                var model = new CrudeFinancialFareModel();
                DataToModel(crudeFinancialFareBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // fetch all rows from table with an offset, and limit of rows
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeFinancialFareModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialFareModel>();
            List<CrudeFinancialFareData> dataList = CrudeFinancialFareData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialFareData crudeFinancialFareBusiness in dataList) {
                var model = new CrudeFinancialFareModel();
                DataToModel(crudeFinancialFareBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // get a count of rows in table
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeFinancialFareData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // fetch all from table into new List of class instances, filtered by any column
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeFinancialFareModel> FetchWithFilter(System.Guid financialFareId, string financialFareTypeRcd, System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime validFromFlightDateTime, System.DateTime validUntilFlightDateTime, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialFareModel>();
            List<CrudeFinancialFareData> dataList = CrudeFinancialFareData.FetchWithFilter(financialFareId,financialFareTypeRcd,departureAirportId,arrivalAirportId,validFromFlightDateTime,validUntilFlightDateTime,amount,financialCurrencyId,userId,dateTime);

            foreach (CrudeFinancialFareData data in dataList) {
                var crudeFinancialFareBusinessModel = new CrudeFinancialFareModel();
                DataToModel(data, crudeFinancialFareBusinessModel);
                list.Add(crudeFinancialFareBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // transfer model to data and insert
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeFinancialFareModel model) {
            var data = new CrudeFinancialFareData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // transfer model to data and insert, on transaction
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeFinancialFareModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFareData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // transfer model to data and update
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeFinancialFareModel model) {
            var data = new CrudeFinancialFareData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // transfer model to data and update, on a transaction
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeFinancialFareModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialFareData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // delete row
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid financialFareId) {
            CrudeFinancialFareData.Delete(financialFareId);
        }
        
        // transfer model object to data object
        // transfer model object to data object
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeFinancialFareModel model, CrudeFinancialFareData data) {
            data.FinancialFareId = model.FinancialFareId;
            data.FinancialFareTypeRcd = model.FinancialFareTypeRcd;
            data.DepartureAirportId = model.DepartureAirportId;
            data.ArrivalAirportId = model.ArrivalAirportId;
            data.ValidFromFlightDateTime = model.ValidFromFlightDateTime;
            data.ValidUntilFlightDateTime = model.ValidUntilFlightDateTime;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // transfer data object to model object
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeFinancialFareData data, CrudeFinancialFareModel model) {
            model.FinancialFareId = data.FinancialFareId;
            model.FinancialFareTypeRcd = data.FinancialFareTypeRcd;
            model.DepartureAirportId = data.DepartureAirportId;
            model.ArrivalAirportId = data.ArrivalAirportId;
            model.ValidFromFlightDateTime = data.ValidFromFlightDateTime;
            model.ValidUntilFlightDateTime = data.ValidUntilFlightDateTime;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
