/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 2:15:12 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeFlightScheduleSegmentSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _flightScheduleId;
        
        private System.Guid _departureAirportId;
        
        private System.Guid _arrivalAirportId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFlightScheduleSegmentSearch() {
            InitializeComponent();
            InitializeGridCrudeFlightScheduleSegment();
            this.AcceptButton = buttonCrudeFlightScheduleSegmentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid flightScheduleId, System.Guid departureAirportId, System.Guid arrivalAirportId, System.Guid userId) {
            try {
                _flightScheduleId = flightScheduleId;
                _departureAirportId = departureAirportId;
                _arrivalAirportId = arrivalAirportId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFlightScheduleSegment();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/c778f8fe-1b09-4755-891f-f9d3126d1b85
        private void buttonCrudeFlightScheduleSegmentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightScheduleSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFlightScheduleSegment.CurrentRow.Cells["FlightScheduleSegmentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/499f894b-7c95-446b-be0a-57fd47b768e3
        private void buttonCrudeFlightScheduleSegmentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightScheduleSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9e26c97-bd6d-404a-80ad-d252a24c6fe8
        private void dataGridViewCrudeFlightScheduleSegment_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightScheduleSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFlightScheduleSegment.CurrentRow.Cells["FlightScheduleSegmentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/4c1fe3ad-84a0-4295-bd83-73d9e9afe750
        private void buttonCrudeFlightScheduleSegmentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFlightScheduleSegment();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6b990ce5-1c34-4759-bffd-659ae312004d
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/a90065e7-8ace-4de7-9367-d4653a7c637f
        public void RefreshCrudeFlightScheduleSegment() {
            var flightScheduleSegment = new CrudeFlightScheduleSegmentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = flightScheduleSegment.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,departureAirportPicker.SelectedValue
                            ,arrivalAirportPicker.SelectedValue
                            ,maskedTextBoxPhysicalSegmentNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPhysicalSegmentNumber.Text)
                            ,maskedTextBoxLogicalSegmentNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxLogicalSegmentNumber.Text)
                            ,TimeSpan.Parse(textBoxDepartureTime.Text)
                            ,TimeSpan.Parse(textBoxArrivalTime.Text)
                            ,textBoxDepartureGate.Text
                            ,textBoxArrivalGate.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFlightScheduleSegment.AutoGenerateColumns = false;
                dataGridViewCrudeFlightScheduleSegment.DataSource = bindingSource;
                dataGridViewCrudeFlightScheduleSegment.AutoResizeColumns();
                dataGridViewCrudeFlightScheduleSegment.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                flightScheduleSegment.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFlightScheduleSegment() {
            try {
                dataGridViewCrudeFlightScheduleSegment.Columns.Clear();
                dataGridViewCrudeFlightScheduleSegment.AutoGenerateColumns = false;
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("DepartureTime","Departure Time");
                dataGridViewCrudeFlightScheduleSegment.Columns["DepartureTime"].DataPropertyName = "DepartureTime";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("ArrivalTime","Arrival Time");
                dataGridViewCrudeFlightScheduleSegment.Columns["ArrivalTime"].DataPropertyName = "ArrivalTime";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("DepartureGate","Departure Gate");
                dataGridViewCrudeFlightScheduleSegment.Columns["DepartureGate"].DataPropertyName = "DepartureGate";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("ArrivalGate","Arrival Gate");
                dataGridViewCrudeFlightScheduleSegment.Columns["ArrivalGate"].DataPropertyName = "ArrivalGate";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("PhysicalSegmentNumber","Physical Segment Number");
                dataGridViewCrudeFlightScheduleSegment.Columns["PhysicalSegmentNumber"].DataPropertyName = "PhysicalSegmentNumber";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("LogicalSegmentNumber","Logical Segment Number");
                dataGridViewCrudeFlightScheduleSegment.Columns["LogicalSegmentNumber"].DataPropertyName = "LogicalSegmentNumber";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFlightScheduleSegment.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("FlightScheduleSegmentId","Flight Schedule Segment");
                dataGridViewCrudeFlightScheduleSegment.Columns["FlightScheduleSegmentId"].DataPropertyName = "FlightScheduleSegmentId";
                dataGridViewCrudeFlightScheduleSegment.Columns["FlightScheduleSegmentId"].Visible = false;
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("FlightScheduleId","Flight Schedule");
                dataGridViewCrudeFlightScheduleSegment.Columns["FlightScheduleId"].DataPropertyName = "FlightScheduleId";
                dataGridViewCrudeFlightScheduleSegment.Columns["FlightScheduleId"].Visible = false;
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("DepartureAirportId","Departure Airport");
                dataGridViewCrudeFlightScheduleSegment.Columns["DepartureAirportId"].DataPropertyName = "DepartureAirportId";
                dataGridViewCrudeFlightScheduleSegment.Columns["DepartureAirportId"].Visible = false;
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("ArrivalAirportId","Arrival Airport");
                dataGridViewCrudeFlightScheduleSegment.Columns["ArrivalAirportId"].DataPropertyName = "ArrivalAirportId";
                dataGridViewCrudeFlightScheduleSegment.Columns["ArrivalAirportId"].Visible = false;
                dataGridViewCrudeFlightScheduleSegment.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFlightScheduleSegment.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFlightScheduleSegment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFlightScheduleSegment.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
