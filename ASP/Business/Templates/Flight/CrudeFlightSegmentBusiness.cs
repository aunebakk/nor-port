﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:30:12 PM
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
    public partial class CrudeFlightSegmentBusiness {
        
        // fetch by Primary key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/fdcc33b4-08f1-43c3-ae28-95fbf029c3bd
        // parameters:
        //  CrudeFlightSegmentData: primary key of table CrudeFlightSegmentData
        public CrudeFlightSegmentModel FetchByFlightSegmentId(System.Guid flightSegmentId) {
            var dataAccessLayer = new CrudeFlightSegmentData();
            var model = new CrudeFlightSegmentModel();

            dataAccessLayer.FetchByFlightSegmentId(flightSegmentId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  FlightId: key of table CrudeFlightSegmentData
        public List<CrudeFlightSegmentModel> FetchByFlightId(System.Guid flightId) {
            return DataListToModelList(CrudeFlightSegmentData.FetchByFlightId(flightId));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  DepartureAirportId: key of table CrudeFlightSegmentData
        public List<CrudeFlightSegmentModel> FetchByDepartureAirportId(System.Guid departureAirportId) {
            return DataListToModelList(CrudeFlightSegmentData.FetchByDepartureAirportId(departureAirportId));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  ArrivalAirportId: key of table CrudeFlightSegmentData
        public List<CrudeFlightSegmentModel> FetchByArrivalAirportId(System.Guid arrivalAirportId) {
            return DataListToModelList(CrudeFlightSegmentData.FetchByArrivalAirportId(arrivalAirportId));
        }
        
        // fetch by Search key into current object
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/87368fa6-b618-4f0c-acbb-1fc4e273bb2d
        // parameters:
        //  UserId: key of table CrudeFlightSegmentData
        public List<CrudeFlightSegmentModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFlightSegmentData.FetchByUserId(userId));
        }
        
        // transfer data list to model list
        // links:
        //  crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
        //  docLink: http://sql2x.org/documentationLink/b8ab5693-f2f2-494f-883e-89b617113511
        // parameters:
        //  CrudeFlightSegmentData: key of table CrudeFlightSegmentData
        public static List<CrudeFlightSegmentModel> DataListToModelList(List<CrudeFlightSegmentData> dataList) {
            var modelList = new List<CrudeFlightSegmentModel>();

            foreach (CrudeFlightSegmentData data in dataList) {
                var model = new CrudeFlightSegmentModel();
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
        //  CrudeFlightSegmentData: key of table CrudeFlightSegmentData
        public static void ModelListToDataList(List<CrudeFlightSegmentModel> modelList, List<CrudeFlightSegmentData> dataList) {
            foreach (CrudeFlightSegmentModel model in modelList) {
                var data = new CrudeFlightSegmentData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeFlightSegmentData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d3e60c3-69e4-43d6-8bd5-14a67a6ecf58
        public List<CrudeFlightSegmentModel> FetchAll() {
            var list = new List<CrudeFlightSegmentModel>();
            List<CrudeFlightSegmentData> dataList = CrudeFlightSegmentData.FetchAll();

            foreach (CrudeFlightSegmentData crudeFlightSegmentBusiness in dataList) {
                var model = new CrudeFlightSegmentModel();
                DataToModel(crudeFlightSegmentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with a limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/6028cc89-271d-4e09-b157-d1016dcaf85e
        public List<CrudeFlightSegmentModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFlightSegmentModel>();
            List<CrudeFlightSegmentData> dataList = CrudeFlightSegmentData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFlightSegmentData crudeFlightSegmentBusiness in dataList) {
                var model = new CrudeFlightSegmentModel();
                DataToModel(crudeFlightSegmentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // fetch all rows from table with an offset, and limit of rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/a87e5c54-b47e-4031-bc3b-837b4cf9f692
        public List<CrudeFlightSegmentModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFlightSegmentModel>();
            List<CrudeFlightSegmentData> dataList = CrudeFlightSegmentData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFlightSegmentData crudeFlightSegmentBusiness in dataList) {
                var model = new CrudeFlightSegmentModel();
                DataToModel(crudeFlightSegmentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/39677f9e-daee-45c6-9527-da98a0d7958d
        public int FetchAllCount() {
            return CrudeFlightSegmentData.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/db27658d-4d23-46d7-9970-7bbaef8634b0
        public List<CrudeFlightSegmentModel> FetchWithFilter(System.Guid flightSegmentId, System.Guid flightId, System.Guid departureAirportId, System.Guid arrivalAirportId, int logicalSegmentNumber, int physicalSegmentNumber, System.DateTime fromDateTime, System.DateTime untilDateTime, string departureGate, string arrivalGate, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFlightSegmentModel>();
            List<CrudeFlightSegmentData> dataList = CrudeFlightSegmentData.FetchWithFilter(flightSegmentId,flightId,departureAirportId,arrivalAirportId,logicalSegmentNumber,physicalSegmentNumber,fromDateTime,untilDateTime,departureGate,arrivalGate,userId,dateTime);

            foreach (CrudeFlightSegmentData data in dataList) {
                var crudeFlightSegmentBusinessModel = new CrudeFlightSegmentModel();
                DataToModel(data, crudeFlightSegmentBusinessModel);
                list.Add(crudeFlightSegmentBusinessModel);
            }

            return list;
        }
        
        // transfer model to data and insert
        // links:
        //  docLink: http://sql2x.org/documentationLink/17cd8423-3c78-459f-a45b-773fcfbc3b7d
        public void Insert(CrudeFlightSegmentModel model) {
            var data = new CrudeFlightSegmentData();
            ModelToData(model, data);
            data.Insert();
        }
        
        // transfer model to data and insert, on transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/fbeb7c34-b2d7-403b-a9fd-503ab705ef81
        public void Insert(CrudeFlightSegmentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFlightSegmentData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        // transfer model to data and update
        // links:
        //  docLink: http://sql2x.org/documentationLink/658fda50-2ad3-414e-9299-2b399d17a057
        public void Update(CrudeFlightSegmentModel model) {
            var data = new CrudeFlightSegmentData();
            ModelToData(model, data);
            data.Update();
        }
        
        // transfer model to data and update, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/aa07e05b-edc8-4e09-bf93-bf2a40c93c09
        public void Update(CrudeFlightSegmentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFlightSegmentData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        // delete row
        // links:
        //  docLink: http://sql2x.org/documentationLink/59823bf7-4ad8-4684-a48b-2abd49c607ee
        public void Delete(System.Guid flightSegmentId) {
            CrudeFlightSegmentData.Delete(flightSegmentId);
        }
        
        // transfer model object to data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/95875d99-b7f7-4a9e-baa4-3fbe9925d8a2
        public static void ModelToData(CrudeFlightSegmentModel model, CrudeFlightSegmentData data) {
            data.FlightSegmentId = model.FlightSegmentId;
            data.FlightId = model.FlightId;
            data.DepartureAirportId = model.DepartureAirportId;
            data.ArrivalAirportId = model.ArrivalAirportId;
            data.LogicalSegmentNumber = model.LogicalSegmentNumber;
            data.PhysicalSegmentNumber = model.PhysicalSegmentNumber;
            data.FromDateTime = model.FromDateTime;
            data.UntilDateTime = model.UntilDateTime;
            data.DepartureGate = model.DepartureGate;
            data.ArrivalGate = model.ArrivalGate;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        // transfer data object to model object
        // links:
        //  docLink: http://sql2x.org/documentationLink/43d57600-5ff5-4ef8-9330-123773d100d3
        public static void DataToModel(CrudeFlightSegmentData data, CrudeFlightSegmentModel model) {
            model.FlightSegmentId = data.FlightSegmentId;
            model.FlightId = data.FlightId;
            model.DepartureAirportId = data.DepartureAirportId;
            model.ArrivalAirportId = data.ArrivalAirportId;
            model.LogicalSegmentNumber = data.LogicalSegmentNumber;
            model.PhysicalSegmentNumber = data.PhysicalSegmentNumber;
            model.FromDateTime = data.FromDateTime;
            model.UntilDateTime = data.UntilDateTime;
            model.DepartureGate = data.DepartureGate;
            model.ArrivalGate = data.ArrivalGate;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}