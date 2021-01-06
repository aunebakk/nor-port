using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherTransactionsSearch : Form {
        
        public VoucherTransactionsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonVoucherTransactionsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianVoucherTransactions.RefreshVoucherTransactions(Guid.Empty);
            base.Show();
        }
        
        private void buttonVoucherTransactionsSearch_Click(object sender, EventArgs e) {
            durianVoucherTransactions.RefreshVoucherTransactions(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
