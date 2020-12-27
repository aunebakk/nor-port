using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIdentifierIndexWithFilterSearch : Form {
        
        public AircraftMaintenanceIdentifierIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAircraftMaintenanceIdentifierIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAircraftMaintenanceIdentifierIndexWithFilter.RefreshAircraftMaintenanceIdentifierIndexWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonAircraftMaintenanceIdentifierIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianAircraftMaintenanceIdentifierIndexWithFilter.RefreshAircraftMaintenanceIdentifierIndexWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
