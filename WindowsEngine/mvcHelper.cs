using System;
using System.Diagnostics;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public static class Logging
    {
        public static Guid UserId(
            //            HttpRequestBase request,
            dynamic viewBag
            ) {
            Guid userId;

            try {
                // return passed in user id
                if ( viewBag.UserId != null ) {
                    userId = viewBag.UserId;
                } else {
                    // figure out user id based on remote address
                    //                    string originatingAddress = request.ServerVariables["REMOTE_ADDR"]; 

                    //                    if (string.IsNullOrEmpty(originatingAddress))
                    userId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                    //                    else
                    //                        userId = new DefaultUserActivityServiceClient().Login(originatingAddress);
                }

                viewBag.UserId = userId;

            } catch {
                userId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            };

            return userId;
        }

        public static void ActionLog(
            //            HttpRequestBase request, 
            string message,
            dynamic viewBag
            ) {

            try {
                var contract = new CrudeDefaultUserActivityContract();

                contract.DefaultUserActivityId = Guid.NewGuid();
                contract.DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.WebPageOpened;

                contract.UserActivityNote = string.IsNullOrEmpty(message) ? null : message;

                contract.DefaultUserId = UserId(viewBag);
                contract.DateTime = DateTime.UtcNow;

                var activity = new CrudeDefaultUserActivityServiceClient();
                activity.Insert(contract);
                activity.Close();
            } catch { };
        }

        public static void ActionLog(
            //            HttpRequestBase request, 
            string message
            ) {

            try {
                var contract = new CrudeDefaultUserActivityContract();

                contract.DefaultUserActivityId = Guid.NewGuid();
                contract.DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.WebPageOpened;
                contract.UserActivityNote = message;

                try {
                    //                    contract.OriginatingAddress = request.ServerVariables["REMOTE_ADDR"]; 
                } catch { };

                contract.DefaultUserId = UserId(string.Empty);
                contract.DateTime = DateTime.UtcNow;

                var activity = new CrudeDefaultUserActivityServiceClient();
                activity.Insert(contract);
                activity.Close();
            } catch { };
        }

        public static Guid ErrorLog(
            string controller,
            string action,
            Exception ex
            ) {

            string message = ex.Message;

            if ( ex.InnerException != null ) {
                message += "\r\n inner " + ex.InnerException;

                if ( ex.InnerException.InnerException != null )
                    message += "\r\n inners inner" + ex.InnerException.InnerException;
            }

            Guid defaultErrorId =
                Logging.ErrorLog(
                    controller,
                    action,
                    message,
                    ex.StackTrace
                    );

            return defaultErrorId;
        }

        public static Guid ErrorLog(
            string controller,
            string action,
            string message,
            string stackTrace
            ) {

            var contract = new CrudeDefaultErrorContract();

            try {
                contract.DefaultErrorId = Guid.NewGuid();
                contract.DefaultErrorTypeRcd = DefaultErrorTypeRef.UserInitiated;
                contract.DefaultErrorLayerRcd = DefaultErrorLayerRef.ASPModelViewController;
                contract.DomainName = "General";
                contract.ClassName = controller;
                contract.MethodName = action;
                contract.StackTrace = stackTrace;
                contract.ErrorMessage = message;
                contract.DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                contract.DateTime = DateTime.UtcNow;

                var activity = new CrudeDefaultErrorServiceClient();
                activity.Insert(contract);
                activity.Close();
            } catch {
            };

            return contract.DefaultErrorId;
        }
    }

    public class LoggingTime
    {
        public Stopwatch StopWatch;
        Guid UserId;
        //string _sql;

        public string DomainName { get; set; }
        public string LayerName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }

        public static LoggingTime PerformanceTimeStart(
            string commandName
            ) {

            var log = new LoggingTime();
            log.MethodName = commandName;
            log.StopWatch = new Stopwatch();
            log.StopWatch.Start();

            return log;
        }

        public static LoggingTime PerformanceTimeStart(
            string domainName,
            string layerName,
            string className,
            string methodName,
            Guid? userId = null
            ) {

            var log = new LoggingTime();
            log.DomainName = domainName;
            log.LayerName = layerName;
            log.ClassName = className;
            log.MethodName = methodName;

            if ( userId != null )
                log.UserId = ( Guid ) userId;

            log.StopWatch = new Stopwatch();
            log.StopWatch.Start();

            return log;
        }

        public void PerformanceTimeStop(
            ) {
            PerformanceTimeStop(logIfMoreThanMilliseconds: 100);
        }

        public void PerformanceTimeStop(
            int logIfMoreThanMilliseconds
            ) {
            StopWatch.Stop();
        }
    }
}
