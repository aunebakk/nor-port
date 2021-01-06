namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudePassengerTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudePassengerTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudePassengerTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudePassengerTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudePassengerTypeRef;
        
        private System.Windows.Forms.TextBox textBoxPassengerTypeName;
        
        private System.Windows.Forms.Label labelPassengerTypeName;
        
        private System.Windows.Forms.TextBox textBoxPassengerType;
        
        private System.Windows.Forms.Label labelPassengerType;
        
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
            this.buttonCrudePassengerTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudePassengerTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudePassengerTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudePassengerTypeRef = new System.Windows.Forms.DataGridView();
            this.labelPassengerTypeName = new System.Windows.Forms.Label();
            this.textBoxPassengerTypeName = new System.Windows.Forms.TextBox();
            this.labelPassengerType = new System.Windows.Forms.Label();
            this.textBoxPassengerType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudePassengerTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelPassengerTypeName
            //
            this.labelPassengerTypeName.AutoSize = true;
            this.labelPassengerTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelPassengerTypeName.Name = "labelPassengerTypeName";
            this.labelPassengerTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerTypeName.TabIndex = 2;
            this.labelPassengerTypeName.Text = "Passenger Type Name:";
            //
            //textBoxPassengerTypeName
            //
            this.textBoxPassengerTypeName.Location = new System.Drawing.Point(140, 13);
            this.textBoxPassengerTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassengerTypeName.Name = "textBoxPassengerTypeName";
            this.textBoxPassengerTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerTypeName.TabIndex = 3;
            //
            // labelPassengerType
            //
            this.labelPassengerType.AutoSize = true;
            this.labelPassengerType.Location = new System.Drawing.Point(11, 36);
            this.labelPassengerType.Name = "labelPassengerType";
            this.labelPassengerType.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerType.TabIndex = 4;
            this.labelPassengerType.Text = "Passenger Type:";
            //
            //textBoxPassengerType
            //
            this.textBoxPassengerType.Location = new System.Drawing.Point(140, 36);
            this.textBoxPassengerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassengerType.Name = "textBoxPassengerType";
            this.textBoxPassengerType.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassengerType.TabIndex = 5;
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
            // dataGridViewCrudePassengerTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudePassengerTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudePassengerTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudePassengerTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudePassengerTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudePassengerTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudePassengerTypeRef.Name = "dataGridViewCrudePassengerTypeRef";
            this.dataGridViewCrudePassengerTypeRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudePassengerTypeRef.TabIndex = 0;
            this.dataGridViewCrudePassengerTypeRef.ReadOnly = true;
            this.dataGridViewCrudePassengerTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudePassengerTypeRef_DoubleClick);
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
            // buttonCrudePassengerTypeRefSearch
            // 
            this.buttonCrudePassengerTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudePassengerTypeRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudePassengerTypeRefSearch.Name = "buttonCrudePassengerTypeRefSearch";
            this.buttonCrudePassengerTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudePassengerTypeRefSearch.TabIndex = 2;
            this.buttonCrudePassengerTypeRefSearch.Text = "&Search";
            this.buttonCrudePassengerTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudePassengerTypeRefSearch.Click += new System.EventHandler(this.buttonCrudePassengerTypeRefSearch_Click);
            // 
            // buttonCrudePassengerTypeRefAdd
            // 
            this.buttonCrudePassengerTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudePassengerTypeRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudePassengerTypeRefAdd.Name = "buttonCrudePassengerTypeRefAdd";
            this.buttonCrudePassengerTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudePassengerTypeRefAdd.TabIndex = 3;
            this.buttonCrudePassengerTypeRefAdd.Text = "&Add";
            this.buttonCrudePassengerTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudePassengerTypeRefAdd.Click += new System.EventHandler(this.buttonCrudePassengerTypeRefAdd_Click);
            // 
            // buttonCrudePassengerTypeRefEdit
            // 
            this.buttonCrudePassengerTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudePassengerTypeRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudePassengerTypeRefEdit.Name = "buttonCrudePassengerTypeRefEdit";
            this.buttonCrudePassengerTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudePassengerTypeRefEdit.TabIndex = 4;
            this.buttonCrudePassengerTypeRefEdit.Text = "&Edit";
            this.buttonCrudePassengerTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudePassengerTypeRefEdit.Click += new System.EventHandler(this.buttonCrudePassengerTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudePassengerTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudePassengerTypeRefAdd);
            this.Controls.Add(this.buttonCrudePassengerTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudePassengerTypeRef);
            this.Name = "CrudePassengerTypeRefSearch";
            this.Text = "Passenger Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudePassengerTypeRef)).EndInit();
            this.Controls.Add(this.labelPassengerTypeName);
            this.Controls.Add(this.textBoxPassengerTypeName);
            this.Controls.Add(this.labelPassengerType);
            this.Controls.Add(this.textBoxPassengerType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
