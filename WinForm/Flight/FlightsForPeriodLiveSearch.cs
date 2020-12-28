using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FlightsForPeriodLiveSearch : Form
    {

        public FlightsForPeriodLiveSearch() {
            InitializeComponent();
            InitializeGridFlightsForPeriod();
            this.AcceptButton = buttonFlightsForPeriodSearch;
            this.CancelButton = buttonClose;
        }

        public new void Show() {
            dateTimePickerFromDateTime.Value = DateTime.UtcNow.Date;
            dateTimePickerFromDateTime.Checked = true;
            dateTimePickerUntilDateTime.Value = DateTime.UtcNow.Date.AddDays(1);
            dateTimePickerUntilDateTime.Checked = true;

            RefreshFlightsForPeriod();
            base.Show();
        }

        public Guid ShowAsSelector() {
            dateTimePickerFromDateTime.Value = DateTime.UtcNow.Date;
            dateTimePickerFromDateTime.Checked = true;
            dateTimePickerUntilDateTime.Value = DateTime.UtcNow.Date.AddDays(1);
            dateTimePickerUntilDateTime.Checked = true;
            buttonCheckEvents.Enabled = false;
            buttonEdit.Enabled = false;

            RefreshFlightsForPeriod();
            ShowDialog();

            if ( dataGridViewFlightsForPeriod.SelectedRows.Count == 1 )
                return ( Guid ) dataGridViewFlightsForPeriod.CurrentRow.Cells["FlightId"].Value;
            else
                return Guid.Empty;
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            if ( dataGridViewFlightsForPeriod.SelectedRows.Count == 1 )
                Close();
            else
                MessageBox.Show("Please select a flight first");
        }

        private void buttonFlightsForPeriodSearch_Click(object sender, EventArgs e) {
            RefreshFlightsForPeriod();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        public void RefreshFlightsForPeriod() {
            FlightSearchService flightsForPeriod = new FlightSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource =
                    flightsForPeriod.
                        FlightsForPeriod(
                            departureAirportPicker.SelectedValue,
                            arrivalAirportPicker.SelectedValue,
                            dateTimePickerFromDateTime.Value,
                            dateTimePickerUntilDateTime.Value
                            );

                dataGridViewFlightsForPeriod.AutoGenerateColumns = true;
                dataGridViewFlightsForPeriod.DataSource = bindingSource;
                dataGridViewFlightsForPeriod.AutoResizeColumns();
                dataGridViewFlightsForPeriod.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                flightsForPeriod.Close();
            }
        }

        private void InitializeGridFlightsForPeriod() {
            dataGridViewFlightsForPeriod.Columns.Clear();
            dataGridViewFlightsForPeriod.AutoGenerateColumns = false;
            dataGridViewFlightsForPeriod.Columns.Add("FlightId", "Flight Id");
            dataGridViewFlightsForPeriod.Columns.Add("AirlineIdentifierCode", "Airline Identifier Code");
            dataGridViewFlightsForPeriod.Columns.Add("FlightNumber", "Flight Number");
            dataGridViewFlightsForPeriod.Columns.Add("DepartureAirportIdentifierCode", "Departure Airport Identifier Code");
            dataGridViewFlightsForPeriod.Columns.Add("DepartureAirportName", "Departure Airport Name");
            dataGridViewFlightsForPeriod.Columns.Add("ArrivalAirportIdentifierCode", "Arrival Airport Identifier Code");
            dataGridViewFlightsForPeriod.Columns.Add("ArrivalAirportName", "Arrival Airport Name");
            dataGridViewFlightsForPeriod.Columns.Add("FromDateTime", "From Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("UntilDateTime", "Until Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("LastDateTimeTypeName", "Last Date Time Type Name");
            dataGridViewFlightsForPeriod.Columns.Add("PlannedDepartureDateTime", "Planned Departure Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("EstimatedDepartureDateTime", "Estimated Departure Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("Comment", "Comment");
            dataGridViewFlightsForPeriod.Columns.Add("ExtensionData", "");
            dataGridViewFlightsForPeriod.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewFlightsForPeriod.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewFlightsForPeriod.AutoResizeColumns();
        }

        private void buttonCheckEvents_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            //var flightService = new FlightServiceClient();
            //try {
            //    Singleton.Instance.Log("Check Flight Status");

            //    flightService.CheckFlightStatuses(
            //        DateTime.UtcNow.Date,
            //        DateTime.UtcNow.Date.AddDays(1),
            //        Singleton.Instance.UserId
            //        );

            //    RefreshFlightsForPeriod();

            //    MessageBox.Show("Checked Flight Status");
            //} catch ( Exception ex ) {
            //    Singleton.Instance.Error(ex);
            //} finally {
            //    flightService.Close();
            //}
            Cursor.Current = Cursors.Default;
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Flight Edit");

                //var mdiChild = new Flight();
                //mdiChild.MdiParent = this.MdiParent;
                //mdiChild.ShowAsEdit(this,
                //                    ( Guid ) dataGridViewFlightsForPeriod.CurrentRow.Cells["FlightId"].Value,
                //                    Singleton.Instance.UserId
                //                    );

            } catch ( Exception ex ) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dataGridViewFlightsForPeriod_DoubleClick(object sender, EventArgs e) {
            if ( dataGridViewFlightsForPeriod.SelectedRows.Count == 1 )
                Close();
        }
    }
}
