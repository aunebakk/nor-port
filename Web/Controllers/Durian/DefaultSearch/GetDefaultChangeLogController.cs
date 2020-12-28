/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:41:58 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc.Controllers {
    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/d6881d43-704e-4777-91c7-30d9357acc93
    public class GetDefaultChangeLogController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/8bae4bc2-d317-474f-9717-7963ab03f019
        [HttpGet]
        public ActionResult GetDefaultChangeLogIndex(System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {

            return View(
                "~/Views/Durian/DefaultSearch/GetDefaultChangeLogIndex.cshtml",
                new DefaultSearchService().GetDefaultChangeLog(defaultChangeName,defaultChangeLogTypeRcd,defaultIssueId,defaultChangeLogId)
                );
        }

    }
}
