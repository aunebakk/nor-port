using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceHotelListSearch : Form {
        
        public ServiceHotelListSearch() {
           InitializeComponent();
           this.AcceptButton = buttonServiceHotelListSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianServiceHotelList.RefreshServiceHotelList();
            base.Show();
        }
        
        private void buttonServiceHotelListSearch_Click(object sender, EventArgs e) {
            durianServiceHotelList.RefreshServiceHotelList();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
