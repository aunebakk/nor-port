namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAgencySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAgencySearch;
        
        private System.Windows.Forms.Button buttonCrudeAgencyAdd;
        
        private System.Windows.Forms.Button buttonCrudeAgencyEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAgency;
        
        private System.Windows.Forms.TextBox textBoxAgencyName;
        
        private System.Windows.Forms.Label labelAgencyName;
        
        private System.Windows.Forms.TextBox textBoxAgencyCode;
        
        private System.Windows.Forms.Label labelAgencyCode;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAgencyAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAgencyEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAgencySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAgency = new System.Windows.Forms.DataGridView();
            this.labelAgencyName = new System.Windows.Forms.Label();
            this.textBoxAgencyName = new System.Windows.Forms.TextBox();
            this.labelAgencyCode = new System.Windows.Forms.Label();
            this.textBoxAgencyCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAgency)).BeginInit();
            this.SuspendLayout();
            //
            // labelAgencyName
            //
            this.labelAgencyName.AutoSize = true;
            this.labelAgencyName.Location = new System.Drawing.Point(11, 13);
            this.labelAgencyName.Name = "labelAgencyName";
            this.labelAgencyName.Size = new System.Drawing.Size(71, 13);
            this.labelAgencyName.TabIndex = 2;
            this.labelAgencyName.Text = "Agency Name:";
            //
            //textBoxAgencyName
            //
            this.textBoxAgencyName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAgencyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAgencyName.Name = "textBoxAgencyName";
            this.textBoxAgencyName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAgencyName.TabIndex = 3;
            //
            // labelAgencyCode
            //
            this.labelAgencyCode.AutoSize = true;
            this.labelAgencyCode.Location = new System.Drawing.Point(11, 36);
            this.labelAgencyCode.Name = "labelAgencyCode";
            this.labelAgencyCode.Size = new System.Drawing.Size(71, 13);
            this.labelAgencyCode.TabIndex = 4;
            this.labelAgencyCode.Text = "Agency Code:";
            //
            //textBoxAgencyCode
            //
            this.textBoxAgencyCode.Location = new System.Drawing.Point(140, 36);
            this.textBoxAgencyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAgencyCode.Name = "textBoxAgencyCode";
            this.textBoxAgencyCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAgencyCode.TabIndex = 5;
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
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeAgency
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAgency.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAgency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAgency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAgency.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAgency.Name = "dataGridViewCrudeAgency";
            this.dataGridViewCrudeAgency.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAgency.TabIndex = 0;
            this.dataGridViewCrudeAgency.ReadOnly = true;
            this.dataGridViewCrudeAgency.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAgency_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAgencySearch
            // 
            this.buttonCrudeAgencySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAgencySearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeAgencySearch.Name = "buttonCrudeAgencySearch";
            this.buttonCrudeAgencySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAgencySearch.TabIndex = 2;
            this.buttonCrudeAgencySearch.Text = "&Search";
            this.buttonCrudeAgencySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAgencySearch.Click += new System.EventHandler(this.buttonCrudeAgencySearch_Click);
            // 
            // buttonCrudeAgencyAdd
            // 
            this.buttonCrudeAgencyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAgencyAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeAgencyAdd.Name = "buttonCrudeAgencyAdd";
            this.buttonCrudeAgencyAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAgencyAdd.TabIndex = 3;
            this.buttonCrudeAgencyAdd.Text = "&Add";
            this.buttonCrudeAgencyAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAgencyAdd.Click += new System.EventHandler(this.buttonCrudeAgencyAdd_Click);
            // 
            // buttonCrudeAgencyEdit
            // 
            this.buttonCrudeAgencyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAgencyEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeAgencyEdit.Name = "buttonCrudeAgencyEdit";
            this.buttonCrudeAgencyEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAgencyEdit.TabIndex = 4;
            this.buttonCrudeAgencyEdit.Text = "&Edit";
            this.buttonCrudeAgencyEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAgencyEdit.Click += new System.EventHandler(this.buttonCrudeAgencyEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeAgencySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAgencyAdd);
            this.Controls.Add(this.buttonCrudeAgencyEdit);
            this.Controls.Add(this.dataGridViewCrudeAgency);
            this.Name = "CrudeAgencySearch";
            this.Text = "Agency Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAgency)).EndInit();
            this.Controls.Add(this.labelAgencyName);
            this.Controls.Add(this.textBoxAgencyName);
            this.Controls.Add(this.labelAgencyCode);
            this.Controls.Add(this.textBoxAgencyCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
