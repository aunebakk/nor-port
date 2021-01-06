/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:14:03 AM
  From Machine: DESKTOP-LSRVP12
  Filename: Passenger.json
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

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/8638d459-df50-43f0-9fb3-f120e7937ccb
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudePassengerService")]
    public partial interface ICrudePassengerService {
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/70a1f934-1d8a-43a0-8896-3ec370944938
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByPassengerId", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByPassengerIdResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract FetchByPassengerId(System.Guid passengerId);
        
        // fetch all rows matching foreign key: BecamePassengerId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByBecamePassengerId", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByBecamePassengerIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByBecamePassengerId(System.Guid becamePassengerId);
        
        // fetch all rows matching foreign key: BindingPassengerId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByBindingPassengerId", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByBindingPassengerIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByBindingPassengerId(System.Guid bindingPassengerId);
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByPassengerTypeRcd", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByPassengerTypeRcdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByPassengerTypeRcd(string passengerTypeRcd);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByDefaultStateRcd", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByDefaultStateRcdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByDefaultStateRcd(string defaultStateRcd);
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/54a1998f-1667-4680-ae80-cb0c31dd5872
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/Insert", ReplyAction="http://tempuri.org/ICrudePassengerService/InsertResponse")]
        void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract contract);
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/c1ccee6d-504c-4fe8-bf7c-57624012598a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/Update", ReplyAction="http://tempuri.org/ICrudePassengerService/UpdateResponse")]
        void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract contract);
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d2e5c69-6801-43a2-9daf-0ff04fa6c996
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/Delete", ReplyAction="http://tempuri.org/ICrudePassengerService/DeleteResponse")]
        void Delete(System.Guid passengerId);
        
        // fetch by Picker Member into new class instance
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f612728-6fe0-427e-aed2-1be23a33d821
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchByPassengerName", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchByPassengerNameResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract FetchByPassengerName(string passengerName);
        
        // fetch all rows from table passenger into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ac8b1d2-0562-43e9-b63f-8973ca381a0a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchAll", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchAllResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/7e45d3c9-f66e-4ad7-8620-df8a4eae6177
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/886cf296-7b9c-4a1a-8b40-8150e605ba11
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/dd08755c-f264-4c12-8d69-18c190b13a6e
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/754c25f9-c499-45f3-9fdb-03850db5c79d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudePassengerService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudePassengerService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchWithFilter(System.Guid passengerId, System.Guid becamePassengerId, System.Guid bindingPassengerId, string passengerTypeRcd, string passengerName, string defaultStateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/ccc2e33d-a5a7-4751-a433-07dd3f2b90a4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudePassengerServiceChannel : ICrudePassengerService, System.ServiceModel.IClientChannel {
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/2ec85c1f-4aad-46ef-a4d4-179312974bf1
    public class CrudePassengerServiceClient : System.ServiceModel.ClientBase<ICrudePassengerService>, ICrudePassengerService {
        
        public CrudePassengerServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9b6c163a-8411-40ba-bb08-e390673c9ab3
        public CrudePassengerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudePassengerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudePassengerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudePassengerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/0bf226bb-0d8e-4930-90b9-d0e53a1f9c2a
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract FetchByPassengerId(System.Guid passengerId) {
            return base.Channel.FetchByPassengerId(passengerId);
        }
        
        // fetch all rows matching foreign key: BecamePassengerId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByBecamePassengerId(System.Guid becamePassengerId) {
            return base.Channel.FetchByBecamePassengerId(becamePassengerId);
        }
        
        // fetch all rows matching foreign key: BindingPassengerId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByBindingPassengerId(System.Guid bindingPassengerId) {
            return base.Channel.FetchByBindingPassengerId(bindingPassengerId);
        }
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: PassengerTypeRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByPassengerTypeRcd(string passengerTypeRcd) {
            return base.Channel.FetchByPassengerTypeRcd(passengerTypeRcd);
        }
        
        // fetch all rows matching foreign key: DefaultStateRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchByDefaultStateRcd(string defaultStateRcd) {
            return base.Channel.FetchByDefaultStateRcd(defaultStateRcd);
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/606647e9-2bdb-4b55-9541-449812c123d2
        public void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/cda8cbb1-dc3e-461a-8c98-5c277efe7e86
        public void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/8513f38a-4552-4020-95b2-78c872a82ffe
        public void Delete(System.Guid passengerId) {
            base.Channel.Delete(passengerId);
        }
        
        // fetch by Picker Member into new class instance
        // links:
        //  docLink: http://sql2x.org/documentationLink/34a8863d-4df9-48e2-a23d-707b546d506b
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract FetchByPassengerName(string passengerName) {
            return base.Channel.FetchByPassengerName(passengerName);
        }
        
        // fetch all rows from table passenger into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/168c348a-8e3d-463e-8e60-727047f10afc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/05a908ff-897b-49a5-a5e4-fd57e1ddca0d
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9ac77a1-e367-4bbd-89ed-c65f56d14f3c
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchAllWithLimitAndOffset(int limit, int offset) {
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
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudePassengerContract> FetchWithFilter(System.Guid passengerId, System.Guid becamePassengerId, System.Guid bindingPassengerId, string passengerTypeRcd, string passengerName, string defaultStateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                passengerId: passengerId,
                becamePassengerId: becamePassengerId,
                bindingPassengerId: bindingPassengerId,
                passengerTypeRcd: passengerTypeRcd,
                passengerName: passengerName,
                defaultStateRcd: defaultStateRcd,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
