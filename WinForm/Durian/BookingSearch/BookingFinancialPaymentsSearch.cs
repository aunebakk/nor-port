using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialPaymentsSearch : Form {
        
        public BookingFinancialPaymentsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingFinancialPaymentsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingFinancialPayments.RefreshBookingFinancialPayments(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingFinancialPaymentsSearch_Click(object sender, EventArgs e) {
            durianBookingFinancialPayments.RefreshBookingFinancialPayments(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
