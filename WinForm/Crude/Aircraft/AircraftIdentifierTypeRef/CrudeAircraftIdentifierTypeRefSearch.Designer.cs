namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAircraftIdentifierTypeName;
        
        private System.Windows.Forms.Label labelAircraftIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxAircraftIdentifierType;
        
        private System.Windows.Forms.Label labelAircraftIdentifierType;
        
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
            this.buttonCrudeAircraftIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAircraftIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxAircraftIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelAircraftIdentifierType = new System.Windows.Forms.Label();
            this.textBoxAircraftIdentifierType = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftIdentifierTypeName
            //
            this.labelAircraftIdentifierTypeName.AutoSize = true;
            this.labelAircraftIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftIdentifierTypeName.Name = "labelAircraftIdentifierTypeName";
            this.labelAircraftIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftIdentifierTypeName.TabIndex = 2;
            this.labelAircraftIdentifierTypeName.Text = "Aircraft Identifier Type Name:";
            //
            //textBoxAircraftIdentifierTypeName
            //
            this.textBoxAircraftIdentifierTypeName.Location = new System.Drawing.Point(203, 13);
            this.textBoxAircraftIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftIdentifierTypeName.Name = "textBoxAircraftIdentifierTypeName";
            this.textBoxAircraftIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftIdentifierTypeName.TabIndex = 3;
            //
            // labelAircraftIdentifierType
            //
            this.labelAircraftIdentifierType.AutoSize = true;
            this.labelAircraftIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftIdentifierType.Name = "labelAircraftIdentifierType";
            this.labelAircraftIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftIdentifierType.TabIndex = 4;
            this.labelAircraftIdentifierType.Text = "Aircraft Identifier Type:";
            //
            //textBoxAircraftIdentifierType
            //
            this.textBoxAircraftIdentifierType.Location = new System.Drawing.Point(203, 36);
            this.textBoxAircraftIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftIdentifierType.Name = "textBoxAircraftIdentifierType";
            this.textBoxAircraftIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftIdentifierType.TabIndex = 5;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(203, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(203, 82);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(203, 105);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 11;
            // 
            // dataGridViewCrudeAircraftIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftIdentifierTypeRef.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAircraftIdentifierTypeRef.Name = "dataGridViewCrudeAircraftIdentifierTypeRef";
            this.dataGridViewCrudeAircraftIdentifierTypeRef.Size = new System.Drawing.Size(441, 96);
            this.dataGridViewCrudeAircraftIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAircraftIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAircraftIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftIdentifierTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(361, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftIdentifierTypeRefSearch
            // 
            this.buttonCrudeAircraftIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftIdentifierTypeRefSearch.Location = new System.Drawing.Point(261, 241);
            this.buttonCrudeAircraftIdentifierTypeRefSearch.Name = "buttonCrudeAircraftIdentifierTypeRefSearch";
            this.buttonCrudeAircraftIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAircraftIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeAircraftIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAircraftIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeAircraftIdentifierTypeRefAdd
            // 
            this.buttonCrudeAircraftIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftIdentifierTypeRefAdd.Location = new System.Drawing.Point(161, 241);
            this.buttonCrudeAircraftIdentifierTypeRefAdd.Name = "buttonCrudeAircraftIdentifierTypeRefAdd";
            this.buttonCrudeAircraftIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAircraftIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeAircraftIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAircraftIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeAircraftIdentifierTypeRefEdit
            // 
            this.buttonCrudeAircraftIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftIdentifierTypeRefEdit.Location = new System.Drawing.Point(61, 241);
            this.buttonCrudeAircraftIdentifierTypeRefEdit.Name = "buttonCrudeAircraftIdentifierTypeRefEdit";
            this.buttonCrudeAircraftIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAircraftIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAircraftIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAircraftIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 269);
            this.Controls.Add(this.buttonCrudeAircraftIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAircraftIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftIdentifierTypeRef);
            this.Name = "CrudeAircraftIdentifierTypeRefSearch";
            this.Text = "Aircraft Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelAircraftIdentifierTypeName);
            this.Controls.Add(this.textBoxAircraftIdentifierTypeName);
            this.Controls.Add(this.labelAircraftIdentifierType);
            this.Controls.Add(this.textBoxAircraftIdentifierType);
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
