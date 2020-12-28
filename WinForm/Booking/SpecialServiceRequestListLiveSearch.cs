using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class SpecialServiceRequestListLiveSearch : Form
    {
        Guid selected;
        public SpecialServiceRequestListLiveSearch() {
            InitializeComponent();
            this.AcceptButton = buttonSpecialServiceRequestListSearch;
            this.CancelButton = buttonClose;
        }

        public new void Show() {
            durianSpecialServiceRequestList.RefreshSpecialServiceRequestList();
            base.Show();
        }

        public Guid GetSSR() {
            durianSpecialServiceRequestList.RefreshSpecialServiceRequestList();
            base.ShowDialog();
            return selected;
        }

        private void buttonSpecialServiceRequestListSearch_Click(object sender, EventArgs e) {
            durianSpecialServiceRequestList.RefreshSpecialServiceRequestList();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            selected = durianSpecialServiceRequestList.ServiceSpecialServiceRequestId;
            Close();
        }
    }
}
