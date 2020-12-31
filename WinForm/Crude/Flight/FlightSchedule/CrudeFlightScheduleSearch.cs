﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:19:55 AM
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
    public partial class CrudeFlightScheduleSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _aircraftTypeRcd;
        
        private System.Guid _airlineId;
        
        private System.Guid _departureAirportId;
        
        private System.Guid _arrivalAirportId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFlightScheduleSearch() {
            InitializeComponent();
            InitializeGridCrudeFlightSchedule();
            this.AcceptButton = buttonCrudeFlightScheduleSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string aircraftTypeRcd, System.Guid airlineId, System.Guid departureAirportId, System.Guid arrivalAirportId, System.Guid userId) {
            try {
                _aircraftTypeRcd = aircraftTypeRcd;
                _airlineId = airlineId;
                _departureAirportId = departureAirportId;
                _arrivalAirportId = arrivalAirportId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFlightSchedule();

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
        private void buttonCrudeFlightScheduleEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightScheduleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFlightSchedule.CurrentRow.Cells["FlightScheduleId"].Value);
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
        private void buttonCrudeFlightScheduleAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightScheduleEdit();
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
        private void dataGridViewCrudeFlightSchedule_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFlightScheduleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFlightSchedule.CurrentRow.Cells["FlightScheduleId"].Value);
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
        private void buttonCrudeFlightScheduleSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFlightSchedule();
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
        public void RefreshCrudeFlightSchedule() {
            var flightSchedule = new CrudeFlightScheduleServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = flightSchedule.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,airlinePicker.SelectedValue
                            ,aircraftTypeRefCombo.Text
                            ,departureAirportPicker.SelectedValue
                            ,arrivalAirportPicker.SelectedValue
                            ,textBoxComment.Text
                            ,dateTimePickerFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerFromDateTime.Value): DateTime.MinValue
                            ,dateTimePickerUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerUntilDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFlightSchedule.AutoGenerateColumns = false;
                dataGridViewCrudeFlightSchedule.DataSource = bindingSource;
                dataGridViewCrudeFlightSchedule.AutoResizeColumns();
                dataGridViewCrudeFlightSchedule.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                flightSchedule.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFlightSchedule() {
            try {
                dataGridViewCrudeFlightSchedule.Columns.Clear();
                dataGridViewCrudeFlightSchedule.AutoGenerateColumns = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("AircraftTypeRcd","Aircraft Type");
                dataGridViewCrudeFlightSchedule.Columns["AircraftTypeRcd"].DataPropertyName = "AircraftTypeRcd";
                dataGridViewCrudeFlightSchedule.Columns.Add("Comment","Comment");
                dataGridViewCrudeFlightSchedule.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeFlightSchedule.Columns.Add("FromDateTime","From Date Time");
                dataGridViewCrudeFlightSchedule.Columns["FromDateTime"].DataPropertyName = "FromDateTime";
                dataGridViewCrudeFlightSchedule.Columns.Add("UntilDateTime","Until Date Time");
                dataGridViewCrudeFlightSchedule.Columns["UntilDateTime"].DataPropertyName = "UntilDateTime";
                dataGridViewCrudeFlightSchedule.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFlightSchedule.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFlightSchedule.Columns.Add("FlightScheduleId","Flight Schedule");
                dataGridViewCrudeFlightSchedule.Columns["FlightScheduleId"].DataPropertyName = "FlightScheduleId";
                dataGridViewCrudeFlightSchedule.Columns["FlightScheduleId"].Visible = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("BecameFlightScheduleId","Became Flight Schedule");
                dataGridViewCrudeFlightSchedule.Columns["BecameFlightScheduleId"].DataPropertyName = "BecameFlightScheduleId";
                dataGridViewCrudeFlightSchedule.Columns["BecameFlightScheduleId"].Visible = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("BindingFlightScheduleId","Binding Flight Schedule");
                dataGridViewCrudeFlightSchedule.Columns["BindingFlightScheduleId"].DataPropertyName = "BindingFlightScheduleId";
                dataGridViewCrudeFlightSchedule.Columns["BindingFlightScheduleId"].Visible = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("AirlineId","Airline");
                dataGridViewCrudeFlightSchedule.Columns["AirlineId"].DataPropertyName = "AirlineId";
                dataGridViewCrudeFlightSchedule.Columns["AirlineId"].Visible = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("DepartureAirportId","Departure Airport");
                dataGridViewCrudeFlightSchedule.Columns["DepartureAirportId"].DataPropertyName = "DepartureAirportId";
                dataGridViewCrudeFlightSchedule.Columns["DepartureAirportId"].Visible = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("ArrivalAirportId","Arrival Airport");
                dataGridViewCrudeFlightSchedule.Columns["ArrivalAirportId"].DataPropertyName = "ArrivalAirportId";
                dataGridViewCrudeFlightSchedule.Columns["ArrivalAirportId"].Visible = false;
                dataGridViewCrudeFlightSchedule.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFlightSchedule.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFlightSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFlightSchedule.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
