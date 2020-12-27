namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportFacilityTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAirportFacilityType;
        
        private System.Windows.Forms.Label labelAirportFacilityType;
        
        private System.Windows.Forms.TextBox textBoxAirportFacilityTypeName;
        
        private System.Windows.Forms.Label labelAirportFacilityTypeName;
        
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
            this.labelAirportFacilityType = new System.Windows.Forms.Label();
            this.textBoxAirportFacilityType = new System.Windows.Forms.TextBox();
            this.labelAirportFacilityTypeName = new System.Windows.Forms.Label();
            this.textBoxAirportFacilityTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirportFacilityType
            //
            this.labelAirportFacilityType.AutoSize = true;
            this.labelAirportFacilityType.Location = new System.Drawing.Point(11, 13);
            this.labelAirportFacilityType.Name = "labelAirportFacilityType";
            this.labelAirportFacilityType.Size = new System.Drawing.Size(71, 13);
            this.labelAirportFacilityType.TabIndex = 2;
            this.labelAirportFacilityType.Text = "Airport Facility Type:";
            //
            //textBoxAirportFacilityType
            //
            this.textBoxAirportFacilityType.Location = new System.Drawing.Point(182, 13);
            this.textBoxAirportFacilityType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportFacilityType.Name = "textBoxAirportFacilityType";
            this.textBoxAirportFacilityType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportFacilityType.TabIndex = 3;
            //
            // labelAirportFacilityTypeName
            //
            this.labelAirportFacilityTypeName.AutoSize = true;
            this.labelAirportFacilityTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAirportFacilityTypeName.Name = "labelAirportFacilityTypeName";
            this.labelAirportFacilityTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportFacilityTypeName.TabIndex = 4;
            this.labelAirportFacilityTypeName.Text = "Airport Facility Type Name:";
            //
            //textBoxAirportFacilityTypeName
            //
            this.textBoxAirportFacilityTypeName.Location = new System.Drawing.Point(182, 36);
            this.textBoxAirportFacilityTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportFacilityTypeName.Name = "textBoxAirportFacilityTypeName";
            this.textBoxAirportFacilityTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportFacilityTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(240, 82);
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
            this.ClientSize = new System.Drawing.Size(444, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirportFacilityTypeRefEdit";
            this.Text = "Airport Facility Type Ref Edit";
            this.Controls.Add(this.labelAirportFacilityType);
            this.Controls.Add(this.textBoxAirportFacilityType);
            this.Controls.Add(this.labelAirportFacilityTypeName);
            this.Controls.Add(this.textBoxAirportFacilityTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
