using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightEventsSearch : Form {
        
        public FlightEventsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightEventsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightEvents.RefreshFlightEvents(Guid.Empty);
            base.Show();
        }
        
        private void buttonFlightEventsSearch_Click(object sender, EventArgs e) {
            durianFlightEvents.RefreshFlightEvents(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
