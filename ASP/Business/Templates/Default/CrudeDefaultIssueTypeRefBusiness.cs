﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 5:09:40 PM
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
    public partial class CrudeDefaultIssueTypeRefBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  defaultIssueTypeRcd: primary key of table default_issue_type_ref
        public CrudeDefaultIssueTypeRefModel FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var model = new CrudeDefaultIssueTypeRefModel();

            dataAccessLayer.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/ad2dd952-e3ec-471a-9e34-f5fc965b8b37
        // parameters:
        //  DefaultIssueTypeName: key of table CrudeDefaultIssueTypeRefData
        public CrudeDefaultIssueTypeRefModel FetchByDefaultIssueTypeName(string defaultIssueTypeName) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var model = new CrudeDefaultIssueTypeRefModel();

            dataAccessLayer.FetchByDefaultIssueTypeName(defaultIssueTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DefaultUserId: key of table default_issue_type_ref
        public List<CrudeDefaultIssueTypeRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultIssueTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeDefaultIssueTypeRefData: object instance of DefaultIssueTypeRef
        public static List<CrudeDefaultIssueTypeRefModel> DataListToModelList(List<CrudeDefaultIssueTypeRefData> dataList) {
            var modelList = new List<CrudeDefaultIssueTypeRefModel>();

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeDefaultIssueTypeRefData: object instance of DefaultIssueTypeRef
        public static void ModelListToDataList(List<CrudeDefaultIssueTypeRefModel> modelList, List<CrudeDefaultIssueTypeRefData> dataList) {
            foreach (CrudeDefaultIssueTypeRefModel model in modelList) {
                var data = new CrudeDefaultIssueTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeDefaultIssueTypeRefData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeDefaultIssueTypeRefModel> FetchAll() {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAll();

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRefBusiness in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(crudeDefaultIssueTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeDefaultIssueTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRefBusiness in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(crudeDefaultIssueTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeDefaultIssueTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRefBusiness in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(crudeDefaultIssueTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeDefaultIssueTypeRefData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeDefaultIssueTypeRefModel> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchWithFilter(defaultIssueTypeRcd,defaultIssueTypeName,defaultUserId,dateTime);

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var crudeDefaultIssueTypeRefBusinessModel = new CrudeDefaultIssueTypeRefModel();
                DataToModel(data, crudeDefaultIssueTypeRefBusinessModel);
                list.Add(crudeDefaultIssueTypeRefBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeDefaultIssueTypeRefModel model) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeDefaultIssueTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeDefaultIssueTypeRefModel model) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeDefaultIssueTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(string defaultIssueTypeRcd) {
            CrudeDefaultIssueTypeRefData.Delete(defaultIssueTypeRcd);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeDefaultIssueTypeRefModel model, CrudeDefaultIssueTypeRefData data) {
            data.DefaultIssueTypeRcd = model.DefaultIssueTypeRcd;
            data.DefaultIssueTypeName = model.DefaultIssueTypeName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeDefaultIssueTypeRefData data, CrudeDefaultIssueTypeRefModel model) {
            model.DefaultIssueTypeRcd = data.DefaultIssueTypeRcd;
            model.DefaultIssueTypeName = data.DefaultIssueTypeName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
