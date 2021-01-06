namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportFacilitySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportFacilitySearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportFacilityAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportFacilityEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportFacility;
        
        private System.Windows.Forms.TextBox textBoxAirportFacilityName;
        
        private System.Windows.Forms.Label labelAirportFacilityName;
        
        private AirportFacilityTypeRefCombo airportFacilityTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirportFacilityTypeRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirportPicker airportPicker;
        
        private System.Windows.Forms.Label labelAirportPicker;
        
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
            this.buttonCrudeAirportFacilityAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportFacilityEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportFacilitySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportFacility = new System.Windows.Forms.DataGridView();
            this.labelAirportFacilityName = new System.Windows.Forms.Label();
            this.textBoxAirportFacilityName = new System.Windows.Forms.TextBox();
            this.labelAirportFacilityTypeRefCombo = new System.Windows.Forms.Label();
            this.airportFacilityTypeRefCombo = new AirportFacilityTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportFacility)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportFacilityName
            //
            this.labelAirportFacilityName.AutoSize = true;
            this.labelAirportFacilityName.Location = new System.Drawing.Point(11, 13);
            this.labelAirportFacilityName.Name = "labelAirportFacilityName";
            this.labelAirportFacilityName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportFacilityName.TabIndex = 2;
            this.labelAirportFacilityName.Text = "Airport Facility Name:";
            //
            //textBoxAirportFacilityName
            //
            this.textBoxAirportFacilityName.Location = new System.Drawing.Point(147, 13);
            this.textBoxAirportFacilityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportFacilityName.Name = "textBoxAirportFacilityName";
            this.textBoxAirportFacilityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportFacilityName.TabIndex = 3;
            //
            // labelAirportFacilityTypeRefCombo
            //
            this.labelAirportFacilityTypeRefCombo.AutoSize = true;
            this.labelAirportFacilityTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAirportFacilityTypeRefCombo.Name = "labelAirportFacilityTypeRefCombo";
            this.labelAirportFacilityTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirportFacilityTypeRefCombo.TabIndex = 4;
            this.labelAirportFacilityTypeRefCombo.Text = "Airport Facility Type:";
            //
            //airportFacilityTypeRefCombo
            //
            this.airportFacilityTypeRefCombo.Location = new System.Drawing.Point(147, 36);
            this.airportFacilityTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportFacilityTypeRefCombo.Name = "airportFacilityTypeRefCombo";
            this.airportFacilityTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.airportFacilityTypeRefCombo.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 82);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 8;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(147, 82);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(250, 20);
            this.airportPicker.TabIndex = 9;
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
            this.userPicker.Location = new System.Drawing.Point(147, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeAirportFacility
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportFacility.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportFacility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportFacility.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAirportFacility.Name = "dataGridViewCrudeAirportFacility";
            this.dataGridViewCrudeAirportFacility.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeAirportFacility.TabIndex = 0;
            this.dataGridViewCrudeAirportFacility.ReadOnly = true;
            this.dataGridViewCrudeAirportFacility.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportFacility_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportFacilitySearch
            // 
            this.buttonCrudeAirportFacilitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportFacilitySearch.Location = new System.Drawing.Point(205, 241);
            this.buttonCrudeAirportFacilitySearch.Name = "buttonCrudeAirportFacilitySearch";
            this.buttonCrudeAirportFacilitySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportFacilitySearch.TabIndex = 2;
            this.buttonCrudeAirportFacilitySearch.Text = "&Search";
            this.buttonCrudeAirportFacilitySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportFacilitySearch.Click += new System.EventHandler(this.buttonCrudeAirportFacilitySearch_Click);
            // 
            // buttonCrudeAirportFacilityAdd
            // 
            this.buttonCrudeAirportFacilityAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportFacilityAdd.Location = new System.Drawing.Point(105, 241);
            this.buttonCrudeAirportFacilityAdd.Name = "buttonCrudeAirportFacilityAdd";
            this.buttonCrudeAirportFacilityAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportFacilityAdd.TabIndex = 3;
            this.buttonCrudeAirportFacilityAdd.Text = "&Add";
            this.buttonCrudeAirportFacilityAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportFacilityAdd.Click += new System.EventHandler(this.buttonCrudeAirportFacilityAdd_Click);
            // 
            // buttonCrudeAirportFacilityEdit
            // 
            this.buttonCrudeAirportFacilityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportFacilityEdit.Location = new System.Drawing.Point(5, 241);
            this.buttonCrudeAirportFacilityEdit.Name = "buttonCrudeAirportFacilityEdit";
            this.buttonCrudeAirportFacilityEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportFacilityEdit.TabIndex = 4;
            this.buttonCrudeAirportFacilityEdit.Text = "&Edit";
            this.buttonCrudeAirportFacilityEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportFacilityEdit.Click += new System.EventHandler(this.buttonCrudeAirportFacilityEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 269);
            this.Controls.Add(this.buttonCrudeAirportFacilitySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportFacilityAdd);
            this.Controls.Add(this.buttonCrudeAirportFacilityEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportFacility);
            this.Name = "CrudeAirportFacilitySearch";
            this.Text = "Airport Facility Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportFacility)).EndInit();
            this.Controls.Add(this.labelAirportFacilityName);
            this.Controls.Add(this.textBoxAirportFacilityName);
            this.Controls.Add(this.labelAirportFacilityTypeRefCombo);
            this.Controls.Add(this.airportFacilityTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
