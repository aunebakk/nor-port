/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:13:57 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// Namespace for a Business Logic Layer in a Controller using ModelViewController
//  the Business Logic Layer contains domain logic that encodes real world business rules
//   that determine how data is created, stored and changed. Typically it will also deal with
//   import and export of data and integration with API's from other parts of the system or other systems
//  the BusinessLogicLayer is where the DataAccessLayer is exposed as
//   REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
//  application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/DefaultUserActivityService")]
    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DefaultUserActivityServiceController : Controller {
        // get a JSON Array Contract with data for ResolveNetnameFromIpV4
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  ipAddress: filter by this key, for no filter use: ''
        [HttpGet("ResolveNetnameFromIpV4")]
        public System.String ResolveNetnameFromIpV4(
            System.String ipAddress
            ) {

            return new DefaultUserActivityService().ResolveNetnameFromIpV4(ipAddress: ipAddress);
        }

        // get a JSON Array Contract with data for AddActivity
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userActivityTypeRcd: filter by this key, for no filter use: ''
        //   activityNote: filter by this key, for no filter use: ''
        //   originatingAddress: filter by this key, for no filter use: ''
        [HttpGet("AddActivity")]
        public void AddActivity(
            System.Guid userId,
            System.String userActivityTypeRcd,
            System.String activityNote,
            System.String originatingAddress
            ) {

            new DefaultUserActivityService().AddActivity(userId: userId, userActivityTypeRcd: userActivityTypeRcd, activityNote: activityNote, originatingAddress: originatingAddress);
        }

        // get a JSON Array Contract with data for Login
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  userCode: filter by this key, for no filter use: ''
        [HttpGet("Login")]
        public System.Guid Login(
            System.String userCode
            ) {

            return new DefaultUserActivityService().Login(userCode: userCode);
        }

        // get a JSON Array Contract with data for LoginOverrideUserName
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  userCode: filter by this key, for no filter use: ''
        [HttpGet("LoginOverrideUserName")]
        public System.Guid LoginOverrideUserName(
            System.String userCode
            ) {

            return new DefaultUserActivityService().LoginOverrideUserName(userCode: userCode);
        }

    }
}
