namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeCountrySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeCountrySearch;
        
        private System.Windows.Forms.Button buttonCrudeCountryAdd;
        
        private System.Windows.Forms.Button buttonCrudeCountryEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeCountry;
        
        private System.Windows.Forms.TextBox textBoxCountryName;
        
        private System.Windows.Forms.Label labelCountryName;
        
        private System.Windows.Forms.TextBox textBoxCountryCode;
        
        private System.Windows.Forms.Label labelCountryCode;
        
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
            this.buttonCrudeCountryAdd = new System.Windows.Forms.Button();
            this.buttonCrudeCountryEdit = new System.Windows.Forms.Button();
            this.buttonCrudeCountrySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeCountry = new System.Windows.Forms.DataGridView();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.labelCountryCode = new System.Windows.Forms.Label();
            this.textBoxCountryCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCountry)).BeginInit();
            this.SuspendLayout();
            //
            // labelCountryName
            //
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(11, 13);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(71, 13);
            this.labelCountryName.TabIndex = 2;
            this.labelCountryName.Text = "Country Name:";
            //
            //textBoxCountryName
            //
            this.textBoxCountryName.Location = new System.Drawing.Point(140, 13);
            this.textBoxCountryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCountryName.TabIndex = 3;
            //
            // labelCountryCode
            //
            this.labelCountryCode.AutoSize = true;
            this.labelCountryCode.Location = new System.Drawing.Point(11, 36);
            this.labelCountryCode.Name = "labelCountryCode";
            this.labelCountryCode.Size = new System.Drawing.Size(71, 13);
            this.labelCountryCode.TabIndex = 4;
            this.labelCountryCode.Text = "Country Code:";
            //
            //textBoxCountryCode
            //
            this.textBoxCountryCode.Location = new System.Drawing.Point(140, 36);
            this.textBoxCountryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountryCode.Name = "textBoxCountryCode";
            this.textBoxCountryCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxCountryCode.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeCountry
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeCountry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeCountry.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeCountry.Name = "dataGridViewCrudeCountry";
            this.dataGridViewCrudeCountry.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeCountry.TabIndex = 0;
            this.dataGridViewCrudeCountry.ReadOnly = true;
            this.dataGridViewCrudeCountry.DoubleClick += new System.EventHandler(this.dataGridViewCrudeCountry_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeCountrySearch
            // 
            this.buttonCrudeCountrySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCountrySearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeCountrySearch.Name = "buttonCrudeCountrySearch";
            this.buttonCrudeCountrySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCountrySearch.TabIndex = 2;
            this.buttonCrudeCountrySearch.Text = "&Search";
            this.buttonCrudeCountrySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeCountrySearch.Click += new System.EventHandler(this.buttonCrudeCountrySearch_Click);
            // 
            // buttonCrudeCountryAdd
            // 
            this.buttonCrudeCountryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCountryAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeCountryAdd.Name = "buttonCrudeCountryAdd";
            this.buttonCrudeCountryAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCountryAdd.TabIndex = 3;
            this.buttonCrudeCountryAdd.Text = "&Add";
            this.buttonCrudeCountryAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeCountryAdd.Click += new System.EventHandler(this.buttonCrudeCountryAdd_Click);
            // 
            // buttonCrudeCountryEdit
            // 
            this.buttonCrudeCountryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCountryEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeCountryEdit.Name = "buttonCrudeCountryEdit";
            this.buttonCrudeCountryEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCountryEdit.TabIndex = 4;
            this.buttonCrudeCountryEdit.Text = "&Edit";
            this.buttonCrudeCountryEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeCountryEdit.Click += new System.EventHandler(this.buttonCrudeCountryEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeCountrySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeCountryAdd);
            this.Controls.Add(this.buttonCrudeCountryEdit);
            this.Controls.Add(this.dataGridViewCrudeCountry);
            this.Name = "CrudeCountrySearch";
            this.Text = "Country Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCountry)).EndInit();
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.labelCountryCode);
            this.Controls.Add(this.textBoxCountryCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
