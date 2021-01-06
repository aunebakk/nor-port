namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingPassengerEvent;
        
        private BookingPassengerEventTypeRefCombo bookingPassengerEventTypeRefCombo;
        
        private System.Windows.Forms.Label labelBookingPassengerEventTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxRemarks;
        
        private System.Windows.Forms.Label labelRemarks;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBookingPassengerEventNumber;
        
        private System.Windows.Forms.Label labelBookingPassengerEventNumber;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
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
            this.buttonCrudeBookingPassengerEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingPassengerEvent = new System.Windows.Forms.DataGridView();
            this.labelBookingPassengerEventTypeRefCombo = new System.Windows.Forms.Label();
            this.bookingPassengerEventTypeRefCombo = new BookingPassengerEventTypeRefCombo();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelBookingPassengerEventNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxBookingPassengerEventNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerEvent)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingPassengerEventTypeRefCombo
            //
            this.labelBookingPassengerEventTypeRefCombo.AutoSize = true;
            this.labelBookingPassengerEventTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelBookingPassengerEventTypeRefCombo.Name = "labelBookingPassengerEventTypeRefCombo";
            this.labelBookingPassengerEventTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventTypeRefCombo.TabIndex = 2;
            this.labelBookingPassengerEventTypeRefCombo.Text = "Booking Passenger Event Type:";
            //
            //bookingPassengerEventTypeRefCombo
            //
            this.bookingPassengerEventTypeRefCombo.Location = new System.Drawing.Point(210, 13);
            this.bookingPassengerEventTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingPassengerEventTypeRefCombo.Name = "bookingPassengerEventTypeRefCombo";
            this.bookingPassengerEventTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.bookingPassengerEventTypeRefCombo.TabIndex = 3;
            //
            // labelRemarks
            //
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(11, 36);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(71, 13);
            this.labelRemarks.TabIndex = 4;
            this.labelRemarks.Text = "Remarks:";
            //
            //textBoxRemarks
            //
            this.textBoxRemarks.Location = new System.Drawing.Point(210, 36);
            this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 20);
            this.textBoxRemarks.TabIndex = 5;
            //
            // labelBookingPassengerEventNumber
            //
            this.labelBookingPassengerEventNumber.AutoSize = true;
            this.labelBookingPassengerEventNumber.Location = new System.Drawing.Point(11, 59);
            this.labelBookingPassengerEventNumber.Name = "labelBookingPassengerEventNumber";
            this.labelBookingPassengerEventNumber.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventNumber.TabIndex = 6;
            this.labelBookingPassengerEventNumber.Text = "Booking Passenger Event Number:";
            //
            //maskedTextBoxBookingPassengerEventNumber
            //
            this.maskedTextBoxBookingPassengerEventNumber.Location = new System.Drawing.Point(210, 59);
            this.maskedTextBoxBookingPassengerEventNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxBookingPassengerEventNumber.Name = "maskedTextBoxBookingPassengerEventNumber";
            this.maskedTextBoxBookingPassengerEventNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxBookingPassengerEventNumber.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
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
            this.userPicker.Location = new System.Drawing.Point(210, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeBookingPassengerEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingPassengerEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingPassengerEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingPassengerEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingPassengerEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingPassengerEvent.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeBookingPassengerEvent.Name = "dataGridViewCrudeBookingPassengerEvent";
            this.dataGridViewCrudeBookingPassengerEvent.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeBookingPassengerEvent.TabIndex = 0;
            this.dataGridViewCrudeBookingPassengerEvent.ReadOnly = true;
            this.dataGridViewCrudeBookingPassengerEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingPassengerEvent_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingPassengerEventSearch
            // 
            this.buttonCrudeBookingPassengerEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEventSearch.Location = new System.Drawing.Point(268, 241);
            this.buttonCrudeBookingPassengerEventSearch.Name = "buttonCrudeBookingPassengerEventSearch";
            this.buttonCrudeBookingPassengerEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEventSearch.TabIndex = 2;
            this.buttonCrudeBookingPassengerEventSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEventSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEventSearch_Click);
            // 
            // buttonCrudeBookingPassengerEventAdd
            // 
            this.buttonCrudeBookingPassengerEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEventAdd.Location = new System.Drawing.Point(168, 241);
            this.buttonCrudeBookingPassengerEventAdd.Name = "buttonCrudeBookingPassengerEventAdd";
            this.buttonCrudeBookingPassengerEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEventAdd.TabIndex = 3;
            this.buttonCrudeBookingPassengerEventAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEventAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEventAdd_Click);
            // 
            // buttonCrudeBookingPassengerEventEdit
            // 
            this.buttonCrudeBookingPassengerEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEventEdit.Location = new System.Drawing.Point(68, 241);
            this.buttonCrudeBookingPassengerEventEdit.Name = "buttonCrudeBookingPassengerEventEdit";
            this.buttonCrudeBookingPassengerEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEventEdit.TabIndex = 4;
            this.buttonCrudeBookingPassengerEventEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEventEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 269);
            this.Controls.Add(this.buttonCrudeBookingPassengerEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingPassengerEventAdd);
            this.Controls.Add(this.buttonCrudeBookingPassengerEventEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingPassengerEvent);
            this.Name = "CrudeBookingPassengerEventSearch";
            this.Text = "Booking Passenger Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerEvent)).EndInit();
            this.Controls.Add(this.labelBookingPassengerEventTypeRefCombo);
            this.Controls.Add(this.bookingPassengerEventTypeRefCombo);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelBookingPassengerEventNumber);
            this.Controls.Add(this.maskedTextBoxBookingPassengerEventNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
