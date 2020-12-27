namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineIdentifierTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAirlineIdentifierType;
        
        private System.Windows.Forms.Label labelAirlineIdentifierType;
        
        private System.Windows.Forms.TextBox textBoxAirlineIdentifierTypeName;
        
        private System.Windows.Forms.Label labelAirlineIdentifierTypeName;
        
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
            this.labelAirlineIdentifierType = new System.Windows.Forms.Label();
            this.textBoxAirlineIdentifierType = new System.Windows.Forms.TextBox();
            this.labelAirlineIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxAirlineIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirlineIdentifierType
            //
            this.labelAirlineIdentifierType.AutoSize = true;
            this.labelAirlineIdentifierType.Location = new System.Drawing.Point(11, 13);
            this.labelAirlineIdentifierType.Name = "labelAirlineIdentifierType";
            this.labelAirlineIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierType.TabIndex = 2;
            this.labelAirlineIdentifierType.Text = "Airline Identifier Type:";
            //
            //textBoxAirlineIdentifierType
            //
            this.textBoxAirlineIdentifierType.Location = new System.Drawing.Point(196, 13);
            this.textBoxAirlineIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineIdentifierType.Name = "textBoxAirlineIdentifierType";
            this.textBoxAirlineIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineIdentifierType.TabIndex = 3;
            //
            // labelAirlineIdentifierTypeName
            //
            this.labelAirlineIdentifierTypeName.AutoSize = true;
            this.labelAirlineIdentifierTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAirlineIdentifierTypeName.Name = "labelAirlineIdentifierTypeName";
            this.labelAirlineIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierTypeName.TabIndex = 4;
            this.labelAirlineIdentifierTypeName.Text = "Airline Identifier Type Name:";
            //
            //textBoxAirlineIdentifierTypeName
            //
            this.textBoxAirlineIdentifierTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxAirlineIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineIdentifierTypeName.Name = "textBoxAirlineIdentifierTypeName";
            this.textBoxAirlineIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineIdentifierTypeName.TabIndex = 5;
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
            this.Name = "CrudeAirlineIdentifierTypeRefEdit";
            this.Text = "Airline Identifier Type Ref Edit";
            this.Controls.Add(this.labelAirlineIdentifierType);
            this.Controls.Add(this.textBoxAirlineIdentifierType);
            this.Controls.Add(this.labelAirlineIdentifierTypeName);
            this.Controls.Add(this.textBoxAirlineIdentifierTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
