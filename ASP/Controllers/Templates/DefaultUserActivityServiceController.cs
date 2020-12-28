/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 8:43:09 AM
  From Machine: DESKTOP-BP3OHLH
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
    [Route("api/1/DefaultUserActivityService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class DefaultUserActivityServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("ResolveNetnameFromIpV4")]
        public System.String ResolveNetnameFromIpV4(
            System.String ipAddress
            ) {

            return new DefaultUserActivityService().ResolveNetnameFromIpV4(ipAddress: ipAddress);
        }

        [HttpGet("AddActivity")]
        public void AddActivity(
            System.Guid userId,
            System.String userActivityTypeRcd,
            System.String activityNote,
            System.String originatingAddress
            ) {

            new DefaultUserActivityService().AddActivity(userId: userId, userActivityTypeRcd: userActivityTypeRcd, activityNote: activityNote, originatingAddress: originatingAddress);
        }

        [HttpGet("Login")]
        public System.Guid Login(
            System.String userCode
            ) {

            return new DefaultUserActivityService().Login(userCode: userCode);
        }

        [HttpGet("LoginOverrideUserName")]
        public System.Guid LoginOverrideUserName(
            System.String userCode
            ) {

            return new DefaultUserActivityService().LoginOverrideUserName(userCode: userCode);
        }
    }
}
