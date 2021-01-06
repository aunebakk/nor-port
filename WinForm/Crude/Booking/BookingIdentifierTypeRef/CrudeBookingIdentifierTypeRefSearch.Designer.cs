namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxBookingIdentifierTypeName;
        
        private System.Windows.Forms.Label labelBookingIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxBookingIdentifierType;
        
        private System.Windows.Forms.Label labelBookingIdentifierType;
        
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
            this.buttonCrudeBookingIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelBookingIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelBookingIdentifierType = new System.Windows.Forms.Label();
            this.textBoxBookingIdentifierType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingIdentifierTypeName
            //
            this.labelBookingIdentifierTypeName.AutoSize = true;
            this.labelBookingIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelBookingIdentifierTypeName.Name = "labelBookingIdentifierTypeName";
            this.labelBookingIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingIdentifierTypeName.TabIndex = 2;
            this.labelBookingIdentifierTypeName.Text = "Booking Identifier Type Name:";
            //
            //textBoxBookingIdentifierTypeName
            //
            this.textBoxBookingIdentifierTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxBookingIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingIdentifierTypeName.Name = "textBoxBookingIdentifierTypeName";
            this.textBoxBookingIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingIdentifierTypeName.TabIndex = 3;
            //
            // labelBookingIdentifierType
            //
            this.labelBookingIdentifierType.AutoSize = true;
            this.labelBookingIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelBookingIdentifierType.Name = "labelBookingIdentifierType";
            this.labelBookingIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingIdentifierType.TabIndex = 4;
            this.labelBookingIdentifierType.Text = "Booking Identifier Type:";
            //
            //textBoxBookingIdentifierType
            //
            this.textBoxBookingIdentifierType.Location = new System.Drawing.Point(196, 36);
            this.textBoxBookingIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingIdentifierType.Name = "textBoxBookingIdentifierType";
            this.textBoxBookingIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingIdentifierType.TabIndex = 5;
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
            // dataGridViewCrudeBookingIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingIdentifierTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingIdentifierTypeRef.Name = "dataGridViewCrudeBookingIdentifierTypeRef";
            this.dataGridViewCrudeBookingIdentifierTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeBookingIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeBookingIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeBookingIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingIdentifierTypeRef_DoubleClick);
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
            // buttonCrudeBookingIdentifierTypeRefSearch
            // 
            this.buttonCrudeBookingIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingIdentifierTypeRefSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeBookingIdentifierTypeRefSearch.Name = "buttonCrudeBookingIdentifierTypeRefSearch";
            this.buttonCrudeBookingIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeBookingIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeBookingIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeBookingIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeBookingIdentifierTypeRefAdd
            // 
            this.buttonCrudeBookingIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingIdentifierTypeRefAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeBookingIdentifierTypeRefAdd.Name = "buttonCrudeBookingIdentifierTypeRefAdd";
            this.buttonCrudeBookingIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeBookingIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeBookingIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeBookingIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeBookingIdentifierTypeRefEdit
            // 
            this.buttonCrudeBookingIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingIdentifierTypeRefEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeBookingIdentifierTypeRefEdit.Name = "buttonCrudeBookingIdentifierTypeRefEdit";
            this.buttonCrudeBookingIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeBookingIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeBookingIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeBookingIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeBookingIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeBookingIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingIdentifierTypeRef);
            this.Name = "CrudeBookingIdentifierTypeRefSearch";
            this.Text = "Booking Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelBookingIdentifierTypeName);
            this.Controls.Add(this.textBoxBookingIdentifierTypeName);
            this.Controls.Add(this.labelBookingIdentifierType);
            this.Controls.Add(this.textBoxBookingIdentifierType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
