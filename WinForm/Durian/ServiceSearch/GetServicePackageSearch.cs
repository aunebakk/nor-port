using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetServicePackageSearch : Form {
        
        public GetServicePackageSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetServicePackageSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetServicePackage.RefreshGetServicePackage(Guid.Empty);
            base.Show();
        }
        
        private void buttonGetServicePackageSearch_Click(object sender, EventArgs e) {
            durianGetServicePackage.RefreshGetServicePackage(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
