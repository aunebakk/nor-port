/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/11/2020 6:54:14 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IDefaultTestSearchService {
        // returns a list of DefaultTestSearchQuery contracts from DefaultTestSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultTestSearchQueryContract> DefaultTestSearchQuery ();
    }
    
    public partial class DefaultTestSearchService : IDefaultTestSearchService {
        // returns a list of DefaultTestSearchQuery contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultTestSearchQueryContract> DefaultTestSearchQuery () {
            // transfer all DefaultTestSearchQuery serialized objects from DefaultTestSearch as DefaultTestSearchQuery contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.DefaultTestSearch();
            var businessLogicLayer = new DefaultTestSearchQuery();
            return businessLogicLayer.DefaultTestSearchQueryFromDal(dataAccessLayer.DefaultTestSearchQuery());
        }
    }
}
