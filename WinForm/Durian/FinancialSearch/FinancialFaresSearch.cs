using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialFaresSearch : Form {
        
        public FinancialFaresSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFinancialFaresSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFinancialFares.RefreshFinancialFares();
            base.Show();
        }
        
        private void buttonFinancialFaresSearch_Click(object sender, EventArgs e) {
            durianFinancialFares.RefreshFinancialFares();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
