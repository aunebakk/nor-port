/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 9:56:09 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateByServiceTableCrudGenerator.BusinessUsing
*/
using SolutionNorSolutionPort.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IDefaultTestService {
        
        // Gets parent and children
        // getter for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/28672bb5-d65f-4daa-84f5-56d7bfad4b22
        [OperationContract()]
        DefaultTestContract DefaultTestCompleteGet(System.Guid defaultTestId, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        // updater for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/b1aacc4e-64a1-4147-8b95-3a76ab53cf0c
        [OperationContract()]
        System.Guid DefaultTestCompleteUpdate(System.Guid defaultTestId, DefaultTestContract testContract, System.Guid userId);
    }
    
    public partial class DefaultTestService : IDefaultTestService {
        
        // Gets parent and children
        // getter for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/28672bb5-d65f-4daa-84f5-56d7bfad4b22
        public DefaultTestContract DefaultTestCompleteGet(System.Guid defaultTestId, System.Guid userId) {
            var testContract = 
                new DefaultTestContract();

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                try {
                    testContract.DefaultTest = 
                        new CrudeDefaultTestService().FetchAll();

                    // save checksum for comparison on update
                    testContract.ChecksumAfterGet = testContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child DefaultTest", ex);
                }
            }

            return testContract;
        }
        
        // Updates parent, children are added or updated as needed
        // updater for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/b1aacc4e-64a1-4147-8b95-3a76ab53cf0c
        public System.Guid DefaultTestCompleteUpdate(System.Guid defaultTestId, DefaultTestContract testContract, System.Guid userId) {

            // check for differences since fetch
            if (testContract.ChecksumAfterGet.Equals(testContract.Checksum()))
                return Guid.Empty;

            // check for database differences since fetch
            DefaultTestContract testContractCurrent = DefaultTestCompleteGet(defaultTestId, userId);
            if (!testContract.ChecksumAfterGet.Equals(testContractCurrent.Checksum())) 
                throw new Exception("DefaultTestCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent default test
                    foreach (CrudeDefaultTestContract defaultTest in testContract.DefaultTest) {
                        new CrudeDefaultTestService().Update(defaultTest, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child DefaultTest", ex);
                }
            }

            return Guid.Empty;

        }
    }
}
