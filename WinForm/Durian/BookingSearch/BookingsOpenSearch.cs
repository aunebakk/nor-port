using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingsOpenSearch : Form {
        
        public BookingsOpenSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingsOpenSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingsOpen.RefreshBookingsOpen();
            base.Show();
        }
        
        private void buttonBookingsOpenSearch_Click(object sender, EventArgs e) {
            durianBookingsOpen.RefreshBookingsOpen();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
