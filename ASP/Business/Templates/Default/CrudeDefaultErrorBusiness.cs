/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 12:55:43 PM
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
    public partial class CrudeDefaultErrorBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  defaultErrorId: primary key of table default_error
        public CrudeDefaultErrorModel FetchByDefaultErrorId(System.Guid defaultErrorId) {
            var dataAccessLayer = new CrudeDefaultErrorData();
            var model = new CrudeDefaultErrorModel();

            dataAccessLayer.FetchByDefaultErrorId(defaultErrorId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/ad2dd952-e3ec-471a-9e34-f5fc965b8b37
        // parameters:
        //  MethodName: key of table CrudeDefaultErrorData
        public CrudeDefaultErrorModel FetchByMethodName(string methodName) {
            var dataAccessLayer = new CrudeDefaultErrorData();
            var model = new CrudeDefaultErrorModel();

            dataAccessLayer.FetchByMethodName(methodName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DefaultErrorLayerRcd: key of table default_error
        public List<CrudeDefaultErrorModel> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return DataListToModelList(CrudeDefaultErrorData.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DefaultErrorTypeRcd: key of table default_error
        public List<CrudeDefaultErrorModel> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            return DataListToModelList(CrudeDefaultErrorData.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DefaultUserId: key of table default_error
        public List<CrudeDefaultErrorModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultErrorData.FetchByDefaultUserId(defaultUserId));
        }
        
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeDefaultErrorData: object instance of DefaultError
        public static List<CrudeDefaultErrorModel> DataListToModelList(List<CrudeDefaultErrorData> dataList) {
            var modelList = new List<CrudeDefaultErrorModel>();

            foreach (CrudeDefaultErrorData data in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeDefaultErrorData: object instance of DefaultError
        public static void ModelListToDataList(List<CrudeDefaultErrorModel> modelList, List<CrudeDefaultErrorData> dataList) {
            foreach (CrudeDefaultErrorModel model in modelList) {
                var data = new CrudeDefaultErrorData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeDefaultErrorData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeDefaultErrorModel> FetchAll() {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAll();

            foreach (CrudeDefaultErrorData crudeDefaultErrorBusiness in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(crudeDefaultErrorBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeDefaultErrorModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultErrorData crudeDefaultErrorBusiness in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(crudeDefaultErrorBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeDefaultErrorModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultErrorData crudeDefaultErrorBusiness in dataList) {
                var model = new CrudeDefaultErrorModel();
                DataToModel(crudeDefaultErrorBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeDefaultErrorData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeDefaultErrorModel> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorModel>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchWithFilter(defaultErrorId,defaultErrorLayerRcd,defaultErrorTypeRcd,layerAddress,errorMessage,stackTrace,methodName,domainName,className,defaultUserId,dateTime);

            foreach (CrudeDefaultErrorData data in dataList) {
                var crudeDefaultErrorBusinessModel = new CrudeDefaultErrorModel();
                DataToModel(data, crudeDefaultErrorBusinessModel);
                list.Add(crudeDefaultErrorBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeDefaultErrorModel model) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeDefaultErrorModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeDefaultErrorModel model) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeDefaultErrorModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid defaultErrorId) {
            CrudeDefaultErrorData.Delete(defaultErrorId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeDefaultErrorModel model, CrudeDefaultErrorData data) {
            data.DefaultErrorId = model.DefaultErrorId;
            data.DefaultErrorLayerRcd = model.DefaultErrorLayerRcd;
            data.DefaultErrorTypeRcd = model.DefaultErrorTypeRcd;
            data.LayerAddress = model.LayerAddress;
            data.ErrorMessage = model.ErrorMessage;
            data.StackTrace = model.StackTrace;
            data.MethodName = model.MethodName;
            data.DomainName = model.DomainName;
            data.ClassName = model.ClassName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeDefaultErrorData data, CrudeDefaultErrorModel model) {
            model.DefaultErrorId = data.DefaultErrorId;
            model.DefaultErrorLayerRcd = data.DefaultErrorLayerRcd;
            model.DefaultErrorTypeRcd = data.DefaultErrorTypeRcd;
            model.LayerAddress = data.LayerAddress;
            model.ErrorMessage = data.ErrorMessage;
            model.StackTrace = data.StackTrace;
            model.MethodName = data.MethodName;
            model.DomainName = data.DomainName;
            model.ClassName = data.ClassName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
