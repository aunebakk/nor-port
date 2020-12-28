namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFirstName;
        
        private System.Windows.Forms.Label labelFirstName;
        
        private System.Windows.Forms.TextBox textBoxMiddleName;
        
        private System.Windows.Forms.Label labelMiddleName;
        
        private System.Windows.Forms.TextBox textBoxLastName;
        
        private System.Windows.Forms.Label labelLastName;
        
        private PassengerTypeRefCombo passengerTypeRefCombo;
        
        private System.Windows.Forms.Label labelPassengerTypeRefCombo;
        
        private NationalityRefCombo nationalityRefCombo;
        
        private System.Windows.Forms.Label labelNationalityRefCombo;
        
        private GenderRefCombo genderRefCombo;
        
        private System.Windows.Forms.Label labelGenderRefCombo;
        
        private TitleRefCombo titleRefCombo;
        
        private System.Windows.Forms.Label labelTitleRefCombo;
        
        private ClientTypeRefCombo clientTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientTypeRefCombo;
        
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPassengerTypeRefCombo = new System.Windows.Forms.Label();
            this.passengerTypeRefCombo = new PassengerTypeRefCombo();
            this.labelNationalityRefCombo = new System.Windows.Forms.Label();
            this.nationalityRefCombo = new NationalityRefCombo();
            this.labelGenderRefCombo = new System.Windows.Forms.Label();
            this.genderRefCombo = new GenderRefCombo();
            this.labelTitleRefCombo = new System.Windows.Forms.Label();
            this.titleRefCombo = new TitleRefCombo();
            this.labelClientTypeRefCombo = new System.Windows.Forms.Label();
            this.clientTypeRefCombo = new ClientTypeRefCombo();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFirstName
            //
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(71, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            //
            //textBoxFirstName
            //
            this.textBoxFirstName.Location = new System.Drawing.Point(140, 13);
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFirstName.TabIndex = 3;
            //
            // labelMiddleName
            //
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(11, 36);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 13);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Middle Name:";
            //
            //textBoxMiddleName
            //
            this.textBoxMiddleName.Location = new System.Drawing.Point(140, 36);
            this.textBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxMiddleName.TabIndex = 5;
            //
            // labelLastName
            //
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 59);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last Name:";
            //
            //textBoxLastName
            //
            this.textBoxLastName.Location = new System.Drawing.Point(140, 59);
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLastName.TabIndex = 7;
            //
            // labelPassengerTypeRefCombo
            //
            this.labelPassengerTypeRefCombo.AutoSize = true;
            this.labelPassengerTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelPassengerTypeRefCombo.Name = "labelPassengerTypeRefCombo";
            this.labelPassengerTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerTypeRefCombo.TabIndex = 8;
            this.labelPassengerTypeRefCombo.Text = "Passenger Type:";
            //
            //passengerTypeRefCombo
            //
            this.passengerTypeRefCombo.Location = new System.Drawing.Point(140, 82);
            this.passengerTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerTypeRefCombo.Name = "passengerTypeRefCombo";
            this.passengerTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.passengerTypeRefCombo.TabIndex = 9;
            //
            // labelNationalityRefCombo
            //
            this.labelNationalityRefCombo.AutoSize = true;
            this.labelNationalityRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelNationalityRefCombo.Name = "labelNationalityRefCombo";
            this.labelNationalityRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelNationalityRefCombo.TabIndex = 10;
            this.labelNationalityRefCombo.Text = "Nationality:";
            //
            //nationalityRefCombo
            //
            this.nationalityRefCombo.Location = new System.Drawing.Point(140, 105);
            this.nationalityRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalityRefCombo.Name = "nationalityRefCombo";
            this.nationalityRefCombo.Size = new System.Drawing.Size(250, 20);
            this.nationalityRefCombo.TabIndex = 11;
            //
            // labelGenderRefCombo
            //
            this.labelGenderRefCombo.AutoSize = true;
            this.labelGenderRefCombo.Location = new System.Drawing.Point(11, 128);
            this.labelGenderRefCombo.Name = "labelGenderRefCombo";
            this.labelGenderRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelGenderRefCombo.TabIndex = 12;
            this.labelGenderRefCombo.Text = "Gender:";
            //
            //genderRefCombo
            //
            this.genderRefCombo.Location = new System.Drawing.Point(140, 128);
            this.genderRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.genderRefCombo.Name = "genderRefCombo";
            this.genderRefCombo.Size = new System.Drawing.Size(250, 20);
            this.genderRefCombo.TabIndex = 13;
            //
            // labelTitleRefCombo
            //
            this.labelTitleRefCombo.AutoSize = true;
            this.labelTitleRefCombo.Location = new System.Drawing.Point(11, 151);
            this.labelTitleRefCombo.Name = "labelTitleRefCombo";
            this.labelTitleRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelTitleRefCombo.TabIndex = 14;
            this.labelTitleRefCombo.Text = "Title:";
            //
            //titleRefCombo
            //
            this.titleRefCombo.Location = new System.Drawing.Point(140, 151);
            this.titleRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.titleRefCombo.Name = "titleRefCombo";
            this.titleRefCombo.Size = new System.Drawing.Size(250, 20);
            this.titleRefCombo.TabIndex = 15;
            //
            // labelClientTypeRefCombo
            //
            this.labelClientTypeRefCombo.AutoSize = true;
            this.labelClientTypeRefCombo.Location = new System.Drawing.Point(11, 174);
            this.labelClientTypeRefCombo.Name = "labelClientTypeRefCombo";
            this.labelClientTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeRefCombo.TabIndex = 16;
            this.labelClientTypeRefCombo.Text = "Client Type:";
            //
            //clientTypeRefCombo
            //
            this.clientTypeRefCombo.Location = new System.Drawing.Point(140, 174);
            this.clientTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTypeRefCombo.Name = "clientTypeRefCombo";
            this.clientTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientTypeRefCombo.TabIndex = 17;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 197);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 18;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 220);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 20;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 220);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 243);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 243);
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
            this.ClientSize = new System.Drawing.Size(402, 271);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientEdit";
            this.Text = "Client Edit";
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelPassengerTypeRefCombo);
            this.Controls.Add(this.passengerTypeRefCombo);
            this.Controls.Add(this.labelNationalityRefCombo);
            this.Controls.Add(this.nationalityRefCombo);
            this.Controls.Add(this.labelGenderRefCombo);
            this.Controls.Add(this.genderRefCombo);
            this.Controls.Add(this.labelTitleRefCombo);
            this.Controls.Add(this.titleRefCombo);
            this.Controls.Add(this.labelClientTypeRefCombo);
            this.Controls.Add(this.clientTypeRefCombo);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
