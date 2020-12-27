using System;
using System.Configuration;
using System.Diagnostics;
using System.ServiceModel;

namespace SolutionNorSolutionPort.BusinessLogicLayer
{
    [ServiceContract()]
    public interface IDiagnosticsService
    {
        [OperationContract()]
        long WorkingSet();

        [OperationContract()]
        DateTime PingTest();

        [OperationContract()]
        string Database();

        [OperationContract()]
        string ComputerName();
    }

    /// <domain>Diagnostics</domain>
    /// <namespace>SolutionNorSolutionPort.BusinessLogicLayer</namespace>
    public class DiagnosticsService : IDiagnosticsService
    {
        public long WorkingSet() {
            Process myProcess = Process.GetCurrentProcess();
            long workingSet = myProcess.WorkingSet64 / 1024 / 1024;

            return workingSet;
        }

        public DateTime PingTest() {
            return DateTime.UtcNow;
        }

        public string Database() {
            string connection = Conn.ConnectionString;

            // exclude password if present
            if ( connection.IndexOf("Password") > 0 )
                return connection.Substring(0,
                       connection.IndexOf("Password"));

            return connection;
        }

        public string ComputerName() {
            //return SystemInformation.ComputerName; // requires System.Forms
            string computerName = string.Empty;
            try {
                computerName = System.Environment.MachineName;
            } catch { }

            return computerName;
        }
    }
}
