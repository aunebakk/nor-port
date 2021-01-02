﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 4:18:52 PM
  From Machine: DESKTOP-LSRVP12
  Filename: FlightScheduleSegmentRuleRef.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: DotNetFrameworkCrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
using System.Runtime.Serialization;
using System.Collections.Generic;

// Client Proxy Layer
// the ClientProxyLayer is where the SOAP services ties into the Client layer
//  this layer is used for, among other technologies, dotNetFramework WinForm,
//  ASP and TypeScript User Interfaces or from one business layer to another
// links:
//  docLink: http://sql2x.org/documentationLink/a58883c6-e6e2-4265-98ad-0268dbbdb1b1
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // this class is used to expose reference codes from the database
    // links:
    //  docLink: http://sql2x.org/documentationLink/77de0aeb-bfe6-4aa6-a070-ded79284f0d1
    public partial class FlightScheduleSegmentRuleRef {
        
        public const string NotOnFriday = "NoFriday";
        
        public const string NotOnMonday = "NoMonday";
        
        public const string NotOnSaturday = "NoSaturday";
        
        public const string NotOnSunday = "NoSunday";
        
        public const string NotOnThursday = "NoThursday";
        
        public const string NotOnTuesday = "NoTuesday";
        
        public const string NotOnWednesday = "NoWednesday";
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/8638d459-df50-43f0-9fb3-f120e7937ccb
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFlightScheduleSegmentRuleRefService")]
    public partial interface ICrudeFlightScheduleSegmentRuleRefService {
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/70a1f934-1d8a-43a0-8896-3ec370944938
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchByFlightSchedul" +
            "eSegmentRuleRcd", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchByFlightSchedul" +
            "eSegmentRuleRcdResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract FetchByFlightScheduleSegmentRuleRcd(string flightScheduleSegmentRuleRcd);
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchByUserIdRespons" +
            "e")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchByUserId(System.Guid userId);
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/54a1998f-1667-4680-ae80-cb0c31dd5872
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract contract);
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/c1ccee6d-504c-4fe8-bf7c-57624012598a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/Update", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract contract);
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d2e5c69-6801-43a2-9daf-0ff04fa6c996
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/DeleteResponse")]
        void Delete(string flightScheduleSegmentRuleRcd);
        
        // fetch by Picker Member into new class instance
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f612728-6fe0-427e-aed2-1be23a33d821
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchByFlightSchedul" +
            "eSegmentRuleName", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchByFlightSchedul" +
            "eSegmentRuleNameResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract FetchByFlightScheduleSegmentRuleName(string flightScheduleSegmentRuleName);
        
        // fetch all rows from table flight_schedule_segment_rule_ref into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ac8b1d2-0562-43e9-b63f-8973ca381a0a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/7e45d3c9-f66e-4ad7-8620-df8a4eae6177
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllWithLimitRes" +
            "ponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/886cf296-7b9c-4a1a-8b40-8150e605ba11
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllWithLimitAnd" +
            "Offset", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllWithLimitAnd" +
            "OffsetResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/dd08755c-f264-4c12-8d69-18c190b13a6e
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchAllCountRespons" +
            "e")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/754c25f9-c499-45f3-9fdb-03850db5c79d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFlightScheduleSegmentRuleRefService/FetchWithFilterRespo" +
            "nse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchWithFilter(string flightScheduleSegmentRuleRcd, string flightScheduleSegmentRuleName, System.Guid userId, System.DateTime dateTime);
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/ccc2e33d-a5a7-4751-a433-07dd3f2b90a4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFlightScheduleSegmentRuleRefServiceChannel : ICrudeFlightScheduleSegmentRuleRefService, System.ServiceModel.IClientChannel {
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/2ec85c1f-4aad-46ef-a4d4-179312974bf1
    public class CrudeFlightScheduleSegmentRuleRefServiceClient : System.ServiceModel.ClientBase<ICrudeFlightScheduleSegmentRuleRefService>, ICrudeFlightScheduleSegmentRuleRefService {
        
        public CrudeFlightScheduleSegmentRuleRefServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9b6c163a-8411-40ba-bb08-e390673c9ab3
        public CrudeFlightScheduleSegmentRuleRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFlightScheduleSegmentRuleRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFlightScheduleSegmentRuleRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFlightScheduleSegmentRuleRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/0bf226bb-0d8e-4930-90b9-d0e53a1f9c2a
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract FetchByFlightScheduleSegmentRuleRcd(string flightScheduleSegmentRuleRcd) {
            return base.Channel.FetchByFlightScheduleSegmentRuleRcd(flightScheduleSegmentRuleRcd);
        }
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/606647e9-2bdb-4b55-9541-449812c123d2
        public void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/cda8cbb1-dc3e-461a-8c98-5c277efe7e86
        public void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/8513f38a-4552-4020-95b2-78c872a82ffe
        public void Delete(string flightScheduleSegmentRuleRcd) {
            base.Channel.Delete(flightScheduleSegmentRuleRcd);
        }
        
        // fetch by Picker Member into new class instance
        // links:
        //  docLink: http://sql2x.org/documentationLink/34a8863d-4df9-48e2-a23d-707b546d506b
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract FetchByFlightScheduleSegmentRuleName(string flightScheduleSegmentRuleName) {
            return base.Channel.FetchByFlightScheduleSegmentRuleName(flightScheduleSegmentRuleName);
        }
        
        // fetch all rows from table flight_schedule_segment_rule_ref into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/168c348a-8e3d-463e-8e60-727047f10afc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/05a908ff-897b-49a5-a5e4-fd57e1ddca0d
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9ac77a1-e367-4bbd-89ed-c65f56d14f3c
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b5f68e2-e3e0-4f82-8f99-f3ce860dc8fe
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/c10bac90-d91e-47a6-bd52-f537c96471cd
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFlightScheduleSegmentRuleRefContract> FetchWithFilter(string flightScheduleSegmentRuleRcd, string flightScheduleSegmentRuleName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                flightScheduleSegmentRuleRcd: flightScheduleSegmentRuleRcd,
                flightScheduleSegmentRuleName: flightScheduleSegmentRuleName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
