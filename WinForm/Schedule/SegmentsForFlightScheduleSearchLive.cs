using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FlightSegmentsScheduleSearchLive : Form
    {
        Guid _flightSchedule;

        public FlightSegmentsScheduleSearchLive() {
            InitializeComponent();
            InitializeGridFlightSegmentsSchedule();
            this.AcceptButton = buttonSearch;
            this.CancelButton = btnClose;
        }

        public void Show(Guid flightSchedule) {
            _flightSchedule = flightSchedule;
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            ScheduleSearchServiceClient FlightSegmentsSchedule = new ScheduleSearchServiceClient();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = FlightSegmentsSchedule.FlightSegmentsSchedule(_flightSchedule);
                gridFlightSegmentsSchedule.AutoGenerateColumns = true;
                gridFlightSegmentsSchedule.DataSource = bindingSource;
                gridFlightSegmentsSchedule.AutoResizeColumns();
                gridFlightSegmentsSchedule.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                FlightSegmentsSchedule.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void InitializeGridFlightSegmentsSchedule() {
            gridFlightSegmentsSchedule.Columns.Clear();
            gridFlightSegmentsSchedule.AutoGenerateColumns = false;
            gridFlightSegmentsSchedule.Columns.Add("FlightScheduleId", "Flight Schedule Id");
            gridFlightSegmentsSchedule.Columns.Add("FlightScheduleSegmentId", "Flight Schedule Segment Id");
            gridFlightSegmentsSchedule.Columns.Add("AirlineIdentifierCode", "Airline Identifier Code");
            gridFlightSegmentsSchedule.Columns.Add("FlightNumber", "Flight Number");
            gridFlightSegmentsSchedule.Columns.Add("DepartureAirportIdentifierCode", "Departure Airport Identifier Code");
            gridFlightSegmentsSchedule.Columns.Add("DepartureAirportName", "Departure Airport Name");
            gridFlightSegmentsSchedule.Columns.Add("ArrivalAirportIdentifierCode", "Arrival Airport Identifier Code");
            gridFlightSegmentsSchedule.Columns.Add("ArrivalAirportName", "Arrival Airport Name");
            gridFlightSegmentsSchedule.Columns.Add("LogicalSegmentNumber", "Logical Segment Number");
            gridFlightSegmentsSchedule.Columns.Add("PhysicalSegmentNumber", "Physical Segment Number");
            gridFlightSegmentsSchedule.Columns.Add("DepartureTime", "Departure Time");
            gridFlightSegmentsSchedule.Columns.Add("ArrivalTime", "Arrival Time");
            gridFlightSegmentsSchedule.Columns.Add("DepartureGate", "Departure Gate");
            gridFlightSegmentsSchedule.Columns.Add("ArrivalGate", "Arrival Gate");
            gridFlightSegmentsSchedule.Columns.Add("ExtensionData", "");
            gridFlightSegmentsSchedule.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in gridFlightSegmentsSchedule.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            gridFlightSegmentsSchedule.AutoResizeColumns();
        }
    }
}
