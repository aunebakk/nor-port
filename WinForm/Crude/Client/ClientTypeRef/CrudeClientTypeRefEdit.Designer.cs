namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientType;
        
        private System.Windows.Forms.Label labelClientType;
        
        private System.Windows.Forms.TextBox textBoxClientTypeName;
        
        private System.Windows.Forms.Label labelClientTypeName;
        
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
            this.labelClientType = new System.Windows.Forms.Label();
            this.textBoxClientType = new System.Windows.Forms.TextBox();
            this.labelClientTypeName = new System.Windows.Forms.Label();
            this.textBoxClientTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientType
            //
            this.labelClientType.AutoSize = true;
            this.labelClientType.Location = new System.Drawing.Point(11, 13);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(71, 13);
            this.labelClientType.TabIndex = 2;
            this.labelClientType.Text = "Client Type:";
            //
            //textBoxClientType
            //
            this.textBoxClientType.Location = new System.Drawing.Point(140, 13);
            this.textBoxClientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientType.Name = "textBoxClientType";
            this.textBoxClientType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientType.TabIndex = 3;
            //
            // labelClientTypeName
            //
            this.labelClientTypeName.AutoSize = true;
            this.labelClientTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelClientTypeName.Name = "labelClientTypeName";
            this.labelClientTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeName.TabIndex = 4;
            this.labelClientTypeName.Text = "Client Type Name:";
            //
            //textBoxClientTypeName
            //
            this.textBoxClientTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxClientTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTypeName.Name = "textBoxClientTypeName";
            this.textBoxClientTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTypeName.TabIndex = 5;
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
            this.Name = "CrudeClientTypeRefEdit";
            this.Text = "Client Type Ref Edit";
            this.Controls.Add(this.labelClientType);
            this.Controls.Add(this.textBoxClientType);
            this.Controls.Add(this.labelClientTypeName);
            this.Controls.Add(this.textBoxClientTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
