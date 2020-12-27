using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceCarRentalListSearch : Form {
        
        public ServiceCarRentalListSearch() {
           InitializeComponent();
           this.AcceptButton = buttonServiceCarRentalListSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianServiceCarRentalList.RefreshServiceCarRentalList();
            base.Show();
        }
        
        private void buttonServiceCarRentalListSearch_Click(object sender, EventArgs e) {
            durianServiceCarRentalList.RefreshServiceCarRentalList();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
