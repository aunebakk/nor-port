namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineLanguageEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
        private LanguageRefCombo languageRefCombo;
        
        private System.Windows.Forms.Label labelLanguageRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAirlineLanguageName;
        
        private System.Windows.Forms.Label labelAirlineLanguageName;
        
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
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelLanguageRefCombo = new System.Windows.Forms.Label();
            this.languageRefCombo = new LanguageRefCombo();
            this.labelAirlineLanguageName = new System.Windows.Forms.Label();
            this.textBoxAirlineLanguageName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 13);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 2;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(147, 13);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 3;
            //
            // labelLanguageRefCombo
            //
            this.labelLanguageRefCombo.AutoSize = true;
            this.labelLanguageRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelLanguageRefCombo.Name = "labelLanguageRefCombo";
            this.labelLanguageRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelLanguageRefCombo.TabIndex = 4;
            this.labelLanguageRefCombo.Text = "Language:";
            //
            //languageRefCombo
            //
            this.languageRefCombo.Location = new System.Drawing.Point(147, 36);
            this.languageRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.languageRefCombo.Name = "languageRefCombo";
            this.languageRefCombo.Size = new System.Drawing.Size(250, 20);
            this.languageRefCombo.TabIndex = 5;
            //
            // labelAirlineLanguageName
            //
            this.labelAirlineLanguageName.AutoSize = true;
            this.labelAirlineLanguageName.Location = new System.Drawing.Point(11, 59);
            this.labelAirlineLanguageName.Name = "labelAirlineLanguageName";
            this.labelAirlineLanguageName.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineLanguageName.TabIndex = 6;
            this.labelAirlineLanguageName.Text = "Airline Language Name:";
            //
            //textBoxAirlineLanguageName
            //
            this.textBoxAirlineLanguageName.Location = new System.Drawing.Point(147, 59);
            this.textBoxAirlineLanguageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineLanguageName.Name = "textBoxAirlineLanguageName";
            this.textBoxAirlineLanguageName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineLanguageName.TabIndex = 7;
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
            this.userPicker.Location = new System.Drawing.Point(147, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 128);
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
            this.ClientSize = new System.Drawing.Size(409, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirlineLanguageEdit";
            this.Text = "Airline Language Edit";
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelLanguageRefCombo);
            this.Controls.Add(this.languageRefCombo);
            this.Controls.Add(this.labelAirlineLanguageName);
            this.Controls.Add(this.textBoxAirlineLanguageName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
