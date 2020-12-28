namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleSegmentRuleRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFlightScheduleSegmentRule;
        
        private System.Windows.Forms.Label labelFlightScheduleSegmentRule;
        
        private System.Windows.Forms.TextBox textBoxFlightScheduleSegmentRuleName;
        
        private System.Windows.Forms.Label labelFlightScheduleSegmentRuleName;
        
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
            this.labelFlightScheduleSegmentRule = new System.Windows.Forms.Label();
            this.textBoxFlightScheduleSegmentRule = new System.Windows.Forms.TextBox();
            this.labelFlightScheduleSegmentRuleName = new System.Windows.Forms.Label();
            this.textBoxFlightScheduleSegmentRuleName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFlightScheduleSegmentRule
            //
            this.labelFlightScheduleSegmentRule.AutoSize = true;
            this.labelFlightScheduleSegmentRule.Location = new System.Drawing.Point(11, 13);
            this.labelFlightScheduleSegmentRule.Name = "labelFlightScheduleSegmentRule";
            this.labelFlightScheduleSegmentRule.Size = new System.Drawing.Size(71, 13);
            this.labelFlightScheduleSegmentRule.TabIndex = 2;
            this.labelFlightScheduleSegmentRule.Text = "Flight Schedule Segment Rule:";
            //
            //textBoxFlightScheduleSegmentRule
            //
            this.textBoxFlightScheduleSegmentRule.Location = new System.Drawing.Point(231, 13);
            this.textBoxFlightScheduleSegmentRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightScheduleSegmentRule.Name = "textBoxFlightScheduleSegmentRule";
            this.textBoxFlightScheduleSegmentRule.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightScheduleSegmentRule.TabIndex = 3;
            //
            // labelFlightScheduleSegmentRuleName
            //
            this.labelFlightScheduleSegmentRuleName.AutoSize = true;
            this.labelFlightScheduleSegmentRuleName.Location = new System.Drawing.Point(11, 36);
            this.labelFlightScheduleSegmentRuleName.Name = "labelFlightScheduleSegmentRuleName";
            this.labelFlightScheduleSegmentRuleName.Size = new System.Drawing.Size(71, 13);
            this.labelFlightScheduleSegmentRuleName.TabIndex = 4;
            this.labelFlightScheduleSegmentRuleName.Text = "Flight Schedule Segment Rule Name:";
            //
            //textBoxFlightScheduleSegmentRuleName
            //
            this.textBoxFlightScheduleSegmentRuleName.Location = new System.Drawing.Point(231, 36);
            this.textBoxFlightScheduleSegmentRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightScheduleSegmentRuleName.Name = "textBoxFlightScheduleSegmentRuleName";
            this.textBoxFlightScheduleSegmentRuleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightScheduleSegmentRuleName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(231, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(289, 82);
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
            this.ClientSize = new System.Drawing.Size(493, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFlightScheduleSegmentRuleRefEdit";
            this.Text = "Flight Schedule Segment Rule Ref Edit";
            this.Controls.Add(this.labelFlightScheduleSegmentRule);
            this.Controls.Add(this.textBoxFlightScheduleSegmentRule);
            this.Controls.Add(this.labelFlightScheduleSegmentRuleName);
            this.Controls.Add(this.textBoxFlightScheduleSegmentRuleName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
