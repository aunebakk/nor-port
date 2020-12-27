namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAirlineIdentifierTypeName;
        
        private System.Windows.Forms.Label labelAirlineIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxAirlineIdentifierType;
        
        private System.Windows.Forms.Label labelAirlineIdentifierType;
        
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
            this.buttonCrudeAirlineIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAirlineIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxAirlineIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelAirlineIdentifierType = new System.Windows.Forms.Label();
            this.textBoxAirlineIdentifierType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirlineIdentifierTypeName
            //
            this.labelAirlineIdentifierTypeName.AutoSize = true;
            this.labelAirlineIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAirlineIdentifierTypeName.Name = "labelAirlineIdentifierTypeName";
            this.labelAirlineIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierTypeName.TabIndex = 2;
            this.labelAirlineIdentifierTypeName.Text = "Airline Identifier Type Name:";
            //
            //textBoxAirlineIdentifierTypeName
            //
            this.textBoxAirlineIdentifierTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxAirlineIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineIdentifierTypeName.Name = "textBoxAirlineIdentifierTypeName";
            this.textBoxAirlineIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineIdentifierTypeName.TabIndex = 3;
            //
            // labelAirlineIdentifierType
            //
            this.labelAirlineIdentifierType.AutoSize = true;
            this.labelAirlineIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelAirlineIdentifierType.Name = "labelAirlineIdentifierType";
            this.labelAirlineIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierType.TabIndex = 4;
            this.labelAirlineIdentifierType.Text = "Airline Identifier Type:";
            //
            //textBoxAirlineIdentifierType
            //
            this.textBoxAirlineIdentifierType.Location = new System.Drawing.Point(196, 36);
            this.textBoxAirlineIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineIdentifierType.Name = "textBoxAirlineIdentifierType";
            this.textBoxAirlineIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineIdentifierType.TabIndex = 5;
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
            // dataGridViewCrudeAirlineIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineIdentifierTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirlineIdentifierTypeRef.Name = "dataGridViewCrudeAirlineIdentifierTypeRef";
            this.dataGridViewCrudeAirlineIdentifierTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeAirlineIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAirlineIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAirlineIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineIdentifierTypeRef_DoubleClick);
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
            // buttonCrudeAirlineIdentifierTypeRefSearch
            // 
            this.buttonCrudeAirlineIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineIdentifierTypeRefSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeAirlineIdentifierTypeRefSearch.Name = "buttonCrudeAirlineIdentifierTypeRefSearch";
            this.buttonCrudeAirlineIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAirlineIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeAirlineIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAirlineIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeAirlineIdentifierTypeRefAdd
            // 
            this.buttonCrudeAirlineIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineIdentifierTypeRefAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeAirlineIdentifierTypeRefAdd.Name = "buttonCrudeAirlineIdentifierTypeRefAdd";
            this.buttonCrudeAirlineIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAirlineIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeAirlineIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAirlineIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeAirlineIdentifierTypeRefEdit
            // 
            this.buttonCrudeAirlineIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineIdentifierTypeRefEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeAirlineIdentifierTypeRefEdit.Name = "buttonCrudeAirlineIdentifierTypeRefEdit";
            this.buttonCrudeAirlineIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAirlineIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAirlineIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAirlineIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeAirlineIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAirlineIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineIdentifierTypeRef);
            this.Name = "CrudeAirlineIdentifierTypeRefSearch";
            this.Text = "Airline Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelAirlineIdentifierTypeName);
            this.Controls.Add(this.textBoxAirlineIdentifierTypeName);
            this.Controls.Add(this.labelAirlineIdentifierType);
            this.Controls.Add(this.textBoxAirlineIdentifierType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
