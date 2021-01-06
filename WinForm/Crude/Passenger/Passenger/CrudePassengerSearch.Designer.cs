namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudePassengerSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudePassengerSearch;
        
        private System.Windows.Forms.Button buttonCrudePassengerAdd;
        
        private System.Windows.Forms.Button buttonCrudePassengerEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudePassenger;
        
        private System.Windows.Forms.TextBox textBoxPassengerName;
        
        private System.Windows.Forms.Label labelPassengerName;
        
        private PassengerTypeRefCombo passengerTypeRefCombo;
        
        private System.Windows.Forms.Label labelPassengerTypeRefCombo;
        
        private DefaultStateRefCombo defaultStateRefCombo;
        
        private System.Windows.Forms.Label labelDefaultStateRefCombo;
        
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
            this.buttonCrudePassengerAdd = new System.Windows.Forms.Button();
            this.buttonCrudePassengerEdit = new System.Windows.Forms.Button();
            this.buttonCrudePassengerSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudePassenger = new System.Windows.Forms.DataGridView();
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.labelPassengerTypeRefCombo = new System.Windows.Forms.Label();
            this.passengerTypeRefCombo = new PassengerTypeRefCombo();
            this.labelDefaultStateRefCombo = new System.Windows.Forms.Label();
            this.defaultStateRefCombo = new DefaultStateRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudePassenger)).BeginInit();
            this.SuspendLayout();
            //
            // labelPassengerName
            //
            this.labelPassengerName.AutoSize = true;
            this.labelPassengerName.Location = new System.Drawing.Point(11, 13);
            this.labelPassengerName.Name = "labelPassengerName";
            this.labelPassengerName.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerName.TabIndex = 2;
            this.labelPassengerName.Text = "Passenger Name:";
            //
            //textBoxPassengerName
            //
            this.textBoxPassengerName.Location = new System.Drawing.Point(140, 13);
            this.textBoxPassengerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerName.TabIndex = 3;
            //
            // labelPassengerTypeRefCombo
            //
            this.labelPassengerTypeRefCombo.AutoSize = true;
            this.labelPassengerTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelPassengerTypeRefCombo.Name = "labelPassengerTypeRefCombo";
            this.labelPassengerTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerTypeRefCombo.TabIndex = 4;
            this.labelPassengerTypeRefCombo.Text = "Passenger Type:";
            //
            //passengerTypeRefCombo
            //
            this.passengerTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.passengerTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerTypeRefCombo.Name = "passengerTypeRefCombo";
            this.passengerTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.passengerTypeRefCombo.TabIndex = 5;
            //
            // labelDefaultStateRefCombo
            //
            this.labelDefaultStateRefCombo.AutoSize = true;
            this.labelDefaultStateRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelDefaultStateRefCombo.Name = "labelDefaultStateRefCombo";
            this.labelDefaultStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultStateRefCombo.TabIndex = 6;
            this.labelDefaultStateRefCombo.Text = "Default State:";
            //
            //defaultStateRefCombo
            //
            this.defaultStateRefCombo.Location = new System.Drawing.Point(140, 59);
            this.defaultStateRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultStateRefCombo.Name = "defaultStateRefCombo";
            this.defaultStateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultStateRefCombo.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
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
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudePassenger
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudePassenger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudePassenger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudePassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudePassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudePassenger.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudePassenger.Name = "dataGridViewCrudePassenger";
            this.dataGridViewCrudePassenger.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudePassenger.TabIndex = 0;
            this.dataGridViewCrudePassenger.ReadOnly = true;
            this.dataGridViewCrudePassenger.DoubleClick += new System.EventHandler(this.dataGridViewCrudePassenger_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudePassengerSearch
            // 
            this.buttonCrudePassengerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudePassengerSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudePassengerSearch.Name = "buttonCrudePassengerSearch";
            this.buttonCrudePassengerSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudePassengerSearch.TabIndex = 2;
            this.buttonCrudePassengerSearch.Text = "&Search";
            this.buttonCrudePassengerSearch.UseVisualStyleBackColor = true;
            this.buttonCrudePassengerSearch.Click += new System.EventHandler(this.buttonCrudePassengerSearch_Click);
            // 
            // buttonCrudePassengerAdd
            // 
            this.buttonCrudePassengerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudePassengerAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudePassengerAdd.Name = "buttonCrudePassengerAdd";
            this.buttonCrudePassengerAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudePassengerAdd.TabIndex = 3;
            this.buttonCrudePassengerAdd.Text = "&Add";
            this.buttonCrudePassengerAdd.UseVisualStyleBackColor = true;
            this.buttonCrudePassengerAdd.Click += new System.EventHandler(this.buttonCrudePassengerAdd_Click);
            // 
            // buttonCrudePassengerEdit
            // 
            this.buttonCrudePassengerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudePassengerEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudePassengerEdit.Name = "buttonCrudePassengerEdit";
            this.buttonCrudePassengerEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudePassengerEdit.TabIndex = 4;
            this.buttonCrudePassengerEdit.Text = "&Edit";
            this.buttonCrudePassengerEdit.UseVisualStyleBackColor = true;
            this.buttonCrudePassengerEdit.Click += new System.EventHandler(this.buttonCrudePassengerEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudePassengerSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudePassengerAdd);
            this.Controls.Add(this.buttonCrudePassengerEdit);
            this.Controls.Add(this.dataGridViewCrudePassenger);
            this.Name = "CrudePassengerSearch";
            this.Text = "Passenger Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudePassenger)).EndInit();
            this.Controls.Add(this.labelPassengerName);
            this.Controls.Add(this.textBoxPassengerName);
            this.Controls.Add(this.labelPassengerTypeRefCombo);
            this.Controls.Add(this.passengerTypeRefCombo);
            this.Controls.Add(this.labelDefaultStateRefCombo);
            this.Controls.Add(this.defaultStateRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
