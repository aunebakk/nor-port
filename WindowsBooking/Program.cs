using System;
using System.Web;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // get user id
            Singleton.Instance.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            if (SystemInformation.ComputerName != string.Empty) {
                try {
                    Singleton.Instance.UserId =
                        new DefaultUserActivityServiceClient()
                                .Login(SystemInformation.ComputerName);
                } catch (Exception) {
                    MessageBox.Show("Failed to login user");
                    return;
                }

                Guid bookingId = Guid.Empty;
                try { 
                    NameValueCollection parameters = GetQueryStringParameters();
                    if (parameters.AllKeys.Length > 0) {
                        bookingId = new Guid(parameters["bookingId"]);
                    }
                } catch { 
                }

                Booking booking = null;
                try {
                    booking = new Booking();
                } catch (Exception ex) {
                    Singleton.Instance.Error(ex);
                    MessageBox.Show("Program: Failed to initiate booking, Check error log");
                }

                if (bookingId != Guid.Empty) {
                    booking.ShowAsEdit(
                        bookingId,
                        Singleton.Instance.UserId
                        );
                } else {
                    booking.ShowAsAdd(
                        Singleton.Instance.UserId
                        );
                }

                Application.Run(booking);
            } else {
                MessageBox.Show("Failed to login user");
            }
        }

        // this requires <TrustUrlParameters>true</TrustUrlParameters> is .csproj 
        private static NameValueCollection GetQueryStringParameters() {
            NameValueCollection nameValueTable = new NameValueCollection();

            if (ApplicationDeployment.IsNetworkDeployed) {
                string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                nameValueTable = HttpUtility.ParseQueryString(queryString);
            }

            return (nameValueTable);
        }
    }
}
