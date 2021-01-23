﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 6:10:29 PM
  From Machine: DESKTOP-9A2DH39
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
    [Route("api/1/DefaultTestService")]
    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DefaultTestServiceController : Controller {

        [HttpGet("Help")]
        public IActionResult Help(
            ) {

            return View(@"Views\Templates\DefaultTestService\DefaultTestServiceHelp.cshtml");
        }

        [HttpGet("DefaultTestCompleteGetHelp")]
        public IActionResult DefaultTestCompleteGetHelp(
            ) {

            return View(@"Views\Templates\DefaultTestService\DefaultTestCompleteGetHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultTestCompleteGet
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  defaultTestId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("DefaultTestCompleteGet")]
        public DefaultTestContract DefaultTestCompleteGet(
            System.Guid defaultTestId,
            System.Guid userId
            ) {

            return new DefaultTestService().DefaultTestCompleteGet(defaultTestId: defaultTestId, userId: userId);
        }


        [HttpGet("DefaultTestCompleteUpdateHelp")]
        public IActionResult DefaultTestCompleteUpdateHelp(
            ) {

            return View(@"Views\Templates\DefaultTestService\DefaultTestCompleteUpdateHelp.cshtml");
        }

        // get a JSON Array Contract with data for DefaultTestCompleteUpdate
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  defaultTestId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   testContract: filter by this key, for no filter use: type unknown
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("DefaultTestCompleteUpdate")]
        public System.Guid DefaultTestCompleteUpdate(
            System.Guid defaultTestId,
            DefaultTestContract testContract,
            System.Guid userId
            ) {

            return new DefaultTestService().DefaultTestCompleteUpdate(defaultTestId: defaultTestId, testContract: testContract, userId: userId);
        }


        [HttpGet("AddTestRunHelp")]
        public IActionResult AddTestRunHelp(
            ) {

            return View(@"Views\Templates\DefaultTestService\AddTestRunHelp.cshtml");
        }

        // get a JSON Array Contract with data for AddTestRun
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  systemName: filter by this key, for no filter use: ''
        //   testArea: filter by this key, for no filter use: ''
        //   testSubArea: filter by this key, for no filter use: ''
        //   testAddress: filter by this key, for no filter use: ''
        //   startDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   endDateTime: filter by this key, for no filter use: '1601.01.01T00:00:00Z'
        //   elapsedMilliseconds: filter by this key, for no filter use: 0
        //   defaultTestRunResultRcd: filter by this key, for no filter use: ''
        //   result: filter by this key, for no filter use: ''
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("AddTestRun")]
        public System.Guid AddTestRun(
            System.String systemName,
            System.String testArea,
            System.String testSubArea,
            System.String testAddress,
            System.DateTime startDateTime,
            System.DateTime endDateTime,
            System.Int32 elapsedMilliseconds,
            System.String defaultTestRunResultRcd,
            System.String result,
            System.Guid userId
            ) {

            return new DefaultTestService().AddTestRun(systemName: systemName, testArea: testArea, testSubArea: testSubArea, testAddress: testAddress, startDateTime: startDateTime, endDateTime: endDateTime, elapsedMilliseconds: elapsedMilliseconds, defaultTestRunResultRcd: defaultTestRunResultRcd, result: result, userId: userId);
        }


        [HttpGet("RunAllTestsHelp")]
        public IActionResult RunAllTestsHelp(
            ) {

            return View(@"Views\Templates\DefaultTestService\RunAllTestsHelp.cshtml");
        }

        // get a JSON Array Contract with data for RunAllTests
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("RunAllTests")]
        public void RunAllTests(
            System.Guid userId
            ) {

            new DefaultTestService().RunAllTests(userId: userId);
        }

    }
}
