namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAddressTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAddressType;
        
        private System.Windows.Forms.Label labelAddressType;
        
        private System.Windows.Forms.TextBox textBoxAddressTypeName;
        
        private System.Windows.Forms.Label labelAddressTypeName;
        
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
            this.labelAddressType = new System.Windows.Forms.Label();
            this.textBoxAddressType = new System.Windows.Forms.TextBox();
            this.labelAddressTypeName = new System.Windows.Forms.Label();
            this.textBoxAddressTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAddressType
            //
            this.labelAddressType.AutoSize = true;
            this.labelAddressType.Location = new System.Drawing.Point(11, 13);
            this.labelAddressType.Name = "labelAddressType";
            this.labelAddressType.Size = new System.Drawing.Size(71, 13);
            this.labelAddressType.TabIndex = 2;
            this.labelAddressType.Text = "Address Type:";
            //
            //textBoxAddressType
            //
            this.textBoxAddressType.Location = new System.Drawing.Point(140, 13);
            this.textBoxAddressType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressType.Name = "textBoxAddressType";
            this.textBoxAddressType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressType.TabIndex = 3;
            //
            // labelAddressTypeName
            //
            this.labelAddressTypeName.AutoSize = true;
            this.labelAddressTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAddressTypeName.Name = "labelAddressTypeName";
            this.labelAddressTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAddressTypeName.TabIndex = 4;
            this.labelAddressTypeName.Text = "Address Type Name:";
            //
            //textBoxAddressTypeName
            //
            this.textBoxAddressTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxAddressTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressTypeName.Name = "textBoxAddressTypeName";
            this.textBoxAddressTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressTypeName.TabIndex = 5;
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
            this.Name = "CrudeAddressTypeRefEdit";
            this.Text = "Address Type Ref Edit";
            this.Controls.Add(this.labelAddressType);
            this.Controls.Add(this.textBoxAddressType);
            this.Controls.Add(this.labelAddressTypeName);
            this.Controls.Add(this.textBoxAddressTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
