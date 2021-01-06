using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengerWithExtraSearch : Form {
        
        public BookingPassengerWithExtraSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingPassengerWithExtraSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingPassengerWithExtra.RefreshBookingPassengerWithExtra(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingPassengerWithExtraSearch_Click(object sender, EventArgs e) {
            durianBookingPassengerWithExtra.RefreshBookingPassengerWithExtra(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
