namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportIdentifier;
        
        private AirportIdentifierTypeRefCombo airportIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirportIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAirportIdentifierCode;
        
        private System.Windows.Forms.Label labelAirportIdentifierCode;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirportPicker airportPicker;
        
        private System.Windows.Forms.Label labelAirportPicker;
        
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
            this.buttonCrudeAirportIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportIdentifier = new System.Windows.Forms.DataGridView();
            this.labelAirportIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.airportIdentifierTypeRefCombo = new AirportIdentifierTypeRefCombo();
            this.labelAirportIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxAirportIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportIdentifierTypeRefCombo
            //
            this.labelAirportIdentifierTypeRefCombo.AutoSize = true;
            this.labelAirportIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAirportIdentifierTypeRefCombo.Name = "labelAirportIdentifierTypeRefCombo";
            this.labelAirportIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierTypeRefCombo.TabIndex = 2;
            this.labelAirportIdentifierTypeRefCombo.Text = "Airport Identifier Type:";
            //
            //airportIdentifierTypeRefCombo
            //
            this.airportIdentifierTypeRefCombo.Location = new System.Drawing.Point(161, 13);
            this.airportIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportIdentifierTypeRefCombo.Name = "airportIdentifierTypeRefCombo";
            this.airportIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.airportIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelAirportIdentifierCode
            //
            this.labelAirportIdentifierCode.AutoSize = true;
            this.labelAirportIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelAirportIdentifierCode.Name = "labelAirportIdentifierCode";
            this.labelAirportIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierCode.TabIndex = 4;
            this.labelAirportIdentifierCode.Text = "Airport Identifier Code:";
            //
            //textBoxAirportIdentifierCode
            //
            this.textBoxAirportIdentifierCode.Location = new System.Drawing.Point(161, 36);
            this.textBoxAirportIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportIdentifierCode.Name = "textBoxAirportIdentifierCode";
            this.textBoxAirportIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportIdentifierCode.TabIndex = 5;
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
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 82);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 8;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(161, 82);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(250, 20);
            this.airportPicker.TabIndex = 9;
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
            // dataGridViewCrudeAirportIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportIdentifier.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeAirportIdentifier.Name = "dataGridViewCrudeAirportIdentifier";
            this.dataGridViewCrudeAirportIdentifier.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeAirportIdentifier.TabIndex = 0;
            this.dataGridViewCrudeAirportIdentifier.ReadOnly = true;
            this.dataGridViewCrudeAirportIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportIdentifier_DoubleClick);
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
            // buttonCrudeAirportIdentifierSearch
            // 
            this.buttonCrudeAirportIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportIdentifierSearch.Location = new System.Drawing.Point(219, 241);
            this.buttonCrudeAirportIdentifierSearch.Name = "buttonCrudeAirportIdentifierSearch";
            this.buttonCrudeAirportIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportIdentifierSearch.TabIndex = 2;
            this.buttonCrudeAirportIdentifierSearch.Text = "&Search";
            this.buttonCrudeAirportIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeAirportIdentifierSearch_Click);
            // 
            // buttonCrudeAirportIdentifierAdd
            // 
            this.buttonCrudeAirportIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportIdentifierAdd.Location = new System.Drawing.Point(119, 241);
            this.buttonCrudeAirportIdentifierAdd.Name = "buttonCrudeAirportIdentifierAdd";
            this.buttonCrudeAirportIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportIdentifierAdd.TabIndex = 3;
            this.buttonCrudeAirportIdentifierAdd.Text = "&Add";
            this.buttonCrudeAirportIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeAirportIdentifierAdd_Click);
            // 
            // buttonCrudeAirportIdentifierEdit
            // 
            this.buttonCrudeAirportIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportIdentifierEdit.Location = new System.Drawing.Point(19, 241);
            this.buttonCrudeAirportIdentifierEdit.Name = "buttonCrudeAirportIdentifierEdit";
            this.buttonCrudeAirportIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportIdentifierEdit.TabIndex = 4;
            this.buttonCrudeAirportIdentifierEdit.Text = "&Edit";
            this.buttonCrudeAirportIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeAirportIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.buttonCrudeAirportIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportIdentifierAdd);
            this.Controls.Add(this.buttonCrudeAirportIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportIdentifier);
            this.Name = "CrudeAirportIdentifierSearch";
            this.Text = "Airport Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportIdentifier)).EndInit();
            this.Controls.Add(this.labelAirportIdentifierTypeRefCombo);
            this.Controls.Add(this.airportIdentifierTypeRefCombo);
            this.Controls.Add(this.labelAirportIdentifierCode);
            this.Controls.Add(this.textBoxAirportIdentifierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
