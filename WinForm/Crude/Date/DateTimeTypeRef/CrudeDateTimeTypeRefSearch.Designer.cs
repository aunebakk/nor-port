namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeDateTimeTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDateTimeTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDateTimeTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDateTimeTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDateTimeTypeRef;
        
        private System.Windows.Forms.TextBox textBoxDateTimeTypeName;
        
        private System.Windows.Forms.Label labelDateTimeTypeName;
        
        private System.Windows.Forms.TextBox textBoxDateTimeType;
        
        private System.Windows.Forms.Label labelDateTimeType;
        
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
            this.buttonCrudeDateTimeTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDateTimeTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDateTimeTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDateTimeTypeRef = new System.Windows.Forms.DataGridView();
            this.labelDateTimeTypeName = new System.Windows.Forms.Label();
            this.textBoxDateTimeTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTimeType = new System.Windows.Forms.Label();
            this.textBoxDateTimeType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDateTimeTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateTimeTypeName
            //
            this.labelDateTimeTypeName.AutoSize = true;
            this.labelDateTimeTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelDateTimeTypeName.Name = "labelDateTimeTypeName";
            this.labelDateTimeTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDateTimeTypeName.TabIndex = 2;
            this.labelDateTimeTypeName.Text = "Date Time Type Name:";
            //
            //textBoxDateTimeTypeName
            //
            this.textBoxDateTimeTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxDateTimeTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDateTimeTypeName.Name = "textBoxDateTimeTypeName";
            this.textBoxDateTimeTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDateTimeTypeName.TabIndex = 3;
            //
            // labelDateTimeType
            //
            this.labelDateTimeType.AutoSize = true;
            this.labelDateTimeType.Location = new System.Drawing.Point(11, 36);
            this.labelDateTimeType.Name = "labelDateTimeType";
            this.labelDateTimeType.Size = new System.Drawing.Size(71, 13);
            this.labelDateTimeType.TabIndex = 4;
            this.labelDateTimeType.Text = "Date Time Type:";
            //
            //textBoxDateTimeType
            //
            this.textBoxDateTimeType.Location = new System.Drawing.Point(140, 36);
            this.textBoxDateTimeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDateTimeType.Name = "textBoxDateTimeType";
            this.textBoxDateTimeType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDateTimeType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeDateTimeTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDateTimeTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDateTimeTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDateTimeTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDateTimeTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDateTimeTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDateTimeTypeRef.Name = "dataGridViewCrudeDateTimeTypeRef";
            this.dataGridViewCrudeDateTimeTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDateTimeTypeRef.TabIndex = 0;
            this.dataGridViewCrudeDateTimeTypeRef.ReadOnly = true;
            this.dataGridViewCrudeDateTimeTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDateTimeTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDateTimeTypeRefSearch
            // 
            this.buttonCrudeDateTimeTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDateTimeTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeDateTimeTypeRefSearch.Name = "buttonCrudeDateTimeTypeRefSearch";
            this.buttonCrudeDateTimeTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDateTimeTypeRefSearch.TabIndex = 2;
            this.buttonCrudeDateTimeTypeRefSearch.Text = "&Search";
            this.buttonCrudeDateTimeTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDateTimeTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeDateTimeTypeRefSearch_Click);
            // 
            // buttonCrudeDateTimeTypeRefAdd
            // 
            this.buttonCrudeDateTimeTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDateTimeTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeDateTimeTypeRefAdd.Name = "buttonCrudeDateTimeTypeRefAdd";
            this.buttonCrudeDateTimeTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDateTimeTypeRefAdd.TabIndex = 3;
            this.buttonCrudeDateTimeTypeRefAdd.Text = "&Add";
            this.buttonCrudeDateTimeTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDateTimeTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeDateTimeTypeRefAdd_Click);
            // 
            // buttonCrudeDateTimeTypeRefEdit
            // 
            this.buttonCrudeDateTimeTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDateTimeTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeDateTimeTypeRefEdit.Name = "buttonCrudeDateTimeTypeRefEdit";
            this.buttonCrudeDateTimeTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDateTimeTypeRefEdit.TabIndex = 4;
            this.buttonCrudeDateTimeTypeRefEdit.Text = "&Edit";
            this.buttonCrudeDateTimeTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDateTimeTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeDateTimeTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeDateTimeTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDateTimeTypeRefAdd);
            this.Controls.Add(this.buttonCrudeDateTimeTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDateTimeTypeRef);
            this.Name = "CrudeDateTimeTypeRefSearch";
            this.Text = "Date Time Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDateTimeTypeRef)).EndInit();
            this.Controls.Add(this.labelDateTimeTypeName);
            this.Controls.Add(this.textBoxDateTimeTypeName);
            this.Controls.Add(this.labelDateTimeType);
            this.Controls.Add(this.textBoxDateTimeType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
