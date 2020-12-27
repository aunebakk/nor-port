namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftIdentifier;
        
        private AircraftIdentifierTypeRefCombo aircraftIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAircraftIdentifierCode;
        
        private System.Windows.Forms.Label labelAircraftIdentifierCode;
        
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
            this.buttonCrudeAircraftIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftIdentifier = new System.Windows.Forms.DataGridView();
            this.labelAircraftIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftIdentifierTypeRefCombo = new AircraftIdentifierTypeRefCombo();
            this.labelAircraftIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxAircraftIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftIdentifierTypeRefCombo
            //
            this.labelAircraftIdentifierTypeRefCombo.AutoSize = true;
            this.labelAircraftIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftIdentifierTypeRefCombo.Name = "labelAircraftIdentifierTypeRefCombo";
            this.labelAircraftIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftIdentifierTypeRefCombo.TabIndex = 2;
            this.labelAircraftIdentifierTypeRefCombo.Text = "Aircraft Identifier Type:";
            //
            //aircraftIdentifierTypeRefCombo
            //
            this.aircraftIdentifierTypeRefCombo.Location = new System.Drawing.Point(168, 13);
            this.aircraftIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftIdentifierTypeRefCombo.Name = "aircraftIdentifierTypeRefCombo";
            this.aircraftIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelAircraftIdentifierCode
            //
            this.labelAircraftIdentifierCode.AutoSize = true;
            this.labelAircraftIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftIdentifierCode.Name = "labelAircraftIdentifierCode";
            this.labelAircraftIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftIdentifierCode.TabIndex = 4;
            this.labelAircraftIdentifierCode.Text = "Aircraft Identifier Code:";
            //
            //textBoxAircraftIdentifierCode
            //
            this.textBoxAircraftIdentifierCode.Location = new System.Drawing.Point(168, 36);
            this.textBoxAircraftIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftIdentifierCode.Name = "textBoxAircraftIdentifierCode";
            this.textBoxAircraftIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftIdentifierCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
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
            this.userPicker.Location = new System.Drawing.Point(168, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeAircraftIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftIdentifier.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAircraftIdentifier.Name = "dataGridViewCrudeAircraftIdentifier";
            this.dataGridViewCrudeAircraftIdentifier.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeAircraftIdentifier.TabIndex = 0;
            this.dataGridViewCrudeAircraftIdentifier.ReadOnly = true;
            this.dataGridViewCrudeAircraftIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftIdentifierSearch
            // 
            this.buttonCrudeAircraftIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftIdentifierSearch.Location = new System.Drawing.Point(226, 218);
            this.buttonCrudeAircraftIdentifierSearch.Name = "buttonCrudeAircraftIdentifierSearch";
            this.buttonCrudeAircraftIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftIdentifierSearch.TabIndex = 2;
            this.buttonCrudeAircraftIdentifierSearch.Text = "&Search";
            this.buttonCrudeAircraftIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeAircraftIdentifierSearch_Click);
            // 
            // buttonCrudeAircraftIdentifierAdd
            // 
            this.buttonCrudeAircraftIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftIdentifierAdd.Location = new System.Drawing.Point(126, 218);
            this.buttonCrudeAircraftIdentifierAdd.Name = "buttonCrudeAircraftIdentifierAdd";
            this.buttonCrudeAircraftIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftIdentifierAdd.TabIndex = 3;
            this.buttonCrudeAircraftIdentifierAdd.Text = "&Add";
            this.buttonCrudeAircraftIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeAircraftIdentifierAdd_Click);
            // 
            // buttonCrudeAircraftIdentifierEdit
            // 
            this.buttonCrudeAircraftIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftIdentifierEdit.Location = new System.Drawing.Point(26, 218);
            this.buttonCrudeAircraftIdentifierEdit.Name = "buttonCrudeAircraftIdentifierEdit";
            this.buttonCrudeAircraftIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftIdentifierEdit.TabIndex = 4;
            this.buttonCrudeAircraftIdentifierEdit.Text = "&Edit";
            this.buttonCrudeAircraftIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeAircraftIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 246);
            this.Controls.Add(this.buttonCrudeAircraftIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftIdentifierAdd);
            this.Controls.Add(this.buttonCrudeAircraftIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftIdentifier);
            this.Name = "CrudeAircraftIdentifierSearch";
            this.Text = "Aircraft Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftIdentifier)).EndInit();
            this.Controls.Add(this.labelAircraftIdentifierTypeRefCombo);
            this.Controls.Add(this.aircraftIdentifierTypeRefCombo);
            this.Controls.Add(this.labelAircraftIdentifierCode);
            this.Controls.Add(this.textBoxAircraftIdentifierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
