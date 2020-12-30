using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Diagnostics;

namespace SolutionNorSolutionPort.UserInterface {
    public static class Logging {
        public static void ActionLog(
            //            HttpRequestBase request, 
            string message,
            dynamic viewBag
            ) {

            try {
                CrudeDefaultUserActivityContract contract = new CrudeDefaultUserActivityContract {
                    DefaultUserActivityId = Guid.NewGuid(),
                    DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.WebPageOpened,

                    UserActivityNote = string.IsNullOrEmpty(message) ? null : message,

                    DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}"),
                    DateTime = DateTime.UtcNow
                };

                CrudeDefaultUserActivityServiceClient activity = new CrudeDefaultUserActivityServiceClient();
                activity.Insert(contract);
                activity.Close();
            } catch { };
        }

        public static void ActionLog(
            //            HttpRequestBase request, 
            string message
            ) {

            try {
                CrudeDefaultUserActivityContract contract = new CrudeDefaultUserActivityContract {
                    DefaultUserActivityId = Guid.NewGuid(),
                    DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.WebPageOpened,
                    UserActivityNote = message
                };

                try {
                    //                    contract.OriginatingAddress = request.ServerVariables["REMOTE_ADDR"]; 
                } catch { };

                contract.DefaultUserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                contract.DateTime = DateTime.UtcNow;

                CrudeDefaultUserActivityServiceClient activity = new CrudeDefaultUserActivityServiceClient();
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

            if (ex.InnerException != null) {
                message += "\r\n inner " + ex.InnerException;

                if (ex.InnerException.InnerException != null) {
                    message += "\r\n inners inner" + ex.InnerException.InnerException;
                }
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

            CrudeDefaultErrorContract contract = new CrudeDefaultErrorContract();

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

                CrudeDefaultErrorServiceClient activity = new CrudeDefaultErrorServiceClient();
                activity.Insert(contract);
                activity.Close();
            } catch {
            };

            return contract.DefaultErrorId;
        }
    }

    public class LoggingTime {
        public Stopwatch StopWatch;
        private Guid UserId;
        //string _sql;

        public string DomainName { get; set; }
        public string LayerName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }

        public static LoggingTime PerformanceTimeStart(
            string commandName
            ) {

            LoggingTime log = new LoggingTime {
                MethodName = commandName,
                StopWatch = new Stopwatch()
            };
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

            LoggingTime log = new LoggingTime {
                DomainName = domainName,
                LayerName = layerName,
                ClassName = className,
                MethodName = methodName
            };

            if (userId != null) {
                log.UserId = (Guid)userId;
            }

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
