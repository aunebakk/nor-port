/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:27:27 AM
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
    public partial class CrudeClientBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  clientId: primary key of table client
        public CrudeClientModel FetchByClientId(System.Guid clientId) {
            var dataAccessLayer = new CrudeClientData();
            var model = new CrudeClientModel();

            dataAccessLayer.FetchByClientId(clientId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/ad2dd952-e3ec-471a-9e34-f5fc965b8b37
        // parameters:
        //  FirstName: key of table CrudeClientData
        public CrudeClientModel FetchByFirstName(string firstName) {
            var dataAccessLayer = new CrudeClientData();
            var model = new CrudeClientModel();

            dataAccessLayer.FetchByFirstName(firstName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  AddressId: key of table client
        public List<CrudeClientModel> FetchByAddressId(System.Guid addressId) {
            return DataListToModelList(CrudeClientData.FetchByAddressId(addressId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DefaultUserId: key of table client
        public List<CrudeClientModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeClientData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  PassengerTypeRcd: key of table client
        public List<CrudeClientModel> FetchByPassengerTypeRcd(string passengerTypeRcd) {
            return DataListToModelList(CrudeClientData.FetchByPassengerTypeRcd(passengerTypeRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  NationalityRcd: key of table client
        public List<CrudeClientModel> FetchByNationalityRcd(string nationalityRcd) {
            return DataListToModelList(CrudeClientData.FetchByNationalityRcd(nationalityRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  GenderRcd: key of table client
        public List<CrudeClientModel> FetchByGenderRcd(string genderRcd) {
            return DataListToModelList(CrudeClientData.FetchByGenderRcd(genderRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  TitleRcd: key of table client
        public List<CrudeClientModel> FetchByTitleRcd(string titleRcd) {
            return DataListToModelList(CrudeClientData.FetchByTitleRcd(titleRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  ClientTypeRcd: key of table client
        public List<CrudeClientModel> FetchByClientTypeRcd(string clientTypeRcd) {
            return DataListToModelList(CrudeClientData.FetchByClientTypeRcd(clientTypeRcd));
        }
        
        // fetch by Search key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table client
        public List<CrudeClientModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeClientData: object instance of Client
        public static List<CrudeClientModel> DataListToModelList(List<CrudeClientData> dataList) {
            var modelList = new List<CrudeClientModel>();

            foreach (CrudeClientData data in dataList) {
                var model = new CrudeClientModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        // transfer model list to data list
        // links:
        //  docLink: http://sql2x.org/documentationLink/1d6a48d9-fe39-4397-b8fa-a332da164cbf
        // parameters:
        //  CrudeClientData: object instance of Client
        public static void ModelListToDataList(List<CrudeClientModel> modelList, List<CrudeClientData> dataList) {
            foreach (CrudeClientModel model in modelList) {
                var data = new CrudeClientData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of data objects in CrudeClientData to a List of REST Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeClientModel> FetchAll() {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAll();

            foreach (CrudeClientData crudeClientBusiness in dataList) {
                var model = new CrudeClientModel();
                DataToModel(crudeClientBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeClientModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientData crudeClientBusiness in dataList) {
                var model = new CrudeClientModel();
                DataToModel(crudeClientBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeClientModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientData crudeClientBusiness in dataList) {
                var model = new CrudeClientModel();
                DataToModel(crudeClientBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeClientData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeClientModel> FetchWithFilter(System.Guid clientId, string firstName, string middleName, string lastName, System.Guid addressId, System.Guid defaultUserId, string passengerTypeRcd, string nationalityRcd, string genderRcd, string titleRcd, string clientTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchWithFilter(clientId,firstName,middleName,lastName,addressId,defaultUserId,passengerTypeRcd,nationalityRcd,genderRcd,titleRcd,clientTypeRcd,userId,dateTime);

            foreach (CrudeClientData data in dataList) {
                var crudeClientBusinessModel = new CrudeClientModel();
                DataToModel(data, crudeClientBusinessModel);
                list.Add(crudeClientBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeClientModel model) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeClientModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeClientModel model) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeClientModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid clientId) {
            CrudeClientData.Delete(clientId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeClientModel model, CrudeClientData data) {
            data.ClientId = model.ClientId;
            data.FirstName = model.FirstName;
            data.MiddleName = model.MiddleName;
            data.LastName = model.LastName;
            data.AddressId = model.AddressId;
            data.DefaultUserId = model.DefaultUserId;
            data.PassengerTypeRcd = model.PassengerTypeRcd;
            data.NationalityRcd = model.NationalityRcd;
            data.GenderRcd = model.GenderRcd;
            data.TitleRcd = model.TitleRcd;
            data.ClientTypeRcd = model.ClientTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeClientData data, CrudeClientModel model) {
            model.ClientId = data.ClientId;
            model.FirstName = data.FirstName;
            model.MiddleName = data.MiddleName;
            model.LastName = data.LastName;
            model.AddressId = data.AddressId;
            model.DefaultUserId = data.DefaultUserId;
            model.PassengerTypeRcd = data.PassengerTypeRcd;
            model.NationalityRcd = data.NationalityRcd;
            model.GenderRcd = data.GenderRcd;
            model.TitleRcd = data.TitleRcd;
            model.ClientTypeRcd = data.ClientTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
