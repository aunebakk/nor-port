namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceSpecialServiceRequestRequirementRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestRequirementRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestRequirementRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestRequirementRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceSpecialServiceRequestRequirementRef;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestRequirementName;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestRequirementName;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestRequirement;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestRequirement;
        
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
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef = new System.Windows.Forms.DataGridView();
            this.labelServiceSpecialServiceRequestRequirementName = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestRequirementName = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestRequirement = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestRequirement = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceSpecialServiceRequestRequirementName
            //
            this.labelServiceSpecialServiceRequestRequirementName.AutoSize = true;
            this.labelServiceSpecialServiceRequestRequirementName.Location = new System.Drawing.Point(11, 13);
            this.labelServiceSpecialServiceRequestRequirementName.Name = "labelServiceSpecialServiceRequestRequirementName";
            this.labelServiceSpecialServiceRequestRequirementName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestRequirementName.TabIndex = 2;
            this.labelServiceSpecialServiceRequestRequirementName.Text = "Service Special Service Request Requirement Name:";
            //
            //textBoxServiceSpecialServiceRequestRequirementName
            //
            this.textBoxServiceSpecialServiceRequestRequirementName.Location = new System.Drawing.Point(336, 13);
            this.textBoxServiceSpecialServiceRequestRequirementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestRequirementName.Name = "textBoxServiceSpecialServiceRequestRequirementName";
            this.textBoxServiceSpecialServiceRequestRequirementName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestRequirementName.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestRequirement
            //
            this.labelServiceSpecialServiceRequestRequirement.AutoSize = true;
            this.labelServiceSpecialServiceRequestRequirement.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestRequirement.Name = "labelServiceSpecialServiceRequestRequirement";
            this.labelServiceSpecialServiceRequestRequirement.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestRequirement.TabIndex = 4;
            this.labelServiceSpecialServiceRequestRequirement.Text = "Service Special Service Request Requirement:";
            //
            //textBoxServiceSpecialServiceRequestRequirement
            //
            this.textBoxServiceSpecialServiceRequestRequirement.Location = new System.Drawing.Point(336, 36);
            this.textBoxServiceSpecialServiceRequestRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestRequirement.Name = "textBoxServiceSpecialServiceRequestRequirement";
            this.textBoxServiceSpecialServiceRequestRequirement.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestRequirement.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(336, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeServiceSpecialServiceRequestRequirementRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.Name = "dataGridViewCrudeServiceSpecialServiceRequestRequirementRef";
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.Size = new System.Drawing.Size(574, 96);
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.TabIndex = 0;
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.ReadOnly = true;
            this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(494, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestRequirementRefSearch
            // 
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.Location = new System.Drawing.Point(394, 195);
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.Name = "buttonCrudeServiceSpecialServiceRequestRequirementRefSearch";
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.TabIndex = 2;
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.Text = "&Search";
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestRequirementRefAdd
            // 
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.Location = new System.Drawing.Point(294, 195);
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.Name = "buttonCrudeServiceSpecialServiceRequestRequirementRefAdd";
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.TabIndex = 3;
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.Text = "&Add";
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestRequirementRefEdit
            // 
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.Location = new System.Drawing.Point(194, 195);
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.Name = "buttonCrudeServiceSpecialServiceRequestRequirementRefEdit";
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.TabIndex = 4;
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.Text = "&Edit";
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 223);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestRequirementRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestRequirementRefAdd);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestRequirementRefEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef);
            this.Name = "CrudeServiceSpecialServiceRequestRequirementRefSearch";
            this.Text = "Service Special Service Request Requirement Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceSpecialServiceRequestRequirementRef)).EndInit();
            this.Controls.Add(this.labelServiceSpecialServiceRequestRequirementName);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestRequirementName);
            this.Controls.Add(this.labelServiceSpecialServiceRequestRequirement);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestRequirement);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
