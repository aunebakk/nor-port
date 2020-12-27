namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftMeasurementEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        
        private System.Windows.Forms.Label labelLength;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeight;
        
        private System.Windows.Forms.Label labelHeight;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeight;
        
        private System.Windows.Forms.Label labelWeight;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWingspan;
        
        private System.Windows.Forms.Label labelWingspan;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        
        private System.Windows.Forms.Label labelWidth;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPayload;
        
        private System.Windows.Forms.Label labelPayload;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTakeoffWeightInKilo;
        
        private System.Windows.Forms.Label labelTakeoffWeightInKilo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpeed;
        
        private System.Windows.Forms.Label labelSpeed;
        
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
            this.labelLength = new System.Windows.Forms.Label();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.maskedTextBoxHeight = new System.Windows.Forms.MaskedTextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.maskedTextBoxWeight = new System.Windows.Forms.MaskedTextBox();
            this.labelWingspan = new System.Windows.Forms.Label();
            this.maskedTextBoxWingspan = new System.Windows.Forms.MaskedTextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.labelPayload = new System.Windows.Forms.Label();
            this.maskedTextBoxPayload = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeoffWeightInKilo = new System.Windows.Forms.Label();
            this.maskedTextBoxTakeoffWeightInKilo = new System.Windows.Forms.MaskedTextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.maskedTextBoxSpeed = new System.Windows.Forms.MaskedTextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLength
            //
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(11, 13);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(71, 13);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Length:";
            //
            //maskedTextBoxLength
            //
            this.maskedTextBoxLength.Location = new System.Drawing.Point(154, 13);
            this.maskedTextBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLength.TabIndex = 3;
            //
            // labelHeight
            //
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(11, 36);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(71, 13);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height:";
            //
            //maskedTextBoxHeight
            //
            this.maskedTextBoxHeight.Location = new System.Drawing.Point(154, 36);
            this.maskedTextBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxHeight.Name = "maskedTextBoxHeight";
            this.maskedTextBoxHeight.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxHeight.TabIndex = 5;
            //
            // labelWeight
            //
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(11, 59);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(71, 13);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Weight:";
            //
            //maskedTextBoxWeight
            //
            this.maskedTextBoxWeight.Location = new System.Drawing.Point(154, 59);
            this.maskedTextBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxWeight.Name = "maskedTextBoxWeight";
            this.maskedTextBoxWeight.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxWeight.TabIndex = 7;
            //
            // labelWingspan
            //
            this.labelWingspan.AutoSize = true;
            this.labelWingspan.Location = new System.Drawing.Point(11, 82);
            this.labelWingspan.Name = "labelWingspan";
            this.labelWingspan.Size = new System.Drawing.Size(71, 13);
            this.labelWingspan.TabIndex = 8;
            this.labelWingspan.Text = "Wingspan:";
            //
            //maskedTextBoxWingspan
            //
            this.maskedTextBoxWingspan.Location = new System.Drawing.Point(154, 82);
            this.maskedTextBoxWingspan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxWingspan.Name = "maskedTextBoxWingspan";
            this.maskedTextBoxWingspan.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxWingspan.TabIndex = 9;
            //
            // labelWidth
            //
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(11, 105);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(71, 13);
            this.labelWidth.TabIndex = 10;
            this.labelWidth.Text = "Width:";
            //
            //maskedTextBoxWidth
            //
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(154, 105);
            this.maskedTextBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxWidth.TabIndex = 11;
            //
            // labelPayload
            //
            this.labelPayload.AutoSize = true;
            this.labelPayload.Location = new System.Drawing.Point(11, 128);
            this.labelPayload.Name = "labelPayload";
            this.labelPayload.Size = new System.Drawing.Size(71, 13);
            this.labelPayload.TabIndex = 12;
            this.labelPayload.Text = "Payload:";
            //
            //maskedTextBoxPayload
            //
            this.maskedTextBoxPayload.Location = new System.Drawing.Point(154, 128);
            this.maskedTextBoxPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPayload.Name = "maskedTextBoxPayload";
            this.maskedTextBoxPayload.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPayload.TabIndex = 13;
            //
            // labelTakeoffWeightInKilo
            //
            this.labelTakeoffWeightInKilo.AutoSize = true;
            this.labelTakeoffWeightInKilo.Location = new System.Drawing.Point(11, 151);
            this.labelTakeoffWeightInKilo.Name = "labelTakeoffWeightInKilo";
            this.labelTakeoffWeightInKilo.Size = new System.Drawing.Size(71, 13);
            this.labelTakeoffWeightInKilo.TabIndex = 14;
            this.labelTakeoffWeightInKilo.Text = "Takeoff Weight In Kilo:";
            //
            //maskedTextBoxTakeoffWeightInKilo
            //
            this.maskedTextBoxTakeoffWeightInKilo.Location = new System.Drawing.Point(154, 151);
            this.maskedTextBoxTakeoffWeightInKilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTakeoffWeightInKilo.Name = "maskedTextBoxTakeoffWeightInKilo";
            this.maskedTextBoxTakeoffWeightInKilo.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxTakeoffWeightInKilo.TabIndex = 15;
            //
            // labelSpeed
            //
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(11, 174);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(71, 13);
            this.labelSpeed.TabIndex = 16;
            this.labelSpeed.Text = "Speed:";
            //
            //maskedTextBoxSpeed
            //
            this.maskedTextBoxSpeed.Location = new System.Drawing.Point(154, 174);
            this.maskedTextBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSpeed.Name = "maskedTextBoxSpeed";
            this.maskedTextBoxSpeed.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSpeed.TabIndex = 17;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 197);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 18;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(154, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 220);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 20;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 220);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 243);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 243);
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
            this.ClientSize = new System.Drawing.Size(416, 271);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAircraftMeasurementEdit";
            this.Text = "Aircraft Measurement Edit";
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.maskedTextBoxLength);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.maskedTextBoxHeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.maskedTextBoxWeight);
            this.Controls.Add(this.labelWingspan);
            this.Controls.Add(this.maskedTextBoxWingspan);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.maskedTextBoxWidth);
            this.Controls.Add(this.labelPayload);
            this.Controls.Add(this.maskedTextBoxPayload);
            this.Controls.Add(this.labelTakeoffWeightInKilo);
            this.Controls.Add(this.maskedTextBoxTakeoffWeightInKilo);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.maskedTextBoxSpeed);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
