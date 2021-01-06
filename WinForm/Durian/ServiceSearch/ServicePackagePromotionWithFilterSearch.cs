using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServicePackagePromotionWithFilterSearch : Form {
        
        public ServicePackagePromotionWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonServicePackagePromotionWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianServicePackagePromotionWithFilter.RefreshServicePackagePromotionWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonServicePackagePromotionWithFilterSearch_Click(object sender, EventArgs e) {
            durianServicePackagePromotionWithFilter.RefreshServicePackagePromotionWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
