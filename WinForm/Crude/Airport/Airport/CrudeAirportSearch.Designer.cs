namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirport;
        
        private System.Windows.Forms.TextBox textBoxAirportName;
        
        private System.Windows.Forms.Label labelAirportName;
        
        private AirportTypeRefCombo airportTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirportTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLatitude;
        
        private System.Windows.Forms.Label labelLatitude;
        
        private System.Windows.Forms.TextBox textBoxLongitude;
        
        private System.Windows.Forms.Label labelLongitude;
        
        private System.Windows.Forms.TextBox textBoxVariation;
        
        private System.Windows.Forms.Label labelVariation;
        
        private System.Windows.Forms.TextBox textBoxAttendance;
        
        private System.Windows.Forms.Label labelAttendance;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUtcOffset;
        
        private System.Windows.Forms.Label labelUtcOffset;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxElevationInMeters;
        
        private System.Windows.Forms.Label labelElevationInMeters;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRunwayInMeters;
        
        private System.Windows.Forms.Label labelRunwayInMeters;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerActivationDateTime;
        
        private System.Windows.Forms.Label labelActivationDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private CityPicker cityPicker;
        
        private System.Windows.Forms.Label labelCityPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.CheckBox checkBoxControlTowerFlag;
        
        private System.Windows.Forms.Label labelControlTowerFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAirportAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirport = new System.Windows.Forms.DataGridView();
            this.labelAirportName = new System.Windows.Forms.Label();
            this.textBoxAirportName = new System.Windows.Forms.TextBox();
            this.labelAirportTypeRefCombo = new System.Windows.Forms.Label();
            this.airportTypeRefCombo = new AirportTypeRefCombo();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.labelVariation = new System.Windows.Forms.Label();
            this.textBoxVariation = new System.Windows.Forms.TextBox();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.textBoxAttendance = new System.Windows.Forms.TextBox();
            this.labelUtcOffset = new System.Windows.Forms.Label();
            this.maskedTextBoxUtcOffset = new System.Windows.Forms.MaskedTextBox();
            this.labelElevationInMeters = new System.Windows.Forms.Label();
            this.maskedTextBoxElevationInMeters = new System.Windows.Forms.MaskedTextBox();
            this.labelRunwayInMeters = new System.Windows.Forms.Label();
            this.maskedTextBoxRunwayInMeters = new System.Windows.Forms.MaskedTextBox();
            this.labelActivationDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerActivationDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelCityPicker = new System.Windows.Forms.Label();
            this.cityPicker = new CityPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelControlTowerFlag = new System.Windows.Forms.Label();
            this.checkBoxControlTowerFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirport)).BeginInit();
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
            this.textBoxAirportName.Size = new System.Drawing.Size(250, 20);
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
            this.airportTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.airportTypeRefCombo.TabIndex = 5;
            //
            // labelLatitude
            //
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(11, 59);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(71, 13);
            this.labelLatitude.TabIndex = 6;
            this.labelLatitude.Text = "Latitude:";
            //
            //textBoxLatitude
            //
            this.textBoxLatitude.Location = new System.Drawing.Point(140, 59);
            this.textBoxLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(250, 20);
            this.textBoxLatitude.TabIndex = 7;
            //
            // labelLongitude
            //
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(11, 82);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(71, 13);
            this.labelLongitude.TabIndex = 8;
            this.labelLongitude.Text = "Longitude:";
            //
            //textBoxLongitude
            //
            this.textBoxLongitude.Location = new System.Drawing.Point(140, 82);
            this.textBoxLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(250, 20);
            this.textBoxLongitude.TabIndex = 9;
            //
            // labelVariation
            //
            this.labelVariation.AutoSize = true;
            this.labelVariation.Location = new System.Drawing.Point(11, 105);
            this.labelVariation.Name = "labelVariation";
            this.labelVariation.Size = new System.Drawing.Size(71, 13);
            this.labelVariation.TabIndex = 10;
            this.labelVariation.Text = "Variation:";
            //
            //textBoxVariation
            //
            this.textBoxVariation.Location = new System.Drawing.Point(140, 105);
            this.textBoxVariation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVariation.Name = "textBoxVariation";
            this.textBoxVariation.Size = new System.Drawing.Size(250, 20);
            this.textBoxVariation.TabIndex = 11;
            //
            // labelAttendance
            //
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Location = new System.Drawing.Point(11, 128);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(71, 13);
            this.labelAttendance.TabIndex = 12;
            this.labelAttendance.Text = "Attendance:";
            //
            //textBoxAttendance
            //
            this.textBoxAttendance.Location = new System.Drawing.Point(140, 128);
            this.textBoxAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAttendance.Name = "textBoxAttendance";
            this.textBoxAttendance.Size = new System.Drawing.Size(250, 20);
            this.textBoxAttendance.TabIndex = 13;
            //
            // labelUtcOffset
            //
            this.labelUtcOffset.AutoSize = true;
            this.labelUtcOffset.Location = new System.Drawing.Point(11, 151);
            this.labelUtcOffset.Name = "labelUtcOffset";
            this.labelUtcOffset.Size = new System.Drawing.Size(71, 13);
            this.labelUtcOffset.TabIndex = 14;
            this.labelUtcOffset.Text = "Utc Offset:";
            //
            //maskedTextBoxUtcOffset
            //
            this.maskedTextBoxUtcOffset.Location = new System.Drawing.Point(140, 151);
            this.maskedTextBoxUtcOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxUtcOffset.Name = "maskedTextBoxUtcOffset";
            this.maskedTextBoxUtcOffset.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxUtcOffset.TabIndex = 15;
            //
            // labelElevationInMeters
            //
            this.labelElevationInMeters.AutoSize = true;
            this.labelElevationInMeters.Location = new System.Drawing.Point(11, 174);
            this.labelElevationInMeters.Name = "labelElevationInMeters";
            this.labelElevationInMeters.Size = new System.Drawing.Size(71, 13);
            this.labelElevationInMeters.TabIndex = 16;
            this.labelElevationInMeters.Text = "Elevation In Meters:";
            //
            //maskedTextBoxElevationInMeters
            //
            this.maskedTextBoxElevationInMeters.Location = new System.Drawing.Point(140, 174);
            this.maskedTextBoxElevationInMeters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxElevationInMeters.Name = "maskedTextBoxElevationInMeters";
            this.maskedTextBoxElevationInMeters.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxElevationInMeters.TabIndex = 17;
            //
            // labelRunwayInMeters
            //
            this.labelRunwayInMeters.AutoSize = true;
            this.labelRunwayInMeters.Location = new System.Drawing.Point(11, 197);
            this.labelRunwayInMeters.Name = "labelRunwayInMeters";
            this.labelRunwayInMeters.Size = new System.Drawing.Size(71, 13);
            this.labelRunwayInMeters.TabIndex = 18;
            this.labelRunwayInMeters.Text = "Runway In Meters:";
            //
            //maskedTextBoxRunwayInMeters
            //
            this.maskedTextBoxRunwayInMeters.Location = new System.Drawing.Point(140, 197);
            this.maskedTextBoxRunwayInMeters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxRunwayInMeters.Name = "maskedTextBoxRunwayInMeters";
            this.maskedTextBoxRunwayInMeters.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxRunwayInMeters.TabIndex = 19;
            //
            // labelActivationDateTime
            //
            this.labelActivationDateTime.AutoSize = true;
            this.labelActivationDateTime.Location = new System.Drawing.Point(11, 220);
            this.labelActivationDateTime.Name = "labelActivationDateTime";
            this.labelActivationDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelActivationDateTime.TabIndex = 20;
            this.labelActivationDateTime.Text = "Activation Date Time:";
            //
            //dateTimePickerActivationDateTime
            //
            this.dateTimePickerActivationDateTime.Location = new System.Drawing.Point(140, 220);
            this.dateTimePickerActivationDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerActivationDateTime.Name = "dateTimePickerActivationDateTime";
            this.dateTimePickerActivationDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerActivationDateTime.TabIndex = 21;
            this.dateTimePickerActivationDateTime.Checked = false;
            this.dateTimePickerActivationDateTime.ShowCheckBox = true;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 243);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 22;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 243);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 23;
            //
            // labelCityPicker
            //
            this.labelCityPicker.AutoSize = true;
            this.labelCityPicker.Location = new System.Drawing.Point(11, 266);
            this.labelCityPicker.Name = "labelCityPicker";
            this.labelCityPicker.Size = new System.Drawing.Size(71, 13);
            this.labelCityPicker.TabIndex = 24;
            this.labelCityPicker.Text = "City:";
            //
            //cityPicker
            //
            this.cityPicker.Location = new System.Drawing.Point(140, 266);
            this.cityPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cityPicker.Name = "cityPicker";
            this.cityPicker.Size = new System.Drawing.Size(250, 20);
            this.cityPicker.TabIndex = 25;
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
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 27;
            //
            // labelControlTowerFlag
            //
            this.labelControlTowerFlag.AutoSize = true;
            this.labelControlTowerFlag.Location = new System.Drawing.Point(11, 312);
            this.labelControlTowerFlag.Name = "labelControlTowerFlag";
            this.labelControlTowerFlag.Size = new System.Drawing.Size(71, 13);
            this.labelControlTowerFlag.TabIndex = 28;
            this.labelControlTowerFlag.Text = "Control Tower Flag:";
            //
            //checkBoxControlTowerFlag
            //
            this.checkBoxControlTowerFlag.Location = new System.Drawing.Point(140, 312);
            this.checkBoxControlTowerFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxControlTowerFlag.Name = "checkBoxControlTowerFlag";
            this.checkBoxControlTowerFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxControlTowerFlag.TabIndex = 29;
            // 
            // dataGridViewCrudeAirport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirport.Location = new System.Drawing.Point(12, 345);
            this.dataGridViewCrudeAirport.Name = "dataGridViewCrudeAirport";
            this.dataGridViewCrudeAirport.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirport.TabIndex = 0;
            this.dataGridViewCrudeAirport.ReadOnly = true;
            this.dataGridViewCrudeAirport.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirport_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 448);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportSearch
            // 
            this.buttonCrudeAirportSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSearch.Location = new System.Drawing.Point(198, 448);
            this.buttonCrudeAirportSearch.Name = "buttonCrudeAirportSearch";
            this.buttonCrudeAirportSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSearch.TabIndex = 2;
            this.buttonCrudeAirportSearch.Text = "&Search";
            this.buttonCrudeAirportSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSearch.Click += new System.EventHandler(this.buttonCrudeAirportSearch_Click);
            // 
            // buttonCrudeAirportAdd
            // 
            this.buttonCrudeAirportAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportAdd.Location = new System.Drawing.Point(98, 448);
            this.buttonCrudeAirportAdd.Name = "buttonCrudeAirportAdd";
            this.buttonCrudeAirportAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportAdd.TabIndex = 3;
            this.buttonCrudeAirportAdd.Text = "&Add";
            this.buttonCrudeAirportAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportAdd.Click += new System.EventHandler(this.buttonCrudeAirportAdd_Click);
            // 
            // buttonCrudeAirportEdit
            // 
            this.buttonCrudeAirportEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportEdit.Location = new System.Drawing.Point(-2, 448);
            this.buttonCrudeAirportEdit.Name = "buttonCrudeAirportEdit";
            this.buttonCrudeAirportEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportEdit.TabIndex = 4;
            this.buttonCrudeAirportEdit.Text = "&Edit";
            this.buttonCrudeAirportEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportEdit.Click += new System.EventHandler(this.buttonCrudeAirportEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 476);
            this.Controls.Add(this.buttonCrudeAirportSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportAdd);
            this.Controls.Add(this.buttonCrudeAirportEdit);
            this.Controls.Add(this.dataGridViewCrudeAirport);
            this.Name = "CrudeAirportSearch";
            this.Text = "Airport Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirport)).EndInit();
            this.Controls.Add(this.labelAirportName);
            this.Controls.Add(this.textBoxAirportName);
            this.Controls.Add(this.labelAirportTypeRefCombo);
            this.Controls.Add(this.airportTypeRefCombo);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.labelVariation);
            this.Controls.Add(this.textBoxVariation);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.textBoxAttendance);
            this.Controls.Add(this.labelUtcOffset);
            this.Controls.Add(this.maskedTextBoxUtcOffset);
            this.Controls.Add(this.labelElevationInMeters);
            this.Controls.Add(this.maskedTextBoxElevationInMeters);
            this.Controls.Add(this.labelRunwayInMeters);
            this.Controls.Add(this.maskedTextBoxRunwayInMeters);
            this.Controls.Add(this.labelActivationDateTime);
            this.Controls.Add(this.dateTimePickerActivationDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelCityPicker);
            this.Controls.Add(this.cityPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelControlTowerFlag);
            this.Controls.Add(this.checkBoxControlTowerFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
