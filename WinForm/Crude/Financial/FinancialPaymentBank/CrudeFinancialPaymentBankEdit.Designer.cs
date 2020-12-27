namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialPaymentBankEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private FinancialBankAccountNumberTypeRefCombo financialBankAccountNumberTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialBankAccountNumberTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxBankName;
        
        private System.Windows.Forms.Label labelBankName;
        
        private System.Windows.Forms.TextBox textBoxBankAccount;
        
        private System.Windows.Forms.Label labelBankAccount;
        
        private System.Windows.Forms.TextBox textBoxBankNumber;
        
        private System.Windows.Forms.Label labelBankNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFinancialBankAccountNumberTypeRefCombo = new System.Windows.Forms.Label();
            this.financialBankAccountNumberTypeRefCombo = new FinancialBankAccountNumberTypeRefCombo();
            this.labelBankName = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.labelBankAccount = new System.Windows.Forms.Label();
            this.textBoxBankAccount = new System.Windows.Forms.TextBox();
            this.labelBankNumber = new System.Windows.Forms.Label();
            this.textBoxBankNumber = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialBankAccountNumberTypeRefCombo
            //
            this.labelFinancialBankAccountNumberTypeRefCombo.AutoSize = true;
            this.labelFinancialBankAccountNumberTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialBankAccountNumberTypeRefCombo.Name = "labelFinancialBankAccountNumberTypeRefCombo";
            this.labelFinancialBankAccountNumberTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBankAccountNumberTypeRefCombo.TabIndex = 2;
            this.labelFinancialBankAccountNumberTypeRefCombo.Text = "Financial Bank Account Number Type:";
            //
            //financialBankAccountNumberTypeRefCombo
            //
            this.financialBankAccountNumberTypeRefCombo.Location = new System.Drawing.Point(238, 13);
            this.financialBankAccountNumberTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialBankAccountNumberTypeRefCombo.Name = "financialBankAccountNumberTypeRefCombo";
            this.financialBankAccountNumberTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialBankAccountNumberTypeRefCombo.TabIndex = 3;
            //
            // labelBankName
            //
            this.labelBankName.AutoSize = true;
            this.labelBankName.Location = new System.Drawing.Point(11, 36);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(71, 13);
            this.labelBankName.TabIndex = 4;
            this.labelBankName.Text = "Bank Name:";
            //
            //textBoxBankName
            //
            this.textBoxBankName.Location = new System.Drawing.Point(238, 36);
            this.textBoxBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBankName.TabIndex = 5;
            //
            // labelBankAccount
            //
            this.labelBankAccount.AutoSize = true;
            this.labelBankAccount.Location = new System.Drawing.Point(11, 59);
            this.labelBankAccount.Name = "labelBankAccount";
            this.labelBankAccount.Size = new System.Drawing.Size(71, 13);
            this.labelBankAccount.TabIndex = 6;
            this.labelBankAccount.Text = "Bank Account:";
            //
            //textBoxBankAccount
            //
            this.textBoxBankAccount.Location = new System.Drawing.Point(238, 59);
            this.textBoxBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(250, 20);
            this.textBoxBankAccount.TabIndex = 7;
            //
            // labelBankNumber
            //
            this.labelBankNumber.AutoSize = true;
            this.labelBankNumber.Location = new System.Drawing.Point(11, 82);
            this.labelBankNumber.Name = "labelBankNumber";
            this.labelBankNumber.Size = new System.Drawing.Size(71, 13);
            this.labelBankNumber.TabIndex = 8;
            this.labelBankNumber.Text = "Bank Number:";
            //
            //textBoxBankNumber
            //
            this.textBoxBankNumber.Location = new System.Drawing.Point(238, 82);
            this.textBoxBankNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankNumber.Name = "textBoxBankNumber";
            this.textBoxBankNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxBankNumber.TabIndex = 9;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 105);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(238, 105);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 11;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 128);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 12;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(238, 128);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 13;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 151);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 14;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(238, 151);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 15;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 174);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 16;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 174);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 197);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(296, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 225);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialPaymentBankEdit";
            this.Text = "Financial Payment Bank Edit";
            this.Controls.Add(this.labelFinancialBankAccountNumberTypeRefCombo);
            this.Controls.Add(this.financialBankAccountNumberTypeRefCombo);
            this.Controls.Add(this.labelBankName);
            this.Controls.Add(this.textBoxBankName);
            this.Controls.Add(this.labelBankAccount);
            this.Controls.Add(this.textBoxBankAccount);
            this.Controls.Add(this.labelBankNumber);
            this.Controls.Add(this.textBoxBankNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
