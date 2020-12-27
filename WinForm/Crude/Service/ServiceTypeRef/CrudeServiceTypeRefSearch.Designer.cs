namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceTypeRef;
        
        private System.Windows.Forms.TextBox textBoxServiceTypeName;
        
        private System.Windows.Forms.Label labelServiceTypeName;
        
        private System.Windows.Forms.TextBox textBoxServiceType;
        
        private System.Windows.Forms.Label labelServiceType;
        
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
            this.buttonCrudeServiceTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceTypeRef = new System.Windows.Forms.DataGridView();
            this.labelServiceTypeName = new System.Windows.Forms.Label();
            this.textBoxServiceTypeName = new System.Windows.Forms.TextBox();
            this.labelServiceType = new System.Windows.Forms.Label();
            this.textBoxServiceType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceTypeName
            //
            this.labelServiceTypeName.AutoSize = true;
            this.labelServiceTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelServiceTypeName.Name = "labelServiceTypeName";
            this.labelServiceTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceTypeName.TabIndex = 2;
            this.labelServiceTypeName.Text = "Service Type Name:";
            //
            //textBoxServiceTypeName
            //
            this.textBoxServiceTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxServiceTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceTypeName.Name = "textBoxServiceTypeName";
            this.textBoxServiceTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceTypeName.TabIndex = 3;
            //
            // labelServiceType
            //
            this.labelServiceType.AutoSize = true;
            this.labelServiceType.Location = new System.Drawing.Point(11, 36);
            this.labelServiceType.Name = "labelServiceType";
            this.labelServiceType.Size = new System.Drawing.Size(71, 13);
            this.labelServiceType.TabIndex = 4;
            this.labelServiceType.Text = "Service Type:";
            //
            //textBoxServiceType
            //
            this.textBoxServiceType.Location = new System.Drawing.Point(140, 36);
            this.textBoxServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceType.Name = "textBoxServiceType";
            this.textBoxServiceType.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceType.TabIndex = 5;
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
            // dataGridViewCrudeServiceTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeServiceTypeRef.Name = "dataGridViewCrudeServiceTypeRef";
            this.dataGridViewCrudeServiceTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeServiceTypeRef.TabIndex = 0;
            this.dataGridViewCrudeServiceTypeRef.ReadOnly = true;
            this.dataGridViewCrudeServiceTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceTypeRef_DoubleClick);
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
            // buttonCrudeServiceTypeRefSearch
            // 
            this.buttonCrudeServiceTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeServiceTypeRefSearch.Name = "buttonCrudeServiceTypeRefSearch";
            this.buttonCrudeServiceTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceTypeRefSearch.TabIndex = 2;
            this.buttonCrudeServiceTypeRefSearch.Text = "&Search";
            this.buttonCrudeServiceTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeServiceTypeRefSearch_Click);
            // 
            // buttonCrudeServiceTypeRefAdd
            // 
            this.buttonCrudeServiceTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeServiceTypeRefAdd.Name = "buttonCrudeServiceTypeRefAdd";
            this.buttonCrudeServiceTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceTypeRefAdd.TabIndex = 3;
            this.buttonCrudeServiceTypeRefAdd.Text = "&Add";
            this.buttonCrudeServiceTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeServiceTypeRefAdd_Click);
            // 
            // buttonCrudeServiceTypeRefEdit
            // 
            this.buttonCrudeServiceTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeServiceTypeRefEdit.Name = "buttonCrudeServiceTypeRefEdit";
            this.buttonCrudeServiceTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceTypeRefEdit.TabIndex = 4;
            this.buttonCrudeServiceTypeRefEdit.Text = "&Edit";
            this.buttonCrudeServiceTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeServiceTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeServiceTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceTypeRefAdd);
            this.Controls.Add(this.buttonCrudeServiceTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceTypeRef);
            this.Name = "CrudeServiceTypeRefSearch";
            this.Text = "Service Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceTypeRef)).EndInit();
            this.Controls.Add(this.labelServiceTypeName);
            this.Controls.Add(this.textBoxServiceTypeName);
            this.Controls.Add(this.labelServiceType);
            this.Controls.Add(this.textBoxServiceType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
