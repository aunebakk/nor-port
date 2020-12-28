namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleSegmentRuleSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentRuleSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentRuleAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleSegmentRuleEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightScheduleSegmentRule;
        
        private FlightScheduleSegmentRuleRefCombo flightScheduleSegmentRuleRefCombo;
        
        private System.Windows.Forms.Label labelFlightScheduleSegmentRuleRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentRuleAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentRuleEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleSegmentRuleSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightScheduleSegmentRule = new System.Windows.Forms.DataGridView();
            this.labelFlightScheduleSegmentRuleRefCombo = new System.Windows.Forms.Label();
            this.flightScheduleSegmentRuleRefCombo = new FlightScheduleSegmentRuleRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleSegmentRule)).BeginInit();
            this.SuspendLayout();
            //
            // labelFlightScheduleSegmentRuleRefCombo
            //
            this.labelFlightScheduleSegmentRuleRefCombo.AutoSize = true;
            this.labelFlightScheduleSegmentRuleRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFlightScheduleSegmentRuleRefCombo.Name = "labelFlightScheduleSegmentRuleRefCombo";
            this.labelFlightScheduleSegmentRuleRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFlightScheduleSegmentRuleRefCombo.TabIndex = 2;
            this.labelFlightScheduleSegmentRuleRefCombo.Text = "Flight Schedule Segment Rule:";
            //
            //flightScheduleSegmentRuleRefCombo
            //
            this.flightScheduleSegmentRuleRefCombo.Location = new System.Drawing.Point(196, 13);
            this.flightScheduleSegmentRuleRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flightScheduleSegmentRuleRefCombo.Name = "flightScheduleSegmentRuleRefCombo";
            this.flightScheduleSegmentRuleRefCombo.Size = new System.Drawing.Size(250, 20);
            this.flightScheduleSegmentRuleRefCombo.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(196, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            // 
            // dataGridViewCrudeFlightScheduleSegmentRule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightScheduleSegmentRule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightScheduleSegmentRule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightScheduleSegmentRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightScheduleSegmentRule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightScheduleSegmentRule.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFlightScheduleSegmentRule.Name = "dataGridViewCrudeFlightScheduleSegmentRule";
            this.dataGridViewCrudeFlightScheduleSegmentRule.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeFlightScheduleSegmentRule.TabIndex = 0;
            this.dataGridViewCrudeFlightScheduleSegmentRule.ReadOnly = true;
            this.dataGridViewCrudeFlightScheduleSegmentRule.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightScheduleSegmentRule_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightScheduleSegmentRuleSearch
            // 
            this.buttonCrudeFlightScheduleSegmentRuleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentRuleSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeFlightScheduleSegmentRuleSearch.Name = "buttonCrudeFlightScheduleSegmentRuleSearch";
            this.buttonCrudeFlightScheduleSegmentRuleSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentRuleSearch.TabIndex = 2;
            this.buttonCrudeFlightScheduleSegmentRuleSearch.Text = "&Search";
            this.buttonCrudeFlightScheduleSegmentRuleSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentRuleSearch.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentRuleSearch_Click);
            // 
            // buttonCrudeFlightScheduleSegmentRuleAdd
            // 
            this.buttonCrudeFlightScheduleSegmentRuleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentRuleAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeFlightScheduleSegmentRuleAdd.Name = "buttonCrudeFlightScheduleSegmentRuleAdd";
            this.buttonCrudeFlightScheduleSegmentRuleAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentRuleAdd.TabIndex = 3;
            this.buttonCrudeFlightScheduleSegmentRuleAdd.Text = "&Add";
            this.buttonCrudeFlightScheduleSegmentRuleAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentRuleAdd.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentRuleAdd_Click);
            // 
            // buttonCrudeFlightScheduleSegmentRuleEdit
            // 
            this.buttonCrudeFlightScheduleSegmentRuleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleSegmentRuleEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeFlightScheduleSegmentRuleEdit.Name = "buttonCrudeFlightScheduleSegmentRuleEdit";
            this.buttonCrudeFlightScheduleSegmentRuleEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleSegmentRuleEdit.TabIndex = 4;
            this.buttonCrudeFlightScheduleSegmentRuleEdit.Text = "&Edit";
            this.buttonCrudeFlightScheduleSegmentRuleEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleSegmentRuleEdit.Click += new System.EventHandler(this.buttonCrudeFlightScheduleSegmentRuleEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentRuleSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentRuleAdd);
            this.Controls.Add(this.buttonCrudeFlightScheduleSegmentRuleEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightScheduleSegmentRule);
            this.Name = "CrudeFlightScheduleSegmentRuleSearch";
            this.Text = "Flight Schedule Segment Rule Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleSegmentRule)).EndInit();
            this.Controls.Add(this.labelFlightScheduleSegmentRuleRefCombo);
            this.Controls.Add(this.flightScheduleSegmentRuleRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
