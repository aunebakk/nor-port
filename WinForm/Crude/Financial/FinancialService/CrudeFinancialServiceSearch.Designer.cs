namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialServiceSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialServiceSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialServiceAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialServiceEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialService;
        
        private ServiceTypeRefCombo serviceTypeRefCombo;
        
        private System.Windows.Forms.Label labelServiceTypeRefCombo;
        
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
            this.buttonCrudeFinancialServiceAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialServiceEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialServiceSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialService = new System.Windows.Forms.DataGridView();
            this.labelServiceTypeRefCombo = new System.Windows.Forms.Label();
            this.serviceTypeRefCombo = new ServiceTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialService)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceTypeRefCombo
            //
            this.labelServiceTypeRefCombo.AutoSize = true;
            this.labelServiceTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelServiceTypeRefCombo.Name = "labelServiceTypeRefCombo";
            this.labelServiceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceTypeRefCombo.TabIndex = 2;
            this.labelServiceTypeRefCombo.Text = "Service Type:";
            //
            //serviceTypeRefCombo
            //
            this.serviceTypeRefCombo.Location = new System.Drawing.Point(175, 13);
            this.serviceTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceTypeRefCombo.Name = "serviceTypeRefCombo";
            this.serviceTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceTypeRefCombo.TabIndex = 3;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 36);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(175, 36);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
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
            this.financialCurrencyPicker.Location = new System.Drawing.Point(175, 82);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(175, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeFinancialService
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialService.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeFinancialService.Name = "dataGridViewCrudeFinancialService";
            this.dataGridViewCrudeFinancialService.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeFinancialService.TabIndex = 0;
            this.dataGridViewCrudeFinancialService.ReadOnly = true;
            this.dataGridViewCrudeFinancialService.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialService_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialServiceSearch
            // 
            this.buttonCrudeFinancialServiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialServiceSearch.Location = new System.Drawing.Point(233, 241);
            this.buttonCrudeFinancialServiceSearch.Name = "buttonCrudeFinancialServiceSearch";
            this.buttonCrudeFinancialServiceSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialServiceSearch.TabIndex = 2;
            this.buttonCrudeFinancialServiceSearch.Text = "&Search";
            this.buttonCrudeFinancialServiceSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialServiceSearch.Click += new System.EventHandler(this.buttonCrudeFinancialServiceSearch_Click);
            // 
            // buttonCrudeFinancialServiceAdd
            // 
            this.buttonCrudeFinancialServiceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialServiceAdd.Location = new System.Drawing.Point(133, 241);
            this.buttonCrudeFinancialServiceAdd.Name = "buttonCrudeFinancialServiceAdd";
            this.buttonCrudeFinancialServiceAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialServiceAdd.TabIndex = 3;
            this.buttonCrudeFinancialServiceAdd.Text = "&Add";
            this.buttonCrudeFinancialServiceAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialServiceAdd.Click += new System.EventHandler(this.buttonCrudeFinancialServiceAdd_Click);
            // 
            // buttonCrudeFinancialServiceEdit
            // 
            this.buttonCrudeFinancialServiceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialServiceEdit.Location = new System.Drawing.Point(33, 241);
            this.buttonCrudeFinancialServiceEdit.Name = "buttonCrudeFinancialServiceEdit";
            this.buttonCrudeFinancialServiceEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialServiceEdit.TabIndex = 4;
            this.buttonCrudeFinancialServiceEdit.Text = "&Edit";
            this.buttonCrudeFinancialServiceEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialServiceEdit.Click += new System.EventHandler(this.buttonCrudeFinancialServiceEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 269);
            this.Controls.Add(this.buttonCrudeFinancialServiceSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialServiceAdd);
            this.Controls.Add(this.buttonCrudeFinancialServiceEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialService);
            this.Name = "CrudeFinancialServiceSearch";
            this.Text = "Financial Service Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialService)).EndInit();
            this.Controls.Add(this.labelServiceTypeRefCombo);
            this.Controls.Add(this.serviceTypeRefCombo);
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
