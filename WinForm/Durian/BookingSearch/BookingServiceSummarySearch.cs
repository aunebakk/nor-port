using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingServiceSummarySearch : Form {
        
        public BookingServiceSummarySearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingServiceSummarySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingServiceSummary.RefreshBookingServiceSummary(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingServiceSummarySearch_Click(object sender, EventArgs e) {
            durianBookingServiceSummary.RefreshBookingServiceSummary(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
