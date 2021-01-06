using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOnBookingSearch : Form {
        
        public FlightsOnBookingSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightsOnBookingSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightsOnBooking.RefreshFlightsOnBooking(Guid.Empty);
            base.Show();
        }
        
        private void buttonFlightsOnBookingSearch_Click(object sender, EventArgs e) {
            durianFlightsOnBooking.RefreshFlightsOnBooking(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
