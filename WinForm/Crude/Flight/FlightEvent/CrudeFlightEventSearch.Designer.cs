namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightEvent;
        
        private DateTimeTypeRefCombo dateTimeTypeRefCombo;
        
        private System.Windows.Forms.Label labelDateTimeTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxRemarks;
        
        private System.Windows.Forms.Label labelRemarks;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFlightEventNumber;
        
        private System.Windows.Forms.Label labelFlightEventNumber;
        
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
            this.buttonCrudeFlightEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightEvent = new System.Windows.Forms.DataGridView();
            this.labelDateTimeTypeRefCombo = new System.Windows.Forms.Label();
            this.dateTimeTypeRefCombo = new DateTimeTypeRefCombo();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelFlightEventNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxFlightEventNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelNewDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerNewDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightEvent)).BeginInit();
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
            this.dateTimeTypeRefCombo.Location = new System.Drawing.Point(140, 13);
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
            this.textBoxRemarks.Location = new System.Drawing.Point(140, 36);
            this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 20);
            this.textBoxRemarks.TabIndex = 5;
            //
            // labelFlightEventNumber
            //
            this.labelFlightEventNumber.AutoSize = true;
            this.labelFlightEventNumber.Location = new System.Drawing.Point(11, 59);
            this.labelFlightEventNumber.Name = "labelFlightEventNumber";
            this.labelFlightEventNumber.Size = new System.Drawing.Size(71, 13);
            this.labelFlightEventNumber.TabIndex = 6;
            this.labelFlightEventNumber.Text = "Flight Event Number:";
            //
            //maskedTextBoxFlightEventNumber
            //
            this.maskedTextBoxFlightEventNumber.Location = new System.Drawing.Point(140, 59);
            this.maskedTextBoxFlightEventNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxFlightEventNumber.Name = "maskedTextBoxFlightEventNumber";
            this.maskedTextBoxFlightEventNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxFlightEventNumber.TabIndex = 7;
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
            this.dateTimePickerNewDateTime.Location = new System.Drawing.Point(140, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
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
            this.userPicker.Location = new System.Drawing.Point(140, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeFlightEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightEvent.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeFlightEvent.Name = "dataGridViewCrudeFlightEvent";
            this.dataGridViewCrudeFlightEvent.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFlightEvent.TabIndex = 0;
            this.dataGridViewCrudeFlightEvent.ReadOnly = true;
            this.dataGridViewCrudeFlightEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightEvent_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightEventSearch
            // 
            this.buttonCrudeFlightEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightEventSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeFlightEventSearch.Name = "buttonCrudeFlightEventSearch";
            this.buttonCrudeFlightEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightEventSearch.TabIndex = 2;
            this.buttonCrudeFlightEventSearch.Text = "&Search";
            this.buttonCrudeFlightEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightEventSearch.Click += new System.EventHandler(this.buttonCrudeFlightEventSearch_Click);
            // 
            // buttonCrudeFlightEventAdd
            // 
            this.buttonCrudeFlightEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightEventAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeFlightEventAdd.Name = "buttonCrudeFlightEventAdd";
            this.buttonCrudeFlightEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightEventAdd.TabIndex = 3;
            this.buttonCrudeFlightEventAdd.Text = "&Add";
            this.buttonCrudeFlightEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightEventAdd.Click += new System.EventHandler(this.buttonCrudeFlightEventAdd_Click);
            // 
            // buttonCrudeFlightEventEdit
            // 
            this.buttonCrudeFlightEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightEventEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeFlightEventEdit.Name = "buttonCrudeFlightEventEdit";
            this.buttonCrudeFlightEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightEventEdit.TabIndex = 4;
            this.buttonCrudeFlightEventEdit.Text = "&Edit";
            this.buttonCrudeFlightEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightEventEdit.Click += new System.EventHandler(this.buttonCrudeFlightEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeFlightEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightEventAdd);
            this.Controls.Add(this.buttonCrudeFlightEventEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightEvent);
            this.Name = "CrudeFlightEventSearch";
            this.Text = "Flight Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightEvent)).EndInit();
            this.Controls.Add(this.labelDateTimeTypeRefCombo);
            this.Controls.Add(this.dateTimeTypeRefCombo);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelFlightEventNumber);
            this.Controls.Add(this.maskedTextBoxFlightEventNumber);
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
