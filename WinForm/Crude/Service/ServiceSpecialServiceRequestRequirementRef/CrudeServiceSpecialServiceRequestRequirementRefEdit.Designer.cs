namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceSpecialServiceRequestRequirementRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestRequirement;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestRequirement;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestRequirementName;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestRequirementName;
        
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
            this.labelServiceSpecialServiceRequestRequirement = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestRequirement = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestRequirementName = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestRequirementName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceSpecialServiceRequestRequirement
            //
            this.labelServiceSpecialServiceRequestRequirement.AutoSize = true;
            this.labelServiceSpecialServiceRequestRequirement.Location = new System.Drawing.Point(11, 13);
            this.labelServiceSpecialServiceRequestRequirement.Name = "labelServiceSpecialServiceRequestRequirement";
            this.labelServiceSpecialServiceRequestRequirement.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestRequirement.TabIndex = 2;
            this.labelServiceSpecialServiceRequestRequirement.Text = "Service Special Service Request Requirement:";
            //
            //textBoxServiceSpecialServiceRequestRequirement
            //
            this.textBoxServiceSpecialServiceRequestRequirement.Location = new System.Drawing.Point(336, 13);
            this.textBoxServiceSpecialServiceRequestRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestRequirement.Name = "textBoxServiceSpecialServiceRequestRequirement";
            this.textBoxServiceSpecialServiceRequestRequirement.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestRequirement.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestRequirementName
            //
            this.labelServiceSpecialServiceRequestRequirementName.AutoSize = true;
            this.labelServiceSpecialServiceRequestRequirementName.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestRequirementName.Name = "labelServiceSpecialServiceRequestRequirementName";
            this.labelServiceSpecialServiceRequestRequirementName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestRequirementName.TabIndex = 4;
            this.labelServiceSpecialServiceRequestRequirementName.Text = "Service Special Service Request Requirement Name:";
            //
            //textBoxServiceSpecialServiceRequestRequirementName
            //
            this.textBoxServiceSpecialServiceRequestRequirementName.Location = new System.Drawing.Point(336, 36);
            this.textBoxServiceSpecialServiceRequestRequirementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestRequirementName.Name = "textBoxServiceSpecialServiceRequestRequirementName";
            this.textBoxServiceSpecialServiceRequestRequirementName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestRequirementName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(336, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(494, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(394, 82);
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
            this.ClientSize = new System.Drawing.Size(598, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServiceSpecialServiceRequestRequirementRefEdit";
            this.Text = "Service Special Service Request Requirement Ref Edit";
            this.Controls.Add(this.labelServiceSpecialServiceRequestRequirement);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestRequirement);
            this.Controls.Add(this.labelServiceSpecialServiceRequestRequirementName);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestRequirementName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
