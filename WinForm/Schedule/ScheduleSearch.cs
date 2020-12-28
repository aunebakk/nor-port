using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ScheduleSearch : Form
    {

        public ScheduleSearch() {
            InitializeComponent();
            InitializeGridFlightSchedule();
            this.AcceptButton = buttonSearch;
            this.CancelButton = btnClose;
        }

        public new void Show() {
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            ScheduleSearchService flightSchedule = new ScheduleSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = flightSchedule.FlightSchedule();
                gridFlightSchedule.AutoGenerateColumns = true;
                gridFlightSchedule.DataSource = bindingSource;
                gridFlightSchedule.AutoResizeColumns();
                gridFlightSchedule.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                flightSchedule.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void InitializeGridFlightSchedule() {
            gridFlightSchedule.Columns.Clear();
            gridFlightSchedule.AutoGenerateColumns = false;
            gridFlightSchedule.Columns.Add("FlightScheduleId", "Flight Schedule Id");
            gridFlightSchedule.Columns.Add("AirlineIdentifierCode", "Airline Identifier Code");
            gridFlightSchedule.Columns.Add("AirlineName", "Airline Name");
            gridFlightSchedule.Columns.Add("FlightNumber", "Flight Number");
            gridFlightSchedule.Columns.Add("AircraftTypeName", "Aircraft Type Name");
            gridFlightSchedule.Columns.Add("DepartureAirportIdentifierCode", "Departure Airport Identifier Code");
            gridFlightSchedule.Columns.Add("DepartureAirportName", "Departure Airport Name");
            gridFlightSchedule.Columns.Add("ArrivalAirportIdentifierCode", "Arrival Airport Identifier Code");
            gridFlightSchedule.Columns.Add("ArrivalAirportName", "Arrival Airport Name");
            gridFlightSchedule.Columns.Add("FromDateTime", "From Date Time");
            gridFlightSchedule.Columns.Add("UntilDateTime", "Until Date Time");
            gridFlightSchedule.Columns.Add("SegmentCount", "Segment Count");
            gridFlightSchedule.Columns.Add("ExtensionData", "");
            gridFlightSchedule.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in gridFlightSchedule.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            gridFlightSchedule.AutoResizeColumns();
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Flight Schedule");

                //var mdiChild = new Schedule();
                //mdiChild.MdiParent = this.MdiParent;
                //mdiChild.ShowAsEdit(this,
                //                    ( Guid ) gridFlightSchedule.CurrentRow.Cells["FlightScheduleId"].Value,
                //                    Singleton.Instance.UserId
                //                    );

            } catch ( Exception ex ) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonSegments_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Flight Segments");

                var mdiChild = new FlightSegmentsScheduleSearchLive();
                mdiChild.MdiParent = this.MdiParent;
                mdiChild.Show(( Guid ) gridFlightSchedule.CurrentRow.Cells["FlightScheduleId"].Value);

            } catch ( Exception ex ) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonNew_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Flight Schedule");

                //var mdiChild = new Schedule();
                //mdiChild.MdiParent = this.MdiParent;
                //mdiChild.ShowAsAdd(this,
                //                    Guid.Empty,
                //                    Singleton.Instance.UserId
                //                    );

            } catch ( Exception ex ) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        public void RefreshSearch() {
            buttonSearch_Click(new object(), new EventArgs());
        }

        private void gridFlightSchedule_DoubleClick(object sender, EventArgs e) {
            buttonEdit_Click(new object(), new EventArgs());
        }

        private void buttonMakeFlights_Click(object sender, EventArgs e) {
            //Cursor.Current = Cursors.WaitCursor;
            //var flightSchedule = new ScheduleServiceClient();
            //try {
            //    Singleton.Instance.Log("Make Flights");
            //    Singleton.Instance.LogToTop();

            //    for ( int row = 0; row < gridFlightSchedule.SelectedRows.Count; row++ ) {
            //        flightSchedule.MakeFlightsFromSchedule(
            //            ( Guid ) gridFlightSchedule.SelectedRows[row].Cells["FlightScheduleId"].Value,
            //            Singleton.Instance.UserId
            //            );
            //    }

            //    Singleton.Instance.Log("Made Flights");
            //} catch ( Exception ex ) {
            //    Singleton.Instance.Error(ex);
            //} finally {
            //    flightSchedule.Close();
            //}
            //Cursor.Current = Cursors.Default;
        }

        private void buttonMakeAll_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Make All Flights");
                Singleton.Instance.LogToTop();

                //new ScheduleServiceClient().MakeFlightsFromScheduleAll(
                //    Singleton.Instance.UserId
                //    );

                Singleton.Instance.Log("Made Flights");
            } catch ( Exception ex ) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
