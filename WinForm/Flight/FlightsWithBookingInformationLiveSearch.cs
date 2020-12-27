using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FlightsWithBookingInformationLiveSearch : Form
    {

        public FlightsWithBookingInformationLiveSearch() {
            InitializeComponent();
            InitializeGridFlightsWithBookingInformation();
            this.AcceptButton = buttonFlightsWithBookingInformationSearch;
            this.CancelButton = buttonClose;
        }

        public new void Show() {
            dateTimePickerFromDateTime.Value = DateTime.UtcNow.Date;
            dateTimePickerFromDateTime.Checked = true;
            dateTimePickerUntilDateTime.Value = DateTime.UtcNow.Date.AddDays(1);
            dateTimePickerUntilDateTime.Checked = true;

            RefreshFlightsWithBookingInformation();
            base.Show();
        }

        private void buttonFlightsWithBookingInformationSearch_Click(object sender, EventArgs e) {
            RefreshFlightsWithBookingInformation();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void RefreshFlightsWithBookingInformation() {
            FlightSearchService flightsWithBookingInformation = new FlightSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource =
                    flightsWithBookingInformation.FlightsWithBookingInformation(
                        departureAirportPicker.SelectedValue,
                        arrivalAirportPicker.SelectedValue,
                        dateTimePickerFromDateTime.Value,
                        dateTimePickerUntilDateTime.Value
                        );

                dataGridViewFlightsWithBookingInformation.AutoGenerateColumns = true;
                dataGridViewFlightsWithBookingInformation.DataSource = bindingSource;
                dataGridViewFlightsWithBookingInformation.AutoResizeColumns();
                dataGridViewFlightsWithBookingInformation.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                flightsWithBookingInformation.Close();
            }
        }

        private void InitializeGridFlightsWithBookingInformation() {
            dataGridViewFlightsWithBookingInformation.Columns.Clear();
            dataGridViewFlightsWithBookingInformation.AutoGenerateColumns = false;
            dataGridViewFlightsWithBookingInformation.Columns.Add("FlightId", "Flight Id");
            dataGridViewFlightsWithBookingInformation.Columns.Add("AirlineIdentifierCode", "Airline");
            dataGridViewFlightsWithBookingInformation.Columns.Add("FlightNumber", "Flight");
            dataGridViewFlightsWithBookingInformation.Columns.Add("DepartureAirportIdentifierCode", "Departure");
            dataGridViewFlightsWithBookingInformation.Columns.Add("DepartureAirportName", "Departure Name");
            dataGridViewFlightsWithBookingInformation.Columns.Add("ArrivalAirportIdentifierCode", "Arrival");
            dataGridViewFlightsWithBookingInformation.Columns.Add("ArrivalAirportName", "Arrival Name");
            dataGridViewFlightsWithBookingInformation.Columns.Add("FromDateTime", "From");
            dataGridViewFlightsWithBookingInformation.Columns.Add("UntilDateTime", "Until");
            dataGridViewFlightsWithBookingInformation.Columns.Add("CanBookFlag", "Can Book");
            dataGridViewFlightsWithBookingInformation.Columns.Add("CanCheckinFlag", "Can Checkin");
            dataGridViewFlightsWithBookingInformation.Columns.Add("InFlightFlag", "In Flight");
            dataGridViewFlightsWithBookingInformation.Columns.Add("FlightsBookedCount", "Flights Booked");
            dataGridViewFlightsWithBookingInformation.Columns.Add("LastDateTimeTypeName", "Last Type");
            dataGridViewFlightsWithBookingInformation.Columns.Add("PlannedDepartureDateTime", "Planned Departure");
            dataGridViewFlightsWithBookingInformation.Columns.Add("EstimatedDepartureDateTime", "Estimated Departure");
            dataGridViewFlightsWithBookingInformation.Columns.Add("ExtensionData", "");
            dataGridViewFlightsWithBookingInformation.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewFlightsWithBookingInformation.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewFlightsWithBookingInformation.AutoResizeColumns();
        }
    }
}
