/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 4:30:21 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/cd82fac1-15df-4881-b376-80b77ab185d0
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/43b6be6f-d1b6-4470-937c-dbf4588a80ee
    public partial class CrudeServiceSpecialServiceRequestEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeServiceSpecialServiceRequestContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeServiceSpecialServiceRequestEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/599dcb45-f71b-4672-bb18-46975a4fe9b3
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.UserId = userId;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByFinancialCurrency(System.Guid financialCurrencyId) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByServiceSpecialServiceRequestGroup(string serviceSpecialServiceRequestGroupRcd) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceSpecialServiceRequestGroupRcd = serviceSpecialServiceRequestGroupRcd;
                serviceSpecialServiceRequestGroupRefCombo.Text = _contract.ServiceSpecialServiceRequestGroupRcd != null ? _contract.ServiceSpecialServiceRequestGroupRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByRequestServiceSpecialServiceRequestRequirement(string requestServiceSpecialServiceRequestRequirementRcd) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.RequestServiceSpecialServiceRequestRequirementRcd = requestServiceSpecialServiceRequestRequirementRcd;
                requestServiceSpecialServiceRequestRequirementRefCombo.Text = _contract.RequestServiceSpecialServiceRequestRequirementRcd != null ? _contract.RequestServiceSpecialServiceRequestRequirementRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByReplyServiceSpecialServiceRequestRequirement(string replyServiceSpecialServiceRequestRequirementRcd) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ReplyServiceSpecialServiceRequestRequirementRcd = replyServiceSpecialServiceRequestRequirementRcd;
                replyServiceSpecialServiceRequestRequirementRefCombo.Text = _contract.ReplyServiceSpecialServiceRequestRequirementRcd != null ? _contract.ReplyServiceSpecialServiceRequestRequirementRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByServiceSpecialServiceRequestOperationRule(string serviceSpecialServiceRequestOperationRuleRcd) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ServiceSpecialServiceRequestOperationRuleRcd = serviceSpecialServiceRequestOperationRuleRcd;
                serviceSpecialServiceRequestOperationRuleRefCombo.Text = _contract.ServiceSpecialServiceRequestOperationRuleRcd != null ? _contract.ServiceSpecialServiceRequestOperationRuleRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(string serviceSpecialServiceRequestGroupRcd, string serviceSpecialServiceRequestCode, string serviceSpecialServiceRequestName, string serviceDescription, decimal amount, System.Guid financialCurrencyId, bool inventoryControlledFlag, string requestServiceSpecialServiceRequestRequirementRcd, string replyServiceSpecialServiceRequestRequirementRcd, string serviceSpecialServiceRequestOperationRuleRcd, System.Guid userId) {
            try {
                _contract = new CrudeServiceSpecialServiceRequestContract();
                _isNew = true;
                _contract.ServiceSpecialServiceRequestGroupRcd = serviceSpecialServiceRequestGroupRcd;
                serviceSpecialServiceRequestGroupRefCombo.Text = _contract.ServiceSpecialServiceRequestGroupRcd != null ? _contract.ServiceSpecialServiceRequestGroupRcd : String.Empty;
                _contract.ServiceSpecialServiceRequestCode = serviceSpecialServiceRequestCode;
                textBoxServiceSpecialServiceRequestCode.Text = _contract.ServiceSpecialServiceRequestCode;
                _contract.ServiceSpecialServiceRequestName = serviceSpecialServiceRequestName;
                textBoxServiceSpecialServiceRequestName.Text = _contract.ServiceSpecialServiceRequestName;
                _contract.ServiceDescription = serviceDescription;
                textBoxServiceDescription.Text = _contract.ServiceDescription;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;
                _contract.InventoryControlledFlag = inventoryControlledFlag;
                checkBoxInventoryControlledFlag.Checked = _contract.InventoryControlledFlag;
                _contract.RequestServiceSpecialServiceRequestRequirementRcd = requestServiceSpecialServiceRequestRequirementRcd;
                requestServiceSpecialServiceRequestRequirementRefCombo.Text = _contract.RequestServiceSpecialServiceRequestRequirementRcd != null ? _contract.RequestServiceSpecialServiceRequestRequirementRcd : String.Empty;
                _contract.ReplyServiceSpecialServiceRequestRequirementRcd = replyServiceSpecialServiceRequestRequirementRcd;
                replyServiceSpecialServiceRequestRequirementRefCombo.Text = _contract.ReplyServiceSpecialServiceRequestRequirementRcd != null ? _contract.ReplyServiceSpecialServiceRequestRequirementRcd : String.Empty;
                _contract.ServiceSpecialServiceRequestOperationRuleRcd = serviceSpecialServiceRequestOperationRuleRcd;
                serviceSpecialServiceRequestOperationRuleRefCombo.Text = _contract.ServiceSpecialServiceRequestOperationRuleRcd != null ? _contract.ServiceSpecialServiceRequestOperationRuleRcd : String.Empty;
                _contract.UserId = userId;
                userPicker.SelectedValue = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/49afd26c-4f21-4992-967b-be190eacef77
        public void ShowAsEdit(System.Guid serviceSpecialServiceRequestId) {
            var service = new CrudeServiceSpecialServiceRequestServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByServiceSpecialServiceRequestId(serviceSpecialServiceRequestId);
                serviceSpecialServiceRequestGroupRefCombo.Text = _contract.ServiceSpecialServiceRequestGroupRcd != null ? _contract.ServiceSpecialServiceRequestGroupRcd : String.Empty;
                textBoxServiceSpecialServiceRequestCode.Text = _contract.ServiceSpecialServiceRequestCode;
                textBoxServiceSpecialServiceRequestName.Text = _contract.ServiceSpecialServiceRequestName;
                textBoxServiceDescription.Text = _contract.ServiceDescription;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;
                checkBoxInventoryControlledFlag.Checked = _contract.InventoryControlledFlag;
                requestServiceSpecialServiceRequestRequirementRefCombo.Text = _contract.RequestServiceSpecialServiceRequestRequirementRcd != null ? _contract.RequestServiceSpecialServiceRequestRequirementRcd : String.Empty;
                replyServiceSpecialServiceRequestRequirementRefCombo.Text = _contract.ReplyServiceSpecialServiceRequestRequirementRcd != null ? _contract.ReplyServiceSpecialServiceRequestRequirementRcd : String.Empty;
                serviceSpecialServiceRequestOperationRuleRefCombo.Text = _contract.ServiceSpecialServiceRequestOperationRuleRcd != null ? _contract.ServiceSpecialServiceRequestOperationRuleRcd : String.Empty;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        // saves the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/c9522930-91f8-4468-a936-8030bb2a6482
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeServiceSpecialServiceRequestServiceClient();
            try {
                _contract.ServiceSpecialServiceRequestGroupRcd = serviceSpecialServiceRequestGroupRefCombo.Text;
                _contract.ServiceSpecialServiceRequestCode = textBoxServiceSpecialServiceRequestCode.Text;
                _contract.ServiceSpecialServiceRequestName = textBoxServiceSpecialServiceRequestName.Text;
                _contract.ServiceDescription = textBoxServiceDescription.Text;
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.FinancialCurrencyId = (Guid)financialCurrencyPicker.SelectedValue;
                _contract.InventoryControlledFlag = Convert.ToBoolean(checkBoxInventoryControlledFlag.Checked);
                _contract.RequestServiceSpecialServiceRequestRequirementRcd = requestServiceSpecialServiceRequestRequirementRefCombo.Text;
                _contract.ReplyServiceSpecialServiceRequestRequirementRcd = replyServiceSpecialServiceRequestRequirementRefCombo.Text;
                _contract.ServiceSpecialServiceRequestOperationRuleRcd = serviceSpecialServiceRequestOperationRuleRefCombo.Text;
                _contract.UserId = (Guid)userPicker.SelectedValue;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/876f1492-f546-42ac-aae3-11837d1d842a
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
