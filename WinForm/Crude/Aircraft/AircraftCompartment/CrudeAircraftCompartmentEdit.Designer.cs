namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftCompartmentEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AircraftCompartmentTypeRefCombo aircraftCompartmentTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftCompartmentTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAircraftCompartmentName;
        
        private System.Windows.Forms.Label labelAircraftCompartmentName;
        
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
            this.labelAircraftCompartmentTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftCompartmentTypeRefCombo = new AircraftCompartmentTypeRefCombo();
            this.labelAircraftCompartmentName = new System.Windows.Forms.Label();
            this.textBoxAircraftCompartmentName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAircraftCompartmentTypeRefCombo
            //
            this.labelAircraftCompartmentTypeRefCombo.AutoSize = true;
            this.labelAircraftCompartmentTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftCompartmentTypeRefCombo.Name = "labelAircraftCompartmentTypeRefCombo";
            this.labelAircraftCompartmentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentTypeRefCombo.TabIndex = 2;
            this.labelAircraftCompartmentTypeRefCombo.Text = "Aircraft Compartment Type:";
            //
            //aircraftCompartmentTypeRefCombo
            //
            this.aircraftCompartmentTypeRefCombo.Location = new System.Drawing.Point(224, 13);
            this.aircraftCompartmentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftCompartmentTypeRefCombo.Name = "aircraftCompartmentTypeRefCombo";
            this.aircraftCompartmentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftCompartmentTypeRefCombo.TabIndex = 3;
            //
            // labelAircraftCompartmentName
            //
            this.labelAircraftCompartmentName.AutoSize = true;
            this.labelAircraftCompartmentName.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftCompartmentName.Name = "labelAircraftCompartmentName";
            this.labelAircraftCompartmentName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentName.TabIndex = 4;
            this.labelAircraftCompartmentName.Text = "Aircraft Compartment Name:";
            //
            //textBoxAircraftCompartmentName
            //
            this.textBoxAircraftCompartmentName.Location = new System.Drawing.Point(224, 36);
            this.textBoxAircraftCompartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftCompartmentName.Name = "textBoxAircraftCompartmentName";
            this.textBoxAircraftCompartmentName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftCompartmentName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(224, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(282, 105);
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
            this.ClientSize = new System.Drawing.Size(486, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAircraftCompartmentEdit";
            this.Text = "Aircraft Compartment Edit";
            this.Controls.Add(this.labelAircraftCompartmentTypeRefCombo);
            this.Controls.Add(this.aircraftCompartmentTypeRefCombo);
            this.Controls.Add(this.labelAircraftCompartmentName);
            this.Controls.Add(this.textBoxAircraftCompartmentName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
