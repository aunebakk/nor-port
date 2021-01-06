namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingServiceRequestEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ServiceTypeRefCombo serviceTypeRefCombo;
        
        private System.Windows.Forms.Label labelServiceTypeRefCombo;
        
        private ServiceSpecialServiceRequestPicker serviceSpecialServiceRequestPicker;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestPicker;
        
        private ServiceRequestStatusRefCombo serviceRequestStatusRefCombo;
        
        private System.Windows.Forms.Label labelServiceRequestStatusRefCombo;
        
        private ServiceCarRentalPicker serviceCarRentalPicker;
        
        private System.Windows.Forms.Label labelServiceCarRentalPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
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
            this.labelServiceTypeRefCombo = new System.Windows.Forms.Label();
            this.serviceTypeRefCombo = new ServiceTypeRefCombo();
            this.labelServiceSpecialServiceRequestPicker = new System.Windows.Forms.Label();
            this.serviceSpecialServiceRequestPicker = new ServiceSpecialServiceRequestPicker();
            this.labelServiceRequestStatusRefCombo = new System.Windows.Forms.Label();
            this.serviceRequestStatusRefCombo = new ServiceRequestStatusRefCombo();
            this.labelServiceCarRentalPicker = new System.Windows.Forms.Label();
            this.serviceCarRentalPicker = new ServiceCarRentalPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceTypeRefCombo
            //
            this.labelServiceTypeRefCombo.AutoSize = true;
            this.labelServiceTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelServiceTypeRefCombo.Name = "labelServiceTypeRefCombo";
            this.labelServiceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceTypeRefCombo.TabIndex = 2;
            this.labelServiceTypeRefCombo.Text = "Service Type:";
            //
            //serviceTypeRefCombo
            //
            this.serviceTypeRefCombo.Location = new System.Drawing.Point(217, 13);
            this.serviceTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceTypeRefCombo.Name = "serviceTypeRefCombo";
            this.serviceTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceTypeRefCombo.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestPicker
            //
            this.labelServiceSpecialServiceRequestPicker.AutoSize = true;
            this.labelServiceSpecialServiceRequestPicker.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestPicker.Name = "labelServiceSpecialServiceRequestPicker";
            this.labelServiceSpecialServiceRequestPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestPicker.TabIndex = 4;
            this.labelServiceSpecialServiceRequestPicker.Text = "Service Special Service Request:";
            //
            //serviceSpecialServiceRequestPicker
            //
            this.serviceSpecialServiceRequestPicker.Location = new System.Drawing.Point(217, 36);
            this.serviceSpecialServiceRequestPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceSpecialServiceRequestPicker.Name = "serviceSpecialServiceRequestPicker";
            this.serviceSpecialServiceRequestPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceSpecialServiceRequestPicker.TabIndex = 5;
            //
            // labelServiceRequestStatusRefCombo
            //
            this.labelServiceRequestStatusRefCombo.AutoSize = true;
            this.labelServiceRequestStatusRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelServiceRequestStatusRefCombo.Name = "labelServiceRequestStatusRefCombo";
            this.labelServiceRequestStatusRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceRequestStatusRefCombo.TabIndex = 6;
            this.labelServiceRequestStatusRefCombo.Text = "Service Request Status:";
            //
            //serviceRequestStatusRefCombo
            //
            this.serviceRequestStatusRefCombo.Location = new System.Drawing.Point(217, 59);
            this.serviceRequestStatusRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceRequestStatusRefCombo.Name = "serviceRequestStatusRefCombo";
            this.serviceRequestStatusRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceRequestStatusRefCombo.TabIndex = 7;
            //
            // labelServiceCarRentalPicker
            //
            this.labelServiceCarRentalPicker.AutoSize = true;
            this.labelServiceCarRentalPicker.Location = new System.Drawing.Point(11, 82);
            this.labelServiceCarRentalPicker.Name = "labelServiceCarRentalPicker";
            this.labelServiceCarRentalPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceCarRentalPicker.TabIndex = 8;
            this.labelServiceCarRentalPicker.Text = "Service Car Rental:";
            //
            //serviceCarRentalPicker
            //
            this.serviceCarRentalPicker.Location = new System.Drawing.Point(217, 82);
            this.serviceCarRentalPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCarRentalPicker.Name = "serviceCarRentalPicker";
            this.serviceCarRentalPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceCarRentalPicker.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(217, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(275, 151);
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
            this.ClientSize = new System.Drawing.Size(479, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeBookingServiceRequestEdit";
            this.Text = "Booking Service Request Edit";
            this.Controls.Add(this.labelServiceTypeRefCombo);
            this.Controls.Add(this.serviceTypeRefCombo);
            this.Controls.Add(this.labelServiceSpecialServiceRequestPicker);
            this.Controls.Add(this.serviceSpecialServiceRequestPicker);
            this.Controls.Add(this.labelServiceRequestStatusRefCombo);
            this.Controls.Add(this.serviceRequestStatusRefCombo);
            this.Controls.Add(this.labelServiceCarRentalPicker);
            this.Controls.Add(this.serviceCarRentalPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
