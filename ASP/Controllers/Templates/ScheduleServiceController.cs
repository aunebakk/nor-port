/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:14:18 AM
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
    [Route("api/1/ScheduleService")]
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
    public class ScheduleServiceController : Controller {
        // get a JSON Array Contract with data for MakeFlightsFromScheduleAll
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("MakeFlightsFromScheduleAll")]
        public void MakeFlightsFromScheduleAll(
            System.Guid userId
            ) {

            new ScheduleService().MakeFlightsFromScheduleAll(userId: userId);
        }

        // get a JSON Array Contract with data for MakeFlightsFromSchedule
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightScheduleId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("MakeFlightsFromSchedule")]
        public void MakeFlightsFromSchedule(
            System.Guid flightScheduleId,
            System.Guid userId
            ) {

            new ScheduleService().MakeFlightsFromSchedule(flightScheduleId: flightScheduleId, userId: userId);
        }

        // get a JSON Array Contract with data for GetSchedule
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  flightScheduleId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("GetSchedule")]
        public ScheduleContract GetSchedule(
            System.Guid flightScheduleId,
            System.Guid userId
            ) {

            return new ScheduleService().GetSchedule(flightScheduleId: flightScheduleId, userId: userId);
        }

        // get a JSON Array Contract with data for CreateSchedule
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  scheduleContract: filter by this key, for no filter use: type unknown
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("CreateSchedule")]
        public void CreateSchedule(
            ScheduleContract scheduleContract,
            System.Guid userId
            ) {

            new ScheduleService().CreateSchedule(scheduleContract: scheduleContract, userId: userId);
        }

        // get a JSON Array Contract with data for UpdateSchedule
        //  from the dot net framework business logic layer in SolutionNorSolutionPort.BusinessLogicLayer
        // links:
        //  docLink: http://sql2x.org/documentationLink/54f84e72-c830-419e-a66e-f5bb6a9c700e
        // parameters:
        //  scheduleContract: filter by this key, for no filter use: type unknown
        //   userId: filter by this key, for no filter use: '00000000-0000-0000-0000-000000000000'
        [HttpGet("UpdateSchedule")]
        public void UpdateSchedule(
            ScheduleContract scheduleContract,
            System.Guid userId
            ) {

            new ScheduleService().UpdateSchedule(scheduleContract: scheduleContract, userId: userId);
        }

    }
}
