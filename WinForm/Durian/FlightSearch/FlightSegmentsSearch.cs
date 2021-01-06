using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsSearch : Form {
        
        public FlightSegmentsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightSegmentsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightSegments.RefreshFlightSegments(Guid.Empty);
            base.Show();
        }
        
        private void buttonFlightSegmentsSearch_Click(object sender, EventArgs e) {
            durianFlightSegments.RefreshFlightSegments(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
