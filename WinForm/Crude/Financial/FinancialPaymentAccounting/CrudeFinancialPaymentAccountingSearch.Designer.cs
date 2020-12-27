namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialPaymentAccountingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentAccountingSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentAccountingAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentAccountingEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentAccounting;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
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
            this.buttonCrudeFinancialPaymentAccountingAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentAccountingEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentAccountingSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentAccounting = new System.Windows.Forms.DataGridView();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentAccounting)).BeginInit();
            this.SuspendLayout();
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 13);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(140, 13);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 6;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(140, 59);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeFinancialPaymentAccounting
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentAccounting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentAccounting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentAccounting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentAccounting.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFinancialPaymentAccounting.Name = "dataGridViewCrudeFinancialPaymentAccounting";
            this.dataGridViewCrudeFinancialPaymentAccounting.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialPaymentAccounting.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentAccounting.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentAccounting.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentAccounting_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialPaymentAccountingSearch
            // 
            this.buttonCrudeFinancialPaymentAccountingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentAccountingSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeFinancialPaymentAccountingSearch.Name = "buttonCrudeFinancialPaymentAccountingSearch";
            this.buttonCrudeFinancialPaymentAccountingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentAccountingSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentAccountingSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentAccountingSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentAccountingSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentAccountingSearch_Click);
            // 
            // buttonCrudeFinancialPaymentAccountingAdd
            // 
            this.buttonCrudeFinancialPaymentAccountingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentAccountingAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeFinancialPaymentAccountingAdd.Name = "buttonCrudeFinancialPaymentAccountingAdd";
            this.buttonCrudeFinancialPaymentAccountingAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentAccountingAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentAccountingAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentAccountingAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentAccountingAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentAccountingAdd_Click);
            // 
            // buttonCrudeFinancialPaymentAccountingEdit
            // 
            this.buttonCrudeFinancialPaymentAccountingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentAccountingEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeFinancialPaymentAccountingEdit.Name = "buttonCrudeFinancialPaymentAccountingEdit";
            this.buttonCrudeFinancialPaymentAccountingEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentAccountingEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentAccountingEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentAccountingEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentAccountingEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentAccountingEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeFinancialPaymentAccountingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentAccountingAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentAccountingEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentAccounting);
            this.Name = "CrudeFinancialPaymentAccountingSearch";
            this.Text = "Financial Payment Accounting Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentAccounting)).EndInit();
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
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
