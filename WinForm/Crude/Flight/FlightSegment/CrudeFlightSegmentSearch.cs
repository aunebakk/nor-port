/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 7:05:40 PM
  From Machine: DESKTOP-BP3OHLH
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
    public partial class CrudeFlightSegmentSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _flightId;
        
        private System.Guid _departureAirportId;
        
        private System.Guid _arrivalAirportId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFlightSegmentSearch() {
            InitializeComponent();
            InitializeGridCrudeFlightSegment();
            this.AcceptButton = buttonCrudeFlightSegmentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid flightId, System.Guid departureAirportId, System.Guid arrivalAirportId, System.Guid userId) {
            try {
                _flightId = flightId;
                _departureAirportId = departureAirportId;
                _arrivalAirportId = arrivalAirportId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFlightSegment();

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
        private void buttonCrudeFlightSegmentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFlightSegment.CurrentRow.Cells["FlightSegmentId"].Value);
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
        private void buttonCrudeFlightSegmentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightSegmentEdit();
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
        private void dataGridViewCrudeFlightSegment_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFlightSegment.CurrentRow.Cells["FlightSegmentId"].Value);
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
        private void buttonCrudeFlightSegmentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFlightSegment();
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
        public void RefreshCrudeFlightSegment() {
            var flightSegment = new CrudeFlightSegmentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = flightSegment.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,departureAirportPicker.SelectedValue
                            ,arrivalAirportPicker.SelectedValue
                            ,maskedTextBoxLogicalSegmentNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxLogicalSegmentNumber.Text)
                            ,maskedTextBoxPhysicalSegmentNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPhysicalSegmentNumber.Text)
                            ,dateTimePickerFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerFromDateTime.Value): DateTime.MinValue
                            ,dateTimePickerUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerUntilDateTime.Value): DateTime.MinValue
                            ,textBoxDepartureGate.Text
                            ,textBoxArrivalGate.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFlightSegment.AutoGenerateColumns = false;
                dataGridViewCrudeFlightSegment.DataSource = bindingSource;
                dataGridViewCrudeFlightSegment.AutoResizeColumns();
                dataGridViewCrudeFlightSegment.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                flightSegment.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFlightSegment() {
            try {
                dataGridViewCrudeFlightSegment.Columns.Clear();
                dataGridViewCrudeFlightSegment.AutoGenerateColumns = false;
                dataGridViewCrudeFlightSegment.Columns.Add("DepartureGate","Departure Gate");
                dataGridViewCrudeFlightSegment.Columns["DepartureGate"].DataPropertyName = "DepartureGate";
                dataGridViewCrudeFlightSegment.Columns.Add("ArrivalGate","Arrival Gate");
                dataGridViewCrudeFlightSegment.Columns["ArrivalGate"].DataPropertyName = "ArrivalGate";
                dataGridViewCrudeFlightSegment.Columns.Add("LogicalSegmentNumber","Logical Segment Number");
                dataGridViewCrudeFlightSegment.Columns["LogicalSegmentNumber"].DataPropertyName = "LogicalSegmentNumber";
                dataGridViewCrudeFlightSegment.Columns.Add("PhysicalSegmentNumber","Physical Segment Number");
                dataGridViewCrudeFlightSegment.Columns["PhysicalSegmentNumber"].DataPropertyName = "PhysicalSegmentNumber";
                dataGridViewCrudeFlightSegment.Columns.Add("FromDateTime","From Date Time");
                dataGridViewCrudeFlightSegment.Columns["FromDateTime"].DataPropertyName = "FromDateTime";
                dataGridViewCrudeFlightSegment.Columns.Add("UntilDateTime","Until Date Time");
                dataGridViewCrudeFlightSegment.Columns["UntilDateTime"].DataPropertyName = "UntilDateTime";
                dataGridViewCrudeFlightSegment.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFlightSegment.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFlightSegment.Columns.Add("FlightSegmentId","Flight Segment");
                dataGridViewCrudeFlightSegment.Columns["FlightSegmentId"].DataPropertyName = "FlightSegmentId";
                dataGridViewCrudeFlightSegment.Columns["FlightSegmentId"].Visible = false;
                dataGridViewCrudeFlightSegment.Columns.Add("FlightId","Flight");
                dataGridViewCrudeFlightSegment.Columns["FlightId"].DataPropertyName = "FlightId";
                dataGridViewCrudeFlightSegment.Columns["FlightId"].Visible = false;
                dataGridViewCrudeFlightSegment.Columns.Add("DepartureAirportId","Departure Airport");
                dataGridViewCrudeFlightSegment.Columns["DepartureAirportId"].DataPropertyName = "DepartureAirportId";
                dataGridViewCrudeFlightSegment.Columns["DepartureAirportId"].Visible = false;
                dataGridViewCrudeFlightSegment.Columns.Add("ArrivalAirportId","Arrival Airport");
                dataGridViewCrudeFlightSegment.Columns["ArrivalAirportId"].DataPropertyName = "ArrivalAirportId";
                dataGridViewCrudeFlightSegment.Columns["ArrivalAirportId"].Visible = false;
                dataGridViewCrudeFlightSegment.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFlightSegment.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFlightSegment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFlightSegment.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
