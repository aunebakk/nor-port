namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerEventTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxBookingPassengerEventType;
        
        private System.Windows.Forms.Label labelBookingPassengerEventType;
        
        private System.Windows.Forms.TextBox textBoxBookingPassengerEventTypeName;
        
        private System.Windows.Forms.Label labelBookingPassengerEventTypeName;
        
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
            this.labelBookingPassengerEventType = new System.Windows.Forms.Label();
            this.textBoxBookingPassengerEventType = new System.Windows.Forms.TextBox();
            this.labelBookingPassengerEventTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingPassengerEventTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingPassengerEventType
            //
            this.labelBookingPassengerEventType.AutoSize = true;
            this.labelBookingPassengerEventType.Location = new System.Drawing.Point(11, 13);
            this.labelBookingPassengerEventType.Name = "labelBookingPassengerEventType";
            this.labelBookingPassengerEventType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventType.TabIndex = 2;
            this.labelBookingPassengerEventType.Text = "Booking Passenger Event Type:";
            //
            //textBoxBookingPassengerEventType
            //
            this.textBoxBookingPassengerEventType.Location = new System.Drawing.Point(231, 13);
            this.textBoxBookingPassengerEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingPassengerEventType.Name = "textBoxBookingPassengerEventType";
            this.textBoxBookingPassengerEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingPassengerEventType.TabIndex = 3;
            //
            // labelBookingPassengerEventTypeName
            //
            this.labelBookingPassengerEventTypeName.AutoSize = true;
            this.labelBookingPassengerEventTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelBookingPassengerEventTypeName.Name = "labelBookingPassengerEventTypeName";
            this.labelBookingPassengerEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventTypeName.TabIndex = 4;
            this.labelBookingPassengerEventTypeName.Text = "Booking Passenger Event Type Name:";
            //
            //textBoxBookingPassengerEventTypeName
            //
            this.textBoxBookingPassengerEventTypeName.Location = new System.Drawing.Point(231, 36);
            this.textBoxBookingPassengerEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingPassengerEventTypeName.Name = "textBoxBookingPassengerEventTypeName";
            this.textBoxBookingPassengerEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingPassengerEventTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(231, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(289, 82);
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
            this.ClientSize = new System.Drawing.Size(493, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeBookingPassengerEventTypeRefEdit";
            this.Text = "Booking Passenger Event Type Ref Edit";
            this.Controls.Add(this.labelBookingPassengerEventType);
            this.Controls.Add(this.textBoxBookingPassengerEventType);
            this.Controls.Add(this.labelBookingPassengerEventTypeName);
            this.Controls.Add(this.textBoxBookingPassengerEventTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
