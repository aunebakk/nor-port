namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierTypeName;
        
        private System.Windows.Forms.Label labelFlightIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierType;
        
        private System.Windows.Forms.Label labelFlightIdentifierType;
        
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
            this.buttonCrudeFlightIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFlightIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelFlightIdentifierType = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFlightIdentifierTypeName
            //
            this.labelFlightIdentifierTypeName.AutoSize = true;
            this.labelFlightIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFlightIdentifierTypeName.Name = "labelFlightIdentifierTypeName";
            this.labelFlightIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierTypeName.TabIndex = 2;
            this.labelFlightIdentifierTypeName.Text = "Flight Identifier Type Name:";
            //
            //textBoxFlightIdentifierTypeName
            //
            this.textBoxFlightIdentifierTypeName.Location = new System.Drawing.Point(189, 13);
            this.textBoxFlightIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierTypeName.Name = "textBoxFlightIdentifierTypeName";
            this.textBoxFlightIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierTypeName.TabIndex = 3;
            //
            // labelFlightIdentifierType
            //
            this.labelFlightIdentifierType.AutoSize = true;
            this.labelFlightIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelFlightIdentifierType.Name = "labelFlightIdentifierType";
            this.labelFlightIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierType.TabIndex = 4;
            this.labelFlightIdentifierType.Text = "Flight Identifier Type:";
            //
            //textBoxFlightIdentifierType
            //
            this.textBoxFlightIdentifierType.Location = new System.Drawing.Point(189, 36);
            this.textBoxFlightIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierType.Name = "textBoxFlightIdentifierType";
            this.textBoxFlightIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFlightIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightIdentifierTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFlightIdentifierTypeRef.Name = "dataGridViewCrudeFlightIdentifierTypeRef";
            this.dataGridViewCrudeFlightIdentifierTypeRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeFlightIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFlightIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFlightIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightIdentifierTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightIdentifierTypeRefSearch
            // 
            this.buttonCrudeFlightIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightIdentifierTypeRefSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeFlightIdentifierTypeRefSearch.Name = "buttonCrudeFlightIdentifierTypeRefSearch";
            this.buttonCrudeFlightIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFlightIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeFlightIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFlightIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeFlightIdentifierTypeRefAdd
            // 
            this.buttonCrudeFlightIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightIdentifierTypeRefAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeFlightIdentifierTypeRefAdd.Name = "buttonCrudeFlightIdentifierTypeRefAdd";
            this.buttonCrudeFlightIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFlightIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeFlightIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFlightIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeFlightIdentifierTypeRefEdit
            // 
            this.buttonCrudeFlightIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightIdentifierTypeRefEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeFlightIdentifierTypeRefEdit.Name = "buttonCrudeFlightIdentifierTypeRefEdit";
            this.buttonCrudeFlightIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFlightIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFlightIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFlightIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeFlightIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFlightIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightIdentifierTypeRef);
            this.Name = "CrudeFlightIdentifierTypeRefSearch";
            this.Text = "Flight Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelFlightIdentifierTypeName);
            this.Controls.Add(this.textBoxFlightIdentifierTypeName);
            this.Controls.Add(this.labelFlightIdentifierType);
            this.Controls.Add(this.textBoxFlightIdentifierType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
