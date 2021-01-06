using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForBookingWithFareSearch : Form {
        
        public FlightsForBookingWithFareSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightsForBookingWithFareSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightsForBookingWithFare.RefreshFlightsForBookingWithFare(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonFlightsForBookingWithFareSearch_Click(object sender, EventArgs e) {
            durianFlightsForBookingWithFare.RefreshFlightsForBookingWithFare(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
