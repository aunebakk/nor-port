using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForPeriodSearch : Form {
        
        public FlightsForPeriodSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightsForPeriodSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightsForPeriod.RefreshFlightsForPeriod(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonFlightsForPeriodSearch_Click(object sender, EventArgs e) {
            durianFlightsForPeriod.RefreshFlightsForPeriod(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
