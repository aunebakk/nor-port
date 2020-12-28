using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetHotelIndexWithFilterSearch : Form {
        
        public GetHotelIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetHotelIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetHotelIndexWithFilter.RefreshGetHotelIndexWithFilter();
            base.Show();
        }
        
        private void buttonGetHotelIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetHotelIndexWithFilter.RefreshGetHotelIndexWithFilter();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
