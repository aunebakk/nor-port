namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFerryIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFerryIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFerryIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFerryIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFerryIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFerryIdentifierTypeName;
        
        private System.Windows.Forms.Label labelFerryIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxFerryIdentifierType;
        
        private System.Windows.Forms.Label labelFerryIdentifierType;
        
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
            this.buttonCrudeFerryIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFerryIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFerryIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFerryIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFerryIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxFerryIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelFerryIdentifierType = new System.Windows.Forms.Label();
            this.textBoxFerryIdentifierType = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerryIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFerryIdentifierTypeName
            //
            this.labelFerryIdentifierTypeName.AutoSize = true;
            this.labelFerryIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFerryIdentifierTypeName.Name = "labelFerryIdentifierTypeName";
            this.labelFerryIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFerryIdentifierTypeName.TabIndex = 2;
            this.labelFerryIdentifierTypeName.Text = "Ferry Identifier Type Name:";
            //
            //textBoxFerryIdentifierTypeName
            //
            this.textBoxFerryIdentifierTypeName.Location = new System.Drawing.Point(182, 13);
            this.textBoxFerryIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryIdentifierTypeName.Name = "textBoxFerryIdentifierTypeName";
            this.textBoxFerryIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryIdentifierTypeName.TabIndex = 3;
            //
            // labelFerryIdentifierType
            //
            this.labelFerryIdentifierType.AutoSize = true;
            this.labelFerryIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelFerryIdentifierType.Name = "labelFerryIdentifierType";
            this.labelFerryIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelFerryIdentifierType.TabIndex = 4;
            this.labelFerryIdentifierType.Text = "Ferry Identifier Type:";
            //
            //textBoxFerryIdentifierType
            //
            this.textBoxFerryIdentifierType.Location = new System.Drawing.Point(182, 36);
            this.textBoxFerryIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryIdentifierType.Name = "textBoxFerryIdentifierType";
            this.textBoxFerryIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryIdentifierType.TabIndex = 5;
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
            this.textBoxState.Location = new System.Drawing.Point(182, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeFerryIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFerryIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFerryIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFerryIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFerryIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFerryIdentifierTypeRef.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFerryIdentifierTypeRef.Name = "dataGridViewCrudeFerryIdentifierTypeRef";
            this.dataGridViewCrudeFerryIdentifierTypeRef.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeFerryIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFerryIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFerryIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFerryIdentifierTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFerryIdentifierTypeRefSearch
            // 
            this.buttonCrudeFerryIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryIdentifierTypeRefSearch.Location = new System.Drawing.Point(240, 218);
            this.buttonCrudeFerryIdentifierTypeRefSearch.Name = "buttonCrudeFerryIdentifierTypeRefSearch";
            this.buttonCrudeFerryIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFerryIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeFerryIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFerryIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeFerryIdentifierTypeRefAdd
            // 
            this.buttonCrudeFerryIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryIdentifierTypeRefAdd.Location = new System.Drawing.Point(140, 218);
            this.buttonCrudeFerryIdentifierTypeRefAdd.Name = "buttonCrudeFerryIdentifierTypeRefAdd";
            this.buttonCrudeFerryIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFerryIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeFerryIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFerryIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeFerryIdentifierTypeRefEdit
            // 
            this.buttonCrudeFerryIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryIdentifierTypeRefEdit.Location = new System.Drawing.Point(40, 218);
            this.buttonCrudeFerryIdentifierTypeRefEdit.Name = "buttonCrudeFerryIdentifierTypeRefEdit";
            this.buttonCrudeFerryIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFerryIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFerryIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFerryIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 246);
            this.Controls.Add(this.buttonCrudeFerryIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFerryIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFerryIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFerryIdentifierTypeRef);
            this.Name = "CrudeFerryIdentifierTypeRefSearch";
            this.Text = "Ferry Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerryIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelFerryIdentifierTypeName);
            this.Controls.Add(this.textBoxFerryIdentifierTypeName);
            this.Controls.Add(this.labelFerryIdentifierType);
            this.Controls.Add(this.textBoxFerryIdentifierType);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
