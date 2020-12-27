using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIndexWithFilterSearch : Form {
        
        public AircraftMaintenanceIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAircraftMaintenanceIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAircraftMaintenanceIndexWithFilter.RefreshAircraftMaintenanceIndexWithFilter();
            base.Show();
        }
        
        private void buttonAircraftMaintenanceIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianAircraftMaintenanceIndexWithFilter.RefreshAircraftMaintenanceIndexWithFilter();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
