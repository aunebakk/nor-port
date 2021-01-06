namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightIdentifierTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierType;
        
        private System.Windows.Forms.Label labelFlightIdentifierType;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierTypeName;
        
        private System.Windows.Forms.Label labelFlightIdentifierTypeName;
        
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
            this.labelFlightIdentifierType = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierType = new System.Windows.Forms.TextBox();
            this.labelFlightIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFlightIdentifierType
            //
            this.labelFlightIdentifierType.AutoSize = true;
            this.labelFlightIdentifierType.Location = new System.Drawing.Point(11, 13);
            this.labelFlightIdentifierType.Name = "labelFlightIdentifierType";
            this.labelFlightIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierType.TabIndex = 2;
            this.labelFlightIdentifierType.Text = "Flight Identifier Type:";
            //
            //textBoxFlightIdentifierType
            //
            this.textBoxFlightIdentifierType.Location = new System.Drawing.Point(189, 13);
            this.textBoxFlightIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierType.Name = "textBoxFlightIdentifierType";
            this.textBoxFlightIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierType.TabIndex = 3;
            //
            // labelFlightIdentifierTypeName
            //
            this.labelFlightIdentifierTypeName.AutoSize = true;
            this.labelFlightIdentifierTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFlightIdentifierTypeName.Name = "labelFlightIdentifierTypeName";
            this.labelFlightIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierTypeName.TabIndex = 4;
            this.labelFlightIdentifierTypeName.Text = "Flight Identifier Type Name:";
            //
            //textBoxFlightIdentifierTypeName
            //
            this.textBoxFlightIdentifierTypeName.Location = new System.Drawing.Point(189, 36);
            this.textBoxFlightIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierTypeName.Name = "textBoxFlightIdentifierTypeName";
            this.textBoxFlightIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 82);
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
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFlightIdentifierTypeRefEdit";
            this.Text = "Flight Identifier Type Ref Edit";
            this.Controls.Add(this.labelFlightIdentifierType);
            this.Controls.Add(this.textBoxFlightIdentifierType);
            this.Controls.Add(this.labelFlightIdentifierTypeName);
            this.Controls.Add(this.textBoxFlightIdentifierTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
