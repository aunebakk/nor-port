namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialSpecialServiceSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialSpecialServiceSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialSpecialServiceAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialSpecialServiceEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialSpecialService;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantity;
        
        private System.Windows.Forms.Label labelQuantity;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ServiceSpecialServiceRequestPicker serviceSpecialServiceRequestPicker;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestPicker;
        
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
            this.buttonCrudeFinancialSpecialServiceAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialSpecialServiceEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialSpecialServiceSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialSpecialService = new System.Windows.Forms.DataGridView();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantity = new System.Windows.Forms.MaskedTextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestPicker = new System.Windows.Forms.Label();
            this.serviceSpecialServiceRequestPicker = new ServiceSpecialServiceRequestPicker();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialSpecialService)).BeginInit();
            this.SuspendLayout();
            //
            // labelQuantity
            //
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(11, 13);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(71, 13);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantity:";
            //
            //maskedTextBoxQuantity
            //
            this.maskedTextBoxQuantity.Location = new System.Drawing.Point(217, 13);
            this.maskedTextBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
            this.maskedTextBoxQuantity.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxQuantity.TabIndex = 3;
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
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(217, 36);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelServiceSpecialServiceRequestPicker
            //
            this.labelServiceSpecialServiceRequestPicker.AutoSize = true;
            this.labelServiceSpecialServiceRequestPicker.Location = new System.Drawing.Point(11, 82);
            this.labelServiceSpecialServiceRequestPicker.Name = "labelServiceSpecialServiceRequestPicker";
            this.labelServiceSpecialServiceRequestPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestPicker.TabIndex = 8;
            this.labelServiceSpecialServiceRequestPicker.Text = "Service Special Service Request:";
            //
            //serviceSpecialServiceRequestPicker
            //
            this.serviceSpecialServiceRequestPicker.Location = new System.Drawing.Point(217, 82);
            this.serviceSpecialServiceRequestPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceSpecialServiceRequestPicker.Name = "serviceSpecialServiceRequestPicker";
            this.serviceSpecialServiceRequestPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceSpecialServiceRequestPicker.TabIndex = 9;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 105);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 10;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(217, 105);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 11;
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
            this.userPicker.Location = new System.Drawing.Point(217, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeFinancialSpecialService
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialSpecialService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialSpecialService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialSpecialService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialSpecialService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialSpecialService.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeFinancialSpecialService.Name = "dataGridViewCrudeFinancialSpecialService";
            this.dataGridViewCrudeFinancialSpecialService.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeFinancialSpecialService.TabIndex = 0;
            this.dataGridViewCrudeFinancialSpecialService.ReadOnly = true;
            this.dataGridViewCrudeFinancialSpecialService.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialSpecialService_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialSpecialServiceSearch
            // 
            this.buttonCrudeFinancialSpecialServiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialSpecialServiceSearch.Location = new System.Drawing.Point(275, 264);
            this.buttonCrudeFinancialSpecialServiceSearch.Name = "buttonCrudeFinancialSpecialServiceSearch";
            this.buttonCrudeFinancialSpecialServiceSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialSpecialServiceSearch.TabIndex = 2;
            this.buttonCrudeFinancialSpecialServiceSearch.Text = "&Search";
            this.buttonCrudeFinancialSpecialServiceSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialSpecialServiceSearch.Click += new System.EventHandler(this.buttonCrudeFinancialSpecialServiceSearch_Click);
            // 
            // buttonCrudeFinancialSpecialServiceAdd
            // 
            this.buttonCrudeFinancialSpecialServiceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialSpecialServiceAdd.Location = new System.Drawing.Point(175, 264);
            this.buttonCrudeFinancialSpecialServiceAdd.Name = "buttonCrudeFinancialSpecialServiceAdd";
            this.buttonCrudeFinancialSpecialServiceAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialSpecialServiceAdd.TabIndex = 3;
            this.buttonCrudeFinancialSpecialServiceAdd.Text = "&Add";
            this.buttonCrudeFinancialSpecialServiceAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialSpecialServiceAdd.Click += new System.EventHandler(this.buttonCrudeFinancialSpecialServiceAdd_Click);
            // 
            // buttonCrudeFinancialSpecialServiceEdit
            // 
            this.buttonCrudeFinancialSpecialServiceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialSpecialServiceEdit.Location = new System.Drawing.Point(75, 264);
            this.buttonCrudeFinancialSpecialServiceEdit.Name = "buttonCrudeFinancialSpecialServiceEdit";
            this.buttonCrudeFinancialSpecialServiceEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialSpecialServiceEdit.TabIndex = 4;
            this.buttonCrudeFinancialSpecialServiceEdit.Text = "&Edit";
            this.buttonCrudeFinancialSpecialServiceEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialSpecialServiceEdit.Click += new System.EventHandler(this.buttonCrudeFinancialSpecialServiceEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 292);
            this.Controls.Add(this.buttonCrudeFinancialSpecialServiceSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialSpecialServiceAdd);
            this.Controls.Add(this.buttonCrudeFinancialSpecialServiceEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialSpecialService);
            this.Name = "CrudeFinancialSpecialServiceSearch";
            this.Text = "Financial Special Service Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialSpecialService)).EndInit();
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.maskedTextBoxQuantity);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelServiceSpecialServiceRequestPicker);
            this.Controls.Add(this.serviceSpecialServiceRequestPicker);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
