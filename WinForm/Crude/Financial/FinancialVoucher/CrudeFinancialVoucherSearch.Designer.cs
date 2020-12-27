namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialVoucherSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialVoucher;
        
        private FinancialVoucherTypeRefCombo financialVoucherTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialVoucherTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxVoucherDescription;
        
        private System.Windows.Forms.Label labelVoucherDescription;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVoucherNumber;
        
        private System.Windows.Forms.Label labelVoucherNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValueAmount;
        
        private System.Windows.Forms.Label labelValueAmount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialVoucher = new System.Windows.Forms.DataGridView();
            this.labelFinancialVoucherTypeRefCombo = new System.Windows.Forms.Label();
            this.financialVoucherTypeRefCombo = new FinancialVoucherTypeRefCombo();
            this.labelVoucherDescription = new System.Windows.Forms.Label();
            this.textBoxVoucherDescription = new System.Windows.Forms.TextBox();
            this.labelVoucherNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxVoucherNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelValueAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxValueAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialVoucher)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialVoucherTypeRefCombo
            //
            this.labelFinancialVoucherTypeRefCombo.AutoSize = true;
            this.labelFinancialVoucherTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialVoucherTypeRefCombo.Name = "labelFinancialVoucherTypeRefCombo";
            this.labelFinancialVoucherTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherTypeRefCombo.TabIndex = 2;
            this.labelFinancialVoucherTypeRefCombo.Text = "Financial Voucher Type:";
            //
            //financialVoucherTypeRefCombo
            //
            this.financialVoucherTypeRefCombo.Location = new System.Drawing.Point(154, 13);
            this.financialVoucherTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialVoucherTypeRefCombo.Name = "financialVoucherTypeRefCombo";
            this.financialVoucherTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialVoucherTypeRefCombo.TabIndex = 3;
            //
            // labelVoucherDescription
            //
            this.labelVoucherDescription.AutoSize = true;
            this.labelVoucherDescription.Location = new System.Drawing.Point(11, 36);
            this.labelVoucherDescription.Name = "labelVoucherDescription";
            this.labelVoucherDescription.Size = new System.Drawing.Size(71, 13);
            this.labelVoucherDescription.TabIndex = 4;
            this.labelVoucherDescription.Text = "Voucher Description:";
            //
            //textBoxVoucherDescription
            //
            this.textBoxVoucherDescription.Location = new System.Drawing.Point(154, 36);
            this.textBoxVoucherDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVoucherDescription.Name = "textBoxVoucherDescription";
            this.textBoxVoucherDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxVoucherDescription.TabIndex = 5;
            //
            // labelVoucherNumber
            //
            this.labelVoucherNumber.AutoSize = true;
            this.labelVoucherNumber.Location = new System.Drawing.Point(11, 59);
            this.labelVoucherNumber.Name = "labelVoucherNumber";
            this.labelVoucherNumber.Size = new System.Drawing.Size(71, 13);
            this.labelVoucherNumber.TabIndex = 6;
            this.labelVoucherNumber.Text = "Voucher Number:";
            //
            //maskedTextBoxVoucherNumber
            //
            this.maskedTextBoxVoucherNumber.Location = new System.Drawing.Point(154, 59);
            this.maskedTextBoxVoucherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxVoucherNumber.Name = "maskedTextBoxVoucherNumber";
            this.maskedTextBoxVoucherNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxVoucherNumber.TabIndex = 7;
            //
            // labelValueAmount
            //
            this.labelValueAmount.AutoSize = true;
            this.labelValueAmount.Location = new System.Drawing.Point(11, 82);
            this.labelValueAmount.Name = "labelValueAmount";
            this.labelValueAmount.Size = new System.Drawing.Size(71, 13);
            this.labelValueAmount.TabIndex = 8;
            this.labelValueAmount.Text = "Value Amount:";
            //
            //maskedTextBoxValueAmount
            //
            this.maskedTextBoxValueAmount.Location = new System.Drawing.Point(154, 82);
            this.maskedTextBoxValueAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxValueAmount.Name = "maskedTextBoxValueAmount";
            this.maskedTextBoxValueAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxValueAmount.TabIndex = 9;
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
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(154, 105);
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
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(154, 128);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 13;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 174);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 16;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(154, 174);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 17;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 197);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 18;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(154, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            // 
            // dataGridViewCrudeFinancialVoucher
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialVoucher.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewCrudeFinancialVoucher.Name = "dataGridViewCrudeFinancialVoucher";
            this.dataGridViewCrudeFinancialVoucher.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeFinancialVoucher.TabIndex = 0;
            this.dataGridViewCrudeFinancialVoucher.ReadOnly = true;
            this.dataGridViewCrudeFinancialVoucher.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialVoucher_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 333);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialVoucherSearch
            // 
            this.buttonCrudeFinancialVoucherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherSearch.Location = new System.Drawing.Point(212, 333);
            this.buttonCrudeFinancialVoucherSearch.Name = "buttonCrudeFinancialVoucherSearch";
            this.buttonCrudeFinancialVoucherSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherSearch.TabIndex = 2;
            this.buttonCrudeFinancialVoucherSearch.Text = "&Search";
            this.buttonCrudeFinancialVoucherSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherSearch.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherSearch_Click);
            // 
            // buttonCrudeFinancialVoucherAdd
            // 
            this.buttonCrudeFinancialVoucherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherAdd.Location = new System.Drawing.Point(112, 333);
            this.buttonCrudeFinancialVoucherAdd.Name = "buttonCrudeFinancialVoucherAdd";
            this.buttonCrudeFinancialVoucherAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherAdd.TabIndex = 3;
            this.buttonCrudeFinancialVoucherAdd.Text = "&Add";
            this.buttonCrudeFinancialVoucherAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherAdd.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherAdd_Click);
            // 
            // buttonCrudeFinancialVoucherEdit
            // 
            this.buttonCrudeFinancialVoucherEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherEdit.Location = new System.Drawing.Point(12, 333);
            this.buttonCrudeFinancialVoucherEdit.Name = "buttonCrudeFinancialVoucherEdit";
            this.buttonCrudeFinancialVoucherEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherEdit.TabIndex = 4;
            this.buttonCrudeFinancialVoucherEdit.Text = "&Edit";
            this.buttonCrudeFinancialVoucherEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherEdit.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 361);
            this.Controls.Add(this.buttonCrudeFinancialVoucherSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialVoucherAdd);
            this.Controls.Add(this.buttonCrudeFinancialVoucherEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialVoucher);
            this.Name = "CrudeFinancialVoucherSearch";
            this.Text = "Financial Voucher Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialVoucher)).EndInit();
            this.Controls.Add(this.labelFinancialVoucherTypeRefCombo);
            this.Controls.Add(this.financialVoucherTypeRefCombo);
            this.Controls.Add(this.labelVoucherDescription);
            this.Controls.Add(this.textBoxVoucherDescription);
            this.Controls.Add(this.labelVoucherNumber);
            this.Controls.Add(this.maskedTextBoxVoucherNumber);
            this.Controls.Add(this.labelValueAmount);
            this.Controls.Add(this.maskedTextBoxValueAmount);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
