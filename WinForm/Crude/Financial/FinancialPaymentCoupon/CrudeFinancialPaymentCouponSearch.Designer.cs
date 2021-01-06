namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialPaymentCouponSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCouponSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCouponAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCouponEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentCoupon;
        
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
            this.buttonCrudeFinancialPaymentCouponAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCouponEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCouponSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentCoupon = new System.Windows.Forms.DataGridView();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentCoupon)).BeginInit();
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
            // dataGridViewCrudeFinancialPaymentCoupon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentCoupon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentCoupon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentCoupon.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFinancialPaymentCoupon.Name = "dataGridViewCrudeFinancialPaymentCoupon";
            this.dataGridViewCrudeFinancialPaymentCoupon.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialPaymentCoupon.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentCoupon.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentCoupon.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentCoupon_DoubleClick);
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
            // buttonCrudeFinancialPaymentCouponSearch
            // 
            this.buttonCrudeFinancialPaymentCouponSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCouponSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeFinancialPaymentCouponSearch.Name = "buttonCrudeFinancialPaymentCouponSearch";
            this.buttonCrudeFinancialPaymentCouponSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCouponSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentCouponSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentCouponSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCouponSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCouponSearch_Click);
            // 
            // buttonCrudeFinancialPaymentCouponAdd
            // 
            this.buttonCrudeFinancialPaymentCouponAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCouponAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeFinancialPaymentCouponAdd.Name = "buttonCrudeFinancialPaymentCouponAdd";
            this.buttonCrudeFinancialPaymentCouponAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCouponAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentCouponAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentCouponAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCouponAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCouponAdd_Click);
            // 
            // buttonCrudeFinancialPaymentCouponEdit
            // 
            this.buttonCrudeFinancialPaymentCouponEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCouponEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeFinancialPaymentCouponEdit.Name = "buttonCrudeFinancialPaymentCouponEdit";
            this.buttonCrudeFinancialPaymentCouponEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCouponEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentCouponEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentCouponEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCouponEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCouponEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCouponSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCouponAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCouponEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentCoupon);
            this.Name = "CrudeFinancialPaymentCouponSearch";
            this.Text = "Financial Payment Coupon Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentCoupon)).EndInit();
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
