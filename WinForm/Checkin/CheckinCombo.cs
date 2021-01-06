using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class CheckinCombo : UserControl
    {

        public event EventHandler Picked;

        public CheckinCombo() {
            InitializeComponent();
        }

        public Guid FlightId {
            get {
                Guid selectedValue = Guid.Empty;
                try {
                    selectedValue = new Guid(cboRef.SelectedValue.ToString());
                } catch { }

                return selectedValue;
            }

            set {
                PopulateCombo();
                if ( value != null && value != Guid.Empty )
                    cboRef.SelectedValue = value;
            }
        }

        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }

        public void PopulateCombo() {
            if ( !DesignMode && cboRef.DataSource == null ) {
                try {
                    List<FlightsOpenForCheckinWithDescriptionContract> flights =
                            new FlightSearchServiceClient().FlightsOpenForCheckinWithDescription(
                                     Guid.Empty
                                    , Guid.Empty
                                    , DateTime.UtcNow.Date
                                    , DateTime.UtcNow.Date.AddDays(1)
                                    );

                    cboRef.DataSource = flights;
                    cboRef.DisplayMember = "FlightDescription";
                    cboRef.ValueMember = "FlightId";
                    if ( flights.Count > 0 )
                        cboRef.SelectedIndex = 0;

                } catch ( Exception ex ) {
                    MessageBox.Show(ex.Message);
                } finally {
                }
            }
        }

        private void cboRef_SelectedIndexChanged(object sender, EventArgs e) {
            if ( cboRef.SelectedValue != null && this.Picked != null )
                this.Picked(new object(), new EventArgs());
        }
    }
}
