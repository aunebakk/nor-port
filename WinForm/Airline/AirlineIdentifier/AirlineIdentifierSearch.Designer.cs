namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirlineIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAirlineIdentifierSearch;
        
        private System.Windows.Forms.Button buttonAirlineIdentifierAdd;
        
        private System.Windows.Forms.Button buttonAirlineIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewAirlineIdentifier;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
        private AirlineIdentifierTypeRefCombo airlineIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirlineIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAirlineIdentifierCode;
        
        private System.Windows.Forms.Label labelAirlineIdentifierCode;
        
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
            this.buttonAirlineIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonAirlineIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonAirlineIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewAirlineIdentifier = new System.Windows.Forms.DataGridView();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelAirlineIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.airlineIdentifierTypeRefCombo = new AirlineIdentifierTypeRefCombo();
            this.labelAirlineIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxAirlineIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlineIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 13);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 2;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(161, 13);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 3;
            //
            // labelAirlineIdentifierTypeRefCombo
            //
            this.labelAirlineIdentifierTypeRefCombo.AutoSize = true;
            this.labelAirlineIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAirlineIdentifierTypeRefCombo.Name = "labelAirlineIdentifierTypeRefCombo";
            this.labelAirlineIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierTypeRefCombo.TabIndex = 4;
            this.labelAirlineIdentifierTypeRefCombo.Text = "Airline Identifier Type:";
            //
            //airlineIdentifierTypeRefCombo
            //
            this.airlineIdentifierTypeRefCombo.Location = new System.Drawing.Point(161, 36);
            this.airlineIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlineIdentifierTypeRefCombo.Name = "airlineIdentifierTypeRefCombo";
            this.airlineIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.airlineIdentifierTypeRefCombo.TabIndex = 5;
            //
            // labelAirlineIdentifierCode
            //
            this.labelAirlineIdentifierCode.AutoSize = true;
            this.labelAirlineIdentifierCode.Location = new System.Drawing.Point(11, 59);
            this.labelAirlineIdentifierCode.Name = "labelAirlineIdentifierCode";
            this.labelAirlineIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierCode.TabIndex = 6;
            this.labelAirlineIdentifierCode.Text = "Airline Identifier Code:";
            //
            //textBoxAirlineIdentifierCode
            //
            this.textBoxAirlineIdentifierCode.Location = new System.Drawing.Point(161, 59);
            this.textBoxAirlineIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineIdentifierCode.Name = "textBoxAirlineIdentifierCode";
            this.textBoxAirlineIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineIdentifierCode.TabIndex = 7;
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
            this.userPicker.Location = new System.Drawing.Point(161, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // dataGridViewAirlineIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAirlineIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAirlineIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAirlineIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirlineIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAirlineIdentifier.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewAirlineIdentifier.Name = "dataGridViewAirlineIdentifier";
            this.dataGridViewAirlineIdentifier.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewAirlineIdentifier.TabIndex = 0;
            this.dataGridViewAirlineIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewAirlineIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAirlineIdentifierSearch
            // 
            this.buttonAirlineIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirlineIdentifierSearch.Location = new System.Drawing.Point(219, 241);
            this.buttonAirlineIdentifierSearch.Name = "buttonAirlineIdentifierSearch";
            this.buttonAirlineIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAirlineIdentifierSearch.TabIndex = 2;
            this.buttonAirlineIdentifierSearch.Text = "&Search";
            this.buttonAirlineIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonAirlineIdentifierSearch.Click += new System.EventHandler(this.buttonAirlineIdentifierSearch_Click);
            // 
            // buttonAirlineIdentifierAdd
            // 
            this.buttonAirlineIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirlineIdentifierAdd.Location = new System.Drawing.Point(119, 241);
            this.buttonAirlineIdentifierAdd.Name = "buttonAirlineIdentifierAdd";
            this.buttonAirlineIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAirlineIdentifierAdd.TabIndex = 3;
            this.buttonAirlineIdentifierAdd.Text = "&Add";
            this.buttonAirlineIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonAirlineIdentifierAdd.Click += new System.EventHandler(this.buttonAirlineIdentifierAdd_Click);
            // 
            // buttonAirlineIdentifierEdit
            // 
            this.buttonAirlineIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirlineIdentifierEdit.Location = new System.Drawing.Point(19, 241);
            this.buttonAirlineIdentifierEdit.Name = "buttonAirlineIdentifierEdit";
            this.buttonAirlineIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonAirlineIdentifierEdit.TabIndex = 4;
            this.buttonAirlineIdentifierEdit.Text = "&Edit";
            this.buttonAirlineIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonAirlineIdentifierEdit.Click += new System.EventHandler(this.buttonAirlineIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.buttonAirlineIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAirlineIdentifierAdd);
            this.Controls.Add(this.buttonAirlineIdentifierEdit);
            this.Controls.Add(this.dataGridViewAirlineIdentifier);
            this.Name = "AirlineIdentifierSearch";
            this.Text = "Airline Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlineIdentifier)).EndInit();
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelAirlineIdentifierTypeRefCombo);
            this.Controls.Add(this.airlineIdentifierTypeRefCombo);
            this.Controls.Add(this.labelAirlineIdentifierCode);
            this.Controls.Add(this.textBoxAirlineIdentifierCode);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
