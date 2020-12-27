namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AircraftIdentifierTypeRefCombo aircraftIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAircraftIdentifierCode;
        
        private System.Windows.Forms.Label labelAircraftIdentifierCode;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.Button buttonAircraftIdentifierSearch;
        
        private System.Windows.Forms.Button buttonAircraftIdentifierAdd;
        
        private System.Windows.Forms.Button buttonAircraftIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftIdentifier;
        
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
            this.buttonAircraftIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonAircraftIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonAircraftIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewAircraftIdentifier = new System.Windows.Forms.DataGridView();
            this.labelAircraftIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftIdentifierTypeRefCombo = new AircraftIdentifierTypeRefCombo();
            this.labelAircraftIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxAircraftIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftIdentifier)).BeginInit();
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
            this.aircraftIdentifierTypeRefCombo.Size = new System.Drawing.Size(350, 20);
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
            this.textBoxAircraftIdentifierCode.Size = new System.Drawing.Size(350, 20);
            this.textBoxAircraftIdentifierCode.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(168, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(350, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewAircraftIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftIdentifier.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewAircraftIdentifier.Name = "dataGridViewAircraftIdentifier";
            this.dataGridViewAircraftIdentifier.Size = new System.Drawing.Size(506, 96);
            this.dataGridViewAircraftIdentifier.TabIndex = 0;
            this.dataGridViewAircraftIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewAircraftIdentifier_DoubleClick);
            // 
            // buttonAircraftIdentifierSearch
            // 
            this.buttonAircraftIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftIdentifierSearch.Location = new System.Drawing.Point(226, 218);
            this.buttonAircraftIdentifierSearch.Name = "buttonAircraftIdentifierSearch";
            this.buttonAircraftIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftIdentifierSearch.TabIndex = 2;
            this.buttonAircraftIdentifierSearch.Text = "&Search";
            this.buttonAircraftIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftIdentifierSearch.Click += new System.EventHandler(this.buttonAircraftIdentifierSearch_Click);
            // 
            // buttonAircraftIdentifierAdd
            // 
            this.buttonAircraftIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftIdentifierAdd.Location = new System.Drawing.Point(126, 218);
            this.buttonAircraftIdentifierAdd.Name = "buttonAircraftIdentifierAdd";
            this.buttonAircraftIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftIdentifierAdd.TabIndex = 3;
            this.buttonAircraftIdentifierAdd.Text = "&Add";
            this.buttonAircraftIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonAircraftIdentifierAdd.Click += new System.EventHandler(this.buttonAircraftIdentifierAdd_Click);
            // 
            // buttonAircraftIdentifierEdit
            // 
            this.buttonAircraftIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftIdentifierEdit.Location = new System.Drawing.Point(26, 218);
            this.buttonAircraftIdentifierEdit.Name = "buttonAircraftIdentifierEdit";
            this.buttonAircraftIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftIdentifierEdit.TabIndex = 4;
            this.buttonAircraftIdentifierEdit.Text = "&Edit";
            this.buttonAircraftIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonAircraftIdentifierEdit.Click += new System.EventHandler(this.buttonAircraftIdentifierEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(426, 218);
            
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
            this.buttonSave.Location = new System.Drawing.Point(326, 218);
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
            this.ClientSize = new System.Drawing.Size(530, 246);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAircraftIdentifierSearch);
            this.Controls.Add(this.buttonAircraftIdentifierAdd);
            this.Controls.Add(this.buttonAircraftIdentifierEdit);
            this.Controls.Add(this.dataGridViewAircraftIdentifier);
            this.Name = "AircraftIdentifierEdit";
            this.Text = "Aircraft Identifier Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftIdentifier)).EndInit();
            this.Controls.Add(this.labelAircraftIdentifierTypeRefCombo);
            this.Controls.Add(this.aircraftIdentifierTypeRefCombo);
            this.Controls.Add(this.labelAircraftIdentifierCode);
            this.Controls.Add(this.textBoxAircraftIdentifierCode);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
