using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftPIMDetailsSearch : Form {
        
        public AircraftPIMDetailsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAircraftPIMDetailsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAircraftPIMDetails.RefreshAircraftPIMDetails();
            base.Show();
        }
        
        private void buttonAircraftPIMDetailsSearch_Click(object sender, EventArgs e) {
            durianAircraftPIMDetails.RefreshAircraftPIMDetails();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
