namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceSpecialServiceRequestGroupRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestGroupRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestGroupRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestGroupRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceSpecialServiceRequestGroupRef;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestGroupName;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestGroupName;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestGroup;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestGroup;
        
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
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef = new System.Windows.Forms.DataGridView();
            this.labelServiceSpecialServiceRequestGroupName = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestGroupName = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestGroup = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestGroup = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceSpecialServiceRequestGroupName
            //
            this.labelServiceSpecialServiceRequestGroupName.AutoSize = true;
            this.labelServiceSpecialServiceRequestGroupName.Location = new System.Drawing.Point(11, 13);
            this.labelServiceSpecialServiceRequestGroupName.Name = "labelServiceSpecialServiceRequestGroupName";
            this.labelServiceSpecialServiceRequestGroupName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestGroupName.TabIndex = 2;
            this.labelServiceSpecialServiceRequestGroupName.Text = "Service Special Service Request Group Name:";
            //
            //textBoxServiceSpecialServiceRequestGroupName
            //
            this.textBoxServiceSpecialServiceRequestGroupName.Location = new System.Drawing.Point(294, 13);
            this.textBoxServiceSpecialServiceRequestGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestGroupName.Name = "textBoxServiceSpecialServiceRequestGroupName";
            this.textBoxServiceSpecialServiceRequestGroupName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestGroupName.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestGroup
            //
            this.labelServiceSpecialServiceRequestGroup.AutoSize = true;
            this.labelServiceSpecialServiceRequestGroup.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestGroup.Name = "labelServiceSpecialServiceRequestGroup";
            this.labelServiceSpecialServiceRequestGroup.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestGroup.TabIndex = 4;
            this.labelServiceSpecialServiceRequestGroup.Text = "Service Special Service Request Group:";
            //
            //textBoxServiceSpecialServiceRequestGroup
            //
            this.textBoxServiceSpecialServiceRequestGroup.Location = new System.Drawing.Point(294, 36);
            this.textBoxServiceSpecialServiceRequestGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestGroup.Name = "textBoxServiceSpecialServiceRequestGroup";
            this.textBoxServiceSpecialServiceRequestGroup.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestGroup.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(294, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeServiceSpecialServiceRequestGroupRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.Name = "dataGridViewCrudeServiceSpecialServiceRequestGroupRef";
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.Size = new System.Drawing.Size(532, 96);
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.TabIndex = 0;
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.ReadOnly = true;
            this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(452, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestGroupRefSearch
            // 
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.Location = new System.Drawing.Point(352, 195);
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.Name = "buttonCrudeServiceSpecialServiceRequestGroupRefSearch";
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.TabIndex = 2;
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.Text = "&Search";
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestGroupRefAdd
            // 
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.Location = new System.Drawing.Point(252, 195);
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.Name = "buttonCrudeServiceSpecialServiceRequestGroupRefAdd";
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.TabIndex = 3;
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.Text = "&Add";
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestGroupRefEdit
            // 
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.Location = new System.Drawing.Point(152, 195);
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.Name = "buttonCrudeServiceSpecialServiceRequestGroupRefEdit";
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.TabIndex = 4;
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.Text = "&Edit";
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 223);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestGroupRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestGroupRefAdd);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestGroupRefEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef);
            this.Name = "CrudeServiceSpecialServiceRequestGroupRefSearch";
            this.Text = "Service Special Service Request Group Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceSpecialServiceRequestGroupRef)).EndInit();
            this.Controls.Add(this.labelServiceSpecialServiceRequestGroupName);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestGroupName);
            this.Controls.Add(this.labelServiceSpecialServiceRequestGroup);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestGroup);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
