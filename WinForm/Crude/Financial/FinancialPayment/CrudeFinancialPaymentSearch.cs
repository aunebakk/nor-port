/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:14:22 AM
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
    public partial class CrudeFinancialPaymentSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _financialPaymentTypeRcd;
        
        private System.Guid _financialPaymentCardId;
        
        private System.Guid _financialPaymentCashId;
        
        private System.Guid _financialPaymentVoucherId;
        
        private System.Guid _financialPaymentCouponId;
        
        private System.Guid _financialPaymentBankId;
        
        private System.Guid _financialPaymentAccountingId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFinancialPaymentSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPayment();
            this.AcceptButton = buttonCrudeFinancialPaymentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string financialPaymentTypeRcd, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCouponId, System.Guid financialPaymentBankId, System.Guid financialPaymentAccountingId, System.Guid userId) {
            try {
                _financialPaymentTypeRcd = financialPaymentTypeRcd;
                _financialPaymentCardId = financialPaymentCardId;
                _financialPaymentCashId = financialPaymentCashId;
                _financialPaymentVoucherId = financialPaymentVoucherId;
                _financialPaymentCouponId = financialPaymentCouponId;
                _financialPaymentBankId = financialPaymentBankId;
                _financialPaymentAccountingId = financialPaymentAccountingId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFinancialPayment();

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
        private void buttonCrudeFinancialPaymentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPayment.CurrentRow.Cells["FinancialPaymentId"].Value);
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
        private void buttonCrudeFinancialPaymentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentEdit();
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
        private void dataGridViewCrudeFinancialPayment_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPayment.CurrentRow.Cells["FinancialPaymentId"].Value);
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
        private void buttonCrudeFinancialPaymentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPayment();
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
        public void RefreshCrudeFinancialPayment() {
            var financialPayment = new CrudeFinancialPaymentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPayment.FetchWithFilter(
                             Guid.Empty
                            ,financialPaymentTypeRefCombo.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialPayment.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPayment.DataSource = bindingSource;
                dataGridViewCrudeFinancialPayment.AutoResizeColumns();
                dataGridViewCrudeFinancialPayment.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPayment.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFinancialPayment() {
            try {
                dataGridViewCrudeFinancialPayment.Columns.Clear();
                dataGridViewCrudeFinancialPayment.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentTypeRcd","Financial Payment Type");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentTypeRcd"].DataPropertyName = "FinancialPaymentTypeRcd";
                dataGridViewCrudeFinancialPayment.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPayment.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentId","Financial Payment");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentId"].DataPropertyName = "FinancialPaymentId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentCardId","Financial Payment Card");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCardId"].DataPropertyName = "FinancialPaymentCardId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCardId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentCashId","Financial Payment Cash");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCashId"].DataPropertyName = "FinancialPaymentCashId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCashId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentVoucherId","Financial Payment Voucher");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentVoucherId"].DataPropertyName = "FinancialPaymentVoucherId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentVoucherId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentCouponId","Financial Payment Coupon");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCouponId"].DataPropertyName = "FinancialPaymentCouponId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCouponId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentBankId","Financial Payment Bank");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentBankId"].DataPropertyName = "FinancialPaymentBankId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentBankId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentAccountingId","Financial Payment Accounting");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentAccountingId"].DataPropertyName = "FinancialPaymentAccountingId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentAccountingId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPayment.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPayment.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
