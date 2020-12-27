using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightCheckedInSearch : Form {
        
        public PassengersOnFlightCheckedInSearch() {
           InitializeComponent();
           this.AcceptButton = buttonPassengersOnFlightCheckedInSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianPassengersOnFlightCheckedIn.RefreshPassengersOnFlightCheckedIn(Guid.Empty);
            base.Show();
        }
        
        private void buttonPassengersOnFlightCheckedInSearch_Click(object sender, EventArgs e) {
            durianPassengersOnFlightCheckedIn.RefreshPassengersOnFlightCheckedIn(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
