using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialTransactionsSearch : Form {
        
        public BookingFinancialTransactionsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingFinancialTransactionsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingFinancialTransactions.RefreshBookingFinancialTransactions(Guid.Empty);
            base.Show();
        }
        
        private void buttonBookingFinancialTransactionsSearch_Click(object sender, EventArgs e) {
            durianBookingFinancialTransactions.RefreshBookingFinancialTransactions(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
