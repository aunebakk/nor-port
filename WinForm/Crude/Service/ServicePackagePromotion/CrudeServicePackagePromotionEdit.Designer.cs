namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServicePackagePromotionEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ServicePackagePicker servicePackagePicker;
        
        private System.Windows.Forms.Label labelServicePackagePicker;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPromotionPriceAmount;
        
        private System.Windows.Forms.Label labelPromotionPriceAmount;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ClientPicker clientPicker;
        
        private System.Windows.Forms.Label labelClientPicker;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelServicePackagePicker = new System.Windows.Forms.Label();
            this.servicePackagePicker = new ServicePackagePicker();
            this.labelPromotionPriceAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxPromotionPriceAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelClientPicker = new System.Windows.Forms.Label();
            this.clientPicker = new ClientPicker();
            this.SuspendLayout();
            //
            // labelServicePackagePicker
            //
            this.labelServicePackagePicker.AutoSize = true;
            this.labelServicePackagePicker.Location = new System.Drawing.Point(11, 13);
            this.labelServicePackagePicker.Name = "labelServicePackagePicker";
            this.labelServicePackagePicker.Size = new System.Drawing.Size(71, 13);
            this.labelServicePackagePicker.TabIndex = 2;
            this.labelServicePackagePicker.Text = "Service Package:";
            //
            //servicePackagePicker
            //
            this.servicePackagePicker.Location = new System.Drawing.Point(154, 13);
            this.servicePackagePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.servicePackagePicker.Name = "servicePackagePicker";
            this.servicePackagePicker.Size = new System.Drawing.Size(250, 20);
            this.servicePackagePicker.TabIndex = 3;
            //
            // labelPromotionPriceAmount
            //
            this.labelPromotionPriceAmount.AutoSize = true;
            this.labelPromotionPriceAmount.Location = new System.Drawing.Point(11, 36);
            this.labelPromotionPriceAmount.Name = "labelPromotionPriceAmount";
            this.labelPromotionPriceAmount.Size = new System.Drawing.Size(71, 13);
            this.labelPromotionPriceAmount.TabIndex = 4;
            this.labelPromotionPriceAmount.Text = "Promotion Price Amount:";
            //
            //maskedTextBoxPromotionPriceAmount
            //
            this.maskedTextBoxPromotionPriceAmount.Location = new System.Drawing.Point(154, 36);
            this.maskedTextBoxPromotionPriceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPromotionPriceAmount.Name = "maskedTextBoxPromotionPriceAmount";
            this.maskedTextBoxPromotionPriceAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPromotionPriceAmount.TabIndex = 5;
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
            this.financialCurrencyPicker.Location = new System.Drawing.Point(154, 59);
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
            this.userPicker.Location = new System.Drawing.Point(154, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 151);
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
            this.ClientSize = new System.Drawing.Size(416, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServicePackagePromotionEdit";
            this.Text = "Service Package Promotion Edit";
            this.Controls.Add(this.labelServicePackagePicker);
            this.Controls.Add(this.servicePackagePicker);
            this.Controls.Add(this.labelPromotionPriceAmount);
            this.Controls.Add(this.maskedTextBoxPromotionPriceAmount);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelClientPicker);
            this.Controls.Add(this.clientPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
