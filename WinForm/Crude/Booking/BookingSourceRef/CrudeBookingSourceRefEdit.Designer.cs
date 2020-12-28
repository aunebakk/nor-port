namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingSourceRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxBookingSource;
        
        private System.Windows.Forms.Label labelBookingSource;
        
        private System.Windows.Forms.TextBox textBoxBookingSourceName;
        
        private System.Windows.Forms.Label labelBookingSourceName;
        
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
            this.labelBookingSource = new System.Windows.Forms.Label();
            this.textBoxBookingSource = new System.Windows.Forms.TextBox();
            this.labelBookingSourceName = new System.Windows.Forms.Label();
            this.textBoxBookingSourceName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingSource
            //
            this.labelBookingSource.AutoSize = true;
            this.labelBookingSource.Location = new System.Drawing.Point(11, 13);
            this.labelBookingSource.Name = "labelBookingSource";
            this.labelBookingSource.Size = new System.Drawing.Size(71, 13);
            this.labelBookingSource.TabIndex = 2;
            this.labelBookingSource.Text = "Booking Source:";
            //
            //textBoxBookingSource
            //
            this.textBoxBookingSource.Location = new System.Drawing.Point(140, 13);
            this.textBoxBookingSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingSource.Name = "textBoxBookingSource";
            this.textBoxBookingSource.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingSource.TabIndex = 3;
            //
            // labelBookingSourceName
            //
            this.labelBookingSourceName.AutoSize = true;
            this.labelBookingSourceName.Location = new System.Drawing.Point(11, 36);
            this.labelBookingSourceName.Name = "labelBookingSourceName";
            this.labelBookingSourceName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingSourceName.TabIndex = 4;
            this.labelBookingSourceName.Text = "Booking Source Name:";
            //
            //textBoxBookingSourceName
            //
            this.textBoxBookingSourceName.Location = new System.Drawing.Point(140, 36);
            this.textBoxBookingSourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingSourceName.Name = "textBoxBookingSourceName";
            this.textBoxBookingSourceName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingSourceName.TabIndex = 5;
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
            this.Name = "CrudeBookingSourceRefEdit";
            this.Text = "Booking Source Ref Edit";
            this.Controls.Add(this.labelBookingSource);
            this.Controls.Add(this.textBoxBookingSource);
            this.Controls.Add(this.labelBookingSourceName);
            this.Controls.Add(this.textBoxBookingSourceName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
