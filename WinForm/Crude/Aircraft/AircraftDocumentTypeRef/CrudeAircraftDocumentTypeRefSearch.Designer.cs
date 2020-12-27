namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftDocumentTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftDocumentTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftDocumentTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftDocumentTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftDocumentTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAircraftDocumentTypeName;
        
        private System.Windows.Forms.Label labelAircraftDocumentTypeName;
        
        private System.Windows.Forms.TextBox textBoxAircraftDocumentType;
        
        private System.Windows.Forms.Label labelAircraftDocumentType;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;
        
        private System.Windows.Forms.Label labelSortOrder;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.CheckBox checkBoxActiveFlag;
        
        private System.Windows.Forms.Label labelActiveFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftDocumentTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftDocumentTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftDocumentTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftDocumentTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAircraftDocumentTypeName = new System.Windows.Forms.Label();
            this.textBoxAircraftDocumentTypeName = new System.Windows.Forms.TextBox();
            this.labelAircraftDocumentType = new System.Windows.Forms.Label();
            this.textBoxAircraftDocumentType = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftDocumentTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftDocumentTypeName
            //
            this.labelAircraftDocumentTypeName.AutoSize = true;
            this.labelAircraftDocumentTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftDocumentTypeName.Name = "labelAircraftDocumentTypeName";
            this.labelAircraftDocumentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftDocumentTypeName.TabIndex = 2;
            this.labelAircraftDocumentTypeName.Text = "Aircraft Document Type Name:";
            //
            //textBoxAircraftDocumentTypeName
            //
            this.textBoxAircraftDocumentTypeName.Location = new System.Drawing.Point(189, 13);
            this.textBoxAircraftDocumentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftDocumentTypeName.Name = "textBoxAircraftDocumentTypeName";
            this.textBoxAircraftDocumentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftDocumentTypeName.TabIndex = 3;
            //
            // labelAircraftDocumentType
            //
            this.labelAircraftDocumentType.AutoSize = true;
            this.labelAircraftDocumentType.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftDocumentType.Name = "labelAircraftDocumentType";
            this.labelAircraftDocumentType.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftDocumentType.TabIndex = 4;
            this.labelAircraftDocumentType.Text = "Aircraft Document Type:";
            //
            //textBoxAircraftDocumentType
            //
            this.textBoxAircraftDocumentType.Location = new System.Drawing.Point(189, 36);
            this.textBoxAircraftDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftDocumentType.Name = "textBoxAircraftDocumentType";
            this.textBoxAircraftDocumentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftDocumentType.TabIndex = 5;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 59);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 6;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(189, 59);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 105);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 10;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(189, 105);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 11;
            // 
            // dataGridViewCrudeAircraftDocumentTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftDocumentTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftDocumentTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftDocumentTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftDocumentTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftDocumentTypeRef.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAircraftDocumentTypeRef.Name = "dataGridViewCrudeAircraftDocumentTypeRef";
            this.dataGridViewCrudeAircraftDocumentTypeRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeAircraftDocumentTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAircraftDocumentTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAircraftDocumentTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftDocumentTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftDocumentTypeRefSearch
            // 
            this.buttonCrudeAircraftDocumentTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftDocumentTypeRefSearch.Location = new System.Drawing.Point(247, 241);
            this.buttonCrudeAircraftDocumentTypeRefSearch.Name = "buttonCrudeAircraftDocumentTypeRefSearch";
            this.buttonCrudeAircraftDocumentTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftDocumentTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAircraftDocumentTypeRefSearch.Text = "&Search";
            this.buttonCrudeAircraftDocumentTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftDocumentTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAircraftDocumentTypeRefSearch_Click);
            // 
            // buttonCrudeAircraftDocumentTypeRefAdd
            // 
            this.buttonCrudeAircraftDocumentTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftDocumentTypeRefAdd.Location = new System.Drawing.Point(147, 241);
            this.buttonCrudeAircraftDocumentTypeRefAdd.Name = "buttonCrudeAircraftDocumentTypeRefAdd";
            this.buttonCrudeAircraftDocumentTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftDocumentTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAircraftDocumentTypeRefAdd.Text = "&Add";
            this.buttonCrudeAircraftDocumentTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftDocumentTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAircraftDocumentTypeRefAdd_Click);
            // 
            // buttonCrudeAircraftDocumentTypeRefEdit
            // 
            this.buttonCrudeAircraftDocumentTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftDocumentTypeRefEdit.Location = new System.Drawing.Point(47, 241);
            this.buttonCrudeAircraftDocumentTypeRefEdit.Name = "buttonCrudeAircraftDocumentTypeRefEdit";
            this.buttonCrudeAircraftDocumentTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftDocumentTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAircraftDocumentTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAircraftDocumentTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftDocumentTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAircraftDocumentTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 269);
            this.Controls.Add(this.buttonCrudeAircraftDocumentTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftDocumentTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAircraftDocumentTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftDocumentTypeRef);
            this.Name = "CrudeAircraftDocumentTypeRefSearch";
            this.Text = "Aircraft Document Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftDocumentTypeRef)).EndInit();
            this.Controls.Add(this.labelAircraftDocumentTypeName);
            this.Controls.Add(this.textBoxAircraftDocumentTypeName);
            this.Controls.Add(this.labelAircraftDocumentType);
            this.Controls.Add(this.textBoxAircraftDocumentType);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
