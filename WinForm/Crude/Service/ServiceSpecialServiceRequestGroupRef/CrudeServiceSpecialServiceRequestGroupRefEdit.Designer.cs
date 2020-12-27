namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceSpecialServiceRequestGroupRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestGroup;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestGroup;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestGroupName;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestGroupName;
        
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
            this.labelServiceSpecialServiceRequestGroup = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestGroup = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestGroupName = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestGroupName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceSpecialServiceRequestGroup
            //
            this.labelServiceSpecialServiceRequestGroup.AutoSize = true;
            this.labelServiceSpecialServiceRequestGroup.Location = new System.Drawing.Point(11, 13);
            this.labelServiceSpecialServiceRequestGroup.Name = "labelServiceSpecialServiceRequestGroup";
            this.labelServiceSpecialServiceRequestGroup.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestGroup.TabIndex = 2;
            this.labelServiceSpecialServiceRequestGroup.Text = "Service Special Service Request Group:";
            //
            //textBoxServiceSpecialServiceRequestGroup
            //
            this.textBoxServiceSpecialServiceRequestGroup.Location = new System.Drawing.Point(294, 13);
            this.textBoxServiceSpecialServiceRequestGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestGroup.Name = "textBoxServiceSpecialServiceRequestGroup";
            this.textBoxServiceSpecialServiceRequestGroup.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestGroup.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestGroupName
            //
            this.labelServiceSpecialServiceRequestGroupName.AutoSize = true;
            this.labelServiceSpecialServiceRequestGroupName.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestGroupName.Name = "labelServiceSpecialServiceRequestGroupName";
            this.labelServiceSpecialServiceRequestGroupName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestGroupName.TabIndex = 4;
            this.labelServiceSpecialServiceRequestGroupName.Text = "Service Special Service Request Group Name:";
            //
            //textBoxServiceSpecialServiceRequestGroupName
            //
            this.textBoxServiceSpecialServiceRequestGroupName.Location = new System.Drawing.Point(294, 36);
            this.textBoxServiceSpecialServiceRequestGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestGroupName.Name = "textBoxServiceSpecialServiceRequestGroupName";
            this.textBoxServiceSpecialServiceRequestGroupName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestGroupName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(294, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(452, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(352, 82);
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
            this.ClientSize = new System.Drawing.Size(556, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServiceSpecialServiceRequestGroupRefEdit";
            this.Text = "Service Special Service Request Group Ref Edit";
            this.Controls.Add(this.labelServiceSpecialServiceRequestGroup);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestGroup);
            this.Controls.Add(this.labelServiceSpecialServiceRequestGroupName);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestGroupName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
