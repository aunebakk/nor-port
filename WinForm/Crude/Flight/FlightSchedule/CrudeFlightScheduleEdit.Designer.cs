namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
        private AircraftTypeRefCombo aircraftTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftTypeRefCombo;
        
        private AirportPicker departureAirportPicker;
        
        private System.Windows.Forms.Label labelDepartureAirportPicker;
        
        private AirportPicker arrivalAirportPicker;
        
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        
        private System.Windows.Forms.Label labelFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        
        private System.Windows.Forms.Label labelUntilDateTime;
        
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
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelAircraftTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftTypeRefCombo = new AircraftTypeRefCombo();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 13);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 2;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(161, 13);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 3;
            //
            // labelAircraftTypeRefCombo
            //
            this.labelAircraftTypeRefCombo.AutoSize = true;
            this.labelAircraftTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftTypeRefCombo.Name = "labelAircraftTypeRefCombo";
            this.labelAircraftTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftTypeRefCombo.TabIndex = 4;
            this.labelAircraftTypeRefCombo.Text = "Aircraft Type:";
            //
            //aircraftTypeRefCombo
            //
            this.aircraftTypeRefCombo.Location = new System.Drawing.Point(161, 36);
            this.aircraftTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftTypeRefCombo.Name = "aircraftTypeRefCombo";
            this.aircraftTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftTypeRefCombo.TabIndex = 5;
            //
            // labelDepartureAirportPicker
            //
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(11, 59);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureAirportPicker.TabIndex = 6;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            //
            //departureAirportPicker
            //
            this.departureAirportPicker.Location = new System.Drawing.Point(161, 59);
            this.departureAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.departureAirportPicker.TabIndex = 7;
            //
            // labelArrivalAirportPicker
            //
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(11, 82);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalAirportPicker.TabIndex = 8;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            //
            //arrivalAirportPicker
            //
            this.arrivalAirportPicker.Location = new System.Drawing.Point(161, 82);
            this.arrivalAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.arrivalAirportPicker.TabIndex = 9;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 105);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 10;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(161, 105);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 11;
            //
            // labelFromDateTime
            //
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFromDateTime.TabIndex = 12;
            this.labelFromDateTime.Text = "From Date Time:";
            //
            //dateTimePickerFromDateTime
            //
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(161, 128);
            this.dateTimePickerFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFromDateTime.TabIndex = 13;
            this.dateTimePickerFromDateTime.Checked = false;
            this.dateTimePickerFromDateTime.ShowCheckBox = true;
            //
            // labelUntilDateTime
            //
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelUntilDateTime.TabIndex = 14;
            this.labelUntilDateTime.Text = "Until Date Time:";
            //
            //dateTimePickerUntilDateTime
            //
            this.dateTimePickerUntilDateTime.Location = new System.Drawing.Point(161, 151);
            this.dateTimePickerUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerUntilDateTime.Name = "dateTimePickerUntilDateTime";
            this.dateTimePickerUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerUntilDateTime.TabIndex = 15;
            this.dateTimePickerUntilDateTime.Checked = false;
            this.dateTimePickerUntilDateTime.ShowCheckBox = true;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 174);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 16;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(161, 174);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 17;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 197);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 18;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 197);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 19;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 220);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 220);
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
            this.ClientSize = new System.Drawing.Size(423, 248);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFlightScheduleEdit";
            this.Text = "Flight Schedule Edit";
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelAircraftTypeRefCombo);
            this.Controls.Add(this.aircraftTypeRefCombo);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
