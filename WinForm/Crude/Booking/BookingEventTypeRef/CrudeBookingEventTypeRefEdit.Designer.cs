namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingEventTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxBookingEventType;
        
        private System.Windows.Forms.Label labelBookingEventType;
        
        private System.Windows.Forms.TextBox textBoxBookingEventTypeName;
        
        private System.Windows.Forms.Label labelBookingEventTypeName;
        
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
            this.labelBookingEventType = new System.Windows.Forms.Label();
            this.textBoxBookingEventType = new System.Windows.Forms.TextBox();
            this.labelBookingEventTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingEventTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingEventType
            //
            this.labelBookingEventType.AutoSize = true;
            this.labelBookingEventType.Location = new System.Drawing.Point(11, 13);
            this.labelBookingEventType.Name = "labelBookingEventType";
            this.labelBookingEventType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingEventType.TabIndex = 2;
            this.labelBookingEventType.Text = "Booking Event Type:";
            //
            //textBoxBookingEventType
            //
            this.textBoxBookingEventType.Location = new System.Drawing.Point(161, 13);
            this.textBoxBookingEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingEventType.Name = "textBoxBookingEventType";
            this.textBoxBookingEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingEventType.TabIndex = 3;
            //
            // labelBookingEventTypeName
            //
            this.labelBookingEventTypeName.AutoSize = true;
            this.labelBookingEventTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelBookingEventTypeName.Name = "labelBookingEventTypeName";
            this.labelBookingEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingEventTypeName.TabIndex = 4;
            this.labelBookingEventTypeName.Text = "Booking Event Type Name:";
            //
            //textBoxBookingEventTypeName
            //
            this.textBoxBookingEventTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxBookingEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingEventTypeName.Name = "textBoxBookingEventTypeName";
            this.textBoxBookingEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingEventTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 82);
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
            this.ClientSize = new System.Drawing.Size(423, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeBookingEventTypeRefEdit";
            this.Text = "Booking Event Type Ref Edit";
            this.Controls.Add(this.labelBookingEventType);
            this.Controls.Add(this.textBoxBookingEventType);
            this.Controls.Add(this.labelBookingEventTypeName);
            this.Controls.Add(this.textBoxBookingEventTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
