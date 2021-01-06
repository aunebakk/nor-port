namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirportEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAirportName;
        
        private System.Windows.Forms.Label labelAirportName;
        
        private AirportTypeRefCombo airportTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirportTypeRefCombo;
        
        private CityPicker cityPicker;
        
        private System.Windows.Forms.Label labelCityPicker;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUtcOffset;
        
        private System.Windows.Forms.Label labelUtcOffset;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxElevationInMeters;
        
        private System.Windows.Forms.Label labelElevationInMeters;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRunwayInMeters;
        
        private System.Windows.Forms.Label labelRunwayInMeters;
        
        private System.Windows.Forms.TextBox textBoxLatitude;
        
        private System.Windows.Forms.Label labelLatitude;
        
        private System.Windows.Forms.TextBox textBoxLongitude;
        
        private System.Windows.Forms.Label labelLongitude;
        
        private System.Windows.Forms.TextBox textBoxVariation;
        
        private System.Windows.Forms.Label labelVariation;
        
        private System.Windows.Forms.TextBox textBoxAttendance;
        
        private System.Windows.Forms.Label labelAttendance;
        
        private System.Windows.Forms.CheckBox checkBoxControlTowerFlag;
        
        private System.Windows.Forms.Label labelControlTowerFlag;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerActivationDateTime;
        
        private System.Windows.Forms.Label labelActivationDateTime;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.Button buttonAirportSearch;
        
        private System.Windows.Forms.Button buttonAirportAdd;
        
        private System.Windows.Forms.Button buttonAirportEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewAirport;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAirportAdd = new System.Windows.Forms.Button();
            this.buttonAirportEdit = new System.Windows.Forms.Button();
            this.buttonAirportSearch = new System.Windows.Forms.Button();
            this.dataGridViewAirport = new System.Windows.Forms.DataGridView();
            this.labelAirportName = new System.Windows.Forms.Label();
            this.textBoxAirportName = new System.Windows.Forms.TextBox();
            this.labelAirportTypeRefCombo = new System.Windows.Forms.Label();
            this.airportTypeRefCombo = new AirportTypeRefCombo();
            this.labelCityPicker = new System.Windows.Forms.Label();
            this.cityPicker = new CityPicker();
            this.labelUtcOffset = new System.Windows.Forms.Label();
            this.maskedTextBoxUtcOffset = new System.Windows.Forms.MaskedTextBox();
            this.labelElevationInMeters = new System.Windows.Forms.Label();
            this.maskedTextBoxElevationInMeters = new System.Windows.Forms.MaskedTextBox();
            this.labelRunwayInMeters = new System.Windows.Forms.Label();
            this.maskedTextBoxRunwayInMeters = new System.Windows.Forms.MaskedTextBox();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.labelVariation = new System.Windows.Forms.Label();
            this.textBoxVariation = new System.Windows.Forms.TextBox();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.textBoxAttendance = new System.Windows.Forms.TextBox();
            this.labelControlTowerFlag = new System.Windows.Forms.Label();
            this.checkBoxControlTowerFlag = new System.Windows.Forms.CheckBox();
            this.labelActivationDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerActivationDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirport)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportName
            //
            this.labelAirportName.AutoSize = true;
            this.labelAirportName.Location = new System.Drawing.Point(11, 13);
            this.labelAirportName.Name = "labelAirportName";
            this.labelAirportName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportName.TabIndex = 2;
            this.labelAirportName.Text = "Airport Name:";
            //
            //textBoxAirportName
            //
            this.textBoxAirportName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAirportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportName.Name = "textBoxAirportName";
            this.textBoxAirportName.Size = new System.Drawing.Size(350, 20);
            this.textBoxAirportName.TabIndex = 3;
            //
            // labelAirportTypeRefCombo
            //
            this.labelAirportTypeRefCombo.AutoSize = true;
            this.labelAirportTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAirportTypeRefCombo.Name = "labelAirportTypeRefCombo";
            this.labelAirportTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirportTypeRefCombo.TabIndex = 4;
            this.labelAirportTypeRefCombo.Text = "Airport Type:";
            //
            //airportTypeRefCombo
            //
            this.airportTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.airportTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportTypeRefCombo.Name = "airportTypeRefCombo";
            this.airportTypeRefCombo.Size = new System.Drawing.Size(350, 20);
            this.airportTypeRefCombo.TabIndex = 5;
            //
            // labelCityPicker
            //
            this.labelCityPicker.AutoSize = true;
            this.labelCityPicker.Location = new System.Drawing.Point(11, 59);
            this.labelCityPicker.Name = "labelCityPicker";
            this.labelCityPicker.Size = new System.Drawing.Size(71, 13);
            this.labelCityPicker.TabIndex = 6;
            this.labelCityPicker.Text = "City:";
            //
            //cityPicker
            //
            this.cityPicker.Location = new System.Drawing.Point(140, 59);
            this.cityPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cityPicker.Name = "cityPicker";
            this.cityPicker.Size = new System.Drawing.Size(350, 20);
            this.cityPicker.TabIndex = 7;
            //
            // labelUtcOffset
            //
            this.labelUtcOffset.AutoSize = true;
            this.labelUtcOffset.Location = new System.Drawing.Point(11, 82);
            this.labelUtcOffset.Name = "labelUtcOffset";
            this.labelUtcOffset.Size = new System.Drawing.Size(71, 13);
            this.labelUtcOffset.TabIndex = 8;
            this.labelUtcOffset.Text = "Utc Offset:";
            //
            //maskedTextBoxUtcOffset
            //
            this.maskedTextBoxUtcOffset.Location = new System.Drawing.Point(140, 82);
            this.maskedTextBoxUtcOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxUtcOffset.Name = "maskedTextBoxUtcOffset";
            this.maskedTextBoxUtcOffset.Size = new System.Drawing.Size(350, 20);
            this.maskedTextBoxUtcOffset.TabIndex = 9;
            //
            // labelElevationInMeters
            //
            this.labelElevationInMeters.AutoSize = true;
            this.labelElevationInMeters.Location = new System.Drawing.Point(11, 105);
            this.labelElevationInMeters.Name = "labelElevationInMeters";
            this.labelElevationInMeters.Size = new System.Drawing.Size(71, 13);
            this.labelElevationInMeters.TabIndex = 10;
            this.labelElevationInMeters.Text = "Elevation In Meters:";
            //
            //maskedTextBoxElevationInMeters
            //
            this.maskedTextBoxElevationInMeters.Location = new System.Drawing.Point(140, 105);
            this.maskedTextBoxElevationInMeters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxElevationInMeters.Name = "maskedTextBoxElevationInMeters";
            this.maskedTextBoxElevationInMeters.Size = new System.Drawing.Size(350, 20);
            this.maskedTextBoxElevationInMeters.TabIndex = 11;
            //
            // labelRunwayInMeters
            //
            this.labelRunwayInMeters.AutoSize = true;
            this.labelRunwayInMeters.Location = new System.Drawing.Point(11, 128);
            this.labelRunwayInMeters.Name = "labelRunwayInMeters";
            this.labelRunwayInMeters.Size = new System.Drawing.Size(71, 13);
            this.labelRunwayInMeters.TabIndex = 12;
            this.labelRunwayInMeters.Text = "Runway In Meters:";
            //
            //maskedTextBoxRunwayInMeters
            //
            this.maskedTextBoxRunwayInMeters.Location = new System.Drawing.Point(140, 128);
            this.maskedTextBoxRunwayInMeters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxRunwayInMeters.Name = "maskedTextBoxRunwayInMeters";
            this.maskedTextBoxRunwayInMeters.Size = new System.Drawing.Size(350, 20);
            this.maskedTextBoxRunwayInMeters.TabIndex = 13;
            //
            // labelLatitude
            //
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(11, 151);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(71, 13);
            this.labelLatitude.TabIndex = 14;
            this.labelLatitude.Text = "Latitude:";
            //
            //textBoxLatitude
            //
            this.textBoxLatitude.Location = new System.Drawing.Point(140, 151);
            this.textBoxLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(350, 20);
            this.textBoxLatitude.TabIndex = 15;
            //
            // labelLongitude
            //
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(11, 174);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(71, 13);
            this.labelLongitude.TabIndex = 16;
            this.labelLongitude.Text = "Longitude:";
            //
            //textBoxLongitude
            //
            this.textBoxLongitude.Location = new System.Drawing.Point(140, 174);
            this.textBoxLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(350, 20);
            this.textBoxLongitude.TabIndex = 17;
            //
            // labelVariation
            //
            this.labelVariation.AutoSize = true;
            this.labelVariation.Location = new System.Drawing.Point(11, 197);
            this.labelVariation.Name = "labelVariation";
            this.labelVariation.Size = new System.Drawing.Size(71, 13);
            this.labelVariation.TabIndex = 18;
            this.labelVariation.Text = "Variation:";
            //
            //textBoxVariation
            //
            this.textBoxVariation.Location = new System.Drawing.Point(140, 197);
            this.textBoxVariation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVariation.Name = "textBoxVariation";
            this.textBoxVariation.Size = new System.Drawing.Size(350, 20);
            this.textBoxVariation.TabIndex = 19;
            //
            // labelAttendance
            //
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Location = new System.Drawing.Point(11, 220);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(71, 13);
            this.labelAttendance.TabIndex = 20;
            this.labelAttendance.Text = "Attendance:";
            //
            //textBoxAttendance
            //
            this.textBoxAttendance.Location = new System.Drawing.Point(140, 220);
            this.textBoxAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAttendance.Name = "textBoxAttendance";
            this.textBoxAttendance.Size = new System.Drawing.Size(350, 20);
            this.textBoxAttendance.TabIndex = 21;
            //
            // labelControlTowerFlag
            //
            this.labelControlTowerFlag.AutoSize = true;
            this.labelControlTowerFlag.Location = new System.Drawing.Point(11, 243);
            this.labelControlTowerFlag.Name = "labelControlTowerFlag";
            this.labelControlTowerFlag.Size = new System.Drawing.Size(71, 13);
            this.labelControlTowerFlag.TabIndex = 22;
            this.labelControlTowerFlag.Text = "Control Tower Flag:";
            //
            //checkBoxControlTowerFlag
            //
            this.checkBoxControlTowerFlag.Location = new System.Drawing.Point(140, 243);
            this.checkBoxControlTowerFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxControlTowerFlag.Name = "checkBoxControlTowerFlag";
            this.checkBoxControlTowerFlag.Size = new System.Drawing.Size(350, 20);
            this.checkBoxControlTowerFlag.TabIndex = 23;
            //
            // labelActivationDateTime
            //
            this.labelActivationDateTime.AutoSize = true;
            this.labelActivationDateTime.Location = new System.Drawing.Point(11, 266);
            this.labelActivationDateTime.Name = "labelActivationDateTime";
            this.labelActivationDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelActivationDateTime.TabIndex = 24;
            this.labelActivationDateTime.Text = "Activation Date Time:";
            //
            //dateTimePickerActivationDateTime
            //
            this.dateTimePickerActivationDateTime.Location = new System.Drawing.Point(140, 266);
            this.dateTimePickerActivationDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerActivationDateTime.Name = "dateTimePickerActivationDateTime";
            this.dateTimePickerActivationDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerActivationDateTime.TabIndex = 25;
            this.dateTimePickerActivationDateTime.Checked = false;
            this.dateTimePickerActivationDateTime.ShowCheckBox = true;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 289);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 26;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 289);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(350, 20);
            this.userPicker.TabIndex = 27;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 312);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 28;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 312);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 29;
            // 
            // dataGridViewAirport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAirport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAirport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAirport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAirport.Location = new System.Drawing.Point(12, 345);
            this.dataGridViewAirport.Name = "dataGridViewAirport";
            this.dataGridViewAirport.Size = new System.Drawing.Size(478, 96);
            this.dataGridViewAirport.TabIndex = 0;
            this.dataGridViewAirport.DoubleClick += new System.EventHandler(this.dataGridViewAirport_DoubleClick);
            // 
            // buttonAirportSearch
            // 
            this.buttonAirportSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportSearch.Location = new System.Drawing.Point(198, 448);
            this.buttonAirportSearch.Name = "buttonAirportSearch";
            this.buttonAirportSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportSearch.TabIndex = 2;
            this.buttonAirportSearch.Text = "&Search";
            this.buttonAirportSearch.UseVisualStyleBackColor = true;
            this.buttonAirportSearch.Click += new System.EventHandler(this.buttonAirportSearch_Click);
            // 
            // buttonAirportAdd
            // 
            this.buttonAirportAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportAdd.Location = new System.Drawing.Point(98, 448);
            this.buttonAirportAdd.Name = "buttonAirportAdd";
            this.buttonAirportAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportAdd.TabIndex = 3;
            this.buttonAirportAdd.Text = "&Add";
            this.buttonAirportAdd.UseVisualStyleBackColor = true;
            this.buttonAirportAdd.Click += new System.EventHandler(this.buttonAirportAdd_Click);
            // 
            // buttonAirportEdit
            // 
            this.buttonAirportEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportEdit.Location = new System.Drawing.Point(-2, 448);
            this.buttonAirportEdit.Name = "buttonAirportEdit";
            this.buttonAirportEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportEdit.TabIndex = 4;
            this.buttonAirportEdit.Text = "&Edit";
            this.buttonAirportEdit.UseVisualStyleBackColor = true;
            this.buttonAirportEdit.Click += new System.EventHandler(this.buttonAirportEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(398, 448);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(298, 448);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 476);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAirportSearch);
            this.Controls.Add(this.buttonAirportAdd);
            this.Controls.Add(this.buttonAirportEdit);
            this.Controls.Add(this.dataGridViewAirport);
            this.Name = "AirportEdit";
            this.Text = "Airport Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirport)).EndInit();
            this.Controls.Add(this.labelAirportName);
            this.Controls.Add(this.textBoxAirportName);
            this.Controls.Add(this.labelAirportTypeRefCombo);
            this.Controls.Add(this.airportTypeRefCombo);
            this.Controls.Add(this.labelCityPicker);
            this.Controls.Add(this.cityPicker);
            this.Controls.Add(this.labelUtcOffset);
            this.Controls.Add(this.maskedTextBoxUtcOffset);
            this.Controls.Add(this.labelElevationInMeters);
            this.Controls.Add(this.maskedTextBoxElevationInMeters);
            this.Controls.Add(this.labelRunwayInMeters);
            this.Controls.Add(this.maskedTextBoxRunwayInMeters);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.labelVariation);
            this.Controls.Add(this.textBoxVariation);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.textBoxAttendance);
            this.Controls.Add(this.labelControlTowerFlag);
            this.Controls.Add(this.checkBoxControlTowerFlag);
            this.Controls.Add(this.labelActivationDateTime);
            this.Controls.Add(this.dateTimePickerActivationDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
