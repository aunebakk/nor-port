/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 2:30:26 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeBookingFlightSegmentSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _defaultStateRcd;
        
        private System.Guid _bookingId;
        
        private System.Guid _flightSegmentId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeBookingFlightSegmentSearch() {
            InitializeComponent();
            InitializeGridCrudeBookingFlightSegment();
            this.AcceptButton = buttonCrudeBookingFlightSegmentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string defaultStateRcd, System.Guid bookingId, System.Guid flightSegmentId, System.Guid userId) {
            try {
                _defaultStateRcd = defaultStateRcd;
                _bookingId = bookingId;
                _flightSegmentId = flightSegmentId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeBookingFlightSegment();

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
        private void buttonCrudeBookingFlightSegmentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingFlightSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBookingFlightSegment.CurrentRow.Cells["BookingFlightSegmentId"].Value);
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
        private void buttonCrudeBookingFlightSegmentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingFlightSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultStateRcd,_userId);
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
        private void dataGridViewCrudeBookingFlightSegment_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingFlightSegmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBookingFlightSegment.CurrentRow.Cells["BookingFlightSegmentId"].Value);
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
        private void buttonCrudeBookingFlightSegmentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeBookingFlightSegment();
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
        public void RefreshCrudeBookingFlightSegment() {
            var bookingFlightSegment = new CrudeBookingFlightSegmentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = bookingFlightSegment.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,defaultStateRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeBookingFlightSegment.AutoGenerateColumns = false;
                dataGridViewCrudeBookingFlightSegment.DataSource = bindingSource;
                dataGridViewCrudeBookingFlightSegment.AutoResizeColumns();
                dataGridViewCrudeBookingFlightSegment.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                bookingFlightSegment.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeBookingFlightSegment() {
            try {
                dataGridViewCrudeBookingFlightSegment.Columns.Clear();
                dataGridViewCrudeBookingFlightSegment.AutoGenerateColumns = false;
                dataGridViewCrudeBookingFlightSegment.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeBookingFlightSegment.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeBookingFlightSegment.Columns.Add("BookingFlightSegmentId","Booking Flight Segment");
                dataGridViewCrudeBookingFlightSegment.Columns["BookingFlightSegmentId"].DataPropertyName = "BookingFlightSegmentId";
                dataGridViewCrudeBookingFlightSegment.Columns["BookingFlightSegmentId"].Visible = false;
                dataGridViewCrudeBookingFlightSegment.Columns.Add("BecameBookingFlightSegmentId","Became Booking Flight Segment");
                dataGridViewCrudeBookingFlightSegment.Columns["BecameBookingFlightSegmentId"].DataPropertyName = "BecameBookingFlightSegmentId";
                dataGridViewCrudeBookingFlightSegment.Columns["BecameBookingFlightSegmentId"].Visible = false;
                dataGridViewCrudeBookingFlightSegment.Columns.Add("BindingBookingFlightSegmentId","Binding Booking Flight Segment");
                dataGridViewCrudeBookingFlightSegment.Columns["BindingBookingFlightSegmentId"].DataPropertyName = "BindingBookingFlightSegmentId";
                dataGridViewCrudeBookingFlightSegment.Columns["BindingBookingFlightSegmentId"].Visible = false;
                dataGridViewCrudeBookingFlightSegment.Columns.Add("BookingId","Booking");
                dataGridViewCrudeBookingFlightSegment.Columns["BookingId"].DataPropertyName = "BookingId";
                dataGridViewCrudeBookingFlightSegment.Columns["BookingId"].Visible = false;
                dataGridViewCrudeBookingFlightSegment.Columns.Add("FlightSegmentId","Flight Segment");
                dataGridViewCrudeBookingFlightSegment.Columns["FlightSegmentId"].DataPropertyName = "FlightSegmentId";
                dataGridViewCrudeBookingFlightSegment.Columns["FlightSegmentId"].Visible = false;
                dataGridViewCrudeBookingFlightSegment.Columns.Add("ExtensionData", "");
                dataGridViewCrudeBookingFlightSegment.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeBookingFlightSegment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeBookingFlightSegment.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
