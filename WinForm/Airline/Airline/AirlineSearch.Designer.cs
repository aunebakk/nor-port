namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirlineSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAirlineSearch;
        
        private System.Windows.Forms.Button buttonAirlineAdd;
        
        private System.Windows.Forms.Button buttonAirlineEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewAirline;
        
        private System.Windows.Forms.TextBox textBoxAirlineName;
        
        private System.Windows.Forms.Label labelAirlineName;
        
        private AirlineTypeRefCombo airlineTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirlineTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLegalName;
        
        private System.Windows.Forms.Label labelLegalName;
        
        private System.Windows.Forms.TextBox textBoxStockMarketSymbol;
        
        private System.Windows.Forms.Label labelStockMarketSymbol;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAircraftCount;
        
        private System.Windows.Forms.Label labelAircraftCount;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
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
            this.buttonAirlineAdd = new System.Windows.Forms.Button();
            this.buttonAirlineEdit = new System.Windows.Forms.Button();
            this.buttonAirlineSearch = new System.Windows.Forms.Button();
            this.dataGridViewAirline = new System.Windows.Forms.DataGridView();
            this.labelAirlineName = new System.Windows.Forms.Label();
            this.textBoxAirlineName = new System.Windows.Forms.TextBox();
            this.labelAirlineTypeRefCombo = new System.Windows.Forms.Label();
            this.airlineTypeRefCombo = new AirlineTypeRefCombo();
            this.labelLegalName = new System.Windows.Forms.Label();
            this.textBoxLegalName = new System.Windows.Forms.TextBox();
            this.labelStockMarketSymbol = new System.Windows.Forms.Label();
            this.textBoxStockMarketSymbol = new System.Windows.Forms.TextBox();
            this.labelAircraftCount = new System.Windows.Forms.Label();
            this.maskedTextBoxAircraftCount = new System.Windows.Forms.MaskedTextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirline)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirlineName
            //
            this.labelAirlineName.AutoSize = true;
            this.labelAirlineName.Location = new System.Drawing.Point(11, 13);
            this.labelAirlineName.Name = "labelAirlineName";
            this.labelAirlineName.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineName.TabIndex = 2;
            this.labelAirlineName.Text = "Airline Name:";
            //
            //textBoxAirlineName
            //
            this.textBoxAirlineName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAirlineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineName.Name = "textBoxAirlineName";
            this.textBoxAirlineName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineName.TabIndex = 3;
            //
            // labelAirlineTypeRefCombo
            //
            this.labelAirlineTypeRefCombo.AutoSize = true;
            this.labelAirlineTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAirlineTypeRefCombo.Name = "labelAirlineTypeRefCombo";
            this.labelAirlineTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineTypeRefCombo.TabIndex = 4;
            this.labelAirlineTypeRefCombo.Text = "Airline Type:";
            //
            //airlineTypeRefCombo
            //
            this.airlineTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.airlineTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlineTypeRefCombo.Name = "airlineTypeRefCombo";
            this.airlineTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.airlineTypeRefCombo.TabIndex = 5;
            //
            // labelLegalName
            //
            this.labelLegalName.AutoSize = true;
            this.labelLegalName.Location = new System.Drawing.Point(11, 59);
            this.labelLegalName.Name = "labelLegalName";
            this.labelLegalName.Size = new System.Drawing.Size(71, 13);
            this.labelLegalName.TabIndex = 6;
            this.labelLegalName.Text = "Legal Name:";
            //
            //textBoxLegalName
            //
            this.textBoxLegalName.Location = new System.Drawing.Point(140, 59);
            this.textBoxLegalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLegalName.Name = "textBoxLegalName";
            this.textBoxLegalName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLegalName.TabIndex = 7;
            //
            // labelStockMarketSymbol
            //
            this.labelStockMarketSymbol.AutoSize = true;
            this.labelStockMarketSymbol.Location = new System.Drawing.Point(11, 82);
            this.labelStockMarketSymbol.Name = "labelStockMarketSymbol";
            this.labelStockMarketSymbol.Size = new System.Drawing.Size(71, 13);
            this.labelStockMarketSymbol.TabIndex = 8;
            this.labelStockMarketSymbol.Text = "Stock Market Symbol:";
            //
            //textBoxStockMarketSymbol
            //
            this.textBoxStockMarketSymbol.Location = new System.Drawing.Point(140, 82);
            this.textBoxStockMarketSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStockMarketSymbol.Name = "textBoxStockMarketSymbol";
            this.textBoxStockMarketSymbol.Size = new System.Drawing.Size(250, 20);
            this.textBoxStockMarketSymbol.TabIndex = 9;
            //
            // labelAircraftCount
            //
            this.labelAircraftCount.AutoSize = true;
            this.labelAircraftCount.Location = new System.Drawing.Point(11, 105);
            this.labelAircraftCount.Name = "labelAircraftCount";
            this.labelAircraftCount.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCount.TabIndex = 10;
            this.labelAircraftCount.Text = "Aircraft Count:";
            //
            //maskedTextBoxAircraftCount
            //
            this.maskedTextBoxAircraftCount.Location = new System.Drawing.Point(140, 105);
            this.maskedTextBoxAircraftCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAircraftCount.Name = "maskedTextBoxAircraftCount";
            this.maskedTextBoxAircraftCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAircraftCount.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // dataGridViewAirline
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAirline.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAirline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAirline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAirline.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewAirline.Name = "dataGridViewAirline";
            this.dataGridViewAirline.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewAirline.TabIndex = 0;
            this.dataGridViewAirline.DoubleClick += new System.EventHandler(this.dataGridViewAirline_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAirlineSearch
            // 
            this.buttonAirlineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirlineSearch.Location = new System.Drawing.Point(198, 287);
            this.buttonAirlineSearch.Name = "buttonAirlineSearch";
            this.buttonAirlineSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAirlineSearch.TabIndex = 2;
            this.buttonAirlineSearch.Text = "&Search";
            this.buttonAirlineSearch.UseVisualStyleBackColor = true;
            this.buttonAirlineSearch.Click += new System.EventHandler(this.buttonAirlineSearch_Click);
            // 
            // buttonAirlineAdd
            // 
            this.buttonAirlineAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirlineAdd.Location = new System.Drawing.Point(98, 287);
            this.buttonAirlineAdd.Name = "buttonAirlineAdd";
            this.buttonAirlineAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAirlineAdd.TabIndex = 3;
            this.buttonAirlineAdd.Text = "&Add";
            this.buttonAirlineAdd.UseVisualStyleBackColor = true;
            this.buttonAirlineAdd.Click += new System.EventHandler(this.buttonAirlineAdd_Click);
            // 
            // buttonAirlineEdit
            // 
            this.buttonAirlineEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirlineEdit.Location = new System.Drawing.Point(-2, 287);
            this.buttonAirlineEdit.Name = "buttonAirlineEdit";
            this.buttonAirlineEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonAirlineEdit.TabIndex = 4;
            this.buttonAirlineEdit.Text = "&Edit";
            this.buttonAirlineEdit.UseVisualStyleBackColor = true;
            this.buttonAirlineEdit.Click += new System.EventHandler(this.buttonAirlineEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 315);
            this.Controls.Add(this.buttonAirlineSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAirlineAdd);
            this.Controls.Add(this.buttonAirlineEdit);
            this.Controls.Add(this.dataGridViewAirline);
            this.Name = "AirlineSearch";
            this.Text = "Airline Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirline)).EndInit();
            this.Controls.Add(this.labelAirlineName);
            this.Controls.Add(this.textBoxAirlineName);
            this.Controls.Add(this.labelAirlineTypeRefCombo);
            this.Controls.Add(this.airlineTypeRefCombo);
            this.Controls.Add(this.labelLegalName);
            this.Controls.Add(this.textBoxLegalName);
            this.Controls.Add(this.labelStockMarketSymbol);
            this.Controls.Add(this.textBoxStockMarketSymbol);
            this.Controls.Add(this.labelAircraftCount);
            this.Controls.Add(this.maskedTextBoxAircraftCount);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
