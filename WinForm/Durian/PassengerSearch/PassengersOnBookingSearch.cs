using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnBookingSearch : Form {
        
        public PassengersOnBookingSearch() {
           InitializeComponent();
           this.AcceptButton = buttonPassengersOnBookingSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianPassengersOnBooking.RefreshPassengersOnBooking(Guid.Empty);
            base.Show();
        }
        
        private void buttonPassengersOnBookingSearch_Click(object sender, EventArgs e) {
            durianPassengersOnBooking.RefreshPassengersOnBooking(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
