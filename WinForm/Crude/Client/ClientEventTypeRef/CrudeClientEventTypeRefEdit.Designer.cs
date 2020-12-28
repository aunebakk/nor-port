namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientEventTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientEventType;
        
        private System.Windows.Forms.Label labelClientEventType;
        
        private System.Windows.Forms.TextBox textBoxClientEventTypeName;
        
        private System.Windows.Forms.Label labelClientEventTypeName;
        
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
            this.labelClientEventType = new System.Windows.Forms.Label();
            this.textBoxClientEventType = new System.Windows.Forms.TextBox();
            this.labelClientEventTypeName = new System.Windows.Forms.Label();
            this.textBoxClientEventTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientEventType
            //
            this.labelClientEventType.AutoSize = true;
            this.labelClientEventType.Location = new System.Drawing.Point(11, 13);
            this.labelClientEventType.Name = "labelClientEventType";
            this.labelClientEventType.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventType.TabIndex = 2;
            this.labelClientEventType.Text = "Client Event Type:";
            //
            //textBoxClientEventType
            //
            this.textBoxClientEventType.Location = new System.Drawing.Point(154, 13);
            this.textBoxClientEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientEventType.Name = "textBoxClientEventType";
            this.textBoxClientEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientEventType.TabIndex = 3;
            //
            // labelClientEventTypeName
            //
            this.labelClientEventTypeName.AutoSize = true;
            this.labelClientEventTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelClientEventTypeName.Name = "labelClientEventTypeName";
            this.labelClientEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventTypeName.TabIndex = 4;
            this.labelClientEventTypeName.Text = "Client Event Type Name:";
            //
            //textBoxClientEventTypeName
            //
            this.textBoxClientEventTypeName.Location = new System.Drawing.Point(154, 36);
            this.textBoxClientEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientEventTypeName.Name = "textBoxClientEventTypeName";
            this.textBoxClientEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientEventTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 82);
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
            this.ClientSize = new System.Drawing.Size(416, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientEventTypeRefEdit";
            this.Text = "Client Event Type Ref Edit";
            this.Controls.Add(this.labelClientEventType);
            this.Controls.Add(this.textBoxClientEventType);
            this.Controls.Add(this.labelClientEventTypeName);
            this.Controls.Add(this.textBoxClientEventTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
