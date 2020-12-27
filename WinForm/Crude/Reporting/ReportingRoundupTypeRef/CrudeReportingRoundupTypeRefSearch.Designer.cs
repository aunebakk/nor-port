namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeReportingRoundupTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeReportingRoundupTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeReportingRoundupTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeReportingRoundupTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeReportingRoundupTypeRef;
        
        private System.Windows.Forms.TextBox textBoxReportingRoundupTypeName;
        
        private System.Windows.Forms.Label labelReportingRoundupTypeName;
        
        private System.Windows.Forms.TextBox textBoxReportingRoundupType;
        
        private System.Windows.Forms.Label labelReportingRoundupType;
        
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
            this.buttonCrudeReportingRoundupTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeReportingRoundupTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeReportingRoundupTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeReportingRoundupTypeRef = new System.Windows.Forms.DataGridView();
            this.labelReportingRoundupTypeName = new System.Windows.Forms.Label();
            this.textBoxReportingRoundupTypeName = new System.Windows.Forms.TextBox();
            this.labelReportingRoundupType = new System.Windows.Forms.Label();
            this.textBoxReportingRoundupType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeReportingRoundupTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelReportingRoundupTypeName
            //
            this.labelReportingRoundupTypeName.AutoSize = true;
            this.labelReportingRoundupTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelReportingRoundupTypeName.Name = "labelReportingRoundupTypeName";
            this.labelReportingRoundupTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelReportingRoundupTypeName.TabIndex = 2;
            this.labelReportingRoundupTypeName.Text = "Reporting Roundup Type Name:";
            //
            //textBoxReportingRoundupTypeName
            //
            this.textBoxReportingRoundupTypeName.Location = new System.Drawing.Point(189, 13);
            this.textBoxReportingRoundupTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportingRoundupTypeName.Name = "textBoxReportingRoundupTypeName";
            this.textBoxReportingRoundupTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxReportingRoundupTypeName.TabIndex = 3;
            //
            // labelReportingRoundupType
            //
            this.labelReportingRoundupType.AutoSize = true;
            this.labelReportingRoundupType.Location = new System.Drawing.Point(11, 36);
            this.labelReportingRoundupType.Name = "labelReportingRoundupType";
            this.labelReportingRoundupType.Size = new System.Drawing.Size(71, 13);
            this.labelReportingRoundupType.TabIndex = 4;
            this.labelReportingRoundupType.Text = "Reporting Roundup Type:";
            //
            //textBoxReportingRoundupType
            //
            this.textBoxReportingRoundupType.Location = new System.Drawing.Point(189, 36);
            this.textBoxReportingRoundupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportingRoundupType.Name = "textBoxReportingRoundupType";
            this.textBoxReportingRoundupType.Size = new System.Drawing.Size(250, 20);
            this.textBoxReportingRoundupType.TabIndex = 5;
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
            // dataGridViewCrudeReportingRoundupTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeReportingRoundupTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeReportingRoundupTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeReportingRoundupTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeReportingRoundupTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeReportingRoundupTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeReportingRoundupTypeRef.Name = "dataGridViewCrudeReportingRoundupTypeRef";
            this.dataGridViewCrudeReportingRoundupTypeRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeReportingRoundupTypeRef.TabIndex = 0;
            this.dataGridViewCrudeReportingRoundupTypeRef.ReadOnly = true;
            this.dataGridViewCrudeReportingRoundupTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeReportingRoundupTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeReportingRoundupTypeRefSearch
            // 
            this.buttonCrudeReportingRoundupTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeReportingRoundupTypeRefSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeReportingRoundupTypeRefSearch.Name = "buttonCrudeReportingRoundupTypeRefSearch";
            this.buttonCrudeReportingRoundupTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeReportingRoundupTypeRefSearch.TabIndex = 2;
            this.buttonCrudeReportingRoundupTypeRefSearch.Text = "&Search";
            this.buttonCrudeReportingRoundupTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeReportingRoundupTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeReportingRoundupTypeRefSearch_Click);
            // 
            // buttonCrudeReportingRoundupTypeRefAdd
            // 
            this.buttonCrudeReportingRoundupTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeReportingRoundupTypeRefAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeReportingRoundupTypeRefAdd.Name = "buttonCrudeReportingRoundupTypeRefAdd";
            this.buttonCrudeReportingRoundupTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeReportingRoundupTypeRefAdd.TabIndex = 3;
            this.buttonCrudeReportingRoundupTypeRefAdd.Text = "&Add";
            this.buttonCrudeReportingRoundupTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeReportingRoundupTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeReportingRoundupTypeRefAdd_Click);
            // 
            // buttonCrudeReportingRoundupTypeRefEdit
            // 
            this.buttonCrudeReportingRoundupTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeReportingRoundupTypeRefEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeReportingRoundupTypeRefEdit.Name = "buttonCrudeReportingRoundupTypeRefEdit";
            this.buttonCrudeReportingRoundupTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeReportingRoundupTypeRefEdit.TabIndex = 4;
            this.buttonCrudeReportingRoundupTypeRefEdit.Text = "&Edit";
            this.buttonCrudeReportingRoundupTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeReportingRoundupTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeReportingRoundupTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeReportingRoundupTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeReportingRoundupTypeRefAdd);
            this.Controls.Add(this.buttonCrudeReportingRoundupTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeReportingRoundupTypeRef);
            this.Name = "CrudeReportingRoundupTypeRefSearch";
            this.Text = "Reporting Roundup Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeReportingRoundupTypeRef)).EndInit();
            this.Controls.Add(this.labelReportingRoundupTypeName);
            this.Controls.Add(this.textBoxReportingRoundupTypeName);
            this.Controls.Add(this.labelReportingRoundupType);
            this.Controls.Add(this.textBoxReportingRoundupType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
