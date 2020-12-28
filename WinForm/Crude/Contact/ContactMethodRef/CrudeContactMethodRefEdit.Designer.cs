namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeContactMethodRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxContactMethod;
        
        private System.Windows.Forms.Label labelContactMethod;
        
        private System.Windows.Forms.TextBox textBoxContactMethodName;
        
        private System.Windows.Forms.Label labelContactMethodName;
        
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
            this.labelContactMethod = new System.Windows.Forms.Label();
            this.textBoxContactMethod = new System.Windows.Forms.TextBox();
            this.labelContactMethodName = new System.Windows.Forms.Label();
            this.textBoxContactMethodName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelContactMethod
            //
            this.labelContactMethod.AutoSize = true;
            this.labelContactMethod.Location = new System.Drawing.Point(11, 13);
            this.labelContactMethod.Name = "labelContactMethod";
            this.labelContactMethod.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethod.TabIndex = 2;
            this.labelContactMethod.Text = "Contact Method:";
            //
            //textBoxContactMethod
            //
            this.textBoxContactMethod.Location = new System.Drawing.Point(140, 13);
            this.textBoxContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethod.Name = "textBoxContactMethod";
            this.textBoxContactMethod.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethod.TabIndex = 3;
            //
            // labelContactMethodName
            //
            this.labelContactMethodName.AutoSize = true;
            this.labelContactMethodName.Location = new System.Drawing.Point(11, 36);
            this.labelContactMethodName.Name = "labelContactMethodName";
            this.labelContactMethodName.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodName.TabIndex = 4;
            this.labelContactMethodName.Text = "Contact Method Name:";
            //
            //textBoxContactMethodName
            //
            this.textBoxContactMethodName.Location = new System.Drawing.Point(140, 36);
            this.textBoxContactMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethodName.Name = "textBoxContactMethodName";
            this.textBoxContactMethodName.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethodName.TabIndex = 5;
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
            this.Name = "CrudeContactMethodRefEdit";
            this.Text = "Contact Method Ref Edit";
            this.Controls.Add(this.labelContactMethod);
            this.Controls.Add(this.textBoxContactMethod);
            this.Controls.Add(this.labelContactMethodName);
            this.Controls.Add(this.textBoxContactMethodName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
