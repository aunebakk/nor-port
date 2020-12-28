using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class DefaultTestSearchQuerySearch : Form {
        
        public DefaultTestSearchQuerySearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultTestSearchQuerySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultTestSearchQuery.RefreshDefaultTestSearchQuery();
            base.Show();
        }
        
        private void buttonDefaultTestSearchQuerySearch_Click(object sender, EventArgs e) {
            durianDefaultTestSearchQuery.RefreshDefaultTestSearchQuery();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
