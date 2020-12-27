namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FlightsForPeriodLiveSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonFlightsForPeriodSearch;

        private System.Windows.Forms.DataGridView dataGridViewFlightsForPeriod;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsForPeriodSearch = new System.Windows.Forms.Button();
            this.dataGridViewFlightsForPeriod = new System.Windows.Forms.DataGridView();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.buttonCheckEvents = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new SolutionNorSolutionPort.UserInterface.AirportPicker();
            this.arrivalAirportPicker = new SolutionNorSolutionPort.UserInterface.AirportPicker();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewFlightsForPeriod ) ).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(668, 277);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFlightsForPeriodSearch
            // 
            this.buttonFlightsForPeriodSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonFlightsForPeriodSearch.Location = new System.Drawing.Point(570, 277);
            this.buttonFlightsForPeriodSearch.Name = "buttonFlightsForPeriodSearch";
            this.buttonFlightsForPeriodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsForPeriodSearch.TabIndex = 2;
            this.buttonFlightsForPeriodSearch.Text = "&Search";
            this.buttonFlightsForPeriodSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsForPeriodSearch.Click += new System.EventHandler(this.buttonFlightsForPeriodSearch_Click);
            // 
            // dataGridViewFlightsForPeriod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.dataGridViewFlightsForPeriod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsForPeriod.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewFlightsForPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsForPeriod.Location = new System.Drawing.Point(9, 61);
            this.dataGridViewFlightsForPeriod.MultiSelect = false;
            this.dataGridViewFlightsForPeriod.Name = "dataGridViewFlightsForPeriod";
            this.dataGridViewFlightsForPeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightsForPeriod.Size = new System.Drawing.Size(751, 210);
            this.dataGridViewFlightsForPeriod.TabIndex = 0;
            this.dataGridViewFlightsForPeriod.DoubleClick += new System.EventHandler(this.dataGridViewFlightsForPeriod_DoubleClick);
            // 
            // labelFromDateTime
            // 
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(486, 12);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(85, 13);
            this.labelFromDateTime.TabIndex = 36;
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
            this.dateTimePickerFromDateTime.TabIndex = 37;
            // 
            // labelUntilDateTime
            // 
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(488, 35);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(83, 13);
            this.labelUntilDateTime.TabIndex = 38;
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
            this.dateTimePickerUntilDateTime.TabIndex = 39;
            // 
            // buttonCheckEvents
            // 
            this.buttonCheckEvents.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCheckEvents.Location = new System.Drawing.Point(374, 277);
            this.buttonCheckEvents.Name = "buttonCheckEvents";
            this.buttonCheckEvents.Size = new System.Drawing.Size(92, 22);
            this.buttonCheckEvents.TabIndex = 41;
            this.buttonCheckEvents.Text = "C&heck Events";
            this.buttonCheckEvents.UseVisualStyleBackColor = true;
            this.buttonCheckEvents.Click += new System.EventHandler(this.buttonCheckEvents_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonEdit.Location = new System.Drawing.Point(472, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSelect.Location = new System.Drawing.Point(276, 277);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(92, 22);
            this.buttonSelect.TabIndex = 42;
            this.buttonSelect.Text = "&Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelDepartureAirportPicker
            // 
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(12, 9);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(90, 13);
            this.labelDepartureAirportPicker.TabIndex = 43;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            // 
            // labelArrivalAirportPicker
            // 
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(12, 32);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(72, 13);
            this.labelArrivalAirportPicker.TabIndex = 45;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            // 
            // departureAirportPicker
            // 
            this.departureAirportPicker.Location = new System.Drawing.Point(162, 9);
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.departureAirportPicker.Size = new System.Drawing.Size(304, 20);
            this.departureAirportPicker.TabIndex = 44;
            // 
            // arrivalAirportPicker
            // 
            this.arrivalAirportPicker.Location = new System.Drawing.Point(162, 32);
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.arrivalAirportPicker.Size = new System.Drawing.Size(304, 20);
            this.arrivalAirportPicker.TabIndex = 46;
            // 
            // FlightsForPeriodLiveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 302);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCheckEvents);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.buttonFlightsForPeriodSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewFlightsForPeriod);
            this.Name = "FlightsForPeriodLiveSearch";
            this.Text = "Flights For Period";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewFlightsForPeriod ) ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelFromDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        private System.Windows.Forms.Label labelUntilDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        private System.Windows.Forms.Button buttonCheckEvents;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelDepartureAirportPicker;
        private AirportPicker departureAirportPicker;
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        private AirportPicker arrivalAirportPicker;
    }
}
