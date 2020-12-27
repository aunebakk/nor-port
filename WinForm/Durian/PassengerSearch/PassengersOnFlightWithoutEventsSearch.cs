using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightWithoutEventsSearch : Form {
        
        public PassengersOnFlightWithoutEventsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonPassengersOnFlightWithoutEventsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianPassengersOnFlightWithoutEvents.RefreshPassengersOnFlightWithoutEvents(Guid.Empty);
            base.Show();
        }
        
        private void buttonPassengersOnFlightWithoutEventsSearch_Click(object sender, EventArgs e) {
            durianPassengersOnFlightWithoutEvents.RefreshPassengersOnFlightWithoutEvents(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
