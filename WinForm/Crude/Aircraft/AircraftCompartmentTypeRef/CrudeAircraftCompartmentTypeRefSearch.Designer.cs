namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftCompartmentTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftCompartmentTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftCompartmentTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftCompartmentTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftCompartmentTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAircraftCompartmentTypeName;
        
        private System.Windows.Forms.Label labelAircraftCompartmentTypeName;
        
        private System.Windows.Forms.TextBox textBoxAircraftCompartmentType;
        
        private System.Windows.Forms.Label labelAircraftCompartmentType;
        
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
            this.buttonCrudeAircraftCompartmentTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftCompartmentTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftCompartmentTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftCompartmentTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAircraftCompartmentTypeName = new System.Windows.Forms.Label();
            this.textBoxAircraftCompartmentTypeName = new System.Windows.Forms.TextBox();
            this.labelAircraftCompartmentType = new System.Windows.Forms.Label();
            this.textBoxAircraftCompartmentType = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftCompartmentTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftCompartmentTypeName
            //
            this.labelAircraftCompartmentTypeName.AutoSize = true;
            this.labelAircraftCompartmentTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftCompartmentTypeName.Name = "labelAircraftCompartmentTypeName";
            this.labelAircraftCompartmentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentTypeName.TabIndex = 2;
            this.labelAircraftCompartmentTypeName.Text = "Aircraft Compartment Type Name:";
            //
            //textBoxAircraftCompartmentTypeName
            //
            this.textBoxAircraftCompartmentTypeName.Location = new System.Drawing.Point(210, 13);
            this.textBoxAircraftCompartmentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftCompartmentTypeName.Name = "textBoxAircraftCompartmentTypeName";
            this.textBoxAircraftCompartmentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftCompartmentTypeName.TabIndex = 3;
            //
            // labelAircraftCompartmentType
            //
            this.labelAircraftCompartmentType.AutoSize = true;
            this.labelAircraftCompartmentType.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftCompartmentType.Name = "labelAircraftCompartmentType";
            this.labelAircraftCompartmentType.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentType.TabIndex = 4;
            this.labelAircraftCompartmentType.Text = "Aircraft Compartment Type:";
            //
            //textBoxAircraftCompartmentType
            //
            this.textBoxAircraftCompartmentType.Location = new System.Drawing.Point(210, 36);
            this.textBoxAircraftCompartmentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftCompartmentType.Name = "textBoxAircraftCompartmentType";
            this.textBoxAircraftCompartmentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftCompartmentType.TabIndex = 5;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(210, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 82);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(210, 105);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 11;
            // 
            // dataGridViewCrudeAircraftCompartmentTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftCompartmentTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftCompartmentTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftCompartmentTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftCompartmentTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftCompartmentTypeRef.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAircraftCompartmentTypeRef.Name = "dataGridViewCrudeAircraftCompartmentTypeRef";
            this.dataGridViewCrudeAircraftCompartmentTypeRef.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeAircraftCompartmentTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAircraftCompartmentTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAircraftCompartmentTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftCompartmentTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftCompartmentTypeRefSearch
            // 
            this.buttonCrudeAircraftCompartmentTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftCompartmentTypeRefSearch.Location = new System.Drawing.Point(268, 241);
            this.buttonCrudeAircraftCompartmentTypeRefSearch.Name = "buttonCrudeAircraftCompartmentTypeRefSearch";
            this.buttonCrudeAircraftCompartmentTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftCompartmentTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAircraftCompartmentTypeRefSearch.Text = "&Search";
            this.buttonCrudeAircraftCompartmentTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftCompartmentTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAircraftCompartmentTypeRefSearch_Click);
            // 
            // buttonCrudeAircraftCompartmentTypeRefAdd
            // 
            this.buttonCrudeAircraftCompartmentTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftCompartmentTypeRefAdd.Location = new System.Drawing.Point(168, 241);
            this.buttonCrudeAircraftCompartmentTypeRefAdd.Name = "buttonCrudeAircraftCompartmentTypeRefAdd";
            this.buttonCrudeAircraftCompartmentTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftCompartmentTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAircraftCompartmentTypeRefAdd.Text = "&Add";
            this.buttonCrudeAircraftCompartmentTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftCompartmentTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAircraftCompartmentTypeRefAdd_Click);
            // 
            // buttonCrudeAircraftCompartmentTypeRefEdit
            // 
            this.buttonCrudeAircraftCompartmentTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftCompartmentTypeRefEdit.Location = new System.Drawing.Point(68, 241);
            this.buttonCrudeAircraftCompartmentTypeRefEdit.Name = "buttonCrudeAircraftCompartmentTypeRefEdit";
            this.buttonCrudeAircraftCompartmentTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftCompartmentTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAircraftCompartmentTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAircraftCompartmentTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftCompartmentTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAircraftCompartmentTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 269);
            this.Controls.Add(this.buttonCrudeAircraftCompartmentTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftCompartmentTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAircraftCompartmentTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftCompartmentTypeRef);
            this.Name = "CrudeAircraftCompartmentTypeRefSearch";
            this.Text = "Aircraft Compartment Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftCompartmentTypeRef)).EndInit();
            this.Controls.Add(this.labelAircraftCompartmentTypeName);
            this.Controls.Add(this.textBoxAircraftCompartmentTypeName);
            this.Controls.Add(this.labelAircraftCompartmentType);
            this.Controls.Add(this.textBoxAircraftCompartmentType);
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
