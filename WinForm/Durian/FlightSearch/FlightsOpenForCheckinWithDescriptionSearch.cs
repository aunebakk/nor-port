using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOpenForCheckinWithDescriptionSearch : Form {
        
        public FlightsOpenForCheckinWithDescriptionSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightsOpenForCheckinWithDescriptionSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightsOpenForCheckinWithDescription.RefreshFlightsOpenForCheckinWithDescription(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonFlightsOpenForCheckinWithDescriptionSearch_Click(object sender, EventArgs e) {
            durianFlightsOpenForCheckinWithDescription.RefreshFlightsOpenForCheckinWithDescription(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
