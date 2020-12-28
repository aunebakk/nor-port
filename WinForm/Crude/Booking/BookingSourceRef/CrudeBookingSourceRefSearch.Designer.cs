namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingSourceRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingSourceRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingSourceRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingSourceRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingSourceRef;
        
        private System.Windows.Forms.TextBox textBoxBookingSourceName;
        
        private System.Windows.Forms.Label labelBookingSourceName;
        
        private System.Windows.Forms.TextBox textBoxBookingSource;
        
        private System.Windows.Forms.Label labelBookingSource;
        
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
            this.buttonCrudeBookingSourceRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingSourceRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingSourceRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingSourceRef = new System.Windows.Forms.DataGridView();
            this.labelBookingSourceName = new System.Windows.Forms.Label();
            this.textBoxBookingSourceName = new System.Windows.Forms.TextBox();
            this.labelBookingSource = new System.Windows.Forms.Label();
            this.textBoxBookingSource = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingSourceRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingSourceName
            //
            this.labelBookingSourceName.AutoSize = true;
            this.labelBookingSourceName.Location = new System.Drawing.Point(11, 13);
            this.labelBookingSourceName.Name = "labelBookingSourceName";
            this.labelBookingSourceName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingSourceName.TabIndex = 2;
            this.labelBookingSourceName.Text = "Booking Source Name:";
            //
            //textBoxBookingSourceName
            //
            this.textBoxBookingSourceName.Location = new System.Drawing.Point(140, 13);
            this.textBoxBookingSourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingSourceName.Name = "textBoxBookingSourceName";
            this.textBoxBookingSourceName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingSourceName.TabIndex = 3;
            //
            // labelBookingSource
            //
            this.labelBookingSource.AutoSize = true;
            this.labelBookingSource.Location = new System.Drawing.Point(11, 36);
            this.labelBookingSource.Name = "labelBookingSource";
            this.labelBookingSource.Size = new System.Drawing.Size(71, 13);
            this.labelBookingSource.TabIndex = 4;
            this.labelBookingSource.Text = "Booking Source:";
            //
            //textBoxBookingSource
            //
            this.textBoxBookingSource.Location = new System.Drawing.Point(140, 36);
            this.textBoxBookingSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingSource.Name = "textBoxBookingSource";
            this.textBoxBookingSource.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingSource.TabIndex = 5;
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
            // dataGridViewCrudeBookingSourceRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingSourceRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingSourceRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingSourceRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingSourceRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingSourceRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingSourceRef.Name = "dataGridViewCrudeBookingSourceRef";
            this.dataGridViewCrudeBookingSourceRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBookingSourceRef.TabIndex = 0;
            this.dataGridViewCrudeBookingSourceRef.ReadOnly = true;
            this.dataGridViewCrudeBookingSourceRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingSourceRef_DoubleClick);
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
            // buttonCrudeBookingSourceRefSearch
            // 
            this.buttonCrudeBookingSourceRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingSourceRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeBookingSourceRefSearch.Name = "buttonCrudeBookingSourceRefSearch";
            this.buttonCrudeBookingSourceRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingSourceRefSearch.TabIndex = 2;
            this.buttonCrudeBookingSourceRefSearch.Text = "&Search";
            this.buttonCrudeBookingSourceRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingSourceRefSearch.Click += new System.EventHandler(this.buttonCrudeBookingSourceRefSearch_Click);
            // 
            // buttonCrudeBookingSourceRefAdd
            // 
            this.buttonCrudeBookingSourceRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingSourceRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeBookingSourceRefAdd.Name = "buttonCrudeBookingSourceRefAdd";
            this.buttonCrudeBookingSourceRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingSourceRefAdd.TabIndex = 3;
            this.buttonCrudeBookingSourceRefAdd.Text = "&Add";
            this.buttonCrudeBookingSourceRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingSourceRefAdd.Click += new System.EventHandler(this.buttonCrudeBookingSourceRefAdd_Click);
            // 
            // buttonCrudeBookingSourceRefEdit
            // 
            this.buttonCrudeBookingSourceRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingSourceRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeBookingSourceRefEdit.Name = "buttonCrudeBookingSourceRefEdit";
            this.buttonCrudeBookingSourceRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingSourceRefEdit.TabIndex = 4;
            this.buttonCrudeBookingSourceRefEdit.Text = "&Edit";
            this.buttonCrudeBookingSourceRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingSourceRefEdit.Click += new System.EventHandler(this.buttonCrudeBookingSourceRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeBookingSourceRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingSourceRefAdd);
            this.Controls.Add(this.buttonCrudeBookingSourceRefEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingSourceRef);
            this.Name = "CrudeBookingSourceRefSearch";
            this.Text = "Booking Source Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingSourceRef)).EndInit();
            this.Controls.Add(this.labelBookingSourceName);
            this.Controls.Add(this.textBoxBookingSourceName);
            this.Controls.Add(this.labelBookingSource);
            this.Controls.Add(this.textBoxBookingSource);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
