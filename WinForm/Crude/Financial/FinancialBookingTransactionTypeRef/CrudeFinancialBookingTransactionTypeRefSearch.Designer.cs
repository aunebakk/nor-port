namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialBookingTransactionTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBookingTransactionTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBookingTransactionTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBookingTransactionTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialBookingTransactionTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialBookingTransactionTypeName;
        
        private System.Windows.Forms.Label labelFinancialBookingTransactionTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialBookingTransactionType;
        
        private System.Windows.Forms.Label labelFinancialBookingTransactionType;
        
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
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialBookingTransactionTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialBookingTransactionTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialBookingTransactionType = new System.Windows.Forms.Label();
            this.textBoxFinancialBookingTransactionType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialBookingTransactionTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialBookingTransactionTypeName
            //
            this.labelFinancialBookingTransactionTypeName.AutoSize = true;
            this.labelFinancialBookingTransactionTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialBookingTransactionTypeName.Name = "labelFinancialBookingTransactionTypeName";
            this.labelFinancialBookingTransactionTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBookingTransactionTypeName.TabIndex = 2;
            this.labelFinancialBookingTransactionTypeName.Text = "Financial Booking Transaction Type Name:";
            //
            //textBoxFinancialBookingTransactionTypeName
            //
            this.textBoxFinancialBookingTransactionTypeName.Location = new System.Drawing.Point(273, 13);
            this.textBoxFinancialBookingTransactionTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBookingTransactionTypeName.Name = "textBoxFinancialBookingTransactionTypeName";
            this.textBoxFinancialBookingTransactionTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBookingTransactionTypeName.TabIndex = 3;
            //
            // labelFinancialBookingTransactionType
            //
            this.labelFinancialBookingTransactionType.AutoSize = true;
            this.labelFinancialBookingTransactionType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialBookingTransactionType.Name = "labelFinancialBookingTransactionType";
            this.labelFinancialBookingTransactionType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBookingTransactionType.TabIndex = 4;
            this.labelFinancialBookingTransactionType.Text = "Financial Booking Transaction Type:";
            //
            //textBoxFinancialBookingTransactionType
            //
            this.textBoxFinancialBookingTransactionType.Location = new System.Drawing.Point(273, 36);
            this.textBoxFinancialBookingTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBookingTransactionType.Name = "textBoxFinancialBookingTransactionType";
            this.textBoxFinancialBookingTransactionType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBookingTransactionType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(273, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialBookingTransactionTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.Name = "dataGridViewCrudeFinancialBookingTransactionTypeRef";
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialBookingTransactionTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialBookingTransactionTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(431, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialBookingTransactionTypeRefSearch
            // 
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.Location = new System.Drawing.Point(331, 195);
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.Name = "buttonCrudeFinancialBookingTransactionTypeRefSearch";
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBookingTransactionTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialBookingTransactionTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialBookingTransactionTypeRefAdd
            // 
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.Location = new System.Drawing.Point(231, 195);
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.Name = "buttonCrudeFinancialBookingTransactionTypeRefAdd";
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBookingTransactionTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialBookingTransactionTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialBookingTransactionTypeRefEdit
            // 
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.Location = new System.Drawing.Point(131, 195);
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.Name = "buttonCrudeFinancialBookingTransactionTypeRefEdit";
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBookingTransactionTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialBookingTransactionTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 223);
            this.Controls.Add(this.buttonCrudeFinancialBookingTransactionTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialBookingTransactionTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialBookingTransactionTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialBookingTransactionTypeRef);
            this.Name = "CrudeFinancialBookingTransactionTypeRefSearch";
            this.Text = "Financial Booking Transaction Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialBookingTransactionTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialBookingTransactionTypeName);
            this.Controls.Add(this.textBoxFinancialBookingTransactionTypeName);
            this.Controls.Add(this.labelFinancialBookingTransactionType);
            this.Controls.Add(this.textBoxFinancialBookingTransactionType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
