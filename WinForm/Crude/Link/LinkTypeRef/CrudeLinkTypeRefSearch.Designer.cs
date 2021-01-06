namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeLinkTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeLinkTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeLinkTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeLinkTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeLinkTypeRef;
        
        private System.Windows.Forms.TextBox textBoxLinkTypeName;
        
        private System.Windows.Forms.Label labelLinkTypeName;
        
        private System.Windows.Forms.TextBox textBoxLinkType;
        
        private System.Windows.Forms.Label labelLinkType;
        
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
            this.buttonCrudeLinkTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeLinkTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeLinkTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeLinkTypeRef = new System.Windows.Forms.DataGridView();
            this.labelLinkTypeName = new System.Windows.Forms.Label();
            this.textBoxLinkTypeName = new System.Windows.Forms.TextBox();
            this.labelLinkType = new System.Windows.Forms.Label();
            this.textBoxLinkType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLinkTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelLinkTypeName
            //
            this.labelLinkTypeName.AutoSize = true;
            this.labelLinkTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelLinkTypeName.Name = "labelLinkTypeName";
            this.labelLinkTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelLinkTypeName.TabIndex = 2;
            this.labelLinkTypeName.Text = "Link Type Name:";
            //
            //textBoxLinkTypeName
            //
            this.textBoxLinkTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxLinkTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkTypeName.Name = "textBoxLinkTypeName";
            this.textBoxLinkTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkTypeName.TabIndex = 3;
            //
            // labelLinkType
            //
            this.labelLinkType.AutoSize = true;
            this.labelLinkType.Location = new System.Drawing.Point(11, 36);
            this.labelLinkType.Name = "labelLinkType";
            this.labelLinkType.Size = new System.Drawing.Size(71, 13);
            this.labelLinkType.TabIndex = 4;
            this.labelLinkType.Text = "Link Type:";
            //
            //textBoxLinkType
            //
            this.textBoxLinkType.Location = new System.Drawing.Point(140, 36);
            this.textBoxLinkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkType.Name = "textBoxLinkType";
            this.textBoxLinkType.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkType.TabIndex = 5;
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
            // dataGridViewCrudeLinkTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeLinkTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeLinkTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeLinkTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeLinkTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeLinkTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeLinkTypeRef.Name = "dataGridViewCrudeLinkTypeRef";
            this.dataGridViewCrudeLinkTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeLinkTypeRef.TabIndex = 0;
            this.dataGridViewCrudeLinkTypeRef.ReadOnly = true;
            this.dataGridViewCrudeLinkTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeLinkTypeRef_DoubleClick);
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
            // buttonCrudeLinkTypeRefSearch
            // 
            this.buttonCrudeLinkTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLinkTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeLinkTypeRefSearch.Name = "buttonCrudeLinkTypeRefSearch";
            this.buttonCrudeLinkTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLinkTypeRefSearch.TabIndex = 2;
            this.buttonCrudeLinkTypeRefSearch.Text = "&Search";
            this.buttonCrudeLinkTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeLinkTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeLinkTypeRefSearch_Click);
            // 
            // buttonCrudeLinkTypeRefAdd
            // 
            this.buttonCrudeLinkTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLinkTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeLinkTypeRefAdd.Name = "buttonCrudeLinkTypeRefAdd";
            this.buttonCrudeLinkTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLinkTypeRefAdd.TabIndex = 3;
            this.buttonCrudeLinkTypeRefAdd.Text = "&Add";
            this.buttonCrudeLinkTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeLinkTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeLinkTypeRefAdd_Click);
            // 
            // buttonCrudeLinkTypeRefEdit
            // 
            this.buttonCrudeLinkTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLinkTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeLinkTypeRefEdit.Name = "buttonCrudeLinkTypeRefEdit";
            this.buttonCrudeLinkTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLinkTypeRefEdit.TabIndex = 4;
            this.buttonCrudeLinkTypeRefEdit.Text = "&Edit";
            this.buttonCrudeLinkTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeLinkTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeLinkTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeLinkTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeLinkTypeRefAdd);
            this.Controls.Add(this.buttonCrudeLinkTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeLinkTypeRef);
            this.Name = "CrudeLinkTypeRefSearch";
            this.Text = "Link Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLinkTypeRef)).EndInit();
            this.Controls.Add(this.labelLinkTypeName);
            this.Controls.Add(this.textBoxLinkTypeName);
            this.Controls.Add(this.labelLinkType);
            this.Controls.Add(this.textBoxLinkType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
