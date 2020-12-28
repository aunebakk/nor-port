namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialFareTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFareTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFareTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFareTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialFareTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialFareTypeName;
        
        private System.Windows.Forms.Label labelFinancialFareTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialFareType;
        
        private System.Windows.Forms.Label labelFinancialFareType;
        
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
            this.buttonCrudeFinancialFareTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFareTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFareTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialFareTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialFareTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialFareTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialFareType = new System.Windows.Forms.Label();
            this.textBoxFinancialFareType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFareTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialFareTypeName
            //
            this.labelFinancialFareTypeName.AutoSize = true;
            this.labelFinancialFareTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialFareTypeName.Name = "labelFinancialFareTypeName";
            this.labelFinancialFareTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFareTypeName.TabIndex = 2;
            this.labelFinancialFareTypeName.Text = "Financial Fare Type Name:";
            //
            //textBoxFinancialFareTypeName
            //
            this.textBoxFinancialFareTypeName.Location = new System.Drawing.Point(168, 13);
            this.textBoxFinancialFareTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFareTypeName.Name = "textBoxFinancialFareTypeName";
            this.textBoxFinancialFareTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFareTypeName.TabIndex = 3;
            //
            // labelFinancialFareType
            //
            this.labelFinancialFareType.AutoSize = true;
            this.labelFinancialFareType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialFareType.Name = "labelFinancialFareType";
            this.labelFinancialFareType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFareType.TabIndex = 4;
            this.labelFinancialFareType.Text = "Financial Fare Type:";
            //
            //textBoxFinancialFareType
            //
            this.textBoxFinancialFareType.Location = new System.Drawing.Point(168, 36);
            this.textBoxFinancialFareType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFareType.Name = "textBoxFinancialFareType";
            this.textBoxFinancialFareType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFareType.TabIndex = 5;
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
            // dataGridViewCrudeFinancialFareTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialFareTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialFareTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialFareTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialFareTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialFareTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialFareTypeRef.Name = "dataGridViewCrudeFinancialFareTypeRef";
            this.dataGridViewCrudeFinancialFareTypeRef.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeFinancialFareTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialFareTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialFareTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialFareTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialFareTypeRefSearch
            // 
            this.buttonCrudeFinancialFareTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFareTypeRefSearch.Location = new System.Drawing.Point(226, 195);
            this.buttonCrudeFinancialFareTypeRefSearch.Name = "buttonCrudeFinancialFareTypeRefSearch";
            this.buttonCrudeFinancialFareTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFareTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialFareTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialFareTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFareTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialFareTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialFareTypeRefAdd
            // 
            this.buttonCrudeFinancialFareTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFareTypeRefAdd.Location = new System.Drawing.Point(126, 195);
            this.buttonCrudeFinancialFareTypeRefAdd.Name = "buttonCrudeFinancialFareTypeRefAdd";
            this.buttonCrudeFinancialFareTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFareTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialFareTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialFareTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFareTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialFareTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialFareTypeRefEdit
            // 
            this.buttonCrudeFinancialFareTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFareTypeRefEdit.Location = new System.Drawing.Point(26, 195);
            this.buttonCrudeFinancialFareTypeRefEdit.Name = "buttonCrudeFinancialFareTypeRefEdit";
            this.buttonCrudeFinancialFareTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFareTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialFareTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialFareTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFareTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialFareTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.buttonCrudeFinancialFareTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialFareTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialFareTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialFareTypeRef);
            this.Name = "CrudeFinancialFareTypeRefSearch";
            this.Text = "Financial Fare Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFareTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialFareTypeName);
            this.Controls.Add(this.textBoxFinancialFareTypeName);
            this.Controls.Add(this.labelFinancialFareType);
            this.Controls.Add(this.textBoxFinancialFareType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
