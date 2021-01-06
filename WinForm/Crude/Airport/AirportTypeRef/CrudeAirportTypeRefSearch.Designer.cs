namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAirportTypeName;
        
        private System.Windows.Forms.Label labelAirportTypeName;
        
        private System.Windows.Forms.TextBox textBoxAirportType;
        
        private System.Windows.Forms.Label labelAirportType;
        
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
            this.buttonCrudeAirportTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAirportTypeName = new System.Windows.Forms.Label();
            this.textBoxAirportTypeName = new System.Windows.Forms.TextBox();
            this.labelAirportType = new System.Windows.Forms.Label();
            this.textBoxAirportType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportTypeName
            //
            this.labelAirportTypeName.AutoSize = true;
            this.labelAirportTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAirportTypeName.Name = "labelAirportTypeName";
            this.labelAirportTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportTypeName.TabIndex = 2;
            this.labelAirportTypeName.Text = "Airport Type Name:";
            //
            //textBoxAirportTypeName
            //
            this.textBoxAirportTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAirportTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportTypeName.Name = "textBoxAirportTypeName";
            this.textBoxAirportTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportTypeName.TabIndex = 3;
            //
            // labelAirportType
            //
            this.labelAirportType.AutoSize = true;
            this.labelAirportType.Location = new System.Drawing.Point(11, 36);
            this.labelAirportType.Name = "labelAirportType";
            this.labelAirportType.Size = new System.Drawing.Size(71, 13);
            this.labelAirportType.TabIndex = 4;
            this.labelAirportType.Text = "Airport Type:";
            //
            //textBoxAirportType
            //
            this.textBoxAirportType.Location = new System.Drawing.Point(140, 36);
            this.textBoxAirportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportType.Name = "textBoxAirportType";
            this.textBoxAirportType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportType.TabIndex = 5;
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
            // dataGridViewCrudeAirportTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirportTypeRef.Name = "dataGridViewCrudeAirportTypeRef";
            this.dataGridViewCrudeAirportTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirportTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAirportTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAirportTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportTypeRef_DoubleClick);
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
            // buttonCrudeAirportTypeRefSearch
            // 
            this.buttonCrudeAirportTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeAirportTypeRefSearch.Name = "buttonCrudeAirportTypeRefSearch";
            this.buttonCrudeAirportTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAirportTypeRefSearch.Text = "&Search";
            this.buttonCrudeAirportTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAirportTypeRefSearch_Click);
            // 
            // buttonCrudeAirportTypeRefAdd
            // 
            this.buttonCrudeAirportTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeAirportTypeRefAdd.Name = "buttonCrudeAirportTypeRefAdd";
            this.buttonCrudeAirportTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAirportTypeRefAdd.Text = "&Add";
            this.buttonCrudeAirportTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAirportTypeRefAdd_Click);
            // 
            // buttonCrudeAirportTypeRefEdit
            // 
            this.buttonCrudeAirportTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeAirportTypeRefEdit.Name = "buttonCrudeAirportTypeRefEdit";
            this.buttonCrudeAirportTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAirportTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAirportTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAirportTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeAirportTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAirportTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportTypeRef);
            this.Name = "CrudeAirportTypeRefSearch";
            this.Text = "Airport Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportTypeRef)).EndInit();
            this.Controls.Add(this.labelAirportTypeName);
            this.Controls.Add(this.textBoxAirportTypeName);
            this.Controls.Add(this.labelAirportType);
            this.Controls.Add(this.textBoxAirportType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
