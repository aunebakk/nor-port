/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 10:05:27 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
// the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/ServiceSearchService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class ServiceSearchServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\ServiceSearchService\ServiceSearchServiceHelp.cshtml");
        }

        [HttpGet("GetServicePackageHelp")]
        public IActionResult GetServicePackageHelp(
            ) {

            return View(@"Views\Templates\ServiceSearchService\GetServicePackageHelp.cshtml");
        }

        // get a JSON Array Contract with data for GetServicePackage
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  servicePackageId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("GetServicePackage")]
        public IEnumerable<GetServicePackageContract> GetServicePackage(
            System.Guid servicePackageId
            ) {

            List<GetServicePackageContract> list =
                new ServiceSearchService().GetServicePackage(servicePackageId: servicePackageId);

            return list;
        }


        [HttpGet("FetchServiceSpecialServiceRequestWithFilterHelp")]
        public IActionResult FetchServiceSpecialServiceRequestWithFilterHelp(
            ) {

            return View(@"Views\Templates\ServiceSearchService\FetchServiceSpecialServiceRequestWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for FetchServiceSpecialServiceRequestWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  serviceSpecialServiceRequestGroupRcd: filter by this key, for no filter use: ''
        //   serviceSpecialServiceRequestCode: filter by this key, for no filter use: ''
        //   requestServiceSpecialServiceRequestRequirementRcd: filter by this key, for no filter use: ''
        //   replyServiceSpecialServiceRequestRequirementRcd: filter by this key, for no filter use: ''
        //   serviceSpecialServiceRequestOperationRuleRcd: filter by this key, for no filter use: ''
        [HttpGet("FetchServiceSpecialServiceRequestWithFilter")]
        public IEnumerable<FetchServiceSpecialServiceRequestWithFilterContract> FetchServiceSpecialServiceRequestWithFilter(
            System.String serviceSpecialServiceRequestGroupRcd,
            System.String serviceSpecialServiceRequestCode,
            System.String requestServiceSpecialServiceRequestRequirementRcd,
            System.String replyServiceSpecialServiceRequestRequirementRcd,
            System.String serviceSpecialServiceRequestOperationRuleRcd
            ) {

            List<FetchServiceSpecialServiceRequestWithFilterContract> list =
                new ServiceSearchService().FetchServiceSpecialServiceRequestWithFilter(serviceSpecialServiceRequestGroupRcd: serviceSpecialServiceRequestGroupRcd, serviceSpecialServiceRequestCode: serviceSpecialServiceRequestCode, requestServiceSpecialServiceRequestRequirementRcd: requestServiceSpecialServiceRequestRequirementRcd, replyServiceSpecialServiceRequestRequirementRcd: replyServiceSpecialServiceRequestRequirementRcd, serviceSpecialServiceRequestOperationRuleRcd: serviceSpecialServiceRequestOperationRuleRcd);

            return list;
        }


        [HttpGet("ServicePackagePromotionWithFilterHelp")]
        public IActionResult ServicePackagePromotionWithFilterHelp(
            ) {

            return View(@"Views\Templates\ServiceSearchService\ServicePackagePromotionWithFilterHelp.cshtml");
        }

        // get a JSON Array Contract with data for ServicePackagePromotionWithFilter
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  clientId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("ServicePackagePromotionWithFilter")]
        public IEnumerable<ServicePackagePromotionWithFilterContract> ServicePackagePromotionWithFilter(
            System.Guid clientId
            ) {

            List<ServicePackagePromotionWithFilterContract> list =
                new ServiceSearchService().ServicePackagePromotionWithFilter(clientId: clientId);

            return list;
        }

    }
}
