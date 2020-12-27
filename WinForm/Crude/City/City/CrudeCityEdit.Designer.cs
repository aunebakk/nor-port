namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeCityEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private CountryPicker countryPicker;
        
        private System.Windows.Forms.Label labelCountryPicker;
        
        private System.Windows.Forms.TextBox textBoxCityCode;
        
        private System.Windows.Forms.Label labelCityCode;
        
        private System.Windows.Forms.TextBox textBoxCityName;
        
        private System.Windows.Forms.Label labelCityName;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCountryPicker = new System.Windows.Forms.Label();
            this.countryPicker = new CountryPicker();
            this.labelCityCode = new System.Windows.Forms.Label();
            this.textBoxCityCode = new System.Windows.Forms.TextBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelCountryPicker
            //
            this.labelCountryPicker.AutoSize = true;
            this.labelCountryPicker.Location = new System.Drawing.Point(11, 13);
            this.labelCountryPicker.Name = "labelCountryPicker";
            this.labelCountryPicker.Size = new System.Drawing.Size(71, 13);
            this.labelCountryPicker.TabIndex = 2;
            this.labelCountryPicker.Text = "Country:";
            //
            //countryPicker
            //
            this.countryPicker.Location = new System.Drawing.Point(140, 13);
            this.countryPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.countryPicker.Name = "countryPicker";
            this.countryPicker.Size = new System.Drawing.Size(250, 20);
            this.countryPicker.TabIndex = 3;
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
            // labelCityName
            //
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(11, 59);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(71, 13);
            this.labelCityName.TabIndex = 6;
            this.labelCityName.Text = "City Name:";
            //
            //textBoxCityName
            //
            this.textBoxCityName.Location = new System.Drawing.Point(140, 59);
            this.textBoxCityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCityName.TabIndex = 7;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 128);
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
            this.ClientSize = new System.Drawing.Size(402, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeCityEdit";
            this.Text = "City Edit";
            this.Controls.Add(this.labelCountryPicker);
            this.Controls.Add(this.countryPicker);
            this.Controls.Add(this.labelCityCode);
            this.Controls.Add(this.textBoxCityCode);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.textBoxCityName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
