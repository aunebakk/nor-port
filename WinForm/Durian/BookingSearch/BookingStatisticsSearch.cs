using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingStatisticsSearch : Form {
        
        public BookingStatisticsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonBookingStatisticsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianBookingStatistics.RefreshBookingStatistics(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
            base.Show();
        }
        
        private void buttonBookingStatisticsSearch_Click(object sender, EventArgs e) {
            durianBookingStatistics.RefreshBookingStatistics(Guid.Empty, Guid.Empty, DateTime.MinValue, DateTime.MinValue);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
