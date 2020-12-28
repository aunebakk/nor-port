namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeExternalSystemSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeExternalSystemSearch;
        
        private System.Windows.Forms.Button buttonCrudeExternalSystemAdd;
        
        private System.Windows.Forms.Button buttonCrudeExternalSystemEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeExternalSystem;
        
        private System.Windows.Forms.TextBox textBoxExternalSystemName;
        
        private System.Windows.Forms.Label labelExternalSystemName;
        
        private System.Windows.Forms.TextBox textBoxExternalSystemCode;
        
        private System.Windows.Forms.Label labelExternalSystemCode;
        
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
            this.buttonCrudeExternalSystemAdd = new System.Windows.Forms.Button();
            this.buttonCrudeExternalSystemEdit = new System.Windows.Forms.Button();
            this.buttonCrudeExternalSystemSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeExternalSystem = new System.Windows.Forms.DataGridView();
            this.labelExternalSystemName = new System.Windows.Forms.Label();
            this.textBoxExternalSystemName = new System.Windows.Forms.TextBox();
            this.labelExternalSystemCode = new System.Windows.Forms.Label();
            this.textBoxExternalSystemCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeExternalSystem)).BeginInit();
            this.SuspendLayout();
            //
            // labelExternalSystemName
            //
            this.labelExternalSystemName.AutoSize = true;
            this.labelExternalSystemName.Location = new System.Drawing.Point(11, 13);
            this.labelExternalSystemName.Name = "labelExternalSystemName";
            this.labelExternalSystemName.Size = new System.Drawing.Size(71, 13);
            this.labelExternalSystemName.TabIndex = 2;
            this.labelExternalSystemName.Text = "External System Name:";
            //
            //textBoxExternalSystemName
            //
            this.textBoxExternalSystemName.Location = new System.Drawing.Point(140, 13);
            this.textBoxExternalSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExternalSystemName.Name = "textBoxExternalSystemName";
            this.textBoxExternalSystemName.Size = new System.Drawing.Size(250, 20);
            this.textBoxExternalSystemName.TabIndex = 3;
            //
            // labelExternalSystemCode
            //
            this.labelExternalSystemCode.AutoSize = true;
            this.labelExternalSystemCode.Location = new System.Drawing.Point(11, 36);
            this.labelExternalSystemCode.Name = "labelExternalSystemCode";
            this.labelExternalSystemCode.Size = new System.Drawing.Size(71, 13);
            this.labelExternalSystemCode.TabIndex = 4;
            this.labelExternalSystemCode.Text = "External System Code:";
            //
            //textBoxExternalSystemCode
            //
            this.textBoxExternalSystemCode.Location = new System.Drawing.Point(140, 36);
            this.textBoxExternalSystemCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExternalSystemCode.Name = "textBoxExternalSystemCode";
            this.textBoxExternalSystemCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxExternalSystemCode.TabIndex = 5;
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
            // dataGridViewCrudeExternalSystem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeExternalSystem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeExternalSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeExternalSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeExternalSystem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeExternalSystem.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeExternalSystem.Name = "dataGridViewCrudeExternalSystem";
            this.dataGridViewCrudeExternalSystem.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeExternalSystem.TabIndex = 0;
            this.dataGridViewCrudeExternalSystem.ReadOnly = true;
            this.dataGridViewCrudeExternalSystem.DoubleClick += new System.EventHandler(this.dataGridViewCrudeExternalSystem_DoubleClick);
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
            // buttonCrudeExternalSystemSearch
            // 
            this.buttonCrudeExternalSystemSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeExternalSystemSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeExternalSystemSearch.Name = "buttonCrudeExternalSystemSearch";
            this.buttonCrudeExternalSystemSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeExternalSystemSearch.TabIndex = 2;
            this.buttonCrudeExternalSystemSearch.Text = "&Search";
            this.buttonCrudeExternalSystemSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeExternalSystemSearch.Click += new System.EventHandler(this.buttonCrudeExternalSystemSearch_Click);
            // 
            // buttonCrudeExternalSystemAdd
            // 
            this.buttonCrudeExternalSystemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeExternalSystemAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeExternalSystemAdd.Name = "buttonCrudeExternalSystemAdd";
            this.buttonCrudeExternalSystemAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeExternalSystemAdd.TabIndex = 3;
            this.buttonCrudeExternalSystemAdd.Text = "&Add";
            this.buttonCrudeExternalSystemAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeExternalSystemAdd.Click += new System.EventHandler(this.buttonCrudeExternalSystemAdd_Click);
            // 
            // buttonCrudeExternalSystemEdit
            // 
            this.buttonCrudeExternalSystemEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeExternalSystemEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeExternalSystemEdit.Name = "buttonCrudeExternalSystemEdit";
            this.buttonCrudeExternalSystemEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeExternalSystemEdit.TabIndex = 4;
            this.buttonCrudeExternalSystemEdit.Text = "&Edit";
            this.buttonCrudeExternalSystemEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeExternalSystemEdit.Click += new System.EventHandler(this.buttonCrudeExternalSystemEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeExternalSystemSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeExternalSystemAdd);
            this.Controls.Add(this.buttonCrudeExternalSystemEdit);
            this.Controls.Add(this.dataGridViewCrudeExternalSystem);
            this.Name = "CrudeExternalSystemSearch";
            this.Text = "External System Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeExternalSystem)).EndInit();
            this.Controls.Add(this.labelExternalSystemName);
            this.Controls.Add(this.textBoxExternalSystemName);
            this.Controls.Add(this.labelExternalSystemCode);
            this.Controls.Add(this.textBoxExternalSystemCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
