using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetCarRentalIndexWithFilterSearch : Form {
        
        public GetCarRentalIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetCarRentalIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetCarRentalIndexWithFilter.RefreshGetCarRentalIndexWithFilter();
            base.Show();
        }
        
        private void buttonGetCarRentalIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetCarRentalIndexWithFilter.RefreshGetCarRentalIndexWithFilter();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
