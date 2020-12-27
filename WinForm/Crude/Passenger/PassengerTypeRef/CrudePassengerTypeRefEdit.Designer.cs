namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudePassengerTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxPassengerType;
        
        private System.Windows.Forms.Label labelPassengerType;
        
        private System.Windows.Forms.TextBox textBoxPassengerTypeName;
        
        private System.Windows.Forms.Label labelPassengerTypeName;
        
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
            this.labelPassengerType = new System.Windows.Forms.Label();
            this.textBoxPassengerType = new System.Windows.Forms.TextBox();
            this.labelPassengerTypeName = new System.Windows.Forms.Label();
            this.textBoxPassengerTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelPassengerType
            //
            this.labelPassengerType.AutoSize = true;
            this.labelPassengerType.Location = new System.Drawing.Point(11, 13);
            this.labelPassengerType.Name = "labelPassengerType";
            this.labelPassengerType.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerType.TabIndex = 2;
            this.labelPassengerType.Text = "Passenger Type:";
            //
            //textBoxPassengerType
            //
            this.textBoxPassengerType.Location = new System.Drawing.Point(140, 13);
            this.textBoxPassengerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassengerType.Name = "textBoxPassengerType";
            this.textBoxPassengerType.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerType.TabIndex = 3;
            //
            // labelPassengerTypeName
            //
            this.labelPassengerTypeName.AutoSize = true;
            this.labelPassengerTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelPassengerTypeName.Name = "labelPassengerTypeName";
            this.labelPassengerTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerTypeName.TabIndex = 4;
            this.labelPassengerTypeName.Text = "Passenger Type Name:";
            //
            //textBoxPassengerTypeName
            //
            this.textBoxPassengerTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxPassengerTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassengerTypeName.Name = "textBoxPassengerTypeName";
            this.textBoxPassengerTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerTypeName.TabIndex = 5;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 82);
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
            this.ClientSize = new System.Drawing.Size(402, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudePassengerTypeRefEdit";
            this.Text = "Passenger Type Ref Edit";
            this.Controls.Add(this.labelPassengerType);
            this.Controls.Add(this.textBoxPassengerType);
            this.Controls.Add(this.labelPassengerTypeName);
            this.Controls.Add(this.textBoxPassengerTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
