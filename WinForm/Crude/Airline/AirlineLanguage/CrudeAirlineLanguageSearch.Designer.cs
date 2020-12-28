namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineLanguageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineLanguageSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineLanguageAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineLanguageEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineLanguage;
        
        private System.Windows.Forms.TextBox textBoxAirlineLanguageName;
        
        private System.Windows.Forms.Label labelAirlineLanguageName;
        
        private LanguageRefCombo languageRefCombo;
        
        private System.Windows.Forms.Label labelLanguageRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
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
            this.buttonCrudeAirlineLanguageAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineLanguageEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineLanguageSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineLanguage = new System.Windows.Forms.DataGridView();
            this.labelAirlineLanguageName = new System.Windows.Forms.Label();
            this.textBoxAirlineLanguageName = new System.Windows.Forms.TextBox();
            this.labelLanguageRefCombo = new System.Windows.Forms.Label();
            this.languageRefCombo = new LanguageRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineLanguage)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirlineLanguageName
            //
            this.labelAirlineLanguageName.AutoSize = true;
            this.labelAirlineLanguageName.Location = new System.Drawing.Point(11, 13);
            this.labelAirlineLanguageName.Name = "labelAirlineLanguageName";
            this.labelAirlineLanguageName.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineLanguageName.TabIndex = 2;
            this.labelAirlineLanguageName.Text = "Airline Language Name:";
            //
            //textBoxAirlineLanguageName
            //
            this.textBoxAirlineLanguageName.Location = new System.Drawing.Point(147, 13);
            this.textBoxAirlineLanguageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineLanguageName.Name = "textBoxAirlineLanguageName";
            this.textBoxAirlineLanguageName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineLanguageName.TabIndex = 3;
            //
            // labelLanguageRefCombo
            //
            this.labelLanguageRefCombo.AutoSize = true;
            this.labelLanguageRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelLanguageRefCombo.Name = "labelLanguageRefCombo";
            this.labelLanguageRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelLanguageRefCombo.TabIndex = 4;
            this.labelLanguageRefCombo.Text = "Language:";
            //
            //languageRefCombo
            //
            this.languageRefCombo.Location = new System.Drawing.Point(147, 36);
            this.languageRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.languageRefCombo.Name = "languageRefCombo";
            this.languageRefCombo.Size = new System.Drawing.Size(250, 20);
            this.languageRefCombo.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 82);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 8;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(147, 82);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(147, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeAirlineLanguage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineLanguage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineLanguage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineLanguage.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAirlineLanguage.Name = "dataGridViewCrudeAirlineLanguage";
            this.dataGridViewCrudeAirlineLanguage.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeAirlineLanguage.TabIndex = 0;
            this.dataGridViewCrudeAirlineLanguage.ReadOnly = true;
            this.dataGridViewCrudeAirlineLanguage.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineLanguage_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirlineLanguageSearch
            // 
            this.buttonCrudeAirlineLanguageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineLanguageSearch.Location = new System.Drawing.Point(205, 241);
            this.buttonCrudeAirlineLanguageSearch.Name = "buttonCrudeAirlineLanguageSearch";
            this.buttonCrudeAirlineLanguageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineLanguageSearch.TabIndex = 2;
            this.buttonCrudeAirlineLanguageSearch.Text = "&Search";
            this.buttonCrudeAirlineLanguageSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineLanguageSearch.Click += new System.EventHandler(this.buttonCrudeAirlineLanguageSearch_Click);
            // 
            // buttonCrudeAirlineLanguageAdd
            // 
            this.buttonCrudeAirlineLanguageAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineLanguageAdd.Location = new System.Drawing.Point(105, 241);
            this.buttonCrudeAirlineLanguageAdd.Name = "buttonCrudeAirlineLanguageAdd";
            this.buttonCrudeAirlineLanguageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineLanguageAdd.TabIndex = 3;
            this.buttonCrudeAirlineLanguageAdd.Text = "&Add";
            this.buttonCrudeAirlineLanguageAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineLanguageAdd.Click += new System.EventHandler(this.buttonCrudeAirlineLanguageAdd_Click);
            // 
            // buttonCrudeAirlineLanguageEdit
            // 
            this.buttonCrudeAirlineLanguageEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineLanguageEdit.Location = new System.Drawing.Point(5, 241);
            this.buttonCrudeAirlineLanguageEdit.Name = "buttonCrudeAirlineLanguageEdit";
            this.buttonCrudeAirlineLanguageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineLanguageEdit.TabIndex = 4;
            this.buttonCrudeAirlineLanguageEdit.Text = "&Edit";
            this.buttonCrudeAirlineLanguageEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineLanguageEdit.Click += new System.EventHandler(this.buttonCrudeAirlineLanguageEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 269);
            this.Controls.Add(this.buttonCrudeAirlineLanguageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineLanguageAdd);
            this.Controls.Add(this.buttonCrudeAirlineLanguageEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineLanguage);
            this.Name = "CrudeAirlineLanguageSearch";
            this.Text = "Airline Language Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineLanguage)).EndInit();
            this.Controls.Add(this.labelAirlineLanguageName);
            this.Controls.Add(this.textBoxAirlineLanguageName);
            this.Controls.Add(this.labelLanguageRefCombo);
            this.Controls.Add(this.languageRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
