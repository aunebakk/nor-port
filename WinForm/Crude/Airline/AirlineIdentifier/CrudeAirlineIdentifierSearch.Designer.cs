namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineIdentifier;
        
        private AirlineIdentifierTypeRefCombo airlineIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirlineIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAirlineIdentifierCode;
        
        private System.Windows.Forms.Label labelAirlineIdentifierCode;
        
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
            this.buttonCrudeAirlineIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineIdentifier = new System.Windows.Forms.DataGridView();
            this.labelAirlineIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.airlineIdentifierTypeRefCombo = new AirlineIdentifierTypeRefCombo();
            this.labelAirlineIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxAirlineIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirlineIdentifierTypeRefCombo
            //
            this.labelAirlineIdentifierTypeRefCombo.AutoSize = true;
            this.labelAirlineIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAirlineIdentifierTypeRefCombo.Name = "labelAirlineIdentifierTypeRefCombo";
            this.labelAirlineIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierTypeRefCombo.TabIndex = 2;
            this.labelAirlineIdentifierTypeRefCombo.Text = "Airline Identifier Type:";
            //
            //airlineIdentifierTypeRefCombo
            //
            this.airlineIdentifierTypeRefCombo.Location = new System.Drawing.Point(161, 13);
            this.airlineIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlineIdentifierTypeRefCombo.Name = "airlineIdentifierTypeRefCombo";
            this.airlineIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.airlineIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelAirlineIdentifierCode
            //
            this.labelAirlineIdentifierCode.AutoSize = true;
            this.labelAirlineIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelAirlineIdentifierCode.Name = "labelAirlineIdentifierCode";
            this.labelAirlineIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAirlineIdentifierCode.TabIndex = 4;
            this.labelAirlineIdentifierCode.Text = "Airline Identifier Code:";
            //
            //textBoxAirlineIdentifierCode
            //
            this.textBoxAirlineIdentifierCode.Location = new System.Drawing.Point(161, 36);
            this.textBoxAirlineIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirlineIdentifierCode.Name = "textBoxAirlineIdentifierCode";
            this.textBoxAirlineIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirlineIdentifierCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
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
            this.airlinePicker.Location = new System.Drawing.Point(161, 82);
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
            this.userPicker.Location = new System.Drawing.Point(161, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeAirlineIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineIdentifier.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAirlineIdentifier.Name = "dataGridViewCrudeAirlineIdentifier";
            this.dataGridViewCrudeAirlineIdentifier.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeAirlineIdentifier.TabIndex = 0;
            this.dataGridViewCrudeAirlineIdentifier.ReadOnly = true;
            this.dataGridViewCrudeAirlineIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineIdentifier_DoubleClick);
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
            // buttonCrudeAirlineIdentifierSearch
            // 
            this.buttonCrudeAirlineIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineIdentifierSearch.Location = new System.Drawing.Point(219, 241);
            this.buttonCrudeAirlineIdentifierSearch.Name = "buttonCrudeAirlineIdentifierSearch";
            this.buttonCrudeAirlineIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineIdentifierSearch.TabIndex = 2;
            this.buttonCrudeAirlineIdentifierSearch.Text = "&Search";
            this.buttonCrudeAirlineIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeAirlineIdentifierSearch_Click);
            // 
            // buttonCrudeAirlineIdentifierAdd
            // 
            this.buttonCrudeAirlineIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineIdentifierAdd.Location = new System.Drawing.Point(119, 241);
            this.buttonCrudeAirlineIdentifierAdd.Name = "buttonCrudeAirlineIdentifierAdd";
            this.buttonCrudeAirlineIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineIdentifierAdd.TabIndex = 3;
            this.buttonCrudeAirlineIdentifierAdd.Text = "&Add";
            this.buttonCrudeAirlineIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeAirlineIdentifierAdd_Click);
            // 
            // buttonCrudeAirlineIdentifierEdit
            // 
            this.buttonCrudeAirlineIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineIdentifierEdit.Location = new System.Drawing.Point(19, 241);
            this.buttonCrudeAirlineIdentifierEdit.Name = "buttonCrudeAirlineIdentifierEdit";
            this.buttonCrudeAirlineIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineIdentifierEdit.TabIndex = 4;
            this.buttonCrudeAirlineIdentifierEdit.Text = "&Edit";
            this.buttonCrudeAirlineIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeAirlineIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.buttonCrudeAirlineIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineIdentifierAdd);
            this.Controls.Add(this.buttonCrudeAirlineIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineIdentifier);
            this.Name = "CrudeAirlineIdentifierSearch";
            this.Text = "Airline Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineIdentifier)).EndInit();
            this.Controls.Add(this.labelAirlineIdentifierTypeRefCombo);
            this.Controls.Add(this.airlineIdentifierTypeRefCombo);
            this.Controls.Add(this.labelAirlineIdentifierCode);
            this.Controls.Add(this.textBoxAirlineIdentifierCode);
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
