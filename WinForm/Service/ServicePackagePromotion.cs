using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{

    public partial class ServicePackagePromotion : Form
    {
        Guid _userId;

        public ServicePackagePromotion() {
            InitializeComponent();
            this.AcceptButton = buttonServicePackagePromotionWithFilterSearch;
            this.CancelButton = buttonClose;
        }

        public void Show(Guid userId) {
            _userId = userId;
            durianServicePackagePromotionWithFilter.RefreshServicePackagePromotionWithFilter(Guid.Empty);
            base.Show();
        }

        private void buttonServicePackagePromotionWithFilterSearch_Click(object sender, EventArgs e) {
            durianServicePackagePromotionWithFilter.RefreshServicePackagePromotionWithFilter(Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonCrudeServicePackagePromotionAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeServicePackagePromotionEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }

        private void buttonCrudeServicePackagePromotionEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeServicePackagePromotionEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(durianServicePackagePromotionWithFilter.ServicePackagePromotionId);
        }

        private void buttonPromotionSend_Click(object sender, EventArgs e) {
            new ServiceServiceClient().PromotionSend(
                durianServicePackagePromotionWithFilter.ServicePackagePromotionId,
                _userId
                );

            MessageBox.Show("Promotion Sent");
        }

        private void buttonMakeBooking_Click(object sender, EventArgs e) {
            new ServiceServiceClient().PromotionMakeBooking(
                durianServicePackagePromotionWithFilter.ServicePackagePromotionId,
                _userId
                );

            MessageBox.Show("Promotion Booked");
        }
    }
}
