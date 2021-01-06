namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightSegmentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightSegmentSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightSegmentAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightSegmentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightSegment;
        
        private System.Windows.Forms.TextBox textBoxDepartureGate;
        
        private System.Windows.Forms.Label labelDepartureGate;
        
        private System.Windows.Forms.TextBox textBoxArrivalGate;
        
        private System.Windows.Forms.Label labelArrivalGate;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogicalSegmentNumber;
        
        private System.Windows.Forms.Label labelLogicalSegmentNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhysicalSegmentNumber;
        
        private System.Windows.Forms.Label labelPhysicalSegmentNumber;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        
        private System.Windows.Forms.Label labelFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        
        private System.Windows.Forms.Label labelUntilDateTime;
        
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
            this.buttonCrudeFlightSegmentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightSegmentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightSegmentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightSegment = new System.Windows.Forms.DataGridView();
            this.labelDepartureGate = new System.Windows.Forms.Label();
            this.textBoxDepartureGate = new System.Windows.Forms.TextBox();
            this.labelArrivalGate = new System.Windows.Forms.Label();
            this.textBoxArrivalGate = new System.Windows.Forms.TextBox();
            this.labelLogicalSegmentNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxLogicalSegmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPhysicalSegmentNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxPhysicalSegmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightSegment)).BeginInit();
            this.SuspendLayout();
            //
            // labelDepartureGate
            //
            this.labelDepartureGate.AutoSize = true;
            this.labelDepartureGate.Location = new System.Drawing.Point(11, 13);
            this.labelDepartureGate.Name = "labelDepartureGate";
            this.labelDepartureGate.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureGate.TabIndex = 2;
            this.labelDepartureGate.Text = "Departure Gate:";
            //
            //textBoxDepartureGate
            //
            this.textBoxDepartureGate.Location = new System.Drawing.Point(161, 13);
            this.textBoxDepartureGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartureGate.Name = "textBoxDepartureGate";
            this.textBoxDepartureGate.Size = new System.Drawing.Size(250, 20);
            this.textBoxDepartureGate.TabIndex = 3;
            //
            // labelArrivalGate
            //
            this.labelArrivalGate.AutoSize = true;
            this.labelArrivalGate.Location = new System.Drawing.Point(11, 36);
            this.labelArrivalGate.Name = "labelArrivalGate";
            this.labelArrivalGate.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalGate.TabIndex = 4;
            this.labelArrivalGate.Text = "Arrival Gate:";
            //
            //textBoxArrivalGate
            //
            this.textBoxArrivalGate.Location = new System.Drawing.Point(161, 36);
            this.textBoxArrivalGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrivalGate.Name = "textBoxArrivalGate";
            this.textBoxArrivalGate.Size = new System.Drawing.Size(250, 20);
            this.textBoxArrivalGate.TabIndex = 5;
            //
            // labelLogicalSegmentNumber
            //
            this.labelLogicalSegmentNumber.AutoSize = true;
            this.labelLogicalSegmentNumber.Location = new System.Drawing.Point(11, 59);
            this.labelLogicalSegmentNumber.Name = "labelLogicalSegmentNumber";
            this.labelLogicalSegmentNumber.Size = new System.Drawing.Size(71, 13);
            this.labelLogicalSegmentNumber.TabIndex = 6;
            this.labelLogicalSegmentNumber.Text = "Logical Segment Number:";
            //
            //maskedTextBoxLogicalSegmentNumber
            //
            this.maskedTextBoxLogicalSegmentNumber.Location = new System.Drawing.Point(161, 59);
            this.maskedTextBoxLogicalSegmentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLogicalSegmentNumber.Name = "maskedTextBoxLogicalSegmentNumber";
            this.maskedTextBoxLogicalSegmentNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLogicalSegmentNumber.TabIndex = 7;
            //
            // labelPhysicalSegmentNumber
            //
            this.labelPhysicalSegmentNumber.AutoSize = true;
            this.labelPhysicalSegmentNumber.Location = new System.Drawing.Point(11, 82);
            this.labelPhysicalSegmentNumber.Name = "labelPhysicalSegmentNumber";
            this.labelPhysicalSegmentNumber.Size = new System.Drawing.Size(71, 13);
            this.labelPhysicalSegmentNumber.TabIndex = 8;
            this.labelPhysicalSegmentNumber.Text = "Physical Segment Number:";
            //
            //maskedTextBoxPhysicalSegmentNumber
            //
            this.maskedTextBoxPhysicalSegmentNumber.Location = new System.Drawing.Point(161, 82);
            this.maskedTextBoxPhysicalSegmentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhysicalSegmentNumber.Name = "maskedTextBoxPhysicalSegmentNumber";
            this.maskedTextBoxPhysicalSegmentNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPhysicalSegmentNumber.TabIndex = 9;
            //
            // labelFromDateTime
            //
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFromDateTime.TabIndex = 10;
            this.labelFromDateTime.Text = "From Date Time:";
            //
            //dateTimePickerFromDateTime
            //
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(161, 105);
            this.dateTimePickerFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFromDateTime.TabIndex = 11;
            this.dateTimePickerFromDateTime.Checked = false;
            this.dateTimePickerFromDateTime.ShowCheckBox = true;
            //
            // labelUntilDateTime
            //
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelUntilDateTime.TabIndex = 12;
            this.labelUntilDateTime.Text = "Until Date Time:";
            //
            //dateTimePickerUntilDateTime
            //
            this.dateTimePickerUntilDateTime.Location = new System.Drawing.Point(161, 128);
            this.dateTimePickerUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerUntilDateTime.Name = "dateTimePickerUntilDateTime";
            this.dateTimePickerUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerUntilDateTime.TabIndex = 13;
            this.dateTimePickerUntilDateTime.Checked = false;
            this.dateTimePickerUntilDateTime.ShowCheckBox = true;
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
            // dataGridViewCrudeFlightSegment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightSegment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightSegment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightSegment.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewCrudeFlightSegment.Name = "dataGridViewCrudeFlightSegment";
            this.dataGridViewCrudeFlightSegment.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeFlightSegment.TabIndex = 0;
            this.dataGridViewCrudeFlightSegment.ReadOnly = true;
            this.dataGridViewCrudeFlightSegment.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightSegment_DoubleClick);
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
            // buttonCrudeFlightSegmentSearch
            // 
            this.buttonCrudeFlightSegmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSegmentSearch.Location = new System.Drawing.Point(219, 356);
            this.buttonCrudeFlightSegmentSearch.Name = "buttonCrudeFlightSegmentSearch";
            this.buttonCrudeFlightSegmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSegmentSearch.TabIndex = 2;
            this.buttonCrudeFlightSegmentSearch.Text = "&Search";
            this.buttonCrudeFlightSegmentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSegmentSearch.Click += new System.EventHandler(this.buttonCrudeFlightSegmentSearch_Click);
            // 
            // buttonCrudeFlightSegmentAdd
            // 
            this.buttonCrudeFlightSegmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSegmentAdd.Location = new System.Drawing.Point(119, 356);
            this.buttonCrudeFlightSegmentAdd.Name = "buttonCrudeFlightSegmentAdd";
            this.buttonCrudeFlightSegmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSegmentAdd.TabIndex = 3;
            this.buttonCrudeFlightSegmentAdd.Text = "&Add";
            this.buttonCrudeFlightSegmentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSegmentAdd.Click += new System.EventHandler(this.buttonCrudeFlightSegmentAdd_Click);
            // 
            // buttonCrudeFlightSegmentEdit
            // 
            this.buttonCrudeFlightSegmentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSegmentEdit.Location = new System.Drawing.Point(19, 356);
            this.buttonCrudeFlightSegmentEdit.Name = "buttonCrudeFlightSegmentEdit";
            this.buttonCrudeFlightSegmentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSegmentEdit.TabIndex = 4;
            this.buttonCrudeFlightSegmentEdit.Text = "&Edit";
            this.buttonCrudeFlightSegmentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSegmentEdit.Click += new System.EventHandler(this.buttonCrudeFlightSegmentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 384);
            this.Controls.Add(this.buttonCrudeFlightSegmentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightSegmentAdd);
            this.Controls.Add(this.buttonCrudeFlightSegmentEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightSegment);
            this.Name = "CrudeFlightSegmentSearch";
            this.Text = "Flight Segment Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightSegment)).EndInit();
            this.Controls.Add(this.labelDepartureGate);
            this.Controls.Add(this.textBoxDepartureGate);
            this.Controls.Add(this.labelArrivalGate);
            this.Controls.Add(this.textBoxArrivalGate);
            this.Controls.Add(this.labelLogicalSegmentNumber);
            this.Controls.Add(this.maskedTextBoxLogicalSegmentNumber);
            this.Controls.Add(this.labelPhysicalSegmentNumber);
            this.Controls.Add(this.maskedTextBoxPhysicalSegmentNumber);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
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
