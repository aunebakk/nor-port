/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:49:54 PM
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
    [Route("api/1/ScheduleService")]
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class ScheduleServiceController : Controller {

        // REST interface to Business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e

        [HttpGet("MakeFlightsFromScheduleAll")]
        public void MakeFlightsFromScheduleAll(
            System.Guid userId
            ) {

            new ScheduleService().MakeFlightsFromScheduleAll(userId: userId);
        }

        [HttpGet("MakeFlightsFromSchedule")]
        public void MakeFlightsFromSchedule(
            System.Guid flightScheduleId,
            System.Guid userId
            ) {

            new ScheduleService().MakeFlightsFromSchedule(flightScheduleId: flightScheduleId, userId: userId);
        }

        [HttpGet("GetSchedule")]
        public ScheduleContract GetSchedule(
            System.Guid flightScheduleId,
            System.Guid userId
            ) {

            return new ScheduleService().GetSchedule(flightScheduleId: flightScheduleId, userId: userId);
        }

        [HttpGet("CreateSchedule")]
        public void CreateSchedule(
            ScheduleContract scheduleContract,
            System.Guid userId
            ) {

            new ScheduleService().CreateSchedule(scheduleContract: scheduleContract, userId: userId);
        }

        [HttpGet("UpdateSchedule")]
        public void UpdateSchedule(
            ScheduleContract scheduleContract,
            System.Guid userId
            ) {

            new ScheduleService().UpdateSchedule(scheduleContract: scheduleContract, userId: userId);
        }
    }
}
