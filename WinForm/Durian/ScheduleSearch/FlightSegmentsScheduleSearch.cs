using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsScheduleSearch : Form {
        
        public FlightSegmentsScheduleSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightSegmentsScheduleSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightSegmentsSchedule.RefreshFlightSegmentsSchedule(Guid.Empty);
            base.Show();
        }
        
        private void buttonFlightSegmentsScheduleSearch_Click(object sender, EventArgs e) {
            durianFlightSegmentsSchedule.RefreshFlightSegmentsSchedule(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
