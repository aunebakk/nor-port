namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialBookingTransactionEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTransactionNumber;
        
        private System.Windows.Forms.Label labelTransactionNumber;
        
        private FinancialBookingTransactionTypeRefCombo financialBookingTransactionTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialBookingTransactionTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private FinancialCostcentrePicker financialCostcentrePicker;
        
        private System.Windows.Forms.Label labelFinancialCostcentrePicker;
        
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
            this.labelTransactionNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxTransactionNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialBookingTransactionTypeRefCombo = new System.Windows.Forms.Label();
            this.financialBookingTransactionTypeRefCombo = new FinancialBookingTransactionTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelFinancialCostcentrePicker = new System.Windows.Forms.Label();
            this.financialCostcentrePicker = new FinancialCostcentrePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelTransactionNumber
            //
            this.labelTransactionNumber.AutoSize = true;
            this.labelTransactionNumber.Location = new System.Drawing.Point(11, 13);
            this.labelTransactionNumber.Name = "labelTransactionNumber";
            this.labelTransactionNumber.Size = new System.Drawing.Size(71, 13);
            this.labelTransactionNumber.TabIndex = 2;
            this.labelTransactionNumber.Text = "Transaction Number:";
            //
            //maskedTextBoxTransactionNumber
            //
            this.maskedTextBoxTransactionNumber.Location = new System.Drawing.Point(238, 13);
            this.maskedTextBoxTransactionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTransactionNumber.Name = "maskedTextBoxTransactionNumber";
            this.maskedTextBoxTransactionNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxTransactionNumber.TabIndex = 3;
            //
            // labelFinancialBookingTransactionTypeRefCombo
            //
            this.labelFinancialBookingTransactionTypeRefCombo.AutoSize = true;
            this.labelFinancialBookingTransactionTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialBookingTransactionTypeRefCombo.Name = "labelFinancialBookingTransactionTypeRefCombo";
            this.labelFinancialBookingTransactionTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBookingTransactionTypeRefCombo.TabIndex = 4;
            this.labelFinancialBookingTransactionTypeRefCombo.Text = "Financial Booking Transaction Type:";
            //
            //financialBookingTransactionTypeRefCombo
            //
            this.financialBookingTransactionTypeRefCombo.Location = new System.Drawing.Point(238, 36);
            this.financialBookingTransactionTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialBookingTransactionTypeRefCombo.Name = "financialBookingTransactionTypeRefCombo";
            this.financialBookingTransactionTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialBookingTransactionTypeRefCombo.TabIndex = 5;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 59);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(238, 59);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 7;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 8;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(238, 82);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 9;
            //
            // labelFinancialCostcentrePicker
            //
            this.labelFinancialCostcentrePicker.AutoSize = true;
            this.labelFinancialCostcentrePicker.Location = new System.Drawing.Point(11, 105);
            this.labelFinancialCostcentrePicker.Name = "labelFinancialCostcentrePicker";
            this.labelFinancialCostcentrePicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentrePicker.TabIndex = 10;
            this.labelFinancialCostcentrePicker.Text = "Financial Costcentre:";
            //
            //financialCostcentrePicker
            //
            this.financialCostcentrePicker.Location = new System.Drawing.Point(238, 105);
            this.financialCostcentrePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCostcentrePicker.Name = "financialCostcentrePicker";
            this.financialCostcentrePicker.Size = new System.Drawing.Size(250, 20);
            this.financialCostcentrePicker.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(238, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 174);
            
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
            this.buttonSave.Location = new System.Drawing.Point(296, 174);
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
            this.ClientSize = new System.Drawing.Size(500, 202);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialBookingTransactionEdit";
            this.Text = "Financial Booking Transaction Edit";
            this.Controls.Add(this.labelTransactionNumber);
            this.Controls.Add(this.maskedTextBoxTransactionNumber);
            this.Controls.Add(this.labelFinancialBookingTransactionTypeRefCombo);
            this.Controls.Add(this.financialBookingTransactionTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelFinancialCostcentrePicker);
            this.Controls.Add(this.financialCostcentrePicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
