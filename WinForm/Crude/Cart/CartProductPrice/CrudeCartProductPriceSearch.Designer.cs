namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeCartProductPriceSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeCartProductPriceSearch;
        
        private System.Windows.Forms.Button buttonCrudeCartProductPriceAdd;
        
        private System.Windows.Forms.Button buttonCrudeCartProductPriceEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeCartProductPrice;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
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
            this.buttonCrudeCartProductPriceAdd = new System.Windows.Forms.Button();
            this.buttonCrudeCartProductPriceEdit = new System.Windows.Forms.Button();
            this.buttonCrudeCartProductPriceSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeCartProductPrice = new System.Windows.Forms.DataGridView();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCartProductPrice)).BeginInit();
            this.SuspendLayout();
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 13);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(140, 13);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 3;
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
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(140, 36);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
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
            this.financialCurrencyPicker.Location = new System.Drawing.Point(140, 82);
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
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeCartProductPrice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeCartProductPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeCartProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeCartProductPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeCartProductPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeCartProductPrice.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeCartProductPrice.Name = "dataGridViewCrudeCartProductPrice";
            this.dataGridViewCrudeCartProductPrice.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeCartProductPrice.TabIndex = 0;
            this.dataGridViewCrudeCartProductPrice.ReadOnly = true;
            this.dataGridViewCrudeCartProductPrice.DoubleClick += new System.EventHandler(this.dataGridViewCrudeCartProductPrice_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeCartProductPriceSearch
            // 
            this.buttonCrudeCartProductPriceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartProductPriceSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeCartProductPriceSearch.Name = "buttonCrudeCartProductPriceSearch";
            this.buttonCrudeCartProductPriceSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartProductPriceSearch.TabIndex = 2;
            this.buttonCrudeCartProductPriceSearch.Text = "&Search";
            this.buttonCrudeCartProductPriceSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeCartProductPriceSearch.Click += new System.EventHandler(this.buttonCrudeCartProductPriceSearch_Click);
            // 
            // buttonCrudeCartProductPriceAdd
            // 
            this.buttonCrudeCartProductPriceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartProductPriceAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeCartProductPriceAdd.Name = "buttonCrudeCartProductPriceAdd";
            this.buttonCrudeCartProductPriceAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartProductPriceAdd.TabIndex = 3;
            this.buttonCrudeCartProductPriceAdd.Text = "&Add";
            this.buttonCrudeCartProductPriceAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeCartProductPriceAdd.Click += new System.EventHandler(this.buttonCrudeCartProductPriceAdd_Click);
            // 
            // buttonCrudeCartProductPriceEdit
            // 
            this.buttonCrudeCartProductPriceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartProductPriceEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeCartProductPriceEdit.Name = "buttonCrudeCartProductPriceEdit";
            this.buttonCrudeCartProductPriceEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartProductPriceEdit.TabIndex = 4;
            this.buttonCrudeCartProductPriceEdit.Text = "&Edit";
            this.buttonCrudeCartProductPriceEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeCartProductPriceEdit.Click += new System.EventHandler(this.buttonCrudeCartProductPriceEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeCartProductPriceSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeCartProductPriceAdd);
            this.Controls.Add(this.buttonCrudeCartProductPriceEdit);
            this.Controls.Add(this.dataGridViewCrudeCartProductPrice);
            this.Name = "CrudeCartProductPriceSearch";
            this.Text = "Cart Product Price Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCartProductPrice)).EndInit();
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
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
