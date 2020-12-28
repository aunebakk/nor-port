/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:15:09 PM
  From Machine: DESKTOP-LSRVP12
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
    public partial class CrudeBookingPassengerEventSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _bookingPassengerEventTypeRcd;
        
        private System.Guid _bookingPassengerId;
        
        private System.Guid _bookingFlightSegmentId;
        
        private System.Guid _bookingPassengerTicketId;
        
        private System.Guid _bookingPassengerSeatId;
        
        private System.Guid _bookingPassengerBaggageId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeBookingPassengerEventSearch() {
            InitializeComponent();
            InitializeGridCrudeBookingPassengerEvent();
            this.AcceptButton = buttonCrudeBookingPassengerEventSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string bookingPassengerEventTypeRcd, System.Guid bookingPassengerId, System.Guid bookingFlightSegmentId, System.Guid bookingPassengerTicketId, System.Guid bookingPassengerSeatId, System.Guid bookingPassengerBaggageId, System.Guid userId) {
            try {
                _bookingPassengerEventTypeRcd = bookingPassengerEventTypeRcd;
                _bookingPassengerId = bookingPassengerId;
                _bookingFlightSegmentId = bookingFlightSegmentId;
                _bookingPassengerTicketId = bookingPassengerTicketId;
                _bookingPassengerSeatId = bookingPassengerSeatId;
                _bookingPassengerBaggageId = bookingPassengerBaggageId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeBookingPassengerEvent();

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
        private void buttonCrudeBookingPassengerEventEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingPassengerEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBookingPassengerEvent.CurrentRow.Cells["BookingPassengerEventId"].Value);
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
        private void buttonCrudeBookingPassengerEventAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingPassengerEventEdit();
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
        private void dataGridViewCrudeBookingPassengerEvent_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingPassengerEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBookingPassengerEvent.CurrentRow.Cells["BookingPassengerEventId"].Value);
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
        private void buttonCrudeBookingPassengerEventSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeBookingPassengerEvent();
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
        public void RefreshCrudeBookingPassengerEvent() {
            var bookingPassengerEvent = new CrudeBookingPassengerEventServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = bookingPassengerEvent.FetchWithFilter(
                             Guid.Empty
                            ,bookingPassengerEventTypeRefCombo.Text
                            ,maskedTextBoxBookingPassengerEventNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxBookingPassengerEventNumber.Text)
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,textBoxRemarks.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeBookingPassengerEvent.AutoGenerateColumns = false;
                dataGridViewCrudeBookingPassengerEvent.DataSource = bindingSource;
                dataGridViewCrudeBookingPassengerEvent.AutoResizeColumns();
                dataGridViewCrudeBookingPassengerEvent.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                bookingPassengerEvent.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeBookingPassengerEvent() {
            try {
                dataGridViewCrudeBookingPassengerEvent.Columns.Clear();
                dataGridViewCrudeBookingPassengerEvent.AutoGenerateColumns = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerEventTypeRcd","Booking Passenger Event Type");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerEventTypeRcd"].DataPropertyName = "BookingPassengerEventTypeRcd";
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("Remarks","Remarks");
                dataGridViewCrudeBookingPassengerEvent.Columns["Remarks"].DataPropertyName = "Remarks";
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerEventNumber","Booking Passenger Event Number");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerEventNumber"].DataPropertyName = "BookingPassengerEventNumber";
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeBookingPassengerEvent.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerEventId","Booking Passenger Event");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerEventId"].DataPropertyName = "BookingPassengerEventId";
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerEventId"].Visible = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerId","Booking Passenger");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerId"].DataPropertyName = "BookingPassengerId";
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerId"].Visible = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingFlightSegmentId","Booking Flight Segment");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingFlightSegmentId"].DataPropertyName = "BookingFlightSegmentId";
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingFlightSegmentId"].Visible = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerTicketId","Booking Passenger Ticket");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerTicketId"].DataPropertyName = "BookingPassengerTicketId";
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerTicketId"].Visible = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerSeatId","Booking Passenger Seat");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerSeatId"].DataPropertyName = "BookingPassengerSeatId";
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerSeatId"].Visible = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("BookingPassengerBaggageId","Booking Passenger Baggage");
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerBaggageId"].DataPropertyName = "BookingPassengerBaggageId";
                dataGridViewCrudeBookingPassengerEvent.Columns["BookingPassengerBaggageId"].Visible = false;
                dataGridViewCrudeBookingPassengerEvent.Columns.Add("ExtensionData", "");
                dataGridViewCrudeBookingPassengerEvent.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeBookingPassengerEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeBookingPassengerEvent.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
