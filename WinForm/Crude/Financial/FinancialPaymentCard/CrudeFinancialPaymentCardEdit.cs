/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:15:13 PM
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
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/cd82fac1-15df-4881-b376-80b77ab185d0
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/43b6be6f-d1b6-4470-937c-dbf4588a80ee
    public partial class CrudeFinancialPaymentCardEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeFinancialPaymentCardContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeFinancialPaymentCardEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialPaymentCardContract();
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
                _contract = new CrudeFinancialPaymentCardContract();
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
        public void ShowAsAddByFinancialCardType(string financialCardTypeRcd) {
            try {
                _contract = new CrudeFinancialPaymentCardContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCardTypeRcd = financialCardTypeRcd;
                financialCardTypeRefCombo.Text = _contract.FinancialCardTypeRcd != null ? _contract.FinancialCardTypeRcd : String.Empty;

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
                _contract = new CrudeFinancialPaymentCardContract();
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
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(string financialCardTypeRcd, string nameOnCard, string cardNumber, int cardVerificationValue, string addressVerificationCode, int issuedYear, int issuedMonth, int expiryYear, int expiryMonth, decimal amount, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _contract = new CrudeFinancialPaymentCardContract();
                _isNew = true;
                _contract.FinancialCardTypeRcd = financialCardTypeRcd;
                financialCardTypeRefCombo.Text = _contract.FinancialCardTypeRcd != null ? _contract.FinancialCardTypeRcd : String.Empty;
                _contract.NameOnCard = nameOnCard;
                textBoxNameOnCard.Text = _contract.NameOnCard;
                _contract.CardNumber = cardNumber;
                textBoxCardNumber.Text = _contract.CardNumber;
                _contract.CardVerificationValue = cardVerificationValue;
                maskedTextBoxCardVerificationValue.Text = _contract.CardVerificationValue.ToString();
                _contract.AddressVerificationCode = addressVerificationCode;
                textBoxAddressVerificationCode.Text = _contract.AddressVerificationCode;
                _contract.IssuedYear = issuedYear;
                maskedTextBoxIssuedYear.Text = _contract.IssuedYear.ToString();
                _contract.IssuedMonth = issuedMonth;
                maskedTextBoxIssuedMonth.Text = _contract.IssuedMonth.ToString();
                _contract.ExpiryYear = expiryYear;
                maskedTextBoxExpiryYear.Text = _contract.ExpiryYear.ToString();
                _contract.ExpiryMonth = expiryMonth;
                maskedTextBoxExpiryMonth.Text = _contract.ExpiryMonth.ToString();
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;
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
        public void ShowAsEdit(System.Guid financialPaymentCardId) {
            var service = new CrudeFinancialPaymentCardServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialPaymentCardId(financialPaymentCardId);
                financialCardTypeRefCombo.Text = _contract.FinancialCardTypeRcd != null ? _contract.FinancialCardTypeRcd : String.Empty;
                textBoxNameOnCard.Text = _contract.NameOnCard;
                textBoxCardNumber.Text = _contract.CardNumber;
                maskedTextBoxCardVerificationValue.Text = _contract.CardVerificationValue.ToString();
                textBoxAddressVerificationCode.Text = _contract.AddressVerificationCode;
                maskedTextBoxIssuedYear.Text = _contract.IssuedYear.ToString();
                maskedTextBoxIssuedMonth.Text = _contract.IssuedMonth.ToString();
                maskedTextBoxExpiryYear.Text = _contract.ExpiryYear.ToString();
                maskedTextBoxExpiryMonth.Text = _contract.ExpiryMonth.ToString();
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;
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
            var service = new CrudeFinancialPaymentCardServiceClient();
            try {
                _contract.FinancialCardTypeRcd = financialCardTypeRefCombo.Text;
                _contract.NameOnCard = textBoxNameOnCard.Text;
                _contract.CardNumber = textBoxCardNumber.Text;
                _contract.CardVerificationValue = maskedTextBoxCardVerificationValue.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCardVerificationValue.Text);
                _contract.AddressVerificationCode = textBoxAddressVerificationCode.Text;
                _contract.IssuedYear = maskedTextBoxIssuedYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedYear.Text);
                _contract.IssuedMonth = maskedTextBoxIssuedMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedMonth.Text);
                _contract.ExpiryYear = maskedTextBoxExpiryYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryYear.Text);
                _contract.ExpiryMonth = maskedTextBoxExpiryMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryMonth.Text);
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.FinancialCurrencyId = (Guid)financialCurrencyPicker.SelectedValue;
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
