namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAirportType;
        
        private System.Windows.Forms.Label labelAirportType;
        
        private System.Windows.Forms.TextBox textBoxAirportTypeName;
        
        private System.Windows.Forms.Label labelAirportTypeName;
        
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
            this.labelAirportType = new System.Windows.Forms.Label();
            this.textBoxAirportType = new System.Windows.Forms.TextBox();
            this.labelAirportTypeName = new System.Windows.Forms.Label();
            this.textBoxAirportTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirportType
            //
            this.labelAirportType.AutoSize = true;
            this.labelAirportType.Location = new System.Drawing.Point(11, 13);
            this.labelAirportType.Name = "labelAirportType";
            this.labelAirportType.Size = new System.Drawing.Size(71, 13);
            this.labelAirportType.TabIndex = 2;
            this.labelAirportType.Text = "Airport Type:";
            //
            //textBoxAirportType
            //
            this.textBoxAirportType.Location = new System.Drawing.Point(140, 13);
            this.textBoxAirportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportType.Name = "textBoxAirportType";
            this.textBoxAirportType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportType.TabIndex = 3;
            //
            // labelAirportTypeName
            //
            this.labelAirportTypeName.AutoSize = true;
            this.labelAirportTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAirportTypeName.Name = "labelAirportTypeName";
            this.labelAirportTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportTypeName.TabIndex = 4;
            this.labelAirportTypeName.Text = "Airport Type Name:";
            //
            //textBoxAirportTypeName
            //
            this.textBoxAirportTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxAirportTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportTypeName.Name = "textBoxAirportTypeName";
            this.textBoxAirportTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportTypeName.TabIndex = 5;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 82);
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
            this.ClientSize = new System.Drawing.Size(402, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirportTypeRefEdit";
            this.Text = "Airport Type Ref Edit";
            this.Controls.Add(this.labelAirportType);
            this.Controls.Add(this.textBoxAirportType);
            this.Controls.Add(this.labelAirportTypeName);
            this.Controls.Add(this.textBoxAirportTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
