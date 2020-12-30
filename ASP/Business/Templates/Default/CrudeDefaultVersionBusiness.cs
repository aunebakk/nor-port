/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:08:20 PM
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
    public partial class CrudeDefaultVersionBusiness {
        
        // fetch by Primary key into current object
        // fetch by Primary key into current object
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  defaultVersionId: primary key of table default_version
        public CrudeDefaultVersionModel FetchByDefaultVersionId(System.Guid defaultVersionId) {
            var dataAccessLayer = new CrudeDefaultVersionData();
            var model = new CrudeDefaultVersionModel();

            dataAccessLayer.FetchByDefaultVersionId(defaultVersionId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // fetch by Search key into current object
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DefaultUserId: key of table default_version
        public List<CrudeDefaultVersionModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultVersionData.FetchByDefaultUserId(defaultUserId));
        }
        
        // transfer data list to model list
        // transfer data list to model list
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeDefaultVersionData: object instance of DefaultVersion
        public static List<CrudeDefaultVersionModel> DataListToModelList(List<CrudeDefaultVersionData> dataList) {
            var modelList = new List<CrudeDefaultVersionModel>();

            foreach (CrudeDefaultVersionData data in dataList) {
                var model = new CrudeDefaultVersionModel();
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
        //  CrudeDefaultVersionData: object instance of DefaultVersion
        public static void ModelListToDataList(List<CrudeDefaultVersionModel> modelList, List<CrudeDefaultVersionData> dataList) {
            foreach (CrudeDefaultVersionModel model in modelList) {
                var data = new CrudeDefaultVersionData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeDefaultVersionData to a List of REST Contracts
        // copy all rows from a List of data objects in CrudeDefaultVersionData to a List of REST Contracts
        // copy all rows from a List of data objects in CrudeDefaultVersionData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeDefaultVersionModel> FetchAll() {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAll();

            foreach (CrudeDefaultVersionData crudeDefaultVersionBusiness in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(crudeDefaultVersionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // fetch all rows from table with a limit of rows
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeDefaultVersionModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultVersionData crudeDefaultVersionBusiness in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(crudeDefaultVersionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // fetch all rows from table with an offset, and limit of rows
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeDefaultVersionModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultVersionData crudeDefaultVersionBusiness in dataList) {
                var model = new CrudeDefaultVersionModel();
                DataToModel(crudeDefaultVersionBusiness, model);
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
            return CrudeDefaultVersionData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // fetch all from table into new List of class instances, filtered by any column
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeDefaultVersionModel> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultVersionModel>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchWithFilter(defaultVersionId,funVersion,number,majorNumber,minorNumber,sequenceNumber,defaultUserId,dateTime);

            foreach (CrudeDefaultVersionData data in dataList) {
                var crudeDefaultVersionBusinessModel = new CrudeDefaultVersionModel();
                DataToModel(data, crudeDefaultVersionBusinessModel);
                list.Add(crudeDefaultVersionBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // transfer model to data and insert
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeDefaultVersionModel model) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // transfer model to data and insert, on transaction
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeDefaultVersionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // transfer model to data and update
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeDefaultVersionModel model) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // transfer model to data and update, on a transaction
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeDefaultVersionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // delete row
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid defaultVersionId) {
            CrudeDefaultVersionData.Delete(defaultVersionId);
        }
        
        // transfer model object to data object
        // transfer model object to data object
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeDefaultVersionModel model, CrudeDefaultVersionData data) {
            data.DefaultVersionId = model.DefaultVersionId;
            data.FunVersion = model.FunVersion;
            data.Number = model.Number;
            data.MajorNumber = model.MajorNumber;
            data.MinorNumber = model.MinorNumber;
            data.SequenceNumber = model.SequenceNumber;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // transfer data object to model object
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeDefaultVersionData data, CrudeDefaultVersionModel model) {
            model.DefaultVersionId = data.DefaultVersionId;
            model.FunVersion = data.FunVersion;
            model.Number = data.Number;
            model.MajorNumber = data.MajorNumber;
            model.MinorNumber = data.MinorNumber;
            model.SequenceNumber = data.SequenceNumber;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
