namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFerryTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFerryTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFerryTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFerryTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFerryTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFerryTypeName;
        
        private System.Windows.Forms.Label labelFerryTypeName;
        
        private System.Windows.Forms.TextBox textBoxFerryType;
        
        private System.Windows.Forms.Label labelFerryType;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
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
            this.buttonCrudeFerryTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFerryTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFerryTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFerryTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFerryTypeName = new System.Windows.Forms.Label();
            this.textBoxFerryTypeName = new System.Windows.Forms.TextBox();
            this.labelFerryType = new System.Windows.Forms.Label();
            this.textBoxFerryType = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerryTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFerryTypeName
            //
            this.labelFerryTypeName.AutoSize = true;
            this.labelFerryTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFerryTypeName.Name = "labelFerryTypeName";
            this.labelFerryTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFerryTypeName.TabIndex = 2;
            this.labelFerryTypeName.Text = "Ferry Type Name:";
            //
            //textBoxFerryTypeName
            //
            this.textBoxFerryTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxFerryTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryTypeName.Name = "textBoxFerryTypeName";
            this.textBoxFerryTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryTypeName.TabIndex = 3;
            //
            // labelFerryType
            //
            this.labelFerryType.AutoSize = true;
            this.labelFerryType.Location = new System.Drawing.Point(11, 36);
            this.labelFerryType.Name = "labelFerryType";
            this.labelFerryType.Size = new System.Drawing.Size(71, 13);
            this.labelFerryType.TabIndex = 4;
            this.labelFerryType.Text = "Ferry Type:";
            //
            //textBoxFerryType
            //
            this.textBoxFerryType.Location = new System.Drawing.Point(140, 36);
            this.textBoxFerryType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryType.Name = "textBoxFerryType";
            this.textBoxFerryType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryType.TabIndex = 5;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 59);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(140, 59);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeFerryTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFerryTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFerryTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFerryTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFerryTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFerryTypeRef.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFerryTypeRef.Name = "dataGridViewCrudeFerryTypeRef";
            this.dataGridViewCrudeFerryTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFerryTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFerryTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFerryTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFerryTypeRef_DoubleClick);
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
            // buttonCrudeFerryTypeRefSearch
            // 
            this.buttonCrudeFerryTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryTypeRefSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeFerryTypeRefSearch.Name = "buttonCrudeFerryTypeRefSearch";
            this.buttonCrudeFerryTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFerryTypeRefSearch.Text = "&Search";
            this.buttonCrudeFerryTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFerryTypeRefSearch_Click);
            // 
            // buttonCrudeFerryTypeRefAdd
            // 
            this.buttonCrudeFerryTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryTypeRefAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeFerryTypeRefAdd.Name = "buttonCrudeFerryTypeRefAdd";
            this.buttonCrudeFerryTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFerryTypeRefAdd.Text = "&Add";
            this.buttonCrudeFerryTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFerryTypeRefAdd_Click);
            // 
            // buttonCrudeFerryTypeRefEdit
            // 
            this.buttonCrudeFerryTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryTypeRefEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeFerryTypeRefEdit.Name = "buttonCrudeFerryTypeRefEdit";
            this.buttonCrudeFerryTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFerryTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFerryTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFerryTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeFerryTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFerryTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFerryTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFerryTypeRef);
            this.Name = "CrudeFerryTypeRefSearch";
            this.Text = "Ferry Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerryTypeRef)).EndInit();
            this.Controls.Add(this.labelFerryTypeName);
            this.Controls.Add(this.textBoxFerryTypeName);
            this.Controls.Add(this.labelFerryType);
            this.Controls.Add(this.textBoxFerryType);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
