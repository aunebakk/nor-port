namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeGenderRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxGender;
        
        private System.Windows.Forms.Label labelGender;
        
        private System.Windows.Forms.TextBox textBoxGenderName;
        
        private System.Windows.Forms.Label labelGenderName;
        
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
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.labelGenderName = new System.Windows.Forms.Label();
            this.textBoxGenderName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelGender
            //
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(11, 13);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(71, 13);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender:";
            //
            //textBoxGender
            //
            this.textBoxGender.Location = new System.Drawing.Point(140, 13);
            this.textBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(250, 20);
            this.textBoxGender.TabIndex = 3;
            //
            // labelGenderName
            //
            this.labelGenderName.AutoSize = true;
            this.labelGenderName.Location = new System.Drawing.Point(11, 36);
            this.labelGenderName.Name = "labelGenderName";
            this.labelGenderName.Size = new System.Drawing.Size(71, 13);
            this.labelGenderName.TabIndex = 4;
            this.labelGenderName.Text = "Gender Name:";
            //
            //textBoxGenderName
            //
            this.textBoxGenderName.Location = new System.Drawing.Point(140, 36);
            this.textBoxGenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGenderName.Name = "textBoxGenderName";
            this.textBoxGenderName.Size = new System.Drawing.Size(250, 20);
            this.textBoxGenderName.TabIndex = 5;
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
            this.Name = "CrudeGenderRefEdit";
            this.Text = "Gender Ref Edit";
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.labelGenderName);
            this.Controls.Add(this.textBoxGenderName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
