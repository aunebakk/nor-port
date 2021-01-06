namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingDocumentTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxBookingDocumentType;
        
        private System.Windows.Forms.Label labelBookingDocumentType;
        
        private System.Windows.Forms.TextBox textBoxBookingDocumentTypeName;
        
        private System.Windows.Forms.Label labelBookingDocumentTypeName;
        
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
            this.labelBookingDocumentType = new System.Windows.Forms.Label();
            this.textBoxBookingDocumentType = new System.Windows.Forms.TextBox();
            this.labelBookingDocumentTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingDocumentTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingDocumentType
            //
            this.labelBookingDocumentType.AutoSize = true;
            this.labelBookingDocumentType.Location = new System.Drawing.Point(11, 13);
            this.labelBookingDocumentType.Name = "labelBookingDocumentType";
            this.labelBookingDocumentType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentType.TabIndex = 2;
            this.labelBookingDocumentType.Text = "Booking Document Type:";
            //
            //textBoxBookingDocumentType
            //
            this.textBoxBookingDocumentType.Location = new System.Drawing.Point(182, 13);
            this.textBoxBookingDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocumentType.Name = "textBoxBookingDocumentType";
            this.textBoxBookingDocumentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocumentType.TabIndex = 3;
            //
            // labelBookingDocumentTypeName
            //
            this.labelBookingDocumentTypeName.AutoSize = true;
            this.labelBookingDocumentTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelBookingDocumentTypeName.Name = "labelBookingDocumentTypeName";
            this.labelBookingDocumentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentTypeName.TabIndex = 4;
            this.labelBookingDocumentTypeName.Text = "Booking Document Type Name:";
            //
            //textBoxBookingDocumentTypeName
            //
            this.textBoxBookingDocumentTypeName.Location = new System.Drawing.Point(182, 36);
            this.textBoxBookingDocumentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocumentTypeName.Name = "textBoxBookingDocumentTypeName";
            this.textBoxBookingDocumentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocumentTypeName.TabIndex = 5;
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
            this.Name = "CrudeBookingDocumentTypeRefEdit";
            this.Text = "Booking Document Type Ref Edit";
            this.Controls.Add(this.labelBookingDocumentType);
            this.Controls.Add(this.textBoxBookingDocumentType);
            this.Controls.Add(this.labelBookingDocumentTypeName);
            this.Controls.Add(this.textBoxBookingDocumentTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
