namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialCurrencyEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private FinancialCurrencyTypeRefCombo financialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeCode;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeCode;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeName;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeName;
        
        private FinancialCurrencyTypeRefCombo financialCurrencyAgainstFinancialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEqualsAmount;
        
        private System.Windows.Forms.Label labelEqualsAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDecimalCount;
        
        private System.Windows.Forms.Label labelDecimalCount;
        
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
            this.labelFinancialCurrencyTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCurrencyTypeRefCombo = new FinancialCurrencyTypeRefCombo();
            this.labelFinancialCurrencyTypeCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeCode = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo = new FinancialCurrencyTypeRefCombo();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelEqualsAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxEqualsAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDecimalCount = new System.Windows.Forms.Label();
            this.maskedTextBoxDecimalCount = new System.Windows.Forms.MaskedTextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialCurrencyTypeRefCombo
            //
            this.labelFinancialCurrencyTypeRefCombo.AutoSize = true;
            this.labelFinancialCurrencyTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCurrencyTypeRefCombo.Name = "labelFinancialCurrencyTypeRefCombo";
            this.labelFinancialCurrencyTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeRefCombo.TabIndex = 2;
            this.labelFinancialCurrencyTypeRefCombo.Text = "Financial Currency Type:";
            //
            //financialCurrencyTypeRefCombo
            //
            this.financialCurrencyTypeRefCombo.Location = new System.Drawing.Point(350, 13);
            this.financialCurrencyTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyTypeRefCombo.Name = "financialCurrencyTypeRefCombo";
            this.financialCurrencyTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyTypeRefCombo.TabIndex = 3;
            //
            // labelFinancialCurrencyTypeCode
            //
            this.labelFinancialCurrencyTypeCode.AutoSize = true;
            this.labelFinancialCurrencyTypeCode.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCurrencyTypeCode.Name = "labelFinancialCurrencyTypeCode";
            this.labelFinancialCurrencyTypeCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeCode.TabIndex = 4;
            this.labelFinancialCurrencyTypeCode.Text = "Financial Currency Type Code:";
            //
            //textBoxFinancialCurrencyTypeCode
            //
            this.textBoxFinancialCurrencyTypeCode.Location = new System.Drawing.Point(350, 36);
            this.textBoxFinancialCurrencyTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeCode.Name = "textBoxFinancialCurrencyTypeCode";
            this.textBoxFinancialCurrencyTypeCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeCode.TabIndex = 5;
            //
            // labelFinancialCurrencyTypeName
            //
            this.labelFinancialCurrencyTypeName.AutoSize = true;
            this.labelFinancialCurrencyTypeName.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialCurrencyTypeName.Name = "labelFinancialCurrencyTypeName";
            this.labelFinancialCurrencyTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeName.TabIndex = 6;
            this.labelFinancialCurrencyTypeName.Text = "Financial Currency Type Name:";
            //
            //textBoxFinancialCurrencyTypeName
            //
            this.textBoxFinancialCurrencyTypeName.Location = new System.Drawing.Point(350, 59);
            this.textBoxFinancialCurrencyTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeName.Name = "textBoxFinancialCurrencyTypeName";
            this.textBoxFinancialCurrencyTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeName.TabIndex = 7;
            //
            // labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo
            //
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.AutoSize = true;
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Name = "labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo";
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.TabIndex = 8;
            this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = "Financial Currency Against Financial Currency Type:";
            //
            //financialCurrencyAgainstFinancialCurrencyTypeRefCombo
            //
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Location = new System.Drawing.Point(350, 82);
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Name = "financialCurrencyAgainstFinancialCurrencyTypeRefCombo";
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo.TabIndex = 9;
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
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(350, 105);
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
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(350, 128);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 13;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 151);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 14;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(350, 151);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 15;
            //
            // labelEqualsAmount
            //
            this.labelEqualsAmount.AutoSize = true;
            this.labelEqualsAmount.Location = new System.Drawing.Point(11, 174);
            this.labelEqualsAmount.Name = "labelEqualsAmount";
            this.labelEqualsAmount.Size = new System.Drawing.Size(71, 13);
            this.labelEqualsAmount.TabIndex = 16;
            this.labelEqualsAmount.Text = "Equals Amount:";
            //
            //maskedTextBoxEqualsAmount
            //
            this.maskedTextBoxEqualsAmount.Location = new System.Drawing.Point(350, 174);
            this.maskedTextBoxEqualsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxEqualsAmount.Name = "maskedTextBoxEqualsAmount";
            this.maskedTextBoxEqualsAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxEqualsAmount.TabIndex = 17;
            //
            // labelDecimalCount
            //
            this.labelDecimalCount.AutoSize = true;
            this.labelDecimalCount.Location = new System.Drawing.Point(11, 197);
            this.labelDecimalCount.Name = "labelDecimalCount";
            this.labelDecimalCount.Size = new System.Drawing.Size(71, 13);
            this.labelDecimalCount.TabIndex = 18;
            this.labelDecimalCount.Text = "Decimal Count:";
            //
            //maskedTextBoxDecimalCount
            //
            this.maskedTextBoxDecimalCount.Location = new System.Drawing.Point(350, 197);
            this.maskedTextBoxDecimalCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDecimalCount.Name = "maskedTextBoxDecimalCount";
            this.maskedTextBoxDecimalCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDecimalCount.TabIndex = 19;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 220);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 20;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(350, 220);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 21;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 243);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 22;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(350, 243);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 23;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(508, 266);
            
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
            this.buttonSave.Location = new System.Drawing.Point(408, 266);
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
            this.ClientSize = new System.Drawing.Size(612, 294);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCurrencyEdit";
            this.Text = "Financial Currency Edit";
            this.Controls.Add(this.labelFinancialCurrencyTypeRefCombo);
            this.Controls.Add(this.financialCurrencyTypeRefCombo);
            this.Controls.Add(this.labelFinancialCurrencyTypeCode);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeCode);
            this.Controls.Add(this.labelFinancialCurrencyTypeName);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeName);
            this.Controls.Add(this.labelFinancialCurrencyAgainstFinancialCurrencyTypeRefCombo);
            this.Controls.Add(this.financialCurrencyAgainstFinancialCurrencyTypeRefCombo);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelEqualsAmount);
            this.Controls.Add(this.maskedTextBoxEqualsAmount);
            this.Controls.Add(this.labelDecimalCount);
            this.Controls.Add(this.maskedTextBoxDecimalCount);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
