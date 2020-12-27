using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleSearch : Form {
        
        public FlightScheduleSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightScheduleSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightSchedule.RefreshFlightSchedule();
            base.Show();
        }
        
        private void buttonFlightScheduleSearch_Click(object sender, EventArgs e) {
            durianFlightSchedule.RefreshFlightSchedule();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
