namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftConfigurationRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftConfigurationRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftConfigurationRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftConfigurationRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftConfigurationRef;
        
        private System.Windows.Forms.TextBox textBoxAircraftConfigurationName;
        
        private System.Windows.Forms.Label labelAircraftConfigurationName;
        
        private System.Windows.Forms.TextBox textBoxAircraftConfiguration;
        
        private System.Windows.Forms.Label labelAircraftConfiguration;
        
        private System.Windows.Forms.TextBox textBoxDescription;
        
        private System.Windows.Forms.Label labelDescription;
        
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
            this.buttonCrudeAircraftConfigurationRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftConfigurationRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftConfigurationRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftConfigurationRef = new System.Windows.Forms.DataGridView();
            this.labelAircraftConfigurationName = new System.Windows.Forms.Label();
            this.textBoxAircraftConfigurationName = new System.Windows.Forms.TextBox();
            this.labelAircraftConfiguration = new System.Windows.Forms.Label();
            this.textBoxAircraftConfiguration = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftConfigurationRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftConfigurationName
            //
            this.labelAircraftConfigurationName.AutoSize = true;
            this.labelAircraftConfigurationName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftConfigurationName.Name = "labelAircraftConfigurationName";
            this.labelAircraftConfigurationName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftConfigurationName.TabIndex = 2;
            this.labelAircraftConfigurationName.Text = "Aircraft Configuration Name:";
            //
            //textBoxAircraftConfigurationName
            //
            this.textBoxAircraftConfigurationName.Location = new System.Drawing.Point(189, 13);
            this.textBoxAircraftConfigurationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftConfigurationName.Name = "textBoxAircraftConfigurationName";
            this.textBoxAircraftConfigurationName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftConfigurationName.TabIndex = 3;
            //
            // labelAircraftConfiguration
            //
            this.labelAircraftConfiguration.AutoSize = true;
            this.labelAircraftConfiguration.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftConfiguration.Name = "labelAircraftConfiguration";
            this.labelAircraftConfiguration.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftConfiguration.TabIndex = 4;
            this.labelAircraftConfiguration.Text = "Aircraft Configuration:";
            //
            //textBoxAircraftConfiguration
            //
            this.textBoxAircraftConfiguration.Location = new System.Drawing.Point(189, 36);
            this.textBoxAircraftConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftConfiguration.Name = "textBoxAircraftConfiguration";
            this.textBoxAircraftConfiguration.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftConfiguration.TabIndex = 5;
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
            this.textBoxDescription.Location = new System.Drawing.Point(189, 59);
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDescription.TabIndex = 7;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 82);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(189, 82);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 128);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 12;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(189, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeAircraftConfigurationRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftConfigurationRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftConfigurationRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftConfigurationRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftConfigurationRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftConfigurationRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeAircraftConfigurationRef.Name = "dataGridViewCrudeAircraftConfigurationRef";
            this.dataGridViewCrudeAircraftConfigurationRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeAircraftConfigurationRef.TabIndex = 0;
            this.dataGridViewCrudeAircraftConfigurationRef.ReadOnly = true;
            this.dataGridViewCrudeAircraftConfigurationRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftConfigurationRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftConfigurationRefSearch
            // 
            this.buttonCrudeAircraftConfigurationRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftConfigurationRefSearch.Location = new System.Drawing.Point(247, 264);
            this.buttonCrudeAircraftConfigurationRefSearch.Name = "buttonCrudeAircraftConfigurationRefSearch";
            this.buttonCrudeAircraftConfigurationRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftConfigurationRefSearch.TabIndex = 2;
            this.buttonCrudeAircraftConfigurationRefSearch.Text = "&Search";
            this.buttonCrudeAircraftConfigurationRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftConfigurationRefSearch.Click += new System.EventHandler(this.buttonCrudeAircraftConfigurationRefSearch_Click);
            // 
            // buttonCrudeAircraftConfigurationRefAdd
            // 
            this.buttonCrudeAircraftConfigurationRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftConfigurationRefAdd.Location = new System.Drawing.Point(147, 264);
            this.buttonCrudeAircraftConfigurationRefAdd.Name = "buttonCrudeAircraftConfigurationRefAdd";
            this.buttonCrudeAircraftConfigurationRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftConfigurationRefAdd.TabIndex = 3;
            this.buttonCrudeAircraftConfigurationRefAdd.Text = "&Add";
            this.buttonCrudeAircraftConfigurationRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftConfigurationRefAdd.Click += new System.EventHandler(this.buttonCrudeAircraftConfigurationRefAdd_Click);
            // 
            // buttonCrudeAircraftConfigurationRefEdit
            // 
            this.buttonCrudeAircraftConfigurationRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftConfigurationRefEdit.Location = new System.Drawing.Point(47, 264);
            this.buttonCrudeAircraftConfigurationRefEdit.Name = "buttonCrudeAircraftConfigurationRefEdit";
            this.buttonCrudeAircraftConfigurationRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftConfigurationRefEdit.TabIndex = 4;
            this.buttonCrudeAircraftConfigurationRefEdit.Text = "&Edit";
            this.buttonCrudeAircraftConfigurationRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftConfigurationRefEdit.Click += new System.EventHandler(this.buttonCrudeAircraftConfigurationRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 292);
            this.Controls.Add(this.buttonCrudeAircraftConfigurationRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftConfigurationRefAdd);
            this.Controls.Add(this.buttonCrudeAircraftConfigurationRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftConfigurationRef);
            this.Name = "CrudeAircraftConfigurationRefSearch";
            this.Text = "Aircraft Configuration Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftConfigurationRef)).EndInit();
            this.Controls.Add(this.labelAircraftConfigurationName);
            this.Controls.Add(this.textBoxAircraftConfigurationName);
            this.Controls.Add(this.labelAircraftConfiguration);
            this.Controls.Add(this.textBoxAircraftConfiguration);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
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
