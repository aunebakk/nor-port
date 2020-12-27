using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAvailableCurrenciesSearch : Form {
        
        public GetAvailableCurrenciesSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetAvailableCurrenciesSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetAvailableCurrencies.RefreshGetAvailableCurrencies(Guid.Empty, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonGetAvailableCurrenciesSearch_Click(object sender, EventArgs e) {
            durianGetAvailableCurrencies.RefreshGetAvailableCurrencies(Guid.Empty, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
