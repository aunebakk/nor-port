namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeLanguageRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeLanguageRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeLanguageRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeLanguageRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeLanguageRef;
        
        private System.Windows.Forms.TextBox textBoxLanguageName;
        
        private System.Windows.Forms.Label labelLanguageName;
        
        private System.Windows.Forms.TextBox textBoxLanguage;
        
        private System.Windows.Forms.Label labelLanguage;
        
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
            this.buttonCrudeLanguageRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeLanguageRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeLanguageRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeLanguageRef = new System.Windows.Forms.DataGridView();
            this.labelLanguageName = new System.Windows.Forms.Label();
            this.textBoxLanguageName = new System.Windows.Forms.TextBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLanguageRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelLanguageName
            //
            this.labelLanguageName.AutoSize = true;
            this.labelLanguageName.Location = new System.Drawing.Point(11, 13);
            this.labelLanguageName.Name = "labelLanguageName";
            this.labelLanguageName.Size = new System.Drawing.Size(71, 13);
            this.labelLanguageName.TabIndex = 2;
            this.labelLanguageName.Text = "Language Name:";
            //
            //textBoxLanguageName
            //
            this.textBoxLanguageName.Location = new System.Drawing.Point(140, 13);
            this.textBoxLanguageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguageName.Name = "textBoxLanguageName";
            this.textBoxLanguageName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLanguageName.TabIndex = 3;
            //
            // labelLanguage
            //
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(11, 36);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(71, 13);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Language:";
            //
            //textBoxLanguage
            //
            this.textBoxLanguage.Location = new System.Drawing.Point(140, 36);
            this.textBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(250, 20);
            this.textBoxLanguage.TabIndex = 5;
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
            // dataGridViewCrudeLanguageRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeLanguageRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeLanguageRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeLanguageRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeLanguageRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeLanguageRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeLanguageRef.Name = "dataGridViewCrudeLanguageRef";
            this.dataGridViewCrudeLanguageRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeLanguageRef.TabIndex = 0;
            this.dataGridViewCrudeLanguageRef.ReadOnly = true;
            this.dataGridViewCrudeLanguageRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeLanguageRef_DoubleClick);
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
            // buttonCrudeLanguageRefSearch
            // 
            this.buttonCrudeLanguageRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLanguageRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeLanguageRefSearch.Name = "buttonCrudeLanguageRefSearch";
            this.buttonCrudeLanguageRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLanguageRefSearch.TabIndex = 2;
            this.buttonCrudeLanguageRefSearch.Text = "&Search";
            this.buttonCrudeLanguageRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeLanguageRefSearch.Click += new System.EventHandler(this.buttonCrudeLanguageRefSearch_Click);
            // 
            // buttonCrudeLanguageRefAdd
            // 
            this.buttonCrudeLanguageRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLanguageRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeLanguageRefAdd.Name = "buttonCrudeLanguageRefAdd";
            this.buttonCrudeLanguageRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLanguageRefAdd.TabIndex = 3;
            this.buttonCrudeLanguageRefAdd.Text = "&Add";
            this.buttonCrudeLanguageRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeLanguageRefAdd.Click += new System.EventHandler(this.buttonCrudeLanguageRefAdd_Click);
            // 
            // buttonCrudeLanguageRefEdit
            // 
            this.buttonCrudeLanguageRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLanguageRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeLanguageRefEdit.Name = "buttonCrudeLanguageRefEdit";
            this.buttonCrudeLanguageRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLanguageRefEdit.TabIndex = 4;
            this.buttonCrudeLanguageRefEdit.Text = "&Edit";
            this.buttonCrudeLanguageRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeLanguageRefEdit.Click += new System.EventHandler(this.buttonCrudeLanguageRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeLanguageRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeLanguageRefAdd);
            this.Controls.Add(this.buttonCrudeLanguageRefEdit);
            this.Controls.Add(this.dataGridViewCrudeLanguageRef);
            this.Name = "CrudeLanguageRefSearch";
            this.Text = "Language Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLanguageRef)).EndInit();
            this.Controls.Add(this.labelLanguageName);
            this.Controls.Add(this.textBoxLanguageName);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
