﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlight;
        
        private AircraftTypeRefCombo aircraftTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        
        private System.Windows.Forms.Label labelFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        
        private System.Windows.Forms.Label labelUntilDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
        private AirportPicker departureAirportPicker;
        
        private System.Windows.Forms.Label labelDepartureAirportPicker;
        
        private AirportPicker arrivalAirportPicker;
        
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFlightAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlight = new System.Windows.Forms.DataGridView();
            this.labelAircraftTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftTypeRefCombo = new AircraftTypeRefCombo();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlight)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftTypeRefCombo
            //
            this.labelAircraftTypeRefCombo.AutoSize = true;
            this.labelAircraftTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftTypeRefCombo.Name = "labelAircraftTypeRefCombo";
            this.labelAircraftTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftTypeRefCombo.TabIndex = 2;
            this.labelAircraftTypeRefCombo.Text = "Aircraft Type:";
            //
            //aircraftTypeRefCombo
            //
            this.aircraftTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.aircraftTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftTypeRefCombo.Name = "aircraftTypeRefCombo";
            this.aircraftTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftTypeRefCombo.TabIndex = 3;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 36);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 4;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(140, 36);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 5;
            //
            // labelFromDateTime
            //
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFromDateTime.TabIndex = 6;
            this.labelFromDateTime.Text = "From Date Time:";
            //
            //dateTimePickerFromDateTime
            //
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFromDateTime.TabIndex = 7;
            this.dateTimePickerFromDateTime.Checked = false;
            this.dateTimePickerFromDateTime.ShowCheckBox = true;
            //
            // labelUntilDateTime
            //
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelUntilDateTime.TabIndex = 8;
            this.labelUntilDateTime.Text = "Until Date Time:";
            //
            //dateTimePickerUntilDateTime
            //
            this.dateTimePickerUntilDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerUntilDateTime.Name = "dateTimePickerUntilDateTime";
            this.dateTimePickerUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerUntilDateTime.TabIndex = 9;
            this.dateTimePickerUntilDateTime.Checked = false;
            this.dateTimePickerUntilDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 128);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 12;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(140, 128);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 13;
            //
            // labelDepartureAirportPicker
            //
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(11, 151);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureAirportPicker.TabIndex = 14;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            //
            //departureAirportPicker
            //
            this.departureAirportPicker.Location = new System.Drawing.Point(140, 151);
            this.departureAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.departureAirportPicker.TabIndex = 15;
            //
            // labelArrivalAirportPicker
            //
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(11, 174);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalAirportPicker.TabIndex = 16;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            //
            //arrivalAirportPicker
            //
            this.arrivalAirportPicker.Location = new System.Drawing.Point(140, 174);
            this.arrivalAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.arrivalAirportPicker.TabIndex = 17;
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
            this.userPicker.Location = new System.Drawing.Point(140, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            // 
            // dataGridViewCrudeFlight
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlight.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlight.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewCrudeFlight.Name = "dataGridViewCrudeFlight";
            this.dataGridViewCrudeFlight.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFlight.TabIndex = 0;
            this.dataGridViewCrudeFlight.ReadOnly = true;
            this.dataGridViewCrudeFlight.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlight_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 333);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightSearch
            // 
            this.buttonCrudeFlightSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSearch.Location = new System.Drawing.Point(198, 333);
            this.buttonCrudeFlightSearch.Name = "buttonCrudeFlightSearch";
            this.buttonCrudeFlightSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSearch.TabIndex = 2;
            this.buttonCrudeFlightSearch.Text = "&Search";
            this.buttonCrudeFlightSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSearch.Click += new System.EventHandler(this.buttonCrudeFlightSearch_Click);
            // 
            // buttonCrudeFlightAdd
            // 
            this.buttonCrudeFlightAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightAdd.Location = new System.Drawing.Point(98, 333);
            this.buttonCrudeFlightAdd.Name = "buttonCrudeFlightAdd";
            this.buttonCrudeFlightAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightAdd.TabIndex = 3;
            this.buttonCrudeFlightAdd.Text = "&Add";
            this.buttonCrudeFlightAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightAdd.Click += new System.EventHandler(this.buttonCrudeFlightAdd_Click);
            // 
            // buttonCrudeFlightEdit
            // 
            this.buttonCrudeFlightEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightEdit.Location = new System.Drawing.Point(-2, 333);
            this.buttonCrudeFlightEdit.Name = "buttonCrudeFlightEdit";
            this.buttonCrudeFlightEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightEdit.TabIndex = 4;
            this.buttonCrudeFlightEdit.Text = "&Edit";
            this.buttonCrudeFlightEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightEdit.Click += new System.EventHandler(this.buttonCrudeFlightEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 361);
            this.Controls.Add(this.buttonCrudeFlightSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightAdd);
            this.Controls.Add(this.buttonCrudeFlightEdit);
            this.Controls.Add(this.dataGridViewCrudeFlight);
            this.Name = "CrudeFlightSearch";
            this.Text = "Flight Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlight)).EndInit();
            this.Controls.Add(this.labelAircraftTypeRefCombo);
            this.Controls.Add(this.aircraftTypeRefCombo);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}