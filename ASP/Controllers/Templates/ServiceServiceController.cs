﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:16:44 AM
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
    [Route("api/1/ServiceService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class ServiceServiceController : Controller {
        // get a JSON Array Contract with data for PromotionSend
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  servicePackagePromotionId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PromotionSend")]
        public void PromotionSend(
            System.Guid servicePackagePromotionId,
            System.Guid userId
            ) {

            new ServiceService().PromotionSend(servicePackagePromotionId: servicePackagePromotionId, userId: userId);
        }

        // get a JSON Array Contract with data for PromotionMakeBooking
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  servicePackagePromotionId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("PromotionMakeBooking")]
        public void PromotionMakeBooking(
            System.Guid servicePackagePromotionId,
            System.Guid userId
            ) {

            new ServiceService().PromotionMakeBooking(servicePackagePromotionId: servicePackagePromotionId, userId: userId);
        }

    }
}
