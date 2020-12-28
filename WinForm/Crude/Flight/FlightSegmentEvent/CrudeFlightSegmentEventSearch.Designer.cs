namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightSegmentEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightSegmentEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightSegmentEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightSegmentEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightSegmentEvent;
        
        private DateTimeTypeRefCombo dateTimeTypeRefCombo;
        
        private System.Windows.Forms.Label labelDateTimeTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxRemarks;
        
        private System.Windows.Forms.Label labelRemarks;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFlightSegmentEventNumber;
        
        private System.Windows.Forms.Label labelFlightSegmentEventNumber;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDateTime;
        
        private System.Windows.Forms.Label labelNewDateTime;
        
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
            this.buttonCrudeFlightSegmentEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightSegmentEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightSegmentEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightSegmentEvent = new System.Windows.Forms.DataGridView();
            this.labelDateTimeTypeRefCombo = new System.Windows.Forms.Label();
            this.dateTimeTypeRefCombo = new DateTimeTypeRefCombo();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelFlightSegmentEventNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxFlightSegmentEventNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelNewDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerNewDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightSegmentEvent)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateTimeTypeRefCombo
            //
            this.labelDateTimeTypeRefCombo.AutoSize = true;
            this.labelDateTimeTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDateTimeTypeRefCombo.Name = "labelDateTimeTypeRefCombo";
            this.labelDateTimeTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDateTimeTypeRefCombo.TabIndex = 2;
            this.labelDateTimeTypeRefCombo.Text = "Date Time Type:";
            //
            //dateTimeTypeRefCombo
            //
            this.dateTimeTypeRefCombo.Location = new System.Drawing.Point(189, 13);
            this.dateTimeTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTypeRefCombo.Name = "dateTimeTypeRefCombo";
            this.dateTimeTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.dateTimeTypeRefCombo.TabIndex = 3;
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
            this.textBoxRemarks.Location = new System.Drawing.Point(189, 36);
            this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 20);
            this.textBoxRemarks.TabIndex = 5;
            //
            // labelFlightSegmentEventNumber
            //
            this.labelFlightSegmentEventNumber.AutoSize = true;
            this.labelFlightSegmentEventNumber.Location = new System.Drawing.Point(11, 59);
            this.labelFlightSegmentEventNumber.Name = "labelFlightSegmentEventNumber";
            this.labelFlightSegmentEventNumber.Size = new System.Drawing.Size(71, 13);
            this.labelFlightSegmentEventNumber.TabIndex = 6;
            this.labelFlightSegmentEventNumber.Text = "Flight Segment Event Number:";
            //
            //maskedTextBoxFlightSegmentEventNumber
            //
            this.maskedTextBoxFlightSegmentEventNumber.Location = new System.Drawing.Point(189, 59);
            this.maskedTextBoxFlightSegmentEventNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxFlightSegmentEventNumber.Name = "maskedTextBoxFlightSegmentEventNumber";
            this.maskedTextBoxFlightSegmentEventNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxFlightSegmentEventNumber.TabIndex = 7;
            //
            // labelNewDateTime
            //
            this.labelNewDateTime.AutoSize = true;
            this.labelNewDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelNewDateTime.Name = "labelNewDateTime";
            this.labelNewDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelNewDateTime.TabIndex = 8;
            this.labelNewDateTime.Text = "New Date Time:";
            //
            //dateTimePickerNewDateTime
            //
            this.dateTimePickerNewDateTime.Location = new System.Drawing.Point(189, 82);
            this.dateTimePickerNewDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNewDateTime.Name = "dateTimePickerNewDateTime";
            this.dateTimePickerNewDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerNewDateTime.TabIndex = 9;
            this.dateTimePickerNewDateTime.Checked = false;
            this.dateTimePickerNewDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(189, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeFlightSegmentEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightSegmentEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightSegmentEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightSegmentEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightSegmentEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightSegmentEvent.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeFlightSegmentEvent.Name = "dataGridViewCrudeFlightSegmentEvent";
            this.dataGridViewCrudeFlightSegmentEvent.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeFlightSegmentEvent.TabIndex = 0;
            this.dataGridViewCrudeFlightSegmentEvent.ReadOnly = true;
            this.dataGridViewCrudeFlightSegmentEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightSegmentEvent_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightSegmentEventSearch
            // 
            this.buttonCrudeFlightSegmentEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSegmentEventSearch.Location = new System.Drawing.Point(247, 264);
            this.buttonCrudeFlightSegmentEventSearch.Name = "buttonCrudeFlightSegmentEventSearch";
            this.buttonCrudeFlightSegmentEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSegmentEventSearch.TabIndex = 2;
            this.buttonCrudeFlightSegmentEventSearch.Text = "&Search";
            this.buttonCrudeFlightSegmentEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSegmentEventSearch.Click += new System.EventHandler(this.buttonCrudeFlightSegmentEventSearch_Click);
            // 
            // buttonCrudeFlightSegmentEventAdd
            // 
            this.buttonCrudeFlightSegmentEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSegmentEventAdd.Location = new System.Drawing.Point(147, 264);
            this.buttonCrudeFlightSegmentEventAdd.Name = "buttonCrudeFlightSegmentEventAdd";
            this.buttonCrudeFlightSegmentEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSegmentEventAdd.TabIndex = 3;
            this.buttonCrudeFlightSegmentEventAdd.Text = "&Add";
            this.buttonCrudeFlightSegmentEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSegmentEventAdd.Click += new System.EventHandler(this.buttonCrudeFlightSegmentEventAdd_Click);
            // 
            // buttonCrudeFlightSegmentEventEdit
            // 
            this.buttonCrudeFlightSegmentEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightSegmentEventEdit.Location = new System.Drawing.Point(47, 264);
            this.buttonCrudeFlightSegmentEventEdit.Name = "buttonCrudeFlightSegmentEventEdit";
            this.buttonCrudeFlightSegmentEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightSegmentEventEdit.TabIndex = 4;
            this.buttonCrudeFlightSegmentEventEdit.Text = "&Edit";
            this.buttonCrudeFlightSegmentEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightSegmentEventEdit.Click += new System.EventHandler(this.buttonCrudeFlightSegmentEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 292);
            this.Controls.Add(this.buttonCrudeFlightSegmentEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightSegmentEventAdd);
            this.Controls.Add(this.buttonCrudeFlightSegmentEventEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightSegmentEvent);
            this.Name = "CrudeFlightSegmentEventSearch";
            this.Text = "Flight Segment Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightSegmentEvent)).EndInit();
            this.Controls.Add(this.labelDateTimeTypeRefCombo);
            this.Controls.Add(this.dateTimeTypeRefCombo);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelFlightSegmentEventNumber);
            this.Controls.Add(this.maskedTextBoxFlightSegmentEventNumber);
            this.Controls.Add(this.labelNewDateTime);
            this.Controls.Add(this.dateTimePickerNewDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
