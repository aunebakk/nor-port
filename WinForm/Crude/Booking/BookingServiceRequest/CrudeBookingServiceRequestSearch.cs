/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:19:51 AM
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
    public partial class CrudeBookingServiceRequestSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _serviceTypeRcd;
        
        private string _serviceRequestStatusRcd;
        
        private System.Guid _bookingId;
        
        private System.Guid _serviceSpecialServiceRequestId;
        
        private System.Guid _serviceHotelId;
        
        private System.Guid _serviceCarRentalId;
        
        private System.Guid _userId;
        
        private System.Guid _serviceFerryId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeBookingServiceRequestSearch() {
            InitializeComponent();
            InitializeGridCrudeBookingServiceRequest();
            this.AcceptButton = buttonCrudeBookingServiceRequestSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string serviceTypeRcd, string serviceRequestStatusRcd, System.Guid bookingId, System.Guid serviceSpecialServiceRequestId, System.Guid serviceHotelId, System.Guid serviceCarRentalId, System.Guid userId, System.Guid serviceFerryId) {
            try {
                _serviceTypeRcd = serviceTypeRcd;
                _serviceRequestStatusRcd = serviceRequestStatusRcd;
                _bookingId = bookingId;
                _serviceSpecialServiceRequestId = serviceSpecialServiceRequestId;
                _serviceHotelId = serviceHotelId;
                _serviceCarRentalId = serviceCarRentalId;
                _userId = userId;
                userPicker.SelectedValue = userId;
                _serviceFerryId = serviceFerryId;

                RefreshCrudeBookingServiceRequest();

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
        private void buttonCrudeBookingServiceRequestEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingServiceRequestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBookingServiceRequest.CurrentRow.Cells["BookingServiceRequestId"].Value);
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
        private void buttonCrudeBookingServiceRequestAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingServiceRequestEdit();
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
        private void dataGridViewCrudeBookingServiceRequest_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingServiceRequestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBookingServiceRequest.CurrentRow.Cells["BookingServiceRequestId"].Value);
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
        private void buttonCrudeBookingServiceRequestSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeBookingServiceRequest();
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
        public void RefreshCrudeBookingServiceRequest() {
            var bookingServiceRequest = new CrudeBookingServiceRequestServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = bookingServiceRequest.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,serviceTypeRefCombo.Text
                            ,serviceSpecialServiceRequestPicker.SelectedValue
                            ,serviceRequestStatusRefCombo.Text
                            ,Guid.Empty
                            ,serviceCarRentalPicker.SelectedValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,Guid.Empty
                            );
                dataGridViewCrudeBookingServiceRequest.AutoGenerateColumns = false;
                dataGridViewCrudeBookingServiceRequest.DataSource = bindingSource;
                dataGridViewCrudeBookingServiceRequest.AutoResizeColumns();
                dataGridViewCrudeBookingServiceRequest.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                bookingServiceRequest.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeBookingServiceRequest() {
            try {
                dataGridViewCrudeBookingServiceRequest.Columns.Clear();
                dataGridViewCrudeBookingServiceRequest.AutoGenerateColumns = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ServiceTypeRcd","Service Type");
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceTypeRcd"].DataPropertyName = "ServiceTypeRcd";
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ServiceRequestStatusRcd","Service Request Status");
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceRequestStatusRcd"].DataPropertyName = "ServiceRequestStatusRcd";
                dataGridViewCrudeBookingServiceRequest.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeBookingServiceRequest.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeBookingServiceRequest.Columns.Add("BookingServiceRequestId","Booking Service Request");
                dataGridViewCrudeBookingServiceRequest.Columns["BookingServiceRequestId"].DataPropertyName = "BookingServiceRequestId";
                dataGridViewCrudeBookingServiceRequest.Columns["BookingServiceRequestId"].Visible = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("BookingId","Booking");
                dataGridViewCrudeBookingServiceRequest.Columns["BookingId"].DataPropertyName = "BookingId";
                dataGridViewCrudeBookingServiceRequest.Columns["BookingId"].Visible = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ServiceSpecialServiceRequestId","Service Special Service Request");
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceSpecialServiceRequestId"].DataPropertyName = "ServiceSpecialServiceRequestId";
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceSpecialServiceRequestId"].Visible = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ServiceHotelId","Service Hotel");
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceHotelId"].DataPropertyName = "ServiceHotelId";
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceHotelId"].Visible = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ServiceCarRentalId","Service Car Rental");
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceCarRentalId"].DataPropertyName = "ServiceCarRentalId";
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceCarRentalId"].Visible = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ServiceFerryId","Service Ferry");
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceFerryId"].DataPropertyName = "ServiceFerryId";
                dataGridViewCrudeBookingServiceRequest.Columns["ServiceFerryId"].Visible = false;
                dataGridViewCrudeBookingServiceRequest.Columns.Add("ExtensionData", "");
                dataGridViewCrudeBookingServiceRequest.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeBookingServiceRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeBookingServiceRequest.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
