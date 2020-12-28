using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class SpecialServiceRequestListSearch : Form {
        
        public SpecialServiceRequestListSearch() {
           InitializeComponent();
           this.AcceptButton = buttonSpecialServiceRequestListSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianSpecialServiceRequestList.RefreshSpecialServiceRequestList();
            base.Show();
        }
        
        private void buttonSpecialServiceRequestListSearch_Click(object sender, EventArgs e) {
            durianSpecialServiceRequestList.RefreshSpecialServiceRequestList();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
