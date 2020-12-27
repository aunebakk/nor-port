namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportSupplierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAiportSupplierName;
        
        private System.Windows.Forms.Label labelAiportSupplierName;
        
        private System.Windows.Forms.TextBox textBoxAirportSupplierCode;
        
        private System.Windows.Forms.Label labelAirportSupplierCode;
        
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
            this.labelAiportSupplierName = new System.Windows.Forms.Label();
            this.textBoxAiportSupplierName = new System.Windows.Forms.TextBox();
            this.labelAirportSupplierCode = new System.Windows.Forms.Label();
            this.textBoxAirportSupplierCode = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAiportSupplierName
            //
            this.labelAiportSupplierName.AutoSize = true;
            this.labelAiportSupplierName.Location = new System.Drawing.Point(11, 13);
            this.labelAiportSupplierName.Name = "labelAiportSupplierName";
            this.labelAiportSupplierName.Size = new System.Drawing.Size(71, 13);
            this.labelAiportSupplierName.TabIndex = 2;
            this.labelAiportSupplierName.Text = "Aiport Supplier Name:";
            //
            //textBoxAiportSupplierName
            //
            this.textBoxAiportSupplierName.Location = new System.Drawing.Point(147, 13);
            this.textBoxAiportSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAiportSupplierName.Name = "textBoxAiportSupplierName";
            this.textBoxAiportSupplierName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAiportSupplierName.TabIndex = 3;
            //
            // labelAirportSupplierCode
            //
            this.labelAirportSupplierCode.AutoSize = true;
            this.labelAirportSupplierCode.Location = new System.Drawing.Point(11, 36);
            this.labelAirportSupplierCode.Name = "labelAirportSupplierCode";
            this.labelAirportSupplierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAirportSupplierCode.TabIndex = 4;
            this.labelAirportSupplierCode.Text = "Airport Supplier Code:";
            //
            //textBoxAirportSupplierCode
            //
            this.textBoxAirportSupplierCode.Location = new System.Drawing.Point(147, 36);
            this.textBoxAirportSupplierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportSupplierCode.Name = "textBoxAirportSupplierCode";
            this.textBoxAirportSupplierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportSupplierCode.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(147, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 105);
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
            this.ClientSize = new System.Drawing.Size(409, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirportSupplierEdit";
            this.Text = "Airport Supplier Edit";
            this.Controls.Add(this.labelAiportSupplierName);
            this.Controls.Add(this.textBoxAiportSupplierName);
            this.Controls.Add(this.labelAirportSupplierCode);
            this.Controls.Add(this.textBoxAirportSupplierCode);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
