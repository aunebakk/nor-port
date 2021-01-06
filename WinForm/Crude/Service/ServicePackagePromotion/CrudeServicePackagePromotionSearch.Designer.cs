namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServicePackagePromotionSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServicePackagePromotionSearch;
        
        private System.Windows.Forms.Button buttonCrudeServicePackagePromotionAdd;
        
        private System.Windows.Forms.Button buttonCrudeServicePackagePromotionEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServicePackagePromotion;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPromotionPriceAmount;
        
        private System.Windows.Forms.Label labelPromotionPriceAmount;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ServicePackagePicker servicePackagePicker;
        
        private System.Windows.Forms.Label labelServicePackagePicker;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private ClientPicker clientPicker;
        
        private System.Windows.Forms.Label labelClientPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeServicePackagePromotionAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServicePackagePromotionEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServicePackagePromotionSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServicePackagePromotion = new System.Windows.Forms.DataGridView();
            this.labelPromotionPriceAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxPromotionPriceAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelServicePackagePicker = new System.Windows.Forms.Label();
            this.servicePackagePicker = new ServicePackagePicker();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelClientPicker = new System.Windows.Forms.Label();
            this.clientPicker = new ClientPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServicePackagePromotion)).BeginInit();
            this.SuspendLayout();
            //
            // labelPromotionPriceAmount
            //
            this.labelPromotionPriceAmount.AutoSize = true;
            this.labelPromotionPriceAmount.Location = new System.Drawing.Point(11, 13);
            this.labelPromotionPriceAmount.Name = "labelPromotionPriceAmount";
            this.labelPromotionPriceAmount.Size = new System.Drawing.Size(71, 13);
            this.labelPromotionPriceAmount.TabIndex = 2;
            this.labelPromotionPriceAmount.Text = "Promotion Price Amount:";
            //
            //maskedTextBoxPromotionPriceAmount
            //
            this.maskedTextBoxPromotionPriceAmount.Location = new System.Drawing.Point(154, 13);
            this.maskedTextBoxPromotionPriceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPromotionPriceAmount.Name = "maskedTextBoxPromotionPriceAmount";
            this.maskedTextBoxPromotionPriceAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPromotionPriceAmount.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelServicePackagePicker
            //
            this.labelServicePackagePicker.AutoSize = true;
            this.labelServicePackagePicker.Location = new System.Drawing.Point(11, 59);
            this.labelServicePackagePicker.Name = "labelServicePackagePicker";
            this.labelServicePackagePicker.Size = new System.Drawing.Size(71, 13);
            this.labelServicePackagePicker.TabIndex = 6;
            this.labelServicePackagePicker.Text = "Service Package:";
            //
            //servicePackagePicker
            //
            this.servicePackagePicker.Location = new System.Drawing.Point(154, 59);
            this.servicePackagePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.servicePackagePicker.Name = "servicePackagePicker";
            this.servicePackagePicker.Size = new System.Drawing.Size(250, 20);
            this.servicePackagePicker.TabIndex = 7;
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
            this.financialCurrencyPicker.Location = new System.Drawing.Point(154, 82);
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
            this.userPicker.Location = new System.Drawing.Point(154, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            //
            // labelClientPicker
            //
            this.labelClientPicker.AutoSize = true;
            this.labelClientPicker.Location = new System.Drawing.Point(11, 128);
            this.labelClientPicker.Name = "labelClientPicker";
            this.labelClientPicker.Size = new System.Drawing.Size(71, 13);
            this.labelClientPicker.TabIndex = 12;
            this.labelClientPicker.Text = "Client:";
            //
            //clientPicker
            //
            this.clientPicker.Location = new System.Drawing.Point(154, 128);
            this.clientPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPicker.Name = "clientPicker";
            this.clientPicker.Size = new System.Drawing.Size(250, 20);
            this.clientPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeServicePackagePromotion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServicePackagePromotion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServicePackagePromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServicePackagePromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServicePackagePromotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServicePackagePromotion.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeServicePackagePromotion.Name = "dataGridViewCrudeServicePackagePromotion";
            this.dataGridViewCrudeServicePackagePromotion.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeServicePackagePromotion.TabIndex = 0;
            this.dataGridViewCrudeServicePackagePromotion.ReadOnly = true;
            this.dataGridViewCrudeServicePackagePromotion.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServicePackagePromotion_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServicePackagePromotionSearch
            // 
            this.buttonCrudeServicePackagePromotionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServicePackagePromotionSearch.Location = new System.Drawing.Point(212, 264);
            this.buttonCrudeServicePackagePromotionSearch.Name = "buttonCrudeServicePackagePromotionSearch";
            this.buttonCrudeServicePackagePromotionSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackagePromotionSearch.TabIndex = 2;
            this.buttonCrudeServicePackagePromotionSearch.Text = "&Search";
            this.buttonCrudeServicePackagePromotionSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackagePromotionSearch.Click += new System.EventHandler(this.buttonCrudeServicePackagePromotionSearch_Click);
            // 
            // buttonCrudeServicePackagePromotionAdd
            // 
            this.buttonCrudeServicePackagePromotionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServicePackagePromotionAdd.Location = new System.Drawing.Point(112, 264);
            this.buttonCrudeServicePackagePromotionAdd.Name = "buttonCrudeServicePackagePromotionAdd";
            this.buttonCrudeServicePackagePromotionAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackagePromotionAdd.TabIndex = 3;
            this.buttonCrudeServicePackagePromotionAdd.Text = "&Add";
            this.buttonCrudeServicePackagePromotionAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackagePromotionAdd.Click += new System.EventHandler(this.buttonCrudeServicePackagePromotionAdd_Click);
            // 
            // buttonCrudeServicePackagePromotionEdit
            // 
            this.buttonCrudeServicePackagePromotionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServicePackagePromotionEdit.Location = new System.Drawing.Point(12, 264);
            this.buttonCrudeServicePackagePromotionEdit.Name = "buttonCrudeServicePackagePromotionEdit";
            this.buttonCrudeServicePackagePromotionEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackagePromotionEdit.TabIndex = 4;
            this.buttonCrudeServicePackagePromotionEdit.Text = "&Edit";
            this.buttonCrudeServicePackagePromotionEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackagePromotionEdit.Click += new System.EventHandler(this.buttonCrudeServicePackagePromotionEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 292);
            this.Controls.Add(this.buttonCrudeServicePackagePromotionSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServicePackagePromotionAdd);
            this.Controls.Add(this.buttonCrudeServicePackagePromotionEdit);
            this.Controls.Add(this.dataGridViewCrudeServicePackagePromotion);
            this.Name = "CrudeServicePackagePromotionSearch";
            this.Text = "Service Package Promotion Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServicePackagePromotion)).EndInit();
            this.Controls.Add(this.labelPromotionPriceAmount);
            this.Controls.Add(this.maskedTextBoxPromotionPriceAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelServicePackagePicker);
            this.Controls.Add(this.servicePackagePicker);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelClientPicker);
            this.Controls.Add(this.clientPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
