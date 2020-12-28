using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceCompartmentIndexWithFilterSearch : Form {
        
        public AircraftMaintenanceCompartmentIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAircraftMaintenanceCompartmentIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAircraftMaintenanceCompartmentIndexWithFilter.RefreshAircraftMaintenanceCompartmentIndexWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonAircraftMaintenanceCompartmentIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianAircraftMaintenanceCompartmentIndexWithFilter.RefreshAircraftMaintenanceCompartmentIndexWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
