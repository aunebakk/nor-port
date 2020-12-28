using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ServiceHotelListLiveSearch : Form
    {
        Guid selected;
        public ServiceHotelListLiveSearch() {
            InitializeComponent();
            this.AcceptButton = buttonServiceHotelListSearch;
            this.CancelButton = buttonCancel;
        }

        public new void Show() {
            durianServiceHotelList.RefreshServiceHotelList();
            base.Show();
        }

        public Guid GetHotel() {
            durianServiceHotelList.RefreshServiceHotelList();
            base.ShowDialog();
            return selected;
        }

        private void buttonServiceHotelListSearch_Click(object sender, EventArgs e) {
            durianServiceHotelList.RefreshServiceHotelList();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            selected = durianServiceHotelList.ServiceHotelId;
            Close();
        }
    }
}
