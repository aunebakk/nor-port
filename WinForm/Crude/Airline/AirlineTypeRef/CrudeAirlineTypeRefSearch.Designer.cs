namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAirlineTypeName;
        
        private System.Windows.Forms.Label labelAirlineTypeName;
        
        private System.Windows.Forms.TextBox textBoxAirlineType;
        
        private System.Windows.Forms.Label labelAirlineType;
        
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
            this.buttonCrudeAirlineTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAirlineTypeName = new System.Windows.Forms.Label();
            this.textBoxAirlineTypeName = new System.Windows.Forms.TextBox();
            this.labelAirlineType = new System.Windows.Forms.Label();
            this.textBoxAirlineType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirlineTypeName
            //
            this.labelAirlineTypeName.AutoSize = true;
            this.labelAirlineTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAirlineTypeName.Name = "labelAirlineTypeName";
            this.labelAirlineTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineTypeName.TabIndex = 2;
            this.labelAirlineTypeName.Text = "Airline Type Name:";
            //
            //textBoxAirlineTypeName
            //
            this.textBoxAirlineTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAirlineTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineTypeName.Name = "textBoxAirlineTypeName";
            this.textBoxAirlineTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineTypeName.TabIndex = 3;
            //
            // labelAirlineType
            //
            this.labelAirlineType.AutoSize = true;
            this.labelAirlineType.Location = new System.Drawing.Point(11, 36);
            this.labelAirlineType.Name = "labelAirlineType";
            this.labelAirlineType.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineType.TabIndex = 4;
            this.labelAirlineType.Text = "Airline Type:";
            //
            //textBoxAirlineType
            //
            this.textBoxAirlineType.Location = new System.Drawing.Point(140, 36);
            this.textBoxAirlineType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineType.Name = "textBoxAirlineType";
            this.textBoxAirlineType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineType.TabIndex = 5;
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
            // dataGridViewCrudeAirlineTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirlineTypeRef.Name = "dataGridViewCrudeAirlineTypeRef";
            this.dataGridViewCrudeAirlineTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirlineTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAirlineTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAirlineTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineTypeRef_DoubleClick);
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
            // buttonCrudeAirlineTypeRefSearch
            // 
            this.buttonCrudeAirlineTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeAirlineTypeRefSearch.Name = "buttonCrudeAirlineTypeRefSearch";
            this.buttonCrudeAirlineTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAirlineTypeRefSearch.Text = "&Search";
            this.buttonCrudeAirlineTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAirlineTypeRefSearch_Click);
            // 
            // buttonCrudeAirlineTypeRefAdd
            // 
            this.buttonCrudeAirlineTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeAirlineTypeRefAdd.Name = "buttonCrudeAirlineTypeRefAdd";
            this.buttonCrudeAirlineTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAirlineTypeRefAdd.Text = "&Add";
            this.buttonCrudeAirlineTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAirlineTypeRefAdd_Click);
            // 
            // buttonCrudeAirlineTypeRefEdit
            // 
            this.buttonCrudeAirlineTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeAirlineTypeRefEdit.Name = "buttonCrudeAirlineTypeRefEdit";
            this.buttonCrudeAirlineTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAirlineTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAirlineTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAirlineTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeAirlineTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAirlineTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineTypeRef);
            this.Name = "CrudeAirlineTypeRefSearch";
            this.Text = "Airline Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineTypeRef)).EndInit();
            this.Controls.Add(this.labelAirlineTypeName);
            this.Controls.Add(this.textBoxAirlineTypeName);
            this.Controls.Add(this.labelAirlineType);
            this.Controls.Add(this.textBoxAirlineType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
