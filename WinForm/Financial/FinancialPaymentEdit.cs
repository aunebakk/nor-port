using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class FinancialPaymentEdit : Form
    {
        CrudeFinancialPaymentContract _financialPaymentContract;
        Guid _bookingId;
        Guid _financialCostcentreId;
        Guid _financialCurrencyId;
        Boolean _isNew;
        decimal _paymentAmount = 0;
        decimal _balanceAmount = 0;
        decimal _paymentAmountInBookingCurrency = 0;
        decimal _roundingAmountInBookingCurrency = 0;

        public FinancialPaymentEdit() {
            InitializeComponent();
            InitializeGridVoucherSearchWithRemainingAmount();
            this.CancelButton = buttonClose;
        }

        public void ShowAsAdd(
            Guid bookingId,
            Guid financialCurrencyId,
            Guid financialCostcentreId,
            Guid userId
            ) {

            _financialPaymentContract = new CrudeFinancialPaymentContract();
            _isNew = true;
            _bookingId = bookingId;
            _financialCostcentreId = financialCostcentreId;
            _financialCurrencyId = financialCurrencyId;
            _financialPaymentContract.UserId = userId;
            _financialPaymentContract.DateTime = DateTime.UtcNow;

            financialCurrencyPickerBookingBalance.SelectedValue = financialCurrencyId;
            financialCurrencyPickerPayment.SelectedValue = financialCurrencyId;
            financialCurrencyPickerBookingCurrency.SelectedValue = financialCurrencyId;

            // amount
            CrudeFinancialCurrencyContract currency = 
                new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(
                    financialCurrencyPickerPayment.SelectedValue
                    );

            _balanceAmount = new BookingServiceClient().BookingFinancialBalance(bookingId);
            maskedTextBoxBalance.Text = _balanceAmount.ToString("F4");
            maskedTextBoxPaymentAmount.Text = _balanceAmount.ToString("F" + currency.DecimalCount.ToString());
            maskedTextBoxPaymentAmount.Focus();

            _roundingAmountInBookingCurrency = _balanceAmount - Math.Round(_balanceAmount, currency.DecimalCount);
            maskedTextBoxRoundingAmount.Text = _roundingAmountInBookingCurrency.ToString();

            CashCalc();

            Show();
        }

        public void FetchBankDetails(
            System.Guid financialPaymentBankId
            ) {

            var service = new CrudeFinancialPaymentBankServiceClient();
            try {
                CrudeFinancialPaymentBankContract contract = service.FetchByFinancialPaymentBankId(financialPaymentBankId);
                _financialCurrencyId = contract.FinancialCurrencyId;

                maskedTextBoxPaymentAmount.Text = contract.Amount.ToString();
                financialCurrencyPickerPayment.SelectedValue = contract.FinancialCurrencyId;

                financialBankAccountNumberTypeRefCombo.Text = contract.FinancialBankAccountNumberTypeRcd != null ? contract.FinancialBankAccountNumberTypeRcd : String.Empty;
                textBoxBankName.Text = contract.BankName;
                textBoxBankAccount.Text = contract.BankAccount;
                textBoxBankNumber.Text = contract.BankNumber;

                Show();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }
        }

        void FetchCashDetails(
            System.Guid financialPaymentCashId
            ) {
            var service = new CrudeFinancialPaymentCashServiceClient();
            try {
                CrudeFinancialPaymentCashContract contract = service.FetchByFinancialPaymentCashId(financialPaymentCashId);
                _financialCurrencyId = contract.FinancialCurrencyId;

                maskedTextBoxPaymentAmount.Text = contract.Amount.ToString();
                financialCurrencyPickerPayment.SelectedValue = contract.FinancialCurrencyId;

            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }
        }

        void FetchCardDetails(
            System.Guid financialPaymentCardId
            ) {

            var service = new CrudeFinancialPaymentCardServiceClient();
            try {
                CrudeFinancialPaymentCardContract contract = service.FetchByFinancialPaymentCardId(financialPaymentCardId);
                _financialCurrencyId = contract.FinancialCurrencyId;

                maskedTextBoxPaymentAmount.Text = contract.Amount.ToString();
                financialCurrencyPickerPayment.SelectedValue = contract.FinancialCurrencyId;

                financialCardTypeRefCombo.Text = contract.FinancialCardTypeRcd != null ? contract.FinancialCardTypeRcd : String.Empty;
                textBoxNameOnCard.Text = contract.NameOnCard;
                textBoxCardNumber.Text = contract.CardNumber;
                maskedTextBoxCardVerificationValue.Text = contract.CardVerificationValue.ToString();
                textBoxAddressVerificationCode.Text = contract.AddressVerificationCode;
                maskedTextBoxIssuedYear.Text = contract.IssuedYear.ToString();
                maskedTextBoxIssuedMonth.Text = contract.IssuedMonth.ToString();
                maskedTextBoxExpiryYear.Text = contract.ExpiryYear.ToString();
                maskedTextBoxExpiryMonth.Text = contract.ExpiryMonth.ToString();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }
        }

        public void ShowAsEdit(
            System.Guid financialPaymentId
            ) {

            var service = new CrudeFinancialPaymentServiceClient();
            _isNew = true;  // to enable page switch

            try {
                _financialPaymentContract = service.FetchByFinancialPaymentId(financialPaymentId);

                // choose tab
                if ( _financialPaymentContract.FinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Card) ) {
                    FetchCardDetails(_financialPaymentContract.FinancialPaymentCardId);
                    tabControl.SelectedTab = tabPageCard;

                } else if ( _financialPaymentContract.FinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Cash) ) {
                    FetchCashDetails(_financialPaymentContract.FinancialPaymentCashId);
                    tabControl.SelectedTab = tabPageCash;

                } else if ( _financialPaymentContract.FinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Voucher) ) {
                    tabControl.SelectedTab = tabPageVoucher;

                } else if ( _financialPaymentContract.FinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Bank) ) {
                    FetchBankDetails(_financialPaymentContract.FinancialPaymentBankId);
                    tabControl.SelectedTab = tabPageBank;

                } else if ( _financialPaymentContract.FinancialPaymentTypeRcd.Contains(FinancialPaymentTypeRef.Accounting) ) {
                    tabControl.SelectedTab = tabPageAccounting;
                }

                buttonPaymentAdd.Enabled = false;

                CashCalc();

                Show();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }
            _isNew = false;  // to disable page switch
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if ( tabControl.SelectedTab == tabPageCard ) {
                //RefreshBooking();
            } else if ( tabControl.SelectedTab == tabPageCash ) {
                financialCurrencyPickerPayment.SelectedValue = _financialCurrencyId;
                //RefreshCrudeBookingContactMethod();
            } else if ( tabControl.SelectedTab == tabPageCash ) {
                //RefreshCrudeBookingContactMethod();
            } else if ( tabControl.SelectedTab == tabPageVoucher ) {
                RefreshVoucherSearchWithRemainingAmount();
            } else if ( tabControl.SelectedTab == tabPageBank ) {
                //RefreshCrudeBookingContactMethod();
            } else if ( tabControl.SelectedTab == tabPageAccounting ) {
                //RefreshCrudeBookingContactMethod();
            }
        }

        private void RefreshVoucherSearchWithRemainingAmount() {
            FinancialSearchServiceClient voucherSearchWithRemaindingAmount = new FinancialSearchServiceClient();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = voucherSearchWithRemaindingAmount.VoucherSearchWithRemainingAmount(DateTime.UtcNow);
                dataGridViewVoucherSearchWithRemainingAmount.AutoGenerateColumns = true;
                dataGridViewVoucherSearchWithRemainingAmount.DataSource = bindingSource;
                dataGridViewVoucherSearchWithRemainingAmount.AutoResizeColumns();
                dataGridViewVoucherSearchWithRemainingAmount.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                voucherSearchWithRemaindingAmount.Close();
            }
        }

        private void InitializeGridVoucherSearchWithRemainingAmount() {
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Clear();
            dataGridViewVoucherSearchWithRemainingAmount.AutoGenerateColumns = false;
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialVoucherId", "Financial Voucher Id");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialCurrencyId", "");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("VoucherNumber", "Voucher Number");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("VoucherDescription", "Voucher Description");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("RemainingAmount", "Remaining Amount");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialCurrencyTypeCode", "Financial Currency Type Code");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialCurrencyTypeName", "Financial Currency Type Name");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("ValidFromDateTime", "Valid From Date Time");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("ValidUntilDateTime", "Valid Until Date Time");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("ExtensionData", "");
            dataGridViewVoucherSearchWithRemainingAmount.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewVoucherSearchWithRemainingAmount.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewVoucherSearchWithRemainingAmount.AutoResizeColumns();
        }

        private void buttonVoucherSearch_Click(object sender, EventArgs e) {
            RefreshVoucherSearchWithRemainingAmount();
        }

        private void maskedTextBoxPaymentAmount_Leave(object sender, EventArgs e) {
            CashCalc();
        }

        bool PayWithCard() {
            var cardContract = new CrudeFinancialPaymentCardContract();

            // Financial Card Type
            cardContract.FinancialCardTypeRcd = financialCardTypeRefCombo.Text;
            if ( string.IsNullOrEmpty(cardContract.FinancialCardTypeRcd) ) {
                financialCardTypeRefCombo.Focus();
                MessageBox.Show("Financial Card Type Missing");
                return false;
            }

            // Name On Card
            cardContract.NameOnCard = textBoxNameOnCard.Text;
            if ( string.IsNullOrEmpty(cardContract.NameOnCard) ) {
                textBoxNameOnCard.Focus();
                MessageBox.Show("Name On Card Missing");
                return false;
            }

            // Card Number 
            cardContract.CardNumber = textBoxCardNumber.Text;
            if ( string.IsNullOrEmpty(cardContract.CardNumber) ) {
                textBoxCardNumber.Focus();
                MessageBox.Show("Card Number Missing");
                return false;
            }

            // Card Verification Value
            { Int32 i; Int32.TryParse(maskedTextBoxCardVerificationValue.Text, out i); cardContract.CardVerificationValue = i; }

            if ( cardContract.CardVerificationValue.Equals(0) ) {
                maskedTextBoxCardVerificationValue.Focus();
                MessageBox.Show("Card Verification Value Missing");
                return false;
            }

            // Address Verification Code
            cardContract.AddressVerificationCode = textBoxAddressVerificationCode.Text;
            if ( string.IsNullOrEmpty(cardContract.AddressVerificationCode) ) {
                textBoxAddressVerificationCode.Focus();
                MessageBox.Show("Address Verification Code Missing");
                return false;
            }

            { Int32 i; Int32.TryParse(maskedTextBoxIssuedYear.Text, out i); cardContract.IssuedYear = i; }
            cardContract.IssuedMonth = maskedTextBoxIssuedMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedMonth.Text);

            // Expiry Year
            cardContract.ExpiryYear = maskedTextBoxExpiryYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryYear.Text);
            if ( cardContract.ExpiryYear.Equals(0) ) {
                maskedTextBoxExpiryYear.Focus();
                MessageBox.Show("Expiry Year Missing");
                return false;
            }

            // Expiry Month
            cardContract.ExpiryMonth = maskedTextBoxExpiryMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryMonth.Text);
            if ( cardContract.ExpiryMonth.Equals(0) ) {
                maskedTextBoxExpiryMonth.Focus();
                MessageBox.Show("Expiry Month Missing");
                return false;
            }

            cardContract.Amount = _paymentAmount;
            cardContract.FinancialCurrencyId = financialCurrencyPickerPayment.SelectedValue;

            new BookingServiceClient()
                .PaymentCardAdd(
                    _bookingId,
                    _paymentAmountInBookingCurrency,
                    _roundingAmountInBookingCurrency,
                    ( Guid ) financialCurrencyPickerBookingBalance.SelectedValue,
                    cardContract,
                    _financialCostcentreId,
                    _financialPaymentContract.UserId
                    );

            return true;
        }

        bool PayWithCash() {
            new BookingServiceClient()
                .PaymentCashAdd(
                    _bookingId,
                    _paymentAmount,
                    0,
                    financialCurrencyPickerPayment.SelectedValue,
                    _paymentAmountInBookingCurrency,
                    _roundingAmountInBookingCurrency,
                    financialCurrencyPickerBookingBalance.SelectedValue,
                    _financialCostcentreId,
                    _financialPaymentContract.UserId
                    );

            return true;
        }

        bool PayWithVoucher() {
            // check if voucher is selected
            if ( dataGridViewVoucherSearchWithRemainingAmount.CurrentRow == null ) {
                MessageBox.Show("Please select a voucher");
                return false;
            }

            new BookingServiceClient()
                .PaymentVoucherAdd(
                    _bookingId,
                    ( Guid ) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialVoucherId"].Value,
                    _paymentAmount,
                    0,
                    ( Guid ) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialCurrencyId"].Value,
                    _paymentAmountInBookingCurrency,
                    _roundingAmountInBookingCurrency,
                    ( Guid ) financialCurrencyPickerBookingBalance.SelectedValue,
                    _financialCostcentreId,
                    _financialPaymentContract.UserId
                    );
            return true;
        }

        bool PayWithBank() {
            var bankContract = new CrudeFinancialPaymentBankContract();

            // Financial Bank Account Number Type
            bankContract.FinancialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRefCombo.Text;
            if ( string.IsNullOrEmpty(bankContract.FinancialBankAccountNumberTypeRcd) ) {
                financialBankAccountNumberTypeRefCombo.Focus();
                MessageBox.Show("Financial Bank Account Number Type Missing");
                return false;
            }

            // Bank Name
            bankContract.BankName = textBoxBankName.Text;
            if ( string.IsNullOrEmpty(bankContract.BankName) ) {
                textBoxBankName.Focus();
                MessageBox.Show("Bank Name Missing");
                return false;
            }

            // Bank Account
            bankContract.BankAccount = textBoxBankAccount.Text;
            if ( string.IsNullOrEmpty(bankContract.BankAccount) ) {
                textBoxBankAccount.Focus();
                MessageBox.Show("Bank Account Missing");
                return false;
            }

            // Bank Number Missing
            bankContract.BankNumber = textBoxBankNumber.Text;
            if ( string.IsNullOrEmpty(bankContract.BankNumber) ) {
                textBoxBankNumber.Focus();
                MessageBox.Show("Bank Number Missing");
                return false;
            }

            new BookingServiceClient()
                .PaymentBankAdd(
                    _bookingId,
                    _paymentAmountInBookingCurrency,
                    _roundingAmountInBookingCurrency,
                    ( Guid ) financialCurrencyPickerBookingBalance.SelectedValue,
                    _paymentAmountInBookingCurrency,
                    _roundingAmountInBookingCurrency,
                    ( Guid ) financialCurrencyPickerBookingBalance.SelectedValue,
                    bankContract.FinancialBankAccountNumberTypeRcd,
                    bankContract.BankName,
                    bankContract.BankAccount,
                    bankContract.BankNumber,
                    _financialCostcentreId,
                    _financialPaymentContract.UserId
                    );

            return true;
        }

        bool PayWithAccount() {
            new BookingServiceClient().
                PaymentAccountingAdd(
                    _bookingId,
                    _paymentAmountInBookingCurrency,
                    _roundingAmountInBookingCurrency,
                    ( Guid ) financialCurrencyPickerBookingBalance.SelectedValue,
                    _financialCostcentreId,
                    _financialPaymentContract.UserId
                    );

            return true;
        }

        private void buttonPaymentAdd_Click(object sender, EventArgs e) {
            /*if (_paymentAmount <= 0) { 
                MessageBox.Show("Amount needs to be a positive number", "Form validation");
                return;
            }
            */
            try {
                if ( _isNew ) {
                    if ( tabControl.SelectedTab == tabPageCard ) {
                        if ( !PayWithCard() )
                            return;
                    } else if ( tabControl.SelectedTab == tabPageCash ) {
                        if ( !PayWithCash() )
                            return;
                    } else if ( tabControl.SelectedTab == tabPageVoucher ) {
                        if ( !PayWithVoucher() )
                            return;
                    } else if ( tabControl.SelectedTab == tabPageBank ) {
                        if ( !PayWithBank() )
                            return;
                    } else if ( tabControl.SelectedTab == tabPageAccounting ) {
                        if ( !PayWithAccount() )
                            return;
                    }
                }
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void buttonCurrencyLookup_Click(object sender, EventArgs e) {
            GetAvailableCurrenciesLiveSearch currencies = new GetAvailableCurrenciesLiveSearch();
            currencies.MdiParent = this.MdiParent;
            currencies.Show(
                financialCurrencyPickerPayment.SelectedValue,
                DateTime.UtcNow
                );
        }

        private void dataGridViewVoucherSearchWithRemainingAmount_SelectionChanged(object sender, EventArgs e) {
            if ( dataGridViewVoucherSearchWithRemainingAmount.CurrentRow != null ) {
                // get voucher
                var voucher = 
                    new CrudeFinancialVoucherServiceClient().FetchByFinancialVoucherId(
                        ( Guid ) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialVoucherId"].Value
                        );

                maskedTextBoxPaymentAmount.Text = voucher.ValueAmount.ToString();
                financialCurrencyPickerPayment.SelectedValue = voucher.FinancialCurrencyId;

                CashCalc();
            }
        }

        private void CashCalc() {
            CrudeFinancialCurrencyContract currency = 
                new BookingServiceClient().PaymentGetCurrency(
                        financialCurrencyPickerPayment.SelectedValue,
                        financialCurrencyPickerBookingBalance.SelectedValue,
                        _financialPaymentContract.DateTime
                        );

            if ( currency.FinancialCurrencyId == Guid.Empty ) {
                _paymentAmount = 0;
                _paymentAmountInBookingCurrency = 0;
                _roundingAmountInBookingCurrency = _balanceAmount - 0;

                maskedTextBoxAmountInBookingCurrency.Text = string.Empty;
                maskedTextBoxRoundingAmount.Text = string.Empty;
                maskedTextBoxNewBalance.Text = maskedTextBoxBalance.Text;

                labelCurrencyNotFound.Visible = true;
            } else {
                // set correct currency exchange
                financialCurrencyPickerPayment.SelectedValue = currency.FinancialCurrencyId;

                decimal.TryParse(maskedTextBoxPaymentAmount.Text, out _paymentAmount);
                _paymentAmountInBookingCurrency = _paymentAmount / currency.Amount;
                _roundingAmountInBookingCurrency = _balanceAmount - Math.Round(_balanceAmount, currency.DecimalCount);

                maskedTextBoxAmountInBookingCurrency.Text = _paymentAmountInBookingCurrency.ToString();
                maskedTextBoxRoundingAmount.Text = _roundingAmountInBookingCurrency.ToString();
                maskedTextBoxNewBalance.Text = ( _balanceAmount - _paymentAmountInBookingCurrency ).ToString("F" + currency.DecimalCount.ToString());

                labelCurrencyNotFound.Visible = false;
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) {
            if ( tabControl.SelectedTab == tabPageAccounting || !_isNew ) {
                e.Cancel = true;
                return;
            }
        }

        private void buttonVoucherView_Click(object sender, EventArgs e) {
            var view = new CrudeFinancialVoucherEdit();
            view.MdiParent = this.MdiParent;
            view.ShowAsEdit(( Guid ) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialVoucherId"].Value);
        }

        private void financialCurrencyPickerPayment_Picked(object sender, EventArgs e) {
            CashCalc();
        }

    }
}
