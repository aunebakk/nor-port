using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialServiceDetailsForBookingSearch : Form {
        
        public FinancialServiceDetailsForBookingSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFinancialServiceDetailsForBookingSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(Guid.Empty);
            base.Show();
        }
        
        private void buttonFinancialServiceDetailsForBookingSearch_Click(object sender, EventArgs e) {
            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
