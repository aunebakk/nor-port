/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 8:33:42 PM
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
    public partial class CrudeFinancialCouponSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _financialCouponTypeRcd;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFinancialCouponSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCoupon();
            this.AcceptButton = buttonCrudeFinancialCouponSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string financialCouponTypeRcd, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _financialCouponTypeRcd = financialCouponTypeRcd;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFinancialCoupon();

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
        private void buttonCrudeFinancialCouponEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCoupon.CurrentRow.Cells["FinancialCouponId"].Value);
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
        private void buttonCrudeFinancialCouponAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponEdit();
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
        private void dataGridViewCrudeFinancialCoupon_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCoupon.CurrentRow.Cells["FinancialCouponId"].Value);
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
        private void buttonCrudeFinancialCouponSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCoupon();
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
        public void RefreshCrudeFinancialCoupon() {
            var financialCoupon = new CrudeFinancialCouponServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCoupon.FetchWithFilter(
                             Guid.Empty
                            ,financialCouponTypeRefCombo.Text
                            ,maskedTextBoxCouponNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCouponNumber.Text)
                            ,maskedTextBoxValueAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxValueAmount.Text)
                            ,financialCurrencyPicker.SelectedValue
                            ,dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue
                            ,dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue
                            ,textBoxCouponDescription.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialCoupon.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCoupon.DataSource = bindingSource;
                dataGridViewCrudeFinancialCoupon.AutoResizeColumns();
                dataGridViewCrudeFinancialCoupon.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCoupon.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFinancialCoupon() {
            try {
                dataGridViewCrudeFinancialCoupon.Columns.Clear();
                dataGridViewCrudeFinancialCoupon.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCoupon.Columns.Add("FinancialCouponTypeRcd","Financial Coupon Type");
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCouponTypeRcd"].DataPropertyName = "FinancialCouponTypeRcd";
                dataGridViewCrudeFinancialCoupon.Columns.Add("CouponDescription","Coupon Description");
                dataGridViewCrudeFinancialCoupon.Columns["CouponDescription"].DataPropertyName = "CouponDescription";
                dataGridViewCrudeFinancialCoupon.Columns.Add("CouponNumber","Coupon Number");
                dataGridViewCrudeFinancialCoupon.Columns["CouponNumber"].DataPropertyName = "CouponNumber";
                dataGridViewCrudeFinancialCoupon.Columns.Add("ValueAmount","Value Amount");
                dataGridViewCrudeFinancialCoupon.Columns["ValueAmount"].DataPropertyName = "ValueAmount";
                dataGridViewCrudeFinancialCoupon.Columns.Add("ValidFromDateTime","Valid From Date Time");
                dataGridViewCrudeFinancialCoupon.Columns["ValidFromDateTime"].DataPropertyName = "ValidFromDateTime";
                dataGridViewCrudeFinancialCoupon.Columns.Add("ValidUntilDateTime","Valid Until Date Time");
                dataGridViewCrudeFinancialCoupon.Columns["ValidUntilDateTime"].DataPropertyName = "ValidUntilDateTime";
                dataGridViewCrudeFinancialCoupon.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCoupon.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCoupon.Columns.Add("FinancialCouponId","Financial Coupon");
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCouponId"].DataPropertyName = "FinancialCouponId";
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCouponId"].Visible = false;
                dataGridViewCrudeFinancialCoupon.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialCoupon.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCoupon.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCoupon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCoupon.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
