namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportIdentifierTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAirportIdentifierType;
        
        private System.Windows.Forms.Label labelAirportIdentifierType;
        
        private System.Windows.Forms.TextBox textBoxAirportIdentifierTypeName;
        
        private System.Windows.Forms.Label labelAirportIdentifierTypeName;
        
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
            this.labelAirportIdentifierType = new System.Windows.Forms.Label();
            this.textBoxAirportIdentifierType = new System.Windows.Forms.TextBox();
            this.labelAirportIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxAirportIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirportIdentifierType
            //
            this.labelAirportIdentifierType.AutoSize = true;
            this.labelAirportIdentifierType.Location = new System.Drawing.Point(11, 13);
            this.labelAirportIdentifierType.Name = "labelAirportIdentifierType";
            this.labelAirportIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierType.TabIndex = 2;
            this.labelAirportIdentifierType.Text = "Airport Identifier Type:";
            //
            //textBoxAirportIdentifierType
            //
            this.textBoxAirportIdentifierType.Location = new System.Drawing.Point(196, 13);
            this.textBoxAirportIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportIdentifierType.Name = "textBoxAirportIdentifierType";
            this.textBoxAirportIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportIdentifierType.TabIndex = 3;
            //
            // labelAirportIdentifierTypeName
            //
            this.labelAirportIdentifierTypeName.AutoSize = true;
            this.labelAirportIdentifierTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAirportIdentifierTypeName.Name = "labelAirportIdentifierTypeName";
            this.labelAirportIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierTypeName.TabIndex = 4;
            this.labelAirportIdentifierTypeName.Text = "Airport Identifier Type Name:";
            //
            //textBoxAirportIdentifierTypeName
            //
            this.textBoxAirportIdentifierTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxAirportIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportIdentifierTypeName.Name = "textBoxAirportIdentifierTypeName";
            this.textBoxAirportIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportIdentifierTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(254, 82);
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
            this.ClientSize = new System.Drawing.Size(458, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirportIdentifierTypeRefEdit";
            this.Text = "Airport Identifier Type Ref Edit";
            this.Controls.Add(this.labelAirportIdentifierType);
            this.Controls.Add(this.textBoxAirportIdentifierType);
            this.Controls.Add(this.labelAirportIdentifierTypeName);
            this.Controls.Add(this.textBoxAirportIdentifierTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
