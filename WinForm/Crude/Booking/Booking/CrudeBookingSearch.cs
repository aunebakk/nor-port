﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:15:08 PM
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
    public partial class CrudeBookingSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _bookingSourceRcd;
        
        private System.Guid _addressId;
        
        private System.Guid _externalSystemId;
        
        private System.Guid _agencyId;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _financialCostcentreId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeBookingSearch() {
            InitializeComponent();
            InitializeGridCrudeBooking();
            this.AcceptButton = buttonCrudeBookingSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string bookingSourceRcd, System.Guid addressId, System.Guid externalSystemId, System.Guid agencyId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid userId) {
            try {
                _bookingSourceRcd = bookingSourceRcd;
                _addressId = addressId;
                _externalSystemId = externalSystemId;
                _agencyId = agencyId;
                _financialCurrencyId = financialCurrencyId;
                _financialCostcentreId = financialCostcentreId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeBooking();

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
        private void buttonCrudeBookingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBooking.CurrentRow.Cells["BookingId"].Value);
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
        private void buttonCrudeBookingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingEdit();
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
        private void dataGridViewCrudeBooking_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeBookingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeBooking.CurrentRow.Cells["BookingId"].Value);
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
        private void buttonCrudeBookingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeBooking();
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
        public void RefreshCrudeBooking() {
            var booking = new CrudeBookingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = booking.FetchWithFilter(
                             Guid.Empty
                            ,textBoxReceivedFrom.Text
                            ,Guid.Empty
                            ,bookingSourceRefCombo.Text
                            ,externalSystemPicker.SelectedValue
                            ,agencyPicker.SelectedValue
                            ,financialCurrencyPicker.SelectedValue
                            ,financialCostcentrePicker.SelectedValue
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeBooking.AutoGenerateColumns = false;
                dataGridViewCrudeBooking.DataSource = bindingSource;
                dataGridViewCrudeBooking.AutoResizeColumns();
                dataGridViewCrudeBooking.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                booking.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeBooking() {
            try {
                dataGridViewCrudeBooking.Columns.Clear();
                dataGridViewCrudeBooking.AutoGenerateColumns = false;
                dataGridViewCrudeBooking.Columns.Add("ReceivedFrom","Received From");
                dataGridViewCrudeBooking.Columns["ReceivedFrom"].DataPropertyName = "ReceivedFrom";
                dataGridViewCrudeBooking.Columns.Add("BookingSourceRcd","Booking Source");
                dataGridViewCrudeBooking.Columns["BookingSourceRcd"].DataPropertyName = "BookingSourceRcd";
                dataGridViewCrudeBooking.Columns.Add("Comment","Comment");
                dataGridViewCrudeBooking.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeBooking.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeBooking.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeBooking.Columns.Add("BookingId","Booking");
                dataGridViewCrudeBooking.Columns["BookingId"].DataPropertyName = "BookingId";
                dataGridViewCrudeBooking.Columns["BookingId"].Visible = false;
                dataGridViewCrudeBooking.Columns.Add("AddressId","Address");
                dataGridViewCrudeBooking.Columns["AddressId"].DataPropertyName = "AddressId";
                dataGridViewCrudeBooking.Columns["AddressId"].Visible = false;
                dataGridViewCrudeBooking.Columns.Add("ExternalSystemId","External System");
                dataGridViewCrudeBooking.Columns["ExternalSystemId"].DataPropertyName = "ExternalSystemId";
                dataGridViewCrudeBooking.Columns["ExternalSystemId"].Visible = false;
                dataGridViewCrudeBooking.Columns.Add("AgencyId","Agency");
                dataGridViewCrudeBooking.Columns["AgencyId"].DataPropertyName = "AgencyId";
                dataGridViewCrudeBooking.Columns["AgencyId"].Visible = false;
                dataGridViewCrudeBooking.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeBooking.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeBooking.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeBooking.Columns.Add("FinancialCostcentreId","Financial Costcentre");
                dataGridViewCrudeBooking.Columns["FinancialCostcentreId"].DataPropertyName = "FinancialCostcentreId";
                dataGridViewCrudeBooking.Columns["FinancialCostcentreId"].Visible = false;
                dataGridViewCrudeBooking.Columns.Add("ExtensionData", "");
                dataGridViewCrudeBooking.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeBooking.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}