using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetFerryIndexWithFilterSearch : Form {
        
        public GetFerryIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetFerryIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetFerryIndexWithFilter.RefreshGetFerryIndexWithFilter();
            base.Show();
        }
        
        private void buttonGetFerryIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetFerryIndexWithFilter.RefreshGetFerryIndexWithFilter();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
