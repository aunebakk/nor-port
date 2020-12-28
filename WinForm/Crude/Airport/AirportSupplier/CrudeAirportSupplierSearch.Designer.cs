namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportSupplierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportSupplierSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportSupplierAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportSupplierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportSupplier;
        
        private System.Windows.Forms.TextBox textBoxAiportSupplierName;
        
        private System.Windows.Forms.Label labelAiportSupplierName;
        
        private System.Windows.Forms.TextBox textBoxAirportSupplierCode;
        
        private System.Windows.Forms.Label labelAirportSupplierCode;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAirportSupplierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportSupplierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportSupplierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportSupplier = new System.Windows.Forms.DataGridView();
            this.labelAiportSupplierName = new System.Windows.Forms.Label();
            this.textBoxAiportSupplierName = new System.Windows.Forms.TextBox();
            this.labelAirportSupplierCode = new System.Windows.Forms.Label();
            this.textBoxAirportSupplierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportSupplier)).BeginInit();
            this.SuspendLayout();
            //
            // labelAiportSupplierName
            //
            this.labelAiportSupplierName.AutoSize = true;
            this.labelAiportSupplierName.Location = new System.Drawing.Point(11, 13);
            this.labelAiportSupplierName.Name = "labelAiportSupplierName";
            this.labelAiportSupplierName.Size = new System.Drawing.Size(71, 13);
            this.labelAiportSupplierName.TabIndex = 2;
            this.labelAiportSupplierName.Text = "Aiport Supplier Name:";
            //
            //textBoxAiportSupplierName
            //
            this.textBoxAiportSupplierName.Location = new System.Drawing.Point(147, 13);
            this.textBoxAiportSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAiportSupplierName.Name = "textBoxAiportSupplierName";
            this.textBoxAiportSupplierName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAiportSupplierName.TabIndex = 3;
            //
            // labelAirportSupplierCode
            //
            this.labelAirportSupplierCode.AutoSize = true;
            this.labelAirportSupplierCode.Location = new System.Drawing.Point(11, 36);
            this.labelAirportSupplierCode.Name = "labelAirportSupplierCode";
            this.labelAirportSupplierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAirportSupplierCode.TabIndex = 4;
            this.labelAirportSupplierCode.Text = "Airport Supplier Code:";
            //
            //textBoxAirportSupplierCode
            //
            this.textBoxAirportSupplierCode.Location = new System.Drawing.Point(147, 36);
            this.textBoxAirportSupplierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportSupplierCode.Name = "textBoxAirportSupplierCode";
            this.textBoxAirportSupplierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportSupplierCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(147, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeAirportSupplier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportSupplier.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAirportSupplier.Name = "dataGridViewCrudeAirportSupplier";
            this.dataGridViewCrudeAirportSupplier.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeAirportSupplier.TabIndex = 0;
            this.dataGridViewCrudeAirportSupplier.ReadOnly = true;
            this.dataGridViewCrudeAirportSupplier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportSupplier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportSupplierSearch
            // 
            this.buttonCrudeAirportSupplierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSupplierSearch.Location = new System.Drawing.Point(205, 218);
            this.buttonCrudeAirportSupplierSearch.Name = "buttonCrudeAirportSupplierSearch";
            this.buttonCrudeAirportSupplierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSupplierSearch.TabIndex = 2;
            this.buttonCrudeAirportSupplierSearch.Text = "&Search";
            this.buttonCrudeAirportSupplierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSupplierSearch.Click += new System.EventHandler(this.buttonCrudeAirportSupplierSearch_Click);
            // 
            // buttonCrudeAirportSupplierAdd
            // 
            this.buttonCrudeAirportSupplierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSupplierAdd.Location = new System.Drawing.Point(105, 218);
            this.buttonCrudeAirportSupplierAdd.Name = "buttonCrudeAirportSupplierAdd";
            this.buttonCrudeAirportSupplierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSupplierAdd.TabIndex = 3;
            this.buttonCrudeAirportSupplierAdd.Text = "&Add";
            this.buttonCrudeAirportSupplierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSupplierAdd.Click += new System.EventHandler(this.buttonCrudeAirportSupplierAdd_Click);
            // 
            // buttonCrudeAirportSupplierEdit
            // 
            this.buttonCrudeAirportSupplierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSupplierEdit.Location = new System.Drawing.Point(5, 218);
            this.buttonCrudeAirportSupplierEdit.Name = "buttonCrudeAirportSupplierEdit";
            this.buttonCrudeAirportSupplierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSupplierEdit.TabIndex = 4;
            this.buttonCrudeAirportSupplierEdit.Text = "&Edit";
            this.buttonCrudeAirportSupplierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSupplierEdit.Click += new System.EventHandler(this.buttonCrudeAirportSupplierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.buttonCrudeAirportSupplierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportSupplierAdd);
            this.Controls.Add(this.buttonCrudeAirportSupplierEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportSupplier);
            this.Name = "CrudeAirportSupplierSearch";
            this.Text = "Airport Supplier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportSupplier)).EndInit();
            this.Controls.Add(this.labelAiportSupplierName);
            this.Controls.Add(this.textBoxAiportSupplierName);
            this.Controls.Add(this.labelAirportSupplierCode);
            this.Controls.Add(this.textBoxAirportSupplierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
