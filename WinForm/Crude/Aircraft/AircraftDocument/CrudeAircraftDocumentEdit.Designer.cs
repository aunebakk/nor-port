namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftDocumentEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AircraftDocumentTypeRefCombo aircraftDocumentTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftDocumentTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxDocumentName;
        
        private System.Windows.Forms.Label labelDocumentName;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDocumentDateTime;
        
        private System.Windows.Forms.Label labelDocumentDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDateTime;
        
        private System.Windows.Forms.Label labelExpiryDateTime;
        
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
            this.labelAircraftDocumentTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftDocumentTypeRefCombo = new AircraftDocumentTypeRefCombo();
            this.labelDocumentName = new System.Windows.Forms.Label();
            this.textBoxDocumentName = new System.Windows.Forms.TextBox();
            this.labelDocumentDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDocumentDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelExpiryDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerExpiryDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAircraftDocumentTypeRefCombo
            //
            this.labelAircraftDocumentTypeRefCombo.AutoSize = true;
            this.labelAircraftDocumentTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftDocumentTypeRefCombo.Name = "labelAircraftDocumentTypeRefCombo";
            this.labelAircraftDocumentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftDocumentTypeRefCombo.TabIndex = 2;
            this.labelAircraftDocumentTypeRefCombo.Text = "Aircraft Document Type:";
            //
            //aircraftDocumentTypeRefCombo
            //
            this.aircraftDocumentTypeRefCombo.Location = new System.Drawing.Point(154, 13);
            this.aircraftDocumentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftDocumentTypeRefCombo.Name = "aircraftDocumentTypeRefCombo";
            this.aircraftDocumentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftDocumentTypeRefCombo.TabIndex = 3;
            //
            // labelDocumentName
            //
            this.labelDocumentName.AutoSize = true;
            this.labelDocumentName.Location = new System.Drawing.Point(11, 36);
            this.labelDocumentName.Name = "labelDocumentName";
            this.labelDocumentName.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentName.TabIndex = 4;
            this.labelDocumentName.Text = "Document Name:";
            //
            //textBoxDocumentName
            //
            this.textBoxDocumentName.Location = new System.Drawing.Point(154, 36);
            this.textBoxDocumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDocumentName.Name = "textBoxDocumentName";
            this.textBoxDocumentName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumentName.TabIndex = 5;
            //
            // labelDocumentDateTime
            //
            this.labelDocumentDateTime.AutoSize = true;
            this.labelDocumentDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDocumentDateTime.Name = "labelDocumentDateTime";
            this.labelDocumentDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentDateTime.TabIndex = 6;
            this.labelDocumentDateTime.Text = "Document Date Time:";
            //
            //dateTimePickerDocumentDateTime
            //
            this.dateTimePickerDocumentDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDocumentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDocumentDateTime.Name = "dateTimePickerDocumentDateTime";
            this.dateTimePickerDocumentDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDocumentDateTime.TabIndex = 7;
            this.dateTimePickerDocumentDateTime.Checked = false;
            this.dateTimePickerDocumentDateTime.ShowCheckBox = true;
            //
            // labelExpiryDateTime
            //
            this.labelExpiryDateTime.AutoSize = true;
            this.labelExpiryDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelExpiryDateTime.Name = "labelExpiryDateTime";
            this.labelExpiryDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryDateTime.TabIndex = 8;
            this.labelExpiryDateTime.Text = "Expiry Date Time:";
            //
            //dateTimePickerExpiryDateTime
            //
            this.dateTimePickerExpiryDateTime.Location = new System.Drawing.Point(154, 82);
            this.dateTimePickerExpiryDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerExpiryDateTime.Name = "dateTimePickerExpiryDateTime";
            this.dateTimePickerExpiryDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerExpiryDateTime.TabIndex = 9;
            this.dateTimePickerExpiryDateTime.Checked = false;
            this.dateTimePickerExpiryDateTime.ShowCheckBox = true;
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
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
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
            this.Name = "CrudeAircraftDocumentEdit";
            this.Text = "Aircraft Document Edit";
            this.Controls.Add(this.labelAircraftDocumentTypeRefCombo);
            this.Controls.Add(this.aircraftDocumentTypeRefCombo);
            this.Controls.Add(this.labelDocumentName);
            this.Controls.Add(this.textBoxDocumentName);
            this.Controls.Add(this.labelDocumentDateTime);
            this.Controls.Add(this.dateTimePickerDocumentDateTime);
            this.Controls.Add(this.labelExpiryDateTime);
            this.Controls.Add(this.dateTimePickerExpiryDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
