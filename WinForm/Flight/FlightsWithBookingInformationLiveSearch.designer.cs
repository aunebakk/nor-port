namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FlightsWithBookingInformationLiveSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonFlightsWithBookingInformationSearch;

        private System.Windows.Forms.DataGridView dataGridViewFlightsWithBookingInformation;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsWithBookingInformationSearch = new System.Windows.Forms.Button();
            this.dataGridViewFlightsWithBookingInformation = new System.Windows.Forms.DataGridView();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new SolutionNorSolutionPort.UserInterface.AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new SolutionNorSolutionPort.UserInterface.AirportPicker();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewFlightsWithBookingInformation ) ).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(669, 277);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFlightsWithBookingInformationSearch
            // 
            this.buttonFlightsWithBookingInformationSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonFlightsWithBookingInformationSearch.Location = new System.Drawing.Point(571, 277);
            this.buttonFlightsWithBookingInformationSearch.Name = "buttonFlightsWithBookingInformationSearch";
            this.buttonFlightsWithBookingInformationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsWithBookingInformationSearch.TabIndex = 2;
            this.buttonFlightsWithBookingInformationSearch.Text = "&Search";
            this.buttonFlightsWithBookingInformationSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsWithBookingInformationSearch.Click += new System.EventHandler(this.buttonFlightsWithBookingInformationSearch_Click);
            // 
            // dataGridViewFlightsWithBookingInformation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.dataGridViewFlightsWithBookingInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsWithBookingInformation.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewFlightsWithBookingInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsWithBookingInformation.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewFlightsWithBookingInformation.Name = "dataGridViewFlightsWithBookingInformation";
            this.dataGridViewFlightsWithBookingInformation.Size = new System.Drawing.Size(749, 210);
            this.dataGridViewFlightsWithBookingInformation.TabIndex = 0;
            // 
            // labelDepartureAirportPicker
            // 
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(12, 9);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(90, 13);
            this.labelDepartureAirportPicker.TabIndex = 51;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            // 
            // departureAirportPicker
            // 
            this.departureAirportPicker.Location = new System.Drawing.Point(162, 9);
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.departureAirportPicker.Size = new System.Drawing.Size(304, 20);
            this.departureAirportPicker.TabIndex = 52;
            // 
            // labelArrivalAirportPicker
            // 
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(12, 32);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(72, 13);
            this.labelArrivalAirportPicker.TabIndex = 53;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            // 
            // arrivalAirportPicker
            // 
            this.arrivalAirportPicker.Location = new System.Drawing.Point(162, 32);
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.arrivalAirportPicker.Size = new System.Drawing.Size(304, 20);
            this.arrivalAirportPicker.TabIndex = 54;
            // 
            // labelFromDateTime
            // 
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(486, 12);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(85, 13);
            this.labelFromDateTime.TabIndex = 47;
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
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerFromDateTime.TabIndex = 48;
            // 
            // labelUntilDateTime
            // 
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(488, 35);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(83, 13);
            this.labelUntilDateTime.TabIndex = 49;
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
            this.dateTimePickerUntilDateTime.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerUntilDateTime.TabIndex = 50;
            // 
            // FlightsWithBookingInformationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 302);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.buttonFlightsWithBookingInformationSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewFlightsWithBookingInformation);
            this.Name = "FlightsWithBookingInformationSearch";
            this.Text = "Flights With Booking Information";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewFlightsWithBookingInformation ) ).EndInit();
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
    }
}
