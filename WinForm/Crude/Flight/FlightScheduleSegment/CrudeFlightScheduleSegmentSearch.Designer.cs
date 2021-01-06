namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleSegmentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightScheduleSegment;
        
        private System.Windows.Forms.TextBox textBoxDepartureTime;
        
        private System.Windows.Forms.Label labelDepartureTime;
        
        private System.Windows.Forms.TextBox textBoxArrivalTime;
        
        private System.Windows.Forms.Label labelArrivalTime;
        
        private System.Windows.Forms.TextBox textBoxDepartureGate;
        
        private System.Windows.Forms.Label labelDepartureGate;
        
        private System.Windows.Forms.TextBox textBoxArrivalGate;
        
        private System.Windows.Forms.Label labelArrivalGate;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhysicalSegmentNumber;
        
        private System.Windows.Forms.Label labelPhysicalSegmentNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogicalSegmentNumber;
        
        private System.Windows.Forms.Label labelLogicalSegmentNumber;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
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
            this.buttonCrudeFlightScheduleSegmentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightScheduleSegment = new System.Windows.Forms.DataGridView();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.textBoxDepartureTime = new System.Windows.Forms.TextBox();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.labelDepartureGate = new System.Windows.Forms.Label();
            this.textBoxDepartureGate = new System.Windows.Forms.TextBox();
            this.labelArrivalGate = new System.Windows.Forms.Label();
            this.textBoxArrivalGate = new System.Windows.Forms.TextBox();
            this.labelPhysicalSegmentNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxPhysicalSegmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelLogicalSegmentNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxLogicalSegmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleSegment)).BeginInit();
            this.SuspendLayout();
            //
            // labelDepartureTime
            //
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(11, 13);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureTime.TabIndex = 2;
            this.labelDepartureTime.Text = "Departure Time:";
            //
            //textBoxDepartureTime
            //
            this.textBoxDepartureTime.Location = new System.Drawing.Point(161, 13);
            this.textBoxDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartureTime.Name = "textBoxDepartureTime";
            this.textBoxDepartureTime.Size = new System.Drawing.Size(250, 20);
            this.textBoxDepartureTime.TabIndex = 3;
            //
            // labelArrivalTime
            //
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Location = new System.Drawing.Point(11, 36);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalTime.TabIndex = 4;
            this.labelArrivalTime.Text = "Arrival Time:";
            //
            //textBoxArrivalTime
            //
            this.textBoxArrivalTime.Location = new System.Drawing.Point(161, 36);
            this.textBoxArrivalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrivalTime.Name = "textBoxArrivalTime";
            this.textBoxArrivalTime.Size = new System.Drawing.Size(250, 20);
            this.textBoxArrivalTime.TabIndex = 5;
            //
            // labelDepartureGate
            //
            this.labelDepartureGate.AutoSize = true;
            this.labelDepartureGate.Location = new System.Drawing.Point(11, 59);
            this.labelDepartureGate.Name = "labelDepartureGate";
            this.labelDepartureGate.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureGate.TabIndex = 6;
            this.labelDepartureGate.Text = "Departure Gate:";
            //
            //textBoxDepartureGate
            //
            this.textBoxDepartureGate.Location = new System.Drawing.Point(161, 59);
            this.textBoxDepartureGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartureGate.Name = "textBoxDepartureGate";
            this.textBoxDepartureGate.Size = new System.Drawing.Size(250, 20);
            this.textBoxDepartureGate.TabIndex = 7;
            //
            // labelArrivalGate
            //
            this.labelArrivalGate.AutoSize = true;
            this.labelArrivalGate.Location = new System.Drawing.Point(11, 82);
            this.labelArrivalGate.Name = "labelArrivalGate";
            this.labelArrivalGate.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalGate.TabIndex = 8;
            this.labelArrivalGate.Text = "Arrival Gate:";
            //
            //textBoxArrivalGate
            //
            this.textBoxArrivalGate.Location = new System.Drawing.Point(161, 82);
            this.textBoxArrivalGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrivalGate.Name = "textBoxArrivalGate";
            this.textBoxArrivalGate.Size = new System.Drawing.Size(250, 20);
            this.textBoxArrivalGate.TabIndex = 9;
            //
            // labelPhysicalSegmentNumber
            //
            this.labelPhysicalSegmentNumber.AutoSize = true;
            this.labelPhysicalSegmentNumber.Location = new System.Drawing.Point(11, 105);
            this.labelPhysicalSegmentNumber.Name = "labelPhysicalSegmentNumber";
            this.labelPhysicalSegmentNumber.Size = new System.Drawing.Size(71, 13);
            this.labelPhysicalSegmentNumber.TabIndex = 10;
            this.labelPhysicalSegmentNumber.Text = "Physical Segment Number:";
            //
            //maskedTextBoxPhysicalSegmentNumber
            //
            this.maskedTextBoxPhysicalSegmentNumber.Location = new System.Drawing.Point(161, 105);
            this.maskedTextBoxPhysicalSegmentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhysicalSegmentNumber.Name = "maskedTextBoxPhysicalSegmentNumber";
            this.maskedTextBoxPhysicalSegmentNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPhysicalSegmentNumber.TabIndex = 11;
            //
            // labelLogicalSegmentNumber
            //
            this.labelLogicalSegmentNumber.AutoSize = true;
            this.labelLogicalSegmentNumber.Location = new System.Drawing.Point(11, 128);
            this.labelLogicalSegmentNumber.Name = "labelLogicalSegmentNumber";
            this.labelLogicalSegmentNumber.Size = new System.Drawing.Size(71, 13);
            this.labelLogicalSegmentNumber.TabIndex = 12;
            this.labelLogicalSegmentNumber.Text = "Logical Segment Number:";
            //
            //maskedTextBoxLogicalSegmentNumber
            //
            this.maskedTextBoxLogicalSegmentNumber.Location = new System.Drawing.Point(161, 128);
            this.maskedTextBoxLogicalSegmentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLogicalSegmentNumber.Name = "maskedTextBoxLogicalSegmentNumber";
            this.maskedTextBoxLogicalSegmentNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLogicalSegmentNumber.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            //
            // labelDepartureAirportPicker
            //
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(11, 174);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureAirportPicker.TabIndex = 16;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            //
            //departureAirportPicker
            //
            this.departureAirportPicker.Location = new System.Drawing.Point(161, 174);
            this.departureAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.departureAirportPicker.TabIndex = 17;
            //
            // labelArrivalAirportPicker
            //
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(11, 197);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalAirportPicker.TabIndex = 18;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            //
            //arrivalAirportPicker
            //
            this.arrivalAirportPicker.Location = new System.Drawing.Point(161, 197);
            this.arrivalAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.arrivalAirportPicker.TabIndex = 19;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 220);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 20;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(161, 220);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 21;
            // 
            // dataGridViewCrudeFlightScheduleSegment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightScheduleSegment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightScheduleSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightScheduleSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightScheduleSegment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightScheduleSegment.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewCrudeFlightScheduleSegment.Name = "dataGridViewCrudeFlightScheduleSegment";
            this.dataGridViewCrudeFlightScheduleSegment.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeFlightScheduleSegment.TabIndex = 0;
            this.dataGridViewCrudeFlightScheduleSegment.ReadOnly = true;
            this.dataGridViewCrudeFlightScheduleSegment.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightScheduleSegment_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 356);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightScheduleSegmentSearch
            // 
            this.buttonCrudeFlightScheduleSegmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentSearch.Location = new System.Drawing.Point(219, 356);
            this.buttonCrudeFlightScheduleSegmentSearch.Name = "buttonCrudeFlightScheduleSegmentSearch";
            this.buttonCrudeFlightScheduleSegmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentSearch.TabIndex = 2;
            this.buttonCrudeFlightScheduleSegmentSearch.Text = "&Search";
            this.buttonCrudeFlightScheduleSegmentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentSearch.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentSearch_Click);
            // 
            // buttonCrudeFlightScheduleSegmentAdd
            // 
            this.buttonCrudeFlightScheduleSegmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentAdd.Location = new System.Drawing.Point(119, 356);
            this.buttonCrudeFlightScheduleSegmentAdd.Name = "buttonCrudeFlightScheduleSegmentAdd";
            this.buttonCrudeFlightScheduleSegmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentAdd.TabIndex = 3;
            this.buttonCrudeFlightScheduleSegmentAdd.Text = "&Add";
            this.buttonCrudeFlightScheduleSegmentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentAdd.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentAdd_Click);
            // 
            // buttonCrudeFlightScheduleSegmentEdit
            // 
            this.buttonCrudeFlightScheduleSegmentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentEdit.Location = new System.Drawing.Point(19, 356);
            this.buttonCrudeFlightScheduleSegmentEdit.Name = "buttonCrudeFlightScheduleSegmentEdit";
            this.buttonCrudeFlightScheduleSegmentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentEdit.TabIndex = 4;
            this.buttonCrudeFlightScheduleSegmentEdit.Text = "&Edit";
            this.buttonCrudeFlightScheduleSegmentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentEdit.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 384);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentAdd);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightScheduleSegment);
            this.Name = "CrudeFlightScheduleSegmentSearch";
            this.Text = "Flight Schedule Segment Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleSegment)).EndInit();
            this.Controls.Add(this.labelDepartureTime);
            this.Controls.Add(this.textBoxDepartureTime);
            this.Controls.Add(this.labelArrivalTime);
            this.Controls.Add(this.textBoxArrivalTime);
            this.Controls.Add(this.labelDepartureGate);
            this.Controls.Add(this.textBoxDepartureGate);
            this.Controls.Add(this.labelArrivalGate);
            this.Controls.Add(this.textBoxArrivalGate);
            this.Controls.Add(this.labelPhysicalSegmentNumber);
            this.Controls.Add(this.maskedTextBoxPhysicalSegmentNumber);
            this.Controls.Add(this.labelLogicalSegmentNumber);
            this.Controls.Add(this.maskedTextBoxLogicalSegmentNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
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
