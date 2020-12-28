/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:04:20 AM
  From Machine: DESKTOP-BP3OHLH
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
    public partial class CrudeFinancialBookingTransactionEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeFinancialBookingTransactionContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeFinancialBookingTransactionEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                this.Text += " - Not Savable (Booking Missing)";
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
                _contract = new CrudeFinancialBookingTransactionContract();
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
        public void ShowAsAddByFinancialBookingTransactionType(string financialBookingTransactionTypeRcd) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialBookingTransactionTypeRcd = financialBookingTransactionTypeRcd;
                financialBookingTransactionTypeRefCombo.Text = _contract.FinancialBookingTransactionTypeRcd != null ? _contract.FinancialBookingTransactionTypeRcd : String.Empty;

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
        public void ShowAsAddByBooking(System.Guid bookingId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.BookingId = bookingId;

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
        public void ShowAsAddByFinancialFee(System.Guid financialFeeId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialFeeId = financialFeeId;

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
        public void ShowAsAddByFinancialTax(System.Guid financialTaxId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialTaxId = financialTaxId;

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
        public void ShowAsAddByFinancialFare(System.Guid financialFareId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialFareId = financialFareId;

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
        public void ShowAsAddByFinancialPayment(System.Guid financialPaymentId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentId = financialPaymentId;

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
                _contract = new CrudeFinancialBookingTransactionContract();
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
        public void ShowAsAddByFinancialCostcentre(System.Guid financialCostcentreId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCostcentreId = financialCostcentreId;
                financialCostcentrePicker.SelectedValue = _contract.FinancialCostcentreId;

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
        public void ShowAsAddByFinancialAdjustment(System.Guid financialAdjustmentId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialAdjustmentId = financialAdjustmentId;

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
        public void ShowAsAddByFinancialService(System.Guid financialServiceId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialServiceId = financialServiceId;

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
        public void ShowAsAdd(System.Guid bookingId, int transactionNumber, string financialBookingTransactionTypeRcd, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialFareId, System.Guid financialPaymentId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, System.Guid financialServiceId, System.Guid userId) {
            try {
                _contract = new CrudeFinancialBookingTransactionContract();
                _isNew = true;
                _contract.BookingId = bookingId;
                _contract.TransactionNumber = transactionNumber;
                maskedTextBoxTransactionNumber.Text = _contract.TransactionNumber.ToString();
                _contract.FinancialBookingTransactionTypeRcd = financialBookingTransactionTypeRcd;
                financialBookingTransactionTypeRefCombo.Text = _contract.FinancialBookingTransactionTypeRcd != null ? _contract.FinancialBookingTransactionTypeRcd : String.Empty;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.FinancialFeeId = financialFeeId;
                _contract.FinancialTaxId = financialTaxId;
                _contract.FinancialFareId = financialFareId;
                _contract.FinancialPaymentId = financialPaymentId;
                _contract.FinancialCurrencyId = financialCurrencyId;
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;
                _contract.FinancialCostcentreId = financialCostcentreId;
                financialCostcentrePicker.SelectedValue = _contract.FinancialCostcentreId;
                _contract.FinancialAdjustmentId = financialAdjustmentId;
                _contract.FinancialServiceId = financialServiceId;
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
        public void ShowAsEdit(System.Guid financialBookingTransactionId) {
            var service = new CrudeFinancialBookingTransactionServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
                maskedTextBoxTransactionNumber.Text = _contract.TransactionNumber.ToString();
                financialBookingTransactionTypeRefCombo.Text = _contract.FinancialBookingTransactionTypeRcd != null ? _contract.FinancialBookingTransactionTypeRcd : String.Empty;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                financialCurrencyPicker.SelectedValue = _contract.FinancialCurrencyId;
                financialCostcentrePicker.SelectedValue = _contract.FinancialCostcentreId;
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
            var service = new CrudeFinancialBookingTransactionServiceClient();
            try {
                _contract.TransactionNumber = maskedTextBoxTransactionNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxTransactionNumber.Text);
                _contract.FinancialBookingTransactionTypeRcd = financialBookingTransactionTypeRefCombo.Text;
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.FinancialCurrencyId = (Guid)financialCurrencyPicker.SelectedValue;
                _contract.FinancialCostcentreId = (Guid)financialCostcentrePicker.SelectedValue;
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
