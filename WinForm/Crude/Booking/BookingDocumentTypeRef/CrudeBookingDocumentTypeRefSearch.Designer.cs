namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingDocumentTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingDocumentTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingDocumentTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingDocumentTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingDocumentTypeRef;
        
        private System.Windows.Forms.TextBox textBoxBookingDocumentTypeName;
        
        private System.Windows.Forms.Label labelBookingDocumentTypeName;
        
        private System.Windows.Forms.TextBox textBoxBookingDocumentType;
        
        private System.Windows.Forms.Label labelBookingDocumentType;
        
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
            this.buttonCrudeBookingDocumentTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingDocumentTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingDocumentTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingDocumentTypeRef = new System.Windows.Forms.DataGridView();
            this.labelBookingDocumentTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingDocumentTypeName = new System.Windows.Forms.TextBox();
            this.labelBookingDocumentType = new System.Windows.Forms.Label();
            this.textBoxBookingDocumentType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingDocumentTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingDocumentTypeName
            //
            this.labelBookingDocumentTypeName.AutoSize = true;
            this.labelBookingDocumentTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelBookingDocumentTypeName.Name = "labelBookingDocumentTypeName";
            this.labelBookingDocumentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentTypeName.TabIndex = 2;
            this.labelBookingDocumentTypeName.Text = "Booking Document Type Name:";
            //
            //textBoxBookingDocumentTypeName
            //
            this.textBoxBookingDocumentTypeName.Location = new System.Drawing.Point(182, 13);
            this.textBoxBookingDocumentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocumentTypeName.Name = "textBoxBookingDocumentTypeName";
            this.textBoxBookingDocumentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocumentTypeName.TabIndex = 3;
            //
            // labelBookingDocumentType
            //
            this.labelBookingDocumentType.AutoSize = true;
            this.labelBookingDocumentType.Location = new System.Drawing.Point(11, 36);
            this.labelBookingDocumentType.Name = "labelBookingDocumentType";
            this.labelBookingDocumentType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentType.TabIndex = 4;
            this.labelBookingDocumentType.Text = "Booking Document Type:";
            //
            //textBoxBookingDocumentType
            //
            this.textBoxBookingDocumentType.Location = new System.Drawing.Point(182, 36);
            this.textBoxBookingDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocumentType.Name = "textBoxBookingDocumentType";
            this.textBoxBookingDocumentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocumentType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeBookingDocumentTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingDocumentTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingDocumentTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingDocumentTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingDocumentTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingDocumentTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingDocumentTypeRef.Name = "dataGridViewCrudeBookingDocumentTypeRef";
            this.dataGridViewCrudeBookingDocumentTypeRef.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeBookingDocumentTypeRef.TabIndex = 0;
            this.dataGridViewCrudeBookingDocumentTypeRef.ReadOnly = true;
            this.dataGridViewCrudeBookingDocumentTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingDocumentTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingDocumentTypeRefSearch
            // 
            this.buttonCrudeBookingDocumentTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingDocumentTypeRefSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonCrudeBookingDocumentTypeRefSearch.Name = "buttonCrudeBookingDocumentTypeRefSearch";
            this.buttonCrudeBookingDocumentTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingDocumentTypeRefSearch.TabIndex = 2;
            this.buttonCrudeBookingDocumentTypeRefSearch.Text = "&Search";
            this.buttonCrudeBookingDocumentTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingDocumentTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeBookingDocumentTypeRefSearch_Click);
            // 
            // buttonCrudeBookingDocumentTypeRefAdd
            // 
            this.buttonCrudeBookingDocumentTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingDocumentTypeRefAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonCrudeBookingDocumentTypeRefAdd.Name = "buttonCrudeBookingDocumentTypeRefAdd";
            this.buttonCrudeBookingDocumentTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingDocumentTypeRefAdd.TabIndex = 3;
            this.buttonCrudeBookingDocumentTypeRefAdd.Text = "&Add";
            this.buttonCrudeBookingDocumentTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingDocumentTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeBookingDocumentTypeRefAdd_Click);
            // 
            // buttonCrudeBookingDocumentTypeRefEdit
            // 
            this.buttonCrudeBookingDocumentTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingDocumentTypeRefEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonCrudeBookingDocumentTypeRefEdit.Name = "buttonCrudeBookingDocumentTypeRefEdit";
            this.buttonCrudeBookingDocumentTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingDocumentTypeRefEdit.TabIndex = 4;
            this.buttonCrudeBookingDocumentTypeRefEdit.Text = "&Edit";
            this.buttonCrudeBookingDocumentTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingDocumentTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeBookingDocumentTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.buttonCrudeBookingDocumentTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingDocumentTypeRefAdd);
            this.Controls.Add(this.buttonCrudeBookingDocumentTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingDocumentTypeRef);
            this.Name = "CrudeBookingDocumentTypeRefSearch";
            this.Text = "Booking Document Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingDocumentTypeRef)).EndInit();
            this.Controls.Add(this.labelBookingDocumentTypeName);
            this.Controls.Add(this.textBoxBookingDocumentTypeName);
            this.Controls.Add(this.labelBookingDocumentType);
            this.Controls.Add(this.textBoxBookingDocumentType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
