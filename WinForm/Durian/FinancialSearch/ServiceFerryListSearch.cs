using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceFerryListSearch : Form {
        
        public ServiceFerryListSearch() {
           InitializeComponent();
           this.AcceptButton = buttonServiceFerryListSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianServiceFerryList.RefreshServiceFerryList();
            base.Show();
        }
        
        private void buttonServiceFerryListSearch_Click(object sender, EventArgs e) {
            durianServiceFerryList.RefreshServiceFerryList();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
