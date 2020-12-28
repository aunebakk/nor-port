namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingPassenger;
        
        private DefaultStateRefCombo defaultStateRefCombo;
        
        private System.Windows.Forms.Label labelDefaultStateRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private PassengerPicker passengerPicker;
        
        private System.Windows.Forms.Label labelPassengerPicker;
        
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
            this.buttonCrudeBookingPassengerAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingPassenger = new System.Windows.Forms.DataGridView();
            this.labelDefaultStateRefCombo = new System.Windows.Forms.Label();
            this.defaultStateRefCombo = new DefaultStateRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelPassengerPicker = new System.Windows.Forms.Label();
            this.passengerPicker = new PassengerPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassenger)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultStateRefCombo
            //
            this.labelDefaultStateRefCombo.AutoSize = true;
            this.labelDefaultStateRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultStateRefCombo.Name = "labelDefaultStateRefCombo";
            this.labelDefaultStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultStateRefCombo.TabIndex = 2;
            this.labelDefaultStateRefCombo.Text = "Default State:";
            //
            //defaultStateRefCombo
            //
            this.defaultStateRefCombo.Location = new System.Drawing.Point(175, 13);
            this.defaultStateRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultStateRefCombo.Name = "defaultStateRefCombo";
            this.defaultStateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultStateRefCombo.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelPassengerPicker
            //
            this.labelPassengerPicker.AutoSize = true;
            this.labelPassengerPicker.Location = new System.Drawing.Point(11, 59);
            this.labelPassengerPicker.Name = "labelPassengerPicker";
            this.labelPassengerPicker.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerPicker.TabIndex = 6;
            this.labelPassengerPicker.Text = "Passenger:";
            //
            //passengerPicker
            //
            this.passengerPicker.Location = new System.Drawing.Point(175, 59);
            this.passengerPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerPicker.Name = "passengerPicker";
            this.passengerPicker.Size = new System.Drawing.Size(250, 20);
            this.passengerPicker.TabIndex = 7;
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
            this.userPicker.Location = new System.Drawing.Point(175, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeBookingPassenger
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingPassenger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingPassenger.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeBookingPassenger.Name = "dataGridViewCrudeBookingPassenger";
            this.dataGridViewCrudeBookingPassenger.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeBookingPassenger.TabIndex = 0;
            this.dataGridViewCrudeBookingPassenger.ReadOnly = true;
            this.dataGridViewCrudeBookingPassenger.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingPassenger_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingPassengerSearch
            // 
            this.buttonCrudeBookingPassengerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerSearch.Location = new System.Drawing.Point(233, 218);
            this.buttonCrudeBookingPassengerSearch.Name = "buttonCrudeBookingPassengerSearch";
            this.buttonCrudeBookingPassengerSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerSearch.TabIndex = 2;
            this.buttonCrudeBookingPassengerSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerSearch_Click);
            // 
            // buttonCrudeBookingPassengerAdd
            // 
            this.buttonCrudeBookingPassengerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerAdd.Location = new System.Drawing.Point(133, 218);
            this.buttonCrudeBookingPassengerAdd.Name = "buttonCrudeBookingPassengerAdd";
            this.buttonCrudeBookingPassengerAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerAdd.TabIndex = 3;
            this.buttonCrudeBookingPassengerAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerAdd_Click);
            // 
            // buttonCrudeBookingPassengerEdit
            // 
            this.buttonCrudeBookingPassengerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEdit.Location = new System.Drawing.Point(33, 218);
            this.buttonCrudeBookingPassengerEdit.Name = "buttonCrudeBookingPassengerEdit";
            this.buttonCrudeBookingPassengerEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEdit.TabIndex = 4;
            this.buttonCrudeBookingPassengerEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 246);
            this.Controls.Add(this.buttonCrudeBookingPassengerSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingPassengerAdd);
            this.Controls.Add(this.buttonCrudeBookingPassengerEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingPassenger);
            this.Name = "CrudeBookingPassengerSearch";
            this.Text = "Booking Passenger Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassenger)).EndInit();
            this.Controls.Add(this.labelDefaultStateRefCombo);
            this.Controls.Add(this.defaultStateRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelPassengerPicker);
            this.Controls.Add(this.passengerPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
