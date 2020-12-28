using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{

    public partial class GetServicePackageSearchLive : Form
    {
        Guid _userId;

        public GetServicePackageSearchLive() {
            InitializeComponent();
            this.AcceptButton = buttonGetServicePackageSearch;
            this.CancelButton = buttonClose;
        }

        public void Show(Guid userId) {
            _userId = userId;
            ;
            durianGetServicePackage.RefreshGetServicePackage(Guid.Empty);
            base.Show();
        }

        private void buttonGetServicePackageSearch_Click(object sender, EventArgs e) {
            durianGetServicePackage.RefreshGetServicePackage(Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonCrudeServicePackageEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeServicePackageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(durianGetServicePackage.ServicePackageId);
        }

        private void buttonCrudeServicePackageAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeServicePackageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
    }
}
