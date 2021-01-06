namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAddressTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAddressTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAddressTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAddressTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAddressTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAddressTypeName;
        
        private System.Windows.Forms.Label labelAddressTypeName;
        
        private System.Windows.Forms.TextBox textBoxAddressType;
        
        private System.Windows.Forms.Label labelAddressType;
        
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
            this.buttonCrudeAddressTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAddressTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAddressTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAddressTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAddressTypeName = new System.Windows.Forms.Label();
            this.textBoxAddressTypeName = new System.Windows.Forms.TextBox();
            this.labelAddressType = new System.Windows.Forms.Label();
            this.textBoxAddressType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAddressTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAddressTypeName
            //
            this.labelAddressTypeName.AutoSize = true;
            this.labelAddressTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAddressTypeName.Name = "labelAddressTypeName";
            this.labelAddressTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAddressTypeName.TabIndex = 2;
            this.labelAddressTypeName.Text = "Address Type Name:";
            //
            //textBoxAddressTypeName
            //
            this.textBoxAddressTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAddressTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressTypeName.Name = "textBoxAddressTypeName";
            this.textBoxAddressTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressTypeName.TabIndex = 3;
            //
            // labelAddressType
            //
            this.labelAddressType.AutoSize = true;
            this.labelAddressType.Location = new System.Drawing.Point(11, 36);
            this.labelAddressType.Name = "labelAddressType";
            this.labelAddressType.Size = new System.Drawing.Size(71, 13);
            this.labelAddressType.TabIndex = 4;
            this.labelAddressType.Text = "Address Type:";
            //
            //textBoxAddressType
            //
            this.textBoxAddressType.Location = new System.Drawing.Point(140, 36);
            this.textBoxAddressType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressType.Name = "textBoxAddressType";
            this.textBoxAddressType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressType.TabIndex = 5;
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
            // dataGridViewCrudeAddressTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAddressTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAddressTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAddressTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAddressTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAddressTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAddressTypeRef.Name = "dataGridViewCrudeAddressTypeRef";
            this.dataGridViewCrudeAddressTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAddressTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAddressTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAddressTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAddressTypeRef_DoubleClick);
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
            // buttonCrudeAddressTypeRefSearch
            // 
            this.buttonCrudeAddressTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAddressTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeAddressTypeRefSearch.Name = "buttonCrudeAddressTypeRefSearch";
            this.buttonCrudeAddressTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAddressTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAddressTypeRefSearch.Text = "&Search";
            this.buttonCrudeAddressTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAddressTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAddressTypeRefSearch_Click);
            // 
            // buttonCrudeAddressTypeRefAdd
            // 
            this.buttonCrudeAddressTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAddressTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeAddressTypeRefAdd.Name = "buttonCrudeAddressTypeRefAdd";
            this.buttonCrudeAddressTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAddressTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAddressTypeRefAdd.Text = "&Add";
            this.buttonCrudeAddressTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAddressTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAddressTypeRefAdd_Click);
            // 
            // buttonCrudeAddressTypeRefEdit
            // 
            this.buttonCrudeAddressTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAddressTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeAddressTypeRefEdit.Name = "buttonCrudeAddressTypeRefEdit";
            this.buttonCrudeAddressTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAddressTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAddressTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAddressTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAddressTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAddressTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeAddressTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAddressTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAddressTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAddressTypeRef);
            this.Name = "CrudeAddressTypeRefSearch";
            this.Text = "Address Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAddressTypeRef)).EndInit();
            this.Controls.Add(this.labelAddressTypeName);
            this.Controls.Add(this.textBoxAddressTypeName);
            this.Controls.Add(this.labelAddressType);
            this.Controls.Add(this.textBoxAddressType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
