namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientTypeRef;
        
        private System.Windows.Forms.TextBox textBoxClientTypeName;
        
        private System.Windows.Forms.Label labelClientTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientType;
        
        private System.Windows.Forms.Label labelClientType;
        
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
            this.buttonCrudeClientTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientTypeRef = new System.Windows.Forms.DataGridView();
            this.labelClientTypeName = new System.Windows.Forms.Label();
            this.textBoxClientTypeName = new System.Windows.Forms.TextBox();
            this.labelClientType = new System.Windows.Forms.Label();
            this.textBoxClientType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientTypeName
            //
            this.labelClientTypeName.AutoSize = true;
            this.labelClientTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelClientTypeName.Name = "labelClientTypeName";
            this.labelClientTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeName.TabIndex = 2;
            this.labelClientTypeName.Text = "Client Type Name:";
            //
            //textBoxClientTypeName
            //
            this.textBoxClientTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxClientTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTypeName.Name = "textBoxClientTypeName";
            this.textBoxClientTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTypeName.TabIndex = 3;
            //
            // labelClientType
            //
            this.labelClientType.AutoSize = true;
            this.labelClientType.Location = new System.Drawing.Point(11, 36);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(71, 13);
            this.labelClientType.TabIndex = 4;
            this.labelClientType.Text = "Client Type:";
            //
            //textBoxClientType
            //
            this.textBoxClientType.Location = new System.Drawing.Point(140, 36);
            this.textBoxClientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientType.Name = "textBoxClientType";
            this.textBoxClientType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientType.TabIndex = 5;
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
            // dataGridViewCrudeClientTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeClientTypeRef.Name = "dataGridViewCrudeClientTypeRef";
            this.dataGridViewCrudeClientTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClientTypeRef.TabIndex = 0;
            this.dataGridViewCrudeClientTypeRef.ReadOnly = true;
            this.dataGridViewCrudeClientTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientTypeRef_DoubleClick);
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
            // buttonCrudeClientTypeRefSearch
            // 
            this.buttonCrudeClientTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeClientTypeRefSearch.Name = "buttonCrudeClientTypeRefSearch";
            this.buttonCrudeClientTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientTypeRefSearch.TabIndex = 2;
            this.buttonCrudeClientTypeRefSearch.Text = "&Search";
            this.buttonCrudeClientTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeClientTypeRefSearch_Click);
            // 
            // buttonCrudeClientTypeRefAdd
            // 
            this.buttonCrudeClientTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeClientTypeRefAdd.Name = "buttonCrudeClientTypeRefAdd";
            this.buttonCrudeClientTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientTypeRefAdd.TabIndex = 3;
            this.buttonCrudeClientTypeRefAdd.Text = "&Add";
            this.buttonCrudeClientTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeClientTypeRefAdd_Click);
            // 
            // buttonCrudeClientTypeRefEdit
            // 
            this.buttonCrudeClientTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeClientTypeRefEdit.Name = "buttonCrudeClientTypeRefEdit";
            this.buttonCrudeClientTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientTypeRefEdit.TabIndex = 4;
            this.buttonCrudeClientTypeRefEdit.Text = "&Edit";
            this.buttonCrudeClientTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeClientTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeClientTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientTypeRefAdd);
            this.Controls.Add(this.buttonCrudeClientTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientTypeRef);
            this.Name = "CrudeClientTypeRefSearch";
            this.Text = "Client Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientTypeRef)).EndInit();
            this.Controls.Add(this.labelClientTypeName);
            this.Controls.Add(this.textBoxClientTypeName);
            this.Controls.Add(this.labelClientType);
            this.Controls.Add(this.textBoxClientType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
