using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAirportIndexWithFilterSearch : Form {
        
        public GetAirportIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetAirportIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetAirportIndexWithFilter.RefreshGetAirportIndexWithFilter();
            base.Show();
        }
        
        private void buttonGetAirportIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetAirportIndexWithFilter.RefreshGetAirportIndexWithFilter();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
