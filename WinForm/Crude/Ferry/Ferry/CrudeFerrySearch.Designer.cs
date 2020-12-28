namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFerrySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFerrySearch;
        
        private System.Windows.Forms.Button buttonCrudeFerryAdd;
        
        private System.Windows.Forms.Button buttonCrudeFerryEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFerry;
        
        private System.Windows.Forms.TextBox textBoxFerryName;
        
        private System.Windows.Forms.Label labelFerryName;
        
        private FerryTypeRefCombo ferryTypeRefCombo;
        
        private System.Windows.Forms.Label labelFerryTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxEngineType;
        
        private System.Windows.Forms.Label labelEngineType;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassengerCapacity;
        
        private System.Windows.Forms.Label labelPassengerCapacity;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstFloatDateTime;
        
        private System.Windows.Forms.Label labelFirstFloatDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerOperationalDateTime;
        
        private System.Windows.Forms.Label labelOperationalDateTime;
        
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
            this.buttonCrudeFerryAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFerryEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFerrySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFerry = new System.Windows.Forms.DataGridView();
            this.labelFerryName = new System.Windows.Forms.Label();
            this.textBoxFerryName = new System.Windows.Forms.TextBox();
            this.labelFerryTypeRefCombo = new System.Windows.Forms.Label();
            this.ferryTypeRefCombo = new FerryTypeRefCombo();
            this.labelEngineType = new System.Windows.Forms.Label();
            this.textBoxEngineType = new System.Windows.Forms.TextBox();
            this.labelPassengerCapacity = new System.Windows.Forms.Label();
            this.maskedTextBoxPassengerCapacity = new System.Windows.Forms.MaskedTextBox();
            this.labelFirstFloatDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFirstFloatDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelOperationalDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerOperationalDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerry)).BeginInit();
            this.SuspendLayout();
            //
            // labelFerryName
            //
            this.labelFerryName.AutoSize = true;
            this.labelFerryName.Location = new System.Drawing.Point(11, 13);
            this.labelFerryName.Name = "labelFerryName";
            this.labelFerryName.Size = new System.Drawing.Size(71, 13);
            this.labelFerryName.TabIndex = 2;
            this.labelFerryName.Text = "Ferry Name:";
            //
            //textBoxFerryName
            //
            this.textBoxFerryName.Location = new System.Drawing.Point(147, 13);
            this.textBoxFerryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryName.Name = "textBoxFerryName";
            this.textBoxFerryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryName.TabIndex = 3;
            //
            // labelFerryTypeRefCombo
            //
            this.labelFerryTypeRefCombo.AutoSize = true;
            this.labelFerryTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFerryTypeRefCombo.Name = "labelFerryTypeRefCombo";
            this.labelFerryTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFerryTypeRefCombo.TabIndex = 4;
            this.labelFerryTypeRefCombo.Text = "Ferry Type:";
            //
            //ferryTypeRefCombo
            //
            this.ferryTypeRefCombo.Location = new System.Drawing.Point(147, 36);
            this.ferryTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ferryTypeRefCombo.Name = "ferryTypeRefCombo";
            this.ferryTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.ferryTypeRefCombo.TabIndex = 5;
            //
            // labelEngineType
            //
            this.labelEngineType.AutoSize = true;
            this.labelEngineType.Location = new System.Drawing.Point(11, 59);
            this.labelEngineType.Name = "labelEngineType";
            this.labelEngineType.Size = new System.Drawing.Size(71, 13);
            this.labelEngineType.TabIndex = 6;
            this.labelEngineType.Text = "Engine Type:";
            //
            //textBoxEngineType
            //
            this.textBoxEngineType.Location = new System.Drawing.Point(147, 59);
            this.textBoxEngineType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEngineType.Name = "textBoxEngineType";
            this.textBoxEngineType.Size = new System.Drawing.Size(250, 20);
            this.textBoxEngineType.TabIndex = 7;
            //
            // labelPassengerCapacity
            //
            this.labelPassengerCapacity.AutoSize = true;
            this.labelPassengerCapacity.Location = new System.Drawing.Point(11, 82);
            this.labelPassengerCapacity.Name = "labelPassengerCapacity";
            this.labelPassengerCapacity.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerCapacity.TabIndex = 8;
            this.labelPassengerCapacity.Text = "Passenger Capacity:";
            //
            //maskedTextBoxPassengerCapacity
            //
            this.maskedTextBoxPassengerCapacity.Location = new System.Drawing.Point(147, 82);
            this.maskedTextBoxPassengerCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPassengerCapacity.Name = "maskedTextBoxPassengerCapacity";
            this.maskedTextBoxPassengerCapacity.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPassengerCapacity.TabIndex = 9;
            //
            // labelFirstFloatDateTime
            //
            this.labelFirstFloatDateTime.AutoSize = true;
            this.labelFirstFloatDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelFirstFloatDateTime.Name = "labelFirstFloatDateTime";
            this.labelFirstFloatDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFirstFloatDateTime.TabIndex = 10;
            this.labelFirstFloatDateTime.Text = "First Float Date Time:";
            //
            //dateTimePickerFirstFloatDateTime
            //
            this.dateTimePickerFirstFloatDateTime.Location = new System.Drawing.Point(147, 105);
            this.dateTimePickerFirstFloatDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFirstFloatDateTime.Name = "dateTimePickerFirstFloatDateTime";
            this.dateTimePickerFirstFloatDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFirstFloatDateTime.TabIndex = 11;
            this.dateTimePickerFirstFloatDateTime.Checked = false;
            this.dateTimePickerFirstFloatDateTime.ShowCheckBox = true;
            //
            // labelOperationalDateTime
            //
            this.labelOperationalDateTime.AutoSize = true;
            this.labelOperationalDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelOperationalDateTime.Name = "labelOperationalDateTime";
            this.labelOperationalDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelOperationalDateTime.TabIndex = 12;
            this.labelOperationalDateTime.Text = "Operational Date Time:";
            //
            //dateTimePickerOperationalDateTime
            //
            this.dateTimePickerOperationalDateTime.Location = new System.Drawing.Point(147, 128);
            this.dateTimePickerOperationalDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOperationalDateTime.Name = "dateTimePickerOperationalDateTime";
            this.dateTimePickerOperationalDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerOperationalDateTime.TabIndex = 13;
            this.dateTimePickerOperationalDateTime.Checked = false;
            this.dateTimePickerOperationalDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 174);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 16;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(147, 174);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 17;
            // 
            // dataGridViewCrudeFerry
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFerry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFerry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFerry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFerry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFerry.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewCrudeFerry.Name = "dataGridViewCrudeFerry";
            this.dataGridViewCrudeFerry.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeFerry.TabIndex = 0;
            this.dataGridViewCrudeFerry.ReadOnly = true;
            this.dataGridViewCrudeFerry.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFerry_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 310);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFerrySearch
            // 
            this.buttonCrudeFerrySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerrySearch.Location = new System.Drawing.Point(205, 310);
            this.buttonCrudeFerrySearch.Name = "buttonCrudeFerrySearch";
            this.buttonCrudeFerrySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerrySearch.TabIndex = 2;
            this.buttonCrudeFerrySearch.Text = "&Search";
            this.buttonCrudeFerrySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFerrySearch.Click += new System.EventHandler(this.buttonCrudeFerrySearch_Click);
            // 
            // buttonCrudeFerryAdd
            // 
            this.buttonCrudeFerryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryAdd.Location = new System.Drawing.Point(105, 310);
            this.buttonCrudeFerryAdd.Name = "buttonCrudeFerryAdd";
            this.buttonCrudeFerryAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryAdd.TabIndex = 3;
            this.buttonCrudeFerryAdd.Text = "&Add";
            this.buttonCrudeFerryAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryAdd.Click += new System.EventHandler(this.buttonCrudeFerryAdd_Click);
            // 
            // buttonCrudeFerryEdit
            // 
            this.buttonCrudeFerryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryEdit.Location = new System.Drawing.Point(5, 310);
            this.buttonCrudeFerryEdit.Name = "buttonCrudeFerryEdit";
            this.buttonCrudeFerryEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryEdit.TabIndex = 4;
            this.buttonCrudeFerryEdit.Text = "&Edit";
            this.buttonCrudeFerryEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryEdit.Click += new System.EventHandler(this.buttonCrudeFerryEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 338);
            this.Controls.Add(this.buttonCrudeFerrySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFerryAdd);
            this.Controls.Add(this.buttonCrudeFerryEdit);
            this.Controls.Add(this.dataGridViewCrudeFerry);
            this.Name = "CrudeFerrySearch";
            this.Text = "Ferry Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerry)).EndInit();
            this.Controls.Add(this.labelFerryName);
            this.Controls.Add(this.textBoxFerryName);
            this.Controls.Add(this.labelFerryTypeRefCombo);
            this.Controls.Add(this.ferryTypeRefCombo);
            this.Controls.Add(this.labelEngineType);
            this.Controls.Add(this.textBoxEngineType);
            this.Controls.Add(this.labelPassengerCapacity);
            this.Controls.Add(this.maskedTextBoxPassengerCapacity);
            this.Controls.Add(this.labelFirstFloatDateTime);
            this.Controls.Add(this.dateTimePickerFirstFloatDateTime);
            this.Controls.Add(this.labelOperationalDateTime);
            this.Controls.Add(this.dateTimePickerOperationalDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
