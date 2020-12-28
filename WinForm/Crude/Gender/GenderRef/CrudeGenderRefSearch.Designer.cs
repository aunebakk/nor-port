namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeGenderRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeGenderRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeGenderRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeGenderRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeGenderRef;
        
        private System.Windows.Forms.TextBox textBoxGenderName;
        
        private System.Windows.Forms.Label labelGenderName;
        
        private System.Windows.Forms.TextBox textBoxGender;
        
        private System.Windows.Forms.Label labelGender;
        
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
            this.buttonCrudeGenderRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeGenderRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeGenderRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeGenderRef = new System.Windows.Forms.DataGridView();
            this.labelGenderName = new System.Windows.Forms.Label();
            this.textBoxGenderName = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeGenderRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelGenderName
            //
            this.labelGenderName.AutoSize = true;
            this.labelGenderName.Location = new System.Drawing.Point(11, 13);
            this.labelGenderName.Name = "labelGenderName";
            this.labelGenderName.Size = new System.Drawing.Size(71, 13);
            this.labelGenderName.TabIndex = 2;
            this.labelGenderName.Text = "Gender Name:";
            //
            //textBoxGenderName
            //
            this.textBoxGenderName.Location = new System.Drawing.Point(140, 13);
            this.textBoxGenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGenderName.Name = "textBoxGenderName";
            this.textBoxGenderName.Size = new System.Drawing.Size(250, 20);
            this.textBoxGenderName.TabIndex = 3;
            //
            // labelGender
            //
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(11, 36);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(71, 13);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender:";
            //
            //textBoxGender
            //
            this.textBoxGender.Location = new System.Drawing.Point(140, 36);
            this.textBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(250, 20);
            this.textBoxGender.TabIndex = 5;
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
            // dataGridViewCrudeGenderRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeGenderRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeGenderRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeGenderRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeGenderRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeGenderRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeGenderRef.Name = "dataGridViewCrudeGenderRef";
            this.dataGridViewCrudeGenderRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeGenderRef.TabIndex = 0;
            this.dataGridViewCrudeGenderRef.ReadOnly = true;
            this.dataGridViewCrudeGenderRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeGenderRef_DoubleClick);
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
            // buttonCrudeGenderRefSearch
            // 
            this.buttonCrudeGenderRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeGenderRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeGenderRefSearch.Name = "buttonCrudeGenderRefSearch";
            this.buttonCrudeGenderRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeGenderRefSearch.TabIndex = 2;
            this.buttonCrudeGenderRefSearch.Text = "&Search";
            this.buttonCrudeGenderRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeGenderRefSearch.Click += new System.EventHandler(this.buttonCrudeGenderRefSearch_Click);
            // 
            // buttonCrudeGenderRefAdd
            // 
            this.buttonCrudeGenderRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeGenderRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeGenderRefAdd.Name = "buttonCrudeGenderRefAdd";
            this.buttonCrudeGenderRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeGenderRefAdd.TabIndex = 3;
            this.buttonCrudeGenderRefAdd.Text = "&Add";
            this.buttonCrudeGenderRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeGenderRefAdd.Click += new System.EventHandler(this.buttonCrudeGenderRefAdd_Click);
            // 
            // buttonCrudeGenderRefEdit
            // 
            this.buttonCrudeGenderRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeGenderRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeGenderRefEdit.Name = "buttonCrudeGenderRefEdit";
            this.buttonCrudeGenderRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeGenderRefEdit.TabIndex = 4;
            this.buttonCrudeGenderRefEdit.Text = "&Edit";
            this.buttonCrudeGenderRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeGenderRefEdit.Click += new System.EventHandler(this.buttonCrudeGenderRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeGenderRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeGenderRefAdd);
            this.Controls.Add(this.buttonCrudeGenderRefEdit);
            this.Controls.Add(this.dataGridViewCrudeGenderRef);
            this.Name = "CrudeGenderRefSearch";
            this.Text = "Gender Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeGenderRef)).EndInit();
            this.Controls.Add(this.labelGenderName);
            this.Controls.Add(this.textBoxGenderName);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
