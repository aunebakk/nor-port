namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialFareTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialFareType;
        
        private System.Windows.Forms.Label labelFinancialFareType;
        
        private System.Windows.Forms.TextBox textBoxFinancialFareTypeName;
        
        private System.Windows.Forms.Label labelFinancialFareTypeName;
        
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
            this.labelFinancialFareType = new System.Windows.Forms.Label();
            this.textBoxFinancialFareType = new System.Windows.Forms.TextBox();
            this.labelFinancialFareTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialFareTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialFareType
            //
            this.labelFinancialFareType.AutoSize = true;
            this.labelFinancialFareType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialFareType.Name = "labelFinancialFareType";
            this.labelFinancialFareType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFareType.TabIndex = 2;
            this.labelFinancialFareType.Text = "Financial Fare Type:";
            //
            //textBoxFinancialFareType
            //
            this.textBoxFinancialFareType.Location = new System.Drawing.Point(168, 13);
            this.textBoxFinancialFareType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFareType.Name = "textBoxFinancialFareType";
            this.textBoxFinancialFareType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFareType.TabIndex = 3;
            //
            // labelFinancialFareTypeName
            //
            this.labelFinancialFareTypeName.AutoSize = true;
            this.labelFinancialFareTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialFareTypeName.Name = "labelFinancialFareTypeName";
            this.labelFinancialFareTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFareTypeName.TabIndex = 4;
            this.labelFinancialFareTypeName.Text = "Financial Fare Type Name:";
            //
            //textBoxFinancialFareTypeName
            //
            this.textBoxFinancialFareTypeName.Location = new System.Drawing.Point(168, 36);
            this.textBoxFinancialFareTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFareTypeName.Name = "textBoxFinancialFareTypeName";
            this.textBoxFinancialFareTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFareTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(226, 82);
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
            this.ClientSize = new System.Drawing.Size(430, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialFareTypeRefEdit";
            this.Text = "Financial Fare Type Ref Edit";
            this.Controls.Add(this.labelFinancialFareType);
            this.Controls.Add(this.textBoxFinancialFareType);
            this.Controls.Add(this.labelFinancialFareTypeName);
            this.Controls.Add(this.textBoxFinancialFareTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
