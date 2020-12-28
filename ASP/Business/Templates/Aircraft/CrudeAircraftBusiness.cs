/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:20:13 PM
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
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/15abf34a-dec0-46df-8ef1-15d4f2eb7dd0
// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/5b274d55-8093-4652-bf16-8b8d1155bea9
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this interface is used to expose POCO classes
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/3f4b94b2-708b-4e8d-847b-2dcf1a60839d
    public partial class CrudeAircraftBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  CrudeAircraftData: primary key of table CrudeAircraftData
        public CrudeAircraftModel FetchByAircraftId(System.Guid aircraftId) {
            var dataAccessLayer = new CrudeAircraftData();
            var model = new CrudeAircraftModel();

            dataAccessLayer.FetchByAircraftId(aircraftId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/ad2dd952-e3ec-471a-9e34-f5fc965b8b37
        // parameters:
        //  AircraftName: key of table CrudeAircraftData
        public CrudeAircraftModel FetchByAircraftName(string aircraftName) {
            var dataAccessLayer = new CrudeAircraftData();
            var model = new CrudeAircraftModel();

            dataAccessLayer.FetchByAircraftName(aircraftName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AircraftTypeRcd: key of table CrudeAircraftData
        public List<CrudeAircraftModel> FetchByAircraftTypeRcd(string aircraftTypeRcd) {
            return DataListToModelList(CrudeAircraftData.FetchByAircraftTypeRcd(aircraftTypeRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AircraftConfigurationRcd: key of table CrudeAircraftData
        public List<CrudeAircraftModel> FetchByAircraftConfigurationRcd(string aircraftConfigurationRcd) {
            return DataListToModelList(CrudeAircraftData.FetchByAircraftConfigurationRcd(aircraftConfigurationRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AircraftBodyRcd: key of table CrudeAircraftData
        public List<CrudeAircraftModel> FetchByAircraftBodyRcd(string aircraftBodyRcd) {
            return DataListToModelList(CrudeAircraftData.FetchByAircraftBodyRcd(aircraftBodyRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AircraftMeasurementId: key of table CrudeAircraftData
        public List<CrudeAircraftModel> FetchByAircraftMeasurementId(System.Guid aircraftMeasurementId) {
            return DataListToModelList(CrudeAircraftData.FetchByAircraftMeasurementId(aircraftMeasurementId));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  ProductId: key of table CrudeAircraftData
        public List<CrudeAircraftModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeAircraftData.FetchByProductId(productId));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table CrudeAircraftData
        public List<CrudeAircraftModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeAircraftData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeAircraftData: key of table CrudeAircraftData
        public static List<CrudeAircraftModel> DataListToModelList(List<CrudeAircraftData> dataList) {
            var modelList = new List<CrudeAircraftModel>();

            foreach (CrudeAircraftData data in dataList) {
                var model = new CrudeAircraftModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeAircraftData: key of table CrudeAircraftData
        public static void ModelListToDataList(List<CrudeAircraftModel> modelList, List<CrudeAircraftData> dataList) {
            foreach (CrudeAircraftModel model in modelList) {
                var data = new CrudeAircraftData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeAircraftData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeAircraftModel> FetchAll() {
            var list = new List<CrudeAircraftModel>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchAll();

            foreach (CrudeAircraftData crudeAircraftBusiness in dataList) {
                var model = new CrudeAircraftModel();
                DataToModel(crudeAircraftBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeAircraftModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeAircraftModel>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeAircraftData crudeAircraftBusiness in dataList) {
                var model = new CrudeAircraftModel();
                DataToModel(crudeAircraftBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeAircraftModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeAircraftModel>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeAircraftData crudeAircraftBusiness in dataList) {
                var model = new CrudeAircraftModel();
                DataToModel(crudeAircraftBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeAircraftData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeAircraftModel> FetchWithFilter(System.Guid aircraftId, string aircraftName, string aircraftTypeRcd, string aircraftConfigurationRcd, string aircraftBodyRcd, System.Guid aircraftMeasurementId, System.Guid productId, System.DateTime operationalDateTime, System.DateTime firstFlightDateTime, string engineType, int passengerCapacity, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeAircraftModel>();
            List<CrudeAircraftData> dataList = CrudeAircraftData.FetchWithFilter(aircraftId,aircraftName,aircraftTypeRcd,aircraftConfigurationRcd,aircraftBodyRcd,aircraftMeasurementId,productId,operationalDateTime,firstFlightDateTime,engineType,passengerCapacity,userId,dateTime);

            foreach (CrudeAircraftData data in dataList) {
                var crudeAircraftBusinessModel = new CrudeAircraftModel();
                DataToModel(data, crudeAircraftBusinessModel);
                list.Add(crudeAircraftBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeAircraftModel model) {
            var data = new CrudeAircraftData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeAircraftModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeAircraftData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeAircraftModel model) {
            var data = new CrudeAircraftData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeAircraftModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeAircraftData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid aircraftId) {
            CrudeAircraftData.Delete(aircraftId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeAircraftModel model, CrudeAircraftData data) {
            data.AircraftId = model.AircraftId;
            data.AircraftName = model.AircraftName;
            data.AircraftTypeRcd = model.AircraftTypeRcd;
            data.AircraftConfigurationRcd = model.AircraftConfigurationRcd;
            data.AircraftBodyRcd = model.AircraftBodyRcd;
            data.AircraftMeasurementId = model.AircraftMeasurementId;
            data.ProductId = model.ProductId;
            data.OperationalDateTime = model.OperationalDateTime;
            data.FirstFlightDateTime = model.FirstFlightDateTime;
            data.EngineType = model.EngineType;
            data.PassengerCapacity = model.PassengerCapacity;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeAircraftData data, CrudeAircraftModel model) {
            model.AircraftId = data.AircraftId;
            model.AircraftName = data.AircraftName;
            model.AircraftTypeRcd = data.AircraftTypeRcd;
            model.AircraftConfigurationRcd = data.AircraftConfigurationRcd;
            model.AircraftBodyRcd = data.AircraftBodyRcd;
            model.AircraftMeasurementId = data.AircraftMeasurementId;
            model.ProductId = data.ProductId;
            model.OperationalDateTime = data.OperationalDateTime;
            model.FirstFlightDateTime = data.FirstFlightDateTime;
            model.EngineType = data.EngineType;
            model.PassengerCapacity = data.PassengerCapacity;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
