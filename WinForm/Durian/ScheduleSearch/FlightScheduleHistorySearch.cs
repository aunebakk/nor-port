using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleHistorySearch : Form {
        
        public FlightScheduleHistorySearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightScheduleHistorySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightScheduleHistory.RefreshFlightScheduleHistory(Guid.Empty);
            base.Show();
        }
        
        private void buttonFlightScheduleHistorySearch_Click(object sender, EventArgs e) {
            durianFlightScheduleHistory.RefreshFlightScheduleHistory(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
