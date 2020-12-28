namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeReportingRoundupTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxReportingRoundupType;
        
        private System.Windows.Forms.Label labelReportingRoundupType;
        
        private System.Windows.Forms.TextBox textBoxReportingRoundupTypeName;
        
        private System.Windows.Forms.Label labelReportingRoundupTypeName;
        
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
            this.labelReportingRoundupType = new System.Windows.Forms.Label();
            this.textBoxReportingRoundupType = new System.Windows.Forms.TextBox();
            this.labelReportingRoundupTypeName = new System.Windows.Forms.Label();
            this.textBoxReportingRoundupTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelReportingRoundupType
            //
            this.labelReportingRoundupType.AutoSize = true;
            this.labelReportingRoundupType.Location = new System.Drawing.Point(11, 13);
            this.labelReportingRoundupType.Name = "labelReportingRoundupType";
            this.labelReportingRoundupType.Size = new System.Drawing.Size(71, 13);
            this.labelReportingRoundupType.TabIndex = 2;
            this.labelReportingRoundupType.Text = "Reporting Roundup Type:";
            //
            //textBoxReportingRoundupType
            //
            this.textBoxReportingRoundupType.Location = new System.Drawing.Point(189, 13);
            this.textBoxReportingRoundupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportingRoundupType.Name = "textBoxReportingRoundupType";
            this.textBoxReportingRoundupType.Size = new System.Drawing.Size(250, 20);
            this.textBoxReportingRoundupType.TabIndex = 3;
            //
            // labelReportingRoundupTypeName
            //
            this.labelReportingRoundupTypeName.AutoSize = true;
            this.labelReportingRoundupTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelReportingRoundupTypeName.Name = "labelReportingRoundupTypeName";
            this.labelReportingRoundupTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelReportingRoundupTypeName.TabIndex = 4;
            this.labelReportingRoundupTypeName.Text = "Reporting Roundup Type Name:";
            //
            //textBoxReportingRoundupTypeName
            //
            this.textBoxReportingRoundupTypeName.Location = new System.Drawing.Point(189, 36);
            this.textBoxReportingRoundupTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportingRoundupTypeName.Name = "textBoxReportingRoundupTypeName";
            this.textBoxReportingRoundupTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxReportingRoundupTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 82);
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
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeReportingRoundupTypeRefEdit";
            this.Text = "Reporting Roundup Type Ref Edit";
            this.Controls.Add(this.labelReportingRoundupType);
            this.Controls.Add(this.textBoxReportingRoundupType);
            this.Controls.Add(this.labelReportingRoundupTypeName);
            this.Controls.Add(this.textBoxReportingRoundupTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
