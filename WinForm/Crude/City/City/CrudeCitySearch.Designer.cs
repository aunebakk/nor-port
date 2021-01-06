namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeCitySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeCitySearch;
        
        private System.Windows.Forms.Button buttonCrudeCityAdd;
        
        private System.Windows.Forms.Button buttonCrudeCityEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeCity;
        
        private System.Windows.Forms.TextBox textBoxCityName;
        
        private System.Windows.Forms.Label labelCityName;
        
        private System.Windows.Forms.TextBox textBoxCityCode;
        
        private System.Windows.Forms.Label labelCityCode;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private CountryPicker countryPicker;
        
        private System.Windows.Forms.Label labelCountryPicker;
        
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
            this.buttonCrudeCityAdd = new System.Windows.Forms.Button();
            this.buttonCrudeCityEdit = new System.Windows.Forms.Button();
            this.buttonCrudeCitySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeCity = new System.Windows.Forms.DataGridView();
            this.labelCityName = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.labelCityCode = new System.Windows.Forms.Label();
            this.textBoxCityCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelCountryPicker = new System.Windows.Forms.Label();
            this.countryPicker = new CountryPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCity)).BeginInit();
            this.SuspendLayout();
            //
            // labelCityName
            //
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(11, 13);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(71, 13);
            this.labelCityName.TabIndex = 2;
            this.labelCityName.Text = "City Name:";
            //
            //textBoxCityName
            //
            this.textBoxCityName.Location = new System.Drawing.Point(140, 13);
            this.textBoxCityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCityName.TabIndex = 3;
            //
            // labelCityCode
            //
            this.labelCityCode.AutoSize = true;
            this.labelCityCode.Location = new System.Drawing.Point(11, 36);
            this.labelCityCode.Name = "labelCityCode";
            this.labelCityCode.Size = new System.Drawing.Size(71, 13);
            this.labelCityCode.TabIndex = 4;
            this.labelCityCode.Text = "City Code:";
            //
            //textBoxCityCode
            //
            this.textBoxCityCode.Location = new System.Drawing.Point(140, 36);
            this.textBoxCityCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCityCode.Name = "textBoxCityCode";
            this.textBoxCityCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxCityCode.TabIndex = 5;
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
            // labelCountryPicker
            //
            this.labelCountryPicker.AutoSize = true;
            this.labelCountryPicker.Location = new System.Drawing.Point(11, 82);
            this.labelCountryPicker.Name = "labelCountryPicker";
            this.labelCountryPicker.Size = new System.Drawing.Size(71, 13);
            this.labelCountryPicker.TabIndex = 8;
            this.labelCountryPicker.Text = "Country:";
            //
            //countryPicker
            //
            this.countryPicker.Location = new System.Drawing.Point(140, 82);
            this.countryPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.countryPicker.Name = "countryPicker";
            this.countryPicker.Size = new System.Drawing.Size(250, 20);
            this.countryPicker.TabIndex = 9;
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
            // dataGridViewCrudeCity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeCity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeCity.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeCity.Name = "dataGridViewCrudeCity";
            this.dataGridViewCrudeCity.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeCity.TabIndex = 0;
            this.dataGridViewCrudeCity.ReadOnly = true;
            this.dataGridViewCrudeCity.DoubleClick += new System.EventHandler(this.dataGridViewCrudeCity_DoubleClick);
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
            // buttonCrudeCitySearch
            // 
            this.buttonCrudeCitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCitySearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeCitySearch.Name = "buttonCrudeCitySearch";
            this.buttonCrudeCitySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCitySearch.TabIndex = 2;
            this.buttonCrudeCitySearch.Text = "&Search";
            this.buttonCrudeCitySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeCitySearch.Click += new System.EventHandler(this.buttonCrudeCitySearch_Click);
            // 
            // buttonCrudeCityAdd
            // 
            this.buttonCrudeCityAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCityAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeCityAdd.Name = "buttonCrudeCityAdd";
            this.buttonCrudeCityAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCityAdd.TabIndex = 3;
            this.buttonCrudeCityAdd.Text = "&Add";
            this.buttonCrudeCityAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeCityAdd.Click += new System.EventHandler(this.buttonCrudeCityAdd_Click);
            // 
            // buttonCrudeCityEdit
            // 
            this.buttonCrudeCityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCityEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeCityEdit.Name = "buttonCrudeCityEdit";
            this.buttonCrudeCityEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCityEdit.TabIndex = 4;
            this.buttonCrudeCityEdit.Text = "&Edit";
            this.buttonCrudeCityEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeCityEdit.Click += new System.EventHandler(this.buttonCrudeCityEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeCitySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeCityAdd);
            this.Controls.Add(this.buttonCrudeCityEdit);
            this.Controls.Add(this.dataGridViewCrudeCity);
            this.Name = "CrudeCitySearch";
            this.Text = "City Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCity)).EndInit();
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.textBoxCityName);
            this.Controls.Add(this.labelCityCode);
            this.Controls.Add(this.textBoxCityCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelCountryPicker);
            this.Controls.Add(this.countryPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
