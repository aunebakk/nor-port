/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 10:34:53 AM
  From Machine: DESKTOP-LSRVP12
  Filename: FinancialBookingTransaction.json
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
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialBookingTransactionService")]
    public partial interface ICrudeFinancialBookingTransactionService {
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/70a1f934-1d8a-43a0-8896-3ec370944938
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialBooki" +
            "ngTransactionId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialBooki" +
            "ngTransactionIdResponse")]
        SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId);
        
        // fetch all rows matching foreign key: BookingId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByBookingId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByBookingIdRespo" +
            "nse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByBookingId(System.Guid bookingId);
        
        // fetch all rows matching foreign key: FinancialFeeId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialFeeId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialFeeId" +
            "Response")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialFeeId(System.Guid financialFeeId);
        
        // fetch all rows matching foreign key: FinancialTaxId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialTaxId" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialTaxId" +
            "Response")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialTaxId(System.Guid financialTaxId);
        
        // fetch all rows matching foreign key: FinancialFareId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialFareI" +
            "d", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialFareI" +
            "dResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialFareId(System.Guid financialFareId);
        
        // fetch all rows matching foreign key: FinancialPaymentId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialPayme" +
            "ntId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialPayme" +
            "ntIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialPaymentId(System.Guid financialPaymentId);
        
        // fetch all rows matching foreign key: FinancialCurrencyId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialCurre" +
            "ncyId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialCurre" +
            "ncyIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        // fetch all rows matching foreign key: FinancialCostcentreId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialCostc" +
            "entreId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialCostc" +
            "entreIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialCostcentreId(System.Guid financialCostcentreId);
        
        // fetch all rows matching foreign key: FinancialAdjustmentId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialAdjus" +
            "tmentId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialAdjus" +
            "tmentIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId);
        
        // fetch all rows matching foreign key: FinancialServiceId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialServi" +
            "ceId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialServi" +
            "ceIdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialServiceId(System.Guid financialServiceId);
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/d406f233-a526-4a0c-b685-872ce5bf4be2
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByUserIdResponse" +
            "")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        // links:
        //  docLink: http://sql2x.org/documentationLink/401902fa-bdbe-4daa-9c14-ae304acf2e0d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialBooki" +
            "ngTransactionTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchByFinancialBooki" +
            "ngTransactionTypeRcdResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialBookingTransactionTypeRcd(string financialBookingTransactionTypeRcd);
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/54a1998f-1667-4680-ae80-cb0c31dd5872
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/InsertResponse")]
        void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract contract);
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/c1ccee6d-504c-4fe8-bf7c-57624012598a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/UpdateResponse")]
        void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract contract);
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d2e5c69-6801-43a2-9daf-0ff04fa6c996
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/DeleteResponse")]
        void Delete(System.Guid financialBookingTransactionId);
        
        // fetch all rows from table financial_booking_transaction into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ac8b1d2-0562-43e9-b63f-8973ca381a0a
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/7e45d3c9-f66e-4ad7-8620-df8a4eae6177
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllWithLimitResp" +
            "onse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/886cf296-7b9c-4a1a-8b40-8150e605ba11
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/dd08755c-f264-4c12-8d69-18c190b13a6e
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/754c25f9-c499-45f3-9fdb-03850db5c79d
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialBookingTransactionService/FetchWithFilterRespon" +
            "se")]
        List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid bookingId, int transactionNumber, string financialBookingTransactionTypeRcd, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialFareId, System.Guid financialPaymentId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, System.Guid financialServiceId, System.Guid userId, System.DateTime dateTime);
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialBookingTransactionServiceChannel : ICrudeFinancialBookingTransactionService, System.ServiceModel.IClientChannel {
    }
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    public class CrudeFinancialBookingTransactionServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialBookingTransactionService>, ICrudeFinancialBookingTransactionService {
        
        public CrudeFinancialBookingTransactionServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9b6c163a-8411-40ba-bb08-e390673c9ab3
        public CrudeFinancialBookingTransactionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialBookingTransactionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialBookingTransactionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialBookingTransactionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/0bf226bb-0d8e-4930-90b9-d0e53a1f9c2a
        public SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            return base.Channel.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
        }
        
        // fetch all rows matching foreign key: BookingId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByBookingId(System.Guid bookingId) {
            return base.Channel.FetchByBookingId(bookingId);
        }
        
        // fetch all rows matching foreign key: FinancialFeeId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialFeeId(System.Guid financialFeeId) {
            return base.Channel.FetchByFinancialFeeId(financialFeeId);
        }
        
        // fetch all rows matching foreign key: FinancialTaxId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialTaxId(System.Guid financialTaxId) {
            return base.Channel.FetchByFinancialTaxId(financialTaxId);
        }
        
        // fetch all rows matching foreign key: FinancialFareId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialFareId(System.Guid financialFareId) {
            return base.Channel.FetchByFinancialFareId(financialFareId);
        }
        
        // fetch all rows matching foreign key: FinancialPaymentId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return base.Channel.FetchByFinancialPaymentId(financialPaymentId);
        }
        
        // fetch all rows matching foreign key: FinancialCurrencyId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        // fetch all rows matching foreign key: FinancialCostcentreId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return base.Channel.FetchByFinancialCostcentreId(financialCostcentreId);
        }
        
        // fetch all rows matching foreign key: FinancialAdjustmentId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            return base.Channel.FetchByFinancialAdjustmentId(financialAdjustmentId);
        }
        
        // fetch all rows matching foreign key: FinancialServiceId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialServiceId(System.Guid financialServiceId) {
            return base.Channel.FetchByFinancialServiceId(financialServiceId);
        }
        
        // fetch all rows matching foreign key: UserId
        // links:
        //  docLink: http://sql2x.org/documentationLink/7f3c31d9-2d99-4f93-b9b1-b866fa1c64dc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: FinancialBookingTransactionTypeRcd
        // links:
        //  docLink: http://sql2x.org/documentationLink/b6aae770-2299-4a5e-8ef5-0e23be13974e
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchByFinancialBookingTransactionTypeRcd(string financialBookingTransactionTypeRcd) {
            return base.Channel.FetchByFinancialBookingTransactionTypeRcd(financialBookingTransactionTypeRcd);
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/606647e9-2bdb-4b55-9541-449812c123d2
        public void Insert(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/cda8cbb1-dc3e-461a-8c98-5c277efe7e86
        public void Update(SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/8513f38a-4552-4020-95b2-78c872a82ffe
        public void Delete(System.Guid financialBookingTransactionId) {
            base.Channel.Delete(financialBookingTransactionId);
        }
        
        // fetch all rows from table financial_booking_transaction into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/168c348a-8e3d-463e-8e60-727047f10afc
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/05a908ff-897b-49a5-a5e4-fd57e1ddca0d
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9ac77a1-e367-4bbd-89ed-c65f56d14f3c
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
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
        public List<SolutionNorSolutionPort.BusinessLogicLayer.CrudeFinancialBookingTransactionContract> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid bookingId, int transactionNumber, string financialBookingTransactionTypeRcd, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialFareId, System.Guid financialPaymentId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, System.Guid financialServiceId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialBookingTransactionId: financialBookingTransactionId,
                bookingId: bookingId,
                transactionNumber: transactionNumber,
                financialBookingTransactionTypeRcd: financialBookingTransactionTypeRcd,
                amount: amount,
                financialFeeId: financialFeeId,
                financialTaxId: financialTaxId,
                financialFareId: financialFareId,
                financialPaymentId: financialPaymentId,
                financialCurrencyId: financialCurrencyId,
                financialCostcentreId: financialCostcentreId,
                financialAdjustmentId: financialAdjustmentId,
                financialServiceId: financialServiceId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
