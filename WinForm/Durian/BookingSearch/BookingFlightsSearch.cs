using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFlightsSearch : Form {
        
        public BookingFlightsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingFlightsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingFlights.RefreshBookingFlights(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingFlightsSearch_Click(object sender, EventArgs e) {
            durianBookingFlights.RefreshBookingFlights(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
