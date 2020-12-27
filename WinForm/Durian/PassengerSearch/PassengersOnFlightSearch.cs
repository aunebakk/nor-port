using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightSearch : Form {
        
        public PassengersOnFlightSearch() {
           InitializeComponent();
           this.AcceptButton = buttonPassengersOnFlightSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianPassengersOnFlight.RefreshPassengersOnFlight(Guid.Empty);
            base.Show();
        }
        
        private void buttonPassengersOnFlightSearch_Click(object sender, EventArgs e) {
            durianPassengersOnFlight.RefreshPassengersOnFlight(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
