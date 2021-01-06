namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceRequestStatusRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxServiceRequestStatus;
        
        private System.Windows.Forms.Label labelServiceRequestStatus;
        
        private System.Windows.Forms.TextBox textBoxServiceRequestStatusName;
        
        private System.Windows.Forms.Label labelServiceRequestStatusName;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.TextBox textBoxDescription;
        
        private System.Windows.Forms.Label labelDescription;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelServiceRequestStatus = new System.Windows.Forms.Label();
            this.textBoxServiceRequestStatus = new System.Windows.Forms.TextBox();
            this.labelServiceRequestStatusName = new System.Windows.Forms.Label();
            this.textBoxServiceRequestStatusName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceRequestStatus
            //
            this.labelServiceRequestStatus.AutoSize = true;
            this.labelServiceRequestStatus.Location = new System.Drawing.Point(11, 13);
            this.labelServiceRequestStatus.Name = "labelServiceRequestStatus";
            this.labelServiceRequestStatus.Size = new System.Drawing.Size(71, 13);
            this.labelServiceRequestStatus.TabIndex = 2;
            this.labelServiceRequestStatus.Text = "Service Request Status:";
            //
            //textBoxServiceRequestStatus
            //
            this.textBoxServiceRequestStatus.Location = new System.Drawing.Point(189, 13);
            this.textBoxServiceRequestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceRequestStatus.Name = "textBoxServiceRequestStatus";
            this.textBoxServiceRequestStatus.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceRequestStatus.TabIndex = 3;
            //
            // labelServiceRequestStatusName
            //
            this.labelServiceRequestStatusName.AutoSize = true;
            this.labelServiceRequestStatusName.Location = new System.Drawing.Point(11, 36);
            this.labelServiceRequestStatusName.Name = "labelServiceRequestStatusName";
            this.labelServiceRequestStatusName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceRequestStatusName.TabIndex = 4;
            this.labelServiceRequestStatusName.Text = "Service Request Status Name:";
            //
            //textBoxServiceRequestStatusName
            //
            this.textBoxServiceRequestStatusName.Location = new System.Drawing.Point(189, 36);
            this.textBoxServiceRequestStatusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceRequestStatusName.Name = "textBoxServiceRequestStatusName";
            this.textBoxServiceRequestStatusName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceRequestStatusName.TabIndex = 5;
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
            // labelDescription
            //
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 82);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(71, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description:";
            //
            //textBoxDescription
            //
            this.textBoxDescription.Location = new System.Drawing.Point(189, 82);
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDescription.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 105);
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
            this.ClientSize = new System.Drawing.Size(451, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServiceRequestStatusRefEdit";
            this.Text = "Service Request Status Ref Edit";
            this.Controls.Add(this.labelServiceRequestStatus);
            this.Controls.Add(this.textBoxServiceRequestStatus);
            this.Controls.Add(this.labelServiceRequestStatusName);
            this.Controls.Add(this.textBoxServiceRequestStatusName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
