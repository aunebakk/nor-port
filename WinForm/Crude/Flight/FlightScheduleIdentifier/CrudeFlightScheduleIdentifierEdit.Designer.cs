namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private FlightIdentifierTypeRefCombo flightIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelFlightIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierCode;
        
        private System.Windows.Forms.Label labelFlightIdentifierCode;
        
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
            this.labelFlightIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.flightIdentifierTypeRefCombo = new FlightIdentifierTypeRefCombo();
            this.labelFlightIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFlightIdentifierTypeRefCombo
            //
            this.labelFlightIdentifierTypeRefCombo.AutoSize = true;
            this.labelFlightIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFlightIdentifierTypeRefCombo.Name = "labelFlightIdentifierTypeRefCombo";
            this.labelFlightIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierTypeRefCombo.TabIndex = 2;
            this.labelFlightIdentifierTypeRefCombo.Text = "Flight Identifier Type:";
            //
            //flightIdentifierTypeRefCombo
            //
            this.flightIdentifierTypeRefCombo.Location = new System.Drawing.Point(154, 13);
            this.flightIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flightIdentifierTypeRefCombo.Name = "flightIdentifierTypeRefCombo";
            this.flightIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.flightIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelFlightIdentifierCode
            //
            this.labelFlightIdentifierCode.AutoSize = true;
            this.labelFlightIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelFlightIdentifierCode.Name = "labelFlightIdentifierCode";
            this.labelFlightIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierCode.TabIndex = 4;
            this.labelFlightIdentifierCode.Text = "Flight Identifier Code:";
            //
            //textBoxFlightIdentifierCode
            //
            this.textBoxFlightIdentifierCode.Location = new System.Drawing.Point(154, 36);
            this.textBoxFlightIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierCode.Name = "textBoxFlightIdentifierCode";
            this.textBoxFlightIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierCode.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(154, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 105);
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
            this.ClientSize = new System.Drawing.Size(416, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFlightScheduleIdentifierEdit";
            this.Text = "Flight Schedule Identifier Edit";
            this.Controls.Add(this.labelFlightIdentifierTypeRefCombo);
            this.Controls.Add(this.flightIdentifierTypeRefCombo);
            this.Controls.Add(this.labelFlightIdentifierCode);
            this.Controls.Add(this.textBoxFlightIdentifierCode);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
