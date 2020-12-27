using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithCheckinInformationSearch : Form {
        
        public FlightsWithCheckinInformationSearch() {
           InitializeComponent();
           this.AcceptButton = buttonFlightsWithCheckinInformationSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianFlightsWithCheckinInformation.RefreshFlightsWithCheckinInformation(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonFlightsWithCheckinInformationSearch_Click(object sender, EventArgs e) {
            durianFlightsWithCheckinInformation.RefreshFlightsWithCheckinInformation(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
