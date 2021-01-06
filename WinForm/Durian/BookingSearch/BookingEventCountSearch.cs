using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventCountSearch : Form {
        
        public BookingEventCountSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingEventCountSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingEventCount.RefreshBookingEventCount(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingEventCountSearch_Click(object sender, EventArgs e) {
            durianBookingEventCount.RefreshBookingEventCount(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
