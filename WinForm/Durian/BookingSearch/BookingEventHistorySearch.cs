using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventHistorySearch : Form {
        
        public BookingEventHistorySearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingEventHistorySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingEventHistory.RefreshBookingEventHistory(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingEventHistorySearch_Click(object sender, EventArgs e) {
            durianBookingEventHistory.RefreshBookingEventHistory(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
