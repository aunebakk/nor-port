namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceImageTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxServiceImageType;
        
        private System.Windows.Forms.Label labelServiceImageType;
        
        private System.Windows.Forms.TextBox textBoxServiceImageTypeName;
        
        private System.Windows.Forms.Label labelServiceImageTypeName;
        
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
            this.labelServiceImageType = new System.Windows.Forms.Label();
            this.textBoxServiceImageType = new System.Windows.Forms.TextBox();
            this.labelServiceImageTypeName = new System.Windows.Forms.Label();
            this.textBoxServiceImageTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceImageType
            //
            this.labelServiceImageType.AutoSize = true;
            this.labelServiceImageType.Location = new System.Drawing.Point(11, 13);
            this.labelServiceImageType.Name = "labelServiceImageType";
            this.labelServiceImageType.Size = new System.Drawing.Size(71, 13);
            this.labelServiceImageType.TabIndex = 2;
            this.labelServiceImageType.Text = "Service Image Type:";
            //
            //textBoxServiceImageType
            //
            this.textBoxServiceImageType.Location = new System.Drawing.Point(161, 13);
            this.textBoxServiceImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceImageType.Name = "textBoxServiceImageType";
            this.textBoxServiceImageType.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceImageType.TabIndex = 3;
            //
            // labelServiceImageTypeName
            //
            this.labelServiceImageTypeName.AutoSize = true;
            this.labelServiceImageTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelServiceImageTypeName.Name = "labelServiceImageTypeName";
            this.labelServiceImageTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceImageTypeName.TabIndex = 4;
            this.labelServiceImageTypeName.Text = "Service Image Type Name:";
            //
            //textBoxServiceImageTypeName
            //
            this.textBoxServiceImageTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxServiceImageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceImageTypeName.Name = "textBoxServiceImageTypeName";
            this.textBoxServiceImageTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceImageTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 82);
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
            this.ClientSize = new System.Drawing.Size(423, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServiceImageTypeRefEdit";
            this.Text = "Service Image Type Ref Edit";
            this.Controls.Add(this.labelServiceImageType);
            this.Controls.Add(this.textBoxServiceImageType);
            this.Controls.Add(this.labelServiceImageTypeName);
            this.Controls.Add(this.textBoxServiceImageTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
