namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialBookingTransactionTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialBookingTransactionType;
        
        private System.Windows.Forms.Label labelFinancialBookingTransactionType;
        
        private System.Windows.Forms.TextBox textBoxFinancialBookingTransactionTypeName;
        
        private System.Windows.Forms.Label labelFinancialBookingTransactionTypeName;
        
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
            this.labelFinancialBookingTransactionType = new System.Windows.Forms.Label();
            this.textBoxFinancialBookingTransactionType = new System.Windows.Forms.TextBox();
            this.labelFinancialBookingTransactionTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialBookingTransactionTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialBookingTransactionType
            //
            this.labelFinancialBookingTransactionType.AutoSize = true;
            this.labelFinancialBookingTransactionType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialBookingTransactionType.Name = "labelFinancialBookingTransactionType";
            this.labelFinancialBookingTransactionType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBookingTransactionType.TabIndex = 2;
            this.labelFinancialBookingTransactionType.Text = "Financial Booking Transaction Type:";
            //
            //textBoxFinancialBookingTransactionType
            //
            this.textBoxFinancialBookingTransactionType.Location = new System.Drawing.Point(273, 13);
            this.textBoxFinancialBookingTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBookingTransactionType.Name = "textBoxFinancialBookingTransactionType";
            this.textBoxFinancialBookingTransactionType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBookingTransactionType.TabIndex = 3;
            //
            // labelFinancialBookingTransactionTypeName
            //
            this.labelFinancialBookingTransactionTypeName.AutoSize = true;
            this.labelFinancialBookingTransactionTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialBookingTransactionTypeName.Name = "labelFinancialBookingTransactionTypeName";
            this.labelFinancialBookingTransactionTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBookingTransactionTypeName.TabIndex = 4;
            this.labelFinancialBookingTransactionTypeName.Text = "Financial Booking Transaction Type Name:";
            //
            //textBoxFinancialBookingTransactionTypeName
            //
            this.textBoxFinancialBookingTransactionTypeName.Location = new System.Drawing.Point(273, 36);
            this.textBoxFinancialBookingTransactionTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBookingTransactionTypeName.Name = "textBoxFinancialBookingTransactionTypeName";
            this.textBoxFinancialBookingTransactionTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBookingTransactionTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(273, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(431, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(331, 82);
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
            this.ClientSize = new System.Drawing.Size(535, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialBookingTransactionTypeRefEdit";
            this.Text = "Financial Booking Transaction Type Ref Edit";
            this.Controls.Add(this.labelFinancialBookingTransactionType);
            this.Controls.Add(this.textBoxFinancialBookingTransactionType);
            this.Controls.Add(this.labelFinancialBookingTransactionTypeName);
            this.Controls.Add(this.textBoxFinancialBookingTransactionTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
