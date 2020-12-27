namespace SolutionNorSolutionPort.UserInterface
{


    public partial class Checkin
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonFlightsWithCheckinInformationSearch;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsWithCheckinInformationSearch = new System.Windows.Forms.Button();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAll = new System.Windows.Forms.TabPage();
            this.passengersOnFlightDurian = new SolutionNorSolutionPort.UserInterface.PassengersOnFlightDurian();
            this.buttonAllCheckOut = new System.Windows.Forms.Button();
            this.buttonAllCheckin = new System.Windows.Forms.Button();
            this.tabPageNoEvents = new System.Windows.Forms.TabPage();
            this.passengersOnFlightWithoutEventsDurian = new SolutionNorSolutionPort.UserInterface.PassengersOnFlightWithoutEventsDurian();
            this.buttonNoEventsCheckin = new System.Windows.Forms.Button();
            this.tabPageCheckedIn = new System.Windows.Forms.TabPage();
            this.passengersOnFlightCheckedInDurian = new SolutionNorSolutionPort.UserInterface.PassengersOnFlightCheckedInDurian();
            this.buttonCheckedInCheckOut = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountRows = new System.Windows.Forms.Label();
            this.checkinCombo = new SolutionNorSolutionPort.UserInterface.CheckinCombo();
            this.departureAirportPicker = new SolutionNorSolutionPort.UserInterface.AirportPicker();
            this.arrivalAirportPicker = new SolutionNorSolutionPort.UserInterface.AirportPicker();
            this.tabControl.SuspendLayout();
            this.tabPageAll.SuspendLayout();
            this.tabPageNoEvents.SuspendLayout();
            this.tabPageCheckedIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(698, 325);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFlightsWithCheckinInformationSearch
            // 
            this.buttonFlightsWithCheckinInformationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsWithCheckinInformationSearch.Location = new System.Drawing.Point(600, 325);
            this.buttonFlightsWithCheckinInformationSearch.Name = "buttonFlightsWithCheckinInformationSearch";
            this.buttonFlightsWithCheckinInformationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsWithCheckinInformationSearch.TabIndex = 2;
            this.buttonFlightsWithCheckinInformationSearch.Text = "&Search";
            this.buttonFlightsWithCheckinInformationSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsWithCheckinInformationSearch.Click += new System.EventHandler(this.buttonFlightsWithCheckinInformationSearch_Click);
            // 
            // labelDepartureAirportPicker
            // 
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(12, 9);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(90, 13);
            this.labelDepartureAirportPicker.TabIndex = 59;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            // 
            // labelArrivalAirportPicker
            // 
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(12, 32);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(72, 13);
            this.labelArrivalAirportPicker.TabIndex = 61;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            // 
            // labelFromDateTime
            // 
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(486, 12);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(85, 13);
            this.labelFromDateTime.TabIndex = 55;
            this.labelFromDateTime.Text = "From Date Time:";
            // 
            // dateTimePickerFromDateTime
            // 
            this.dateTimePickerFromDateTime.Checked = false;
            this.dateTimePickerFromDateTime.CustomFormat = "yyyy MMMM dd, HH:mm";
            this.dateTimePickerFromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(577, 12);
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.ShowCheckBox = true;
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerFromDateTime.TabIndex = 56;
            // 
            // labelUntilDateTime
            // 
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(486, 35);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(83, 13);
            this.labelUntilDateTime.TabIndex = 57;
            this.labelUntilDateTime.Text = "Until Date Time:";
            // 
            // dateTimePickerUntilDateTime
            // 
            this.dateTimePickerUntilDateTime.Checked = false;
            this.dateTimePickerUntilDateTime.CustomFormat = "yyyy MMMM dd, HH:mm";
            this.dateTimePickerUntilDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUntilDateTime.Location = new System.Drawing.Point(577, 35);
            this.dateTimePickerUntilDateTime.Name = "dateTimePickerUntilDateTime";
            this.dateTimePickerUntilDateTime.ShowCheckBox = true;
            this.dateTimePickerUntilDateTime.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerUntilDateTime.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Flight:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageAll);
            this.tabControl.Controls.Add(this.tabPageNoEvents);
            this.tabControl.Controls.Add(this.tabPageCheckedIn);
            this.tabControl.Location = new System.Drawing.Point(15, 84);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 235);
            this.tabControl.TabIndex = 66;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.passengersOnFlightDurian);
            this.tabPageAll.Controls.Add(this.buttonAllCheckOut);
            this.tabPageAll.Controls.Add(this.buttonAllCheckin);
            this.tabPageAll.Location = new System.Drawing.Point(4, 22);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAll.Size = new System.Drawing.Size(767, 209);
            this.tabPageAll.TabIndex = 0;
            this.tabPageAll.Text = "All";
            this.tabPageAll.UseVisualStyleBackColor = true;
            // 
            // passengersOnFlightDurian
            // 
            this.passengersOnFlightDurian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengersOnFlightDurian.Location = new System.Drawing.Point(6, 6);
            this.passengersOnFlightDurian.Name = "passengersOnFlightDurian";
            this.passengersOnFlightDurian.Size = new System.Drawing.Size(755, 169);
            this.passengersOnFlightDurian.TabIndex = 69;
            // 
            // buttonAllCheckOut
            // 
            this.buttonAllCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllCheckOut.Location = new System.Drawing.Point(571, 181);
            this.buttonAllCheckOut.Name = "buttonAllCheckOut";
            this.buttonAllCheckOut.Size = new System.Drawing.Size(92, 22);
            this.buttonAllCheckOut.TabIndex = 68;
            this.buttonAllCheckOut.Text = "Check &Out";
            this.buttonAllCheckOut.UseVisualStyleBackColor = true;
            this.buttonAllCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonAllCheckin
            // 
            this.buttonAllCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllCheckin.Location = new System.Drawing.Point(669, 181);
            this.buttonAllCheckin.Name = "buttonAllCheckin";
            this.buttonAllCheckin.Size = new System.Drawing.Size(92, 22);
            this.buttonAllCheckin.TabIndex = 67;
            this.buttonAllCheckin.Text = "Check &In";
            this.buttonAllCheckin.UseVisualStyleBackColor = true;
            this.buttonAllCheckin.Click += new System.EventHandler(this.buttonCheckin_Click);
            // 
            // tabPageNoEvents
            // 
            this.tabPageNoEvents.Controls.Add(this.passengersOnFlightWithoutEventsDurian);
            this.tabPageNoEvents.Controls.Add(this.buttonNoEventsCheckin);
            this.tabPageNoEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageNoEvents.Name = "tabPageNoEvents";
            this.tabPageNoEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNoEvents.Size = new System.Drawing.Size(767, 209);
            this.tabPageNoEvents.TabIndex = 1;
            this.tabPageNoEvents.Text = "No Events";
            this.tabPageNoEvents.UseVisualStyleBackColor = true;
            // 
            // passengersOnFlightWithoutEventsDurian
            // 
            this.passengersOnFlightWithoutEventsDurian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengersOnFlightWithoutEventsDurian.Location = new System.Drawing.Point(6, 6);
            this.passengersOnFlightWithoutEventsDurian.Name = "passengersOnFlightWithoutEventsDurian";
            this.passengersOnFlightWithoutEventsDurian.Size = new System.Drawing.Size(755, 169);
            this.passengersOnFlightWithoutEventsDurian.TabIndex = 69;
            // 
            // buttonNoEventsCheckin
            // 
            this.buttonNoEventsCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNoEventsCheckin.Location = new System.Drawing.Point(669, 181);
            this.buttonNoEventsCheckin.Name = "buttonNoEventsCheckin";
            this.buttonNoEventsCheckin.Size = new System.Drawing.Size(92, 22);
            this.buttonNoEventsCheckin.TabIndex = 68;
            this.buttonNoEventsCheckin.Text = "Check &In";
            this.buttonNoEventsCheckin.UseVisualStyleBackColor = true;
            this.buttonNoEventsCheckin.Click += new System.EventHandler(this.buttonNoEventsCheckin_Click);
            // 
            // tabPageCheckedIn
            // 
            this.tabPageCheckedIn.Controls.Add(this.passengersOnFlightCheckedInDurian);
            this.tabPageCheckedIn.Controls.Add(this.buttonCheckedInCheckOut);
            this.tabPageCheckedIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheckedIn.Name = "tabPageCheckedIn";
            this.tabPageCheckedIn.Size = new System.Drawing.Size(767, 209);
            this.tabPageCheckedIn.TabIndex = 2;
            this.tabPageCheckedIn.Text = "Checked In";
            this.tabPageCheckedIn.UseVisualStyleBackColor = true;
            // 
            // passengersOnFlightCheckedInDurian
            // 
            this.passengersOnFlightCheckedInDurian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengersOnFlightCheckedInDurian.Location = new System.Drawing.Point(6, 6);
            this.passengersOnFlightCheckedInDurian.Name = "passengersOnFlightCheckedInDurian";
            this.passengersOnFlightCheckedInDurian.Size = new System.Drawing.Size(755, 169);
            this.passengersOnFlightCheckedInDurian.TabIndex = 70;
            // 
            // buttonCheckedInCheckOut
            // 
            this.buttonCheckedInCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckedInCheckOut.Location = new System.Drawing.Point(669, 181);
            this.buttonCheckedInCheckOut.Name = "buttonCheckedInCheckOut";
            this.buttonCheckedInCheckOut.Size = new System.Drawing.Size(92, 22);
            this.buttonCheckedInCheckOut.TabIndex = 69;
            this.buttonCheckedInCheckOut.Text = "Check &Out";
            this.buttonCheckedInCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckedInCheckOut.Click += new System.EventHandler(this.buttonCheckedInCheckOut_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(16, 328);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(38, 13);
            this.labelCount.TabIndex = 67;
            this.labelCount.Text = "Count:";
            // 
            // labelCountRows
            // 
            this.labelCountRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountRows.AutoSize = true;
            this.labelCountRows.Location = new System.Drawing.Point(65, 328);
            this.labelCountRows.Name = "labelCountRows";
            this.labelCountRows.Size = new System.Drawing.Size(13, 13);
            this.labelCountRows.TabIndex = 68;
            this.labelCountRows.Text = "0";
            // 
            // checkinCombo
            // 
            this.checkinCombo.FlightId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkinCombo.Location = new System.Drawing.Point(162, 55);
            this.checkinCombo.Name = "checkinCombo";
            this.checkinCombo.Size = new System.Drawing.Size(304, 21);
            this.checkinCombo.TabIndex = 63;
            this.checkinCombo.Picked += new System.EventHandler(this.checkinCombo_Picked);
            // 
            // departureAirportPicker
            // 
            this.departureAirportPicker.Location = new System.Drawing.Point(162, 9);
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.departureAirportPicker.Size = new System.Drawing.Size(304, 20);
            this.departureAirportPicker.TabIndex = 60;
            // 
            // arrivalAirportPicker
            // 
            this.arrivalAirportPicker.Location = new System.Drawing.Point(162, 32);
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.arrivalAirportPicker.Size = new System.Drawing.Size(304, 20);
            this.arrivalAirportPicker.TabIndex = 62;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 353);
            this.Controls.Add(this.labelCountRows);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkinCombo);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.buttonFlightsWithCheckinInformationSearch);
            this.Controls.Add(this.buttonClose);
            this.Name = "Checkin";
            this.Text = "Checkin";
            this.tabControl.ResumeLayout(false);
            this.tabPageAll.ResumeLayout(false);
            this.tabPageNoEvents.ResumeLayout(false);
            this.tabPageCheckedIn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelDepartureAirportPicker;
        private AirportPicker departureAirportPicker;
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        private AirportPicker arrivalAirportPicker;
        private System.Windows.Forms.Label labelFromDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        private System.Windows.Forms.Label labelUntilDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        private CheckinCombo checkinCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.Button buttonAllCheckOut;
        private System.Windows.Forms.Button buttonAllCheckin;
        private System.Windows.Forms.TabPage tabPageNoEvents;
        private System.Windows.Forms.TabPage tabPageCheckedIn;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountRows;
        private System.Windows.Forms.Button buttonNoEventsCheckin;
        private System.Windows.Forms.Button buttonCheckedInCheckOut;
        private PassengersOnFlightDurian passengersOnFlightDurian;
        private PassengersOnFlightCheckedInDurian passengersOnFlightCheckedInDurian;
        private PassengersOnFlightWithoutEventsDurian passengersOnFlightWithoutEventsDurian;
    }
}
