namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportFacilityTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportFacilityTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportFacilityTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportFacilityTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportFacilityTypeRef;
        
        private System.Windows.Forms.TextBox textBoxAirportFacilityTypeName;
        
        private System.Windows.Forms.Label labelAirportFacilityTypeName;
        
        private System.Windows.Forms.TextBox textBoxAirportFacilityType;
        
        private System.Windows.Forms.Label labelAirportFacilityType;
        
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
            this.buttonCrudeAirportFacilityTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportFacilityTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportFacilityTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportFacilityTypeRef = new System.Windows.Forms.DataGridView();
            this.labelAirportFacilityTypeName = new System.Windows.Forms.Label();
            this.textBoxAirportFacilityTypeName = new System.Windows.Forms.TextBox();
            this.labelAirportFacilityType = new System.Windows.Forms.Label();
            this.textBoxAirportFacilityType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportFacilityTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportFacilityTypeName
            //
            this.labelAirportFacilityTypeName.AutoSize = true;
            this.labelAirportFacilityTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelAirportFacilityTypeName.Name = "labelAirportFacilityTypeName";
            this.labelAirportFacilityTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportFacilityTypeName.TabIndex = 2;
            this.labelAirportFacilityTypeName.Text = "Airport Facility Type Name:";
            //
            //textBoxAirportFacilityTypeName
            //
            this.textBoxAirportFacilityTypeName.Location = new System.Drawing.Point(182, 13);
            this.textBoxAirportFacilityTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportFacilityTypeName.Name = "textBoxAirportFacilityTypeName";
            this.textBoxAirportFacilityTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportFacilityTypeName.TabIndex = 3;
            //
            // labelAirportFacilityType
            //
            this.labelAirportFacilityType.AutoSize = true;
            this.labelAirportFacilityType.Location = new System.Drawing.Point(11, 36);
            this.labelAirportFacilityType.Name = "labelAirportFacilityType";
            this.labelAirportFacilityType.Size = new System.Drawing.Size(71, 13);
            this.labelAirportFacilityType.TabIndex = 4;
            this.labelAirportFacilityType.Text = "Airport Facility Type:";
            //
            //textBoxAirportFacilityType
            //
            this.textBoxAirportFacilityType.Location = new System.Drawing.Point(182, 36);
            this.textBoxAirportFacilityType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportFacilityType.Name = "textBoxAirportFacilityType";
            this.textBoxAirportFacilityType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportFacilityType.TabIndex = 5;
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
            // dataGridViewCrudeAirportFacilityTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportFacilityTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportFacilityTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportFacilityTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportFacilityTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportFacilityTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirportFacilityTypeRef.Name = "dataGridViewCrudeAirportFacilityTypeRef";
            this.dataGridViewCrudeAirportFacilityTypeRef.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeAirportFacilityTypeRef.TabIndex = 0;
            this.dataGridViewCrudeAirportFacilityTypeRef.ReadOnly = true;
            this.dataGridViewCrudeAirportFacilityTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportFacilityTypeRef_DoubleClick);
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
            // buttonCrudeAirportFacilityTypeRefSearch
            // 
            this.buttonCrudeAirportFacilityTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportFacilityTypeRefSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonCrudeAirportFacilityTypeRefSearch.Name = "buttonCrudeAirportFacilityTypeRefSearch";
            this.buttonCrudeAirportFacilityTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportFacilityTypeRefSearch.TabIndex = 2;
            this.buttonCrudeAirportFacilityTypeRefSearch.Text = "&Search";
            this.buttonCrudeAirportFacilityTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportFacilityTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeAirportFacilityTypeRefSearch_Click);
            // 
            // buttonCrudeAirportFacilityTypeRefAdd
            // 
            this.buttonCrudeAirportFacilityTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportFacilityTypeRefAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonCrudeAirportFacilityTypeRefAdd.Name = "buttonCrudeAirportFacilityTypeRefAdd";
            this.buttonCrudeAirportFacilityTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportFacilityTypeRefAdd.TabIndex = 3;
            this.buttonCrudeAirportFacilityTypeRefAdd.Text = "&Add";
            this.buttonCrudeAirportFacilityTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportFacilityTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeAirportFacilityTypeRefAdd_Click);
            // 
            // buttonCrudeAirportFacilityTypeRefEdit
            // 
            this.buttonCrudeAirportFacilityTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportFacilityTypeRefEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonCrudeAirportFacilityTypeRefEdit.Name = "buttonCrudeAirportFacilityTypeRefEdit";
            this.buttonCrudeAirportFacilityTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportFacilityTypeRefEdit.TabIndex = 4;
            this.buttonCrudeAirportFacilityTypeRefEdit.Text = "&Edit";
            this.buttonCrudeAirportFacilityTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportFacilityTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeAirportFacilityTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.buttonCrudeAirportFacilityTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportFacilityTypeRefAdd);
            this.Controls.Add(this.buttonCrudeAirportFacilityTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportFacilityTypeRef);
            this.Name = "CrudeAirportFacilityTypeRefSearch";
            this.Text = "Airport Facility Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportFacilityTypeRef)).EndInit();
            this.Controls.Add(this.labelAirportFacilityTypeName);
            this.Controls.Add(this.textBoxAirportFacilityTypeName);
            this.Controls.Add(this.labelAirportFacilityType);
            this.Controls.Add(this.textBoxAirportFacilityType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
