using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FetchServiceSpecialServiceRequestWithFilterSearch : Form {
        
        public FetchServiceSpecialServiceRequestWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFetchServiceSpecialServiceRequestWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFetchServiceSpecialServiceRequestWithFilter.RefreshFetchServiceSpecialServiceRequestWithFilter(String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
            base.Show();
        }
        
        private void buttonFetchServiceSpecialServiceRequestWithFilterSearch_Click(object sender, EventArgs e) {
            durianFetchServiceSpecialServiceRequestWithFilter.RefreshFetchServiceSpecialServiceRequestWithFilter(String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
