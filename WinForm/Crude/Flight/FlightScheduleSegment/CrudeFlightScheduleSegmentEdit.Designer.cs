namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleSegmentEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AirportPicker departureAirportPicker;
        
        private System.Windows.Forms.Label labelDepartureAirportPicker;
        
        private AirportPicker arrivalAirportPicker;
        
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhysicalSegmentNumber;
        
        private System.Windows.Forms.Label labelPhysicalSegmentNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogicalSegmentNumber;
        
        private System.Windows.Forms.Label labelLogicalSegmentNumber;
        
        private System.Windows.Forms.TextBox textBoxDepartureTime;
        
        private System.Windows.Forms.Label labelDepartureTime;
        
        private System.Windows.Forms.TextBox textBoxArrivalTime;
        
        private System.Windows.Forms.Label labelArrivalTime;
        
        private System.Windows.Forms.TextBox textBoxDepartureGate;
        
        private System.Windows.Forms.Label labelDepartureGate;
        
        private System.Windows.Forms.TextBox textBoxArrivalGate;
        
        private System.Windows.Forms.Label labelArrivalGate;
        
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
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelPhysicalSegmentNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxPhysicalSegmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelLogicalSegmentNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxLogicalSegmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.textBoxDepartureTime = new System.Windows.Forms.TextBox();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.labelDepartureGate = new System.Windows.Forms.Label();
            this.textBoxDepartureGate = new System.Windows.Forms.TextBox();
            this.labelArrivalGate = new System.Windows.Forms.Label();
            this.textBoxArrivalGate = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDepartureAirportPicker
            //
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(11, 13);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureAirportPicker.TabIndex = 2;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            //
            //departureAirportPicker
            //
            this.departureAirportPicker.Location = new System.Drawing.Point(161, 13);
            this.departureAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.departureAirportPicker.TabIndex = 3;
            //
            // labelArrivalAirportPicker
            //
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(11, 36);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalAirportPicker.TabIndex = 4;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            //
            //arrivalAirportPicker
            //
            this.arrivalAirportPicker.Location = new System.Drawing.Point(161, 36);
            this.arrivalAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.arrivalAirportPicker.TabIndex = 5;
            //
            // labelPhysicalSegmentNumber
            //
            this.labelPhysicalSegmentNumber.AutoSize = true;
            this.labelPhysicalSegmentNumber.Location = new System.Drawing.Point(11, 59);
            this.labelPhysicalSegmentNumber.Name = "labelPhysicalSegmentNumber";
            this.labelPhysicalSegmentNumber.Size = new System.Drawing.Size(71, 13);
            this.labelPhysicalSegmentNumber.TabIndex = 6;
            this.labelPhysicalSegmentNumber.Text = "Physical Segment Number:";
            //
            //maskedTextBoxPhysicalSegmentNumber
            //
            this.maskedTextBoxPhysicalSegmentNumber.Location = new System.Drawing.Point(161, 59);
            this.maskedTextBoxPhysicalSegmentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhysicalSegmentNumber.Name = "maskedTextBoxPhysicalSegmentNumber";
            this.maskedTextBoxPhysicalSegmentNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPhysicalSegmentNumber.TabIndex = 7;
            //
            // labelLogicalSegmentNumber
            //
            this.labelLogicalSegmentNumber.AutoSize = true;
            this.labelLogicalSegmentNumber.Location = new System.Drawing.Point(11, 82);
            this.labelLogicalSegmentNumber.Name = "labelLogicalSegmentNumber";
            this.labelLogicalSegmentNumber.Size = new System.Drawing.Size(71, 13);
            this.labelLogicalSegmentNumber.TabIndex = 8;
            this.labelLogicalSegmentNumber.Text = "Logical Segment Number:";
            //
            //maskedTextBoxLogicalSegmentNumber
            //
            this.maskedTextBoxLogicalSegmentNumber.Location = new System.Drawing.Point(161, 82);
            this.maskedTextBoxLogicalSegmentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLogicalSegmentNumber.Name = "maskedTextBoxLogicalSegmentNumber";
            this.maskedTextBoxLogicalSegmentNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLogicalSegmentNumber.TabIndex = 9;
            //
            // labelDepartureTime
            //
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(11, 105);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureTime.TabIndex = 10;
            this.labelDepartureTime.Text = "Departure Time:";
            //
            //textBoxDepartureTime
            //
            this.textBoxDepartureTime.Location = new System.Drawing.Point(161, 105);
            this.textBoxDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartureTime.Name = "textBoxDepartureTime";
            this.textBoxDepartureTime.Size = new System.Drawing.Size(250, 20);
            this.textBoxDepartureTime.TabIndex = 11;
            //
            // labelArrivalTime
            //
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Location = new System.Drawing.Point(11, 128);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalTime.TabIndex = 12;
            this.labelArrivalTime.Text = "Arrival Time:";
            //
            //textBoxArrivalTime
            //
            this.textBoxArrivalTime.Location = new System.Drawing.Point(161, 128);
            this.textBoxArrivalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrivalTime.Name = "textBoxArrivalTime";
            this.textBoxArrivalTime.Size = new System.Drawing.Size(250, 20);
            this.textBoxArrivalTime.TabIndex = 13;
            //
            // labelDepartureGate
            //
            this.labelDepartureGate.AutoSize = true;
            this.labelDepartureGate.Location = new System.Drawing.Point(11, 151);
            this.labelDepartureGate.Name = "labelDepartureGate";
            this.labelDepartureGate.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureGate.TabIndex = 14;
            this.labelDepartureGate.Text = "Departure Gate:";
            //
            //textBoxDepartureGate
            //
            this.textBoxDepartureGate.Location = new System.Drawing.Point(161, 151);
            this.textBoxDepartureGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartureGate.Name = "textBoxDepartureGate";
            this.textBoxDepartureGate.Size = new System.Drawing.Size(250, 20);
            this.textBoxDepartureGate.TabIndex = 15;
            //
            // labelArrivalGate
            //
            this.labelArrivalGate.AutoSize = true;
            this.labelArrivalGate.Location = new System.Drawing.Point(11, 174);
            this.labelArrivalGate.Name = "labelArrivalGate";
            this.labelArrivalGate.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalGate.TabIndex = 16;
            this.labelArrivalGate.Text = "Arrival Gate:";
            //
            //textBoxArrivalGate
            //
            this.textBoxArrivalGate.Location = new System.Drawing.Point(161, 174);
            this.textBoxArrivalGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrivalGate.Name = "textBoxArrivalGate";
            this.textBoxArrivalGate.Size = new System.Drawing.Size(250, 20);
            this.textBoxArrivalGate.TabIndex = 17;
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
            this.userPicker.Location = new System.Drawing.Point(161, 197);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 220);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 243);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 243);
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
            this.ClientSize = new System.Drawing.Size(423, 271);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFlightScheduleSegmentEdit";
            this.Text = "Flight Schedule Segment Edit";
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelPhysicalSegmentNumber);
            this.Controls.Add(this.maskedTextBoxPhysicalSegmentNumber);
            this.Controls.Add(this.labelLogicalSegmentNumber);
            this.Controls.Add(this.maskedTextBoxLogicalSegmentNumber);
            this.Controls.Add(this.labelDepartureTime);
            this.Controls.Add(this.textBoxDepartureTime);
            this.Controls.Add(this.labelArrivalTime);
            this.Controls.Add(this.textBoxArrivalTime);
            this.Controls.Add(this.labelDepartureGate);
            this.Controls.Add(this.textBoxDepartureGate);
            this.Controls.Add(this.labelArrivalGate);
            this.Controls.Add(this.textBoxArrivalGate);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
