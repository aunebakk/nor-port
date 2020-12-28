namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerTicketSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerTicketSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerTicketAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerTicketEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingPassengerTicket;
        
        private System.Windows.Forms.TextBox textBoxTicketNumber;
        
        private System.Windows.Forms.Label labelTicketNumber;
        
        private System.Windows.Forms.TextBox textBoxTicketDescription;
        
        private System.Windows.Forms.Label labelTicketDescription;
        
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
            this.buttonCrudeBookingPassengerTicketAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerTicketEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerTicketSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingPassengerTicket = new System.Windows.Forms.DataGridView();
            this.labelTicketNumber = new System.Windows.Forms.Label();
            this.textBoxTicketNumber = new System.Windows.Forms.TextBox();
            this.labelTicketDescription = new System.Windows.Forms.Label();
            this.textBoxTicketDescription = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerTicket)).BeginInit();
            this.SuspendLayout();
            //
            // labelTicketNumber
            //
            this.labelTicketNumber.AutoSize = true;
            this.labelTicketNumber.Location = new System.Drawing.Point(11, 13);
            this.labelTicketNumber.Name = "labelTicketNumber";
            this.labelTicketNumber.Size = new System.Drawing.Size(71, 13);
            this.labelTicketNumber.TabIndex = 2;
            this.labelTicketNumber.Text = "Ticket Number:";
            //
            //textBoxTicketNumber
            //
            this.textBoxTicketNumber.Location = new System.Drawing.Point(140, 13);
            this.textBoxTicketNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTicketNumber.Name = "textBoxTicketNumber";
            this.textBoxTicketNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxTicketNumber.TabIndex = 3;
            //
            // labelTicketDescription
            //
            this.labelTicketDescription.AutoSize = true;
            this.labelTicketDescription.Location = new System.Drawing.Point(11, 36);
            this.labelTicketDescription.Name = "labelTicketDescription";
            this.labelTicketDescription.Size = new System.Drawing.Size(71, 13);
            this.labelTicketDescription.TabIndex = 4;
            this.labelTicketDescription.Text = "Ticket Description:";
            //
            //textBoxTicketDescription
            //
            this.textBoxTicketDescription.Location = new System.Drawing.Point(140, 36);
            this.textBoxTicketDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTicketDescription.Name = "textBoxTicketDescription";
            this.textBoxTicketDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxTicketDescription.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeBookingPassengerTicket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingPassengerTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingPassengerTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingPassengerTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingPassengerTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingPassengerTicket.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeBookingPassengerTicket.Name = "dataGridViewCrudeBookingPassengerTicket";
            this.dataGridViewCrudeBookingPassengerTicket.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBookingPassengerTicket.TabIndex = 0;
            this.dataGridViewCrudeBookingPassengerTicket.ReadOnly = true;
            this.dataGridViewCrudeBookingPassengerTicket.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingPassengerTicket_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingPassengerTicketSearch
            // 
            this.buttonCrudeBookingPassengerTicketSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerTicketSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeBookingPassengerTicketSearch.Name = "buttonCrudeBookingPassengerTicketSearch";
            this.buttonCrudeBookingPassengerTicketSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerTicketSearch.TabIndex = 2;
            this.buttonCrudeBookingPassengerTicketSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerTicketSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerTicketSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerTicketSearch_Click);
            // 
            // buttonCrudeBookingPassengerTicketAdd
            // 
            this.buttonCrudeBookingPassengerTicketAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerTicketAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeBookingPassengerTicketAdd.Name = "buttonCrudeBookingPassengerTicketAdd";
            this.buttonCrudeBookingPassengerTicketAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerTicketAdd.TabIndex = 3;
            this.buttonCrudeBookingPassengerTicketAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerTicketAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerTicketAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerTicketAdd_Click);
            // 
            // buttonCrudeBookingPassengerTicketEdit
            // 
            this.buttonCrudeBookingPassengerTicketEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerTicketEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeBookingPassengerTicketEdit.Name = "buttonCrudeBookingPassengerTicketEdit";
            this.buttonCrudeBookingPassengerTicketEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerTicketEdit.TabIndex = 4;
            this.buttonCrudeBookingPassengerTicketEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerTicketEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerTicketEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerTicketEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeBookingPassengerTicketSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingPassengerTicketAdd);
            this.Controls.Add(this.buttonCrudeBookingPassengerTicketEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingPassengerTicket);
            this.Name = "CrudeBookingPassengerTicketSearch";
            this.Text = "Booking Passenger Ticket Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerTicket)).EndInit();
            this.Controls.Add(this.labelTicketNumber);
            this.Controls.Add(this.textBoxTicketNumber);
            this.Controls.Add(this.labelTicketDescription);
            this.Controls.Add(this.textBoxTicketDescription);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
