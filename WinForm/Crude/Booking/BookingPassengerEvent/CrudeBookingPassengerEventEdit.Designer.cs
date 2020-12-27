namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerEventEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private BookingPassengerEventTypeRefCombo bookingPassengerEventTypeRefCombo;
        
        private System.Windows.Forms.Label labelBookingPassengerEventTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBookingPassengerEventNumber;
        
        private System.Windows.Forms.Label labelBookingPassengerEventNumber;
        
        private System.Windows.Forms.TextBox textBoxRemarks;
        
        private System.Windows.Forms.Label labelRemarks;
        
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
            this.labelBookingPassengerEventTypeRefCombo = new System.Windows.Forms.Label();
            this.bookingPassengerEventTypeRefCombo = new BookingPassengerEventTypeRefCombo();
            this.labelBookingPassengerEventNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxBookingPassengerEventNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingPassengerEventTypeRefCombo
            //
            this.labelBookingPassengerEventTypeRefCombo.AutoSize = true;
            this.labelBookingPassengerEventTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelBookingPassengerEventTypeRefCombo.Name = "labelBookingPassengerEventTypeRefCombo";
            this.labelBookingPassengerEventTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventTypeRefCombo.TabIndex = 2;
            this.labelBookingPassengerEventTypeRefCombo.Text = "Booking Passenger Event Type:";
            //
            //bookingPassengerEventTypeRefCombo
            //
            this.bookingPassengerEventTypeRefCombo.Location = new System.Drawing.Point(210, 13);
            this.bookingPassengerEventTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingPassengerEventTypeRefCombo.Name = "bookingPassengerEventTypeRefCombo";
            this.bookingPassengerEventTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.bookingPassengerEventTypeRefCombo.TabIndex = 3;
            //
            // labelBookingPassengerEventNumber
            //
            this.labelBookingPassengerEventNumber.AutoSize = true;
            this.labelBookingPassengerEventNumber.Location = new System.Drawing.Point(11, 36);
            this.labelBookingPassengerEventNumber.Name = "labelBookingPassengerEventNumber";
            this.labelBookingPassengerEventNumber.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventNumber.TabIndex = 4;
            this.labelBookingPassengerEventNumber.Text = "Booking Passenger Event Number:";
            //
            //maskedTextBoxBookingPassengerEventNumber
            //
            this.maskedTextBoxBookingPassengerEventNumber.Location = new System.Drawing.Point(210, 36);
            this.maskedTextBoxBookingPassengerEventNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxBookingPassengerEventNumber.Name = "maskedTextBoxBookingPassengerEventNumber";
            this.maskedTextBoxBookingPassengerEventNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxBookingPassengerEventNumber.TabIndex = 5;
            //
            // labelRemarks
            //
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(11, 59);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(71, 13);
            this.labelRemarks.TabIndex = 6;
            this.labelRemarks.Text = "Remarks:";
            //
            //textBoxRemarks
            //
            this.textBoxRemarks.Location = new System.Drawing.Point(210, 59);
            this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 20);
            this.textBoxRemarks.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(210, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(268, 128);
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
            this.ClientSize = new System.Drawing.Size(472, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeBookingPassengerEventEdit";
            this.Text = "Booking Passenger Event Edit";
            this.Controls.Add(this.labelBookingPassengerEventTypeRefCombo);
            this.Controls.Add(this.bookingPassengerEventTypeRefCombo);
            this.Controls.Add(this.labelBookingPassengerEventNumber);
            this.Controls.Add(this.maskedTextBoxBookingPassengerEventNumber);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
