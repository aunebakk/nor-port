using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightHistorySearch : Form {
        
        public FlightHistorySearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightHistorySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightHistory.RefreshFlightHistory(Guid.Empty);
            base.Show();
        }
        
        private void buttonFlightHistorySearch_Click(object sender, EventArgs e) {
            durianFlightHistory.RefreshFlightHistory(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
