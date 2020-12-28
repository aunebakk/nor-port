﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:45 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.DotNetFrameworkBusinessToDotNetCoreRest.ControllerMake
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

// controller namespace for mvc
// links:
//  docLink: http://sql2x.org/documentationLink/6382691f-5a87-466f-89a7-ab9d8e28b367
namespace SolutionNorSolutionPort.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/DefaultTestService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DefaultTestServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

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

        [HttpGet("RunAllTests")]
        public void RunAllTests(
            System.Guid userId
            ) {

            new DefaultTestService().RunAllTests(userId: userId);
        }
    }
}