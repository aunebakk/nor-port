using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengersSearch : Form {
        
        public BookingPassengersSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingPassengersSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingPassengers.RefreshBookingPassengers(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingPassengersSearch_Click(object sender, EventArgs e) {
            durianBookingPassengers.RefreshBookingPassengers(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
