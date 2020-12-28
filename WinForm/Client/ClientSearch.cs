using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class ClientSearch : Form
    {
        Guid _userId;

        public ClientSearch() {
            InitializeComponent();
            this.AcceptButton = buttonGetClientWithFilterSearch;
            this.CancelButton = buttonClose;
        }

        public void Show(Guid userId) {
            _userId = userId;
            durianGetClientWithFilter.RefreshGetClientWithFilter(String.Empty, String.Empty);
            base.Show();
        }

        private void buttonGetClientWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetClientWithFilter.RefreshGetClientWithFilter(String.Empty, String.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonCrudeClientAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeClientEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }

        private void buttonCrudeClientEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeClientEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(durianGetClientWithFilter.ClientId);
        }

        private void durianGetClientWithFilter_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeClientEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(durianGetClientWithFilter.ClientId);
        }
    }
}
