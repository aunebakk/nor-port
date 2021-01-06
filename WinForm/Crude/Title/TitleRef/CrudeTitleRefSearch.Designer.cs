namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeTitleRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeTitleRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeTitleRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeTitleRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeTitleRef;
        
        private System.Windows.Forms.TextBox textBoxTitleName;
        
        private System.Windows.Forms.Label labelTitleName;
        
        private System.Windows.Forms.TextBox textBoxTitle;
        
        private System.Windows.Forms.Label labelTitle;
        
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
            this.buttonCrudeTitleRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeTitleRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeTitleRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeTitleRef = new System.Windows.Forms.DataGridView();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.textBoxTitleName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeTitleRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelTitleName
            //
            this.labelTitleName.AutoSize = true;
            this.labelTitleName.Location = new System.Drawing.Point(11, 13);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(71, 13);
            this.labelTitleName.TabIndex = 2;
            this.labelTitleName.Text = "Title Name:";
            //
            //textBoxTitleName
            //
            this.textBoxTitleName.Location = new System.Drawing.Point(140, 13);
            this.textBoxTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitleName.Name = "textBoxTitleName";
            this.textBoxTitleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxTitleName.TabIndex = 3;
            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(71, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title:";
            //
            //textBoxTitle
            //
            this.textBoxTitle.Location = new System.Drawing.Point(140, 36);
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxTitle.TabIndex = 5;
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
            // dataGridViewCrudeTitleRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeTitleRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeTitleRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeTitleRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeTitleRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeTitleRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeTitleRef.Name = "dataGridViewCrudeTitleRef";
            this.dataGridViewCrudeTitleRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeTitleRef.TabIndex = 0;
            this.dataGridViewCrudeTitleRef.ReadOnly = true;
            this.dataGridViewCrudeTitleRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeTitleRef_DoubleClick);
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
            // buttonCrudeTitleRefSearch
            // 
            this.buttonCrudeTitleRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeTitleRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeTitleRefSearch.Name = "buttonCrudeTitleRefSearch";
            this.buttonCrudeTitleRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeTitleRefSearch.TabIndex = 2;
            this.buttonCrudeTitleRefSearch.Text = "&Search";
            this.buttonCrudeTitleRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeTitleRefSearch.Click += new System.EventHandler(this.buttonCrudeTitleRefSearch_Click);
            // 
            // buttonCrudeTitleRefAdd
            // 
            this.buttonCrudeTitleRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeTitleRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeTitleRefAdd.Name = "buttonCrudeTitleRefAdd";
            this.buttonCrudeTitleRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeTitleRefAdd.TabIndex = 3;
            this.buttonCrudeTitleRefAdd.Text = "&Add";
            this.buttonCrudeTitleRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeTitleRefAdd.Click += new System.EventHandler(this.buttonCrudeTitleRefAdd_Click);
            // 
            // buttonCrudeTitleRefEdit
            // 
            this.buttonCrudeTitleRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeTitleRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeTitleRefEdit.Name = "buttonCrudeTitleRefEdit";
            this.buttonCrudeTitleRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeTitleRefEdit.TabIndex = 4;
            this.buttonCrudeTitleRefEdit.Text = "&Edit";
            this.buttonCrudeTitleRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeTitleRefEdit.Click += new System.EventHandler(this.buttonCrudeTitleRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeTitleRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeTitleRefAdd);
            this.Controls.Add(this.buttonCrudeTitleRefEdit);
            this.Controls.Add(this.dataGridViewCrudeTitleRef);
            this.Name = "CrudeTitleRefSearch";
            this.Text = "Title Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeTitleRef)).EndInit();
            this.Controls.Add(this.labelTitleName);
            this.Controls.Add(this.textBoxTitleName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
