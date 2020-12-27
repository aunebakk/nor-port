using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftDetailsSearch : Form {
        
        public AircraftDetailsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonAircraftDetailsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianAircraftDetails.RefreshAircraftDetails();
            base.Show();
        }
        
        private void buttonAircraftDetailsSearch_Click(object sender, EventArgs e) {
            durianAircraftDetails.RefreshAircraftDetails();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
