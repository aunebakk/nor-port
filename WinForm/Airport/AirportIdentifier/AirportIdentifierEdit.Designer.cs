namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirportIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AirportPicker airportPicker;
        
        private System.Windows.Forms.Label labelAirportPicker;
        
        private AirportIdentifierTypeRefCombo airportIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelAirportIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAirportIdentifierCode;
        
        private System.Windows.Forms.Label labelAirportIdentifierCode;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.Button buttonAirportIdentifierSearch;
        
        private System.Windows.Forms.Button buttonAirportIdentifierAdd;
        
        private System.Windows.Forms.Button buttonAirportIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewAirportIdentifier;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAirportIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonAirportIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonAirportIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewAirportIdentifier = new System.Windows.Forms.DataGridView();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelAirportIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.airportIdentifierTypeRefCombo = new AirportIdentifierTypeRefCombo();
            this.labelAirportIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxAirportIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirportIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 13);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 2;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(161, 13);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(350, 20);
            this.airportPicker.TabIndex = 3;
            //
            // labelAirportIdentifierTypeRefCombo
            //
            this.labelAirportIdentifierTypeRefCombo.AutoSize = true;
            this.labelAirportIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAirportIdentifierTypeRefCombo.Name = "labelAirportIdentifierTypeRefCombo";
            this.labelAirportIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierTypeRefCombo.TabIndex = 4;
            this.labelAirportIdentifierTypeRefCombo.Text = "Airport Identifier Type:";
            //
            //airportIdentifierTypeRefCombo
            //
            this.airportIdentifierTypeRefCombo.Location = new System.Drawing.Point(161, 36);
            this.airportIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportIdentifierTypeRefCombo.Name = "airportIdentifierTypeRefCombo";
            this.airportIdentifierTypeRefCombo.Size = new System.Drawing.Size(350, 20);
            this.airportIdentifierTypeRefCombo.TabIndex = 5;
            //
            // labelAirportIdentifierCode
            //
            this.labelAirportIdentifierCode.AutoSize = true;
            this.labelAirportIdentifierCode.Location = new System.Drawing.Point(11, 59);
            this.labelAirportIdentifierCode.Name = "labelAirportIdentifierCode";
            this.labelAirportIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAirportIdentifierCode.TabIndex = 6;
            this.labelAirportIdentifierCode.Text = "Airport Identifier Code:";
            //
            //textBoxAirportIdentifierCode
            //
            this.textBoxAirportIdentifierCode.Location = new System.Drawing.Point(161, 59);
            this.textBoxAirportIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportIdentifierCode.Name = "textBoxAirportIdentifierCode";
            this.textBoxAirportIdentifierCode.Size = new System.Drawing.Size(350, 20);
            this.textBoxAirportIdentifierCode.TabIndex = 7;
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
            this.userPicker.Size = new System.Drawing.Size(350, 20);
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
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // dataGridViewAirportIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAirportIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAirportIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAirportIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirportIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAirportIdentifier.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewAirportIdentifier.Name = "dataGridViewAirportIdentifier";
            this.dataGridViewAirportIdentifier.Size = new System.Drawing.Size(499, 96);
            this.dataGridViewAirportIdentifier.TabIndex = 0;
            this.dataGridViewAirportIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewAirportIdentifier_DoubleClick);
            // 
            // buttonAirportIdentifierSearch
            // 
            this.buttonAirportIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportIdentifierSearch.Location = new System.Drawing.Point(219, 241);
            this.buttonAirportIdentifierSearch.Name = "buttonAirportIdentifierSearch";
            this.buttonAirportIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportIdentifierSearch.TabIndex = 2;
            this.buttonAirportIdentifierSearch.Text = "&Search";
            this.buttonAirportIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonAirportIdentifierSearch.Click += new System.EventHandler(this.buttonAirportIdentifierSearch_Click);
            // 
            // buttonAirportIdentifierAdd
            // 
            this.buttonAirportIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportIdentifierAdd.Location = new System.Drawing.Point(119, 241);
            this.buttonAirportIdentifierAdd.Name = "buttonAirportIdentifierAdd";
            this.buttonAirportIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportIdentifierAdd.TabIndex = 3;
            this.buttonAirportIdentifierAdd.Text = "&Add";
            this.buttonAirportIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonAirportIdentifierAdd.Click += new System.EventHandler(this.buttonAirportIdentifierAdd_Click);
            // 
            // buttonAirportIdentifierEdit
            // 
            this.buttonAirportIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportIdentifierEdit.Location = new System.Drawing.Point(19, 241);
            this.buttonAirportIdentifierEdit.Name = "buttonAirportIdentifierEdit";
            this.buttonAirportIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportIdentifierEdit.TabIndex = 4;
            this.buttonAirportIdentifierEdit.Text = "&Edit";
            this.buttonAirportIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonAirportIdentifierEdit.Click += new System.EventHandler(this.buttonAirportIdentifierEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(419, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(319, 241);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 269);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAirportIdentifierSearch);
            this.Controls.Add(this.buttonAirportIdentifierAdd);
            this.Controls.Add(this.buttonAirportIdentifierEdit);
            this.Controls.Add(this.dataGridViewAirportIdentifier);
            this.Name = "AirportIdentifierEdit";
            this.Text = "Airport Identifier Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirportIdentifier)).EndInit();
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelAirportIdentifierTypeRefCombo);
            this.Controls.Add(this.airportIdentifierTypeRefCombo);
            this.Controls.Add(this.labelAirportIdentifierCode);
            this.Controls.Add(this.textBoxAirportIdentifierCode);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
