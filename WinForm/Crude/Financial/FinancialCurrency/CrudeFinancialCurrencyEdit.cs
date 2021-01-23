﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 4:49:37 PM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeFinancialCurrencyEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeFinancialCurrencyContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeFinancialCurrencyEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialCurrencyContract();
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
                _contract = new CrudeFinancialCurrencyContract();
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
        public void ShowAsAddByFinancialCurrencyType(string financialCurrencyTypeRcd) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;

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
        public void ShowAsAddByFinancialCurrencyTypeAndFinancialCurrencyAgainstFinancialCurrencyType(string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRcd;
                financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd : String.Empty;

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
        public void ShowAsAdd(string financialCurrencyTypeRcd, string financialCurrencyTypeCode, string financialCurrencyTypeName, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, System.Guid userId) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;
                _contract.FinancialCurrencyTypeCode = financialCurrencyTypeCode;
                textBoxFinancialCurrencyTypeCode.Text = _contract.FinancialCurrencyTypeCode;
                _contract.FinancialCurrencyTypeName = financialCurrencyTypeName;
                textBoxFinancialCurrencyTypeName.Text = _contract.FinancialCurrencyTypeName;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRcd;
                financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd : String.Empty;
                _contract.ValidFromDateTime = validFromDateTime;
                dateTimePickerValidFromDateTime.Value = _contract.ValidFromDateTime != DateTime.MinValue ? _contract.ValidFromDateTime : dateTimePickerValidFromDateTime.MinDate;
                dateTimePickerValidFromDateTime.Checked = _contract.ValidFromDateTime != DateTime.MinValue;
                _contract.ValidUntilDateTime = validUntilDateTime;
                dateTimePickerValidUntilDateTime.Value = _contract.ValidUntilDateTime != DateTime.MinValue ? _contract.ValidUntilDateTime : dateTimePickerValidUntilDateTime.MinDate;
                dateTimePickerValidUntilDateTime.Checked = _contract.ValidUntilDateTime != DateTime.MinValue;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.EqualsAmount = equalsAmount;
                maskedTextBoxEqualsAmount.Text = _contract.EqualsAmount.ToString();
                _contract.DecimalCount = decimalCount;
                maskedTextBoxDecimalCount.Text = _contract.DecimalCount.ToString();
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
        public void ShowAsEdit(System.Guid financialCurrencyId) {
            var service = new CrudeFinancialCurrencyServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCurrencyId(financialCurrencyId);
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;
                textBoxFinancialCurrencyTypeCode.Text = _contract.FinancialCurrencyTypeCode;
                textBoxFinancialCurrencyTypeName.Text = _contract.FinancialCurrencyTypeName;
                financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd : String.Empty;
                dateTimePickerValidFromDateTime.Value = _contract.ValidFromDateTime != DateTime.MinValue ? _contract.ValidFromDateTime : dateTimePickerValidFromDateTime.MinDate;
                dateTimePickerValidFromDateTime.Checked = _contract.ValidFromDateTime != DateTime.MinValue;
                dateTimePickerValidUntilDateTime.Value = _contract.ValidUntilDateTime != DateTime.MinValue ? _contract.ValidUntilDateTime : dateTimePickerValidUntilDateTime.MinDate;
                dateTimePickerValidUntilDateTime.Checked = _contract.ValidUntilDateTime != DateTime.MinValue;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                maskedTextBoxEqualsAmount.Text = _contract.EqualsAmount.ToString();
                maskedTextBoxDecimalCount.Text = _contract.DecimalCount.ToString();
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
            var service = new CrudeFinancialCurrencyServiceClient();
            try {
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRefCombo.Text;
                _contract.FinancialCurrencyTypeCode = textBoxFinancialCurrencyTypeCode.Text;
                _contract.FinancialCurrencyTypeName = textBoxFinancialCurrencyTypeName.Text;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text;
                _contract.ValidFromDateTime = dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue;
                _contract.ValidUntilDateTime = dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue;
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.EqualsAmount = maskedTextBoxEqualsAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxEqualsAmount.Text);
                _contract.DecimalCount = maskedTextBoxDecimalCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDecimalCount.Text);
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
