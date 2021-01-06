using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceDocumentIndexWithFilterSearch : Form {
        
        public AircraftMaintenanceDocumentIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAircraftMaintenanceDocumentIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAircraftMaintenanceDocumentIndexWithFilter.RefreshAircraftMaintenanceDocumentIndexWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonAircraftMaintenanceDocumentIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianAircraftMaintenanceDocumentIndexWithFilter.RefreshAircraftMaintenanceDocumentIndexWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
