namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialCostcentreEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialCostcentreCode;
        
        private System.Windows.Forms.Label labelFinancialCostcentreCode;
        
        private System.Windows.Forms.TextBox textBoxFinancialCostcentreName;
        
        private System.Windows.Forms.Label labelFinancialCostcentreName;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
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
            this.labelFinancialCostcentreCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCostcentreCode = new System.Windows.Forms.TextBox();
            this.labelFinancialCostcentreName = new System.Windows.Forms.Label();
            this.textBoxFinancialCostcentreName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialCostcentreCode
            //
            this.labelFinancialCostcentreCode.AutoSize = true;
            this.labelFinancialCostcentreCode.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCostcentreCode.Name = "labelFinancialCostcentreCode";
            this.labelFinancialCostcentreCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentreCode.TabIndex = 2;
            this.labelFinancialCostcentreCode.Text = "Financial Costcentre Code:";
            //
            //textBoxFinancialCostcentreCode
            //
            this.textBoxFinancialCostcentreCode.Location = new System.Drawing.Point(175, 13);
            this.textBoxFinancialCostcentreCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCostcentreCode.Name = "textBoxFinancialCostcentreCode";
            this.textBoxFinancialCostcentreCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCostcentreCode.TabIndex = 3;
            //
            // labelFinancialCostcentreName
            //
            this.labelFinancialCostcentreName.AutoSize = true;
            this.labelFinancialCostcentreName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCostcentreName.Name = "labelFinancialCostcentreName";
            this.labelFinancialCostcentreName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentreName.TabIndex = 4;
            this.labelFinancialCostcentreName.Text = "Financial Costcentre Name:";
            //
            //textBoxFinancialCostcentreName
            //
            this.textBoxFinancialCostcentreName.Location = new System.Drawing.Point(175, 36);
            this.textBoxFinancialCostcentreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCostcentreName.Name = "textBoxFinancialCostcentreName";
            this.textBoxFinancialCostcentreName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCostcentreName.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(175, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(233, 105);
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
            this.ClientSize = new System.Drawing.Size(437, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCostcentreEdit";
            this.Text = "Financial Costcentre Edit";
            this.Controls.Add(this.labelFinancialCostcentreCode);
            this.Controls.Add(this.textBoxFinancialCostcentreCode);
            this.Controls.Add(this.labelFinancialCostcentreName);
            this.Controls.Add(this.textBoxFinancialCostcentreName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
