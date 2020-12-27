namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceSpecialServiceRequestOperationRuleRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestOperationRule;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestOperationRule;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestOperationRuleName;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestOperationRuleName;
        
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
            this.labelServiceSpecialServiceRequestOperationRule = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestOperationRule = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestOperationRuleName = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestOperationRuleName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceSpecialServiceRequestOperationRule
            //
            this.labelServiceSpecialServiceRequestOperationRule.AutoSize = true;
            this.labelServiceSpecialServiceRequestOperationRule.Location = new System.Drawing.Point(11, 13);
            this.labelServiceSpecialServiceRequestOperationRule.Name = "labelServiceSpecialServiceRequestOperationRule";
            this.labelServiceSpecialServiceRequestOperationRule.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestOperationRule.TabIndex = 2;
            this.labelServiceSpecialServiceRequestOperationRule.Text = "Service Special Service Request Operation Rule:";
            //
            //textBoxServiceSpecialServiceRequestOperationRule
            //
            this.textBoxServiceSpecialServiceRequestOperationRule.Location = new System.Drawing.Point(357, 13);
            this.textBoxServiceSpecialServiceRequestOperationRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestOperationRule.Name = "textBoxServiceSpecialServiceRequestOperationRule";
            this.textBoxServiceSpecialServiceRequestOperationRule.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestOperationRule.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestOperationRuleName
            //
            this.labelServiceSpecialServiceRequestOperationRuleName.AutoSize = true;
            this.labelServiceSpecialServiceRequestOperationRuleName.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestOperationRuleName.Name = "labelServiceSpecialServiceRequestOperationRuleName";
            this.labelServiceSpecialServiceRequestOperationRuleName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestOperationRuleName.TabIndex = 4;
            this.labelServiceSpecialServiceRequestOperationRuleName.Text = "Service Special Service Request Operation Rule Name:";
            //
            //textBoxServiceSpecialServiceRequestOperationRuleName
            //
            this.textBoxServiceSpecialServiceRequestOperationRuleName.Location = new System.Drawing.Point(357, 36);
            this.textBoxServiceSpecialServiceRequestOperationRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestOperationRuleName.Name = "textBoxServiceSpecialServiceRequestOperationRuleName";
            this.textBoxServiceSpecialServiceRequestOperationRuleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestOperationRuleName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(357, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(515, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(415, 82);
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
            this.ClientSize = new System.Drawing.Size(619, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServiceSpecialServiceRequestOperationRuleRefEdit";
            this.Text = "Service Special Service Request Operation Rule Ref Edit";
            this.Controls.Add(this.labelServiceSpecialServiceRequestOperationRule);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestOperationRule);
            this.Controls.Add(this.labelServiceSpecialServiceRequestOperationRuleName);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestOperationRuleName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
