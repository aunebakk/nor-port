/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 4:18:52 PM
  From Machine: DESKTOP-LSRVP12
  Filename: FinancialPayment.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialPaymentService")]
    public partial interface ICrudeFinancialPaymentService {
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/70a1f934-1d8a-43a0-8896-3ec370944938
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentIdRespons" +
            "e")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract FetchByFinancialPaymentId(System.Guid financialPaymentId);
        
        // fetch all rows matching foreign key: FinancialPaymentCardId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCardId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCardIdRes" +
            "ponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId);
        
        // fetch all rows matching foreign key: FinancialPaymentCashId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCashId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCashIdRes" +
            "ponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId);
        
        // fetch all rows matching foreign key: FinancialPaymentVoucherId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentVoucherId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentVoucherId" +
            "Response")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId);
        
        // fetch all rows matching foreign key: FinancialPaymentCouponId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCouponId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentCouponIdR" +
            "esponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId);
        
        // fetch all rows matching foreign key: FinancialPaymentBankId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentBankId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentBankIdRes" +
            "ponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId);
        
        // fetch all rows matching foreign key: FinancialPaymentAccountingId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentAccountin" +
            "gId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentAccountin" +
            "gIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId);
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchByFinancialPaymentTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd);
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/54a1998f-1667-4680-ae80-cb0c31dd5872
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/InsertResponse")]
        void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract contract);
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/c1ccee6d-504c-4fe8-bf7c-57624012598a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/UpdateResponse")]
        void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract contract);
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d2e5c69-6801-43a2-9daf-0ff04fa6c996
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/DeleteResponse")]
        void Delete(System.Guid financialPaymentId);
        
        // fetch all rows from table financial_payment into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ac8b1d2-0562-43e9-b63f-8973ca381a0a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/7e45d3c9-f66e-4ad7-8620-df8a4eae6177
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/886cf296-7b9c-4a1a-8b40-8150e605ba11
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/dd08755c-f264-4c12-8d69-18c190b13a6e
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/754c25f9-c499-45f3-9fdb-03850db5c79d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialPaymentService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialPaymentService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCouponId, System.Guid financialPaymentBankId, System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime);
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/ccc2e33d-a5a7-4751-a433-07dd3f2b90a4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialPaymentServiceChannel : ICrudeFinancialPaymentService, System.ServiceModel.IClientChannel {
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/2ec85c1f-4aad-46ef-a4d4-179312974bf1
    public class CrudeFinancialPaymentServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialPaymentService>, ICrudeFinancialPaymentService {
        
        public CrudeFinancialPaymentServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9b6c163a-8411-40ba-bb08-e390673c9ab3
        public CrudeFinancialPaymentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialPaymentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialPaymentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/0bf226bb-0d8e-4930-90b9-d0e53a1f9c2a
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return base.Channel.FetchByFinancialPaymentId(financialPaymentId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentCardId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            return base.Channel.FetchByFinancialPaymentCardId(financialPaymentCardId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentCashId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            return base.Channel.FetchByFinancialPaymentCashId(financialPaymentCashId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentVoucherId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            return base.Channel.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentCouponId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            return base.Channel.FetchByFinancialPaymentCouponId(financialPaymentCouponId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentBankId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            return base.Channel.FetchByFinancialPaymentBankId(financialPaymentBankId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentAccountingId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            return base.Channel.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
        }
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentTypeRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            return base.Channel.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/606647e9-2bdb-4b55-9541-449812c123d2
        public void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/cda8cbb1-dc3e-461a-8c98-5c277efe7e86
        public void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/8513f38a-4552-4020-95b2-78c872a82ffe
        public void Delete(System.Guid financialPaymentId) {
            base.Channel.Delete(financialPaymentId);
        }
        
        // fetch all rows from table financial_payment into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/168c348a-8e3d-463e-8e60-727047f10afc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/05a908ff-897b-49a5-a5e4-fd57e1ddca0d
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9ac77a1-e367-4bbd-89ed-c65f56d14f3c
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
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
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialPaymentContract> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCouponId, System.Guid financialPaymentBankId, System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialPaymentId: financialPaymentId,
                financialPaymentTypeRcd: financialPaymentTypeRcd,
                financialPaymentCardId: financialPaymentCardId,
                financialPaymentCashId: financialPaymentCashId,
                financialPaymentVoucherId: financialPaymentVoucherId,
                financialPaymentCouponId: financialPaymentCouponId,
                financialPaymentBankId: financialPaymentBankId,
                financialPaymentAccountingId: financialPaymentAccountingId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
