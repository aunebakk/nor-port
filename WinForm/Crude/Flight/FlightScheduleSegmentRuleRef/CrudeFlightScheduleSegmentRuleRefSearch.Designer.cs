namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleSegmentRuleRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentRuleRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentRuleRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentRuleRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightScheduleSegmentRuleRef;
        
        private System.Windows.Forms.TextBox textBoxFlightScheduleSegmentRuleName;
        
        private System.Windows.Forms.Label labelFlightScheduleSegmentRuleName;
        
        private System.Windows.Forms.TextBox textBoxFlightScheduleSegmentRule;
        
        private System.Windows.Forms.Label labelFlightScheduleSegmentRule;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef = new System.Windows.Forms.DataGridView();
            this.labelFlightScheduleSegmentRuleName = new System.Windows.Forms.Label();
            this.textBoxFlightScheduleSegmentRuleName = new System.Windows.Forms.TextBox();
            this.labelFlightScheduleSegmentRule = new System.Windows.Forms.Label();
            this.textBoxFlightScheduleSegmentRule = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleSegmentRuleRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFlightScheduleSegmentRuleName
            //
            this.labelFlightScheduleSegmentRuleName.AutoSize = true;
            this.labelFlightScheduleSegmentRuleName.Location = new System.Drawing.Point(11, 13);
            this.labelFlightScheduleSegmentRuleName.Name = "labelFlightScheduleSegmentRuleName";
            this.labelFlightScheduleSegmentRuleName.Size = new System.Drawing.Size(71, 13);
            this.labelFlightScheduleSegmentRuleName.TabIndex = 2;
            this.labelFlightScheduleSegmentRuleName.Text = "Flight Schedule Segment Rule Name:";
            //
            //textBoxFlightScheduleSegmentRuleName
            //
            this.textBoxFlightScheduleSegmentRuleName.Location = new System.Drawing.Point(231, 13);
            this.textBoxFlightScheduleSegmentRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightScheduleSegmentRuleName.Name = "textBoxFlightScheduleSegmentRuleName";
            this.textBoxFlightScheduleSegmentRuleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightScheduleSegmentRuleName.TabIndex = 3;
            //
            // labelFlightScheduleSegmentRule
            //
            this.labelFlightScheduleSegmentRule.AutoSize = true;
            this.labelFlightScheduleSegmentRule.Location = new System.Drawing.Point(11, 36);
            this.labelFlightScheduleSegmentRule.Name = "labelFlightScheduleSegmentRule";
            this.labelFlightScheduleSegmentRule.Size = new System.Drawing.Size(71, 13);
            this.labelFlightScheduleSegmentRule.TabIndex = 4;
            this.labelFlightScheduleSegmentRule.Text = "Flight Schedule Segment Rule:";
            //
            //textBoxFlightScheduleSegmentRule
            //
            this.textBoxFlightScheduleSegmentRule.Location = new System.Drawing.Point(231, 36);
            this.textBoxFlightScheduleSegmentRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightScheduleSegmentRule.Name = "textBoxFlightScheduleSegmentRule";
            this.textBoxFlightScheduleSegmentRule.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightScheduleSegmentRule.TabIndex = 5;
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
            // dataGridViewCrudeFlightScheduleSegmentRuleRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.Name = "dataGridViewCrudeFlightScheduleSegmentRuleRef";
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.Size = new System.Drawing.Size(469, 96);
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.TabIndex = 0;
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.ReadOnly = true;
            this.dataGridViewCrudeFlightScheduleSegmentRuleRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightScheduleSegmentRuleRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightScheduleSegmentRuleRefSearch
            // 
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.Location = new System.Drawing.Point(289, 195);
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.Name = "buttonCrudeFlightScheduleSegmentRuleRefSearch";
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.TabIndex = 2;
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.Text = "&Search";
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentRuleRefSearch.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentRuleRefSearch_Click);
            // 
            // buttonCrudeFlightScheduleSegmentRuleRefAdd
            // 
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.Location = new System.Drawing.Point(189, 195);
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.Name = "buttonCrudeFlightScheduleSegmentRuleRefAdd";
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.TabIndex = 3;
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.Text = "&Add";
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentRuleRefAdd.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentRuleRefAdd_Click);
            // 
            // buttonCrudeFlightScheduleSegmentRuleRefEdit
            // 
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.Location = new System.Drawing.Point(89, 195);
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.Name = "buttonCrudeFlightScheduleSegmentRuleRefEdit";
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.TabIndex = 4;
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.Text = "&Edit";
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentRuleRefEdit.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentRuleRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 223);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentRuleRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentRuleRefAdd);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentRuleRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightScheduleSegmentRuleRef);
            this.Name = "CrudeFlightScheduleSegmentRuleRefSearch";
            this.Text = "Flight Schedule Segment Rule Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleSegmentRuleRef)).EndInit();
            this.Controls.Add(this.labelFlightScheduleSegmentRuleName);
            this.Controls.Add(this.textBoxFlightScheduleSegmentRuleName);
            this.Controls.Add(this.labelFlightScheduleSegmentRule);
            this.Controls.Add(this.textBoxFlightScheduleSegmentRule);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
