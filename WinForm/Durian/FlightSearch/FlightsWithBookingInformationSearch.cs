using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithBookingInformationSearch : Form {
        
        public FlightsWithBookingInformationSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightsWithBookingInformationSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightsWithBookingInformation.RefreshFlightsWithBookingInformation(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonFlightsWithBookingInformationSearch_Click(object sender, EventArgs e) {
            durianFlightsWithBookingInformation.RefreshFlightsWithBookingInformation(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
