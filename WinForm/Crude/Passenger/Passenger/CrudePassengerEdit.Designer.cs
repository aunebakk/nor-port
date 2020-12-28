namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudePassengerEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private PassengerTypeRefCombo passengerTypeRefCombo;
        
        private System.Windows.Forms.Label labelPassengerTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxPassengerName;
        
        private System.Windows.Forms.Label labelPassengerName;
        
        private DefaultStateRefCombo defaultStateRefCombo;
        
        private System.Windows.Forms.Label labelDefaultStateRefCombo;
        
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
            this.labelPassengerTypeRefCombo = new System.Windows.Forms.Label();
            this.passengerTypeRefCombo = new PassengerTypeRefCombo();
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.labelDefaultStateRefCombo = new System.Windows.Forms.Label();
            this.defaultStateRefCombo = new DefaultStateRefCombo();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelPassengerTypeRefCombo
            //
            this.labelPassengerTypeRefCombo.AutoSize = true;
            this.labelPassengerTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelPassengerTypeRefCombo.Name = "labelPassengerTypeRefCombo";
            this.labelPassengerTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerTypeRefCombo.TabIndex = 2;
            this.labelPassengerTypeRefCombo.Text = "Passenger Type:";
            //
            //passengerTypeRefCombo
            //
            this.passengerTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.passengerTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerTypeRefCombo.Name = "passengerTypeRefCombo";
            this.passengerTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.passengerTypeRefCombo.TabIndex = 3;
            //
            // labelPassengerName
            //
            this.labelPassengerName.AutoSize = true;
            this.labelPassengerName.Location = new System.Drawing.Point(11, 36);
            this.labelPassengerName.Name = "labelPassengerName";
            this.labelPassengerName.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerName.TabIndex = 4;
            this.labelPassengerName.Text = "Passenger Name:";
            //
            //textBoxPassengerName
            //
            this.textBoxPassengerName.Location = new System.Drawing.Point(140, 36);
            this.textBoxPassengerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerName.TabIndex = 5;
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
            this.Name = "CrudePassengerEdit";
            this.Text = "Passenger Edit";
            this.Controls.Add(this.labelPassengerTypeRefCombo);
            this.Controls.Add(this.passengerTypeRefCombo);
            this.Controls.Add(this.labelPassengerName);
            this.Controls.Add(this.textBoxPassengerName);
            this.Controls.Add(this.labelDefaultStateRefCombo);
            this.Controls.Add(this.defaultStateRefCombo);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
