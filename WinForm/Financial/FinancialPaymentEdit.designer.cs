namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FinancialPaymentEdit
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCard = new System.Windows.Forms.TabPage();
            this.labelIssuedYear = new System.Windows.Forms.Label();
            this.maskedTextBoxIssuedYear = new System.Windows.Forms.MaskedTextBox();
            this.labelIssuedMonth = new System.Windows.Forms.Label();
            this.maskedTextBoxIssuedMonth = new System.Windows.Forms.MaskedTextBox();
            this.labelExpiryYear = new System.Windows.Forms.Label();
            this.maskedTextBoxExpiryYear = new System.Windows.Forms.MaskedTextBox();
            this.labelExpiryMonth = new System.Windows.Forms.Label();
            this.maskedTextBoxExpiryMonth = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCardTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCardTypeRefCombo = new SolutionNorSolutionPort.UserInterface.FinancialCardTypeRefCombo();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelCardVerificationValue = new System.Windows.Forms.Label();
            this.maskedTextBoxCardVerificationValue = new System.Windows.Forms.MaskedTextBox();
            this.labelAddressVerificationCode = new System.Windows.Forms.Label();
            this.textBoxAddressVerificationCode = new System.Windows.Forms.TextBox();
            this.tabPageCash = new System.Windows.Forms.TabPage();
            this.tabPageVoucher = new System.Windows.Forms.TabPage();
            this.dataGridViewVoucherSearchWithRemainingAmount = new System.Windows.Forms.DataGridView();
            this.buttonVoucherView = new System.Windows.Forms.Button();
            this.buttonVoucherSearch = new System.Windows.Forms.Button();
            this.labelFinancialVoucherTypeRefCombo = new System.Windows.Forms.Label();
            this.labelVoucherNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxVoucherNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelVoucherDescription = new System.Windows.Forms.Label();
            this.textBoxVoucherDescription = new System.Windows.Forms.TextBox();
            this.financialVoucherTypeRefCombo = new SolutionNorSolutionPort.UserInterface.FinancialVoucherTypeRefCombo();
            this.tabPageBank = new System.Windows.Forms.TabPage();
            this.labelFinancialBankAccountNumberTypeRefCombo = new System.Windows.Forms.Label();
            this.labelBankName = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.labelBankAccount = new System.Windows.Forms.Label();
            this.textBoxBankAccount = new System.Windows.Forms.TextBox();
            this.labelBankNumber = new System.Windows.Forms.Label();
            this.textBoxBankNumber = new System.Windows.Forms.TextBox();
            this.financialBankAccountNumberTypeRefCombo = new SolutionNorSolutionPort.UserInterface.FinancialBankAccountNumberTypeRefCombo();
            this.tabPageAccounting = new System.Windows.Forms.TabPage();
            this.buttonPaymentAdd = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.maskedTextBoxBalance = new System.Windows.Forms.MaskedTextBox();
            this.labelRoundingAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxRoundingAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelBookingBalanceCurrency = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxPaymentAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelNewBalance = new System.Windows.Forms.Label();
            this.maskedTextBoxNewBalance = new System.Windows.Forms.MaskedTextBox();
            this.labelCurrencyNotFound = new System.Windows.Forms.Label();
            this.buttonCurrencyLookup = new System.Windows.Forms.Button();
            this.financialCurrencyPickerBookingBalance = new SolutionNorSolutionPort.UserInterface.FinancialCurrencyLivePicker();
            this.labelPaymentAmountCurrency = new System.Windows.Forms.Label();
            this.financialCurrencyPickerPayment = new SolutionNorSolutionPort.UserInterface.FinancialCurrencyLivePicker();
            this.labelBookingCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPickerBookingCurrency = new SolutionNorSolutionPort.UserInterface.FinancialCurrencyLivePicker();
            this.labelBookingCurrency = new System.Windows.Forms.Label();
            this.maskedTextBoxAmountInBookingCurrency = new System.Windows.Forms.MaskedTextBox();
            this.tabControl.SuspendLayout();
            this.tabPageCard.SuspendLayout();
            this.tabPageVoucher.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewVoucherSearchWithRemainingAmount ) ).BeginInit();
            this.tabPageBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(587, 411);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.tabControl.Controls.Add(this.tabPageCard);
            this.tabControl.Controls.Add(this.tabPageCash);
            this.tabControl.Controls.Add(this.tabPageVoucher);
            this.tabControl.Controls.Add(this.tabPageBank);
            this.tabControl.Controls.Add(this.tabPageAccounting);
            this.tabControl.Location = new System.Drawing.Point(12, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(669, 288);
            this.tabControl.TabIndex = 16;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabPageCard
            // 
            this.tabPageCard.Controls.Add(this.labelIssuedYear);
            this.tabPageCard.Controls.Add(this.maskedTextBoxIssuedYear);
            this.tabPageCard.Controls.Add(this.labelIssuedMonth);
            this.tabPageCard.Controls.Add(this.maskedTextBoxIssuedMonth);
            this.tabPageCard.Controls.Add(this.labelExpiryYear);
            this.tabPageCard.Controls.Add(this.maskedTextBoxExpiryYear);
            this.tabPageCard.Controls.Add(this.labelExpiryMonth);
            this.tabPageCard.Controls.Add(this.maskedTextBoxExpiryMonth);
            this.tabPageCard.Controls.Add(this.labelFinancialCardTypeRefCombo);
            this.tabPageCard.Controls.Add(this.financialCardTypeRefCombo);
            this.tabPageCard.Controls.Add(this.labelNameOnCard);
            this.tabPageCard.Controls.Add(this.textBoxNameOnCard);
            this.tabPageCard.Controls.Add(this.labelCardNumber);
            this.tabPageCard.Controls.Add(this.textBoxCardNumber);
            this.tabPageCard.Controls.Add(this.labelCardVerificationValue);
            this.tabPageCard.Controls.Add(this.maskedTextBoxCardVerificationValue);
            this.tabPageCard.Controls.Add(this.labelAddressVerificationCode);
            this.tabPageCard.Controls.Add(this.textBoxAddressVerificationCode);
            this.tabPageCard.Location = new System.Drawing.Point(4, 22);
            this.tabPageCard.Name = "tabPageCard";
            this.tabPageCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCard.Size = new System.Drawing.Size(661, 262);
            this.tabPageCard.TabIndex = 0;
            this.tabPageCard.Text = "Card";
            this.tabPageCard.UseVisualStyleBackColor = true;
            // 
            // labelIssuedYear
            // 
            this.labelIssuedYear.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.labelIssuedYear.AutoSize = true;
            this.labelIssuedYear.Location = new System.Drawing.Point(379, 12);
            this.labelIssuedYear.Name = "labelIssuedYear";
            this.labelIssuedYear.Size = new System.Drawing.Size(66, 13);
            this.labelIssuedYear.TabIndex = 22;
            this.labelIssuedYear.Text = "Issued Year:";
            // 
            // maskedTextBoxIssuedYear
            // 
            this.maskedTextBoxIssuedYear.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.maskedTextBoxIssuedYear.Location = new System.Drawing.Point(473, 12);
            this.maskedTextBoxIssuedYear.Name = "maskedTextBoxIssuedYear";
            this.maskedTextBoxIssuedYear.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxIssuedYear.TabIndex = 23;
            // 
            // labelIssuedMonth
            // 
            this.labelIssuedMonth.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.labelIssuedMonth.AutoSize = true;
            this.labelIssuedMonth.Location = new System.Drawing.Point(379, 35);
            this.labelIssuedMonth.Name = "labelIssuedMonth";
            this.labelIssuedMonth.Size = new System.Drawing.Size(74, 13);
            this.labelIssuedMonth.TabIndex = 24;
            this.labelIssuedMonth.Text = "Issued Month:";
            // 
            // maskedTextBoxIssuedMonth
            // 
            this.maskedTextBoxIssuedMonth.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.maskedTextBoxIssuedMonth.Location = new System.Drawing.Point(473, 35);
            this.maskedTextBoxIssuedMonth.Name = "maskedTextBoxIssuedMonth";
            this.maskedTextBoxIssuedMonth.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxIssuedMonth.TabIndex = 25;
            // 
            // labelExpiryYear
            // 
            this.labelExpiryYear.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.labelExpiryYear.AutoSize = true;
            this.labelExpiryYear.Location = new System.Drawing.Point(379, 58);
            this.labelExpiryYear.Name = "labelExpiryYear";
            this.labelExpiryYear.Size = new System.Drawing.Size(63, 13);
            this.labelExpiryYear.TabIndex = 26;
            this.labelExpiryYear.Text = "Expiry Year:";
            // 
            // maskedTextBoxExpiryYear
            // 
            this.maskedTextBoxExpiryYear.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.maskedTextBoxExpiryYear.Location = new System.Drawing.Point(473, 58);
            this.maskedTextBoxExpiryYear.Name = "maskedTextBoxExpiryYear";
            this.maskedTextBoxExpiryYear.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxExpiryYear.TabIndex = 27;
            // 
            // labelExpiryMonth
            // 
            this.labelExpiryMonth.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.labelExpiryMonth.AutoSize = true;
            this.labelExpiryMonth.Location = new System.Drawing.Point(379, 81);
            this.labelExpiryMonth.Name = "labelExpiryMonth";
            this.labelExpiryMonth.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryMonth.TabIndex = 28;
            this.labelExpiryMonth.Text = "Expiry Month:";
            // 
            // maskedTextBoxExpiryMonth
            // 
            this.maskedTextBoxExpiryMonth.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.maskedTextBoxExpiryMonth.Location = new System.Drawing.Point(473, 81);
            this.maskedTextBoxExpiryMonth.Name = "maskedTextBoxExpiryMonth";
            this.maskedTextBoxExpiryMonth.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxExpiryMonth.TabIndex = 29;
            // 
            // labelFinancialCardTypeRefCombo
            // 
            this.labelFinancialCardTypeRefCombo.AutoSize = true;
            this.labelFinancialCardTypeRefCombo.Location = new System.Drawing.Point(6, 12);
            this.labelFinancialCardTypeRefCombo.Name = "labelFinancialCardTypeRefCombo";
            this.labelFinancialCardTypeRefCombo.Size = new System.Drawing.Size(104, 13);
            this.labelFinancialCardTypeRefCombo.TabIndex = 12;
            this.labelFinancialCardTypeRefCombo.Text = "Financial Card Type:";
            // 
            // financialCardTypeRefCombo
            // 
            this.financialCardTypeRefCombo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.financialCardTypeRefCombo.Location = new System.Drawing.Point(170, 12);
            this.financialCardTypeRefCombo.Name = "financialCardTypeRefCombo";
            this.financialCardTypeRefCombo.Size = new System.Drawing.Size(201, 20);
            this.financialCardTypeRefCombo.TabIndex = 13;
            // 
            // labelNameOnCard
            // 
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(6, 35);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(80, 13);
            this.labelNameOnCard.TabIndex = 14;
            this.labelNameOnCard.Text = "Name On Card:";
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxNameOnCard.Location = new System.Drawing.Point(170, 35);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(201, 20);
            this.textBoxNameOnCard.TabIndex = 15;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(6, 58);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(72, 13);
            this.labelCardNumber.TabIndex = 16;
            this.labelCardNumber.Text = "Card Number:";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxCardNumber.Location = new System.Drawing.Point(170, 58);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(201, 20);
            this.textBoxCardNumber.TabIndex = 17;
            // 
            // labelCardVerificationValue
            // 
            this.labelCardVerificationValue.AutoSize = true;
            this.labelCardVerificationValue.Location = new System.Drawing.Point(6, 81);
            this.labelCardVerificationValue.Name = "labelCardVerificationValue";
            this.labelCardVerificationValue.Size = new System.Drawing.Size(117, 13);
            this.labelCardVerificationValue.TabIndex = 18;
            this.labelCardVerificationValue.Text = "Card Verification Value:";
            // 
            // maskedTextBoxCardVerificationValue
            // 
            this.maskedTextBoxCardVerificationValue.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.maskedTextBoxCardVerificationValue.Location = new System.Drawing.Point(170, 81);
            this.maskedTextBoxCardVerificationValue.Name = "maskedTextBoxCardVerificationValue";
            this.maskedTextBoxCardVerificationValue.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxCardVerificationValue.TabIndex = 19;
            // 
            // labelAddressVerificationCode
            // 
            this.labelAddressVerificationCode.AutoSize = true;
            this.labelAddressVerificationCode.Location = new System.Drawing.Point(6, 104);
            this.labelAddressVerificationCode.Name = "labelAddressVerificationCode";
            this.labelAddressVerificationCode.Size = new System.Drawing.Size(131, 13);
            this.labelAddressVerificationCode.TabIndex = 20;
            this.labelAddressVerificationCode.Text = "Address Verification Code:";
            // 
            // textBoxAddressVerificationCode
            // 
            this.textBoxAddressVerificationCode.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxAddressVerificationCode.Location = new System.Drawing.Point(170, 104);
            this.textBoxAddressVerificationCode.Name = "textBoxAddressVerificationCode";
            this.textBoxAddressVerificationCode.Size = new System.Drawing.Size(201, 20);
            this.textBoxAddressVerificationCode.TabIndex = 21;
            // 
            // tabPageCash
            // 
            this.tabPageCash.Location = new System.Drawing.Point(4, 22);
            this.tabPageCash.Name = "tabPageCash";
            this.tabPageCash.Size = new System.Drawing.Size(661, 262);
            this.tabPageCash.TabIndex = 1;
            this.tabPageCash.Text = "Cash";
            this.tabPageCash.UseVisualStyleBackColor = true;
            // 
            // tabPageVoucher
            // 
            this.tabPageVoucher.Controls.Add(this.dataGridViewVoucherSearchWithRemainingAmount);
            this.tabPageVoucher.Controls.Add(this.buttonVoucherView);
            this.tabPageVoucher.Controls.Add(this.buttonVoucherSearch);
            this.tabPageVoucher.Controls.Add(this.labelFinancialVoucherTypeRefCombo);
            this.tabPageVoucher.Controls.Add(this.labelVoucherNumber);
            this.tabPageVoucher.Controls.Add(this.maskedTextBoxVoucherNumber);
            this.tabPageVoucher.Controls.Add(this.labelVoucherDescription);
            this.tabPageVoucher.Controls.Add(this.textBoxVoucherDescription);
            this.tabPageVoucher.Controls.Add(this.financialVoucherTypeRefCombo);
            this.tabPageVoucher.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoucher.Name = "tabPageVoucher";
            this.tabPageVoucher.Size = new System.Drawing.Size(661, 262);
            this.tabPageVoucher.TabIndex = 2;
            this.tabPageVoucher.Text = "Voucher";
            this.tabPageVoucher.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVoucherSearchWithRemainingAmount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.dataGridViewVoucherSearchWithRemainingAmount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVoucherSearchWithRemainingAmount.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewVoucherSearchWithRemainingAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucherSearchWithRemainingAmount.Location = new System.Drawing.Point(9, 90);
            this.dataGridViewVoucherSearchWithRemainingAmount.Name = "dataGridViewVoucherSearchWithRemainingAmount";
            this.dataGridViewVoucherSearchWithRemainingAmount.Size = new System.Drawing.Size(645, 141);
            this.dataGridViewVoucherSearchWithRemainingAmount.TabIndex = 24;
            this.dataGridViewVoucherSearchWithRemainingAmount.SelectionChanged += new System.EventHandler(this.dataGridViewVoucherSearchWithRemainingAmount_SelectionChanged);
            // 
            // buttonVoucherView
            // 
            this.buttonVoucherView.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonVoucherView.Location = new System.Drawing.Point(464, 237);
            this.buttonVoucherView.Name = "buttonVoucherView";
            this.buttonVoucherView.Size = new System.Drawing.Size(92, 22);
            this.buttonVoucherView.TabIndex = 23;
            this.buttonVoucherView.Text = "&View";
            this.buttonVoucherView.UseVisualStyleBackColor = true;
            this.buttonVoucherView.Click += new System.EventHandler(this.buttonVoucherView_Click);
            // 
            // buttonVoucherSearch
            // 
            this.buttonVoucherSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonVoucherSearch.Location = new System.Drawing.Point(562, 237);
            this.buttonVoucherSearch.Name = "buttonVoucherSearch";
            this.buttonVoucherSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonVoucherSearch.TabIndex = 22;
            this.buttonVoucherSearch.Text = "&Search";
            this.buttonVoucherSearch.UseVisualStyleBackColor = true;
            this.buttonVoucherSearch.Click += new System.EventHandler(this.buttonVoucherSearch_Click);
            // 
            // labelFinancialVoucherTypeRefCombo
            // 
            this.labelFinancialVoucherTypeRefCombo.AutoSize = true;
            this.labelFinancialVoucherTypeRefCombo.Location = new System.Drawing.Point(6, 12);
            this.labelFinancialVoucherTypeRefCombo.Name = "labelFinancialVoucherTypeRefCombo";
            this.labelFinancialVoucherTypeRefCombo.Size = new System.Drawing.Size(122, 13);
            this.labelFinancialVoucherTypeRefCombo.TabIndex = 16;
            this.labelFinancialVoucherTypeRefCombo.Text = "Financial Voucher Type:";
            // 
            // labelVoucherNumber
            // 
            this.labelVoucherNumber.AutoSize = true;
            this.labelVoucherNumber.Location = new System.Drawing.Point(6, 38);
            this.labelVoucherNumber.Name = "labelVoucherNumber";
            this.labelVoucherNumber.Size = new System.Drawing.Size(90, 13);
            this.labelVoucherNumber.TabIndex = 18;
            this.labelVoucherNumber.Text = "Voucher Number:";
            // 
            // maskedTextBoxVoucherNumber
            // 
            this.maskedTextBoxVoucherNumber.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.maskedTextBoxVoucherNumber.Location = new System.Drawing.Point(150, 38);
            this.maskedTextBoxVoucherNumber.Name = "maskedTextBoxVoucherNumber";
            this.maskedTextBoxVoucherNumber.Size = new System.Drawing.Size(259, 20);
            this.maskedTextBoxVoucherNumber.TabIndex = 19;
            // 
            // labelVoucherDescription
            // 
            this.labelVoucherDescription.AutoSize = true;
            this.labelVoucherDescription.Location = new System.Drawing.Point(6, 65);
            this.labelVoucherDescription.Name = "labelVoucherDescription";
            this.labelVoucherDescription.Size = new System.Drawing.Size(106, 13);
            this.labelVoucherDescription.TabIndex = 20;
            this.labelVoucherDescription.Text = "Voucher Description:";
            // 
            // textBoxVoucherDescription
            // 
            this.textBoxVoucherDescription.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxVoucherDescription.Location = new System.Drawing.Point(150, 64);
            this.textBoxVoucherDescription.Name = "textBoxVoucherDescription";
            this.textBoxVoucherDescription.Size = new System.Drawing.Size(259, 20);
            this.textBoxVoucherDescription.TabIndex = 21;
            // 
            // financialVoucherTypeRefCombo
            // 
            this.financialVoucherTypeRefCombo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.financialVoucherTypeRefCombo.Location = new System.Drawing.Point(150, 12);
            this.financialVoucherTypeRefCombo.Name = "financialVoucherTypeRefCombo";
            this.financialVoucherTypeRefCombo.Size = new System.Drawing.Size(259, 20);
            this.financialVoucherTypeRefCombo.TabIndex = 17;
            // 
            // tabPageBank
            // 
            this.tabPageBank.Controls.Add(this.labelFinancialBankAccountNumberTypeRefCombo);
            this.tabPageBank.Controls.Add(this.labelBankName);
            this.tabPageBank.Controls.Add(this.textBoxBankName);
            this.tabPageBank.Controls.Add(this.labelBankAccount);
            this.tabPageBank.Controls.Add(this.textBoxBankAccount);
            this.tabPageBank.Controls.Add(this.labelBankNumber);
            this.tabPageBank.Controls.Add(this.textBoxBankNumber);
            this.tabPageBank.Controls.Add(this.financialBankAccountNumberTypeRefCombo);
            this.tabPageBank.Location = new System.Drawing.Point(4, 22);
            this.tabPageBank.Name = "tabPageBank";
            this.tabPageBank.Size = new System.Drawing.Size(661, 262);
            this.tabPageBank.TabIndex = 3;
            this.tabPageBank.Text = "Bank";
            this.tabPageBank.UseVisualStyleBackColor = true;
            // 
            // labelFinancialBankAccountNumberTypeRefCombo
            // 
            this.labelFinancialBankAccountNumberTypeRefCombo.AutoSize = true;
            this.labelFinancialBankAccountNumberTypeRefCombo.Location = new System.Drawing.Point(6, 12);
            this.labelFinancialBankAccountNumberTypeRefCombo.Name = "labelFinancialBankAccountNumberTypeRefCombo";
            this.labelFinancialBankAccountNumberTypeRefCombo.Size = new System.Drawing.Size(190, 13);
            this.labelFinancialBankAccountNumberTypeRefCombo.TabIndex = 10;
            this.labelFinancialBankAccountNumberTypeRefCombo.Text = "Financial Bank Account Number Type:";
            // 
            // labelBankName
            // 
            this.labelBankName.AutoSize = true;
            this.labelBankName.Location = new System.Drawing.Point(6, 35);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(66, 13);
            this.labelBankName.TabIndex = 12;
            this.labelBankName.Text = "Bank Name:";
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxBankName.Location = new System.Drawing.Point(240, 35);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(413, 20);
            this.textBoxBankName.TabIndex = 13;
            // 
            // labelBankAccount
            // 
            this.labelBankAccount.AutoSize = true;
            this.labelBankAccount.Location = new System.Drawing.Point(6, 84);
            this.labelBankAccount.Name = "labelBankAccount";
            this.labelBankAccount.Size = new System.Drawing.Size(78, 13);
            this.labelBankAccount.TabIndex = 14;
            this.labelBankAccount.Text = "Bank Account:";
            // 
            // textBoxBankAccount
            // 
            this.textBoxBankAccount.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxBankAccount.Location = new System.Drawing.Point(240, 84);
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(413, 20);
            this.textBoxBankAccount.TabIndex = 15;
            // 
            // labelBankNumber
            // 
            this.labelBankNumber.AutoSize = true;
            this.labelBankNumber.Location = new System.Drawing.Point(6, 58);
            this.labelBankNumber.Name = "labelBankNumber";
            this.labelBankNumber.Size = new System.Drawing.Size(75, 13);
            this.labelBankNumber.TabIndex = 16;
            this.labelBankNumber.Text = "Bank Number:";
            // 
            // textBoxBankNumber
            // 
            this.textBoxBankNumber.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxBankNumber.Location = new System.Drawing.Point(240, 58);
            this.textBoxBankNumber.Name = "textBoxBankNumber";
            this.textBoxBankNumber.Size = new System.Drawing.Size(413, 20);
            this.textBoxBankNumber.TabIndex = 17;
            // 
            // financialBankAccountNumberTypeRefCombo
            // 
            this.financialBankAccountNumberTypeRefCombo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.financialBankAccountNumberTypeRefCombo.Location = new System.Drawing.Point(240, 12);
            this.financialBankAccountNumberTypeRefCombo.Name = "financialBankAccountNumberTypeRefCombo";
            this.financialBankAccountNumberTypeRefCombo.Size = new System.Drawing.Size(413, 20);
            this.financialBankAccountNumberTypeRefCombo.TabIndex = 11;
            // 
            // tabPageAccounting
            // 
            this.tabPageAccounting.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccounting.Name = "tabPageAccounting";
            this.tabPageAccounting.Size = new System.Drawing.Size(661, 262);
            this.tabPageAccounting.TabIndex = 4;
            this.tabPageAccounting.Text = "Accounting";
            this.tabPageAccounting.UseVisualStyleBackColor = true;
            // 
            // buttonPaymentAdd
            // 
            this.buttonPaymentAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonPaymentAdd.Location = new System.Drawing.Point(489, 411);
            this.buttonPaymentAdd.Name = "buttonPaymentAdd";
            this.buttonPaymentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonPaymentAdd.TabIndex = 24;
            this.buttonPaymentAdd.Text = "&Add";
            this.buttonPaymentAdd.UseVisualStyleBackColor = true;
            this.buttonPaymentAdd.Click += new System.EventHandler(this.buttonPaymentAdd_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(9, 307);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(91, 13);
            this.labelBalance.TabIndex = 28;
            this.labelBalance.Text = "Booking Balance:";
            // 
            // maskedTextBoxBalance
            // 
            this.maskedTextBoxBalance.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.maskedTextBoxBalance.Enabled = false;
            this.maskedTextBoxBalance.Location = new System.Drawing.Point(119, 304);
            this.maskedTextBoxBalance.Name = "maskedTextBoxBalance";
            this.maskedTextBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxBalance.TabIndex = 29;
            // 
            // labelRoundingAmount
            // 
            this.labelRoundingAmount.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelRoundingAmount.AutoSize = true;
            this.labelRoundingAmount.Location = new System.Drawing.Point(9, 383);
            this.labelRoundingAmount.Name = "labelRoundingAmount";
            this.labelRoundingAmount.Size = new System.Drawing.Size(56, 13);
            this.labelRoundingAmount.TabIndex = 30;
            this.labelRoundingAmount.Text = "Rounding:";
            // 
            // maskedTextBoxRoundingAmount
            // 
            this.maskedTextBoxRoundingAmount.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.maskedTextBoxRoundingAmount.Enabled = false;
            this.maskedTextBoxRoundingAmount.Location = new System.Drawing.Point(119, 380);
            this.maskedTextBoxRoundingAmount.Name = "maskedTextBoxRoundingAmount";
            this.maskedTextBoxRoundingAmount.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRoundingAmount.TabIndex = 31;
            // 
            // labelBookingBalanceCurrency
            // 
            this.labelBookingBalanceCurrency.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelBookingBalanceCurrency.AutoSize = true;
            this.labelBookingBalanceCurrency.Location = new System.Drawing.Point(225, 307);
            this.labelBookingBalanceCurrency.Name = "labelBookingBalanceCurrency";
            this.labelBookingBalanceCurrency.Size = new System.Drawing.Size(52, 13);
            this.labelBookingBalanceCurrency.TabIndex = 32;
            this.labelBookingBalanceCurrency.Text = "Currency:";
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Location = new System.Drawing.Point(9, 332);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(90, 13);
            this.labelPaymentAmount.TabIndex = 34;
            this.labelPaymentAmount.Text = "Payment Amount:";
            // 
            // maskedTextBoxPaymentAmount
            // 
            this.maskedTextBoxPaymentAmount.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.maskedTextBoxPaymentAmount.Location = new System.Drawing.Point(119, 329);
            this.maskedTextBoxPaymentAmount.Name = "maskedTextBoxPaymentAmount";
            this.maskedTextBoxPaymentAmount.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPaymentAmount.TabIndex = 35;
            this.maskedTextBoxPaymentAmount.Leave += new System.EventHandler(this.maskedTextBoxPaymentAmount_Leave);
            // 
            // labelNewBalance
            // 
            this.labelNewBalance.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelNewBalance.AutoSize = true;
            this.labelNewBalance.Location = new System.Drawing.Point(9, 408);
            this.labelNewBalance.Name = "labelNewBalance";
            this.labelNewBalance.Size = new System.Drawing.Size(74, 13);
            this.labelNewBalance.TabIndex = 36;
            this.labelNewBalance.Text = "New Balance:";
            // 
            // maskedTextBoxNewBalance
            // 
            this.maskedTextBoxNewBalance.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.maskedTextBoxNewBalance.Enabled = false;
            this.maskedTextBoxNewBalance.Location = new System.Drawing.Point(119, 405);
            this.maskedTextBoxNewBalance.Name = "maskedTextBoxNewBalance";
            this.maskedTextBoxNewBalance.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNewBalance.TabIndex = 37;
            // 
            // labelCurrencyNotFound
            // 
            this.labelCurrencyNotFound.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.labelCurrencyNotFound.AutoSize = true;
            this.labelCurrencyNotFound.Location = new System.Drawing.Point(575, 355);
            this.labelCurrencyNotFound.Name = "labelCurrencyNotFound";
            this.labelCurrencyNotFound.Size = new System.Drawing.Size(102, 13);
            this.labelCurrencyNotFound.TabIndex = 38;
            this.labelCurrencyNotFound.Text = "Currency Not Found";
            this.labelCurrencyNotFound.Visible = false;
            // 
            // buttonCurrencyLookup
            // 
            this.buttonCurrencyLookup.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCurrencyLookup.Location = new System.Drawing.Point(391, 411);
            this.buttonCurrencyLookup.Name = "buttonCurrencyLookup";
            this.buttonCurrencyLookup.Size = new System.Drawing.Size(92, 22);
            this.buttonCurrencyLookup.TabIndex = 39;
            this.buttonCurrencyLookup.Text = "&Currencies";
            this.buttonCurrencyLookup.UseVisualStyleBackColor = true;
            this.buttonCurrencyLookup.Click += new System.EventHandler(this.buttonCurrencyLookup_Click);
            // 
            // financialCurrencyPickerBookingBalance
            // 
            this.financialCurrencyPickerBookingBalance.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.financialCurrencyPickerBookingBalance.Enabled = false;
            this.financialCurrencyPickerBookingBalance.Location = new System.Drawing.Point(283, 304);
            this.financialCurrencyPickerBookingBalance.Name = "financialCurrencyPickerBookingBalance";
            this.financialCurrencyPickerBookingBalance.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.financialCurrencyPickerBookingBalance.Size = new System.Drawing.Size(286, 20);
            this.financialCurrencyPickerBookingBalance.TabIndex = 33;
            // 
            // labelPaymentAmountCurrency
            // 
            this.labelPaymentAmountCurrency.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelPaymentAmountCurrency.AutoSize = true;
            this.labelPaymentAmountCurrency.Location = new System.Drawing.Point(225, 332);
            this.labelPaymentAmountCurrency.Name = "labelPaymentAmountCurrency";
            this.labelPaymentAmountCurrency.Size = new System.Drawing.Size(52, 13);
            this.labelPaymentAmountCurrency.TabIndex = 40;
            this.labelPaymentAmountCurrency.Text = "Currency:";
            // 
            // financialCurrencyPickerPayment
            // 
            this.financialCurrencyPickerPayment.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.financialCurrencyPickerPayment.Location = new System.Drawing.Point(283, 329);
            this.financialCurrencyPickerPayment.Name = "financialCurrencyPickerPayment";
            this.financialCurrencyPickerPayment.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.financialCurrencyPickerPayment.Size = new System.Drawing.Size(286, 20);
            this.financialCurrencyPickerPayment.TabIndex = 41;
            this.financialCurrencyPickerPayment.Picked += new System.EventHandler(this.financialCurrencyPickerPayment_Picked);
            // 
            // labelBookingCurrencyPicker
            // 
            this.labelBookingCurrencyPicker.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelBookingCurrencyPicker.AutoSize = true;
            this.labelBookingCurrencyPicker.Location = new System.Drawing.Point(225, 358);
            this.labelBookingCurrencyPicker.Name = "labelBookingCurrencyPicker";
            this.labelBookingCurrencyPicker.Size = new System.Drawing.Size(52, 13);
            this.labelBookingCurrencyPicker.TabIndex = 44;
            this.labelBookingCurrencyPicker.Text = "Currency:";
            // 
            // financialCurrencyPickerBookingCurrency
            // 
            this.financialCurrencyPickerBookingCurrency.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.financialCurrencyPickerBookingCurrency.Enabled = false;
            this.financialCurrencyPickerBookingCurrency.Location = new System.Drawing.Point(283, 355);
            this.financialCurrencyPickerBookingCurrency.Name = "financialCurrencyPickerBookingCurrency";
            this.financialCurrencyPickerBookingCurrency.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.financialCurrencyPickerBookingCurrency.Size = new System.Drawing.Size(286, 20);
            this.financialCurrencyPickerBookingCurrency.TabIndex = 45;
            // 
            // labelBookingCurrency
            // 
            this.labelBookingCurrency.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.labelBookingCurrency.AutoSize = true;
            this.labelBookingCurrency.Location = new System.Drawing.Point(9, 358);
            this.labelBookingCurrency.Name = "labelBookingCurrency";
            this.labelBookingCurrency.Size = new System.Drawing.Size(106, 13);
            this.labelBookingCurrency.TabIndex = 42;
            this.labelBookingCurrency.Text = "In Booking Currency:";
            // 
            // maskedTextBoxAmountInBookingCurrency
            // 
            this.maskedTextBoxAmountInBookingCurrency.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.maskedTextBoxAmountInBookingCurrency.Enabled = false;
            this.maskedTextBoxAmountInBookingCurrency.Location = new System.Drawing.Point(119, 355);
            this.maskedTextBoxAmountInBookingCurrency.Name = "maskedTextBoxAmountInBookingCurrency";
            this.maskedTextBoxAmountInBookingCurrency.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAmountInBookingCurrency.TabIndex = 43;
            // 
            // FinancialPaymentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 442);
            this.Controls.Add(this.labelBookingCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPickerBookingCurrency);
            this.Controls.Add(this.labelBookingCurrency);
            this.Controls.Add(this.maskedTextBoxAmountInBookingCurrency);
            this.Controls.Add(this.labelPaymentAmountCurrency);
            this.Controls.Add(this.financialCurrencyPickerPayment);
            this.Controls.Add(this.buttonCurrencyLookup);
            this.Controls.Add(this.labelCurrencyNotFound);
            this.Controls.Add(this.labelNewBalance);
            this.Controls.Add(this.buttonPaymentAdd);
            this.Controls.Add(this.maskedTextBoxNewBalance);
            this.Controls.Add(this.labelPaymentAmount);
            this.Controls.Add(this.maskedTextBoxPaymentAmount);
            this.Controls.Add(this.labelBookingBalanceCurrency);
            this.Controls.Add(this.financialCurrencyPickerBookingBalance);
            this.Controls.Add(this.labelRoundingAmount);
            this.Controls.Add(this.maskedTextBoxRoundingAmount);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.maskedTextBoxBalance);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.Name = "FinancialPaymentEdit";
            this.Text = "Financial Payment Edit";
            this.tabControl.ResumeLayout(false);
            this.tabPageCard.ResumeLayout(false);
            this.tabPageCard.PerformLayout();
            this.tabPageVoucher.ResumeLayout(false);
            this.tabPageVoucher.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewVoucherSearchWithRemainingAmount ) ).EndInit();
            this.tabPageBank.ResumeLayout(false);
            this.tabPageBank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCard;
        private System.Windows.Forms.TabPage tabPageCash;
        private System.Windows.Forms.TabPage tabPageVoucher;
        private System.Windows.Forms.TabPage tabPageBank;
        private System.Windows.Forms.TabPage tabPageAccounting;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBalance;
        private System.Windows.Forms.Label labelRoundingAmount;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRoundingAmount;
        private System.Windows.Forms.Label labelBookingBalanceCurrency;
        private FinancialCurrencyLivePicker financialCurrencyPickerBookingBalance;
        private System.Windows.Forms.Button buttonVoucherSearch;
        private System.Windows.Forms.Label labelFinancialVoucherTypeRefCombo;
        private FinancialVoucherTypeRefCombo financialVoucherTypeRefCombo;
        private System.Windows.Forms.Label labelVoucherNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVoucherNumber;
        private System.Windows.Forms.Label labelVoucherDescription;
        private System.Windows.Forms.TextBox textBoxVoucherDescription;
        private System.Windows.Forms.Button buttonPaymentAdd;
        private System.Windows.Forms.Label labelFinancialCardTypeRefCombo;
        private FinancialCardTypeRefCombo financialCardTypeRefCombo;
        private System.Windows.Forms.Label labelNameOnCard;
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelCardVerificationValue;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCardVerificationValue;
        private System.Windows.Forms.Label labelAddressVerificationCode;
        private System.Windows.Forms.TextBox textBoxAddressVerificationCode;
        private System.Windows.Forms.Label labelIssuedYear;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIssuedYear;
        private System.Windows.Forms.Label labelIssuedMonth;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIssuedMonth;
        private System.Windows.Forms.Label labelExpiryYear;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpiryYear;
        private System.Windows.Forms.Label labelExpiryMonth;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpiryMonth;
        private System.Windows.Forms.Label labelFinancialBankAccountNumberTypeRefCombo;
        private FinancialBankAccountNumberTypeRefCombo financialBankAccountNumberTypeRefCombo;
        private System.Windows.Forms.Label labelBankName;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.Label labelBankAccount;
        private System.Windows.Forms.TextBox textBoxBankAccount;
        private System.Windows.Forms.Label labelBankNumber;
        private System.Windows.Forms.TextBox textBoxBankNumber;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPaymentAmount;
        private System.Windows.Forms.Label labelNewBalance;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNewBalance;
        private System.Windows.Forms.Label labelCurrencyNotFound;
        private System.Windows.Forms.Button buttonCurrencyLookup;
        private System.Windows.Forms.Button buttonVoucherView;
        private System.Windows.Forms.Label labelPaymentAmountCurrency;
        private FinancialCurrencyLivePicker financialCurrencyPickerPayment;
        private System.Windows.Forms.Label labelBookingCurrencyPicker;
        private FinancialCurrencyLivePicker financialCurrencyPickerBookingCurrency;
        private System.Windows.Forms.Label labelBookingCurrency;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmountInBookingCurrency;
        private System.Windows.Forms.DataGridView dataGridViewVoucherSearchWithRemainingAmount;
    }
}
