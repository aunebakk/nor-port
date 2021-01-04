/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 1:20:27 PM
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
    public partial class CrudeServiceSpecialServiceRequestSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _serviceSpecialServiceRequestGroupRcd;
        
        private string _requestServiceSpecialServiceRequestRequirementRcd;
        
        private string _replyServiceSpecialServiceRequestRequirementRcd;
        
        private string _serviceSpecialServiceRequestOperationRuleRcd;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeServiceSpecialServiceRequestSearch() {
            InitializeComponent();
            InitializeGridCrudeServiceSpecialServiceRequest();
            this.AcceptButton = buttonCrudeServiceSpecialServiceRequestSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string serviceSpecialServiceRequestGroupRcd, string requestServiceSpecialServiceRequestRequirementRcd, string replyServiceSpecialServiceRequestRequirementRcd, string serviceSpecialServiceRequestOperationRuleRcd, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _serviceSpecialServiceRequestGroupRcd = serviceSpecialServiceRequestGroupRcd;
                _requestServiceSpecialServiceRequestRequirementRcd = requestServiceSpecialServiceRequestRequirementRcd;
                _replyServiceSpecialServiceRequestRequirementRcd = replyServiceSpecialServiceRequestRequirementRcd;
                _serviceSpecialServiceRequestOperationRuleRcd = serviceSpecialServiceRequestOperationRuleRcd;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeServiceSpecialServiceRequest();

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
        private void buttonCrudeServiceSpecialServiceRequestEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeServiceSpecialServiceRequestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeServiceSpecialServiceRequest.CurrentRow.Cells["ServiceSpecialServiceRequestId"].Value);
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
        private void buttonCrudeServiceSpecialServiceRequestAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeServiceSpecialServiceRequestEdit();
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
        private void dataGridViewCrudeServiceSpecialServiceRequest_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeServiceSpecialServiceRequestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeServiceSpecialServiceRequest.CurrentRow.Cells["ServiceSpecialServiceRequestId"].Value);
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
        private void buttonCrudeServiceSpecialServiceRequestSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeServiceSpecialServiceRequest();
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
        public void RefreshCrudeServiceSpecialServiceRequest() {
            var serviceSpecialServiceRequest = new CrudeServiceSpecialServiceRequestServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = serviceSpecialServiceRequest.FetchWithFilter(
                             Guid.Empty
                            ,serviceSpecialServiceRequestGroupRefCombo.Text
                            ,textBoxServiceSpecialServiceRequestCode.Text
                            ,textBoxServiceSpecialServiceRequestName.Text
                            ,textBoxServiceDescription.Text
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,financialCurrencyPicker.SelectedValue
                            ,Convert.ToBoolean(checkBoxInventoryControlledFlag.Checked)
                            ,requestServiceSpecialServiceRequestRequirementRefCombo.Text
                            ,replyServiceSpecialServiceRequestRequirementRefCombo.Text
                            ,serviceSpecialServiceRequestOperationRuleRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeServiceSpecialServiceRequest.AutoGenerateColumns = false;
                dataGridViewCrudeServiceSpecialServiceRequest.DataSource = bindingSource;
                dataGridViewCrudeServiceSpecialServiceRequest.AutoResizeColumns();
                dataGridViewCrudeServiceSpecialServiceRequest.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                serviceSpecialServiceRequest.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeServiceSpecialServiceRequest() {
            try {
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Clear();
                dataGridViewCrudeServiceSpecialServiceRequest.AutoGenerateColumns = false;
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ServiceSpecialServiceRequestName","Service Special Service Request Name");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceSpecialServiceRequestName"].DataPropertyName = "ServiceSpecialServiceRequestName";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ServiceSpecialServiceRequestGroupRcd","Service Special Service Request Group");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceSpecialServiceRequestGroupRcd"].DataPropertyName = "ServiceSpecialServiceRequestGroupRcd";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ServiceSpecialServiceRequestCode","Service Special Service Request Code");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceSpecialServiceRequestCode"].DataPropertyName = "ServiceSpecialServiceRequestCode";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ServiceDescription","Service Description");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceDescription"].DataPropertyName = "ServiceDescription";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("RequestServiceSpecialServiceRequestRequirementRcd","Request Service Special Service Request Requirement");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["RequestServiceSpecialServiceRequestRequirementRcd"].DataPropertyName = "RequestServiceSpecialServiceRequestRequirementRcd";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ReplyServiceSpecialServiceRequestRequirementRcd","Reply Service Special Service Request Requirement");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ReplyServiceSpecialServiceRequestRequirementRcd"].DataPropertyName = "ReplyServiceSpecialServiceRequestRequirementRcd";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ServiceSpecialServiceRequestOperationRuleRcd","Service Special Service Request Operation Rule");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceSpecialServiceRequestOperationRuleRcd"].DataPropertyName = "ServiceSpecialServiceRequestOperationRuleRcd";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("Amount","Amount");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ServiceSpecialServiceRequestId","Service Special Service Request");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceSpecialServiceRequestId"].DataPropertyName = "ServiceSpecialServiceRequestId";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ServiceSpecialServiceRequestId"].Visible = false;
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("InventoryControlledFlag","Inventory Controlled Flag");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["InventoryControlledFlag"].DataPropertyName = "InventoryControlledFlag";
                dataGridViewCrudeServiceSpecialServiceRequest.Columns.Add("ExtensionData", "");
                dataGridViewCrudeServiceSpecialServiceRequest.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeServiceSpecialServiceRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeServiceSpecialServiceRequest.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
