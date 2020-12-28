using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class TransactionsCreditDebitBalanceSearch : Form {
        
        public TransactionsCreditDebitBalanceSearch() {
           InitializeComponent();
           this.AcceptButton = buttonTransactionsCreditDebitBalanceSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianTransactionsCreditDebitBalance.RefreshTransactionsCreditDebitBalance(DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonTransactionsCreditDebitBalanceSearch_Click(object sender, EventArgs e) {
            durianTransactionsCreditDebitBalance.RefreshTransactionsCreditDebitBalance(DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
