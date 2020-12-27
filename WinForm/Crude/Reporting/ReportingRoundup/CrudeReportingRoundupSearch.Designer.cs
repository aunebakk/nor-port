namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeReportingRoundupSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeReportingRoundupSearch;
        
        private System.Windows.Forms.Button buttonCrudeReportingRoundupAdd;
        
        private System.Windows.Forms.Button buttonCrudeReportingRoundupEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeReportingRoundup;
        
        private ReportingRoundupTypeRefCombo reportingRoundupTypeRefCombo;
        
        private System.Windows.Forms.Label labelReportingRoundupTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxReportingReferenceCode;
        
        private System.Windows.Forms.Label labelReportingReferenceCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCountNumber;
        
        private System.Windows.Forms.Label labelCountNumber;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        
        private System.Windows.Forms.Label labelDate;
        
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
            this.buttonCrudeReportingRoundupAdd = new System.Windows.Forms.Button();
            this.buttonCrudeReportingRoundupEdit = new System.Windows.Forms.Button();
            this.buttonCrudeReportingRoundupSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeReportingRoundup = new System.Windows.Forms.DataGridView();
            this.labelReportingRoundupTypeRefCombo = new System.Windows.Forms.Label();
            this.reportingRoundupTypeRefCombo = new ReportingRoundupTypeRefCombo();
            this.labelReportingReferenceCode = new System.Windows.Forms.Label();
            this.textBoxReportingReferenceCode = new System.Windows.Forms.TextBox();
            this.labelCountNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxCountNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeReportingRoundup)).BeginInit();
            this.SuspendLayout();
            //
            // labelReportingRoundupTypeRefCombo
            //
            this.labelReportingRoundupTypeRefCombo.AutoSize = true;
            this.labelReportingRoundupTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelReportingRoundupTypeRefCombo.Name = "labelReportingRoundupTypeRefCombo";
            this.labelReportingRoundupTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelReportingRoundupTypeRefCombo.TabIndex = 2;
            this.labelReportingRoundupTypeRefCombo.Text = "Reporting Roundup Type:";
            //
            //reportingRoundupTypeRefCombo
            //
            this.reportingRoundupTypeRefCombo.Location = new System.Drawing.Point(168, 13);
            this.reportingRoundupTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.reportingRoundupTypeRefCombo.Name = "reportingRoundupTypeRefCombo";
            this.reportingRoundupTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.reportingRoundupTypeRefCombo.TabIndex = 3;
            //
            // labelReportingReferenceCode
            //
            this.labelReportingReferenceCode.AutoSize = true;
            this.labelReportingReferenceCode.Location = new System.Drawing.Point(11, 36);
            this.labelReportingReferenceCode.Name = "labelReportingReferenceCode";
            this.labelReportingReferenceCode.Size = new System.Drawing.Size(71, 13);
            this.labelReportingReferenceCode.TabIndex = 4;
            this.labelReportingReferenceCode.Text = "Reporting Reference Code:";
            //
            //textBoxReportingReferenceCode
            //
            this.textBoxReportingReferenceCode.Location = new System.Drawing.Point(168, 36);
            this.textBoxReportingReferenceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportingReferenceCode.Name = "textBoxReportingReferenceCode";
            this.textBoxReportingReferenceCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxReportingReferenceCode.TabIndex = 5;
            //
            // labelCountNumber
            //
            this.labelCountNumber.AutoSize = true;
            this.labelCountNumber.Location = new System.Drawing.Point(11, 59);
            this.labelCountNumber.Name = "labelCountNumber";
            this.labelCountNumber.Size = new System.Drawing.Size(71, 13);
            this.labelCountNumber.TabIndex = 6;
            this.labelCountNumber.Text = "Count Number:";
            //
            //maskedTextBoxCountNumber
            //
            this.maskedTextBoxCountNumber.Location = new System.Drawing.Point(168, 59);
            this.maskedTextBoxCountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCountNumber.Name = "maskedTextBoxCountNumber";
            this.maskedTextBoxCountNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCountNumber.TabIndex = 7;
            //
            // labelDate
            //
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(11, 82);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(71, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date:";
            //
            //dateTimePickerDate
            //
            this.dateTimePickerDate.Location = new System.Drawing.Point(168, 82);
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDate.TabIndex = 9;
            this.dateTimePickerDate.Checked = false;
            this.dateTimePickerDate.ShowCheckBox = true;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(168, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeReportingRoundup
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeReportingRoundup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeReportingRoundup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeReportingRoundup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeReportingRoundup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeReportingRoundup.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeReportingRoundup.Name = "dataGridViewCrudeReportingRoundup";
            this.dataGridViewCrudeReportingRoundup.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeReportingRoundup.TabIndex = 0;
            this.dataGridViewCrudeReportingRoundup.ReadOnly = true;
            this.dataGridViewCrudeReportingRoundup.DoubleClick += new System.EventHandler(this.dataGridViewCrudeReportingRoundup_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeReportingRoundupSearch
            // 
            this.buttonCrudeReportingRoundupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeReportingRoundupSearch.Location = new System.Drawing.Point(226, 264);
            this.buttonCrudeReportingRoundupSearch.Name = "buttonCrudeReportingRoundupSearch";
            this.buttonCrudeReportingRoundupSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeReportingRoundupSearch.TabIndex = 2;
            this.buttonCrudeReportingRoundupSearch.Text = "&Search";
            this.buttonCrudeReportingRoundupSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeReportingRoundupSearch.Click += new System.EventHandler(this.buttonCrudeReportingRoundupSearch_Click);
            // 
            // buttonCrudeReportingRoundupAdd
            // 
            this.buttonCrudeReportingRoundupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeReportingRoundupAdd.Location = new System.Drawing.Point(126, 264);
            this.buttonCrudeReportingRoundupAdd.Name = "buttonCrudeReportingRoundupAdd";
            this.buttonCrudeReportingRoundupAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeReportingRoundupAdd.TabIndex = 3;
            this.buttonCrudeReportingRoundupAdd.Text = "&Add";
            this.buttonCrudeReportingRoundupAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeReportingRoundupAdd.Click += new System.EventHandler(this.buttonCrudeReportingRoundupAdd_Click);
            // 
            // buttonCrudeReportingRoundupEdit
            // 
            this.buttonCrudeReportingRoundupEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeReportingRoundupEdit.Location = new System.Drawing.Point(26, 264);
            this.buttonCrudeReportingRoundupEdit.Name = "buttonCrudeReportingRoundupEdit";
            this.buttonCrudeReportingRoundupEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeReportingRoundupEdit.TabIndex = 4;
            this.buttonCrudeReportingRoundupEdit.Text = "&Edit";
            this.buttonCrudeReportingRoundupEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeReportingRoundupEdit.Click += new System.EventHandler(this.buttonCrudeReportingRoundupEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 292);
            this.Controls.Add(this.buttonCrudeReportingRoundupSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeReportingRoundupAdd);
            this.Controls.Add(this.buttonCrudeReportingRoundupEdit);
            this.Controls.Add(this.dataGridViewCrudeReportingRoundup);
            this.Name = "CrudeReportingRoundupSearch";
            this.Text = "Reporting Roundup Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeReportingRoundup)).EndInit();
            this.Controls.Add(this.labelReportingRoundupTypeRefCombo);
            this.Controls.Add(this.reportingRoundupTypeRefCombo);
            this.Controls.Add(this.labelReportingReferenceCode);
            this.Controls.Add(this.textBoxReportingReferenceCode);
            this.Controls.Add(this.labelCountNumber);
            this.Controls.Add(this.maskedTextBoxCountNumber);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
