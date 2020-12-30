/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 6:36:22 AM
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
    public partial class CrudeFinancialBookingTransactionSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _financialBookingTransactionTypeRcd;
        
        private System.Guid _bookingId;
        
        private System.Guid _financialFeeId;
        
        private System.Guid _financialTaxId;
        
        private System.Guid _financialFareId;
        
        private System.Guid _financialPaymentId;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _financialCostcentreId;
        
        private System.Guid _financialAdjustmentId;
        
        private System.Guid _financialServiceId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFinancialBookingTransactionSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialBookingTransaction();
            this.AcceptButton = buttonCrudeFinancialBookingTransactionSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string financialBookingTransactionTypeRcd, System.Guid bookingId, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialFareId, System.Guid financialPaymentId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, System.Guid financialServiceId, System.Guid userId) {
            try {
                _financialBookingTransactionTypeRcd = financialBookingTransactionTypeRcd;
                _bookingId = bookingId;
                _financialFeeId = financialFeeId;
                _financialTaxId = financialTaxId;
                _financialFareId = financialFareId;
                _financialPaymentId = financialPaymentId;
                _financialCurrencyId = financialCurrencyId;
                _financialCostcentreId = financialCostcentreId;
                _financialAdjustmentId = financialAdjustmentId;
                _financialServiceId = financialServiceId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFinancialBookingTransaction();

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
        private void buttonCrudeFinancialBookingTransactionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialBookingTransactionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialBookingTransaction.CurrentRow.Cells["FinancialBookingTransactionId"].Value);
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
        private void buttonCrudeFinancialBookingTransactionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialBookingTransactionEdit();
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
        private void dataGridViewCrudeFinancialBookingTransaction_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialBookingTransactionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialBookingTransaction.CurrentRow.Cells["FinancialBookingTransactionId"].Value);
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
        private void buttonCrudeFinancialBookingTransactionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialBookingTransaction();
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
        public void RefreshCrudeFinancialBookingTransaction() {
            var financialBookingTransaction = new CrudeFinancialBookingTransactionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialBookingTransaction.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,maskedTextBoxTransactionNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxTransactionNumber.Text)
                            ,financialBookingTransactionTypeRefCombo.Text
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,financialCurrencyPicker.SelectedValue
                            ,financialCostcentrePicker.SelectedValue
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialBookingTransaction.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialBookingTransaction.DataSource = bindingSource;
                dataGridViewCrudeFinancialBookingTransaction.AutoResizeColumns();
                dataGridViewCrudeFinancialBookingTransaction.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialBookingTransaction.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFinancialBookingTransaction() {
            try {
                dataGridViewCrudeFinancialBookingTransaction.Columns.Clear();
                dataGridViewCrudeFinancialBookingTransaction.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialBookingTransactionTypeRcd","Financial Booking Transaction Type");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialBookingTransactionTypeRcd"].DataPropertyName = "FinancialBookingTransactionTypeRcd";
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("TransactionNumber","Transaction Number");
                dataGridViewCrudeFinancialBookingTransaction.Columns["TransactionNumber"].DataPropertyName = "TransactionNumber";
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialBookingTransaction.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialBookingTransaction.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialBookingTransactionId","Financial Booking Transaction");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialBookingTransactionId"].DataPropertyName = "FinancialBookingTransactionId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialBookingTransactionId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("BookingId","Booking");
                dataGridViewCrudeFinancialBookingTransaction.Columns["BookingId"].DataPropertyName = "BookingId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["BookingId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialFeeId","Financial Fee");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialFeeId"].DataPropertyName = "FinancialFeeId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialFeeId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialTaxId","Financial Tax");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialTaxId"].DataPropertyName = "FinancialTaxId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialTaxId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialFareId","Financial Fare");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialFareId"].DataPropertyName = "FinancialFareId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialFareId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialPaymentId","Financial Payment");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialPaymentId"].DataPropertyName = "FinancialPaymentId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialPaymentId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialCostcentreId","Financial Costcentre");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialCostcentreId"].DataPropertyName = "FinancialCostcentreId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialCostcentreId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialAdjustmentId","Financial Adjustment");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialAdjustmentId"].DataPropertyName = "FinancialAdjustmentId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialAdjustmentId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("FinancialServiceId","Financial Service");
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialServiceId"].DataPropertyName = "FinancialServiceId";
                dataGridViewCrudeFinancialBookingTransaction.Columns["FinancialServiceId"].Visible = false;
                dataGridViewCrudeFinancialBookingTransaction.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialBookingTransaction.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialBookingTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialBookingTransaction.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
