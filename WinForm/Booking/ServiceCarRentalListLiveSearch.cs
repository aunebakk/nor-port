using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ServiceCarRentalListLiveSearch : Form
    {
        Guid selected;
        public ServiceCarRentalListLiveSearch() {
            InitializeComponent();
            this.AcceptButton = buttonServiceCarRentalListSearch;
            this.CancelButton = buttonCancel;
        }

        public new void Show() {
            durianServiceCarRentalList.RefreshServiceCarRentalList();
            base.Show();
        }

        public Guid GetCarRental() {
            durianServiceCarRentalList.RefreshServiceCarRentalList();
            base.ShowDialog();
            return selected;
        }

        private void buttonServiceCarRentalListSearch_Click(object sender, EventArgs e) {
            durianServiceCarRentalList.RefreshServiceCarRentalList();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            selected = durianServiceCarRentalList.ServiceCarRentalId;
            Close();
        }
    }
}
