namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeNationalityRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeNationalityRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeNationalityRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeNationalityRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeNationalityRef;
        
        private System.Windows.Forms.TextBox textBoxNationalityName;
        
        private System.Windows.Forms.Label labelNationalityName;
        
        private System.Windows.Forms.TextBox textBoxNationality;
        
        private System.Windows.Forms.Label labelNationality;
        
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
            this.buttonCrudeNationalityRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeNationalityRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeNationalityRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeNationalityRef = new System.Windows.Forms.DataGridView();
            this.labelNationalityName = new System.Windows.Forms.Label();
            this.textBoxNationalityName = new System.Windows.Forms.TextBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeNationalityRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelNationalityName
            //
            this.labelNationalityName.AutoSize = true;
            this.labelNationalityName.Location = new System.Drawing.Point(11, 13);
            this.labelNationalityName.Name = "labelNationalityName";
            this.labelNationalityName.Size = new System.Drawing.Size(71, 13);
            this.labelNationalityName.TabIndex = 2;
            this.labelNationalityName.Text = "Nationality Name:";
            //
            //textBoxNationalityName
            //
            this.textBoxNationalityName.Location = new System.Drawing.Point(140, 13);
            this.textBoxNationalityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNationalityName.Name = "textBoxNationalityName";
            this.textBoxNationalityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxNationalityName.TabIndex = 3;
            //
            // labelNationality
            //
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(11, 36);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(71, 13);
            this.labelNationality.TabIndex = 4;
            this.labelNationality.Text = "Nationality:";
            //
            //textBoxNationality
            //
            this.textBoxNationality.Location = new System.Drawing.Point(140, 36);
            this.textBoxNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(250, 20);
            this.textBoxNationality.TabIndex = 5;
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
            // dataGridViewCrudeNationalityRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeNationalityRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeNationalityRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeNationalityRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeNationalityRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeNationalityRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeNationalityRef.Name = "dataGridViewCrudeNationalityRef";
            this.dataGridViewCrudeNationalityRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeNationalityRef.TabIndex = 0;
            this.dataGridViewCrudeNationalityRef.ReadOnly = true;
            this.dataGridViewCrudeNationalityRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeNationalityRef_DoubleClick);
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
            // buttonCrudeNationalityRefSearch
            // 
            this.buttonCrudeNationalityRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeNationalityRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeNationalityRefSearch.Name = "buttonCrudeNationalityRefSearch";
            this.buttonCrudeNationalityRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeNationalityRefSearch.TabIndex = 2;
            this.buttonCrudeNationalityRefSearch.Text = "&Search";
            this.buttonCrudeNationalityRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeNationalityRefSearch.Click += new System.EventHandler(this.buttonCrudeNationalityRefSearch_Click);
            // 
            // buttonCrudeNationalityRefAdd
            // 
            this.buttonCrudeNationalityRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeNationalityRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeNationalityRefAdd.Name = "buttonCrudeNationalityRefAdd";
            this.buttonCrudeNationalityRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeNationalityRefAdd.TabIndex = 3;
            this.buttonCrudeNationalityRefAdd.Text = "&Add";
            this.buttonCrudeNationalityRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeNationalityRefAdd.Click += new System.EventHandler(this.buttonCrudeNationalityRefAdd_Click);
            // 
            // buttonCrudeNationalityRefEdit
            // 
            this.buttonCrudeNationalityRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeNationalityRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeNationalityRefEdit.Name = "buttonCrudeNationalityRefEdit";
            this.buttonCrudeNationalityRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeNationalityRefEdit.TabIndex = 4;
            this.buttonCrudeNationalityRefEdit.Text = "&Edit";
            this.buttonCrudeNationalityRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeNationalityRefEdit.Click += new System.EventHandler(this.buttonCrudeNationalityRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeNationalityRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeNationalityRefAdd);
            this.Controls.Add(this.buttonCrudeNationalityRefEdit);
            this.Controls.Add(this.dataGridViewCrudeNationalityRef);
            this.Name = "CrudeNationalityRefSearch";
            this.Text = "Nationality Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeNationalityRef)).EndInit();
            this.Controls.Add(this.labelNationalityName);
            this.Controls.Add(this.textBoxNationalityName);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.textBoxNationality);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
