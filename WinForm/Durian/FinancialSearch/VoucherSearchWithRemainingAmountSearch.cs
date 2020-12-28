using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherSearchWithRemainingAmountSearch : Form {
        
        public VoucherSearchWithRemainingAmountSearch() {
           InitializeComponent();
           this.AcceptButton = buttonVoucherSearchWithRemainingAmountSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianVoucherSearchWithRemainingAmount.RefreshVoucherSearchWithRemainingAmount(DateTime.MinValue);
            base.Show();
        }
        
        private void buttonVoucherSearchWithRemainingAmountSearch_Click(object sender, EventArgs e) {
            durianVoucherSearchWithRemainingAmount.RefreshVoucherSearchWithRemainingAmount(DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
