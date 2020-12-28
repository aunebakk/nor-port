namespace SolutionNorSolutionPort.UserInterface
{


    public partial class BookingPassengerEdit
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private DefaultUserPicker userPicker;

        private System.Windows.Forms.Label labelUserPicker;

        private System.Windows.Forms.TextBox dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new SolutionNorSolutionPort.UserInterface.DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelPassengerTypeRefCombo = new System.Windows.Forms.Label();
            this.passengerTypeRefCombo = new SolutionNorSolutionPort.UserInterface.PassengerTypeRefCombo();
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.labelDefaultStateRefCombo = new System.Windows.Forms.Label();
            this.defaultStateRefCombo = new SolutionNorSolutionPort.UserInterface.DefaultStateRefCombo();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(299, 140);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSave.Location = new System.Drawing.Point(199, 140);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelUserPicker
            // 
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 87);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(32, 13);
            this.labelUserPicker.TabIndex = 4;
            this.labelUserPicker.Text = "User:";
            // 
            // userPicker
            // 
            this.userPicker.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.userPicker.Location = new System.Drawing.Point(140, 87);
            this.userPicker.Name = "userPicker";
            this.userPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 5;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 110);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(59, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            // 
            // dateTimePickerDateTime
            // 
            this.dateTimePickerDateTime.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 110);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // labelPassengerTypeRefCombo
            // 
            this.labelPassengerTypeRefCombo.AutoSize = true;
            this.labelPassengerTypeRefCombo.Location = new System.Drawing.Point(12, 9);
            this.labelPassengerTypeRefCombo.Name = "labelPassengerTypeRefCombo";
            this.labelPassengerTypeRefCombo.Size = new System.Drawing.Size(87, 13);
            this.labelPassengerTypeRefCombo.TabIndex = 8;
            this.labelPassengerTypeRefCombo.Text = "Passenger Type:";
            // 
            // passengerTypeRefCombo
            // 
            this.passengerTypeRefCombo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.passengerTypeRefCombo.Location = new System.Drawing.Point(141, 9);
            this.passengerTypeRefCombo.Name = "passengerTypeRefCombo";
            this.passengerTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.passengerTypeRefCombo.TabIndex = 9;
            // 
            // labelPassengerName
            // 
            this.labelPassengerName.AutoSize = true;
            this.labelPassengerName.Location = new System.Drawing.Point(11, 35);
            this.labelPassengerName.Name = "labelPassengerName";
            this.labelPassengerName.Size = new System.Drawing.Size(91, 13);
            this.labelPassengerName.TabIndex = 10;
            this.labelPassengerName.Text = "Passenger Name:";
            // 
            // textBoxPassengerName
            // 
            this.textBoxPassengerName.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxPassengerName.Location = new System.Drawing.Point(140, 35);
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerName.TabIndex = 11;
            // 
            // labelDefaultStateRefCombo
            // 
            this.labelDefaultStateRefCombo.AutoSize = true;
            this.labelDefaultStateRefCombo.Location = new System.Drawing.Point(11, 61);
            this.labelDefaultStateRefCombo.Name = "labelDefaultStateRefCombo";
            this.labelDefaultStateRefCombo.Size = new System.Drawing.Size(72, 13);
            this.labelDefaultStateRefCombo.TabIndex = 12;
            this.labelDefaultStateRefCombo.Text = "Default State:";
            // 
            // defaultStateRefCombo
            // 
            this.defaultStateRefCombo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.defaultStateRefCombo.Location = new System.Drawing.Point(141, 61);
            this.defaultStateRefCombo.Name = "defaultStateRefCombo";
            this.defaultStateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultStateRefCombo.TabIndex = 13;
            // 
            // BookingPassengerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 174);
            this.Controls.Add(this.labelDefaultStateRefCombo);
            this.Controls.Add(this.defaultStateRefCombo);
            this.Controls.Add(this.labelPassengerTypeRefCombo);
            this.Controls.Add(this.passengerTypeRefCombo);
            this.Controls.Add(this.labelPassengerName);
            this.Controls.Add(this.textBoxPassengerName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Name = "BookingPassengerEdit";
            this.Text = "Booking Passenger Edit";
            this.Load += new System.EventHandler(this.BookingPassengerEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelPassengerTypeRefCombo;
        private PassengerTypeRefCombo passengerTypeRefCombo;
        private System.Windows.Forms.Label labelPassengerName;
        private System.Windows.Forms.TextBox textBoxPassengerName;
        private System.Windows.Forms.Label labelDefaultStateRefCombo;
        private DefaultStateRefCombo defaultStateRefCombo;
    }
}
