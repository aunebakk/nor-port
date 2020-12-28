namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightSegmentEventEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFlightSegmentEventNumber;
        
        private System.Windows.Forms.Label labelFlightSegmentEventNumber;
        
        private DateTimeTypeRefCombo dateTimeTypeRefCombo;
        
        private System.Windows.Forms.Label labelDateTimeTypeRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDateTime;
        
        private System.Windows.Forms.Label labelNewDateTime;
        
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
            this.labelFlightSegmentEventNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxFlightSegmentEventNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTimeTypeRefCombo = new System.Windows.Forms.Label();
            this.dateTimeTypeRefCombo = new DateTimeTypeRefCombo();
            this.labelNewDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerNewDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFlightSegmentEventNumber
            //
            this.labelFlightSegmentEventNumber.AutoSize = true;
            this.labelFlightSegmentEventNumber.Location = new System.Drawing.Point(11, 13);
            this.labelFlightSegmentEventNumber.Name = "labelFlightSegmentEventNumber";
            this.labelFlightSegmentEventNumber.Size = new System.Drawing.Size(71, 13);
            this.labelFlightSegmentEventNumber.TabIndex = 2;
            this.labelFlightSegmentEventNumber.Text = "Flight Segment Event Number:";
            //
            //maskedTextBoxFlightSegmentEventNumber
            //
            this.maskedTextBoxFlightSegmentEventNumber.Location = new System.Drawing.Point(189, 13);
            this.maskedTextBoxFlightSegmentEventNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxFlightSegmentEventNumber.Name = "maskedTextBoxFlightSegmentEventNumber";
            this.maskedTextBoxFlightSegmentEventNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxFlightSegmentEventNumber.TabIndex = 3;
            //
            // labelDateTimeTypeRefCombo
            //
            this.labelDateTimeTypeRefCombo.AutoSize = true;
            this.labelDateTimeTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelDateTimeTypeRefCombo.Name = "labelDateTimeTypeRefCombo";
            this.labelDateTimeTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDateTimeTypeRefCombo.TabIndex = 4;
            this.labelDateTimeTypeRefCombo.Text = "Date Time Type:";
            //
            //dateTimeTypeRefCombo
            //
            this.dateTimeTypeRefCombo.Location = new System.Drawing.Point(189, 36);
            this.dateTimeTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTypeRefCombo.Name = "dateTimeTypeRefCombo";
            this.dateTimeTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.dateTimeTypeRefCombo.TabIndex = 5;
            //
            // labelNewDateTime
            //
            this.labelNewDateTime.AutoSize = true;
            this.labelNewDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelNewDateTime.Name = "labelNewDateTime";
            this.labelNewDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelNewDateTime.TabIndex = 6;
            this.labelNewDateTime.Text = "New Date Time:";
            //
            //dateTimePickerNewDateTime
            //
            this.dateTimePickerNewDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerNewDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNewDateTime.Name = "dateTimePickerNewDateTime";
            this.dateTimePickerNewDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerNewDateTime.TabIndex = 7;
            this.dateTimePickerNewDateTime.Checked = false;
            this.dateTimePickerNewDateTime.ShowCheckBox = true;
            //
            // labelRemarks
            //
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(11, 82);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(71, 13);
            this.labelRemarks.TabIndex = 8;
            this.labelRemarks.Text = "Remarks:";
            //
            //textBoxRemarks
            //
            this.textBoxRemarks.Location = new System.Drawing.Point(189, 82);
            this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 20);
            this.textBoxRemarks.TabIndex = 9;
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
            this.userPicker.Location = new System.Drawing.Point(189, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 151);
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
            this.ClientSize = new System.Drawing.Size(451, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFlightSegmentEventEdit";
            this.Text = "Flight Segment Event Edit";
            this.Controls.Add(this.labelFlightSegmentEventNumber);
            this.Controls.Add(this.maskedTextBoxFlightSegmentEventNumber);
            this.Controls.Add(this.labelDateTimeTypeRefCombo);
            this.Controls.Add(this.dateTimeTypeRefCombo);
            this.Controls.Add(this.labelNewDateTime);
            this.Controls.Add(this.dateTimePickerNewDateTime);
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
