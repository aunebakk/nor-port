namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerSeatSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerSeatSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerSeatAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerSeatEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingPassengerSeat;
        
        private System.Windows.Forms.TextBox textBoxSeatNumber;
        
        private System.Windows.Forms.Label labelSeatNumber;
        
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
            this.buttonCrudeBookingPassengerSeatAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerSeatEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerSeatSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingPassengerSeat = new System.Windows.Forms.DataGridView();
            this.labelSeatNumber = new System.Windows.Forms.Label();
            this.textBoxSeatNumber = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerSeat)).BeginInit();
            this.SuspendLayout();
            //
            // labelSeatNumber
            //
            this.labelSeatNumber.AutoSize = true;
            this.labelSeatNumber.Location = new System.Drawing.Point(11, 13);
            this.labelSeatNumber.Name = "labelSeatNumber";
            this.labelSeatNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSeatNumber.TabIndex = 2;
            this.labelSeatNumber.Text = "Seat Number:";
            //
            //textBoxSeatNumber
            //
            this.textBoxSeatNumber.Location = new System.Drawing.Point(140, 13);
            this.textBoxSeatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSeatNumber.Name = "textBoxSeatNumber";
            this.textBoxSeatNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxSeatNumber.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            // 
            // dataGridViewCrudeBookingPassengerSeat
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingPassengerSeat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingPassengerSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingPassengerSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingPassengerSeat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingPassengerSeat.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingPassengerSeat.Name = "dataGridViewCrudeBookingPassengerSeat";
            this.dataGridViewCrudeBookingPassengerSeat.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBookingPassengerSeat.TabIndex = 0;
            this.dataGridViewCrudeBookingPassengerSeat.ReadOnly = true;
            this.dataGridViewCrudeBookingPassengerSeat.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingPassengerSeat_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingPassengerSeatSearch
            // 
            this.buttonCrudeBookingPassengerSeatSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerSeatSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeBookingPassengerSeatSearch.Name = "buttonCrudeBookingPassengerSeatSearch";
            this.buttonCrudeBookingPassengerSeatSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerSeatSearch.TabIndex = 2;
            this.buttonCrudeBookingPassengerSeatSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerSeatSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerSeatSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerSeatSearch_Click);
            // 
            // buttonCrudeBookingPassengerSeatAdd
            // 
            this.buttonCrudeBookingPassengerSeatAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerSeatAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeBookingPassengerSeatAdd.Name = "buttonCrudeBookingPassengerSeatAdd";
            this.buttonCrudeBookingPassengerSeatAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerSeatAdd.TabIndex = 3;
            this.buttonCrudeBookingPassengerSeatAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerSeatAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerSeatAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerSeatAdd_Click);
            // 
            // buttonCrudeBookingPassengerSeatEdit
            // 
            this.buttonCrudeBookingPassengerSeatEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerSeatEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeBookingPassengerSeatEdit.Name = "buttonCrudeBookingPassengerSeatEdit";
            this.buttonCrudeBookingPassengerSeatEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerSeatEdit.TabIndex = 4;
            this.buttonCrudeBookingPassengerSeatEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerSeatEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerSeatEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerSeatEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeBookingPassengerSeatSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingPassengerSeatAdd);
            this.Controls.Add(this.buttonCrudeBookingPassengerSeatEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingPassengerSeat);
            this.Name = "CrudeBookingPassengerSeatSearch";
            this.Text = "Booking Passenger Seat Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerSeat)).EndInit();
            this.Controls.Add(this.labelSeatNumber);
            this.Controls.Add(this.textBoxSeatNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
