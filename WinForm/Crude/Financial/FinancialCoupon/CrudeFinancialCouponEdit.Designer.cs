namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialCouponEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private FinancialCouponTypeRefCombo financialCouponTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCouponTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCouponNumber;
        
        private System.Windows.Forms.Label labelCouponNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValueAmount;
        
        private System.Windows.Forms.Label labelValueAmount;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        private System.Windows.Forms.TextBox textBoxCouponDescription;
        
        private System.Windows.Forms.Label labelCouponDescription;
        
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
            this.labelFinancialCouponTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCouponTypeRefCombo = new FinancialCouponTypeRefCombo();
            this.labelCouponNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxCouponNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelValueAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxValueAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelCouponDescription = new System.Windows.Forms.Label();
            this.textBoxCouponDescription = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialCouponTypeRefCombo
            //
            this.labelFinancialCouponTypeRefCombo.AutoSize = true;
            this.labelFinancialCouponTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCouponTypeRefCombo.Name = "labelFinancialCouponTypeRefCombo";
            this.labelFinancialCouponTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCouponTypeRefCombo.TabIndex = 2;
            this.labelFinancialCouponTypeRefCombo.Text = "Financial Coupon Type:";
            //
            //financialCouponTypeRefCombo
            //
            this.financialCouponTypeRefCombo.Location = new System.Drawing.Point(147, 13);
            this.financialCouponTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCouponTypeRefCombo.Name = "financialCouponTypeRefCombo";
            this.financialCouponTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCouponTypeRefCombo.TabIndex = 3;
            //
            // labelCouponNumber
            //
            this.labelCouponNumber.AutoSize = true;
            this.labelCouponNumber.Location = new System.Drawing.Point(11, 36);
            this.labelCouponNumber.Name = "labelCouponNumber";
            this.labelCouponNumber.Size = new System.Drawing.Size(71, 13);
            this.labelCouponNumber.TabIndex = 4;
            this.labelCouponNumber.Text = "Coupon Number:";
            //
            //maskedTextBoxCouponNumber
            //
            this.maskedTextBoxCouponNumber.Location = new System.Drawing.Point(147, 36);
            this.maskedTextBoxCouponNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCouponNumber.Name = "maskedTextBoxCouponNumber";
            this.maskedTextBoxCouponNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCouponNumber.TabIndex = 5;
            //
            // labelValueAmount
            //
            this.labelValueAmount.AutoSize = true;
            this.labelValueAmount.Location = new System.Drawing.Point(11, 59);
            this.labelValueAmount.Name = "labelValueAmount";
            this.labelValueAmount.Size = new System.Drawing.Size(71, 13);
            this.labelValueAmount.TabIndex = 6;
            this.labelValueAmount.Text = "Value Amount:";
            //
            //maskedTextBoxValueAmount
            //
            this.maskedTextBoxValueAmount.Location = new System.Drawing.Point(147, 59);
            this.maskedTextBoxValueAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxValueAmount.Name = "maskedTextBoxValueAmount";
            this.maskedTextBoxValueAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxValueAmount.TabIndex = 7;
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
            this.financialCurrencyPicker.Location = new System.Drawing.Point(147, 82);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 9;
            //
            // labelValidFromDateTime
            //
            this.labelValidFromDateTime.AutoSize = true;
            this.labelValidFromDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelValidFromDateTime.Name = "labelValidFromDateTime";
            this.labelValidFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromDateTime.TabIndex = 10;
            this.labelValidFromDateTime.Text = "Valid From Date Time:";
            //
            //dateTimePickerValidFromDateTime
            //
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(147, 105);
            this.dateTimePickerValidFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromDateTime.Name = "dateTimePickerValidFromDateTime";
            this.dateTimePickerValidFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromDateTime.TabIndex = 11;
            this.dateTimePickerValidFromDateTime.Checked = false;
            this.dateTimePickerValidFromDateTime.ShowCheckBox = true;
            //
            // labelValidUntilDateTime
            //
            this.labelValidUntilDateTime.AutoSize = true;
            this.labelValidUntilDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelValidUntilDateTime.Name = "labelValidUntilDateTime";
            this.labelValidUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilDateTime.TabIndex = 12;
            this.labelValidUntilDateTime.Text = "Valid Until Date Time:";
            //
            //dateTimePickerValidUntilDateTime
            //
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(147, 128);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 13;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
            //
            // labelCouponDescription
            //
            this.labelCouponDescription.AutoSize = true;
            this.labelCouponDescription.Location = new System.Drawing.Point(11, 151);
            this.labelCouponDescription.Name = "labelCouponDescription";
            this.labelCouponDescription.Size = new System.Drawing.Size(71, 13);
            this.labelCouponDescription.TabIndex = 14;
            this.labelCouponDescription.Text = "Coupon Description:";
            //
            //textBoxCouponDescription
            //
            this.textBoxCouponDescription.Location = new System.Drawing.Point(147, 151);
            this.textBoxCouponDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCouponDescription.Name = "textBoxCouponDescription";
            this.textBoxCouponDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxCouponDescription.TabIndex = 15;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 174);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 16;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(147, 174);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 17;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 197);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 18;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 197);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 19;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 220);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 220);
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
            this.ClientSize = new System.Drawing.Size(409, 248);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCouponEdit";
            this.Text = "Financial Coupon Edit";
            this.Controls.Add(this.labelFinancialCouponTypeRefCombo);
            this.Controls.Add(this.financialCouponTypeRefCombo);
            this.Controls.Add(this.labelCouponNumber);
            this.Controls.Add(this.maskedTextBoxCouponNumber);
            this.Controls.Add(this.labelValueAmount);
            this.Controls.Add(this.maskedTextBoxValueAmount);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelCouponDescription);
            this.Controls.Add(this.textBoxCouponDescription);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
