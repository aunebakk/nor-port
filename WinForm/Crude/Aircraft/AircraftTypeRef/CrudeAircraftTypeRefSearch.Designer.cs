namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAircraftTypeName;
        
        private System.Windows.Forms.Label labelAircraftTypeName;
        
        private System.Windows.Forms.TextBox textBoxAircraftType;
        
        private System.Windows.Forms.Label labelAircraftType;
        
        private System.Windows.Forms.TextBox textBoxDescription;
        
        private System.Windows.Forms.Label labelDescription;
        
        private System.Windows.Forms.PictureBox pictureBoxAircraftFamilyImage;
        
        private System.Windows.Forms.Label labelAircraftFamilyImage;
        
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
            this.buttonCrudeAircraftTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAircraftTypeName = new System.Windows.Forms.Label();
            this.textBoxAircraftTypeName = new System.Windows.Forms.TextBox();
            this.labelAircraftType = new System.Windows.Forms.Label();
            this.textBoxAircraftType = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelAircraftFamilyImage = new System.Windows.Forms.Label();
            this.pictureBoxAircraftFamilyImage = new System.Windows.Forms.PictureBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftTypeName
            //
            this.labelAircraftTypeName.AutoSize = true;
            this.labelAircraftTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftTypeName.Name = "labelAircraftTypeName";
            this.labelAircraftTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftTypeName.TabIndex = 2;
            this.labelAircraftTypeName.Text = "Aircraft Type Name:";
            //
            //textBoxAircraftTypeName
            //
            this.textBoxAircraftTypeName.Location = new System.Drawing.Point(147, 13);
            this.textBoxAircraftTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftTypeName.Name = "textBoxAircraftTypeName";
            this.textBoxAircraftTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftTypeName.TabIndex = 3;
            //
            // labelAircraftType
            //
            this.labelAircraftType.AutoSize = true;
            this.labelAircraftType.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftType.Name = "labelAircraftType";
            this.labelAircraftType.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftType.TabIndex = 4;
            this.labelAircraftType.Text = "Aircraft Type:";
            //
            //textBoxAircraftType
            //
            this.textBoxAircraftType.Location = new System.Drawing.Point(147, 36);
            this.textBoxAircraftType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftType.Name = "textBoxAircraftType";
            this.textBoxAircraftType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftType.TabIndex = 5;
            //
            // labelDescription
            //
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 59);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(71, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description:";
            //
            //textBoxDescription
            //
            this.textBoxDescription.Location = new System.Drawing.Point(147, 59);
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDescription.TabIndex = 7;
            //
            // labelAircraftFamilyImage
            //
            this.labelAircraftFamilyImage.AutoSize = true;
            this.labelAircraftFamilyImage.Location = new System.Drawing.Point(11, 82);
            this.labelAircraftFamilyImage.Name = "labelAircraftFamilyImage";
            this.labelAircraftFamilyImage.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftFamilyImage.TabIndex = 8;
            this.labelAircraftFamilyImage.Text = "Aircraft Family Image:";
            //
            //pictureBoxAircraftFamilyImage
            //
            this.pictureBoxAircraftFamilyImage.Location = new System.Drawing.Point(147, 82);
            this.pictureBoxAircraftFamilyImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAircraftFamilyImage.Name = "pictureBoxAircraftFamilyImage";
            this.pictureBoxAircraftFamilyImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxAircraftFamilyImage.TabIndex = 9;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 105);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 10;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(147, 105);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 151);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 14;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(147, 151);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 15;
            // 
            // dataGridViewCrudeAircraftTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftTypeRef.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeAircraftTypeRef.Name = "dataGridViewCrudeAircraftTypeRef";
            this.dataGridViewCrudeAircraftTypeRef.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeAircraftTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAircraftTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAircraftTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftTypeRefSearch
            // 
            this.buttonCrudeAircraftTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftTypeRefSearch.Location = new System.Drawing.Point(205, 287);
            this.buttonCrudeAircraftTypeRefSearch.Name = "buttonCrudeAircraftTypeRefSearch";
            this.buttonCrudeAircraftTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAircraftTypeRefSearch.Text = "&Search";
            this.buttonCrudeAircraftTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAircraftTypeRefSearch_Click);
            // 
            // buttonCrudeAircraftTypeRefAdd
            // 
            this.buttonCrudeAircraftTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftTypeRefAdd.Location = new System.Drawing.Point(105, 287);
            this.buttonCrudeAircraftTypeRefAdd.Name = "buttonCrudeAircraftTypeRefAdd";
            this.buttonCrudeAircraftTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAircraftTypeRefAdd.Text = "&Add";
            this.buttonCrudeAircraftTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAircraftTypeRefAdd_Click);
            // 
            // buttonCrudeAircraftTypeRefEdit
            // 
            this.buttonCrudeAircraftTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftTypeRefEdit.Location = new System.Drawing.Point(5, 287);
            this.buttonCrudeAircraftTypeRefEdit.Name = "buttonCrudeAircraftTypeRefEdit";
            this.buttonCrudeAircraftTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAircraftTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAircraftTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAircraftTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 315);
            this.Controls.Add(this.buttonCrudeAircraftTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAircraftTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftTypeRef);
            this.Name = "CrudeAircraftTypeRefSearch";
            this.Text = "Aircraft Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftTypeRef)).EndInit();
            this.Controls.Add(this.labelAircraftTypeName);
            this.Controls.Add(this.textBoxAircraftTypeName);
            this.Controls.Add(this.labelAircraftType);
            this.Controls.Add(this.textBoxAircraftType);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelAircraftFamilyImage);
            this.Controls.Add(this.pictureBoxAircraftFamilyImage);
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
