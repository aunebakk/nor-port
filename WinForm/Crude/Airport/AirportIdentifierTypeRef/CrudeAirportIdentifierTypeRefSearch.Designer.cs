namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAirportIdentifierTypeName;
        
        private System.Windows.Forms.Label labelAirportIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxAirportIdentifierType;
        
        private System.Windows.Forms.Label labelAirportIdentifierType;
        
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
            this.buttonCrudeAirportIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAirportIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxAirportIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelAirportIdentifierType = new System.Windows.Forms.Label();
            this.textBoxAirportIdentifierType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportIdentifierTypeName
            //
            this.labelAirportIdentifierTypeName.AutoSize = true;
            this.labelAirportIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAirportIdentifierTypeName.Name = "labelAirportIdentifierTypeName";
            this.labelAirportIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierTypeName.TabIndex = 2;
            this.labelAirportIdentifierTypeName.Text = "Airport Identifier Type Name:";
            //
            //textBoxAirportIdentifierTypeName
            //
            this.textBoxAirportIdentifierTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxAirportIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportIdentifierTypeName.Name = "textBoxAirportIdentifierTypeName";
            this.textBoxAirportIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportIdentifierTypeName.TabIndex = 3;
            //
            // labelAirportIdentifierType
            //
            this.labelAirportIdentifierType.AutoSize = true;
            this.labelAirportIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelAirportIdentifierType.Name = "labelAirportIdentifierType";
            this.labelAirportIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierType.TabIndex = 4;
            this.labelAirportIdentifierType.Text = "Airport Identifier Type:";
            //
            //textBoxAirportIdentifierType
            //
            this.textBoxAirportIdentifierType.Location = new System.Drawing.Point(196, 36);
            this.textBoxAirportIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportIdentifierType.Name = "textBoxAirportIdentifierType";
            this.textBoxAirportIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportIdentifierType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeAirportIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportIdentifierTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirportIdentifierTypeRef.Name = "dataGridViewCrudeAirportIdentifierTypeRef";
            this.dataGridViewCrudeAirportIdentifierTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeAirportIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAirportIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAirportIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportIdentifierTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportIdentifierTypeRefSearch
            // 
            this.buttonCrudeAirportIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportIdentifierTypeRefSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeAirportIdentifierTypeRefSearch.Name = "buttonCrudeAirportIdentifierTypeRefSearch";
            this.buttonCrudeAirportIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAirportIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeAirportIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAirportIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeAirportIdentifierTypeRefAdd
            // 
            this.buttonCrudeAirportIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportIdentifierTypeRefAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeAirportIdentifierTypeRefAdd.Name = "buttonCrudeAirportIdentifierTypeRefAdd";
            this.buttonCrudeAirportIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAirportIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeAirportIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAirportIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeAirportIdentifierTypeRefEdit
            // 
            this.buttonCrudeAirportIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportIdentifierTypeRefEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeAirportIdentifierTypeRefEdit.Name = "buttonCrudeAirportIdentifierTypeRefEdit";
            this.buttonCrudeAirportIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAirportIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAirportIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAirportIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeAirportIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAirportIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportIdentifierTypeRef);
            this.Name = "CrudeAirportIdentifierTypeRefSearch";
            this.Text = "Airport Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelAirportIdentifierTypeName);
            this.Controls.Add(this.textBoxAirportIdentifierTypeName);
            this.Controls.Add(this.labelAirportIdentifierType);
            this.Controls.Add(this.textBoxAirportIdentifierType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
