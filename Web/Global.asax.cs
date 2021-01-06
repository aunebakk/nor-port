using SolutionNorSolutionPort.AspMvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace Web {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start () {
            AreaRegistration.RegisterAllAreas ();
            FilterConfig.RegisterGlobalFilters ( GlobalFilters.Filters );
            RouteConfig.RegisterRoutes ( RouteTable.Routes );
            BundleConfig.RegisterBundles ( BundleTable.Bundles );
            EvaluateDisplayMode (); //Evaluate incoming request and update Display Mode table
        }

        protected void Session_Start(Object sender, EventArgs e) {
            Session["init"] = 0;
            Session["SessionID"] = Guid.NewGuid().ToString();
        }

        // Code that runs when an un-handled error occurs
        void Application_Error(object sender, EventArgs e) {
            Guid defaultErrorId = Guid.Empty;

            // Get the exception object.
            try {
                Exception exception = Server.GetLastError();

                // bull from somewhere
                string errorString = string.Empty;
                string controllerName = string.Empty;
                string actionName = string.Empty;
                try {
                    HttpContext ctx = HttpContext.Current;
                    KeyValuePair<string, object> error = new KeyValuePair<string, object>("ErrorMessage", ctx.Server.GetLastError().ToString());
                    if (error.Value != null)
                        errorString = error.Value.ToString();

                    ctx.Response.Clear();
                    RequestContext rc = ((MvcHandler)ctx.CurrentHandler).RequestContext;
                    controllerName = rc.RouteData.GetRequiredString("controller");
                    actionName = rc.RouteData.GetRequiredString("action");
                    IControllerFactory factory = ControllerBuilder.Current.GetControllerFactory();
                    IController controller = factory.CreateController(rc, controllerName);
                    ControllerContext cc = new ControllerContext(rc, (ControllerBase)controller);
                } catch (Exception) {
                    errorString = "Application_Error: Failed to get detailed error info";
                }

                // get error info
                string message = string.Empty;
                string stackTrace = string.Empty;
                try {
                    message += exception.Message;

                    if (exception.InnerException != null)
                        message += "\r\n" + exception.InnerException.Message;

                    stackTrace += errorString;
                    stackTrace += "\r\n" + exception.StackTrace;
                } catch (Exception) {
                }

                // log error info
                try {
                    defaultErrorId =
                        Logging.ErrorLog(
                            controllerName,
                            actionName,
                            message,
                            stackTrace
                            );
                } catch (Exception) {
                }

                // For other kinds of errors give the user some information
                // but stay on the default page
                // Response.Write("<h2>Global Page Error</h2>\n" + controllerName);
                // Response.Write("<p>" + exception.Message + "</p>\n");
                // Response.Write("Return to the <a href='Default.aspx'>" +
                //                "Default Page</a>\n");

                // Log the exception and notify system operators
                // ExceptionUtility.LogException(exc, "DefaultPage");
                // ExceptionUtility.NotifySystemOps(exc);
            } catch {

            } finally {
                // Clear the error from the server
                Server.ClearError();

                Context.Server.TransferRequest("~/Home/Error?defaultErrorId=" + defaultErrorId.ToString());
            }
        }

        /// <summary>
        ///     Evaluates incoming request and determines and adds an entry into the Display mode table
        /// </summary>
        private static void EvaluateDisplayMode () {
            DisplayModeProvider.Instance.Modes.Insert ( 0 ,
                new DefaultDisplayMode ( "Phone" ) {
                    //...modify file (view that is served)
                    //Query condition
                    ContextCondition = ctx => ( ctx.GetOverriddenUserAgent () != null ) &&
                                              ( //...either iPhone or iPad                           
                                                  ( ctx.GetOverriddenUserAgent ()
                                                      .IndexOf ( "iPhone" , StringComparison.OrdinalIgnoreCase ) >= 0 ) ||
                                                  ( ctx.GetOverriddenUserAgent ()
                                                      .IndexOf ( "Android" , StringComparison.OrdinalIgnoreCase ) >= 0 ) ||
                                                  ( ctx.GetOverriddenUserAgent ()
                                                      .IndexOf ( "iPod" , StringComparison.OrdinalIgnoreCase ) >= 0 )
                                                  )
                } );

            DisplayModeProvider.Instance.Modes.Insert ( 0 ,
                new DefaultDisplayMode ( "Tablet" ) {
                    ContextCondition = ctx => ( ctx.GetOverriddenUserAgent () != null ) &&
                                              (
                                                  ( ctx.GetOverriddenUserAgent ()
                                                      .IndexOf ( "iPad" , StringComparison.OrdinalIgnoreCase ) >= 0 ) ||
                                                  ( ctx.GetOverriddenUserAgent ()
                                                      .IndexOf ( "Playbook" , StringComparison.OrdinalIgnoreCase ) >= 0 )
                                                  )
                } );
        }
    }
}
