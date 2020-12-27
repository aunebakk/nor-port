namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceImageTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceImageTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceImageTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceImageTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceImageTypeRef;
        
        private System.Windows.Forms.TextBox textBoxServiceImageTypeName;
        
        private System.Windows.Forms.Label labelServiceImageTypeName;
        
        private System.Windows.Forms.TextBox textBoxServiceImageType;
        
        private System.Windows.Forms.Label labelServiceImageType;
        
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
            this.buttonCrudeServiceImageTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceImageTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceImageTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceImageTypeRef = new System.Windows.Forms.DataGridView();
            this.labelServiceImageTypeName = new System.Windows.Forms.Label();
            this.textBoxServiceImageTypeName = new System.Windows.Forms.TextBox();
            this.labelServiceImageType = new System.Windows.Forms.Label();
            this.textBoxServiceImageType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceImageTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceImageTypeName
            //
            this.labelServiceImageTypeName.AutoSize = true;
            this.labelServiceImageTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelServiceImageTypeName.Name = "labelServiceImageTypeName";
            this.labelServiceImageTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceImageTypeName.TabIndex = 2;
            this.labelServiceImageTypeName.Text = "Service Image Type Name:";
            //
            //textBoxServiceImageTypeName
            //
            this.textBoxServiceImageTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxServiceImageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceImageTypeName.Name = "textBoxServiceImageTypeName";
            this.textBoxServiceImageTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceImageTypeName.TabIndex = 3;
            //
            // labelServiceImageType
            //
            this.labelServiceImageType.AutoSize = true;
            this.labelServiceImageType.Location = new System.Drawing.Point(11, 36);
            this.labelServiceImageType.Name = "labelServiceImageType";
            this.labelServiceImageType.Size = new System.Drawing.Size(71, 13);
            this.labelServiceImageType.TabIndex = 4;
            this.labelServiceImageType.Text = "Service Image Type:";
            //
            //textBoxServiceImageType
            //
            this.textBoxServiceImageType.Location = new System.Drawing.Point(161, 36);
            this.textBoxServiceImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceImageType.Name = "textBoxServiceImageType";
            this.textBoxServiceImageType.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceImageType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeServiceImageTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceImageTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceImageTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceImageTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceImageTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceImageTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeServiceImageTypeRef.Name = "dataGridViewCrudeServiceImageTypeRef";
            this.dataGridViewCrudeServiceImageTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeServiceImageTypeRef.TabIndex = 0;
            this.dataGridViewCrudeServiceImageTypeRef.ReadOnly = true;
            this.dataGridViewCrudeServiceImageTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceImageTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceImageTypeRefSearch
            // 
            this.buttonCrudeServiceImageTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceImageTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeServiceImageTypeRefSearch.Name = "buttonCrudeServiceImageTypeRefSearch";
            this.buttonCrudeServiceImageTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceImageTypeRefSearch.TabIndex = 2;
            this.buttonCrudeServiceImageTypeRefSearch.Text = "&Search";
            this.buttonCrudeServiceImageTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceImageTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeServiceImageTypeRefSearch_Click);
            // 
            // buttonCrudeServiceImageTypeRefAdd
            // 
            this.buttonCrudeServiceImageTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceImageTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeServiceImageTypeRefAdd.Name = "buttonCrudeServiceImageTypeRefAdd";
            this.buttonCrudeServiceImageTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceImageTypeRefAdd.TabIndex = 3;
            this.buttonCrudeServiceImageTypeRefAdd.Text = "&Add";
            this.buttonCrudeServiceImageTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceImageTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeServiceImageTypeRefAdd_Click);
            // 
            // buttonCrudeServiceImageTypeRefEdit
            // 
            this.buttonCrudeServiceImageTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceImageTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeServiceImageTypeRefEdit.Name = "buttonCrudeServiceImageTypeRefEdit";
            this.buttonCrudeServiceImageTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceImageTypeRefEdit.TabIndex = 4;
            this.buttonCrudeServiceImageTypeRefEdit.Text = "&Edit";
            this.buttonCrudeServiceImageTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceImageTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeServiceImageTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeServiceImageTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceImageTypeRefAdd);
            this.Controls.Add(this.buttonCrudeServiceImageTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceImageTypeRef);
            this.Name = "CrudeServiceImageTypeRefSearch";
            this.Text = "Service Image Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceImageTypeRef)).EndInit();
            this.Controls.Add(this.labelServiceImageTypeName);
            this.Controls.Add(this.textBoxServiceImageTypeName);
            this.Controls.Add(this.labelServiceImageType);
            this.Controls.Add(this.textBoxServiceImageType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
