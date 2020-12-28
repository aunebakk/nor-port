namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeReportingRoundupEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        
        private System.Windows.Forms.Label labelDate;
        
        private ReportingRoundupTypeRefCombo reportingRoundupTypeRefCombo;
        
        private System.Windows.Forms.Label labelReportingRoundupTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxReportingReferenceCode;
        
        private System.Windows.Forms.Label labelReportingReferenceCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCountNumber;
        
        private System.Windows.Forms.Label labelCountNumber;
        
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
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelReportingRoundupTypeRefCombo = new System.Windows.Forms.Label();
            this.reportingRoundupTypeRefCombo = new ReportingRoundupTypeRefCombo();
            this.labelReportingReferenceCode = new System.Windows.Forms.Label();
            this.textBoxReportingReferenceCode = new System.Windows.Forms.TextBox();
            this.labelCountNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxCountNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDate
            //
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(11, 13);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(71, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            //
            //dateTimePickerDate
            //
            this.dateTimePickerDate.Location = new System.Drawing.Point(168, 13);
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDate.TabIndex = 3;
            this.dateTimePickerDate.Checked = false;
            this.dateTimePickerDate.ShowCheckBox = true;
            //
            // labelReportingRoundupTypeRefCombo
            //
            this.labelReportingRoundupTypeRefCombo.AutoSize = true;
            this.labelReportingRoundupTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelReportingRoundupTypeRefCombo.Name = "labelReportingRoundupTypeRefCombo";
            this.labelReportingRoundupTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelReportingRoundupTypeRefCombo.TabIndex = 4;
            this.labelReportingRoundupTypeRefCombo.Text = "Reporting Roundup Type:";
            //
            //reportingRoundupTypeRefCombo
            //
            this.reportingRoundupTypeRefCombo.Location = new System.Drawing.Point(168, 36);
            this.reportingRoundupTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.reportingRoundupTypeRefCombo.Name = "reportingRoundupTypeRefCombo";
            this.reportingRoundupTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.reportingRoundupTypeRefCombo.TabIndex = 5;
            //
            // labelReportingReferenceCode
            //
            this.labelReportingReferenceCode.AutoSize = true;
            this.labelReportingReferenceCode.Location = new System.Drawing.Point(11, 59);
            this.labelReportingReferenceCode.Name = "labelReportingReferenceCode";
            this.labelReportingReferenceCode.Size = new System.Drawing.Size(71, 13);
            this.labelReportingReferenceCode.TabIndex = 6;
            this.labelReportingReferenceCode.Text = "Reporting Reference Code:";
            //
            //textBoxReportingReferenceCode
            //
            this.textBoxReportingReferenceCode.Location = new System.Drawing.Point(168, 59);
            this.textBoxReportingReferenceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportingReferenceCode.Name = "textBoxReportingReferenceCode";
            this.textBoxReportingReferenceCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxReportingReferenceCode.TabIndex = 7;
            //
            // labelCountNumber
            //
            this.labelCountNumber.AutoSize = true;
            this.labelCountNumber.Location = new System.Drawing.Point(11, 82);
            this.labelCountNumber.Name = "labelCountNumber";
            this.labelCountNumber.Size = new System.Drawing.Size(71, 13);
            this.labelCountNumber.TabIndex = 8;
            this.labelCountNumber.Text = "Count Number:";
            //
            //maskedTextBoxCountNumber
            //
            this.maskedTextBoxCountNumber.Location = new System.Drawing.Point(168, 82);
            this.maskedTextBoxCountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCountNumber.Name = "maskedTextBoxCountNumber";
            this.maskedTextBoxCountNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCountNumber.TabIndex = 9;
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
            this.userPicker.Location = new System.Drawing.Point(168, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(226, 151);
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
            this.ClientSize = new System.Drawing.Size(430, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeReportingRoundupEdit";
            this.Text = "Reporting Roundup Edit";
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelReportingRoundupTypeRefCombo);
            this.Controls.Add(this.reportingRoundupTypeRefCombo);
            this.Controls.Add(this.labelReportingReferenceCode);
            this.Controls.Add(this.textBoxReportingReferenceCode);
            this.Controls.Add(this.labelCountNumber);
            this.Controls.Add(this.maskedTextBoxCountNumber);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
