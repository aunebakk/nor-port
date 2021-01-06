using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirportsAvailableWithFilterSearch : Form {
        
        public AirportsAvailableWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAirportsAvailableWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAirportsAvailableWithFilter.RefreshAirportsAvailableWithFilter(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonAirportsAvailableWithFilterSearch_Click(object sender, EventArgs e) {
            durianAirportsAvailableWithFilter.RefreshAirportsAvailableWithFilter(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
